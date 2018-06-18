using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyI2C;

namespace PCA9633_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            scrollValueGroup.Enabled = false;
            scrollValue1.Enabled = false;
            scrollValue2.Enabled = false;
            scrollValue3.Enabled = false;
            scrollValue4.Enabled = false;
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            if (Read)
            {
                return (byte)(numAddress.Value * 2 + 1);
            }
            return (byte)(numAddress.Value * 2);
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private string ReadSensorGroup()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 0x00, 0x00 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x08, 0xFF }, 0);
                scrollValueGroup.Enabled = true;
                scrollValue1.Enabled = false;
                scrollValue2.Enabled = false;
                scrollValue3.Enabled = false;
                scrollValue4.Enabled = false;
            }
            catch
            {
                _ERROR.Visible = true;
            }
            return "Error";
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 0x00, 0x00 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x08, 0xAA }, 0);
                scrollValue1.Enabled = true;
                scrollValue2.Enabled = true;
                scrollValue3.Enabled = true;
                scrollValue4.Enabled = true;
                scrollValueGroup.Enabled = false;
            }
            catch
            {
                _ERROR.Visible = true;
            }
            return "Error";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadSensorGroup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void scrollValueGroup_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 6, (byte)scrollValueGroup.Value }, 0);
        }

        private void scrollValue1_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 2, (byte)scrollValue1.Value }, 0);
        }

        private void scrollValue2_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 3, (byte)scrollValue2.Value }, 0);
        }

        private void scrollValue3_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 4, (byte)scrollValue3.Value }, 0);
        }

        private void scrollValue4_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 5, (byte)scrollValue4.Value }, 0);
        }
    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CS frm = new frmI2CS();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
