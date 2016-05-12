namespace MQ3_I2CADC
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.lbCh0 = new System.Windows.Forms.Label();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(183, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 546;
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
            this.chkAutoUpdate.Location = new System.Drawing.Point(339, 199);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdate.TabIndex = 545;
            this.chkAutoUpdate.Text = "Auto Update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(16, 23);
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
            80,
            0,
            0,
            0});
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(451, 75);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 544;
            this.lbCh0.Text = "---";
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(13, 113);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 542;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // btnReadCh0
            // 
            this.btnReadCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh0.Location = new System.Drawing.Point(339, 35);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh0.TabIndex = 543;
            this.btnReadCh0.Text = "Read";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmI2CADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 239);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lbCh0);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh0);
            this.Name = "frmI2CADC";
            this.Text = "frmI2CADC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CADC_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CADC_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label lbCh0;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        private System.Windows.Forms.Timer timer1;
    }
}