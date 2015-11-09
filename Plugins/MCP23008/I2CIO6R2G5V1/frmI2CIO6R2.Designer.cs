namespace MCP23008_I2CIO6R2
{
    partial class frmI2CIO6R2
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
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lbInput8 = new System.Windows.Forms.Label();
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
            this.label24 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupInput.SuspendLayout();
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
            this.GroupBox1.Text = "I2CIO6R2G5V1 Hardware Address";
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
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lbInput8);
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
            this.groupInput.Controls.Add(this.label24);
            this.groupInput.Controls.Add(this.label3);
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.checkBox2);
            this.groupInput.Controls.Add(this.CheckBox1);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInput.Location = new System.Drawing.Point(259, 12);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(444, 159);
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
            this.label6.Location = new System.Drawing.Point(399, 21);
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
            this.label7.Location = new System.Drawing.Point(346, 21);
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
            this.label8.Location = new System.Drawing.Point(293, 21);
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
            this.btnReadInput.Location = new System.Drawing.Point(269, 105);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(145, 36);
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
            this.label4.Location = new System.Drawing.Point(240, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 16);
            this.label24.TabIndex = 525;
            this.label24.Text = "R1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(69, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 20);
            this.checkBox2.TabIndex = 535;
            this.checkBox2.Tag = "1";
            this.checkBox2.Text = "Off";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(6, 52);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(43, 20);
            this.CheckBox1.TabIndex = 535;
            this.CheckBox1.Tag = "1";
            this.CheckBox1.Text = "Off";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            this.CheckBox1.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "R2";
            // 
            // frmI2CIO6R2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 180);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this._ERROR);
            this.Name = "frmI2CIO6R2";
            this.Text = "MCP23008 I2CIO6R2G5V1";
            this.Load += new System.EventHandler(this.frmI2CDIO8_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Label lbInput8;
        private System.Windows.Forms.Label lbInput7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInput6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbInput5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbInput4;
        private System.Windows.Forms.Label lbInput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button btnReadInput;
        internal System.Windows.Forms.CheckBox checkBox2;
    }
}