using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using NCD;
namespace AnyI2cLib
{
    /// <summary>
    /// Driver for Bridge X2&X5
    /// </summary>
    public class I2CBridgeX
    {

        public delegate void OnReadDataHandler(object sender, byte[]rData);
        public delegate void OnWriteDataHandler(object sender, byte[] sData);

        public OnReadDataHandler OnReadData;
        public OnWriteDataHandler OnWriteData;

        //NCDComponent Component = new NCDComponent();
        SerialPort mCom = new SerialPort();
        public string PortName = string.Empty;
        public I2CBridgeX()
        {
        }


        public bool Open()
        {
            mCom.PortName = PortName;
            mCom.BaudRate = 115200;
            mCom.Open();
            return mCom.IsOpen;

        }

        public void Close()
        {
            mCom.Close();
        }

        public byte[] ScanDevices(byte port)
        {
            ArrayList devices = new ArrayList();

            for (byte i = 0; i < 128; i++)
            {
                bool exist = Write(port, i, null);
                if(exist)
                {
                    devices.Add(i);
                }
            }
            return (byte[])devices.ToArray(typeof(byte));
        }

        public bool IsOpen
        {
            get
            {
                return mCom.IsOpen;
            }
        }

        public byte[] ReadData(byte port, byte addr, byte dataLength)
        {

            if (mCom.IsOpen)
            {
                byte[] data = new byte[5];
                data[0] = 188;
                data[1] = (byte)(port + 50);
                data[2] = (byte)(1);
                data[3] = (byte)(addr*2 + 1);
                data[4] = dataLength;
                WriteBytesAPI(data);
                //OnMyWriteData(this, data);
                data = ReadBytesApi();
                //OnMyReadData(this, data);
                if (data != null)
                {
                    return data;
                }
            }
            return null;
        }

        public bool Write(byte port, byte addr, params byte[] buffer)
        {
            bool bRtn = false;
            if (mCom.IsOpen)
            {
                int bufferLength = 0;
                if (buffer != null)
                {
                    bufferLength = buffer.Length;
                }
                byte[] data = new byte[bufferLength + 5];
                data[0] = 188;
                data[1] = (byte)(port + 50);
                data[2] = (byte)(bufferLength + 1);
                data[3] = (byte)(addr * 2);
                data[4 +bufferLength ] = 0;
                for (int i = 0; i < bufferLength; i++)
                {
                    data[4 + i] = buffer[i];
                }
                WriteBytesAPI(data);
                //OnMyWriteData(this, data);
                data = ReadBytesApi();
                //OnMyReadData(this, data);
                if (data != null)
                {
                    if (data[0] == 85)
                    {
                        bRtn = true;
                    }
                }
            }

            return bRtn;
        }

        /// <summary>
        /// list all bridge x2 and x5
        /// </summary>
        /// <returns></returns>
        public static I2CBridgeX[] EnumBridge()
        {
            SerialDeviceInfo [] info = ListPorts.EnumPorts();
            ArrayList list = new ArrayList();
            try
            {
                for (int i = 0; i < info.Length; i++)
                {
                    bool isI2c = IsI2CBridgeX(info[i].PortName);
                    Debug.Print(isI2c.ToString());
                    if (isI2c)
                    {
                        I2CBridgeX b = new I2CBridgeX();
                        b.PortName = info[i].PortName;
                        list.Add(b);
                    }
                }
            }
            catch
            {
            }
            return (I2CBridgeX[])list.ToArray(typeof(I2CBridgeX));
        }

        /// <summary>
        /// return value in specific address
        /// return -1 if not valid
        /// 0-255 for value in rom
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        private static int GetEE(NCDComponent ncdObj,  byte addr)
        {
            ncdObj.WriteBytesAPI(254, 53, addr);
            byte[]  data = ncdObj.ReadBytesApi();
            if (data != null)
            {
                return data[0];
            }
            return -1;
        }

