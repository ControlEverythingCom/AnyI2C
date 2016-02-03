
using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.ComponentModel;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace AnyI2cLib
{
    /// <summary>
    /// ListPorts class is used to get information from ListPorts.exe
    /// </summary>
    public class ListPorts
    {
        public SerialDeviceInfo[] Infos;
        public static SerialDeviceInfo[] EnumPorts()
        {
            try
            {

                ArrayList list = new ArrayList();
                ManagementObjectSearcher searcher =

                                new ManagementObjectSearcher("root\\CIMV2",

                                "SELECT * FROM Win32_PnPEntity");

                if (searcher != null)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        object obj = queryObj["Caption"];
                        if (obj != null)
                        {
                            if (obj.ToString().Contains("(COM"))
                            {
                                SerialDeviceInfo deviceInfo;
                                deviceInfo.FriendName = obj.ToString();
                                deviceInfo.PortName = FindComPortString(deviceInfo.FriendName);
                                list.Add(deviceInfo);
                            }

                        }

                    }
                    return (SerialDeviceInfo[])list.ToArray(typeof(SerialDeviceInfo));

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }

        /// <summary>
        /// finid the com port string 
        /// </summary>
        /// <param name="des"></param>
        /// <returns></returns>
        static string FindComPortString(string des)
        {
            int n1 = des.LastIndexOf('(');
            int n2 = des.LastIndexOf(')');
            return des.Substring(n1 + 1, n2 - n1 - 1);
        }


        /// <summary>
        /// list all bridge X port
        /// </summary>
        /// <returns></returns>
        public static SerialDeviceInfo[] EnumBridgeXPorts()
        {
            ArrayList list = new ArrayList();
            SerialDeviceInfo [] infos= EnumPorts();
            for (int i = 0; i < infos.Length; i++)
            {
                NCDCom com = new NCDCom(infos[i].PortName);
                if (com.Open())
                {
                    if (com.IsI2CBridgeX())
                    {
                        list.Add(infos[i]);
                    }
                    com.Close();
                }


            }
            return (SerialDeviceInfo[])list.ToArray(typeof(SerialDeviceInfo));
        }



    }

    public class NCDCom
    {
        public SerialPort mCom;

        public NCDCom(String port)
        {
            mCom = new SerialPort();
            mCom.BaudRate = 115200;
            mCom.PortName = port;

        }

        /// <summary>
        /// open the com port
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            bool isOpen = false;
            try
            {
                mCom.ReadTimeout = 100;
                mCom.Open();
                isOpen = mCom.IsOpen;
            }
            catch
            {

            }
            return isOpen;
        }

        public void Close()
        {
            if (mCom.IsOpen)
            {
                mCom.Close();
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
            byte[] apiData = null;
            int ack = ReadByte();
            if (ack != 170)
            {
                mCom.ReadExisting();
                return apiData;
            }

            bool correctData = true;
            int length = ReadByte();
            if (length != -1)
            {
                apiData = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    int data = ReadByte();
                    if (data != -1)
                    {
                        apiData[i] = (byte)data;
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
            mCom.Write(data, 0, data.Length);
        }

        /// <summary>
        /// test if it is a i2cBridgeX device by reading eeprom data
        /// </summary>
        /// <param name="comport"></param>
        /// <returns></returns>
        public bool IsI2CBridgeX()
        {
            bool bRtn = false;
            try
            {
                int n = GetEE(246);
                if ((n > 0) && (n & 32) > 0)
                {
                    bRtn = true;
                }
            }
            catch
            {
                bRtn = false;
            }
            finally
            {
            }
            return bRtn;
        }

        /// <summary>
        /// return value in specific address
        /// return -1 if not valid
        /// 0-255 for value in rom
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public int GetEE(byte addr)
        {
            WriteBytesAPI(254, 53, addr);
            byte[] data = ReadBytesApi();
            if (data != null)
            {
                return data[0];
            }
            return -1;
        }

    }
    

    /// <summary>
    /// structure for serial port device, include serial port and modem
    /// </summary>
    public struct SerialDeviceInfo
    {
        public string FriendName;
        public string PortName;

    }

}
