namespace AD5667_I2CDAC
{
    partial class frmI2CDAC
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
            this.scrollValue1 = new System.Windows.Forms.HScrollBar();
            this.lbV1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.lbV2 = new System.Windows.Forms.Label();
            this.scrollValue2 = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollValue1
            // 
            this.scrollValue1.LargeChange = 1;
            this.scrollValue1.Location = new System.Drawing.Point(308, 42);
            this.scrollValue1.Maximum = 65535;
            this.scrollValue1.Name = "scrollValue1";
            this.scrollValue1.Size = new System.Drawing.Size(433, 20);
            this.scrollValue1.TabIndex = 514;
            this.scrollValue1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue1_Scroll);
            // 
            // lbV1
            // 
            this.lbV1.AutoSize = true;
            this.lbV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV1.Location = new System.Drawing.Point(523, 81);
            this.lbV1.Name = "lbV1";
            this.lbV1.Size = new System.Drawing.Size(58, 29);
            this.lbV1.TabIndex = 512;
            this.lbV1.Text = "-----";
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
            14,
            0,
            0,
            0});
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(261, 68);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "AD5667 Hardware Address";
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(430, 238);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(270, 46);
            this._ERROR.TabIndex = 513;
            this._ERROR.Text = "ERROR: <X> Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.groupBox3);
            this.GroupBox6.Controls.Add(this.GroupBox1);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(4, 17);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(284, 267);
            this.GroupBox6.TabIndex = 510;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "AD5667 Controller";
            // 
            // lbV2
            // 
            this.lbV2.AutoSize = true;
            this.lbV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV2.Location = new System.Drawing.Point(523, 159);
            this.lbV2.Name = "lbV2";
            this.lbV2.Size = new System.Drawing.Size(58, 29);
            this.lbV2.TabIndex = 512;
            this.lbV2.Text = "-----";
            // 
            // scrollValue2
            // 
            this.scrollValue2.LargeChange = 1;
            this.scrollValue2.Location = new System.Drawing.Point(308, 135);
            this.scrollValue2.Maximum = 65535;
            this.scrollValue2.Name = "scrollValue2";
            this.scrollValue2.Size = new System.Drawing.Size(433, 20);
            this.scrollValue2.TabIndex = 514;
            this.scrollValue2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue2_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 541;
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
            this.numPort.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // frmI2CDAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 292);
            this.Controls.Add(this.scrollValue2);
            this.Controls.Add(this.lbV2);
            this.Controls.Add(this.scrollValue1);
            this.Controls.Add(this.lbV1);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.GroupBox6);
            this.Name = "frmI2CDAC";
            this.Text = "AD5667 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CPOT_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CDAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.HScrollBar scrollValue1;
        internal System.Windows.Forms.Label lbV1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label lbV2;
        internal System.Windows.Forms.HScrollBar scrollValue2;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
    }
}