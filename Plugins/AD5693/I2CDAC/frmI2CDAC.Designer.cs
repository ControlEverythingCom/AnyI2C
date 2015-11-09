namespace AD5693_I2CDAC
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
            this.lbTemp1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollValue1
            // 
            this.scrollValue1.LargeChange = 1;
            this.scrollValue1.Location = new System.Drawing.Point(308, 70);
            this.scrollValue1.Maximum = 65535;
            this.scrollValue1.Name = "scrollValue1";
            this.scrollValue1.Size = new System.Drawing.Size(433, 20);
            this.scrollValue1.TabIndex = 514;
            this.scrollValue1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue1_Scroll);
            // 
            // lbTemp1
            // 
            this.lbTemp1.AutoSize = true;
            this.lbTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp1.Location = new System.Drawing.Point(523, 126);
            this.lbTemp1.Name = "lbTemp1";
            this.lbTemp1.Size = new System.Drawing.Size(58, 29);
            this.lbTemp1.TabIndex = 512;
            this.lbTemp1.Text = "-----";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRead.Location = new System.Drawing.Point(308, 17);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 32);
            this.btnRead.TabIndex = 509;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
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
            76,
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
            this.GroupBox1.Text = "AD5693 Hardware Address";
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
            this.GroupBox6.Controls.Add(this.GroupBox1);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(4, 17);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(284, 267);
            this.GroupBox6.TabIndex = 510;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "AD5693 Controller";
            // 
            // frmI2CDAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 292);
            this.Controls.Add(this.scrollValue1);
            this.Controls.Add(this.lbTemp1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.GroupBox6);
            this.Name = "frmI2CDAC";
            this.Text = "AD5693 Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.HScrollBar scrollValue1;
        internal System.Windows.Forms.Label lbTemp1;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox6;
    }
}