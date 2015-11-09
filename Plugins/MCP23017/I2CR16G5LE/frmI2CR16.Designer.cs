namespace MCP23017_I2CR16
{
    partial class frmI2CR16x0
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
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.chkB2R1 = new System.Windows.Forms.CheckBox();
            this.chkB2R2 = new System.Windows.Forms.CheckBox();
            this.chkB2R3 = new System.Windows.Forms.CheckBox();
            this.chkB2R4 = new System.Windows.Forms.CheckBox();
            this.chkB2R6 = new System.Windows.Forms.CheckBox();
            this.chkB2R5 = new System.Windows.Forms.CheckBox();
            this.chkB2R7 = new System.Windows.Forms.CheckBox();
            this.chkB2R8 = new System.Windows.Forms.CheckBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.btnAllOff2 = new System.Windows.Forms.Button();
            this.btnAllOn2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
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
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(15, 131);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(219, 40);
            this._ERROR.TabIndex = 508;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(18, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(216, 98);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "I2CR16x Hardware Address";
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
            this.numAddress.Location = new System.Drawing.Point(15, 41);
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
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.chkB2R1);
            this.GroupBox5.Controls.Add(this.chkB2R2);
            this.GroupBox5.Controls.Add(this.chkB2R3);
            this.GroupBox5.Controls.Add(this.chkB2R4);
            this.GroupBox5.Controls.Add(this.chkB2R6);
            this.GroupBox5.Controls.Add(this.chkB2R5);
            this.GroupBox5.Controls.Add(this.chkB2R7);
            this.GroupBox5.Controls.Add(this.chkB2R8);
            this.GroupBox5.Controls.Add(this.Label10);
            this.GroupBox5.Controls.Add(this.Label11);
            this.GroupBox5.Controls.Add(this.Label12);
            this.GroupBox5.Controls.Add(this.Label13);
            this.GroupBox5.Controls.Add(this.Label14);
            this.GroupBox5.Controls.Add(this.Label15);
            this.GroupBox5.Controls.Add(this.Label16);
            this.GroupBox5.Controls.Add(this.Label17);
            this.GroupBox5.Controls.Add(this.btnAllOff2);
            this.GroupBox5.Controls.Add(this.btnAllOn2);
            this.GroupBox5.Controls.Add(this.btnRead2);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox5.Location = new System.Drawing.Point(240, 98);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(635, 73);
            this.GroupBox5.TabIndex = 527;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Bank 2";
            // 
            // chkB2R1
            // 
            this.chkB2R1.AutoSize = true;
            this.chkB2R1.Location = new System.Drawing.Point(12, 43);
            this.chkB2R1.Name = "chkB2R1";
            this.chkB2R1.Size = new System.Drawing.Size(46, 20);
            this.chkB2R1.TabIndex = 523;
            this.chkB2R1.Tag = "1";
            this.chkB2R1.Text = "Off";
            this.chkB2R1.UseVisualStyleBackColor = true;
            this.chkB2R1.Click += new System.EventHandler(this.chkB2R1_Click);
            // 
            // chkB2R2
            // 
            this.chkB2R2.AutoSize = true;
            this.chkB2R2.Location = new System.Drawing.Point(68, 43);
            this.chkB2R2.Name = "chkB2R2";
            this.chkB2R2.Size = new System.Drawing.Size(46, 20);
            this.chkB2R2.TabIndex = 522;
            this.chkB2R2.Tag = "2";
            this.chkB2R2.Text = "Off";
            this.chkB2R2.UseVisualStyleBackColor = true;
            this.chkB2R2.Click += new System.EventHandler(this.chkB2R2_Click);
            // 
            // chkB2R3
            // 
            this.chkB2R3.AutoSize = true;
            this.chkB2R3.Location = new System.Drawing.Point(124, 43);
            this.chkB2R3.Name = "chkB2R3";
            this.chkB2R3.Size = new System.Drawing.Size(46, 20);
            this.chkB2R3.TabIndex = 521;
            this.chkB2R3.Tag = "3";
            this.chkB2R3.Text = "Off";
            this.chkB2R3.UseVisualStyleBackColor = true;
            this.chkB2R3.Click += new System.EventHandler(this.chkB2R3_Click);
            // 
            // chkB2R4
            // 
            this.chkB2R4.AutoSize = true;
            this.chkB2R4.Location = new System.Drawing.Point(180, 43);
            this.chkB2R4.Name = "chkB2R4";
            this.chkB2R4.Size = new System.Drawing.Size(46, 20);
            this.chkB2R4.TabIndex = 520;
            this.chkB2R4.Tag = "4";
            this.chkB2R4.Text = "Off";
            this.chkB2R4.UseVisualStyleBackColor = true;
            this.chkB2R4.Click += new System.EventHandler(this.chkB2R4_Click);
            // 
            // chkB2R6
            // 
            this.chkB2R6.AutoSize = true;
            this.chkB2R6.Location = new System.Drawing.Point(292, 43);
            this.chkB2R6.Name = "chkB2R6";
            this.chkB2R6.Size = new System.Drawing.Size(46, 20);
            this.chkB2R6.TabIndex = 519;
            this.chkB2R6.Tag = "6";
            this.chkB2R6.Text = "Off";
            this.chkB2R6.UseVisualStyleBackColor = true;
            this.chkB2R6.Click += new System.EventHandler(this.chkB2R6_Click);
            // 
            // chkB2R5
            // 
            this.chkB2R5.AutoSize = true;
            this.chkB2R5.Location = new System.Drawing.Point(236, 43);
            this.chkB2R5.Name = "chkB2R5";
            this.chkB2R5.Size = new System.Drawing.Size(46, 20);
            this.chkB2R5.TabIndex = 518;
            this.chkB2R5.Tag = "5";
            this.chkB2R5.Text = "Off";
            this.chkB2R5.UseVisualStyleBackColor = true;
            this.chkB2R5.Click += new System.EventHandler(this.chkB2R5_Click);
            // 
            // chkB2R7
            // 
            this.chkB2R7.AutoSize = true;
            this.chkB2R7.Location = new System.Drawing.Point(348, 43);
            this.chkB2R7.Name = "chkB2R7";
            this.chkB2R7.Size = new System.Drawing.Size(46, 20);
            this.chkB2R7.TabIndex = 517;
            this.chkB2R7.Tag = "7";
            this.chkB2R7.Text = "Off";
            this.chkB2R7.UseVisualStyleBackColor = true;
            this.chkB2R7.Click += new System.EventHandler(this.chkB2R7_Click);
            // 
            // chkB2R8
            // 
            this.chkB2R8.AutoSize = true;
            this.chkB2R8.Location = new System.Drawing.Point(404, 43);
            this.chkB2R8.Name = "chkB2R8";
            this.chkB2R8.Size = new System.Drawing.Size(46, 20);
            this.chkB2R8.TabIndex = 516;
            this.chkB2R8.Tag = "8";
            this.chkB2R8.Text = "Off";
            this.chkB2R8.UseVisualStyleBackColor = true;
            this.chkB2R8.Click += new System.EventHandler(this.chkB2R8_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(401, 15);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(25, 16);
            this.Label10.TabIndex = 512;
            this.Label10.Text = "R8";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(177, 15);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(25, 16);
            this.Label11.TabIndex = 505;
            this.Label11.Text = "R4";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(345, 15);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(25, 16);
            this.Label12.TabIndex = 511;
            this.Label12.Text = "R7";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(121, 15);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(25, 16);
            this.Label13.TabIndex = 510;
            this.Label13.Text = "R3";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(289, 15);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(25, 16);
            this.Label14.TabIndex = 509;
            this.Label14.Text = "R6";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(233, 15);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(25, 16);
            this.Label15.TabIndex = 508;
            this.Label15.Text = "R5";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(65, 15);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(25, 16);
            this.Label16.TabIndex = 507;
            this.Label16.Text = "R2";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(9, 15);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(25, 16);
            this.Label17.TabIndex = 506;
            this.Label17.Text = "R1";
            // 
            // btnAllOff2
            // 
            this.btnAllOff2.Location = new System.Drawing.Point(516, 43);
            this.btnAllOff2.Name = "btnAllOff2";
            this.btnAllOff2.Size = new System.Drawing.Size(106, 23);
            this.btnAllOff2.TabIndex = 513;
            this.btnAllOff2.Text = "Turn All Off";
            this.btnAllOff2.UseVisualStyleBackColor = true;
            this.btnAllOff2.Click += new System.EventHandler(this.btnAllOff2_Click);
            // 
            // btnAllOn2
            // 
            this.btnAllOn2.Location = new System.Drawing.Point(516, 15);
            this.btnAllOn2.Name = "btnAllOn2";
            this.btnAllOn2.Size = new System.Drawing.Size(106, 23);
            this.btnAllOn2.TabIndex = 515;
            this.btnAllOn2.Text = "Turn All On";
            this.btnAllOn2.UseVisualStyleBackColor = true;
            this.btnAllOn2.Click += new System.EventHandler(this.btnAllOn2_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(454, 15);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(56, 23);
            this.btnRead2.TabIndex = 514;
            this.btnRead2.Text = "Read";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
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
            this.GroupBox3.Controls.Add(this.btnAllOff1);
            this.GroupBox3.Controls.Add(this.btnAllOn1);
            this.GroupBox3.Controls.Add(this.btnRead1);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox3.Location = new System.Drawing.Point(240, 15);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(635, 73);
            this.GroupBox3.TabIndex = 526;
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
            this.chkB1R8.Click += new System.EventHandler(this.chkB1R8_Click);
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
            this.chkB1R4.Click += new System.EventHandler(this.chkB1R4_Click);
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
            this.chkB1R7.Click += new System.EventHandler(this.chkB1R7_Click);
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
            this.chkB1R3.Click += new System.EventHandler(this.chkB1R3_Click);
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
            this.chkB1R6.Click += new System.EventHandler(this.chkB1R6_Click);
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
            this.chkB1R5.Click += new System.EventHandler(this.chkB1R5_Click);
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
            this.chkB1R2.Click += new System.EventHandler(this.chkB1R2_Click);
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
            this.btnAllOff1.Location = new System.Drawing.Point(516, 43);
            this.btnAllOff1.Name = "btnAllOff1";
            this.btnAllOff1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOff1.TabIndex = 513;
            this.btnAllOff1.Text = "Turn All Off";
            this.btnAllOff1.UseVisualStyleBackColor = true;
            this.btnAllOff1.Click += new System.EventHandler(this.btnAllOff1_Click);
            // 
            // btnAllOn1
            // 
            this.btnAllOn1.Location = new System.Drawing.Point(516, 15);
            this.btnAllOn1.Name = "btnAllOn1";
            this.btnAllOn1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOn1.TabIndex = 515;
            this.btnAllOn1.Text = "Turn All On";
            this.btnAllOn1.UseVisualStyleBackColor = true;
            this.btnAllOn1.Click += new System.EventHandler(this.btnAllOn1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(454, 15);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(56, 23);
            this.btnRead1.TabIndex = 514;
            this.btnRead1.Text = "Read";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // frmI2CIO4R4x0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 193);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CIO4R4x0";
            this.Text = "MCP23017 I2CR16x";
            this.Load += new System.EventHandler(this.frmI2CDIO8_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.CheckBox chkB2R1;
        internal System.Windows.Forms.CheckBox chkB2R2;
        internal System.Windows.Forms.CheckBox chkB2R3;
        internal System.Windows.Forms.CheckBox chkB2R4;
        internal System.Windows.Forms.CheckBox chkB2R6;
        internal System.Windows.Forms.CheckBox chkB2R5;
        internal System.Windows.Forms.CheckBox chkB2R7;
        internal System.Windows.Forms.CheckBox chkB2R8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button btnAllOff2;
        internal System.Windows.Forms.Button btnAllOn2;
        internal System.Windows.Forms.Button btnRead2;
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
    }
}