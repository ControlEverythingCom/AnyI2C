namespace ADS7828_I2CADC
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
            this.lbCh7 = new System.Windows.Forms.Label();
            this.lbCh6 = new System.Windows.Forms.Label();
            this.btnReadCh7 = new System.Windows.Forms.Button();
            this.btnReadCh6 = new System.Windows.Forms.Button();
            this.lbCh5 = new System.Windows.Forms.Label();
            this.lbCh4 = new System.Windows.Forms.Label();
            this.btnReadCh5 = new System.Windows.Forms.Button();
            this.btnReadCh4 = new System.Windows.Forms.Button();
            this.lbCh3 = new System.Windows.Forms.Label();
            this.lbCh2 = new System.Windows.Forms.Label();
            this.btnReadCh3 = new System.Windows.Forms.Button();
            this.btnReadCh2 = new System.Windows.Forms.Button();
            this.lbCh1 = new System.Windows.Forms.Label();
            this.lbCh0 = new System.Windows.Forms.Label();
            this.btnReadCh1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCh7
            // 
            this.lbCh7.AutoSize = true;
            this.lbCh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh7.Location = new System.Drawing.Point(624, 281);
            this.lbCh7.Name = "lbCh7";
            this.lbCh7.Size = new System.Drawing.Size(23, 16);
            this.lbCh7.TabIndex = 530;
            this.lbCh7.Text = "---";
            // 
            // lbCh6
            // 
            this.lbCh6.AutoSize = true;
            this.lbCh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh6.Location = new System.Drawing.Point(624, 207);
            this.lbCh6.Name = "lbCh6";
            this.lbCh6.Size = new System.Drawing.Size(23, 16);
            this.lbCh6.TabIndex = 531;
            this.lbCh6.Text = "---";
            // 
            // btnReadCh7
            // 
            this.btnReadCh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh7.Location = new System.Drawing.Point(554, 231);
            this.btnReadCh7.Name = "btnReadCh7";
            this.btnReadCh7.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh7.TabIndex = 528;
            this.btnReadCh7.Text = "Read Channel 7";
            this.btnReadCh7.UseVisualStyleBackColor = true;
            this.btnReadCh7.Click += new System.EventHandler(this.btnReadCh7_Click);
            // 
            // btnReadCh6
            // 
            this.btnReadCh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh6.Location = new System.Drawing.Point(554, 163);
            this.btnReadCh6.Name = "btnReadCh6";
            this.btnReadCh6.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh6.TabIndex = 529;
            this.btnReadCh6.Text = "Read Channel 6";
            this.btnReadCh6.UseVisualStyleBackColor = true;
            this.btnReadCh6.Click += new System.EventHandler(this.btnReadCh6_Click);
            // 
            // lbCh5
            // 
            this.lbCh5.AutoSize = true;
            this.lbCh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh5.Location = new System.Drawing.Point(624, 120);
            this.lbCh5.Name = "lbCh5";
            this.lbCh5.Size = new System.Drawing.Size(23, 16);
            this.lbCh5.TabIndex = 526;
            this.lbCh5.Text = "---";
            // 
            // lbCh4
            // 
            this.lbCh4.AutoSize = true;
            this.lbCh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh4.Location = new System.Drawing.Point(624, 56);
            this.lbCh4.Name = "lbCh4";
            this.lbCh4.Size = new System.Drawing.Size(23, 16);
            this.lbCh4.TabIndex = 527;
            this.lbCh4.Text = "---";
            // 
            // btnReadCh5
            // 
            this.btnReadCh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh5.Location = new System.Drawing.Point(554, 80);
            this.btnReadCh5.Name = "btnReadCh5";
            this.btnReadCh5.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh5.TabIndex = 524;
            this.btnReadCh5.Text = "Read Channel 5";
            this.btnReadCh5.UseVisualStyleBackColor = true;
            this.btnReadCh5.Click += new System.EventHandler(this.btnReadCh5_Click);
            // 
            // btnReadCh4
            // 
            this.btnReadCh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh4.Location = new System.Drawing.Point(554, 12);
            this.btnReadCh4.Name = "btnReadCh4";
            this.btnReadCh4.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh4.TabIndex = 525;
            this.btnReadCh4.Text = "Read Channel 4";
            this.btnReadCh4.UseVisualStyleBackColor = true;
            this.btnReadCh4.Click += new System.EventHandler(this.btnReadCh4_Click);
            // 
            // lbCh3
            // 
            this.lbCh3.AutoSize = true;
            this.lbCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh3.Location = new System.Drawing.Point(405, 281);
            this.lbCh3.Name = "lbCh3";
            this.lbCh3.Size = new System.Drawing.Size(23, 16);
            this.lbCh3.TabIndex = 522;
            this.lbCh3.Text = "---";
            // 
            // lbCh2
            // 
            this.lbCh2.AutoSize = true;
            this.lbCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh2.Location = new System.Drawing.Point(405, 207);
            this.lbCh2.Name = "lbCh2";
            this.lbCh2.Size = new System.Drawing.Size(23, 16);
            this.lbCh2.TabIndex = 523;
            this.lbCh2.Text = "---";
            // 
            // btnReadCh3
            // 
            this.btnReadCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh3.Location = new System.Drawing.Point(335, 231);
            this.btnReadCh3.Name = "btnReadCh3";
            this.btnReadCh3.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh3.TabIndex = 520;
            this.btnReadCh3.Text = "Read Channel 3";
            this.btnReadCh3.UseVisualStyleBackColor = true;
            this.btnReadCh3.Click += new System.EventHandler(this.btnReadCh3_Click);
            // 
            // btnReadCh2
            // 
            this.btnReadCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh2.Location = new System.Drawing.Point(335, 163);
            this.btnReadCh2.Name = "btnReadCh2";
            this.btnReadCh2.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh2.TabIndex = 521;
            this.btnReadCh2.Text = "Read Channel 2";
            this.btnReadCh2.UseVisualStyleBackColor = true;
            this.btnReadCh2.Click += new System.EventHandler(this.btnReadCh2_Click);
            // 
            // lbCh1
            // 
            this.lbCh1.AutoSize = true;
            this.lbCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh1.Location = new System.Drawing.Point(405, 120);
            this.lbCh1.Name = "lbCh1";
            this.lbCh1.Size = new System.Drawing.Size(23, 16);
            this.lbCh1.TabIndex = 518;
            this.lbCh1.Text = "---";
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(405, 56);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 519;
            this.lbCh0.Text = "---";
            // 
            // btnReadCh1
            // 
            this.btnReadCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh1.Location = new System.Drawing.Point(335, 80);
            this.btnReadCh1.Name = "btnReadCh1";
            this.btnReadCh1.Size = new System.Drawing.Size(169, 23);
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
            72,
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
            this.btnReadCh0.Location = new System.Drawing.Point(335, 12);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(169, 23);
            this.btnReadCh0.TabIndex = 517;
            this.btnReadCh0.Text = "Read Channel 0";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Location = new System.Drawing.Point(150, 231);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chkAutoUpdate.TabIndex = 533;
            this.chkAutoUpdate.Text = "Auto Update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // frmI2CADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 308);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lbCh7);
            this.Controls.Add(this.lbCh6);
            this.Controls.Add(this.btnReadCh7);
            this.Controls.Add(this.btnReadCh6);
            this.Controls.Add(this.lbCh5);
            this.Controls.Add(this.lbCh4);
            this.Controls.Add(this.btnReadCh5);
            this.Controls.Add(this.btnReadCh4);
            this.Controls.Add(this.lbCh3);
            this.Controls.Add(this.lbCh2);
            this.Controls.Add(this.btnReadCh3);
            this.Controls.Add(this.btnReadCh2);
            this.Controls.Add(this.lbCh1);
            this.Controls.Add(this.lbCh0);
            this.Controls.Add(this.btnReadCh1);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnReadCh0);
            this.Name = "frmI2CADC";
            this.Text = "ADS7828 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CADC_FormClosing);
            this.Load += new System.EventHandler(this.frmADS7828_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbCh7;
        internal System.Windows.Forms.Label lbCh6;
        internal System.Windows.Forms.Button btnReadCh7;
        internal System.Windows.Forms.Button btnReadCh6;
        internal System.Windows.Forms.Label lbCh5;
        internal System.Windows.Forms.Label lbCh4;
        internal System.Windows.Forms.Button btnReadCh5;
        internal System.Windows.Forms.Button btnReadCh4;
        internal System.Windows.Forms.Label lbCh3;
        internal System.Windows.Forms.Label lbCh2;
        internal System.Windows.Forms.Button btnReadCh3;
        internal System.Windows.Forms.Button btnReadCh2;
        internal System.Windows.Forms.Label lbCh1;
        internal System.Windows.Forms.Label lbCh0;
        internal System.Windows.Forms.Button btnReadCh1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
    }
}