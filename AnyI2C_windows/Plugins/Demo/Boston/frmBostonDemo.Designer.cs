namespace BostonDemo
{
    partial class frmBostonDemo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.scrollbarFreq = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFreq = new System.Windows.Forms.Label();
            this.groupPWM1 = new System.Windows.Forms.GroupBox();
            this.scrollbarOn = new System.Windows.Forms.HScrollBar();
            this.lbOn = new System.Windows.Forms.Label();
            this.scrollBarOff = new System.Windows.Forms.HScrollBar();
            this.lbOff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLed = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupPWM1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(197, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 651;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(372, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 52);
            this.groupBox4.TabIndex = 487;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GroupBox2";
            // 
            // numPort
            // 
            this.numPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPort.Location = new System.Drawing.Point(11, 21);
            this.numPort.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(82, 35);
            this.numPort.TabIndex = 490;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(172, 68);
            this.GroupBox1.TabIndex = 646;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Hardware Address";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Location = new System.Drawing.Point(372, 84);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 52);
            this.GroupBox2.TabIndex = 487;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "GroupBox2";
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddress.Location = new System.Drawing.Point(11, 21);
            this.numAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(82, 35);
            this.numAddress.TabIndex = 490;
            this.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAddress.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(9, 180);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 647;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // scrollbarFreq
            // 
            this.scrollbarFreq.LargeChange = 1;
            this.scrollbarFreq.Location = new System.Drawing.Point(39, 37);
            this.scrollbarFreq.Maximum = 255;
            this.scrollbarFreq.Minimum = 1;
            this.scrollbarFreq.Name = "scrollbarFreq";
            this.scrollbarFreq.Size = new System.Drawing.Size(179, 18);
            this.scrollbarFreq.TabIndex = 652;
            this.scrollbarFreq.Value = 1;
            this.scrollbarFreq.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPCS0_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 653;
            this.label1.Text = "LED";
            // 
            // lbFreq
            // 
            this.lbFreq.AutoSize = true;
            this.lbFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFreq.Location = new System.Drawing.Point(263, 40);
            this.lbFreq.Name = "lbFreq";
            this.lbFreq.Size = new System.Drawing.Size(15, 15);
            this.lbFreq.TabIndex = 654;
            this.lbFreq.Text = "0";
            // 
            // groupPWM1
            // 
            this.groupPWM1.Controls.Add(this.lbFreq);
            this.groupPWM1.Controls.Add(this.scrollbarFreq);
            this.groupPWM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPWM1.Location = new System.Drawing.Point(12, 111);
            this.groupPWM1.Name = "groupPWM1";
            this.groupPWM1.Size = new System.Drawing.Size(305, 66);
            this.groupPWM1.TabIndex = 656;
            this.groupPWM1.TabStop = false;
            this.groupPWM1.Text = "PWM Freqence";
            // 
            // scrollbarOn
            // 
            this.scrollbarOn.LargeChange = 1;
            this.scrollbarOn.Location = new System.Drawing.Point(415, 111);
            this.scrollbarOn.Maximum = 4095;
            this.scrollbarOn.Name = "scrollbarOn";
            this.scrollbarOn.Size = new System.Drawing.Size(127, 17);
            this.scrollbarOn.TabIndex = 652;
            this.scrollbarOn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollbarOn_Scroll);
            // 
            // lbOn
            // 
            this.lbOn.AutoSize = true;
            this.lbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOn.Location = new System.Drawing.Point(562, 114);
            this.lbOn.Name = "lbOn";
            this.lbOn.Size = new System.Drawing.Size(15, 15);
            this.lbOn.TabIndex = 654;
            this.lbOn.Text = "0";
            // 
            // scrollBarOff
            // 
            this.scrollBarOff.LargeChange = 1;
            this.scrollBarOff.Location = new System.Drawing.Point(415, 169);
            this.scrollBarOff.Maximum = 4095;
            this.scrollBarOff.Name = "scrollBarOff";
            this.scrollBarOff.Size = new System.Drawing.Size(127, 17);
            this.scrollBarOff.TabIndex = 652;
            this.scrollBarOff.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarOff_Scroll);
            // 
            // lbOff
            // 
            this.lbOff.AutoSize = true;
            this.lbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOff.Location = new System.Drawing.Point(562, 172);
            this.lbOff.Name = "lbOff";
            this.lbOff.Size = new System.Drawing.Size(15, 15);
            this.lbOff.TabIndex = 654;
            this.lbOff.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 654;
            this.label7.Text = "On";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 654;
            this.label8.Text = "Off";
            // 
            // cmbLed
            // 
            this.cmbLed.FormattingEnabled = true;
            this.cmbLed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "All"});
            this.cmbLed.Location = new System.Drawing.Point(442, 32);
            this.cmbLed.Name = "cmbLed";
            this.cmbLed.Size = new System.Drawing.Size(121, 21);
            this.cmbLed.TabIndex = 657;
            this.cmbLed.SelectedIndexChanged += new System.EventHandler(this.cmbLed_SelectedIndexChanged);
            // 
            // frmI2CPWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 260);
            this.Controls.Add(this.cmbLed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOn);
            this.Controls.Add(this.groupPWM1);
            this.Controls.Add(this.scrollBarOff);
            this.Controls.Add(this.scrollbarOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CPWM";
            this.Text = "PCA9685 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupPWM1.ResumeLayout(false);
            this.groupPWM1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
        private System.Windows.Forms.HScrollBar scrollbarFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFreq;
        private System.Windows.Forms.GroupBox groupPWM1;
        private System.Windows.Forms.HScrollBar scrollbarOn;
        private System.Windows.Forms.Label lbOn;
        private System.Windows.Forms.HScrollBar scrollBarOff;
        private System.Windows.Forms.Label lbOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLed;
    }
}