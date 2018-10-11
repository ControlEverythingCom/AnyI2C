using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AnyI2C;

namespace LIS33DE_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            return (byte)(numAddress.Value);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //Cofigure Sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x20, 0x47 }, 0);
                Thread.Sleep(500);
                byte[] valuex = CommObj.Send(new byte[] { addr, 0x29 }, 1);
                byte[] valuey = CommObj.Send(new byte[] { addr, 0x2B }, 1);
                byte[] valuez = CommObj.Send(new byte[] { addr, 0x2D }, 1);
                if (valuex != null && valuey != null && valuez != null)
                {
                    lbX.Text = (valuex[0] > 127) ? (valuex[0] - 256).ToString() : (valuex[0]).ToString();
                    lbY.Text = (valuey[0] > 127) ? (valuey[0] - 256).ToString() : (valuey[0]).ToString();
                    lbZ.Text = (valuez[0] > 127) ? (valuez[0] - 256).ToString() : (valuez[0]).ToString();
                }
                return "OK";
            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnReadCh0.Enabled = !chkAutoUpdate.Checked;
            if (chkAutoUpdate.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
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
