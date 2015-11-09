using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Schema;
using System.Reflection;

using AnyI2cLib;
using FTD2XX_NET;
using AnyI2C.Data;

namespace AnyI2C
{
    public partial class frmMain : Form
    {
        I2CBridgeX mBridge = null;
        I2CAdapter[] i2cBridges;
        I2CData mData = new I2CData();
        DevicesCollection mDevices;
        I2CBridgeX[] i2cBridgeXs;
        public frmMain()
        {
            InitializeComponent();
        }




        private void frmMain_Load(object sender, EventArgs e)
        {

            //InitFtdiControls();
            EnumBridgeX();
            btnScan.Enabled = false;
            btnSend.Enabled = false;
            Configure config = new Configure();
            config.Load();
            mData = config.Data;
            if (i2cBridges != null)
            {
                for (int i = 0; i < i2cBridges.Length; i++)
                {
                    if (i2cBridges[i].LocationID == config.LocationID)
                    {
                        mBridge = i2cBridgeXs[i];
                        cmbI2CBridge.SelectedIndex = i;
                        if (config.Opened)
                        {
                            mBridge.Open();
                            btnScan.Enabled = true;
                            btnSend.Enabled = true;
                        }
                        break;
                    }
                }
            }
            if (mData == null)
            {
                mData = new I2CData();
            }
        
            ctlI2CAddress1.Addr7 = mData.Address;
            UpdateGUIFromData(mData.Content);
            chkWrite.Checked = mData.IsWrite;
            chkRead.Checked = mData.IsRead;
            numReadLength.Value = mData.ReadDataLength;
            SetFormat(mData.Format);
            LoadDevicesConfigure();
        }


        private void UpdateGUIFromData(byte[] content)
        {
            txtQuickSend.Text = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < content.Length; i++)
            {
                if (mData.Format == emViewFormat.Dec)
                {
                    sb.Append(string.Format("{0} ", content[i]));
                }
                else
                {
                    sb.Append(string.Format("{0:X2} ", content[i]));
                }
            }
            txtQuickSend.Text = sb.ToString();
        }

        /// <summary>
        /// Found all Ftdi devices and fill them in list
        /// </summary>
        private void InitFtdiControls()
        {
            try
            {
                i2cBridges = I2CAdapter.EnumBridge();
                cmbI2CBridge.Items.Clear();
                for (int i = 0; i < i2cBridges.Length; i++)
                {
                    cmbI2CBridge.Items.Add("I2C Bridge - " + i2cBridges[i].LocationID.ToString());
                }
                if (i2cBridges.Length > 0)
                {
                    cmbI2CBridge.SelectedIndex = 0;
                }
            }
            catch
            {
            }

        }

        private void EnumBridgeX()
        {
            try
            {
                i2cBridgeXs = I2CBridgeX.EnumBridge();
                cmbI2CBridge.Items.Clear();
                for (int i = 0; i < i2cBridgeXs.Length; i++)
                {
                    cmbI2CBridge.Items.Add("I2C Bridge - " + i2cBridgeXs[i].PortName);
                }
                if (i2cBridgeXs.Length > 0)
                {
                    cmbI2CBridge.SelectedIndex = 0;
                }

            }
            catch
            {
            }

        }


        /// <summary>
        /// get view format from format 
        /// </summary>
        /// <returns></returns>
        private emViewFormat GetFormat()
        {
            if (cmbShowFormat.Text == "HEX")
            {
                return emViewFormat.Hex;
            }
            return emViewFormat.Dec;
        }


        private void SetFormat(emViewFormat format)
        {
            if (format == emViewFormat.Hex)
            {
                cmbShowFormat.SelectedIndex = 0;
            }
            else
            {
                cmbShowFormat.SelectedIndex = 1;
            }

        }

