namespace AnyI2C.Controls.I2C
{
    partial class ctlI2CByte
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
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Label();
            this.B4 = new System.Windows.Forms.Label();
            this.B5 = new System.Windows.Forms.Label();
            this.B6 = new System.Windows.Forms.Label();
            this.B7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(231, 2);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(22, 21);
            this.btnDown.TabIndex = 503;
            this.btnDown.Text = "-";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(209, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(21, 21);
            this.btnUp.TabIndex = 504;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.Color.White;
            this.txtHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(356, 3);
            this.txtHex.MaxLength = 3;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(34, 20);
            this.txtHex.TabIndex = 494;
            this.txtHex.Text = "0";
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            this.txtHex.Leave += new System.EventHandler(this.txtHex_Leave);
            // 
            // txtDec
            // 
            this.txtDec.BackColor = System.Drawing.Color.White;
            this.txtDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec.Location = new System.Drawing.Point(308, 3);
            this.txtDec.MaxLength = 3;
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(34, 20);
            this.txtDec.TabIndex = 495;
            this.txtDec.Text = "0";
            this.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDec.TextChanged += new System.EventHandler(this.txtDec_TextChanged);
            this.txtDec.Leave += new System.EventHandler(this.txtDec_Leave);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(3, 6);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(13, 13);
            this.lbID.TabIndex = 505;
            this.lbID.Text = "0";
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(276, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(22, 21);
            this.btnRight.TabIndex = 506;
            this.btnRight.Text = ">";
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(254, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(21, 21);
            this.btnLeft.TabIndex = 507;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B0.Location = new System.Drawing.Point(184, 4);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(16, 18);
            this.B0.TabIndex = 508;
            this.B0.Tag = "0";
            this.B0.Text = "0";
            this.B0.Click += new System.EventHandler(this.B7_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B1.Location = new System.Drawing.Point(162, 4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(16, 18);
            this.B1.TabIndex = 509;
            this.B1.Tag = "1";
            this.B1.Text = "0";
            this.B1.Click += new System.EventHandler(this.B7_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B2.Location = new System.Drawing.Point(140, 4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(16, 18);
            this.B2.TabIndex = 510;
            this.B2.Tag = "2";
            this.B2.Text = "0";
            this.B2.Click += new System.EventHandler(this.B7_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B3.Location = new System.Drawing.Point(118, 4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(16, 18);
            this.B3.TabIndex = 511;
            this.B3.Tag = "3";
            this.B3.Text = "0";
            this.B3.Click += new System.EventHandler(this.B7_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B4.Location = new System.Drawing.Point(96, 4);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(16, 18);
            this.B4.TabIndex = 512;
            this.B4.Tag = "4";
            this.B4.Text = "0";
            this.B4.Click += new System.EventHandler(this.B7_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B5.Location = new System.Drawing.Point(74, 4);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(16, 18);
            this.B5.TabIndex = 513;
            this.B5.Tag = "5";
            this.B5.Text = "0";
            this.B5.Click += new System.EventHandler(this.B7_Click);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B6.Location = new System.Drawing.Point(52, 4);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(16, 18);
            this.B6.TabIndex = 514;
            this.B6.Tag = "6";
            this.B6.Text = "0";
            this.B6.Click += new System.EventHandler(this.B7_Click);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B7.Location = new System.Drawing.Point(30, 4);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(16, 18);
            this.B7.TabIndex = 515;
            this.B7.Tag = "7";
            this.B7.Text = "0";
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // ctlI2CByte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtDec);
            this.Name = "ctlI2CByte";
            this.Size = new System.Drawing.Size(407, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        internal System.Windows.Forms.TextBox txtHex;
        internal System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label B0;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label B3;
        private System.Windows.Forms.Label B4;
        private System.Windows.Forms.Label B5;
        private System.Windows.Forms.Label B6;
        private System.Windows.Forms.Label B7;

    }
}
