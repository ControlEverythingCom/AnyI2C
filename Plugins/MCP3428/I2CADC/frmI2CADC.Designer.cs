namespace MCP3428_I2CADC
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
            this.lbCh1 = new System.Windows.Forms.Label();
            this.lbCh0 = new System.Windows.Forms.Label();
            this.btnReadCh1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnReadCh2 = new System.Windows.Forms.Button();
            this.btnReadCh3 = new System.Windows.Forms.Button();
            this.lbCh2 = new System.Windows.Forms.Label();
            this.lbCh3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCh1
            // 
            this.lbCh1.AutoSize = true;
            this.lbCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh1.Location = new System.Drawing.Point(447, 113);
            this.lbCh1.Name = "lbCh1";
            this.lbCh1.Size = new System.Drawing.Size(23, 16);
            this.lbCh1.TabIndex = 518;
            this.lbCh1.Text = "---";
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(447, 56);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 519;
            this.lbCh0.Text = "---";
            // 
            // btnReadCh1
            // 
            this.btnReadCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh1.Location = new System.Drawing.Point(335, 81);
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
            this.GroupBox1.Size = new System.Drawing.Size(287, 68);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "MCP3428 Hardware Address";
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
            this.btnReadCh0.Size = new System.Drawing.Size(249, 23);
            this.btnReadCh0.TabIndex = 517;
            this.btnReadCh0.Text = "Read Channel 0";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(12, 188);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(287, 46);
            this.btnSetup.TabIndex = 520;
            this.btnSetup.Text = "Setup I2CADC";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnReadCh2
            // 
            this.btnReadCh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh2.Location = new System.Drawing.Point(335, 138);
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
            this.btnReadCh3.Location = new System.Drawing.Point(335, 195);
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
            this.lbCh2.Location = new System.Drawing.Point(447, 170);
            this.lbCh2.Name = "lbCh2";
            this.lbCh2.Size = new System.Drawing.Size(23, 16);
            this.lbCh2.TabIndex = 519;
            this.lbCh2.Text = "---";
            // 
            // lbCh3
            // 
            this.lbCh3.AutoSize = true;
            this.lbCh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh3.Location = new System.Drawing.Point(447, 227);
            this.lbCh3.Name = "lbCh3";
            this.lbCh3.Size = new System.Drawing.Size(23, 16);
            this.lbCh3.TabIndex = 518;
            this.lbCh3.Text = "---";
            // 
            // frmI2CADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.btnSetup);
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
            this.Text = "MCP3428 Control Panel";
            this.Load += new System.EventHandler(this.frmMCP3426_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
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
        internal System.Windows.Forms.Button btnSetup;
        internal System.Windows.Forms.Button btnReadCh2;
        internal System.Windows.Forms.Button btnReadCh3;
        internal System.Windows.Forms.Label lbCh2;
        internal System.Windows.Forms.Label lbCh3;
    }
}