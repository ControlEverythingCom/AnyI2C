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

namespace L3G4200_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void L3G4200_Load(object sender, EventArgs e)
        {
            numAddress.Value = CommObj.GetDefaultAddress();

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

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //config the sensor
                byte[] value = CommObj.Send(new byte[] { addr,0x20,0xf}, 0);
                Thread.Sleep(100);
                byte [] valueL = CommObj.Send(new byte[] { addr, 0x28 }, 1);
                byte [] valueH = CommObj.Send(new byte[] { addr,0x29}, 1);
                if (valueH != null && valueL != null)
                {
                    if (valueH.Length == 1 && valueL.Length == 1)
                    {
                        lbX.Text = (valueH[0] * 256 + valueL[0]).ToString();
                    }
                }
                valueL = CommObj.Send(new byte[] { addr, 0x2A}, 1);
                valueH = CommObj.Send(new byte[] { addr, 0x2B }, 1);
                if (valueH != null && valueL != null)
                {
                    if (valueH.Length == 1 && valueL.Length == 1)
                    {
                        lbY.Text = (valueH[0] * 256 + valueL[0]).ToString();
                    }
                }
                valueL = CommObj.Send(new byte[] { addr, 0x2C }, 1);
                valueH = CommObj.Send(new byte[] { addr, 0x2D }, 1);
                if (valueH != null && valueL != null)
                {
                    if (valueH.Length == 1 && valueL.Length == 1)
                    {
                        lbZ.Text = (valueH[0] * 256 + valueL[0]).ToString();
                    }
                }
                return "OK";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
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
