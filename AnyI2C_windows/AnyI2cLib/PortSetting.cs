using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NCD;

namespace NCD
{
    internal partial class PortSetting : Form
    {
        public string PortName
        {
            get
            {
                return cmbPortName.Text;
            }
            set
            {
                cmbPortName.Text = value;
            }
        }

        public bool ShowBaudrate
        {
            get
            {
                return cmbBaudrate.Visible;
            }
            set 
            {
                cmbBaudrate.Visible = value;
                lbBaudrate.Visible = value;
            }
        }

        public string IP
        {
            get
            {
                return txtIP.Text;
            }
            set
            {
                txtIP.Text = value;
            }
        }

        public int Port
        {
            get
            {
                return System.Convert.ToInt32(txtNetworkPort.Text);
            }
            set
            {
                txtNetworkPort.Text = value.ToString();
            }
        }

        public int baudrate
        {
            get
            {
                return System.Convert.ToInt32(cmbBaudrate.Text);
            }
            set
            {
                cmbBaudrate.Text = value.ToString();
            }
        }

        /// <summary>
        /// Using Com Port
        /// </summary>
        public bool UsingComPort
        {
            get
            {
                return rdComPort.Checked;
            }
            set
            {
                rdComPort.Checked = value;
                rdNetwork.Checked = !value;
            }
        }

        SerialDeviceInfo[] mSerialPortInfos = ListPorts.EnumPorts();

        public PortSetting()
        {
            InitializeComponent();
        }

        private void PortSetting_Load(object sender, EventArgs e)
        {
            FillComPortList();
        }

        private void FillComPortList()
        {
            cmbPortName.Items.Clear();
            for (int i = 0; i < mSerialPortInfos.Length; i++)
            {
                cmbPortName.Items.Add(mSerialPortInfos[i].PortName);
            }
        }


        private void cmbPortName_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the item.
            e.DrawBackground();
            e.Graphics.DrawString(mSerialPortInfos[e.Index].FriendName, e.Font, System.Drawing.Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

    }
}