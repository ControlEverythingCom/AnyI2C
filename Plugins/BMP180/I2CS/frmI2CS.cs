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

namespace BMP180_I2CS
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

        double ReadUnsignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr }, 2);
            if (value != null)
            {
                if (value.Length == 2)
                {
                    return value[0] * 256 + value[1];
                }
            }
            throw new Exception("Error Read");
        }

        double ReadSignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr }, 2);
            if (value != null)
            {
                if (value.Length == 2)
                {
                    if (value[0] < 128)
                    {
                        return value[0] * 256 + value[1];
                    }
                    else
                    {
                        return value[0] * 256 + value[1] - 65536;
                    }
                }
            }
            throw new Exception("Error Read");
        }


        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                double AC1 = ReadSignedShort(0xAA);
                double AC2 = ReadSignedShort(0xAC);
                double AC3 = ReadSignedShort(0xAE);
                double AC4 = ReadUnsignedShort(0xB0);
                double AC5 = ReadUnsignedShort(0xB2);
                double AC6 = ReadUnsignedShort(0xB4);
                double B1 = ReadSignedShort(0xB6);
                double B2 = ReadSignedShort(0xB8);
                double MB = ReadSignedShort(0xBA);
                double MC = ReadSignedShort(0xBC);
                double MD = ReadSignedShort(0xBE);

                //AC1 = 408;
                //AC2 = -72;
                //AC3 = -14388;
                //AC4 = 32741;
                //AC5 = 32757;
                //AC6 = 23153;
                //B1 = 6190;
                //B2 = 4;
                //MB = -32768;
                //MC = -8711;
                //MD = 2868;


                byte addr = GetAddress(false);
                // Read uncompensated temperature value
                byte[] value = CommObj.Send(new byte[] { addr, 0xF4, 0x2E}, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0xF6}, 2);
                int UT = value[0] * 256 + value[1];
                //UT = 27898;
                double X1 = (UT - AC6)*AC5/ Math.Pow(2, 15);
                double X2 = MC * Math.Pow(2, 11) / (X1 + MD);
                double B5 = X1 + X2;
                double T = (B5 + 8) / 16.0;
                T = T / 10.0;   //0.1 C
                lbT.Text = T.ToString("F2");

                // read uncompensated pressure
                value = CommObj.Send(new byte[] { addr, 0xF4, 0x34 }, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0xF6 }, 3);
                int UP = value[0] * 256 + value[1];
                //UP = 23843;
                double B6 = B5 - 4000;
                X1 = (B2 * (B6 * B6 / Math.Pow(2, 12))) / Math.Pow(2, 11);
                X2 = AC2 * B6 / Math.Pow(2, 11);
                double X3 = X1 + X2;
                double B3 = (((AC1 * 4 + X3)) + 2) / 4;
                X1 = AC3 * B6 / Math.Pow(2, 13);
                X2 = (B1 * (B6 * B6 / Math.Pow(2, 12))) / Math.Pow(2, 16);
                X3 = ((X1 + X2) + 2) / 4;
                double B4 = AC4 * (X3 + 32768) / Math.Pow(2, 15);
                double B7 = (UP - B3) * (50000);
                double p = B7 /B4 * 2.0;
                X1 = p * p / 65536;
                X1 = (X1 * 3038) / 65536;
                X2 = (-7357 * p) / 65536;
                p = p + (X1 + X2 + 3791) / 16;
                p = p / 100;    //0.01pa
                lbP.Text = p.ToString("F2");

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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbP_Click(object sender, EventArgs e)
        {

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
