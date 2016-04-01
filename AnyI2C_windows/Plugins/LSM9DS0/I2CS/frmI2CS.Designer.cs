namespace LSM9DS0_I2CS
{
    partial class frmI2CS
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGZ = new System.Windows.Forms.Label();
            this.lbMZ = new System.Windows.Forms.Label();
            this.lbAZ = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGY = new System.Windows.Forms.Label();
            this.lbMY = new System.Windows.Forms.Label();
            this.lbAY = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lbGX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAX = new System.Windows.Forms.Label();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.btnReadCh1 = new System.Windows.Forms.Button();
            this.chkAutoUpdateGyro = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(179, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 563;
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
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(335, 200);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdate.TabIndex = 562;
            this.chkAutoUpdate.Text = "Auto Update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(637, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 16);
            this.label15.TabIndex = 557;
            this.label15.Text = "GZ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(488, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 558;
            this.label9.Text = "MZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(332, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 556;
            this.label2.Text = "AZ";
            // 
            // lbGZ
            // 
            this.lbGZ.AutoSize = true;
            this.lbGZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbGZ.Location = new System.Drawing.Point(710, 168);
            this.lbGZ.Name = "lbGZ";
            this.lbGZ.Size = new System.Drawing.Size(23, 16);
            this.lbGZ.TabIndex = 561;
            this.lbGZ.Text = "---";
            // 
            // lbMZ
            // 
            this.lbMZ.AutoSize = true;
            this.lbMZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMZ.Location = new System.Drawing.Point(546, 164);
            this.lbMZ.Name = "lbMZ";
            this.lbMZ.Size = new System.Drawing.Size(23, 16);
            this.lbMZ.TabIndex = 560;
            this.lbMZ.Text = "---";
            // 
            // lbAZ
            // 
            this.lbAZ.AutoSize = true;
            this.lbAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbAZ.Location = new System.Drawing.Point(390, 164);
            this.lbAZ.Name = "lbAZ";
            this.lbAZ.Size = new System.Drawing.Size(23, 16);
            this.lbAZ.TabIndex = 559;
            this.lbAZ.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(636, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 551;
            this.label13.Text = "GY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(487, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 552;
            this.label7.Text = "MY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(331, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 550;
            this.label1.Text = "AY";
            // 
            // lbGY
            // 
            this.lbGY.AutoSize = true;
            this.lbGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbGY.Location = new System.Drawing.Point(710, 128);
            this.lbGY.Name = "lbGY";
            this.lbGY.Size = new System.Drawing.Size(23, 16);
            this.lbGY.TabIndex = 555;
            this.lbGY.Text = "---";
            // 
            // lbMY
            // 
            this.lbMY.AutoSize = true;
            this.lbMY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMY.Location = new System.Drawing.Point(545, 128);
            this.lbMY.Name = "lbMY";
            this.lbMY.Size = new System.Drawing.Size(23, 16);
            this.lbMY.TabIndex = 554;
            this.lbMY.Text = "---";
            // 
            // lbAY
            // 
            this.lbAY.AutoSize = true;
            this.lbAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbAY.Location = new System.Drawing.Point(389, 128);
            this.lbAY.Name = "lbAY";
            this.lbAY.Size = new System.Drawing.Size(23, 16);
            this.lbAY.TabIndex = 553;
            this.lbAY.Text = "---";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(161, 68);
            this.GroupBox1.TabIndex = 541;
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
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(637, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 549;
            this.label11.Text = "GX";
            // 
            // lbGX
            // 
            this.lbGX.AutoSize = true;
            this.lbGX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbGX.Location = new System.Drawing.Point(710, 100);
            this.lbGX.Name = "lbGX";
            this.lbGX.Size = new System.Drawing.Size(23, 16);
            this.lbGX.TabIndex = 548;
            this.lbGX.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(488, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 547;
            this.label5.Text = "MX";
            // 
            // lbMX
            // 
            this.lbMX.AutoSize = true;
            this.lbMX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMX.Location = new System.Drawing.Point(545, 96);
            this.lbMX.Name = "lbMX";
            this.lbMX.Size = new System.Drawing.Size(23, 16);
            this.lbMX.TabIndex = 546;
            this.lbMX.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(332, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 545;
            this.label3.Text = "AX";
            // 
            // lbAX
            // 
            this.lbAX.AutoSize = true;
            this.lbAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbAX.Location = new System.Drawing.Point(389, 96);
            this.lbAX.Name = "lbAX";
            this.lbAX.Size = new System.Drawing.Size(23, 16);
            this.lbAX.TabIndex = 544;
            this.lbAX.Text = "---";
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(9, 102);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 542;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // btnReadCh0
            // 
            this.btnReadCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh0.Location = new System.Drawing.Point(323, 24);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(261, 29);
            this.btnReadCh0.TabIndex = 543;
            this.btnReadCh0.Text = "Read ";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // btnReadCh1
            // 
            this.btnReadCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh1.Location = new System.Drawing.Point(602, 24);
            this.btnReadCh1.Name = "btnReadCh1";
            this.btnReadCh1.Size = new System.Drawing.Size(149, 29);
            this.btnReadCh1.TabIndex = 564;
            this.btnReadCh1.Text = "Read ";
            this.btnReadCh1.UseVisualStyleBackColor = true;
            this.btnReadCh1.Click += new System.EventHandler(this.btnReadCh1_Click);
            // 
            // chkAutoUpdateGyro
            // 
            this.chkAutoUpdateGyro.AutoSize = true;
            this.chkAutoUpdateGyro.Location = new System.Drawing.Point(623, 200);
            this.chkAutoUpdateGyro.Name = "chkAutoUpdateGyro";
            this.chkAutoUpdateGyro.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdateGyro.TabIndex = 565;
            this.chkAutoUpdateGyro.Text = "Auto Update";
            this.chkAutoUpdateGyro.UseVisualStyleBackColor = true;
            this.chkAutoUpdateGyro.CheckedChanged += new System.EventHandler(this.chkAutoUpdateGyro_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmI2CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 239);
            this.Controls.Add(this.chkAutoUpdateGyro);
            this.Controls.Add(this.btnReadCh1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGZ);
            this.Controls.Add(this.lbMZ);
            this.Controls.Add(this.lbAZ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGY);
            this.Controls.Add(this.lbMY);
            this.Controls.Add(this.lbAY);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbGX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAX);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh0);
            this.Name = "frmI2CS";
            this.Text = "LSM9DS0 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbGZ;
        internal System.Windows.Forms.Label lbMZ;
        internal System.Windows.Forms.Label lbAZ;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbGY;
        internal System.Windows.Forms.Label lbMY;
        internal System.Windows.Forms.Label lbAY;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label lbGX;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lbMX;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lbAX;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        internal System.Windows.Forms.Button btnReadCh1;
        private System.Windows.Forms.CheckBox chkAutoUpdateGyro;
        private System.Windows.Forms.Timer timer2;
    }
}