        private void cmbI2CBridge_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index == -1)
            {
                string str = "None ";
                e.Graphics.DrawString(str, e.Font, System.Drawing.Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
            else
            {
                string str = "I2C Bridge - " + i2cBridgeXs[e.Index].PortName;
                e.Graphics.DrawString(str, e.Font, System.Drawing.Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void OpenI2CAdapter()
        {
            int id = cmbI2CBridge.SelectedIndex;
            if (id != -1)
            {
                mBridge = i2cBridgeXs[id];
                mBridge.Open();
                if (mBridge.IsOpen)
                {
                    lbStatus.Text = "Selected I2C Bridge Opened.";
                    btnSend.Enabled = true;
                    btnScan.Enabled = true;
                }
                else
                {
                    btnSend.Enabled = false;
                    btnScan.Enabled = false;
                    lbStatus.Text = "Fail to open selected I2C bridge.";
                }
                Debug.Print(mBridge.IsOpen.ToString());
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenI2CAdapter();
        }

        private void cmbI2CBridge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mBridge.IsOpen)
            {
                mBridge.Close();
            }
            OpenI2CAdapter();
        }


        private byte[] GetInstanceData()
        {
            emViewFormat format = mData.Format;
            string str = txtQuickSend.Text;
            byte[] data = new byte[0];

            switch (format)
            {
                case emViewFormat.Dec:
                    data = CommonData.GetBytesFromDecString(str);
                    break;
                case emViewFormat.Hex:
                    data = CommonData.GetBytesFromHexString(str);
                    break;
                default:
                    break;
            }
            return data;
        }

        private void txtQuickSend_TextChanged(object sender, EventArgs e)
        {
            HelpFunction.ValidateResult result = HelpFunction.CheckInput(txtQuickSend.Text, mData.Format);
            if (result.IsValid)
            {
                lbInfo.IsShowText = false;
                lbInfo.Value = new int[] { GetInstanceData().Length };
                lbInfo.ForeColor = Color.Black;
            }
            else
            {
                lbInfo.IsShowText = true;
                lbInfo.Text = "Wrong Data";
                lbInfo.ForeColor = Color.Red;
            }
        }

        public  void Send()
        {
            try
            {
                UpdateData();
                mData.Address = ctlI2CAddress1.Addr7;
                if (chkWrite.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("W:");
                    string format = GetFormat() == emViewFormat.Hex ? "{0:X2} " : "{0:d} ";
                    sb.AppendFormat(format, ctlI2CAddress1.Addr7 * 2);
                    for (int i = 0; i < mData.Content.Length; i++)
                    {
                        sb.AppendFormat(format, mData.Content[i]);
                    }
                    LogText(sb.ToString());
                }

                mBridge.Write((byte)numPort.Value, ctlI2CAddress1.Addr7, mData.Content);
                if (chkRead.Checked)
                {
                    byte[] readData = mBridge.ReadData((byte)numPort.Value, ctlI2CAddress1.Addr7, (byte)numReadLength.Value);
                    if (readData != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        string format = GetFormat() == emViewFormat.Hex ? "{0:X2} " : "{0:d} ";
                        sb.Append("W:");
                        sb.AppendFormat(format, ctlI2CAddress1.Addr7 * 2 + 1);
                        sb.AppendLine();
                        sb.Append("R:");
                        for (int i = 0; i < readData.Length; i++)
                        {
                            sb.AppendFormat(format, readData[i]);
                        }
                        LogText(sb.ToString());
                    }
                }


            }
            catch 
            {
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void LogText(string text)
        {
            txtLog.AppendText(text + Environment.NewLine);
        }

        /// <summary>
        /// if the input is valid
        /// </summary>
        private bool ValidContent
        {
            get
            {
                bool valid = false;
                try
                {
                    if (txtQuickSend.Text != string.Empty)
                    {
                        if (mData.Format == emViewFormat.Dec)
                        {
                            byte[] data1 = CommonData.GetBytesFromDecString(txtQuickSend.Text);
                        }
                        else
                        {
                            byte[] data1 = CommonData.GetBytesFromHexString(txtQuickSend.Text);
                        }
                        valid = true;
                    }
                    else
                    {
                        valid = true;
                    }


                }
                catch
                {
                    valid = false;
                }
                return valid;
            }
        }

        private void cmbShowFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ValidContent)
            {
                cmbShowFormat.SelectedIndexChanged -= cmbShowFormat_SelectedIndexChanged;
                SetFormat(mData.Format);
                cmbShowFormat.SelectedIndexChanged += cmbShowFormat_SelectedIndexChanged;
                return;
            }
            UpdateData();
            mData.Format = GetFormat();
            UpdateGUIFromData(mData.Content);
        }


        private void UpdateData()
        {
            mData.Content = GetDataFromGUI();
            mData.IsWrite = chkWrite.Checked;
            mData.IsRead = chkRead.Checked;
            mData.ReadDataLength = (byte)numReadLength.Value;
        }

        /// <summary>
        /// Create data from gui
        /// </summary>
        /// <returns></returns>
        private byte[] GetDataFromGUI()
        {
            byte addr = (byte)(ctlI2CAddress1.Addr7 * 2);
            byte[] data2 = new byte[1] { addr };
            byte[] data = CommonData.GetBytes(txtQuickSend.Text, mData.Format, "");
            if (data != null)
            {
                data2 = new byte[data.Length + 1];
                data2[0] = addr;
                for (int i = 0; i < data.Length; i++)
                {
                    data2[i + 1] = data[i];
                }
            }
            //return data2;
            return data;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateData();
            mData.Address = ctlI2CAddress1.Addr7;
            Controls.frmI2CDataEdit frm = new Controls.frmI2CDataEdit(mData);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mData = frm.Data;
                UpdateGUIFromData(mData.Content);
                ctlI2CAddress1.Addr7 = mData.Address;
                chkRead.Checked = mData.IsRead;
                chkWrite.Checked = mData.IsWrite;
                numReadLength.Value = mData.ReadDataLength;

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            frmScanI2C frm = new frmScanI2C(mBridge, (byte)numPort.Value );
            frm.SelectedAddr = ctlI2CAddress1.Addr7;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.SelectedAddr != -1)
                {
                    ctlI2CAddress1.Addr7 = (byte)frm.SelectedAddr;
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateData();
            try
            {
                Configure config = new Configure();
                //config.LocationID = mBridge.LocationID;
                config.PortName = mBridge.PortName;
                config.Data = mData;
                config.Opened = mBridge.IsOpen;
                config.Save();
            }
            catch
            {
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(Application.ExecutablePath) + "\\ADS7828.dll";
            Assembly guiLib = Assembly.LoadFile(path);
            //Type t = guiLib.GetType("I2CDIO8.MyGUI");
            Type t = guiLib.GetType("ADS7828.MyGUI");
            GuiInterface gui = (GuiInterface)Activator.CreateInstance(t);
            CommObj obj = new CommObj(this);
            
            gui.Show(obj);

        }

        /// <summary>
        /// load devices configure
        /// </summary>
        private void LoadDevicesConfigure()
        {
            mDevices = new DevicesCollection();
            lstDevices.Items.Clear();
            mDevices.LoadAllDevices();
            foreach (DeviceConfig dev in mDevices.Devices)
            {
                lstDevices.Items.Add(dev.Name);
            }
            if (mDevices.Devices.Length > 0)
            {
                FillCommandsTree(mDevices.Devices[0]);
            }
        }


        /// <summary>
        /// Fill Commands tree with 
        /// </summary>
        private void FillCommandsTree(DeviceConfig dev)
        {

            tvCommands.Nodes.Clear();
            DeviceCommandsGroup cmds = dev.Commands;
            if (cmds.Commands != null)
            {
                foreach (DeviceCommandBase cmd in cmds.Commands)
                {
                    TreeNode node = FillCommandsTreeSubNode(cmd);
                    tvCommands.Nodes.Add(node);
                }
            }
            ctlI2CAddress1.Addr7 = dev.Address;
        }

        /// <summary>
        /// Fill command tree 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="cmd"></param>
        private TreeNode FillCommandsTreeSubNode( DeviceCommandBase cmd)
        {
            TreeNode nd = new TreeNode();
            nd.Tag = cmd;
            if (cmd is DeviceCommandsGroup)
            {
                DeviceCommandsGroup g = (DeviceCommandsGroup)cmd;
                nd.Text = g.ToString();
                if (g.Commands != null)
                {
                    foreach (DeviceCommandBase c in g.Commands)
                    {
                        nd.Nodes.Add(FillCommandsTreeSubNode(c));
                    }
                }
            }
            else if (cmd is DeviceCommand)
            {
                nd.Text = cmd.ToString();
            }
            else if (cmd is DeviceGUICommand)
            {
                nd.Text = cmd.ToString();
            }
            return nd;
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = lstDevices.SelectedIndex;
            if (id != -1)
            {
                DeviceConfig dev = (DeviceConfig)(mDevices.Devices[id]);
                FillCommandsTree(dev);
            }
        }

        private void tvCommands_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nd = tvCommands.SelectedNode;
            if (nd != null)
            {
                if (nd.Tag is DeviceCommand)
                {
                    DeviceCommand cmd = (DeviceCommand)nd.Tag;
                    txtQuickSend.Text = cmd.GetSendDataString(GetFormat() == emViewFormat.Hex);
                    chkWrite.Checked = cmd.Write;
                    chkRead.Checked = cmd.ReadDataLength > 0;
                    numReadLength.Value = cmd.ReadDataLength;
                    Send();
                }
                else if (nd.Tag is DeviceGUICommand)
                {
                    DeviceGUICommand cmd = (DeviceGUICommand)nd.Tag;
                    string path = System.IO.Directory.GetParent(Application.ExecutablePath) + "\\" + cmd.GUIPath;
                    Assembly guiLib = Assembly.LoadFile(path);
                    //Type t = guiLib.GetType("I2CDIO8.MyGUI");
                    Type t = guiLib.GetType(cmd.TypeName);
                    GuiInterface gui = (GuiInterface)Activator.CreateInstance(t);
                    CommObj obj = new CommObj(this);

                    gui.Show(obj);


                }
            }
        }

        private void tvCommands_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void OnWriteDataError()
        {
            LogText("Write Data Error");
        }

        private void OnReadDataError()
        {
            LogText("Read Data Error");
        }

        /// <summary>
        /// Send i2c data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="readLength"></param>
        /// <returns></returns>
        public byte[] SendI2C(byte[] writedata, byte readLength)
        {
            I2CData data = new I2CData();
            byte[] data2 = new byte[writedata.Length - 1];
            for (int i = 1; i < writedata.Length; i++)
            {
                data2[i - 1] = writedata[i];
            }
            data.Content = data2;
            data.ReadDataLength = readLength;
            data.IsRead = readLength > 0;
            data.Address = (byte)(writedata[0] >> 1);
            mData = data;
            UpdateGUIFromData(mData.Content);
            ctlI2CAddress1.Addr7 = mData.Address;
            chkRead.Checked = mData.IsRead;
            chkWrite.Checked = mData.IsWrite;
            numReadLength.Value = mData.ReadDataLength;
            UpdateData();
            if (chkWrite.Checked)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("W:");
                string format = GetFormat() == emViewFormat.Hex ? "{0:X2} " : "{0:d} ";
                sb.AppendFormat(format, ctlI2CAddress1.Addr7 * 2);
                for (int i = 0; i < mData.Content.Length; i++)
                {
                    sb.AppendFormat(format, mData.Content[i]);
                }
                LogText(sb.ToString());
            }

            if (!mBridge.Write((byte)numPort.Value, mData.Address, mData.Content))
            {
                OnWriteDataError();
                throw new Exception("On Write Data Error");
            }
            else
            {
                if (chkRead.Checked)
                {
                    try
                    {
                        byte[] readData = mBridge.ReadData((byte)numPort.Value, ctlI2CAddress1.Addr7, (byte)numReadLength.Value);
                        if (readData != null)
                        {
                            StringBuilder sb = new StringBuilder();
                            string format = GetFormat() == emViewFormat.Hex ? "{0:X2} " : "{0:d} ";
                            sb.Append("W:");
                            sb.AppendFormat(format, ctlI2CAddress1.Addr7 * 2 + 1);
                            sb.AppendLine();
                            sb.Append("R:");
                            for (int i = 0; i < readData.Length; i++)
                            {
                                sb.AppendFormat(format, readData[i]);
                            }
                            LogText(sb.ToString());
                            return readData;
                        }

                    }
                    catch (Exception ex)
                    {
                        OnReadDataError();
                        throw new Exception("On Read Data Error");
                    }
                }
            }
            return null;

        }

        public byte GetCurrentAddress()
        {
            return ctlI2CAddress1.Addr7;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //I2CBridgeX [] bridgeX = I2CBridgeX.EnumBridge();
            mBridge.Write((byte)numPort.Value, (byte)ctlI2CAddress1.Addr7, 10, 12);
            mBridge.Write((byte)numPort.Value, (byte)ctlI2CAddress1.Addr7, 10);
            byte[] data = mBridge.ReadData((byte)numPort.Value, (byte)ctlI2CAddress1.Addr7, 1);

        }

    }

    public class Configure
    {
        public uint LocationID = 0; // location id of the i2cbridge device
        public bool Opened = false; // if the bridge is opened
        public string PortName = string.Empty;
        public I2CData Data;        // current i2c data
        
        //load the configure file
        public void Load()
        {
            try
            {
                XmlReader reader = XmlReader.Create("Config.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Configure));
                Configure temp = (Configure)serializer.Deserialize(reader);
                Data = temp.Data;
                LocationID = temp.LocationID;
                Opened = temp.Opened;
                PortName = temp.PortName;
                reader.Close();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to load configure file.");
            }
        }

        // save the configure file
        public void Save()
        {

            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "\t";
                settings.OmitXmlDeclaration = true;     //omit declaration
                settings.NewLineOnAttributes = true;
                XmlWriter writer = XmlWriter.Create("Config.xml", settings);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                XmlSerializer serializer = new XmlSerializer(typeof(Configure));
                serializer.Serialize(writer, this, ns); 
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to save configure file.");
            }


        }
    
    }



    public class CommObj : CommInterface
    {
        public frmMain mForm;
        public CommObj(frmMain frm  )
        {
            mForm = frm;
        }

        public byte[]  Send(byte[] writedata, byte readLength)
        {
            return mForm.SendI2C(writedata, readLength);
        }

        public byte GetDefaultAddress()
        {
            if (mForm != null)
            {
                return mForm.GetCurrentAddress();
            }
            return 0;
        }

    }


}
