namespace AD5241_I2CPOT
{
    partial class frmI2CPOT
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
            this.scrollValue2 = new System.Windows.Forms.HScrollBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbTemp2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.scrollValue1 = new System.Windows.Forms.HScrollBar();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbTemp1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
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
            // scrollValue2
            // 
            this.scrollValue2.LargeChange = 1;
            this.scrollValue2.Location = new System.Drawing.Point(389, 97);
            this.scrollValue2.Maximum = 255;
            this.scrollValue2.Name = "scrollValue2";
            this.scrollValue2.Size = new System.Drawing.Size(250, 20);
            this.scrollValue2.TabIndex = 517;
            this.scrollValue2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue2_Scroll);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(322, 91);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 29);
            this.Label4.TabIndex = 515;
            this.Label4.Text = "Ch 2";
            // 
            // lbTemp2
            // 
            this.lbTemp2.AutoSize = true;
            this.lbTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp2.Location = new System.Drawing.Point(668, 91);
            this.lbTemp2.Name = "lbTemp2";
            this.lbTemp2.Size = new System.Drawing.Size(40, 29);
            this.lbTemp2.TabIndex = 516;
            this.lbTemp2.Text = "---";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(329, 188);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(385, 35);
            this.Label1.TabIndex = 508;
            this.Label1.Text = "Apply Voltage(5V) to Terminal A and B and measure the voltage of wiper.";
            // 
            // scrollValue1
            // 
            this.scrollValue1.LargeChange = 1;
            this.scrollValue1.Location = new System.Drawing.Point(389, 70);
            this.scrollValue1.Maximum = 255;
            this.scrollValue1.Name = "scrollValue1";
            this.scrollValue1.Size = new System.Drawing.Size(250, 20);
            this.scrollValue1.TabIndex = 514;
            this.scrollValue1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue1_Scroll);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(322, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 29);
            this.Label2.TabIndex = 511;
            this.Label2.Text = "Ch 1";
            // 
            // lbTemp1
            // 
            this.lbTemp1.AutoSize = true;
            this.lbTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp1.Location = new System.Drawing.Point(668, 64);
            this.lbTemp1.Name = "lbTemp1";
            this.lbTemp1.Size = new System.Drawing.Size(40, 29);
            this.lbTemp1.TabIndex = 512;
            this.lbTemp1.Text = "---";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRead.Location = new System.Drawing.Point(322, 17);
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
            44,
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
            this.GroupBox1.Size = new System.Drawing.Size(282, 68);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "AD5242/42 Hardware Address";
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(444, 238);
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
            this.GroupBox6.Size = new System.Drawing.Size(305, 267);
            this.GroupBox6.TabIndex = 510;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "AD5241/42 Controller";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 539;
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
            // frmI2CPOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 292);
            this.Controls.Add(this.scrollValue2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lbTemp2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.scrollValue1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lbTemp1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.GroupBox6);
            this.Name = "frmI2CPOT";
            this.Text = "AD5241/42 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CPOT_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CPOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.HScrollBar scrollValue2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lbTemp2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.HScrollBar scrollValue1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbTemp1;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
    }
}