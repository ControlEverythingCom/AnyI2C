namespace PCA9530_I2CPWM
{
    partial class frmI2CPWM
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
            this.hScrollBarPCS0 = new System.Windows.Forms.HScrollBar();
            this.hScrollBarPWM0 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPCS0 = new System.Windows.Forms.Label();
            this.lbPWM0 = new System.Windows.Forms.Label();
            this.cmbLed0 = new System.Windows.Forms.ComboBox();
            this.cmbLed1 = new System.Windows.Forms.ComboBox();
            this.groupPWM1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbPWM1 = new System.Windows.Forms.Label();
            this.lbPCS1 = new System.Windows.Forms.Label();
            this.hScrollBarPWM1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBarPCS1 = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupPWM1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(179, 12);
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
            this.GroupBox1.Size = new System.Drawing.Size(161, 68);
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
            96,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(9, 212);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 647;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // hScrollBarPCS0
            // 
            this.hScrollBarPCS0.LargeChange = 1;
            this.hScrollBarPCS0.Location = new System.Drawing.Point(74, 21);
            this.hScrollBarPCS0.Maximum = 255;
            this.hScrollBarPCS0.Name = "hScrollBarPCS0";
            this.hScrollBarPCS0.Size = new System.Drawing.Size(179, 18);
            this.hScrollBarPCS0.TabIndex = 652;
            this.hScrollBarPCS0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPCS0_Scroll);
            // 
            // hScrollBarPWM0
            // 
            this.hScrollBarPWM0.LargeChange = 1;
            this.hScrollBarPWM0.Location = new System.Drawing.Point(74, 63);
            this.hScrollBarPWM0.Maximum = 255;
            this.hScrollBarPWM0.Name = "hScrollBarPWM0";
            this.hScrollBarPWM0.Size = new System.Drawing.Size(179, 18);
            this.hScrollBarPWM0.TabIndex = 652;
            this.hScrollBarPWM0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPWM0_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 653;
            this.label1.Text = "LED 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 653;
            this.label2.Text = "LED 1";
            // 
            // lbPCS0
            // 
            this.lbPCS0.AutoSize = true;
            this.lbPCS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCS0.Location = new System.Drawing.Point(264, 21);
            this.lbPCS0.Name = "lbPCS0";
            this.lbPCS0.Size = new System.Drawing.Size(15, 15);
            this.lbPCS0.TabIndex = 654;
            this.lbPCS0.Text = "0";
            // 
            // lbPWM0
            // 
            this.lbPWM0.AutoSize = true;
            this.lbPWM0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWM0.Location = new System.Drawing.Point(264, 63);
            this.lbPWM0.Name = "lbPWM0";
            this.lbPWM0.Size = new System.Drawing.Size(15, 15);
            this.lbPWM0.TabIndex = 654;
            this.lbPWM0.Text = "0";
            // 
            // cmbLed0
            // 
            this.cmbLed0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLed0.FormattingEnabled = true;
            this.cmbLed0.Items.AddRange(new object[] {
            "Off",
            "On",
            "Blinks at PWM0 Rate",
            "Blinks at PWM1 Rate"});
            this.cmbLed0.Location = new System.Drawing.Point(396, 209);
            this.cmbLed0.Name = "cmbLed0";
            this.cmbLed0.Size = new System.Drawing.Size(140, 21);
            this.cmbLed0.TabIndex = 655;
            this.cmbLed0.SelectedIndexChanged += new System.EventHandler(this.cmbLed0_SelectedIndexChanged);
            // 
            // cmbLed1
            // 
            this.cmbLed1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLed1.FormattingEnabled = true;
            this.cmbLed1.Items.AddRange(new object[] {
            "Off",
            "On",
            "Blinks at PWM0 Rate",
            "Blinks at PWM1 Rate"});
            this.cmbLed1.Location = new System.Drawing.Point(396, 248);
            this.cmbLed1.Name = "cmbLed1";
            this.cmbLed1.Size = new System.Drawing.Size(140, 21);
            this.cmbLed1.TabIndex = 655;
            this.cmbLed1.SelectedIndexChanged += new System.EventHandler(this.cmbLed0_SelectedIndexChanged);
            // 
            // groupPWM1
            // 
            this.groupPWM1.Controls.Add(this.lbPWM0);
            this.groupPWM1.Controls.Add(this.lbPCS0);
            this.groupPWM1.Controls.Add(this.hScrollBarPWM0);
            this.groupPWM1.Controls.Add(this.hScrollBarPCS0);
            this.groupPWM1.Controls.Add(this.label4);
            this.groupPWM1.Controls.Add(this.label3);
            this.groupPWM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPWM1.Location = new System.Drawing.Point(322, 12);
            this.groupPWM1.Name = "groupPWM1";
            this.groupPWM1.Size = new System.Drawing.Size(305, 93);
            this.groupPWM1.TabIndex = 656;
            this.groupPWM1.TabStop = false;
            this.groupPWM1.Text = "PWM0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 653;
            this.label4.Text = "PWM0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 653;
            this.label3.Text = "PCS0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbPWM1);
            this.groupBox5.Controls.Add(this.lbPCS1);
            this.groupBox5.Controls.Add(this.hScrollBarPWM1);
            this.groupBox5.Controls.Add(this.hScrollBarPCS1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(322, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 93);
            this.groupBox5.TabIndex = 656;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PWM1";
            // 
            // lbPWM1
            // 
            this.lbPWM1.AutoSize = true;
            this.lbPWM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWM1.Location = new System.Drawing.Point(264, 63);
            this.lbPWM1.Name = "lbPWM1";
            this.lbPWM1.Size = new System.Drawing.Size(15, 15);
            this.lbPWM1.TabIndex = 654;
            this.lbPWM1.Text = "0";
            // 
            // lbPCS1
            // 
            this.lbPCS1.AutoSize = true;
            this.lbPCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCS1.Location = new System.Drawing.Point(264, 21);
            this.lbPCS1.Name = "lbPCS1";
            this.lbPCS1.Size = new System.Drawing.Size(15, 15);
            this.lbPCS1.TabIndex = 654;
            this.lbPCS1.Text = "0";
            // 
            // hScrollBarPWM1
            // 
            this.hScrollBarPWM1.LargeChange = 1;
            this.hScrollBarPWM1.Location = new System.Drawing.Point(74, 63);
            this.hScrollBarPWM1.Maximum = 255;
            this.hScrollBarPWM1.Name = "hScrollBarPWM1";
            this.hScrollBarPWM1.Size = new System.Drawing.Size(179, 18);
            this.hScrollBarPWM1.TabIndex = 652;
            this.hScrollBarPWM1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPWM1_Scroll);
            // 
            // hScrollBarPCS1
            // 
            this.hScrollBarPCS1.LargeChange = 1;
            this.hScrollBarPCS1.Location = new System.Drawing.Point(74, 21);
            this.hScrollBarPCS1.Maximum = 255;
            this.hScrollBarPCS1.Name = "hScrollBarPCS1";
            this.hScrollBarPCS1.Size = new System.Drawing.Size(179, 18);
            this.hScrollBarPCS1.TabIndex = 652;
            this.hScrollBarPCS1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPCS1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 653;
            this.label7.Text = "PWM1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 653;
            this.label8.Text = "PCS1";
            // 
            // frmI2CPWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 284);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupPWM1);
            this.Controls.Add(this.cmbLed1);
            this.Controls.Add(this.cmbLed0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CPWM";
            this.Text = "PCA9530 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupPWM1.ResumeLayout(false);
            this.groupPWM1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.HScrollBar hScrollBarPCS0;
        private System.Windows.Forms.HScrollBar hScrollBarPWM0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPCS0;
        private System.Windows.Forms.Label lbPWM0;
        private System.Windows.Forms.ComboBox cmbLed0;
        private System.Windows.Forms.ComboBox cmbLed1;
        private System.Windows.Forms.GroupBox groupPWM1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbPWM1;
        private System.Windows.Forms.Label lbPCS1;
        private System.Windows.Forms.HScrollBar hScrollBarPWM1;
        private System.Windows.Forms.HScrollBar hScrollBarPCS1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}