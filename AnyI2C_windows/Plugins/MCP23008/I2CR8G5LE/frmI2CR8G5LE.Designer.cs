namespace MCP23008_I2CR8G5LE
{
    partial class frmI2CR8G5LE
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.chkB1R8 = new System.Windows.Forms.CheckBox();
            this.chkB1R4 = new System.Windows.Forms.CheckBox();
            this.chkB1R7 = new System.Windows.Forms.CheckBox();
            this.chkB1R3 = new System.Windows.Forms.CheckBox();
            this.chkB1R6 = new System.Windows.Forms.CheckBox();
            this.chkB1R5 = new System.Windows.Forms.CheckBox();
            this.chkB1R2 = new System.Windows.Forms.CheckBox();
            this.chkB1R1 = new System.Windows.Forms.CheckBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAllOff1 = new System.Windows.Forms.Button();
            this.btnAllOn1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.numPort);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 73);
            this.groupBox4.TabIndex = 543;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Port";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(372, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 52);
            this.groupBox6.TabIndex = 487;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GroupBox2";
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
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.chkB1R8);
            this.GroupBox3.Controls.Add(this.chkB1R4);
            this.GroupBox3.Controls.Add(this.chkB1R7);
            this.GroupBox3.Controls.Add(this.chkB1R3);
            this.GroupBox3.Controls.Add(this.chkB1R6);
            this.GroupBox3.Controls.Add(this.chkB1R5);
            this.GroupBox3.Controls.Add(this.chkB1R2);
            this.GroupBox3.Controls.Add(this.chkB1R1);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.label18);
            this.GroupBox3.Controls.Add(this.label19);
            this.GroupBox3.Controls.Add(this.label20);
            this.GroupBox3.Controls.Add(this.label21);
            this.GroupBox3.Controls.Add(this.label22);
            this.GroupBox3.Controls.Add(this.label23);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox3.Location = new System.Drawing.Point(240, 15);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(450, 86);
            this.GroupBox3.TabIndex = 542;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Bank 1";
            // 
            // chkB1R8
            // 
            this.chkB1R8.AutoSize = true;
            this.chkB1R8.Location = new System.Drawing.Point(404, 34);
            this.chkB1R8.Name = "chkB1R8";
            this.chkB1R8.Size = new System.Drawing.Size(46, 20);
            this.chkB1R8.TabIndex = 523;
            this.chkB1R8.Tag = "8";
            this.chkB1R8.Text = "Off";
            this.chkB1R8.UseVisualStyleBackColor = true;
            this.chkB1R8.Click += new System.EventHandler(this.chkB1R8_Clicked);
            // 
            // chkB1R4
            // 
            this.chkB1R4.AutoSize = true;
            this.chkB1R4.Location = new System.Drawing.Point(180, 34);
            this.chkB1R4.Name = "chkB1R4";
            this.chkB1R4.Size = new System.Drawing.Size(46, 20);
            this.chkB1R4.TabIndex = 522;
            this.chkB1R4.Tag = "4";
            this.chkB1R4.Text = "Off";
            this.chkB1R4.UseVisualStyleBackColor = true;
            this.chkB1R4.Click += new System.EventHandler(this.chkB1R4_Clicked);
            // 
            // chkB1R7
            // 
            this.chkB1R7.AutoSize = true;
            this.chkB1R7.Location = new System.Drawing.Point(348, 34);
            this.chkB1R7.Name = "chkB1R7";
            this.chkB1R7.Size = new System.Drawing.Size(46, 20);
            this.chkB1R7.TabIndex = 521;
            this.chkB1R7.Tag = "7";
            this.chkB1R7.Text = "Off";
            this.chkB1R7.UseVisualStyleBackColor = true;
            this.chkB1R7.Click += new System.EventHandler(this.chkB1R7_Clicked);
            // 
            // chkB1R3
            // 
            this.chkB1R3.AutoSize = true;
            this.chkB1R3.Location = new System.Drawing.Point(124, 34);
            this.chkB1R3.Name = "chkB1R3";
            this.chkB1R3.Size = new System.Drawing.Size(46, 20);
            this.chkB1R3.TabIndex = 520;
            this.chkB1R3.Tag = "3";
            this.chkB1R3.Text = "Off";
            this.chkB1R3.UseVisualStyleBackColor = true;
            this.chkB1R3.Click += new System.EventHandler(this.chkB1R3_Clicked);
            // 
            // chkB1R6
            // 
            this.chkB1R6.AutoSize = true;
            this.chkB1R6.Location = new System.Drawing.Point(292, 34);
            this.chkB1R6.Name = "chkB1R6";
            this.chkB1R6.Size = new System.Drawing.Size(46, 20);
            this.chkB1R6.TabIndex = 519;
            this.chkB1R6.Tag = "6";
            this.chkB1R6.Text = "Off";
            this.chkB1R6.UseVisualStyleBackColor = true;
            this.chkB1R6.Click += new System.EventHandler(this.chkB1R6_Clicked);
            // 
            // chkB1R5
            // 
            this.chkB1R5.AutoSize = true;
            this.chkB1R5.Location = new System.Drawing.Point(236, 34);
            this.chkB1R5.Name = "chkB1R5";
            this.chkB1R5.Size = new System.Drawing.Size(46, 20);
            this.chkB1R5.TabIndex = 518;
            this.chkB1R5.Tag = "5";
            this.chkB1R5.Text = "Off";
            this.chkB1R5.UseVisualStyleBackColor = true;
            this.chkB1R5.Click += new System.EventHandler(this.chkB1R5_Clicked);
            // 
            // chkB1R2
            // 
            this.chkB1R2.AutoSize = true;
            this.chkB1R2.Location = new System.Drawing.Point(68, 34);
            this.chkB1R2.Name = "chkB1R2";
            this.chkB1R2.Size = new System.Drawing.Size(46, 20);
            this.chkB1R2.TabIndex = 517;
            this.chkB1R2.Tag = "2";
            this.chkB1R2.Text = "Off";
            this.chkB1R2.UseVisualStyleBackColor = true;
            this.chkB1R2.Click += new System.EventHandler(this.chkB1R2_Clicked);
            // 
            // chkB1R1
            // 
            this.chkB1R1.AutoSize = true;
            this.chkB1R1.Location = new System.Drawing.Point(12, 34);
            this.chkB1R1.Name = "chkB1R1";
            this.chkB1R1.Size = new System.Drawing.Size(46, 20);
            this.chkB1R1.TabIndex = 516;
            this.chkB1R1.Tag = "1";
            this.chkB1R1.Text = "Off";
            this.chkB1R1.UseVisualStyleBackColor = true;
            this.chkB1R1.Click += new System.EventHandler(this.chkB1R1_Clicked);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(401, 15);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(25, 16);
            this.Label9.TabIndex = 512;
            this.Label9.Text = "R8";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(177, 15);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(25, 16);
            this.Label5.TabIndex = 505;
            this.Label5.Text = "R4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(345, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 511;
            this.label18.Text = "R7";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(121, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 510;
            this.label19.Text = "R3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(289, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 509;
            this.label20.Text = "R6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(233, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 16);
            this.label21.TabIndex = 508;
            this.label21.Text = "R5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(65, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 16);
            this.label22.TabIndex = 507;
            this.label22.Text = "R2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 16);
            this.label23.TabIndex = 506;
            this.label23.Text = "R1";
            // 
            // btnAllOff1
            // 
            this.btnAllOff1.Location = new System.Drawing.Point(584, 139);
            this.btnAllOff1.Name = "btnAllOff1";
            this.btnAllOff1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOff1.TabIndex = 513;
            this.btnAllOff1.Text = "Turn All Off";
            this.btnAllOff1.UseVisualStyleBackColor = true;
            this.btnAllOff1.Click += new System.EventHandler(this.btnAllOff1_Click);
            // 
            // btnAllOn1
            // 
            this.btnAllOn1.Location = new System.Drawing.Point(584, 111);
            this.btnAllOn1.Name = "btnAllOn1";
            this.btnAllOn1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOn1.TabIndex = 515;
            this.btnAllOn1.Text = "Turn All On";
            this.btnAllOn1.UseVisualStyleBackColor = true;
            this.btnAllOn1.Click += new System.EventHandler(this.btnAllOn1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(522, 111);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(56, 23);
            this.btnRead1.TabIndex = 514;
            this.btnRead1.Text = "Read";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(18, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(216, 89);
            this.GroupBox1.TabIndex = 540;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "I2CR8G5LE Hardware Address";
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
            this.numAddress.Location = new System.Drawing.Point(15, 42);
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
            32,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(249, 114);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(217, 65);
            this._ERROR.TabIndex = 541;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // frmI2CR8G5LE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 192);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.btnAllOn1);
            this.Controls.Add(this.btnRead1);
            this.Controls.Add(this.btnAllOff1);
            this.Name = "frmI2CR8G5LE";
            this.Text = "MCP23008 I2CR8G5LE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CR8G5LE_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CR8G5LE_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.CheckBox chkB1R8;
        internal System.Windows.Forms.CheckBox chkB1R4;
        internal System.Windows.Forms.CheckBox chkB1R7;
        internal System.Windows.Forms.CheckBox chkB1R3;
        internal System.Windows.Forms.CheckBox chkB1R6;
        internal System.Windows.Forms.CheckBox chkB1R5;
        internal System.Windows.Forms.CheckBox chkB1R2;
        internal System.Windows.Forms.CheckBox chkB1R1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Button btnAllOff1;
        internal System.Windows.Forms.Button btnAllOn1;
        internal System.Windows.Forms.Button btnRead1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
    }
}