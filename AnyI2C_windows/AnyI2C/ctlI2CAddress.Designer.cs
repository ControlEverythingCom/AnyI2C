namespace AnyI2C.Controls.I2C
{
    partial class ctlI2CAddress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.a0 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.Label();
            this.a5 = new System.Windows.Forms.Label();
            this.a6 = new System.Windows.Forms.Label();
            this.lb8BitValue = new System.Windows.Forms.Label();
            this.a7 = new System.Windows.Forms.Label();
            this.lbRW = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cmbAddress);
            this.GroupBox3.Controls.Add(this.a0);
            this.GroupBox3.Controls.Add(this.a1);
            this.GroupBox3.Controls.Add(this.a2);
            this.GroupBox3.Controls.Add(this.a3);
            this.GroupBox3.Controls.Add(this.a4);
            this.GroupBox3.Controls.Add(this.a5);
            this.GroupBox3.Controls.Add(this.a6);
            this.GroupBox3.Controls.Add(this.lb8BitValue);
            this.GroupBox3.Controls.Add(this.a7);
            this.GroupBox3.Controls.Add(this.lbRW);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(434, 61);
            this.GroupBox3.TabIndex = 485;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Device Address";
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(17, 32);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(74, 21);
            this.cmbAddress.TabIndex = 493;
            this.cmbAddress.SelectedIndexChanged += new System.EventHandler(this.cmbAddress_SelectedIndexChanged);
            // 
            // a0
            // 
            this.a0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a0.Location = new System.Drawing.Point(254, 34);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(16, 18);
            this.a0.TabIndex = 492;
            this.a0.Tag = "0";
            this.a0.Text = "0";
            this.a0.Click += new System.EventHandler(this.a7_Click);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1.Location = new System.Drawing.Point(232, 34);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(16, 18);
            this.a1.TabIndex = 492;
            this.a1.Tag = "1";
            this.a1.Text = "0";
            this.a1.Click += new System.EventHandler(this.a7_Click);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2.Location = new System.Drawing.Point(210, 34);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(16, 18);
            this.a2.TabIndex = 492;
            this.a2.Tag = "2";
            this.a2.Text = "0";
            this.a2.Click += new System.EventHandler(this.a7_Click);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a3.Location = new System.Drawing.Point(188, 34);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(16, 18);
            this.a3.TabIndex = 492;
            this.a3.Tag = "3";
            this.a3.Text = "0";
            this.a3.Click += new System.EventHandler(this.a7_Click);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a4.Location = new System.Drawing.Point(166, 34);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(16, 18);
            this.a4.TabIndex = 492;
            this.a4.Tag = "4";
            this.a4.Text = "0";
            this.a4.Click += new System.EventHandler(this.a7_Click);
            // 
            // a5
            // 
            this.a5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a5.Location = new System.Drawing.Point(144, 34);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(16, 18);
            this.a5.TabIndex = 492;
            this.a5.Tag = "5";
            this.a5.Text = "0";
            this.a5.Click += new System.EventHandler(this.a7_Click);
            // 
            // a6
            // 
            this.a6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a6.Location = new System.Drawing.Point(122, 34);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(16, 18);
            this.a6.TabIndex = 492;
            this.a6.Tag = "6";
            this.a6.Text = "0";
            this.a6.Click += new System.EventHandler(this.a7_Click);
            // 
            // lb8BitValue
            // 
            this.lb8BitValue.BackColor = System.Drawing.SystemColors.Control;
            this.lb8BitValue.Location = new System.Drawing.Point(325, 35);
            this.lb8BitValue.Name = "lb8BitValue";
            this.lb8BitValue.Size = new System.Drawing.Size(103, 18);
            this.lb8BitValue.TabIndex = 492;
            this.lb8BitValue.Text = "0";
            this.lb8BitValue.Visible = false;
            // 
            // a7
            // 
            this.a7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a7.Location = new System.Drawing.Point(100, 34);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(16, 18);
            this.a7.TabIndex = 492;
            this.a7.Tag = "7";
            this.a7.Text = "0";
            this.a7.Click += new System.EventHandler(this.a7_Click);
            // 
            // lbRW
            // 
            this.lbRW.AutoSize = true;
            this.lbRW.BackColor = System.Drawing.Color.Yellow;
            this.lbRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRW.Location = new System.Drawing.Point(274, 36);
            this.lbRW.Name = "lbRW";
            this.lbRW.Size = new System.Drawing.Size(43, 13);
            this.lbRW.TabIndex = 491;
            this.lbRW.Text = "WRITE";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(17, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(310, 13);
            this.Label1.TabIndex = 487;
            this.Label1.Text = "7-Bit Address       A6   A5   A4   A3   A2   A1   A0  R/W               ";
            // 
            // ctlI2CAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox3);
            this.Name = "ctlI2CAddress";
            this.Size = new System.Drawing.Size(448, 67);
            this.Load += new System.EventHandler(this.ctlI2CAddress_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lbRW;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label a0;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label a4;
        private System.Windows.Forms.Label a5;
        private System.Windows.Forms.Label a6;
        private System.Windows.Forms.Label lb8BitValue;
        private System.Windows.Forms.Label a7;
        private System.Windows.Forms.ComboBox cmbAddress;
    }
}
