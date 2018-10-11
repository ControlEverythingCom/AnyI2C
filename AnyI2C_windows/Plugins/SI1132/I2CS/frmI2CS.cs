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

namespace SI1132_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmTSL45315_Load(object sender, EventArgs e)
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
                // power on and measure
                // write to config
                byte[] value = CommObj.Send(new byte[] { addr, 0x2c },2);
                lbCh0.Text = (value[0] * 256 + value[1]).ToString();

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
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void InitChip()
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 0x13, 0x7B }, 0);
            CommObj.Send(new byte[] { addr, 0x14, 0x6b }, 0);
            CommObj.Send(new byte[] { addr, 0x15, 1 }, 0);
            CommObj.Send(new byte[] { addr, 0x16, 0 }, 0);

            SetParam(0x01, 0xf0); // enable uv, ir, vis, aux
            SetParam(0x0e, 0x00); // als ir adc mux
            SetParam(0x1e, 0);      // ir adc gain
            SetParam(0x1d, 0x70);   // ir count
            SetParam(0x1f, 0x20);   // set ir range

            CommObj.Send(new byte[] { addr, 0x08, 0xff }, 0); // master rate
            CommObj.Send(new byte[] { addr, 0x18, 0x0e }, 0); // auto


        }

        private void SetParam(byte p, byte v)
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] {addr, 0x17, v }, 0);    // write value to reg
            CommObj.Send(new byte[] { addr, 0x18, (byte)(p | 0xA0 )}, 0); // write param address
            byte [] data = CommObj.Send(new byte[] { addr, 0x2E }, 1); // read data back to confirm, should be 0
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            InitChip();
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
