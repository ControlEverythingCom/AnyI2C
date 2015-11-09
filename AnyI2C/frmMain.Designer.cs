﻿namespace AnyI2C
{
    partial class frmMain
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
            this.cmbI2CBridge = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.tvCommands = new System.Windows.Forms.TreeView();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmbShowFormat = new System.Windows.Forms.ComboBox();
            this.chkWrite = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuickSend = new System.Windows.Forms.TextBox();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.numReadLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbInfo = new AnyI2C.NumLabel();
            this.ctlI2CAddress1 = new AnyI2C.Controls.I2C.ctlI2CAddress();
            this.btnTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbI2CBridge
            // 
            this.cmbI2CBridge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbI2CBridge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbI2CBridge.DropDownWidth = 400;
            this.cmbI2CBridge.FormattingEnabled = true;
            this.cmbI2CBridge.Location = new System.Drawing.Point(84, 14);
            this.cmbI2CBridge.Name = "cmbI2CBridge";
            this.cmbI2CBridge.Size = new System.Drawing.Size(160, 21);
            this.cmbI2CBridge.TabIndex = 6;
            this.cmbI2CBridge.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbI2CBridge_DrawItem);
            this.cmbI2CBridge.SelectedIndexChanged += new System.EventHandler(this.cmbI2CBridge_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "I2C Adapter";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(250, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(14, 66);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(438, 251);
            this.lstDevices.TabIndex = 9;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // tvCommands
            // 
            this.tvCommands.Location = new System.Drawing.Point(14, 365);
            this.tvCommands.Name = "tvCommands";
            this.tvCommands.Size = new System.Drawing.Size(437, 366);
            this.tvCommands.TabIndex = 10;
            this.tvCommands.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCommands_AfterSelect);
            this.tvCommands.DoubleClick += new System.EventHandler(this.tvCommands_DoubleClick);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(475, 266);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(435, 465);
            this.txtLog.TabIndex = 11;
            // 
            // cmbShowFormat
            // 
            this.cmbShowFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbShowFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowFormat.FormattingEnabled = true;
            this.cmbShowFormat.Items.AddRange(new object[] {
            "HEX",
            "DEC"});
            this.cmbShowFormat.Location = new System.Drawing.Point(820, 144);
            this.cmbShowFormat.Name = "cmbShowFormat";
            this.cmbShowFormat.Size = new System.Drawing.Size(91, 21);
            this.cmbShowFormat.TabIndex = 29;
            this.cmbShowFormat.SelectedIndexChanged += new System.EventHandler(this.cmbShowFormat_SelectedIndexChanged);
            // 
            // chkWrite
            // 
            this.chkWrite.AutoSize = true;
            this.chkWrite.Location = new System.Drawing.Point(491, 142);
            this.chkWrite.Name = "chkWrite";
            this.chkWrite.Size = new System.Drawing.Size(51, 17);
            this.chkWrite.TabIndex = 32;
            this.chkWrite.Text = "Write";
            this.chkWrite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Data";
            // 
            // txtQuickSend
            // 
            this.txtQuickSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuickSend.Location = new System.Drawing.Point(585, 141);
            this.txtQuickSend.Multiline = true;
            this.txtQuickSend.Name = "txtQuickSend";
            this.txtQuickSend.Size = new System.Drawing.Size(225, 40);
            this.txtQuickSend.TabIndex = 30;
            this.txtQuickSend.TextChanged += new System.EventHandler(this.txtQuickSend_TextChanged);
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(491, 195);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(52, 17);
            this.chkRead.TabIndex = 36;
            this.chkRead.Text = "Read";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // numReadLength
            // 
            this.numReadLength.Location = new System.Drawing.Point(650, 194);
            this.numReadLength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numReadLength.Name = "numReadLength";
            this.numReadLength.Size = new System.Drawing.Size(53, 20);
            this.numReadLength.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Read Data Length";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(719, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 23);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Commands";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Log";
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Location = new System.Drawing.Point(0, 766);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(923, 13);
            this.lbStatus.TabIndex = 39;
            this.lbStatus.Text = "Status";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(820, 191);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 23);
            this.btnSend.TabIndex = 37;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(480, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(135, 23);
            this.btnScan.TabIndex = 8;
            this.btnScan.Text = "Scan I2C Devices";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 737);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.AutoSize = true;
            this.lbInfo.IsShowText = false;
            this.lbInfo.Location = new System.Drawing.Point(817, 168);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Prefix = "Length: ";
            this.lbInfo.Size = new System.Drawing.Size(94, 13);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Length:  0x0 [Hex]";
            this.lbInfo.Value = new int[] {
        0};
            // 
            // ctlI2CAddress1
            // 
            this.ctlI2CAddress1.Addr7 = ((byte)(0));
            this.ctlI2CAddress1.Location = new System.Drawing.Point(475, 48);
            this.ctlI2CAddress1.Name = "ctlI2CAddress1";
            this.ctlI2CAddress1.Size = new System.Drawing.Size(448, 67);
            this.ctlI2CAddress1.TabIndex = 12;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(112, 737);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 40;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(402, 15);
            this.numPort.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(49, 20);
            this.numPort.TabIndex = 41;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(923, 779);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkRead);
            this.Controls.Add(this.numReadLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.cmbShowFormat);
            this.Controls.Add(this.chkWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuickSend);
            this.Controls.Add(this.ctlI2CAddress1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tvCommands);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbI2CBridge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label26);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Any I2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbI2CBridge;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.TreeView tvCommands;
        private System.Windows.Forms.TextBox txtLog;
        private AnyI2C.Controls.I2C.ctlI2CAddress ctlI2CAddress1;
        private AnyI2C.NumLabel lbInfo;
        protected System.Windows.Forms.ComboBox cmbShowFormat;
        private System.Windows.Forms.CheckBox chkWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuickSend;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.NumericUpDown numReadLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPort;
    }
}

