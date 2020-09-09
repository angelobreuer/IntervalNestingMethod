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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculationPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formularStatusLabel = new System.Windows.Forms.Label();
            this.formularTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.calculationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(0, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 160);
            this.label4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calculationPanel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.formularStatusLabel);
            this.panel1.Controls.Add(this.formularTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(738, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 391);
            this.panel1.TabIndex = 16;
            // 
            // calculationPanel
            // 
            this.calculationPanel.Controls.Add(this.label3);
            this.calculationPanel.Controls.Add(this.trackBar1);
            this.calculationPanel.Controls.Add(this.button3);
            this.calculationPanel.Controls.Add(this.button2);
            this.calculationPanel.Controls.Add(this.button1);
            this.calculationPanel.Enabled = false;
            this.calculationPanel.Location = new System.Drawing.Point(12, 108);
            this.calculationPanel.Name = "calculationPanel";
            this.calculationPanel.Size = new System.Drawing.Size(362, 120);
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(7, 51);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(349, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Weiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "f(x) = ";
            // 
            // formularStatusLabel
            // 
            this.formularStatusLabel.AutoSize = true;
            this.formularStatusLabel.Location = new System.Drawing.Point(12, 65);
            this.formularStatusLabel.Name = "formularStatusLabel";
            this.formularStatusLabel.Size = new System.Drawing.Size(126, 15);
            this.formularStatusLabel.TabIndex = 4;
            this.formularStatusLabel.Text = "Bitte Formel eingeben.";
            // 
            // formularTextBox
            // 
            this.formularTextBox.Location = new System.Drawing.Point(57, 36);
            this.formularTextBox.Name = "formularTextBox";
            this.formularTextBox.Size = new System.Drawing.Size(317, 23);
            this.formularTextBox.TabIndex = 3;
            this.formularTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.calculationPanel.ResumeLayout(false);
            this.calculationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox calculationPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label formularStatusLabel;
        private System.Windows.Forms.TextBox formularTextBox;
        private System.Windows.Forms.Label label3;
    }
}