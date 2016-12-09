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
using System.Collections;
using System.Text;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;

namespace AnyI2cLib
{
    public class TcpWrapper : CommBaseObj
    {
        string mIp = "192.168.0.100";
        int mPort = 2101;
        
        int mReadPoolTime = 500000;     // read and write
        int mWritePoolTimie = 500000;

        ArrayList mBuffer = new ArrayList();    // buffer that hold on data in writebyte. The data in buffer will be sent before read 

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


        Socket mTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        public TcpWrapper()
        {

        }

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return mTcp.Connected;
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
                    return mIp;
                }
                else
                {
                    return mIp + " Error";
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
                while (mTcp.Poll(50000,SelectMode.SelectRead))
                {
                    byte [] buffer = new byte[1];
                    mTcp.Receive(buffer);
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
            if (cfg.UsingComPort)       // use tcp ip only
            {
                throw new Exception("Wrong Configuration Data");
            }
            bool portOpen = IsOpen;
            if (portOpen)
            {
                Close();
            }
            mIp  = cfg.Network.IPAddress;
            mPort = cfg.Network.NetworkPort;
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
                mTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(mIp);
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, mPort);
                mTcp.Connect(ipEnd);
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(ConnectionInfo);
                }
            }
            catch 
            {
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(ConnectionInfo);
                }
            }
        }

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public void Open(int timeout)
        {
            try
            {
                mTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(mIp);
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, mPort);
                IAsyncResult result = mTcp.BeginConnect(ipEnd, null, null);

                bool success = result.AsyncWaitHandle.WaitOne(timeout, true);

                if (!success)
                {
                    // NOTE, MUST CLOSE THE SOCKET

                    mTcp.Close();
                    throw new ApplicationException("Failed to connect server.");
                }
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(ConnectionInfo);
                }
            }
            catch
            {
                if (mOnConnectStatusChange != null)
                {
                    mOnConnectStatusChange(ConnectionInfo);
                }
            }
        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public void Close()
        {
            try
            {
                mTcp.Close();
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
                //mBuffer.Add(data);
                if (mTcp.Poll(mWritePoolTimie, SelectMode.SelectWrite))
                {
                    mTcp.Send(new byte[] { data });
                }
                else
                {
                    throw new Exception("write Time out");
                }

            }
            else
            {
                throw new Exception();
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

                if (mTcp.Poll(mWritePoolTimie, SelectMode.SelectWrite))
                {
                    if (mPace == 0)
                    {
                        mTcp.Send(data);
                    }
                    else
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            byte[] d1 = new byte[1];
                            d1[0] = data[i];
                            mTcp.Send(d1);
                            System.Threading.Thread.Sleep(mPace);
                        }
                    }
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    throw new Exception("write Time out");
                }

            }
            else
            {
                throw new Exception();
            }
        }


        /// <summary>
        /// For taralist ii,will hold data till flush was called
        /// </summary>
        /// <param name="data"></param>
        public void TRIIWriteBytes(byte[] data)
        {
            mBuffer.AddRange(data);
        }


        /// <summary>
        /// Write the data in buffer
        /// </summary>
        private void SendBufferData()
        {
            if(mBuffer.Count > 0)
            {
                if (mTcp.Poll(mWritePoolTimie, SelectMode.SelectWrite))
                {
                    byte [] data = (byte[] )mBuffer.ToArray(typeof(byte));
                    mBuffer.Clear();    // clear the buffer
                    if (mPace == 0)
                    {
                        mTcp.Send(data);
                    }
                    else
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            byte [] d1 = new byte[1];
                            d1[0] = data[i];
                            mTcp.Send(d1);
                            System.Threading.Thread.Sleep(mPace);
                        }
                    }
                    if (mPace != 0)
                    {
                        System.Threading.Thread.Sleep(10);
                    }
                }
                else
                {
                    throw new Exception("write Time out");
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

                SendBufferData();
                //if (mTcp.Poll(50000, SelectMode.SelectWrite))
                //{
                //    mTcp.Send(new byte[] { data });
                //}
                //else
                //{
                //    throw new Exception("write Time out");
                //}
                if(mTcp.Poll(mReadPoolTime, SelectMode.SelectRead))
                {
                    byte[] buffer = new byte[1];
                    if (mTcp.Receive(buffer, SocketFlags.None) == 1)
                    {
                        nData = buffer[0];
                    }
                    else
                    {
                        throw new Exception("Read Time out");
                    }
                }
                else
                {
                    throw new Exception("Read Time out");
                }

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
            if (IsOpen)
            {
                SendBufferData();
            }
        }

        private int mPace = 0;  // pace between byte, 0 for write whole buffer, one time

        /// <summary>
        /// set the write pace between byte, 
        /// </summary>
        /// <param name="ms"></param>
        public void SetTCPWritePace(int ms)
        {
            mPace = ms;
            if (mPace != 0)
            {
                mReadPoolTime = 5000000;
                mWritePoolTimie = 500000;
            }
            else
            {
                mReadPoolTime = 50000;
                mWritePoolTimie = 50000;
            }
        }

    }
}
