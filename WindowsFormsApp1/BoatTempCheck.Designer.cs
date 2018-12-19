namespace WindowsFormsApp1
{
    partial class BoatTempCheck
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
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            this.button1 = new System.Windows.Forms.Button();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTmpBoat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTmpShed = new System.Windows.Forms.TextBox();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeatBox = new System.Windows.Forms.TextBox();
            this.aGauge3 = new System.Windows.Forms.AGauge();
            this.txtHygBoat = new System.Windows.Forms.TextBox();
            this.txtHy1Shed = new System.Windows.Forms.TextBox();
            this.txtHy2Shed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            aGaugeRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange4.EndValue = 0F;
            aGaugeRange4.InnerRadius = 30;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange1";
            aGaugeRange4.OuterRadius = 50;
            aGaugeRange4.StartValue = 30F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange4);
            this.aGauge1.Location = new System.Drawing.Point(12, 2);
            this.aGauge1.MaxValue = 40F;
            this.aGauge1.MinValue = -40F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 1;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTmpBoat
            // 
            this.txtTmpBoat.Enabled = false;
            this.txtTmpBoat.Location = new System.Drawing.Point(89, 161);
            this.txtTmpBoat.Name = "txtTmpBoat";
            this.txtTmpBoat.ReadOnly = true;
            this.txtTmpBoat.Size = new System.Drawing.Size(46, 20);
            this.txtTmpBoat.TabIndex = 2;
            this.txtTmpBoat.Text = "txtTmpBoat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Båt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skjul";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTmpShed
            // 
            this.txtTmpShed.Enabled = false;
            this.txtTmpShed.Location = new System.Drawing.Point(353, 161);
            this.txtTmpShed.Name = "txtTmpShed";
            this.txtTmpShed.ReadOnly = true;
            this.txtTmpShed.Size = new System.Drawing.Size(46, 20);
            this.txtTmpShed.TabIndex = 5;
            this.txtTmpShed.Text = "txtTmpShed";
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            aGaugeRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange5.EndValue = 0F;
            aGaugeRange5.InnerRadius = 30;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange1";
            aGaugeRange5.OuterRadius = 50;
            aGaugeRange5.StartValue = 30F;
            this.aGauge2.GaugeRanges.Add(aGaugeRange5);
            this.aGauge2.Location = new System.Drawing.Point(276, 2);
            this.aGauge2.MaxValue = 40F;
            this.aGauge2.MinValue = -40F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(205, 180);
            this.aGauge2.TabIndex = 4;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Värmeskåp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHeatBox
            // 
            this.txtHeatBox.Enabled = false;
            this.txtHeatBox.Location = new System.Drawing.Point(618, 161);
            this.txtHeatBox.Name = "txtHeatBox";
            this.txtHeatBox.ReadOnly = true;
            this.txtHeatBox.Size = new System.Drawing.Size(46, 20);
            this.txtHeatBox.TabIndex = 8;
            this.txtHeatBox.Text = "txtHeatBox";
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Center = new System.Drawing.Point(100, 100);
            aGaugeRange6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange6.EndValue = 0F;
            aGaugeRange6.InnerRadius = 30;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRange1";
            aGaugeRange6.OuterRadius = 50;
            aGaugeRange6.StartValue = 30F;
            this.aGauge3.GaugeRanges.Add(aGaugeRange6);
            this.aGauge3.Location = new System.Drawing.Point(541, 2);
            this.aGauge3.MaxValue = 40F;
            this.aGauge3.MinValue = -40F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorTicks = 9;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(205, 180);
            this.aGauge3.TabIndex = 7;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // txtHygBoat
            // 
            this.txtHygBoat.Enabled = false;
            this.txtHygBoat.Location = new System.Drawing.Point(89, 207);
            this.txtHygBoat.Name = "txtHygBoat";
            this.txtHygBoat.ReadOnly = true;
            this.txtHygBoat.Size = new System.Drawing.Size(46, 20);
            this.txtHygBoat.TabIndex = 10;
            this.txtHygBoat.Text = "txtHygBoat";
            // 
            // txtHy1Shed
            // 
            this.txtHy1Shed.Enabled = false;
            this.txtHy1Shed.Location = new System.Drawing.Point(318, 207);
            this.txtHy1Shed.Name = "txtHy1Shed";
            this.txtHy1Shed.ReadOnly = true;
            this.txtHy1Shed.Size = new System.Drawing.Size(46, 20);
            this.txtHy1Shed.TabIndex = 11;
            this.txtHy1Shed.Text = "txtHy1Shed";
            // 
            // txtHy2Shed
            // 
            this.txtHy2Shed.Enabled = false;
            this.txtHy2Shed.Location = new System.Drawing.Point(388, 207);
            this.txtHy2Shed.Name = "txtHy2Shed";
            this.txtHy2Shed.ReadOnly = true;
            this.txtHy2Shed.Size = new System.Drawing.Size(46, 20);
            this.txtHy2Shed.TabIndex = 12;
            this.txtHy2Shed.Text = "txtHy2Shed";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "open ssh key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ppk";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Open ssh|*.ppk|All|*.*";
            this.openFileDialog1.Title = "Select openssh ppk file";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 256);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(259, 50);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "2018-12-18 03:39:33 Temp -12.3^ LOW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ " +
    "LOW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ LOW, turning OFF";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 256);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(259, 50);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "2018-12-18 03:39:33 Temp 12.3^ LOW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ L" +
    "OW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ LOW, turning OFF";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(542, 256);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(259, 50);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "2018-12-18 03:39:33 Temp 12.3^ LOW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ L" +
    "OW, turning OFF\r\n2018-12-18 03:39:33 Temp 12.3^ LOW, turning OFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kompresorrsavfuktare";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Värmare";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sorbtionsavfuktare";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoatTempCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtHy2Shed);
            this.Controls.Add(this.txtHy1Shed);
            this.Controls.Add(this.txtHygBoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeatBox);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTmpShed);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTmpBoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aGauge1);
            this.Name = "BoatTempCheck";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Boat Temperature Checker";
            this.Load += new System.EventHandler(this.BoatTempCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTmpBoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTmpShed;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeatBox;
        private System.Windows.Forms.AGauge aGauge3;
        private System.Windows.Forms.TextBox txtHygBoat;
        private System.Windows.Forms.TextBox txtHy1Shed;
        private System.Windows.Forms.TextBox txtHy2Shed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

