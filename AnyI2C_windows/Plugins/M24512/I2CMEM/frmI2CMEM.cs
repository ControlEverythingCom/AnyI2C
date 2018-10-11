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

namespace M24512_I2CM
{
    public partial class frmI2CMem : Form
    {
        CommInterface CommObj = null;
        public frmI2CMem()
        {
            InitializeComponent();
        }
        
        public void Attach(CommInterface com)
        {
            CommObj = com;
        }        

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(false);
            byte[] v = CommObj.Send(new byte [] {addr, (byte)(numAddrHigh.Value), (byte)(numAddrLow.Value)}, 1);
            if (v != null)
            {
                numValue.Value = v[0];
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte [] {addr, (byte)(numAddrHigh.Value), (byte)(numAddrLow.Value), (byte)(numValue.Value)}, 0);
            CommObj.LogText("GUI Initialize Complete");
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            return (byte)(numAddress.Value);
        }

        private void frmI2CMem_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
        }

        private void frmM245212_FormClosing(object sender, FormClosingEventArgs e)
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
            frmI2CMem frm = new frmI2CMem();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
