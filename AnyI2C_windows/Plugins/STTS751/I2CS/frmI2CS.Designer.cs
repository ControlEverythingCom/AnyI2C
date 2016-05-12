namespace STTS751_I2CS
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCh0 = new System.Windows.Forms.Label();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
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
            this.groupBox3.TabIndex = 545;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(476, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 543;
            this.label2.Text = "C";
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(414, 132);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 544;
            this.lbCh0.Text = "---";
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._ERROR.Location = new System.Drawing.Point(9, 102);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 541;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // btnReadCh0
            // 
            this.btnReadCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh0.Location = new System.Drawing.Point(335, 24);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(249, 29);
            this.btnReadCh0.TabIndex = 542;
            this.btnReadCh0.Text = "Read ";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numAddress);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 68);
            this.groupBox1.TabIndex = 540;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Address";
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
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
            57,
            0,
            0,
            0});
            // 
            // frmI2CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 196);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCh0);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh0);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmI2CS";
            this.Text = "STTS751 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbCh0;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.NumericUpDown numAddress;
    }
}