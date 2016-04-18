using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AnyI2C;

namespace CurrentMonitor_I2CS
{
    public partial class frmI2CS : Form
    {
        string[] SensorTypes = { "DLCT03C20", "DLCT27C10", "DLCT03CL20", "OPCT16AL" };
        CommInterface CommObj = null;
        byte mChannelsCount = 12;
        ArrayList ChansArray;
        ArrayList PanelsArray;

        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();

            // add all channels control to array
            ChansArray = new ArrayList();
            ChansArray.Add(lbCh1);
            ChansArray.Add(lbCh2);
            ChansArray.Add(lbCh3);
            ChansArray.Add(lbCh4);
            ChansArray.Add(lbCh5);
            ChansArray.Add(lbCh6);
            ChansArray.Add(lbCh7);
            ChansArray.Add(lbCh8);
            ChansArray.Add(lbCh9);
            ChansArray.Add(lbCh10);
            ChansArray.Add(lbCh11);
            ChansArray.Add(lbCh12);
            
            // add all panels control to array
            PanelsArray = new ArrayList();
            PanelsArray.Add(groupCh1);
            PanelsArray.Add(groupCh2);
            PanelsArray.Add(groupCh3);
            PanelsArray.Add(groupCh4);
            PanelsArray.Add(groupCh5);
            PanelsArray.Add(groupCh6);
            PanelsArray.Add(groupCh7);
            PanelsArray.Add(groupCh8);
            PanelsArray.Add(groupCh9);
            PanelsArray.Add(groupCh10);
            PanelsArray.Add(groupCh11);
            PanelsArray.Add(groupCh12);

            EnableGUI(false);
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

        /// <summary>
        /// Disable OR Enable GUI Boxes and Buttons
        /// </summary>
        private void EnableGUI(bool response)
        {
            groupBoxReadAllCh.Enabled = response;
            for (int i = 0; i < PanelsArray.Count; i++)
            {
                GroupBox g = (GroupBox)(PanelsArray[i]);
                g.Enabled = response;
            }
        }

        /// <summary>
        /// Enable Required GUI Boxes and Buttons
        /// </summary>
        private void EnableRequiredGUI(int numberOfChannels)
        {
            for (int i = 0; i < numberOfChannels; i ++ )
            {
                GroupBox g = (GroupBox)(PanelsArray[i]);
                g.Enabled = true;
            }

        }

        private bool InitializeSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(true);
                //read the  the sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x92, 0x6A, 0x02, 0x00, 0x00, 0x00, 0x00, 0xFE }, 7);
                Thread.Sleep(100);
                if (value != null)
                {
                    if (value.Length == 7)
                    {
                        lbType.Text = SensorTypes[value[0] - 1];
                        lbMaxCurrent.Text = value[1].ToString();
                        mChannelsCount = value[2];
                        lbNoOfChannels.Text = mChannelsCount.ToString();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    _ERROR.Visible = true;
                    return false;
                }
            }
            catch
            {
                _ERROR.Visible = true;
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadAllChannels();
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

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(txtInterval.Text);
            timer1.Enabled = chkAutoUpdate.Checked;
        }

        private void InitSensor_Click(object sender, EventArgs e)
        {
            bool bRtn = InitializeSensor();
            if (bRtn)
            {
                btnInit.Enabled = false;
                btnCalibration.Enabled = true;
                groupBoxReadAllCh.Enabled = true;
                EnableRequiredGUI(mChannelsCount);
                CommObj.LogText("GUI Initialize Complete");
            }
        }

        private void readCh1_Click(object sender, EventArgs e)
        {

        }

        private void readCh1_Click_1(object sender, EventArgs e)
        {
            byte addr = GetAddress(true);
            Button btn = (Button)sender;
            byte chan = byte.Parse((string)(btn.Tag));// tag contains channel information for each button
            byte[] temp = new byte[] { 0x92, 0x6A, 0x01, chan, chan, 0x00, 0x00 };
            byte checksum = GetCheckSum(temp);
            byte[] value = CommObj.Send(new byte[] { addr, 0x92, 0x6A, 0x01, chan, chan, 0x00, 0x00, checksum }, 4);

            if (value != null)
            {
                if (value.Length == 4)
                {
                    Label lb = (Label)ChansArray[chan - 1];
                    double amp = (value[0] * 256 * 256 + value[1] * 256 + value[2]) / 1000.0;
                    lb.Text = amp.ToString("f3");
                }
            }
            else
            {
                _ERROR.Visible = true;
            }
        }

        private void ReadAllChannels()
        {
            byte addr = GetAddress(true);
            byte chan = mChannelsCount;
            byte[] temp = new byte[] { 0x92, 0x6A, 0x01, 1, chan, 0x00, 0x00 };
            byte checksum = GetCheckSum(temp);
            byte[] value = CommObj.Send(new byte[] { addr, 0x92, 0x6A, 0x01, 1, chan, 0x00, 0x00, checksum}, (byte)(chan*3 + 1));
            if (value != null)
            {
                if (value.Length == (chan*3 + 1))
                {
                    for (int i = 0; i < chan; i++)
                    {
                        Label lb = (Label)ChansArray[i];
                        double amp = (value[0 + i * 3] * 256 * 256 + value[1 + i * 3] * 256 + value[2 + i * 3]) / 1000.0;
                        lb.Text = amp.ToString("f3");
                    }
                }
            }
            else
            {
                _ERROR.Visible = true;
            }
        }

        private void ReadAllCh_Click(object sender, EventArgs e)
        {
            ReadAllChannels();
        }

        /// <summary>
        /// Calculate the check sum
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte GetCheckSum(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum += data[i];
            }
            return (byte)(checksum & 0xff);
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            frmCalibration frm = new frmCalibration();
            frm.CommObj = CommObj;
            frm.ChannelsCount = mChannelsCount;
            frm.Address = GetAddress(true);
            frm.ShowDialog();
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
