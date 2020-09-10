namespace IntervalNestingMethod
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox1;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.minimumRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formulaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formularStatusLabel = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculationPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumRangeNumericUpDown)).BeginInit();
            groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.calculationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.flowLayoutPanel1);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(0, 89);
            groupBox2.Margin = new System.Windows.Forms.Padding(8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(383, 50);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Suchbereich";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(label5);
            this.flowLayoutPanel1.Controls.Add(this.minimumRangeNumericUpDown);
            this.flowLayoutPanel1.Controls.Add(label1);
            this.flowLayoutPanel1.Controls.Add(this.maximumRangeNumericUpDown);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 26);
            label5.TabIndex = 3;
            label5.Text = "X1:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimumRangeNumericUpDown
            // 
            this.minimumRangeNumericUpDown.Location = new System.Drawing.Point(35, 3);
            this.minimumRangeNumericUpDown.Maximum = new decimal(new int[] {
            -169738240,
            -513,
            536870911,
            0});
            this.minimumRangeNumericUpDown.Minimum = new decimal(new int[] {
            -169738240,
            -513,
            536870911,
            -2147483648});
            this.minimumRangeNumericUpDown.Name = "minimumRangeNumericUpDown";
            this.minimumRangeNumericUpDown.Size = new System.Drawing.Size(118, 23);
            this.minimumRangeNumericUpDown.TabIndex = 0;
            this.minimumRangeNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.minimumRangeNumericUpDown.ValueChanged += new System.EventHandler(this.MinimumRangeNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(159, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 23);
            label1.TabIndex = 2;
            label1.Text = "X2:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maximumRangeNumericUpDown
            // 
            this.maximumRangeNumericUpDown.Location = new System.Drawing.Point(194, 3);
            this.maximumRangeNumericUpDown.Maximum = new decimal(new int[] {
            -169738240,
            -513,
            536870911,
            0});
            this.maximumRangeNumericUpDown.Minimum = new decimal(new int[] {
            -169738240,
            -513,
            536870911,
            -2147483648});
            this.maximumRangeNumericUpDown.Name = "maximumRangeNumericUpDown";
            this.maximumRangeNumericUpDown.Size = new System.Drawing.Size(113, 23);
            this.maximumRangeNumericUpDown.TabIndex = 1;
            this.maximumRangeNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maximumRangeNumericUpDown.ValueChanged += new System.EventHandler(this.MaximumRangeNumericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.panel2);
            groupBox1.Controls.Add(this.formularStatusLabel);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(8);
            groupBox1.Size = new System.Drawing.Size(383, 89);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formulaTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 26);
            this.panel2.TabIndex = 5;
            // 
            // formulaTextBox
            // 
            this.formulaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formulaTextBox.Location = new System.Drawing.Point(39, 0);
            this.formulaTextBox.Name = "formulaTextBox";
            this.formulaTextBox.Size = new System.Drawing.Size(328, 23);
            this.formulaTextBox.TabIndex = 3;
            this.formulaTextBox.TextChanged += new System.EventHandler(this.FormulaTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "f(x) = ";
            // 
            // formularStatusLabel
            // 
            this.formularStatusLabel.AutoSize = true;
            this.formularStatusLabel.Location = new System.Drawing.Point(8, 62);
            this.formularStatusLabel.Name = "formularStatusLabel";
            this.formularStatusLabel.Size = new System.Drawing.Size(126, 15);
            this.formularStatusLabel.TabIndex = 4;
            this.formularStatusLabel.Text = "Bitte Formel eingeben.";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(738, 391);
            this.formsPlot1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 132);
            this.label4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.calculationPanel);
            this.panel1.Controls.Add(groupBox2);
            this.panel1.Controls.Add(groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(738, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 391);
            this.panel1.TabIndex = 16;
            // 
            // calculationPanel
            // 
            this.calculationPanel.Controls.Add(this.label3);
            this.calculationPanel.Controls.Add(this.speedTrackBar);
            this.calculationPanel.Controls.Add(this.stopButton);
            this.calculationPanel.Controls.Add(this.startButton);
            this.calculationPanel.Controls.Add(this.nextButton);
            this.calculationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calculationPanel.Enabled = false;
            this.calculationPanel.Location = new System.Drawing.Point(0, 139);
            this.calculationPanel.Margin = new System.Windows.Forms.Padding(8);
            this.calculationPanel.Name = "calculationPanel";
            this.calculationPanel.Size = new System.Drawing.Size(383, 120);
            this.calculationPanel.TabIndex = 11;
            this.calculationPanel.TabStop = false;
            this.calculationPanel.Text = "Berechnungspanel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geschwindigkeit: 1000ms pro Update";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(7, 51);
            this.speedTrackBar.Maximum = 1000;
            this.speedTrackBar.Minimum = 1;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedTrackBar.Size = new System.Drawing.Size(349, 45);
            this.speedTrackBar.TabIndex = 14;
            this.speedTrackBar.Value = 1000;
            this.speedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(168, 22);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(87, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(8, 22);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Weiter";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 391);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Nullstellenberechner mit Hilfe des Intervallschachtelungsverfahren";
            groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimumRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumRangeNumericUpDown)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.calculationPanel.ResumeLayout(false);
            this.calculationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox calculationPanel;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label formularStatusLabel;
        private System.Windows.Forms.TextBox formulaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown minimumRangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown maximumRangeNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}