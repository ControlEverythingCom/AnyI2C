using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCD;
namespace AnyI2cLib
{
    /// <summary>
    /// Driver for Bridge X2&X5
    /// </summary>
    public class I2CBridgeX
    {
        NCDComponent Component = new NCDComponent();
        public string PortName = string.Empty;
        public I2CBridgeX()
        {

        }


        public bool Open()
        {
            Component.PortName = PortName;
            Component.BaudRate = 115200;
            Component.UsingComPort = true;
            Component.OpenPort();
            return Component.IsOpen;

        }

        public void Close()
        {
            Component.ClosePort();
        }

        public byte[] ScanDevices(byte port)
        {
            ArrayList devices = new ArrayList();

            for (byte i = 63; i < 128; i++)
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
                return Component.IsOpen;
            }
        }

        public byte[] ReadData(byte port, byte addr, byte dataLength)
        {

            if (Component.IsOpen)
            {
                byte[] data = new byte[5];
                data[0] = 188;
                data[1] = (byte)(port + 50);
                data[2] = (byte)(1);
                data[3] = (byte)(addr*2 + 1);
                data[4] = dataLength;
                Component.WriteBytesAPI(data);
                data = Component.ReadBytesApi();
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
            if (Component.IsOpen)
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
                Component.WriteBytesAPI(data);
                data = Component.ReadBytesApi();
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
            SerialDeviceInfo [] info = NCD.ListPorts.EnumPorts();
            ArrayList list = new ArrayList();
            try
            {
                for (int i = 0; i < info.Length; i++)
                {
                    bool isI2c = IsI2CBridgeX(info[i].PortName);
                    Debug.Print(isI2c.ToString());
                    //if (isI2c)
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

    }
}
