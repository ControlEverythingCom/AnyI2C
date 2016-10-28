

using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace AnyI2cLib
{
    public class TcpWrapper : CommBaseObj
    {
        string mIp = "192.168.0.100";
        int mPort = 2000;

        private int mReadTimeout = 10;
        public override int ReadTimeOut
        {
            get
            {
                return mReadTimeout;
            }
            set
            {
                mReadTimeout = value;
            }
        }

        Socket mTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        public TcpWrapper()
        {

        }

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public override bool IsOpen
        {
            get
            {
                return mTcp.Connected;
            }
        }


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public override string ConnectionInfo
        {
            get
            {
                if (IsOpen)
                {
                    return mIp;
                }
                else
                {
                    return mIp + ", Error";
                }
            }
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public override void Purge()
        {
            if (!IsOpen)
            {
                return;
            }
            try
            {
                if (mTcp.Poll(50000, SelectMode.SelectRead))
                {
                    byte[] buffer = new byte[256];
                    mTcp.Receive(buffer);
                }
            }
            catch (SocketException ex)
            {
                mTcp.Close();
            }
        }

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        public bool SetParameters(NetworkConfig cfg)
        {
            try
            {
                bool portOpen = IsOpen;
                if (portOpen)
                {
                    Close();
                }
                mIp = cfg.IPAddress;
                mPort = cfg.NetworkPort;
                if (portOpen)
                {
                    Open();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Open device, reture true if opened
        /// </summary>
        /// <returns></returns>
        public override void Open()
        {
            try
            {
                mTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(mIp);
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, mPort);
                //mTcp.Connect(ipEnd);
                IAsyncResult result = mTcp.BeginConnect(ipEnd, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                if (success)
                {
                    _OnConnectStatusChange(ConnectionInfo);
                    //Log.SystemLogWriter w = new Log.SystemLogWriter();
                    //w.Log(ip.ToString() + " Opened");

                }
                else
                {
                    //Log.SystemLogWriter w = new Log.SystemLogWriter();
                    //w.Log(ip.ToString() + " Open failed");
                    mTcp.Close();

                }
            }
            catch (Exception ex)
            {
                _OnConnectStatusChange(ConnectionInfo);
                //Log.SystemLogWriter w = new Log.SystemLogWriter();
                //w.Log(mIp + " " + ex.Message);
            }
        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public override void Close()
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
        public override void WriteBytes(byte[] data)
        {
            try
            {
                if (IsOpen)
                {
                    if (mTcp.Poll(50000, SelectMode.SelectWrite))
                    {
                        mTcp.Send(data);
                    }
                    else
                    {
                        //throw new Exception("write Time out");
                    }

                }
                else
                {
                    //throw new Exception();
                }
            }
            catch (SocketException ex)
            {
                Close();
            }
        }

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public override byte ReadByte()
        {
            byte nData = 0;
            try
            {
                if (IsOpen)
                {
                    DateTime t = DateTime.Now;
                    TimeSpan ts = new TimeSpan();
                    //while (ts.TotalMilliseconds < mReadTimeout)
                    {
                        if (mTcp.Poll(5000000, SelectMode.SelectRead))
                        {
                            byte[] buffer = new byte[1];
                            if (mTcp.Receive(buffer, SocketFlags.None) == 1)
                            {
                                nData = buffer[0];
                                return nData;
                            }
                            else
                            {
                                ts = DateTime.Now - t;
                            }
                        }
                        else
                        {
                            ts = DateTime.Now - t;
                        }

                    }
                    throw new TimeoutException();


                }
                else
                {
                    throw new Exception("Read Byte Error");
                }
            }
            catch (SocketException ex)
            {
                Close();
            }
            return nData;
        }

        public override byte[] ReadAll()
        {
            try
            {
                if (IsOpen)
                {
                    ArrayList ar = new ArrayList();
                    if (mTcp.Poll(1000000, SelectMode.SelectRead))
                    {
                        byte[] buffer = new byte[128];
                        int n = mTcp.Receive(buffer, SocketFlags.None);
                        if (n > 0)
                        {
                            byte[] data = new byte[n];
                            Array.Copy(buffer, data, n);
                            ar.AddRange(data);
                        }
                    }
                    return (byte[])ar.ToArray(typeof(byte));

                }

            }
            catch (SocketException ex)
            {
                Close();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return null;
        }

    }
}
