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

namespace MCP23008_I2CR8G5LE
{
    public partial class frmI2CR8G5LE : Form
    {
        byte currentOutputStatusB1 = 0; 
        CommInterface CommObj = null;
        public frmI2CR8G5LE()
        {
            InitializeComponent();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        private void frmI2CR8G5LE_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            Init();
            UpdateStatus();
        }

        private void Init()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                CommObj.Send(new byte[] { addr, 0, 0 }, 0);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

        }

        private void UpdateStatus()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            chkB1R1.Checked = GetOneOutputStatus(currentOutputStatusB1, 0);
            chkB1R2.Checked = GetOneOutputStatus(currentOutputStatusB1, 1);
            chkB1R3.Checked = GetOneOutputStatus(currentOutputStatusB1, 2);
            chkB1R4.Checked = GetOneOutputStatus(currentOutputStatusB1, 3);
            chkB1R5.Checked = GetOneOutputStatus(currentOutputStatusB1, 4);
            chkB1R6.Checked = GetOneOutputStatus(currentOutputStatusB1, 5);
            chkB1R7.Checked = GetOneOutputStatus(currentOutputStatusB1, 6);
            chkB1R8.Checked = GetOneOutputStatus(currentOutputStatusB1, 7);
        }

        private bool GetOneOutputStatus(byte value, byte pos)
        {
            bool status = false;
            if (ByteLib.GetBit(value, pos) == 1)
            {
                status = true;
            }
            return status;
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

        /// <summary>
        /// update one bit of the output for bank 1
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        private void UpdateOneBitB1(byte value, byte pos)
        {
            try
            {
                currentOutputStatusB1 = ByteLib.SetBit(currentOutputStatusB1, pos, value);
                byte addr = GetAddress(true);
                CommObj.Send(new byte[] { addr, 9, currentOutputStatusB1 }, 0);
            }
            catch
            {

            }
        }

        private void frmI2CR8G5LE_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void btnAllOn1_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 9, 255 }, 0);
            UpdateStatus();
        }

        private void btnAllOff1_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 9, 0 }, 0);
            UpdateStatus();
        }

        private void chkB1R1_Clicked(object sender, EventArgs e)
        {
            if (chkB1R1.Checked)
            {
                UpdateOneBitB1(1, 0);
            }
            else
            {
                UpdateOneBitB1(0, 0);
            }
        }

        private void chkB1R2_Clicked(object sender, EventArgs e)
        {
            if (chkB1R2.Checked)
            {
                UpdateOneBitB1(1, 1);
            }
            else
            {
                UpdateOneBitB1(0, 1);
            }
        }

        private void chkB1R3_Clicked(object sender, EventArgs e)
        {
            if (chkB1R3.Checked)
            {
                UpdateOneBitB1(1, 2);
            }
            else
            {
                UpdateOneBitB1(0, 2);
            }
        }

        private void chkB1R4_Clicked(object sender, EventArgs e)
        {
            if (chkB1R4.Checked)
            {
                UpdateOneBitB1(1, 3);
            }
            else
            {
                UpdateOneBitB1(0, 3);
            }
        }

        private void chkB1R5_Clicked(object sender, EventArgs e)
        {
            if (chkB1R5.Checked)
            {
                UpdateOneBitB1(1, 4);
            }
            else
            {
                UpdateOneBitB1(0, 4);
            }
        }

        private void chkB1R6_Clicked(object sender, EventArgs e)
        {
            if (chkB1R6.Checked)
            {
                UpdateOneBitB1(1, 5);
            }
            else
            {
                UpdateOneBitB1(0, 5);
            }
        }

        private void chkB1R7_Clicked(object sender, EventArgs e)
        {
            if (chkB1R7.Checked)
            {
                UpdateOneBitB1(1, 6);
            }
            else
            {
                UpdateOneBitB1(0, 6);
            }
        }

        private void chkB1R8_Clicked(object sender, EventArgs e)
        {
            if (chkB1R8.Checked)
            {
                UpdateOneBitB1(1, 7);
            }
            else
            {
                UpdateOneBitB1(0, 7);
            }
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            chkB1R1.Checked = GetOneOutputStatus(currentOutputStatusB1, 0);
            chkB1R2.Checked = GetOneOutputStatus(currentOutputStatusB1, 1);
            chkB1R3.Checked = GetOneOutputStatus(currentOutputStatusB1, 2);
            chkB1R4.Checked = GetOneOutputStatus(currentOutputStatusB1, 3);
            chkB1R5.Checked = GetOneOutputStatus(currentOutputStatusB1, 4);
            chkB1R6.Checked = GetOneOutputStatus(currentOutputStatusB1, 5);
            chkB1R7.Checked = GetOneOutputStatus(currentOutputStatusB1, 6);
            chkB1R8.Checked = GetOneOutputStatus(currentOutputStatusB1, 7);
        }
    }

    public class ByteLib
    {

        /// <summary>
        /// return the specific bit value
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        static public byte GetBit(byte v, byte pos)
        {
            byte value = (byte)(1 << pos);
            byte result = (byte)((v & value) > 0 ? 1 : 0);

            return result;
        }

        /// <summary>
        /// return the new value with specific bit set
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <param name="bitValue"></param>
        /// <returns></returns>
        static public byte SetBit(byte v, byte pos, byte bitValue)
        {
            byte result = v;
            byte value = (byte)(1 << pos);
            result = (byte)(v | value);
            result = (byte)(result - value);
            value = (byte)(bitValue << pos);
            result = (byte)(result + value);
            return result;
        }

        public enum emCheckSumMethod
        {
            CS_A_B = 0                  // check sum by plus all bytes together and mod with 0x100
            ,
            CS_FF_A_B             // check sum by 0xFF minus value in CS_A_B, like zig bee device
                ,
            CS_100_A_B            // check sum by 0x100 minus value in CS_A_B
                ,
            FLETCHER              // Fletcher's Checksum
                ,
            XOR                   // xor
                ,
            CRC16Standard         // CRC 16 standard = 0xA001
                ,
            CRC16CCITT            // CRC 16 CCITT Kermit = 0x8408   
                , CS_FF_OR              // check by 0xFF or all bytes together

        }

    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CR8G5LE frm = new frmI2CR8G5LE();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
