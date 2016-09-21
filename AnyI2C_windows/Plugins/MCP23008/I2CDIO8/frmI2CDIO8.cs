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

namespace MCP23008_I2CDIO8
{
    public partial class frmI2CDIO8 : Form
    {
        byte currentOutputStatus = 0;
        CommInterface CommObj = null;
        public frmI2CDIO8()
        {
            InitializeComponent();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        private void frmI2CDIO8_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            Init();
            UpdateStatus();
        }

        private void Init()
        {
            SetupAsOutput();

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
                    currentOutputStatus = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            chkOutput0.Checked = GetOneOutputStatus(currentOutputStatus, 0);
            chkOutput1.Checked = GetOneOutputStatus(currentOutputStatus, 1);
            chkOutput2.Checked = GetOneOutputStatus(currentOutputStatus, 2);
            chkOutput3.Checked = GetOneOutputStatus(currentOutputStatus, 3);
            chkOutput4.Checked = GetOneOutputStatus(currentOutputStatus, 4);
            chkOutput5.Checked = GetOneOutputStatus(currentOutputStatus, 5);
            chkOutput6.Checked = GetOneOutputStatus(currentOutputStatus, 6);
            chkOutput7.Checked = GetOneOutputStatus(currentOutputStatus, 7);
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
                currentOutputStatus = ByteLib.SetBit(currentOutputStatus, pos, value);
                byte addr = GetAddress(true);
                CommObj.Send(new byte[] { addr, 9, currentOutputStatus }, 0);
            }
            catch
            {

            }
        }

        private void frmI2CDIO8_FormClosing(object sender, FormClosingEventArgs e)
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
            if (chkOutput0.Checked)
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
            if (chkOutput1.Checked)
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
            if (chkOutput2.Checked)
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
            if (chkOutput3.Checked)
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
            if (chkOutput4.Checked)
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
            if (chkOutput5.Checked)
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
            if (chkOutput6.Checked)
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
            if (chkOutput7.Checked)
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
            UpdateOutputStatus();
        }

        private void UpdateOutputStatus()
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
                    currentOutputStatus = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            chkOutput0.Checked = GetOneOutputStatus(currentOutputStatus, 0);
            chkOutput1.Checked = GetOneOutputStatus(currentOutputStatus, 1);
            chkOutput2.Checked = GetOneOutputStatus(currentOutputStatus, 2);
            chkOutput3.Checked = GetOneOutputStatus(currentOutputStatus, 3);
            chkOutput4.Checked = GetOneOutputStatus(currentOutputStatus, 4);
            chkOutput5.Checked = GetOneOutputStatus(currentOutputStatus, 5);
            chkOutput6.Checked = GetOneOutputStatus(currentOutputStatus, 6);
            chkOutput7.Checked = GetOneOutputStatus(currentOutputStatus, 7);
        }

        private void UpdateInputStatus()
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
                    currentOutputStatus = value[0];
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            lbInput0.Text = GetOneOutputStatus(currentOutputStatus, 0) ? "High" : "Low";
            lbInput1.Text = GetOneOutputStatus(currentOutputStatus, 1) ? "High" : "Low";
            lbInput2.Text = GetOneOutputStatus(currentOutputStatus, 2) ? "High" : "Low";
            lbInput3.Text = GetOneOutputStatus(currentOutputStatus, 3) ? "High" : "Low";
            lbInput4.Text = GetOneOutputStatus(currentOutputStatus, 4) ? "High" : "Low";
            lbInput5.Text = GetOneOutputStatus(currentOutputStatus, 5) ? "High" : "Low";
            lbInput6.Text = GetOneOutputStatus(currentOutputStatus, 6) ? "High" : "Low";
            lbInput7.Text = GetOneOutputStatus(currentOutputStatus, 7) ? "High" : "Low";
        }

        private void SetupAsOutput()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // set default as output
                CommObj.Send(new byte[] { addr, 0, 0 }, 0);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatus = value[0];
                    UpdateOutputStatus();
                    groupOutput.Enabled = true;
                    groupInput.Enabled = false;
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }
        }

        private void SetupAsInput()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // set default as output
                CommObj.Send(new byte[] { addr, 0, 0xff }, 0);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatus = value[0];
                    UpdateOutputStatus();
                    groupOutput.Enabled = false;
                    groupInput.Enabled = true;
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetupAsOutput();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetupAsInput();
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
            frmI2CDIO8 frm = new frmI2CDIO8();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
