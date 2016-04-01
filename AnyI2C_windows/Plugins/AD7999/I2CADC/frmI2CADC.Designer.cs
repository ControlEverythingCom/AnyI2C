namespace AD7999_I2CADC
{
    partial class frmI2CADC
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
            this.lbCh1 = new System.Windows.Forms.Label();
            this.lbCh0 = new System.Windows.Forms.Label();
            this.btnReadCh1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.btnReadCh2 = new System.Windows.Forms.Button();
            this.btnReadCh3 = new System.Windows.Forms.Button();
            this.lbCh2 = new System.Windows.Forms.Label();
            this.lbCh3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCh1
            // 
            this.lbCh1.AutoSize = true;
            this.lbCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh1.Location = new System.Drawing.Point(447, 101);
            this.lbCh1.Name = "lbCh1";
            this.lbCh1.Size = new System.Drawing.Size(23, 16);
            this.lbCh1.TabIndex = 518;
            this.lbCh1.Text = "---";
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(447, 52);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 519;
            this.lbCh0.Text = "---";
            // 
            // btnReadCh1
            // 
            this.btnReadCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh1.Location = new System.Drawing.Point(335, 73);
            this.btnReadCh1.Name = "btnReadCh1";
            this.btnReadCh1.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh1.TabIndex = 516;
            this.btnReadCh1.Text = "Read Channel 1";
            this.btnReadCh1.UseVisualStyleBackColor = true;
            this.btnReadCh1.Click += new System.EventHandler(this.btnReadCh1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(161, 84);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "AD7999 Hardware Address";
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
            this.numAddress.Location = new System.Drawing.Point(11, 36);
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
            41,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(9, 126);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 514;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // btnReadCh0
            // 
            this.btnReadCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh0.Location = new System.Drawing.Point(335, 24);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh0.TabIndex = 517;
            this.btnReadCh0.Text = "Read Channel 0";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // btnReadCh2
            // 
            this.btnReadCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh2.Location = new System.Drawing.Point(339, 122);
            this.btnReadCh2.Name = "btnReadCh2";
            this.btnReadCh2.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh2.TabIndex = 517;
            this.btnReadCh2.Text = "Read Channel 2";
            this.btnReadCh2.UseVisualStyleBackColor = true;
            this.btnReadCh2.Click += new System.EventHandler(this.btnReadCh2_Click);
            // 
            // btnReadCh3
            // 
            this.btnReadCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh3.Location = new System.Drawing.Point(339, 171);
            this.btnReadCh3.Name = "btnReadCh3";
            this.btnReadCh3.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh3.TabIndex = 516;
            this.btnReadCh3.Text = "Read Channel 3";
            this.btnReadCh3.UseVisualStyleBackColor = true;
            this.btnReadCh3.Click += new System.EventHandler(this.btnReadCh3_Click);
            // 
            // lbCh2
            // 
            this.lbCh2.AutoSize = true;
            this.lbCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh2.Location = new System.Drawing.Point(447, 150);
            this.lbCh2.Name = "lbCh2";
            this.lbCh2.Size = new System.Drawing.Size(23, 16);
            this.lbCh2.TabIndex = 519;
            this.lbCh2.Text = "---";
            // 
            // lbCh3
            // 
            this.lbCh3.AutoSize = true;
            this.lbCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh3.Location = new System.Drawing.Point(447, 199);
            this.lbCh3.Name = "lbCh3";
            this.lbCh3.Size = new System.Drawing.Size(23, 16);
            this.lbCh3.TabIndex = 518;
            this.lbCh3.Text = "---";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(179, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 84);
            this.groupBox3.TabIndex = 540;
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
            this.numPort.Location = new System.Drawing.Point(11, 36);
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
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(38, 210);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdate.TabIndex = 541;
            this.chkAutoUpdate.Text = "Auto Update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // frmI2CADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 239);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lbCh3);
            this.Controls.Add(this.lbCh1);
            this.Controls.Add(this.lbCh2);
            this.Controls.Add(this.lbCh0);
            this.Controls.Add(this.btnReadCh3);
            this.Controls.Add(this.btnReadCh1);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh2);
            this.Controls.Add(this.btnReadCh0);
            this.Name = "frmI2CADC";
            this.Text = "AD7999 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAD7999_FormClosing);
            this.Load += new System.EventHandler(this.frmAD7999_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbCh1;
        internal System.Windows.Forms.Label lbCh0;
        internal System.Windows.Forms.Button btnReadCh1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        internal System.Windows.Forms.Button btnReadCh2;
        internal System.Windows.Forms.Button btnReadCh3;
        internal System.Windows.Forms.Label lbCh2;
        internal System.Windows.Forms.Label lbCh3;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
    }
}