        /// <summary>
        /// test if it is a i2cBridgeX device by reading eeprom data
        /// </summary>
        /// <param name="comport"></param>
        /// <returns></returns>
        public static bool IsI2CBridgeX(string comport)
        {
            bool bRtn = false;
            NCDComponent ncdObj = new NCDComponent();
            try
            {
                ncdObj.PortName = comport;
                ncdObj.BaudRate = 115200;
                ncdObj.UsingComPort = true;
                ncdObj.OpenPort();
                if (ncdObj.IsOpen)
                {
                    int n = GetEE(ncdObj, 246);
                    if ((n > 0) && (n & 32) > 0)
                    {
                        bRtn = true;
                    }
                }
            }
            catch
            {
                bRtn = false;
            }
            finally
            {
                ncdObj.ClosePort();
            }

            return bRtn;
        }

        public void OnMyReadData(object sender, byte[]  e)
        {
            if (OnReadData != null)
            {
                OnReadData(sender, e);
            }
        }

        public void OnMyWriteData(object sender, byte[] e)
        {
            if (OnWriteData != null)
            {
                OnWriteData(sender, e);
            }
        }

        /// <summary>
        /// Write data in api format
        /// </summary>
        /// <param name="data"></param>
        public void WriteBytesAPI(params byte[] data)
        {
            if (mCom.IsOpen)
            {
                ArrayList ApiPackage = new ArrayList();
                ApiPackage.Add((byte)170);
                ApiPackage.Add((byte)data.Length);
                ApiPackage.AddRange(data);
                int checksum = 0;
                checksum = checksum + 170;
                checksum = checksum + data.Length;
                for (int i = 0; i < data.Length; i++)
                {
                    checksum = checksum + data[i];
                }
                checksum = checksum % 0x100;
                ApiPackage.Add((byte)checksum);
                byte[] apiData = (byte[])ApiPackage.ToArray(typeof(byte));
                WriteBytes(apiData);
            }
        }


        /// <summary>
        /// Ready a byte from Com port
        /// </summary>
        /// <returns>0 - 255, the data read, -1 for failure</returns>
        public int ReadByte()
        {
            int nRtn = -1;
            try
            {
                byte data = 0;
                if (_ReadByte(out data))
                {
                    nRtn = data;
                }

            }
            catch
            {

            }
            return nRtn;
        }


        /// <summary>
        /// Read a byte from Com Port
        /// </summary>
        /// <param name="data">data been read</param>
        /// <returns>true for success</returns>
        internal bool _ReadByte(out byte data)
        {
            bool bRtn = false;
            data = 0;
            try
            {
                data = (byte)mCom.ReadByte();
                bRtn = true;

            }
            catch (TimeoutException ex)
            {
            }

            return bRtn;
        }

        /// <summary>
        /// Read data in api format, return null if read nothing
        /// </summary>
        /// <returns></returns>
        public byte[] ReadBytesApi()
        {
            ArrayList ar = new ArrayList();
            byte[] apiData = null;
            int ack = ReadByte();
            if (ack != 170)
            {
                mCom.ReadExisting();
                return apiData;
            }
            ar.Add((byte)ack);
            bool correctData = true;
            int length = ReadByte();
            if (length != -1)
            {
                ar.Add((byte)length);
                apiData = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    int data = ReadByte();
                    if (data != -1)
                    {
                        apiData[i] = (byte)data;
                        ar.Add((byte)data);
                    }
                    else
                    {
                        correctData = false;
                        break;
                    }
                }
                if (correctData)
                {
                    int data = ReadByte();
                    if (data != -1)
                    {
                        ar.Add((byte)data);
                        int checksum = 170 + length + GetCheckSum(apiData);
                        checksum = checksum % 0x100;
                        if (data != checksum)
                        {
                            correctData = false;
                        }
                    }
                    else
                    {
                        correctData = false;
                    }

                }
            }
            else
            {
                correctData = false;
            }
            OnMyReadData(this, (byte[])ar.ToArray(typeof(byte)));
            if (correctData)
            {
                return apiData;
            }
            return null;

        }

        /// <summary>
        /// calculate the checksum of the data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte GetCheckSum(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum = checksum + data[i];
            }
            checksum = checksum % 0x100;
            return (byte)checksum;
        }


        private void WriteBytes(byte[] data)
        {
            OnMyWriteData(this, data);
            mCom.Write(data, 0, data.Length);
        }


    }


}
