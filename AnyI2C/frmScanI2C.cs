using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AnyI2cLib;
namespace AnyI2C
{
    public partial class frmScanI2C : Form
    {
        public int SelectedAddr = -1;   // no select
        public byte [] ConnectedDevices = null;
        I2CBridgeX  i2cBridge = null;
        byte mPort = 0;
        public frmScanI2C(I2CBridgeX bridge, byte port)
        {
            InitializeComponent();
            i2cBridge = bridge;
            mPort = port;
        }

        private void frmScanI2C_Load(object sender, EventArgs e)
        {
            ScanDevices();
        }

        private void ScanDevices()
        {
            lstDevices.Items.Clear();
            if (i2cBridge != null)
            {
                ConnectedDevices = i2cBridge.ScanDevices(mPort);
                if (ConnectedDevices != null)
                {
                    for (int i = 0; i < ConnectedDevices.Length; i++)
                    {
                        string addr = string.Format("{0:D}  (0x{1:X2})", ConnectedDevices[i], ConnectedDevices[i]);
                        lstDevices.Items.Add(addr);
                        if (SelectedAddr == ConnectedDevices[i])
                        {
                            lstDevices.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ScanDevices();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(lstDevices.SelectedIndex != -1 )
            {
                SelectedAddr = ConnectedDevices[lstDevices.SelectedIndex];
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDevices.SelectedIndex != -1)
            {
                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
            }
        }

        private void lstDevices_DoubleClick(object sender, EventArgs e)
        {
            if (lstDevices.SelectedIndex != -1)
            {
                SelectedAddr = ConnectedDevices[lstDevices.SelectedIndex];
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

    }
}
