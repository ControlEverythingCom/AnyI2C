namespace PCA9633_I2CS
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
            this.scrollValue4 = new System.Windows.Forms.HScrollBar();
            this.Label6 = new System.Windows.Forms.Label();
            this.scrollValue3 = new System.Windows.Forms.HScrollBar();
            this.Label8 = new System.Windows.Forms.Label();
            this.scrollValue2 = new System.Windows.Forms.HScrollBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.scrollValue1 = new System.Windows.Forms.HScrollBar();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this._ERROR = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.scrollValueGroup = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollValue4
            // 
            this.scrollValue4.LargeChange = 1;
            this.scrollValue4.Location = new System.Drawing.Point(427, 235);
            this.scrollValue4.Maximum = 255;
            this.scrollValue4.Name = "scrollValue4";
            this.scrollValue4.Size = new System.Drawing.Size(250, 20);
            this.scrollValue4.TabIndex = 534;
            this.scrollValue4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue4_Scroll);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(297, 229);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(66, 29);
            this.Label6.TabIndex = 533;
            this.Label6.Text = "Ch 4";
            // 
            // scrollValue3
            // 
            this.scrollValue3.LargeChange = 1;
            this.scrollValue3.Location = new System.Drawing.Point(427, 208);
            this.scrollValue3.Maximum = 255;
            this.scrollValue3.Name = "scrollValue3";
            this.scrollValue3.Size = new System.Drawing.Size(250, 20);
            this.scrollValue3.TabIndex = 532;
            this.scrollValue3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue3_Scroll);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(297, 202);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(66, 29);
            this.Label8.TabIndex = 531;
            this.Label8.Text = "Ch 3";
            // 
            // scrollValue2
            // 
            this.scrollValue2.LargeChange = 1;
            this.scrollValue2.Location = new System.Drawing.Point(427, 182);
            this.scrollValue2.Maximum = 255;
            this.scrollValue2.Name = "scrollValue2";
            this.scrollValue2.Size = new System.Drawing.Size(250, 20);
            this.scrollValue2.TabIndex = 530;
            this.scrollValue2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue2_Scroll);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(297, 176);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 29);
            this.Label4.TabIndex = 529;
            this.Label4.Text = "Ch 2";
            // 
            // scrollValue1
            // 
            this.scrollValue1.LargeChange = 1;
            this.scrollValue1.Location = new System.Drawing.Point(427, 155);
            this.scrollValue1.Maximum = 255;
            this.scrollValue1.Name = "scrollValue1";
            this.scrollValue1.Size = new System.Drawing.Size(250, 20);
            this.scrollValue1.TabIndex = 528;
            this.scrollValue1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValue1_Scroll);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(297, 149);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 29);
            this.Label2.TabIndex = 526;
            this.Label2.Text = "Ch 1";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRead.Location = new System.Drawing.Point(302, 23);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 32);
            this.btnRead.TabIndex = 524;
            this.btnRead.Text = "Read Group";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ERROR.Location = new System.Drawing.Point(5, 209);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(270, 46);
            this._ERROR.TabIndex = 527;
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
            this.GroupBox6.Size = new System.Drawing.Size(271, 188);
            this.GroupBox6.TabIndex = 525;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "PCA9633 Controller";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 541;
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
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(241, 68);
            this.GroupBox1.TabIndex = 491;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "PCA9633 Hardware Address";
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
            // scrollValueGroup
            // 
            this.scrollValueGroup.LargeChange = 1;
            this.scrollValueGroup.Location = new System.Drawing.Point(427, 73);
            this.scrollValueGroup.Maximum = 255;
            this.scrollValueGroup.Name = "scrollValueGroup";
            this.scrollValueGroup.Size = new System.Drawing.Size(250, 20);
            this.scrollValueGroup.TabIndex = 536;
            this.scrollValueGroup.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollValueGroup_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 535;
            this.label1.Text = "Ch Group";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(302, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 537;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmI2CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scrollValueGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrollValue4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.scrollValue3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.scrollValue2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.scrollValue1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.GroupBox6);
            this.Name = "frmI2CS";
            this.Text = "PCA9633 Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.GroupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.HScrollBar scrollValue4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.HScrollBar scrollValue3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.HScrollBar scrollValue2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.HScrollBar scrollValue1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.HScrollBar scrollValueGroup;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button1;
    }
}