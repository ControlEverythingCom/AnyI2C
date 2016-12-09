// 
// ALL RIGHTS RESERVED:
// ====================
// The contents of this file, and associated files in this directory, are 
// Copyright (C) Serial Port Tool(SPT) , all rights reserved, 2009.
// All software Source Code, Images, Database-Design and code, Graphics Design 
// and source files, and related content (collectively referred to as SOURCE) are 
// Copyright (C) SPT, 2009, All Rights Reserved.
// http://SerialPortTool.com
//


using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;

namespace AnyI2cLib
{

    public delegate void UpdateMessageHandler(string err);

    public class ConnectionException : Exception
    {
        string mMessage;
        public ConnectionException(string msg)
        {
            mMessage = msg;
        }

        public override string Message
        {
            get
            {
                return mMessage;
            }
        }
    }


    public class NetworkConfig
    {
        public string IPAddress = "192.168.0.104";
        public int NetworkPort = 2101;      // default port number is 2000
    }

    /// <summary>
    /// use for port data
    /// </summary>
    public class PortData
    {

        public PortData()   //default setting
        {
            string[] ports = SerialPort.GetPortNames();
            portName = ports.Length > 0 ? ports[0] : String.Empty;  //get first valid port name
            baudRate = 115200;
        }

        /// <summary>
        /// construct portData object with specified port name
        /// </summary>
        /// <param name="name">specified port name</param>
        public PortData(string name)
        {
            portName = name;
            baudRate = 115200;
        }


        public string portName; //port name
        public int baudRate; //baud rate

    }

    public class DeviceConfig
    {
        public PortData PortData = new PortData();
        public NetworkConfig Network = new NetworkConfig();
        public bool UsingComPort = true;

        public DeviceConfig Clone()
        {
            DeviceConfig cfg = new DeviceConfig();
            cfg.PortData.baudRate = PortData.baudRate;
            cfg.PortData.portName = PortData.portName;
            cfg.Network.IPAddress = Network.IPAddress;
            cfg.Network.NetworkPort = Network.NetworkPort;
            cfg.UsingComPort = UsingComPort;
            return cfg;
        }
    }

    public class CommunicationLayer
    {

        private int mReadTimeout = 100;
        public int ReadTimeout
        {
            get
            {
                return mReadTimeout;
            }
            set
            {
                mReadTimeout = 100;
            }
        }

        /// <summary>
        /// callback for update connection status
        /// </summary>
        public event UpdateMessageHandler UpdateConnectionStatus;

