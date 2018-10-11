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

namespace CPS120_I2CS
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
            return (byte)(numAddress.Value);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                bool readSuccess = false;
                int tryTimes = 0;
                while (!readSuccess && tryTimes < 10)
                {
                    tryTimes++;
                    byte addr = GetAddress(false);
                    byte[] value = CommObj.Send(new byte[] { addr }, 0);
                    addr = GetAddress(true);
                    value = CommObj.Send(new byte[] { addr }, 4);
                    if (value != null)
                    {
                        if (value.Length == 4)
                        {
                            int v = value[0] & 0xC0;
                            if (v <2)
                            {
                                readSuccess = true;
                                double baro = (value[0] & 0x3f * 256 + value[1])*0.055 + 30 ;
                                double temp = (value[2] * 64) * 0.01 - 40;
                                lbBaro.Text = baro.ToString("F2");
                                lbTemp.Text = temp.ToString("F2");
                                return value[0].ToString();
                            }
                        }
                    }
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
            ReadSensor();
        }

        private void frmCPS120_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
