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
            numAddress.Value = CommObj.GetDefaultAddress();
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
            CommObj.Send(new byte[] { addr, 0x8, 3 }, 0);

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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte d1 = (byte)(numericUpDown1.Value / 100);
            byte d2 = (byte)((numericUpDown1.Value - d1 * 100) / 10);
            byte d3 = (byte)((numericUpDown1.Value - d1 * 100 - d2 * 10));
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 1, d1 }, 0);
            CommObj.Send(new byte[] { addr, 2, d2 }, 0);
            CommObj.Send(new byte[] { addr, 3, d3 }, 0);
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
