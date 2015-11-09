namespace I2CDIO8
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
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.rdInput = new System.Windows.Forms.RadioButton();
            this.rdOutput = new System.Windows.Forms.RadioButton();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lbInput8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbInput7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInput6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbInput5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbInput4 = new System.Windows.Forms.Label();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.lbInput3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInput2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInput1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.btnAllHigh = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.btnAllLow = new System.Windows.Forms.Button();
            this.btnReadOutput = new System.Windows.Forms.Button();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupInput.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(15, 131);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(219, 103);
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
            this.GroupBox1.Size = new System.Drawing.Size(216, 68);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "I2CDIO8 Hardware Address";
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
            32,
            0,
            0,
            0});
            // 
            // rdInput
            // 
            this.rdInput.AutoSize = true;
            this.rdInput.Location = new System.Drawing.Point(259, 21);
            this.rdInput.Name = "rdInput";
            this.rdInput.Size = new System.Drawing.Size(49, 17);
            this.rdInput.TabIndex = 509;
            this.rdInput.TabStop = true;
            this.rdInput.Text = "Input";
            this.rdInput.UseVisualStyleBackColor = true;
            this.rdInput.CheckedChanged += new System.EventHandler(this.rdInput_CheckedChanged);
            // 
            // rdOutput
            // 
            this.rdOutput.AutoSize = true;
            this.rdOutput.Location = new System.Drawing.Point(259, 169);
            this.rdOutput.Name = "rdOutput";
            this.rdOutput.Size = new System.Drawing.Size(57, 17);
            this.rdOutput.TabIndex = 509;
            this.rdOutput.TabStop = true;
            this.rdOutput.Text = "Output";
            this.rdOutput.UseVisualStyleBackColor = true;
            this.rdOutput.CheckedChanged += new System.EventHandler(this.rdOutput_CheckedChanged);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lbInput8);
            this.groupInput.Controls.Add(this.label5);
            this.groupInput.Controls.Add(this.lbInput7);
            this.groupInput.Controls.Add(this.label6);
            this.groupInput.Controls.Add(this.lbInput6);
            this.groupInput.Controls.Add(this.label7);
            this.groupInput.Controls.Add(this.lbInput5);
            this.groupInput.Controls.Add(this.label8);
            this.groupInput.Controls.Add(this.lbInput4);
            this.groupInput.Controls.Add(this.btnReadInput);
            this.groupInput.Controls.Add(this.lbInput3);
            this.groupInput.Controls.Add(this.label4);
            this.groupInput.Controls.Add(this.lbInput2);
            this.groupInput.Controls.Add(this.label3);
            this.groupInput.Controls.Add(this.lbInput1);
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInput.Location = new System.Drawing.Point(259, 44);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(444, 104);
            this.groupInput.TabIndex = 510;
            this.groupInput.TabStop = false;
            // 
            // lbInput8
            // 
            this.lbInput8.AutoSize = true;
            this.lbInput8.Location = new System.Drawing.Point(388, 52);
            this.lbInput8.Name = "lbInput8";
            this.lbInput8.Size = new System.Drawing.Size(32, 16);
            this.lbInput8.TabIndex = 1;
            this.lbInput8.Text = "Low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "8";
            // 
            // lbInput7
            // 
            this.lbInput7.AutoSize = true;
            this.lbInput7.Location = new System.Drawing.Point(334, 52);
            this.lbInput7.Name = "lbInput7";
            this.lbInput7.Size = new System.Drawing.Size(32, 16);
            this.lbInput7.TabIndex = 2;
            this.lbInput7.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "7";
            // 
            // lbInput6
            // 
            this.lbInput6.AutoSize = true;
            this.lbInput6.Location = new System.Drawing.Point(280, 52);
            this.lbInput6.Name = "lbInput6";
            this.lbInput6.Size = new System.Drawing.Size(32, 16);
            this.lbInput6.TabIndex = 3;
            this.lbInput6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "6";
            // 
            // lbInput5
            // 
            this.lbInput5.AutoSize = true;
            this.lbInput5.Location = new System.Drawing.Point(226, 52);
            this.lbInput5.Name = "lbInput5";
            this.lbInput5.Size = new System.Drawing.Size(32, 16);
            this.lbInput5.TabIndex = 4;
            this.lbInput5.Text = "Low";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "5";
            // 
            // lbInput4
            // 
            this.lbInput4.AutoSize = true;
            this.lbInput4.Location = new System.Drawing.Point(172, 52);
            this.lbInput4.Name = "lbInput4";
            this.lbInput4.Size = new System.Drawing.Size(32, 16);
            this.lbInput4.TabIndex = 0;
            this.lbInput4.Text = "Low";
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(310, 75);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(56, 23);
            this.btnReadInput.TabIndex = 533;
            this.btnReadInput.Text = "Read";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // lbInput3
            // 
            this.lbInput3.AutoSize = true;
            this.lbInput3.Location = new System.Drawing.Point(118, 52);
            this.lbInput3.Name = "lbInput3";
            this.lbInput3.Size = new System.Drawing.Size(32, 16);
            this.lbInput3.TabIndex = 0;
            this.lbInput3.Text = "Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // lbInput2
            // 
            this.lbInput2.AutoSize = true;
            this.lbInput2.Location = new System.Drawing.Point(64, 52);
            this.lbInput2.Name = "lbInput2";
            this.lbInput2.Size = new System.Drawing.Size(32, 16);
            this.lbInput2.TabIndex = 0;
            this.lbInput2.Text = "Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // lbInput1
            // 
            this.lbInput1.AutoSize = true;
            this.lbInput1.Location = new System.Drawing.Point(21, 52);
            this.lbInput1.Name = "lbInput1";
            this.lbInput1.Size = new System.Drawing.Size(21, 16);
            this.lbInput1.TabIndex = 0;
            this.lbInput1.Text = "Hi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.CheckBox6);
            this.groupOutput.Controls.Add(this.label21);
            this.groupOutput.Controls.Add(this.CheckBox7);
            this.groupOutput.Controls.Add(this.label19);
            this.groupOutput.Controls.Add(this.CheckBox8);
            this.groupOutput.Controls.Add(this.btnAllHigh);
            this.groupOutput.Controls.Add(this.label17);
            this.groupOutput.Controls.Add(this.CheckBox4);
            this.groupOutput.Controls.Add(this.btnAllLow);
            this.groupOutput.Controls.Add(this.btnReadOutput);
            this.groupOutput.Controls.Add(this.CheckBox3);
            this.groupOutput.Controls.Add(this.CheckBox5);
            this.groupOutput.Controls.Add(this.label24);
            this.groupOutput.Controls.Add(this.label23);
            this.groupOutput.Controls.Add(this.CheckBox2);
            this.groupOutput.Controls.Add(this.label22);
            this.groupOutput.Controls.Add(this.CheckBox1);
            this.groupOutput.Controls.Add(this.label20);
            this.groupOutput.Controls.Add(this.label18);
            this.groupOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOutput.Location = new System.Drawing.Point(259, 192);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(444, 108);
            this.groupOutput.TabIndex = 510;
            this.groupOutput.TabStop = false;
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(287, 49);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(51, 20);
            this.CheckBox6.TabIndex = 538;
            this.CheckBox6.Tag = "6";
            this.CheckBox6.Text = "Low";
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.Click += new System.EventHandler(this.CheckBox6_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(287, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 16);
            this.label21.TabIndex = 528;
            this.label21.Text = "6";
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(341, 49);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(51, 20);
            this.CheckBox7.TabIndex = 540;
            this.CheckBox7.Tag = "7";
            this.CheckBox7.Text = "Low";
            this.CheckBox7.UseVisualStyleBackColor = true;
            this.CheckBox7.Click += new System.EventHandler(this.CheckBox7_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(341, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 16);
            this.label19.TabIndex = 530;
            this.label19.Text = "7";
            // 
            // CheckBox8
            // 
            this.CheckBox8.AutoSize = true;
            this.CheckBox8.Location = new System.Drawing.Point(395, 49);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(51, 20);
            this.CheckBox8.TabIndex = 542;
            this.CheckBox8.Tag = "8";
            this.CheckBox8.Text = "Low";
            this.CheckBox8.UseVisualStyleBackColor = true;
            this.CheckBox8.Click += new System.EventHandler(this.CheckBox8_Click);
            // 
            // btnAllHigh
            // 
            this.btnAllHigh.Location = new System.Drawing.Point(48, 72);
            this.btnAllHigh.Name = "btnAllHigh";
            this.btnAllHigh.Size = new System.Drawing.Size(106, 23);
            this.btnAllHigh.TabIndex = 534;
            this.btnAllHigh.Text = "Turn All High";
            this.btnAllHigh.UseVisualStyleBackColor = true;
            this.btnAllHigh.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(395, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 16);
            this.label17.TabIndex = 531;
            this.label17.Text = "8";
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(179, 49);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(51, 20);
            this.CheckBox4.TabIndex = 541;
            this.CheckBox4.Tag = "4";
            this.CheckBox4.Text = "Low";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.Click += new System.EventHandler(this.CheckBox4_Click);
            // 
            // btnAllLow
            // 
            this.btnAllLow.Location = new System.Drawing.Point(178, 72);
            this.btnAllLow.Name = "btnAllLow";
            this.btnAllLow.Size = new System.Drawing.Size(106, 23);
            this.btnAllLow.TabIndex = 532;
            this.btnAllLow.Text = "Turn All Low";
            this.btnAllLow.UseVisualStyleBackColor = true;
            this.btnAllLow.Click += new System.EventHandler(this.btnAllOff_Click);
            // 
            // btnReadOutput
            // 
            this.btnReadOutput.Location = new System.Drawing.Point(310, 72);
            this.btnReadOutput.Name = "btnReadOutput";
            this.btnReadOutput.Size = new System.Drawing.Size(56, 23);
            this.btnReadOutput.TabIndex = 533;
            this.btnReadOutput.Text = "Read";
            this.btnReadOutput.UseVisualStyleBackColor = true;
            this.btnReadOutput.Click += new System.EventHandler(this.btnReadOutput_Click);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(125, 49);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(51, 20);
            this.CheckBox3.TabIndex = 539;
            this.CheckBox3.Tag = "3";
            this.CheckBox3.Text = "Low";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.Click += new System.EventHandler(this.CheckBox3_Click);
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(233, 49);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(51, 20);
            this.CheckBox5.TabIndex = 537;
            this.CheckBox5.Tag = "5";
            this.CheckBox5.Text = "Low";
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.Click += new System.EventHandler(this.CheckBox5_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 16);
            this.label24.TabIndex = 525;
            this.label24.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(71, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 16);
            this.label23.TabIndex = 526;
            this.label23.Text = "2";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(71, 49);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(51, 20);
            this.CheckBox2.TabIndex = 536;
            this.CheckBox2.Tag = "2";
            this.CheckBox2.Text = "Low";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.Click += new System.EventHandler(this.CheckBox2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(233, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 16);
            this.label22.TabIndex = 527;
            this.label22.Text = "5";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(17, 49);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(51, 20);
            this.CheckBox1.TabIndex = 535;
            this.CheckBox1.Tag = "1";
            this.CheckBox1.Text = "Low";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(125, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 16);
            this.label20.TabIndex = 529;
            this.label20.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(179, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 16);
            this.label18.TabIndex = 524;
            this.label18.Text = "4";
            // 
            // frmI2CDIO8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 334);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.rdOutput);
            this.Controls.Add(this.rdInput);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CDIO8";
            this.Text = "I2CDIO8";
            this.Load += new System.EventHandler(this.frmI2CDIO8_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.RadioButton rdInput;
        private System.Windows.Forms.RadioButton rdOutput;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.Label lbInput8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbInput7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInput6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbInput5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbInput4;
        private System.Windows.Forms.Label lbInput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox CheckBox7;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.CheckBox CheckBox8;
        internal System.Windows.Forms.Button btnAllHigh;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.CheckBox CheckBox4;
        internal System.Windows.Forms.Button btnAllLow;
        internal System.Windows.Forms.Button btnReadOutput;
        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.CheckBox CheckBox5;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.CheckBox CheckBox6;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Button btnReadInput;
    }
}