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

namespace MCP23008_I2CIO4R4
{
    public partial class frmI2CIO4R4x0 : Form
    {
        byte currentOutputStatus = 0;

        CommInterface CommObj = null;
        public frmI2CIO4R4x0()
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
            Init();
            UpdateStatus();
        }

        private void Init()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                CommObj.Send(new byte[] { addr, 0, 240 }, 0);
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
            CheckBox1.Checked = GetOneOutputStatus(currentOutputStatus, 0);
            checkBox2.Checked = GetOneOutputStatus(currentOutputStatus, 1);
            checkBox3.Checked = GetOneOutputStatus(currentOutputStatus, 2);
            checkBox4.Checked = GetOneOutputStatus(currentOutputStatus, 3);
            lbInput5.Text = GetStatusString(currentOutputStatus, 4);
            lbInput6.Text = GetStatusString(currentOutputStatus, 5);
            lbInput7.Text = GetStatusString(currentOutputStatus, 6);
            lbInput8.Text = GetStatusString(currentOutputStatus, 7);
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
            UpdateStatus();
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

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                UpdateOneBit(1, 1);
            }
            else
            {
                UpdateOneBit(0, 1);
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                UpdateOneBit(1, 2);
            }
            else
            {
                UpdateOneBit(0, 2);
            }

        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                UpdateOneBit(1, 3);
            }
            else
            {
                UpdateOneBit(0, 3);
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
            frmI2CIO4R4x0 frm = new frmI2CIO4R4x0();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
