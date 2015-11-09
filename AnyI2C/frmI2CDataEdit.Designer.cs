namespace AnyI2C.Controls
{
    partial class frmI2CDataEdit
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
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.numReadLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShowFormat = new System.Windows.Forms.ComboBox();
            this.chkWrite = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuickSend = new System.Windows.Forms.TextBox();
            this.panelItems = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lbInfo = new AnyI2C.NumLabel();
            this.ctlI2CAddress1 = new AnyI2C.Controls.I2C.ctlI2CAddress();
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).BeginInit();
            this.panelItems.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(18, 422);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(52, 17);
            this.chkRead.TabIndex = 20;
            this.chkRead.Text = "Read";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // numReadLength
            // 
            this.numReadLength.Location = new System.Drawing.Point(177, 421);
            this.numReadLength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numReadLength.Name = "numReadLength";
            this.numReadLength.Size = new System.Drawing.Size(53, 20);
            this.numReadLength.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Read Data Length";
            // 
            // cmbShowFormat
            // 
            this.cmbShowFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShowFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowFormat.FormattingEnabled = true;
            this.cmbShowFormat.Items.AddRange(new object[] {
            "HEX",
            "DEC"});
            this.cmbShowFormat.Location = new System.Drawing.Point(356, 85);
            this.cmbShowFormat.Name = "cmbShowFormat";
            this.cmbShowFormat.Size = new System.Drawing.Size(91, 21);
            this.cmbShowFormat.TabIndex = 21;
            this.cmbShowFormat.SelectedIndexChanged += new System.EventHandler(this.cmbShowFormat_SelectedIndexChanged);
            // 
            // chkWrite
            // 
            this.chkWrite.AutoSize = true;
            this.chkWrite.Location = new System.Drawing.Point(15, 85);
            this.chkWrite.Name = "chkWrite";
            this.chkWrite.Size = new System.Drawing.Size(51, 17);
            this.chkWrite.TabIndex = 24;
            this.chkWrite.Text = "Write";
            this.chkWrite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data";
            // 
            // txtQuickSend
            // 
            this.txtQuickSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuickSend.Location = new System.Drawing.Point(109, 84);
            this.txtQuickSend.Multiline = true;
            this.txtQuickSend.Name = "txtQuickSend";
            this.txtQuickSend.Size = new System.Drawing.Size(238, 40);
            this.txtQuickSend.TabIndex = 22;
            this.txtQuickSend.TextChanged += new System.EventHandler(this.txtQuickSend_TextChanged);
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelItems.Controls.Add(this.label1);
            this.panelItems.Location = new System.Drawing.Point(11, 130);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(438, 285);
            this.panelItems.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " #      B7   B6   B5   B4    B3  B2   B1   B0                                    " +
    "  Dec          Hex        Comment";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(343, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 531);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(44, 532);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(59, 23);
            this.btnCalc.TabIndex = 29;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Visible = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComment);
            this.groupBox2.Location = new System.Drawing.Point(10, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(438, 71);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(6, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(426, 46);
            this.txtComment.TabIndex = 0;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.AutoSize = true;
            this.lbInfo.IsShowText = false;
            this.lbInfo.Location = new System.Drawing.Point(353, 111);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Prefix = "Length: ";
            this.lbInfo.Size = new System.Drawing.Size(94, 13);
            this.lbInfo.TabIndex = 28;
            this.lbInfo.Text = "Length:  0x0 [Hex]";
            this.lbInfo.Value = new int[] {
        0};
            // 
            // ctlI2CAddress1
            // 
            this.ctlI2CAddress1.Addr7 = ((byte)(0));
            this.ctlI2CAddress1.Location = new System.Drawing.Point(12, 12);
            this.ctlI2CAddress1.Name = "ctlI2CAddress1";
            this.ctlI2CAddress1.Size = new System.Drawing.Size(443, 67);
            this.ctlI2CAddress1.TabIndex = 2;
            // 
            // frmI2CDataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.cmbShowFormat);
            this.Controls.Add(this.chkWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuickSend);
            this.Controls.Add(this.chkRead);
            this.Controls.Add(this.numReadLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctlI2CAddress1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmI2CDataEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit I2C Data";
            this.Load += new System.EventHandler(this.frmI2CDataEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).EndInit();
            this.panelItems.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private I2C.ctlI2CAddress ctlI2CAddress1;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.NumericUpDown numReadLength;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox cmbShowFormat;
        private System.Windows.Forms.CheckBox chkWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuickSend;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private NumLabel lbInfo;
        protected System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComment;

    }
}