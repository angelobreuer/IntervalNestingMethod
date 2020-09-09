namespace IntervalNestingMethod
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using NCalc;
    using ScottPlot;

    public partial class MainForm : Form
    {
        private IntervalHistory _intervalHistory;
        private double _lastSample;
        private PlottableVLine _lastValueLine;
        private NullPointFinder _nullPointFinder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FindNullPoint();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(formularTextBox.Text))
            {
                formularStatusLabel.Text = "Bitte Formel eingeben.";
                calculationPanel.Enabled = false;
                return;
            }

            var expression = new Expression(formularTextBox.Text, EvaluateOptions.NoCache);

            if (expression.HasErrors())
            {
                formularStatusLabel.Text = "Fehler in der Formel: " + expression.Error;
                calculationPanel.Enabled = false;
                return;
            }

            formularStatusLabel.Text = "Formel ist gültig.";

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

            _nullPointFinder = new NullPointFinder(Evaluate);
            _intervalHistory = new IntervalHistory();
            _lastValueLine = null;

            calculationPanel.Enabled = true;

            formsPlot1.plt.Clear();
            formsPlot1.plt.PlotFunction(x => Evaluate(x));
            formsPlot1.plt.PlotVLine(0, Color.Green);
            formsPlot1.plt.PlotHLine(0, Color.Green);
            formsPlot1.Render();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            FindNullPoint();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label3.Text = $"Geschwindigkeit: {trackBar1.Value}ms pro Update";
        }
    }
}
