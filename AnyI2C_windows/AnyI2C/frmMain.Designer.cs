namespace AnyI2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.lbDevices = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lbManufactory = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbGeneralCall = new System.Windows.Forms.Label();
            this.lbCommandDes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLogDataType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbInfo = new AnyI2C.NumLabel();
            this.ctlI2CAddress1 = new AnyI2C.Controls.I2C.ctlI2CAddress();
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.cmbI2CBridge.Size = new System.Drawing.Size(197, 21);
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
            this.btnOpen.Location = new System.Drawing.Point(287, 12);
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
            this.lstDevices.Location = new System.Drawing.Point(19, 66);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(433, 251);
            this.lstDevices.TabIndex = 9;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // tvCommands
            // 
            this.tvCommands.Location = new System.Drawing.Point(8, 17);
            this.tvCommands.Name = "tvCommands";
            this.tvCommands.Size = new System.Drawing.Size(433, 253);
            this.tvCommands.TabIndex = 10;
            this.tvCommands.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCommands_AfterSelect);
            this.tvCommands.DoubleClick += new System.EventHandler(this.tvCommands_DoubleClick);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(475, 266);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
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
            this.cmbShowFormat.Location = new System.Drawing.Point(820, 142);
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
            this.txtQuickSend.Location = new System.Drawing.Point(585, 139);
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
            this.btnEdit.Text = "Bit Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbDevices
            // 
            this.lbDevices.AutoSize = true;
            this.lbDevices.Location = new System.Drawing.Point(16, 48);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(41, 13);
            this.lbDevices.TabIndex = 38;
            this.lbDevices.Text = "Device";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Log";
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Location = new System.Drawing.Point(0, 761);
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
            this.btnLoad.Location = new System.Drawing.Point(593, 740);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(686, 740);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 40;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
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
            // lbManufactory
            // 
            this.lbManufactory.AutoSize = true;
            this.lbManufactory.Location = new System.Drawing.Point(6, 20);
            this.lbManufactory.Name = "lbManufactory";
            this.lbManufactory.Size = new System.Drawing.Size(66, 13);
            this.lbManufactory.TabIndex = 42;
            this.lbManufactory.Text = "Manufactory";
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(5, 37);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(282, 26);
            this.lbType.TabIndex = 42;
            this.lbType.Text = "Type";
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(7, 66);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(403, 31);
            this.lbAddress.TabIndex = 42;
            this.lbAddress.Text = "Address";
            // 
            // lbGeneralCall
            // 
            this.lbGeneralCall.AutoSize = true;
            this.lbGeneralCall.Location = new System.Drawing.Point(294, 20);
            this.lbGeneralCall.Name = "lbGeneralCall";
            this.lbGeneralCall.Size = new System.Drawing.Size(104, 13);
            this.lbGeneralCall.TabIndex = 43;
            this.lbGeneralCall.Text = "Support General Call";
            // 
            // lbCommandDes
            // 
            this.lbCommandDes.Location = new System.Drawing.Point(7, 276);
            this.lbCommandDes.Name = "lbCommandDes";
            this.lbCommandDes.Size = new System.Drawing.Size(432, 27);
            this.lbCommandDes.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGeneralCall);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lbManufactory);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Location = new System.Drawing.Point(12, 654);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCommandDes);
            this.groupBox2.Controls.Add(this.tvCommands);
            this.groupBox2.Location = new System.Drawing.Point(11, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 315);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // cmbLogDataType
            // 
            this.cmbLogDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogDataType.FormattingEnabled = true;
            this.cmbLogDataType.Items.AddRange(new object[] {
            "I2C Data",
            "Command Data",
            "API Data Encoded"});
            this.cmbLogDataType.Location = new System.Drawing.Point(734, 242);
            this.cmbLogDataType.Name = "cmbLogDataType";
            this.cmbLogDataType.Size = new System.Drawing.Size(176, 21);
            this.cmbLogDataType.TabIndex = 46;
            this.cmbLogDataType.SelectedIndexChanged += new System.EventHandler(this.cmbLogDataType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Log Data Type";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.AutoSize = true;
            this.lbInfo.IsShowText = false;
            this.lbInfo.Location = new System.Drawing.Point(817, 166);
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
            // frmMain
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(923, 774);
            this.Controls.Add(this.cmbLogDataType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDevices);
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
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbI2CBridge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AnyI2C v1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReadLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label lbManufactory;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbGeneralCall;
        private System.Windows.Forms.Label lbCommandDes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLogDataType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}

