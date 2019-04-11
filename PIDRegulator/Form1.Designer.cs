namespace PIDRegulator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.PortListComboBox = new System.Windows.Forms.ComboBox();
			this.KpNumeric = new System.Windows.Forms.NumericUpDown();
			this.KiNumeric = new System.Windows.Forms.NumericUpDown();
			this.KdNumeric = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.OffsetUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LimitNumeric = new System.Windows.Forms.NumericUpDown();
			this.ButtonUp = new System.Windows.Forms.Button();
			this.ButtonRight = new System.Windows.Forms.Button();
			this.ButtonLeft = new System.Windows.Forms.Button();
			this.ButtonDown = new System.Windows.Forms.Button();
			this.DefaultButton = new System.Windows.Forms.Button();
			this.ControlAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.KpNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KiNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KdNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OffsetUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LimitNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ControlAngleNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// ConnectButton
			// 
			this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ConnectButton.Location = new System.Drawing.Point(542, 72);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(117, 24);
			this.ConnectButton.TabIndex = 0;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// PortListComboBox
			// 
			this.PortListComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PortListComboBox.FormattingEnabled = true;
			this.PortListComboBox.Location = new System.Drawing.Point(542, 12);
			this.PortListComboBox.Name = "PortListComboBox";
			this.PortListComboBox.Size = new System.Drawing.Size(117, 24);
			this.PortListComboBox.TabIndex = 1;
			// 
			// KpNumeric
			// 
			this.KpNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.KpNumeric.DecimalPlaces = 2;
			this.KpNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.KpNumeric.Location = new System.Drawing.Point(539, 316);
			this.KpNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.KpNumeric.Name = "KpNumeric";
			this.KpNumeric.Size = new System.Drawing.Size(120, 22);
			this.KpNumeric.TabIndex = 2;
			this.KpNumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// KiNumeric
			// 
			this.KiNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.KiNumeric.DecimalPlaces = 2;
			this.KiNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.KiNumeric.Location = new System.Drawing.Point(539, 366);
			this.KiNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.KiNumeric.Name = "KiNumeric";
			this.KiNumeric.Size = new System.Drawing.Size(120, 22);
			this.KiNumeric.TabIndex = 3;
			this.KiNumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// KdNumeric
			// 
			this.KdNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.KdNumeric.DecimalPlaces = 2;
			this.KdNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.KdNumeric.Location = new System.Drawing.Point(539, 416);
			this.KdNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.KdNumeric.Name = "KdNumeric";
			this.KdNumeric.Size = new System.Drawing.Size(120, 22);
			this.KdNumeric.TabIndex = 4;
			this.KdNumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(539, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kp";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(539, 346);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ki";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(539, 396);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kd";
			// 
			// UpdateButton
			// 
			this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UpdateButton.Location = new System.Drawing.Point(542, 42);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(117, 24);
			this.UpdateButton.TabIndex = 8;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			legend1.Position.Auto = false;
			legend1.Position.Height = 10.82353F;
			legend1.Position.Width = 21.41757F;
			legend1.Position.X = 75.58244F;
			legend1.Position.Y = 3F;
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(12, 12);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "OutputSeries";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "AngleSeries";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(521, 429);
			this.chart1.TabIndex = 9;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// OffsetUpDown
			// 
			this.OffsetUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OffsetUpDown.DecimalPlaces = 3;
			this.OffsetUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.OffsetUpDown.Location = new System.Drawing.Point(539, 271);
			this.OffsetUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
			this.OffsetUpDown.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
			this.OffsetUpDown.Name = "OffsetUpDown";
			this.OffsetUpDown.Size = new System.Drawing.Size(120, 22);
			this.OffsetUpDown.TabIndex = 10;
			this.OffsetUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(539, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Offset";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(539, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Limit";
			// 
			// LimitNumeric
			// 
			this.LimitNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LimitNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.LimitNumeric.Location = new System.Drawing.Point(539, 226);
			this.LimitNumeric.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
			this.LimitNumeric.Name = "LimitNumeric";
			this.LimitNumeric.Size = new System.Drawing.Size(120, 22);
			this.LimitNumeric.TabIndex = 12;
			this.LimitNumeric.ValueChanged += new System.EventHandler(this.ValueChanged);
			// 
			// ButtonUp
			// 
			this.ButtonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonUp.Location = new System.Drawing.Point(770, 144);
			this.ButtonUp.Name = "ButtonUp";
			this.ButtonUp.Size = new System.Drawing.Size(75, 68);
			this.ButtonUp.TabIndex = 15;
			this.ButtonUp.Text = "Up";
			this.ButtonUp.UseVisualStyleBackColor = true;
			this.ButtonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseDown);
			this.ButtonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseUp);
			// 
			// ButtonRight
			// 
			this.ButtonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonRight.Location = new System.Drawing.Point(851, 218);
			this.ButtonRight.Name = "ButtonRight";
			this.ButtonRight.Size = new System.Drawing.Size(75, 68);
			this.ButtonRight.TabIndex = 16;
			this.ButtonRight.Text = "Right";
			this.ButtonRight.UseVisualStyleBackColor = true;
			this.ButtonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseDown);
			this.ButtonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseUp);
			// 
			// ButtonLeft
			// 
			this.ButtonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonLeft.Location = new System.Drawing.Point(689, 218);
			this.ButtonLeft.Name = "ButtonLeft";
			this.ButtonLeft.Size = new System.Drawing.Size(75, 68);
			this.ButtonLeft.TabIndex = 17;
			this.ButtonLeft.Text = "Left";
			this.ButtonLeft.UseVisualStyleBackColor = true;
			this.ButtonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseDown);
			this.ButtonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseUp);
			// 
			// ButtonDown
			// 
			this.ButtonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonDown.Location = new System.Drawing.Point(770, 292);
			this.ButtonDown.Name = "ButtonDown";
			this.ButtonDown.Size = new System.Drawing.Size(75, 68);
			this.ButtonDown.TabIndex = 18;
			this.ButtonDown.Text = "Down";
			this.ButtonDown.UseVisualStyleBackColor = true;
			this.ButtonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseDown);
			this.ButtonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonUp_MouseUp);
			// 
			// DefaultButton
			// 
			this.DefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DefaultButton.Location = new System.Drawing.Point(539, 172);
			this.DefaultButton.Name = "DefaultButton";
			this.DefaultButton.Size = new System.Drawing.Size(117, 24);
			this.DefaultButton.TabIndex = 19;
			this.DefaultButton.Text = "Default";
			this.DefaultButton.UseVisualStyleBackColor = true;
			this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
			// 
			// ControlAngleNumericUpDown
			// 
			this.ControlAngleNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlAngleNumericUpDown.DecimalPlaces = 1;
			this.ControlAngleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ControlAngleNumericUpDown.Location = new System.Drawing.Point(536, 135);
			this.ControlAngleNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ControlAngleNumericUpDown.Name = "ControlAngleNumericUpDown";
			this.ControlAngleNumericUpDown.Size = new System.Drawing.Size(120, 22);
			this.ControlAngleNumericUpDown.TabIndex = 20;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 453);
			this.Controls.Add(this.ControlAngleNumericUpDown);
			this.Controls.Add(this.DefaultButton);
			this.Controls.Add(this.ButtonDown);
			this.Controls.Add(this.ButtonLeft);
			this.Controls.Add(this.ButtonRight);
			this.Controls.Add(this.ButtonUp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.LimitNumeric);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OffsetUpDown);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.KdNumeric);
			this.Controls.Add(this.KiNumeric);
			this.Controls.Add(this.KpNumeric);
			this.Controls.Add(this.PortListComboBox);
			this.Controls.Add(this.ConnectButton);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Form1";
			this.Text = "PID Regulator";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.KpNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KiNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KdNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OffsetUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LimitNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ControlAngleNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConnectButton;
		private System.Windows.Forms.ComboBox PortListComboBox;
		private System.Windows.Forms.NumericUpDown KpNumeric;
		private System.Windows.Forms.NumericUpDown KiNumeric;
		private System.Windows.Forms.NumericUpDown KdNumeric;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.NumericUpDown OffsetUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown LimitNumeric;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonDown;
		private System.Windows.Forms.Button DefaultButton;
		private System.Windows.Forms.NumericUpDown ControlAngleNumericUpDown;
	}
}

