// Control everything i2c library

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FTD2XX_NET;

namespace AnyI2cLib
{
    // libaray for ftdi i2c interface
    public class I2CAdapter
    {
        public uint LocationID = uint.MaxValue;     // localtion id of the bridge
        private FT232HI2C mDevice = new FT232HI2C();
        public static I2CAdapter[] EnumBridge()
        {
            ArrayList array = new ArrayList();
            FTDI.FT_DEVICE_INFO_NODE[] ftdiList = ListFtdi.EnumFtdi();
            for (int i = 0; i < ftdiList.Length; i++)
            {
                if (ftdiList[i].Type == FTDI.FT_DEVICE.FT_DEVICE_232H)
                {
                    I2CAdapter b = new I2CAdapter();
                    b.LocationID = ftdiList[i].LocId;
                    array.Add(b);
                }

            }
            if(array.Count > 0)
            {
                return (I2CAdapter[])array.ToArray(typeof(I2CAdapter));
            }
            return null;
        }


        // open i2c bus adapter
        public bool Open()
        {

            mDevice.Open(LocationID);
            mDevice.Init();
            return mDevice.IsOpen;
        }

        /// <summary>
        /// close i2c bus adapter
        /// </summary>
        public void Close()
        {
            mDevice.Close();
        }

        /// <summary>
        /// Scan all available devices, return null is no device is found
        /// </summary>
        /// <returns></returns>
        public byte[] ScanDevices()
        {
            return mDevice.SacnDevices();
        }


        /// <summary>
        /// atribute for if the i2c bus adapter is opened
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return mDevice.IsOpen;
            }
        }

        /// <summary>
        /// Cmd for read, 
        /// readLength, length for reading
        /// </summary>
        /// <param name="readCmd"></param>
        /// <param name="readLength"></param>
        public byte[] ReadData(byte addr, byte dataLength)
        {
            return mDevice.ReadI2cData(addr, dataLength);
        }

        /// <summary>
        /// Write data
        /// Return true when success, false for error
        /// </summary>
        /// <param name="buffer"></param>
        public bool Write(byte add, byte[] buffer)
        {
            return mDevice.Write(buffer);
        }


    }

}
