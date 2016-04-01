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

namespace STS21_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmADC081C_Load(object sender, EventArgs e)
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
            if (Read)
            {
                return (byte)(numAddress.Value * 2 + 1);
            }
            return (byte)(numAddress.Value * 2);
        }

        private string ReadTemperature(byte ch)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //byte[] value = CommObj.Send(new byte[] { addr, 0xF3}, 2);
                byte[] value = CommObj.Send(new byte[] { addr, 0xF3 }, 0);
                Thread.Sleep(300);
                byte[] value1 = CommObj.Send(new byte[] { addr }, 1);
                byte[] value2 = CommObj.Send(new byte[] { addr }, 1);
                double t = 0;
                if (value1 != null && value2 != null)
                {
                    t = -46.85 + 175.72 * (value1[0] * 256 + value2[0]) / Math.Pow(2, 16);
                    return t.ToString("F2");
                }

            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            lbT.Text = ReadTemperature(0);
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
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