        private CommBaseObj mCom = new ComPortWrapper();

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public bool IsOpen
        {
            get
            {
                if (mCom != null)
                {
                    return mCom.IsOpen;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Construction
        /// </summary>
        public CommunicationLayer()
        {

        }

        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public string ConnectionInfo
        {
            get
            {
                string info = "Error";
                if (mCom != null)
                {
                    info = mCom.ConnectionInfo;
                }
                return info;

            }
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public void Purge()
        {
            if (mCom != null)
            {
                mCom.Purge();
            }
        }

        public void TRIIWriteBytes(byte[] data)
        {
            if (mCom != null)
            {
                mCom.TRIIWriteBytes(data);
            }
        }

        /// <summary>
        /// Flush the data in write buffer to port, it is added for network communiction only
        /// Serial port will write the to port immediately
        /// </summary>
        public void Flush()
        {
            if (mCom != null)
            {
                mCom.Flush();
            }
        }

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        public void SetParameters(DeviceConfig cfg)
        {
            if (mCom != null)
            {
                mCom.Close();
            }
                
            if (cfg.UsingComPort)
            {
                mCom = new ComPortWrapper();
            }
            else
            {
                mCom = new TcpWrapper();
            }

            mCom.SetParameters(cfg);
            mCom.OnConnectStatusChange += new UpdateMessageHandler(OnConnectionStatusChanged);
        }

        private void OnConnectionStatusChanged(string msg)
        {
            if (UpdateConnectionStatus != null)
            {
                UpdateConnectionStatus(msg);
            }
        }


        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public void Open()
        {
            if (mCom != null)
            {
                mCom.Open();
            }

        }

        /// <summary>
        /// Open the connection, 
        /// return false if time out
        /// </summary>
        /// <param name="timeout"></param>
        public void Open(int timeout)
        {
            if (mCom != null)
            {
                mCom.Open(timeout);
            }
        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public void Close()
        {
            if (mCom != null)
            {
                mCom.Close();
            }
        }

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void WriteByte(byte data)
        {
            if (mCom != null)
            {
                mCom.WriteByte(data);
            }
        }


        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void WriteBytes(byte [] data)
        {
            if (mCom != null)
            {
                mCom.WriteBytes(data);
            }
        }


        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            try
            {
                if (mCom != null)
                {
                    return (mCom.ReadByte());
                }

            }
            catch
            {
                throw new Exception("Null Com Object");
            }
            return 0;

        }

        /// <summary>
        /// set the write pace between byte, 
        /// </summary>
        /// <param name="ms"></param>
        public void SetTCPWritePace(int ms)
        {
            mCom.SetTCPWritePace(ms);
        }


    }

    public interface CommBaseObj
    {
        event UpdateMessageHandler OnConnectStatusChange;
        
        /// <summary>
        /// property for if the device is open
        /// </summary>
        bool IsOpen
        {
            get;
        }


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        string ConnectionInfo
        {
            get;
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        void Purge();

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        void SetParameters(DeviceConfig cfg);

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        void Open();

        /// <summary>
        /// Open device with timeout
        /// </summary>
        /// <param name="timeout"></param>
        void Open(int timeout);

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        void Close();

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        void WriteByte(byte data);

        /// <summary>
        /// Write byte array 
        /// </summary>
        /// <param name="data"></param>
        void WriteBytes(byte[] data);

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        byte ReadByte();

        /// <summary>
        /// Flush the data in write buffer to port, it is added for network communiction only
        /// Serial port will write the to port immediately
        /// </summary>
        void Flush();


        /// <summary>
        /// set the write pace between byte, 
        /// </summary>
        /// <param name="ms"></param>
        void SetTCPWritePace(int ms);

        /// <summary>
        /// write bytes method for Taralist II 
        /// </summary>
        /// <param name="data"></param>
        void TRIIWriteBytes(byte[] data);



    }

    public class ComPortWrapper : CommBaseObj
    {
        private event UpdateMessageHandler mOnConnectStatusChange; 
        public event UpdateMessageHandler OnConnectStatusChange
        {
            add
            {
                if (mOnConnectStatusChange == null)
                {
                    mOnConnectStatusChange = value;
                }
                else
                {
                    lock (mOnConnectStatusChange)
                    {
                        mOnConnectStatusChange += value;
                    }
                }
            }
            remove
            {
                if (mOnConnectStatusChange == null)
                {
                    mOnConnectStatusChange = value;
                }
                else
                {
                    lock (mOnConnectStatusChange)
                    {
                        mOnConnectStatusChange -= value;
                    }
                }
            }
        }
        
        
        SerialPort mPort = new SerialPort();


        public ComPortWrapper()
        {

        }

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return mPort.IsOpen;
            }
        }


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public string ConnectionInfo
        {
            get
            {
                if (IsOpen)
                {
                    return mPort.PortName + " " + mPort.BaudRate.ToString();
                }
                else
                {
                    return mPort.PortName + " Error";
                }
            }
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public void Purge()
        {
            if (!IsOpen)
            {
                return;
            }
            try
            {
                mPort.ReadTimeout = 0;
                while (true)
                {
                    mPort.ReadByte();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        public void SetParameters(DeviceConfig cfg)
        {
            if (!cfg.UsingComPort)
            {
                throw new Exception("Wrong Configuration Data");
            }
            bool portOpen = IsOpen;
            if (portOpen)
            {
                Close();
            }
            mPort.PortName = cfg.PortData.portName;
            mPort.BaudRate = cfg.PortData.baudRate;
            if (portOpen)
            {
                Open();
            }
        }

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public void Open()
        {
            try
            {
                mPort.Open();
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(mPort.PortName + ", " + mPort.BaudRate);
                }
            }
            catch 
            {
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(mPort.PortName + " Error");
                }
            }
        }

        /// <summary>
        /// open with timeout, 
        /// timeout value is invalid for serial port
        /// </summary>
        /// <param name="timeout"></param>
        public void Open(int timeout)
        {
            Open();
        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public void Close()
        {
            try
            {
                mPort.Close();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void WriteByte(byte data)
        {
            if (IsOpen)
            {
                try
                {
                    mPort.WriteTimeout = 100;
                    mPort.Write(new byte[] { data }, 0, 1);
                }
                catch
                {

                }

            }
        }

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void WriteBytes(byte[] data)
        {
            if (IsOpen)
            {
                try
                {
                    mPort.WriteTimeout = 100;
                    mPort.Write(data, 0, data.Length);
                }
                catch
                {

                }

            }
        }



        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            byte nData = 0;
            if (IsOpen)
            {
                mPort.ReadTimeout = 1000;
                nData = (byte)mPort.ReadByte();

            }
            else
            {
                throw new Exception("Port Closed");
            }
            return nData;
        }

        /// <summary>
        /// Flush the data in write buffer to port, it is added for network communiction only
        /// Serial port will write the to port immediately
        /// </summary>
        public void Flush()
        {
            // do nothing
        }

        /// <summary>
        /// set the write pace between byte, for tcp only
        /// </summary>
        /// <param name="ms"></param>
        public void SetTCPWritePace(int ms)
        {

        }

        public void TRIIWriteBytes(byte[] data)
        {
            WriteBytes(data);
        }


    }


}
