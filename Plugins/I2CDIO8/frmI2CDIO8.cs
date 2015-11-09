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

namespace I2CDIO8
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
            numAddress.Value = CommObj.GetDefaultAddress();
            rdInput.Checked = true;
        }

        private void rdInput_CheckedChanged(object sender, EventArgs e)
        {
            if(rdInput.Checked)
            {
                try
                {
                    _ERROR.Visible = false;
                    byte addr = GetAddress(false);
                    CommObj.Send(new byte[] { addr, 0, 255 }, 0);
                    addr = GetAddress(true);
                    byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                    if (value != null)
                    {
                        Debug.Print(value[0].ToString());
                        UpdateInput(value[0]);
                    }
                }
                catch
                {
                    _ERROR.Visible = true;
                }
            }
            groupInput.Enabled = rdInput.Checked;
            groupOutput.Enabled = !rdInput.Checked;
        }

        private void rdOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOutput.Checked)
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
                        SetOutputStatus(value[0]);
                        currentOutputStatus = value[0];
                    }
                }
                catch
                {
                    _ERROR.Visible = true;
                }
            }
            groupInput.Enabled = rdInput.Checked;
            groupOutput.Enabled = !rdInput.Checked;
        }

        private void UpdateInput(byte value)
        {
            lbInput1.Text = GetStatusString(value, 0);
            lbInput2.Text = GetStatusString(value, 1);
            lbInput3.Text = GetStatusString(value, 2);
            lbInput4.Text = GetStatusString(value, 3);
            lbInput5.Text = GetStatusString(value, 4);
            lbInput6.Text = GetStatusString(value, 5);
            lbInput7.Text = GetStatusString(value, 6);
            lbInput8.Text = GetStatusString(value, 7);
        }

        private string GetStatusString(byte value, byte pos)
        {
            byte bitValue = ByteLib.GetBit(value, pos);
            if (bitValue == 1)
            {
                return "Hi";
            }
            return "Low";

        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            if (rdInput.Checked)
            {
                try
                {
                    _ERROR.Visible = false;
                    byte addr = GetAddress(false);
                    CommObj.Send(new byte[] { addr, 0, 255 }, 0);
                    addr = GetAddress(true);
                    byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                    if (value != null)
                    {
                        Debug.Print(value[0].ToString());
                        UpdateInput(value[0]);
                    }
                }
                catch
                {
                    _ERROR.Visible = true;
                }
            }
        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                currentOutputStatus = 255;
                CommObj.Send(new byte[] { addr, 9, 255 }, 0);
                CheckBox1.Checked = true;
                CheckBox2.Checked = true;
                CheckBox3.Checked = true;
                CheckBox4.Checked = true;
                CheckBox5.Checked = true;
                CheckBox6.Checked = true;
                CheckBox7.Checked = true;
                CheckBox8.Checked = true;
            }
            catch
            {
                _ERROR.Visible = true;
            }
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                currentOutputStatus = 0;
                CommObj.Send(new byte[] { addr, 9, 0 }, 0);
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
                CheckBox5.Checked = false;
                CheckBox6.Checked = false;
                CheckBox7.Checked = false;
                CheckBox8.Checked = false;

            }
            catch
            {
                _ERROR.Visible = true;
            }
        }

        private void btnReadOutput_Click(object sender, EventArgs e)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 9 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    SetOutputStatus(value[0]);
                }

            }
            catch
            {
                _ERROR.Visible = true;
            }
        }
        private void SwitchToInputMode()
        {

        }

        private void SwitchToOutputMode()
        {

        }

        private void ReadInputStatus()
        {
        }

        private void ReadOutputStatus()
        {
        }

        private void TurnAllOn()
        {
        }
        private void TurnAllOff()
        {
        }

        private void SetOutputStatus(byte value)
        {
           CheckBox1.Checked = GetOneOutputStatus(value, 0);
           CheckBox2.Checked = GetOneOutputStatus(value, 1);
           CheckBox3.Checked = GetOneOutputStatus(value, 2);
           CheckBox4.Checked = GetOneOutputStatus(value, 3);
           CheckBox5.Checked = GetOneOutputStatus(value, 4);
           CheckBox6.Checked = GetOneOutputStatus(value, 5);
           CheckBox7.Checked = GetOneOutputStatus(value, 6);
           CheckBox8.Checked = GetOneOutputStatus(value, 7);
        }

        /// <summary>
        /// update one bit of the output
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        private void UpdateOneBit(byte value, byte pos)
        {
            try
            {
                currentOutputStatus = ByteLib.SetBit(currentOutputStatus, pos, value);
                SetOutputStatus(currentOutputStatus);
                byte addr = GetAddress(true);
                CommObj.Send(new byte[] { addr, 9, currentOutputStatus }, 0);
            }
            catch
            {

            }
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

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                UpdateOneBit(1, 0);
            }
            else
            {
                UpdateOneBit(0, 0);
            }
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                UpdateOneBit(1, 1);
            }
            else
            {
                UpdateOneBit(0, 1);
            }

        }

        private void CheckBox3_Click(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                UpdateOneBit(1, 2);
            }
            else
            {
                UpdateOneBit(0, 2);
            }

        }

        private void CheckBox4_Click(object sender, EventArgs e)
        {
            if (CheckBox4.Checked)
            {
                UpdateOneBit(1, 3);
            }
            else
            {
                UpdateOneBit(0, 3);
            }

        }

        private void CheckBox5_Click(object sender, EventArgs e)
        {
            if (CheckBox5.Checked)
            {
                UpdateOneBit(1, 4);
            }
            else
            {
                UpdateOneBit(0, 4);
            }

        }

        private void CheckBox6_Click(object sender, EventArgs e)
        {
            if (CheckBox6.Checked)
            {
                UpdateOneBit(1, 5);
            }
            else
            {
                UpdateOneBit(0, 5);
            }

        }

        private void CheckBox7_Click(object sender, EventArgs e)
        {
            if (CheckBox7.Checked)
            {
                UpdateOneBit(1, 6);
            }
            else
            {
                UpdateOneBit(0, 6);
            }

        }

        private void CheckBox8_Click(object sender, EventArgs e)
        {
            if (CheckBox8.Checked)
            {
                UpdateOneBit(1, 7);
            }
            else
            {
                UpdateOneBit(0, 7);
            }

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
