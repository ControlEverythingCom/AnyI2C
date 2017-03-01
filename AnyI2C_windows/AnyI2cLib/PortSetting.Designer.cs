namespace NCD
{
    partial class PortSetting
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupNetwork = new System.Windows.Forms.GroupBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtNetworkPort = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.rdComPort = new System.Windows.Forms.RadioButton();
            this.rdNetwork = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(86, 269);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPortName.DropDownWidth = 300;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(105, 19);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(183, 21);
            this.cmbPortName.TabIndex = 2;
            this.cmbPortName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbPortName_DrawItem);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000",
            "266660",
            "285710",
            "307700",
            "333330",
            "363620",
            "400000",
            "444440",
            "500000",
            "571410",
            "666660",
            "800000",
            "1000000",
            "1333300",
            "2000000"});
            this.cmbBaudrate.Location = new System.Drawing.Point(105, 49);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(183, 21);
            this.cmbBaudrate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.Location = new System.Drawing.Point(18, 52);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(50, 13);
            this.lbBaudrate.TabIndex = 4;
            this.lbBaudrate.Text = "Baudrate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupNetwork);
            this.groupBox2.Controls.Add(this.rdComPort);
            this.groupBox2.Controls.Add(this.rdNetwork);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 252);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Controls.Add(this.lbBaudrate);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupNetwork
            // 
            this.groupNetwork.Controls.Add(this.txtIP);
            this.groupNetwork.Controls.Add(this.lbPort);
            this.groupNetwork.Controls.Add(this.txtNetworkPort);
            this.groupNetwork.Controls.Add(this.lbIP);
            this.groupNetwork.Location = new System.Drawing.Point(12, 156);
            this.groupNetwork.Name = "groupNetwork";
            this.groupNetwork.Size = new System.Drawing.Size(314, 82);
            this.groupNetwork.TabIndex = 13;
            this.groupNetwork.TabStop = false;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(105, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(182, 20);
            this.txtIP.TabIndex = 12;
            this.txtIP.Text = "192.168.0.104";
            // 
            // lbPort
            // 
            this.lbPort.Location = new System.Drawing.Point(13, 51);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(86, 17);
            this.lbPort.TabIndex = 9;
            this.lbPort.Text = "Listen Port";
            // 
            // txtNetworkPort
            // 
            this.txtNetworkPort.Location = new System.Drawing.Point(105, 49);
            this.txtNetworkPort.Name = "txtNetworkPort";
            this.txtNetworkPort.Size = new System.Drawing.Size(182, 20);
            this.txtNetworkPort.TabIndex = 11;
            this.txtNetworkPort.Text = "2101";
            // 
            // lbIP
            // 
            this.lbIP.Location = new System.Drawing.Point(13, 22);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(86, 17);
            this.lbIP.TabIndex = 10;
            this.lbIP.Text = "IP Adress";
            // 
            // rdComPort
            // 
            this.rdComPort.AutoSize = true;
            this.rdComPort.Checked = true;
            this.rdComPort.Location = new System.Drawing.Point(12, 28);
            this.rdComPort.Name = "rdComPort";
            this.rdComPort.Size = new System.Drawing.Size(68, 17);
            this.rdComPort.TabIndex = 14;
            this.rdComPort.TabStop = true;
            this.rdComPort.Text = "Com Port";
            this.rdComPort.UseVisualStyleBackColor = true;
            // 
            // rdNetwork
            // 
            this.rdNetwork.AutoSize = true;
            this.rdNetwork.Location = new System.Drawing.Point(12, 136);
            this.rdNetwork.Name = "rdNetwork";
            this.rdNetwork.Size = new System.Drawing.Size(65, 17);
            this.rdNetwork.TabIndex = 14;
            this.rdNetwork.Text = "Network";
            this.rdNetwork.UseVisualStyleBackColor = true;
            // 
            // PortSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Setting";
            this.Load += new System.EventHandler(this.PortSetting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupNetwork.ResumeLayout(false);
            this.groupNetwork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupNetwork;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtNetworkPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.RadioButton rdComPort;
        private System.Windows.Forms.RadioButton rdNetwork;
    }
}