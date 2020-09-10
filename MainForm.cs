namespace IntervalNestingMethod
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using NCalc;
    using ScottPlot;

    /// <summary>
    ///     The initial main form.
    /// </summary>
    public partial class MainForm : Form
    {
        private IntervalHistory _intervalHistory;
        private double _lastSample;
        private PlottableVLine _lastValueLine;
        private NullPointFinder _nullPointFinder;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Renders the next null-point guess.
        /// </summary>
        private void FindNullPoint()
        {
            if (_nullPointFinder is null)
            {
                return;
            }

            var nullPointFound = _nullPointFinder.NextSample(out var value);

            if (_lastValueLine != null)
            {
                formsPlot1.plt.Remove(_lastValueLine);
                formsPlot1.plt.PlotVLine(_lastSample, Color.LightBlue);
            }

            _lastValueLine = formsPlot1.plt.PlotVLine(value, Color.Red);
            _lastSample = value;

            formsPlot1.Render();

            if (nullPointFound)
            {
                label4.Text = "Nullstelle: " + value;
                calculationPanel.Enabled = false;
                timer1.Enabled = false;
            }
            else if (_nullPointFinder.Tolerance == 0.0D)
            {
                label4.Text = "Nullstelle konnte nicht gefunden werden\n- Nullstelle liegt außerhalb des Bereiches!";
                calculationPanel.Enabled = false;
                timer1.Enabled = false;
            }
            else
            {
                _intervalHistory.Push(_nullPointFinder.Minimum, _nullPointFinder.Maximum);
                label4.Text = $"{_intervalHistory}\n\nFehlertoleranz: ± {_nullPointFinder.Tolerance.ToString("F20").TrimEnd('0')}";
            }
        }

        /// <summary>
        ///     An event handler that is invoked when the formula text box was edited.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void FormulaTextBox_TextChanged(object sender, EventArgs eventArgs)
        {
            Rerender();
        }

        private void MaximumRangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (maximumRangeNumericUpDown.Value < minimumRangeNumericUpDown.Value)
            {
                minimumRangeNumericUpDown.Value = maximumRangeNumericUpDown.Value;
            }

            Rerender();
        }

        private void MinimumRangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minimumRangeNumericUpDown.Value > maximumRangeNumericUpDown.Value)
            {
                maximumRangeNumericUpDown.Value = minimumRangeNumericUpDown.Value;
            }

            Rerender();
        }

        /// <summary>
        ///     An event handler that is invoked when the next button is clicked.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void NextButton_Click(object sender, EventArgs eventArgs)
        {
            FindNullPoint();
        }

        private void Rerender()
        {
            if (string.IsNullOrWhiteSpace(formulaTextBox.Text))
            {
                formularStatusLabel.Text = "Bitte Formel eingeben.";
                formularStatusLabel.ForeColor = Color.Red;
                calculationPanel.Enabled = false;
                return;
            }

            var expression = new Expression(formulaTextBox.Text, EvaluateOptions.NoCache);

            if (expression.HasErrors())
            {
                formularStatusLabel.Text = "Fehler in der Formel: " + expression.Error;
                formularStatusLabel.ForeColor = Color.Red;
                calculationPanel.Enabled = false;
                return;
            }

            formularStatusLabel.Text = "Formel ist gültig.";
            formularStatusLabel.ForeColor = Color.Green;

            double Evaluate(double value)
            {
                if (expression is null)
                {
                    return 0D;
                }

                expression.Parameters["x"] = value;

                try
                {
                    if (expression.Evaluate() is double result)
                    {
                        return result;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        owner: this,
                        text: exception.Message,
                        caption: "Wert der Formel konnte nicht aufgelöst werden!",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);

                    formularStatusLabel.Text = "Wert der Formel konnte nicht aufgelöst werden!";
                    calculationPanel.Enabled = false;
                    expression = null;
                }

                return 0D;
            }

            _nullPointFinder = new NullPointFinder(
                func: Evaluate,
                minimum: (double)minimumRangeNumericUpDown.Value,
                maximum: (double)maximumRangeNumericUpDown.Value);

            _intervalHistory = new IntervalHistory();
            _lastValueLine = null;

            calculationPanel.Enabled = true;

            formsPlot1.plt.Clear();
            formsPlot1.plt.PlotFunction(x => Evaluate(x));
            formsPlot1.plt.PlotVLine(0, Color.Green);
            formsPlot1.plt.PlotHLine(0, Color.Green);
            formsPlot1.Render();
        }

        /// <summary>
        ///     An event handler that is invoked when the timer ticks.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void SpeedTrackBar_Scroll(object sender, EventArgs eventArgs)
        {
            timer1.Interval = speedTrackBar.Value;
            label3.Text = $"Geschwindigkeit: {speedTrackBar.Value}ms pro Update";
        }

        /// <summary>
        ///     An event handler that is invoked when the start button is clicked.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void StartButton_Click(object sender, EventArgs eventArgs)
        {
            timer1.Enabled = true;
        }

        /// <summary>
        ///     An event handler that is invoked when the stop button is clicked.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void StopButton_Click(object sender, EventArgs eventArgs)
        {
            timer1.Enabled = false;
        }

        /// <summary>
        ///     An event handler that is invoked when the timer ticks.
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="eventArgs">the event arguments passed with the event</param>
        private void Timer1_Tick(object sender, EventArgs eventArgs)
        {
            FindNullPoint();
        }
    }
}
