namespace ADXL345_I2CS
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.lbX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(287, 68);
            this.GroupBox1.TabIndex = 491;
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
            104,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(9, 102);
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
            this.btnReadCh0.Size = new System.Drawing.Size(249, 29);
            this.btnReadCh0.TabIndex = 517;
            this.btnReadCh0.Text = "Read ";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbX.Location = new System.Drawing.Point(451, 100);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(23, 16);
            this.lbX.TabIndex = 519;
            this.lbX.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(394, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 519;
            this.label3.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(393, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 520;
            this.label1.Text = "Y";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbY.Location = new System.Drawing.Point(451, 132);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(23, 16);
            this.lbY.TabIndex = 521;
            this.lbY.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(394, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 522;
            this.label2.Text = "Z";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbZ.Location = new System.Drawing.Point(452, 168);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(23, 16);
            this.lbZ.TabIndex = 523;
            this.lbZ.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(335, 200);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdate.TabIndex = 524;
            this.chkAutoUpdate.Text = "Auto Update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // frmI2CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 239);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh0);
            this.Name = "frmI2CS";
            this.Text = "ADXL345 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.L3G4200_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        internal System.Windows.Forms.Label lbX;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbY;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
    }
}