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

namespace AS1115_I2CL3E
{
    public partial class frmI2CL3E : Form
    {
        CommInterface CommObj = null;
        public frmI2CL3E()
        {
            InitializeComponent();
        }


        private void frmI2CL3E_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            SetupL3C();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        /// <summary>
        /// setup led display
        /// </summary>
        private void SetupL3C()
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 9, 7 }, 0);
            CommObj.Send(new byte[] { addr, 0xa, 0xff }, 0);
            CommObj.Send(new byte[] { addr, 0xc, 0x01 }, 0);
            CommObj.Send(new byte[] { addr, 0xe, 0 }, 0);
            CommObj.Send(new byte[] { addr, 0xB, 3 }, 0);
            CommObj.Send(new byte[] { addr, 0x1, 0 }, 0);
            CommObj.Send(new byte[] { addr, 0x2, 0 }, 0);
            CommObj.Send(new byte[] { addr, 0x3, 0 }, 0);
            CommObj.LogText("GUI Initialize Complete");
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


        private void frmI2CL3E_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte d1 = (byte)(numContent.Value / 100);
            byte d2 = (byte)((numContent.Value - d1 * 100) / 10);
            byte d3 = (byte)((numContent.Value - d1 * 100 - d2 * 10));
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 1, d1 }, 0);
            CommObj.Send(new byte[] { addr, 2, d2 }, 0);
            CommObj.Send(new byte[] { addr, 3, d3 }, 0);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void numContent_ValueChanged(object sender, EventArgs e)
        {
            byte d1 = (byte)(numContent.Value / 100);
            byte d2 = (byte)((numContent.Value - d1 * 100) / 10);
            byte d3 = (byte)((numContent.Value - d1 * 100 - d2 * 10));
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 1, d1 }, 0);
            CommObj.Send(new byte[] { addr, 2, d2 }, 0);
            CommObj.Send(new byte[] { addr, 3, d3 }, 0);

        }

        private void numBrightness_ValueChanged(object sender, EventArgs e)
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 0xa, (byte)(0xf0 + numBrightness.Value) }, 0);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            SetupL3C();
        }

    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CL3E frm = new frmI2CL3E();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
