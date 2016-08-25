namespace MCP23008_I2CDIO8
{
    partial class frmI2CDIO8
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
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.chkOutput7 = new System.Windows.Forms.CheckBox();
            this.chkOutput3 = new System.Windows.Forms.CheckBox();
            this.chkOutput6 = new System.Windows.Forms.CheckBox();
            this.chkOutput2 = new System.Windows.Forms.CheckBox();
            this.chkOutput5 = new System.Windows.Forms.CheckBox();
            this.chkOutput4 = new System.Windows.Forms.CheckBox();
            this.chkOutput1 = new System.Windows.Forms.CheckBox();
            this.chkOutput0 = new System.Windows.Forms.CheckBox();
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
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lbInput7 = new System.Windows.Forms.Label();
            this.lbInput6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInput5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbInput4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbInput3 = new System.Windows.Forms.Label();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.lbInput2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInput1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInput0 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupOutput.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupInput.SuspendLayout();
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
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.chkOutput7);
            this.groupOutput.Controls.Add(this.chkOutput3);
            this.groupOutput.Controls.Add(this.chkOutput6);
            this.groupOutput.Controls.Add(this.chkOutput2);
            this.groupOutput.Controls.Add(this.btnAllOff1);
            this.groupOutput.Controls.Add(this.btnAllOn1);
            this.groupOutput.Controls.Add(this.chkOutput5);
            this.groupOutput.Controls.Add(this.btnRead1);
            this.groupOutput.Controls.Add(this.chkOutput4);
            this.groupOutput.Controls.Add(this.chkOutput1);
            this.groupOutput.Controls.Add(this.chkOutput0);
            this.groupOutput.Controls.Add(this.Label9);
            this.groupOutput.Controls.Add(this.Label5);
            this.groupOutput.Controls.Add(this.label18);
            this.groupOutput.Controls.Add(this.label19);
            this.groupOutput.Controls.Add(this.label20);
            this.groupOutput.Controls.Add(this.label21);
            this.groupOutput.Controls.Add(this.label22);
            this.groupOutput.Controls.Add(this.label23);
            this.groupOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupOutput.Location = new System.Drawing.Point(249, 32);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(494, 116);
            this.groupOutput.TabIndex = 542;
            this.groupOutput.TabStop = false;
            // 
            // chkOutput7
            // 
            this.chkOutput7.AutoSize = true;
            this.chkOutput7.Location = new System.Drawing.Point(423, 47);
            this.chkOutput7.Name = "chkOutput7";
            this.chkOutput7.Size = new System.Drawing.Size(59, 20);
            this.chkOutput7.TabIndex = 523;
            this.chkOutput7.Tag = "8";
            this.chkOutput7.Text = "High";
            this.chkOutput7.UseVisualStyleBackColor = true;
            this.chkOutput7.Click += new System.EventHandler(this.chkB1R8_Clicked);
            // 
            // chkOutput3
            // 
            this.chkOutput3.AutoSize = true;
            this.chkOutput3.Location = new System.Drawing.Point(187, 47);
            this.chkOutput3.Name = "chkOutput3";
            this.chkOutput3.Size = new System.Drawing.Size(59, 20);
            this.chkOutput3.TabIndex = 522;
            this.chkOutput3.Tag = "4";
            this.chkOutput3.Text = "High";
            this.chkOutput3.UseVisualStyleBackColor = true;
            this.chkOutput3.Click += new System.EventHandler(this.chkB1R4_Clicked);
            // 
            // chkOutput6
            // 
            this.chkOutput6.AutoSize = true;
            this.chkOutput6.Location = new System.Drawing.Point(364, 47);
            this.chkOutput6.Name = "chkOutput6";
            this.chkOutput6.Size = new System.Drawing.Size(59, 20);
            this.chkOutput6.TabIndex = 521;
            this.chkOutput6.Tag = "7";
            this.chkOutput6.Text = "High";
            this.chkOutput6.UseVisualStyleBackColor = true;
            this.chkOutput6.Click += new System.EventHandler(this.chkB1R7_Clicked);
            // 
            // chkOutput2
            // 
            this.chkOutput2.AutoSize = true;
            this.chkOutput2.Location = new System.Drawing.Point(128, 47);
            this.chkOutput2.Name = "chkOutput2";
            this.chkOutput2.Size = new System.Drawing.Size(59, 20);
            this.chkOutput2.TabIndex = 520;
            this.chkOutput2.Tag = "3";
            this.chkOutput2.Text = "High";
            this.chkOutput2.UseVisualStyleBackColor = true;
            this.chkOutput2.Click += new System.EventHandler(this.chkB1R3_Clicked);
            // 
            // chkOutput5
            // 
            this.chkOutput5.AutoSize = true;
            this.chkOutput5.Location = new System.Drawing.Point(305, 47);
            this.chkOutput5.Name = "chkOutput5";
            this.chkOutput5.Size = new System.Drawing.Size(59, 20);
            this.chkOutput5.TabIndex = 519;
            this.chkOutput5.Tag = "6";
            this.chkOutput5.Text = "High";
            this.chkOutput5.UseVisualStyleBackColor = true;
            this.chkOutput5.Click += new System.EventHandler(this.chkB1R6_Clicked);
            // 
            // chkOutput4
            // 
            this.chkOutput4.AutoSize = true;
            this.chkOutput4.Location = new System.Drawing.Point(246, 47);
            this.chkOutput4.Name = "chkOutput4";
            this.chkOutput4.Size = new System.Drawing.Size(59, 20);
            this.chkOutput4.TabIndex = 518;
            this.chkOutput4.Tag = "5";
            this.chkOutput4.Text = "High";
            this.chkOutput4.UseVisualStyleBackColor = true;
            this.chkOutput4.Click += new System.EventHandler(this.chkB1R5_Clicked);
            // 
            // chkOutput1
            // 
            this.chkOutput1.AutoSize = true;
            this.chkOutput1.Location = new System.Drawing.Point(69, 47);
            this.chkOutput1.Name = "chkOutput1";
            this.chkOutput1.Size = new System.Drawing.Size(59, 20);
            this.chkOutput1.TabIndex = 517;
            this.chkOutput1.Tag = "2";
            this.chkOutput1.Text = "High";
            this.chkOutput1.UseVisualStyleBackColor = true;
            this.chkOutput1.Click += new System.EventHandler(this.chkB1R2_Clicked);
            // 
            // chkOutput0
            // 
            this.chkOutput0.AutoSize = true;
            this.chkOutput0.Location = new System.Drawing.Point(10, 47);
            this.chkOutput0.Name = "chkOutput0";
            this.chkOutput0.Size = new System.Drawing.Size(59, 20);
            this.chkOutput0.TabIndex = 516;
            this.chkOutput0.Tag = "1";
            this.chkOutput0.Text = "High";
            this.chkOutput0.UseVisualStyleBackColor = true;
            this.chkOutput0.Click += new System.EventHandler(this.chkB1R1_Clicked);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(438, 28);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(25, 16);
            this.Label9.TabIndex = 512;
            this.Label9.Text = "R8";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(206, 28);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(25, 16);
            this.Label5.TabIndex = 505;
            this.Label5.Text = "R4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(380, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 511;
            this.label18.Text = "R7";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(148, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 510;
            this.label19.Text = "R3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(322, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 509;
            this.label20.Text = "R6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(264, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 16);
            this.label21.TabIndex = 508;
            this.label21.Text = "R5";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(90, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 16);
            this.label22.TabIndex = 507;
            this.label22.Text = "R2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(32, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 16);
            this.label23.TabIndex = 506;
            this.label23.Text = "R1";
            // 
            // btnAllOff1
            // 
            this.btnAllOff1.Location = new System.Drawing.Point(305, 83);
            this.btnAllOff1.Name = "btnAllOff1";
            this.btnAllOff1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOff1.TabIndex = 513;
            this.btnAllOff1.Text = "Turn All Low";
            this.btnAllOff1.UseVisualStyleBackColor = true;
            this.btnAllOff1.Click += new System.EventHandler(this.btnAllOff1_Click);
            // 
            // btnAllOn1
            // 
            this.btnAllOn1.Location = new System.Drawing.Point(152, 84);
            this.btnAllOn1.Name = "btnAllOn1";
            this.btnAllOn1.Size = new System.Drawing.Size(106, 23);
            this.btnAllOn1.TabIndex = 515;
            this.btnAllOn1.Text = "Turn All High";
            this.btnAllOn1.UseVisualStyleBackColor = true;
            this.btnAllOn1.Click += new System.EventHandler(this.btnAllOn1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(54, 84);
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
            this.GroupBox1.Text = "I2CDIO Hardware Address";
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
            this._ERROR.Location = new System.Drawing.Point(12, 206);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(217, 65);
            this._ERROR.TabIndex = 541;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lbInput7);
            this.groupInput.Controls.Add(this.lbInput6);
            this.groupInput.Controls.Add(this.label6);
            this.groupInput.Controls.Add(this.lbInput5);
            this.groupInput.Controls.Add(this.label7);
            this.groupInput.Controls.Add(this.lbInput4);
            this.groupInput.Controls.Add(this.label8);
            this.groupInput.Controls.Add(this.lbInput3);
            this.groupInput.Controls.Add(this.btnReadInput);
            this.groupInput.Controls.Add(this.lbInput2);
            this.groupInput.Controls.Add(this.label4);
            this.groupInput.Controls.Add(this.lbInput0);
            this.groupInput.Controls.Add(this.lbInput1);
            this.groupInput.Controls.Add(this.label24);
            this.groupInput.Controls.Add(this.label3);
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInput.Location = new System.Drawing.Point(249, 188);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(494, 117);
            this.groupInput.TabIndex = 544;
            this.groupInput.TabStop = false;
            // 
            // lbInput7
            // 
            this.lbInput7.AutoSize = true;
            this.lbInput7.Location = new System.Drawing.Point(442, 52);
            this.lbInput7.Name = "lbInput7";
            this.lbInput7.Size = new System.Drawing.Size(32, 16);
            this.lbInput7.TabIndex = 1;
            this.lbInput7.Text = "Low";
            // 
            // lbInput6
            // 
            this.lbInput6.AutoSize = true;
            this.lbInput6.Location = new System.Drawing.Point(381, 52);
            this.lbInput6.Name = "lbInput6";
            this.lbInput6.Size = new System.Drawing.Size(32, 16);
            this.lbInput6.TabIndex = 2;
            this.lbInput6.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "7";
            // 
            // lbInput5
            // 
            this.lbInput5.AutoSize = true;
            this.lbInput5.Location = new System.Drawing.Point(320, 52);
            this.lbInput5.Name = "lbInput5";
            this.lbInput5.Size = new System.Drawing.Size(32, 16);
            this.lbInput5.TabIndex = 3;
            this.lbInput5.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "6";
            // 
            // lbInput4
            // 
            this.lbInput4.AutoSize = true;
            this.lbInput4.Location = new System.Drawing.Point(259, 52);
            this.lbInput4.Name = "lbInput4";
            this.lbInput4.Size = new System.Drawing.Size(32, 16);
            this.lbInput4.TabIndex = 4;
            this.lbInput4.Text = "Low";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "5";
            // 
            // lbInput3
            // 
            this.lbInput3.AutoSize = true;
            this.lbInput3.Location = new System.Drawing.Point(198, 52);
            this.lbInput3.Name = "lbInput3";
            this.lbInput3.Size = new System.Drawing.Size(32, 16);
            this.lbInput3.TabIndex = 0;
            this.lbInput3.Text = "Low";
            // 
            // btnReadInput
            // 
            this.btnReadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInput.Location = new System.Drawing.Point(58, 83);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(56, 23);
            this.btnReadInput.TabIndex = 533;
            this.btnReadInput.Text = "Read";
            this.btnReadInput.UseVisualStyleBackColor = true;
            // 
            // lbInput2
            // 
            this.lbInput2.AutoSize = true;
            this.lbInput2.Location = new System.Drawing.Point(137, 52);
            this.lbInput2.Name = "lbInput2";
            this.lbInput2.Size = new System.Drawing.Size(32, 16);
            this.lbInput2.TabIndex = 0;
            this.lbInput2.Text = "Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // lbInput1
            // 
            this.lbInput1.AutoSize = true;
            this.lbInput1.Location = new System.Drawing.Point(76, 52);
            this.lbInput1.Name = "lbInput1";
            this.lbInput1.Size = new System.Drawing.Size(32, 16);
            this.lbInput1.TabIndex = 0;
            this.lbInput1.Text = "Low";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(25, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 16);
            this.label24.TabIndex = 525;
            this.label24.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // lbInput0
            // 
            this.lbInput0.AutoSize = true;
            this.lbInput0.Location = new System.Drawing.Point(15, 52);
            this.lbInput0.Name = "lbInput0";
            this.lbInput0.Size = new System.Drawing.Size(32, 16);
            this.lbInput0.TabIndex = 0;
            this.lbInput0.Text = "Low";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(249, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 19);
            this.radioButton1.TabIndex = 545;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Setup as Output";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(249, 165);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 19);
            this.radioButton2.TabIndex = 545;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Setup As Input";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // frmI2CDIO8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 317);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CDIO8";
            this.Text = "MCP23008 I2CDIO8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CDIO8_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CDIO8_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox groupOutput;
        internal System.Windows.Forms.CheckBox chkOutput7;
        internal System.Windows.Forms.CheckBox chkOutput3;
        internal System.Windows.Forms.CheckBox chkOutput6;
        internal System.Windows.Forms.CheckBox chkOutput2;
        internal System.Windows.Forms.CheckBox chkOutput5;
        internal System.Windows.Forms.CheckBox chkOutput4;
        internal System.Windows.Forms.CheckBox chkOutput1;
        internal System.Windows.Forms.CheckBox chkOutput0;
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
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Label lbInput7;
        private System.Windows.Forms.Label lbInput6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInput5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbInput4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbInput3;
        internal System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.Label lbInput2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInput1;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInput0;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}