

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;

using FTD2XX_NET;

namespace AnyI2cLib
{

    /// <summary>
    /// For use FT232 as i2c master
    /// </summary>
    class FT232HI2C
    {


        private FTDI mDevice = new FTDI();
        bool bCommandEchod = false;

	    FTDI.FT_STATUS ftStatus;					// Status defined in D2XX to indicate operation result

	    byte [] OutputBuffer= new byte[1024];			// Buffer to hold MPSSE commands and data to be sent to FT232H
	    byte [] InputBuffer = new byte [1024];				// Buffer to hold Data bytes read from FT232H
    	
	    uint dwClockDivisor = 0x00C8;		// 100khz
        //uint dwClockDivisor = 0x0032;		// 400khz
    	
	    uint  dwNumBytesToSend = 0; 		// Counter used to hold number of bytes to be sent
	    uint  dwNumBytesSent = 0;			// Holds number of bytes actually sent (returned by the read function)

	    uint  dwNumInputBuffer = 0;			// Number of bytes which we want to read
	    uint dwNumBytesRead = 0;			// Number of bytes actually read
	    uint ReadTimeoutCounter = 0;		// Used as a software timeout counter when the code checks the Queue Status


        const FTDI.FT_STATUS FT_OK = FTDI.FT_STATUS.FT_OK;


        /// <summary>
        /// Create ft232H device
        /// </summary>
        public FT232HI2C()
        {

        }

        public void Open(uint locationId)
        {
            // Open first device in our list by serial number
            if (!mDevice.LoadLibrarySuccess)
            {
                return; // fail to load library
            }
            if (mDevice.IsOpen)
            {
                mDevice.Close();
            }
            mDevice.OpenByLocation(locationId);

        }



        public void Close()
        {
            if(mDevice.IsOpen)
            {
                mDevice.Close();
            }
        }

        public bool IsOpen
        {
            get
            {
                return mDevice.IsOpen;
            }

        }

        private void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        /// <summary>
        /// initialize device
        /// </summary>
        /// <returns></returns>
        public bool Init()
        {
            FTDI.FT_STATUS ftStatus = mDevice.ResetDevice();
            ftStatus |= mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);// Get number of bytes in the input buffer
		    if ((ftStatus == FTDI.FT_STATUS.FT_OK) && (dwNumInputBuffer > 0))
		    {
			    mDevice.Read(InputBuffer, dwNumInputBuffer, ref dwNumBytesRead);  	
		    }
            ftStatus |= mDevice.InTransferSize(65536);			// Set USB request transfer sizes
            ftStatus |= mDevice.SetCharacters(0, false, 0, false);				// Disable event and error characters
            ftStatus |= mDevice.SetTimeouts(5000, 5000);					// Set the read and write timeouts to 5 seconds
            ftStatus |= mDevice.SetLatency(16);						// Keep the latency timer at default of 16ms
            ftStatus |= mDevice.SetBitMode(0x0, 0x00); 					// Reset the mode to whatever is set in EEPROM
            ftStatus |= mDevice.SetBitMode(0x0, 0x02);	 					// Enable MPSSE mode

            // Inform the user if any errors were encountered
            if (ftStatus != FT_OK)
            {
                return false;
            }

            Sleep(50);
            SynchroniseMPSSEbyAA();
            SynchroniseMPSSEbyAB();
            ConfigMPSSE_Setting();
            ConfigMPSSE_IO_Pins();

            return (ftStatus == FTDI.FT_STATUS.FT_OK);
        }

        /// <summary>
        ///  Synchronise the MPSSE by sending bad command AA to it
        /// </summary>
        /// <returns></returns>
        private bool SynchroniseMPSSEbyAA()
        {
            dwNumBytesToSend = 0;																// Used as an index to the buffer
            OutputBuffer[dwNumBytesToSend++] = 0xAA;											// Add an invalid command 0xAA
            FTDI.FT_STATUS ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		// Send off the invalid command

            // Check if the bytes were sent off OK
            if (dwNumBytesToSend != dwNumBytesSent)
            {
                return false;
            }            
            dwNumInputBuffer = 0;
            ReadTimeoutCounter = 0;

            ftStatus = mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);	// Get number of bytes in the input buffer

            while ((dwNumInputBuffer < 2) && (ftStatus == FTDI.FT_STATUS.FT_OK) && (ReadTimeoutCounter < 500))
            {
                // Sit in this loop until
                // (1) we receive the two bytes expected
                // or (2) a hardware error occurs causing the GetQueueStatus to return an error code
                // or (3) we have checked 500 times and the expected byte is not coming 
                ftStatus = mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);	// Get number of bytes in the input buffer
                ReadTimeoutCounter++;
                Sleep(1);													// short delay
            }

            // If the loop above exited due to the byte coming back (not an error code and not a timeout)
            // then read the bytes available and check for the error code followed by the invalid character
            if ((ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                ftStatus = mDevice.Read( InputBuffer, dwNumInputBuffer, ref dwNumBytesRead); // Now read the data

                // Check if we have two consecutive bytes in the buffer with value 0xFA and 0xAA
                bCommandEchod = false;
                for (int dwCount = 0; dwCount < dwNumBytesRead - 1; dwCount++)
                {
                    if ((InputBuffer[dwCount] == 0xFA) && (InputBuffer[dwCount + 1] == 0xAA))
                    {
                        bCommandEchod = true;
                        break;
                    }
                }
            }
            // If the device did not respond correctly, display error message and exit.

            if (bCommandEchod == false)
            {
                return false;
            }
            return true;
	
        }

        /// <summary>
        ///  Synchronise the MPSSE by sending bad command AA to it
        /// </summary>
        /// <returns></returns>
        private bool SynchroniseMPSSEbyAB()
        {
            dwNumBytesToSend = 0;																// Used as an index to the buffer
            OutputBuffer[dwNumBytesToSend++] = 0xAB;											// Add an invalid command 0xAA
            FTDI.FT_STATUS ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		// Send off the invalid command

            // Check if the bytes were sent off OK
            if (dwNumBytesToSend != dwNumBytesSent)
            {
                return false;
            }     
            dwNumInputBuffer = 0;
            ReadTimeoutCounter = 0;

            ftStatus = mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);	// Get number of bytes in the input buffer

            while ((dwNumInputBuffer < 2) && (ftStatus == FTDI.FT_STATUS.FT_OK) && (ReadTimeoutCounter < 500))
            {
                // Sit in this loop until
                // (1) we receive the two bytes expected
                // or (2) a hardware error occurs causing the GetQueueStatus to return an error code
                // or (3) we have checked 500 times and the expected byte is not coming 
                ftStatus = mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);	// Get number of bytes in the input buffer
                ReadTimeoutCounter++;
                Sleep(1);													// short delay
            }

            // If the loop above exited due to the byte coming back (not an error code and not a timeout)
            // then read the bytes available and check for the error code followed by the invalid character
            if ((ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                ftStatus = mDevice.Read(InputBuffer, dwNumInputBuffer, ref dwNumBytesRead); // Now read the data

                // Check if we have two consecutive bytes in the buffer with value 0xFA and 0xAB
                bCommandEchod = false;
                for (int dwCount = 0; dwCount < dwNumBytesRead - 1; dwCount++)
                {
                    if ((InputBuffer[dwCount] == 0xFA) && (InputBuffer[dwCount + 1] == 0xAB))
                    {
                        bCommandEchod = true;
                        break;
                    }
                }
            }
            // If the device did not respond correctly, display error message and exit.

            if (bCommandEchod == false)
            {
                return false;
            }
            return true;

        }



		// #########################################################################################
		// Configure the MPSSE settings
		// #########################################################################################
        private bool ConfigMPSSE_Setting()
        {

		    dwNumBytesToSend = 0;							// Clear index to zero
		    OutputBuffer[dwNumBytesToSend++] = 0x8A; 		// Disable clock divide-by-5 for 60Mhz master clock
		    OutputBuffer[dwNumBytesToSend++] = 0x97;		// Ensure adaptive clocking is off
		    OutputBuffer[dwNumBytesToSend++] = 0x8C; 		// Enable 3 phase data clocking, data valid on both clock edges for I2C

		    OutputBuffer[dwNumBytesToSend++] = 0x9E; 		// Enable the FT232H's drive-zero mode on the lines used for I2C ...
		    OutputBuffer[dwNumBytesToSend++] = 0x07;		// ... on the bits 0, 1 and 2 of the lower port (AD0, AD1, AD2)...
		    OutputBuffer[dwNumBytesToSend++] = 0x00;		// ...not required on the upper port AC 0-7

		    OutputBuffer[dwNumBytesToSend++] = 0x85;		// Ensure internal loopback is off

		    ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);	// Send off the commands

		    // Now configure the dividers to set the SCLK frequency which we will use
		    // The SCLK clock frequency can be worked out by the algorithm (when divide-by-5 is off)
		    // SCLK frequency  = 60MHz /((1 +  [(1 +0xValueH*256) OR 0xValueL])*2)
		    dwNumBytesToSend = 0;													// Clear index to zero
		    OutputBuffer[dwNumBytesToSend++] = 0x86; 								// Command to set clock divisor
		    OutputBuffer[dwNumBytesToSend++] = (byte)(dwClockDivisor & 0xFF);				// Set 0xValueL of clock divisor
		    OutputBuffer[dwNumBytesToSend++] = (byte)((dwClockDivisor >> 8) & 0xFF);		// Set 0xValueH of clock divisor
		    ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);	// Send off the commands

		    Sleep(20);	
            return true;
        }


		// #########################################################################################
		// Configure the I/O pins of the MPSSE
		// #########################################################################################
        private bool ConfigMPSSE_IO_Pins()
        {
            return true;
        }



        // #########################################################################################
        // Flush the buffer
        // #########################################################################################
        private void FlushBuffer()
        {

            SetI2CLinesIdle();								// Set idle line condition
            SetI2CStart();									// Set the start condition on the lines

            bool bSucceed = SendAddrAndCheckACK(0x00, false);	// Send the general call address 0x00 wr (I2C = 0x00)
            bSucceed = SendByteAndCheckACK(0x0E);			// Send the Flush Buffer command  

            SetI2CStop();									// Send the stop condition	

            Console.Write("Buffer flushed\n");
            Sleep(100);

        }

        public bool Write(params byte[] data)
        {
            bool bSucceed = false;
            SetI2CLinesIdle();							// Set idle line condition
            SetI2CStart();								// Send the start condition
            if (data != null)
            {
                ArrayList dataSent = new ArrayList();   
                for (int i = 0; i < data.Length; i++)
                {
                    if (i == 0)
                    {
                        bSucceed = SendAddrAndCheckACK((byte)(data[0] / 2), false);
                    }
                    else
                    {
                        bSucceed = SendByteAndCheckACK(data[i]);		// Send the DataAvailable command 0x0C 
                    }
                    System.Diagnostics.Debug.Print(bSucceed.ToString());
                    if (!bSucceed)
                    {
                        SetI2CStop();								// Send the stop condition	
                        return bSucceed;
                    }
                    else
                    {
                        dataSent.Add(data[i]);
                    }

                }
            }
            SetI2CStop();								// Send the stop condition	
            return bSucceed;
        }


        public bool SendI2CCommand(byte address, params byte[] data)
        {
            bool bSucceed = false;
            SetI2CLinesIdle();							// Set idle line condition
            SetI2CStart();								// Send the start condition
            bSucceed = SendAddrAndCheckACK(address, false);// Send the general call address 0x00 wr (I2C = 0x00)
            System.Diagnostics.Debug.Print(bSucceed.ToString());
            if (!bSucceed)
            {
                return bSucceed;
            }
            if (data != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    bSucceed = SendByteAndCheckACK(data[i]);		// Send the DataAvailable command 0x0C 
                    System.Diagnostics.Debug.Print(bSucceed.ToString());
                    if(!bSucceed )
                    {
                        return bSucceed;
                    }
                }
            }
            SetI2CStop();								// Send the stop condition	
            return bSucceed;
        }

        public byte[] ReadI2cData(byte address, byte readCount)
        {
            SetI2CLinesIdle();							// Set idle line condition
            SetI2CStart();								// Send the start condition
            bool bSucceed = SendAddrAndCheckACK(address, true);// Send the general call address 0x00 wr (I2C = 0x00)
            //if (DataSent != null)
            //{
            //    DataSentEventArgs e = new DataSentEventArgs(new byte[] { (byte)(address * 2 + 1) }); // data for read
            //    DataSent(this, e);
            //}
            System.Diagnostics.Debug.Print(bSucceed.ToString());
            if (!bSucceed)
            {
                SetI2CStop();
                throw new Exception("I2C Read Data Error");
            }
            dwNumBytesToSend = 0;			//Clear output buffer
            for (int i = 0; i < readCount - 1; i++)
            {

                // Read the first byte of data over I2C and ACK it

                //Clock one byte in
                OutputBuffer[dwNumBytesToSend++] = 0x20; 		// Command to clock data byte in MSB first on clock rising edge
                OutputBuffer[dwNumBytesToSend++] = 0x00;
                OutputBuffer[dwNumBytesToSend++] = 0x00;		// Data length of 0x0000 means 1 byte data to clock in

                // Clock out one bit...send ack bit as '0'
                OutputBuffer[dwNumBytesToSend++] = 0x13;		// Command to clock data bit out MSB first on clock falling edge
                OutputBuffer[dwNumBytesToSend++] = 0x00;		// Length of 0x00 means 1 bit
                OutputBuffer[dwNumBytesToSend++] = 0x00;		// Data value to clock out is in bit 7 of this value

                // Put I2C line back to idle (during transfer) state... Clock line driven low, Data line high (open drain)
                OutputBuffer[dwNumBytesToSend++] = 0x80;		// Command to set lower 8 bits of port (ADbus 0-7 on the FT232H)
                OutputBuffer[dwNumBytesToSend++] = 0xFE;		// Set the value of the pins (only affects those set as output)
                OutputBuffer[dwNumBytesToSend++] = 0xFB;		// Set the directions - all pins as output except Bit2(data_in)
            }

            OutputBuffer[dwNumBytesToSend++] = 0x20; 		// Command to clock data byte in MSB first on clock rising edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// Data length of 0x0000 means 1 byte data to clock in

            // Clock out one bit...send ack bit as '0'
            OutputBuffer[dwNumBytesToSend++] = 0x13;		// Command to clock data bit out MSB first on clock falling edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// Length of 0x00 means 1 bit
            OutputBuffer[dwNumBytesToSend++] = 0xff;		// Data value to clock out is in bit 7 of this value

            // Put I2C line back to idle (during transfer) state... Clock line driven low, Data line high (open drain)
            OutputBuffer[dwNumBytesToSend++] = 0x80;		// Command to set lower 8 bits of port (ADbus 0-7 on the FT232H)
            OutputBuffer[dwNumBytesToSend++] = 0xFE;		// Set the value of the pins (only affects those set as output)
            OutputBuffer[dwNumBytesToSend++] = 0xFB;		// Set the directions - all pins as output except Bit2(data_in)
            
            // This command then tells the MPSSE to send any results gathered back immediately
            OutputBuffer[dwNumBytesToSend++] = 0x87;		// Send answer back immediate command

            ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands

            // ===============================================================
            // Now wait for the 3 bytes which we read to come back to the host PC
            // ===============================================================

            dwNumInputBuffer = 0;
            ReadTimeoutCounter = 0;

            ftStatus |= mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);            // Get number of bytes in the input buffer

            while ((dwNumInputBuffer < readCount) && (ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                // Sit in this loop until
                // (1) we receive the 3 bytes expected
                // or (2) a hardware error occurs causing the GetQueueStatus to return an error code
                // or (3) we have checked 500 times and the expected byte is not coming 
                ftStatus |= mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);            // Get number of bytes in the input buffer
                ReadTimeoutCounter++;
                Sleep(1);													// short delay
            }

            // If the loop above exited due to the bytes coming back (not an error code and not a timeout)
            // then read the bytes available and return True to indicate success
            if ((ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                byte [] ByteDataRead = new byte[readCount];
                ftStatus = mDevice.Read(ByteDataRead , dwNumInputBuffer, ref dwNumBytesRead); // Now read the data
                Sleep(10);
                SetI2CStop();			
                return ByteDataRead;									// Indicate success
            }
            else
            {
                Sleep(10);
                SetI2CStop();
                throw new Exception("I2C Read Data Error");
            }
        }



        // ##############################################################################################################
        // Function to write 1 byte, and check if it returns an ACK or NACK by clocking in one bit
        //     We clock one byte out to the I2C Slave
        //     We then clock in one bit from the Slave which is the ACK/NAK bit
        //	   Put lines back to the idle state (idle between start and stop is clock low, data high (open-drain)
        // Returns TRUE if the write was ACKed
        // ##############################################################################################################

        bool SendByteAndCheckACK(byte dwDataSend)
        {
            dwNumBytesToSend = 0;			// Clear output buffer
            FTDI.FT_STATUS ftStatus = FT_OK;

            OutputBuffer[dwNumBytesToSend++] = 0x11; 		// command to clock data bytes out MSB first on clock falling edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// 
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// Data length of 0x0000 means 1 byte data to clock out
            OutputBuffer[dwNumBytesToSend++] = dwDataSend;	// Actual byte to clock out

            // Put I2C line back to idle (during transfer) state... Clock line driven low, Data line high (open drain)
            OutputBuffer[dwNumBytesToSend++] = 0x80;		// Command to set lower 8 bits of port (ADbus 0-7 on the FT232H)
            OutputBuffer[dwNumBytesToSend++] = 0xFE;		// Set the value of the pins (only affects those set as output)
            OutputBuffer[dwNumBytesToSend++] = 0xFB;		// Set the directions - all pins as output except Bit2(data_in)

            // AD0 (SCL) is output driven low
            // AD1 (DATA OUT) is output high (open drain)
            // AD2 (DATA IN) is input (therefore the output value specified is ignored)
            // AD3 to AD7 are inputs driven high (not used in this application)

            OutputBuffer[dwNumBytesToSend++] = 0x22; 	// Command to clock in bits MSB first on clock rising edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;	// Length of 0x00 means to scan in 1 bit

            // This command then tells the MPSSE to send any results gathered back immediately
            OutputBuffer[dwNumBytesToSend++] = 0x87;	//Send answer back immediate command

            ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands
            Sleep(1);
            // ===============================================================
            // Now wait for the byte which we read to come back to the host PC
            // ===============================================================

            dwNumInputBuffer = 0;
            ReadTimeoutCounter = 0;

            ftStatus |= mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);            // Get number of bytes in the input buffer

            while ((dwNumInputBuffer < 1) && (ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                // Sit in this loop until
                // (1) we receive the one byte expected
                // or (2) a hardware error occurs causing the GetQueueStatus to return an error code
                // or (3) we have checked 500 times and the expected byte is not coming 
                ftStatus |= mDevice.GetRxBytesAvailable(ref dwNumInputBuffer);            // Get number of bytes in the input buffer
                ReadTimeoutCounter++;
                Sleep(10);													// short delay
            }

            // If the loop above exited due to the byte coming back (not an error code and not a timeout)

            if ((ftStatus == FT_OK) && (ReadTimeoutCounter < 500))
            {
                ftStatus = mDevice.Read(InputBuffer, dwNumInputBuffer, ref dwNumBytesRead); // Now read the data

                if (((InputBuffer[0] & 0x01) == 0x00))		//Check ACK bit 0 on data byte read out
                {
                    return true;							// Return True if the ACK was received
                }
                else
                {
                    //printf("Failed to get ACK from I2C Slave \n");
                    return false; //Error, can't get the ACK bit 
                }
            }
            else
            {
                return false;									// Failed to get any data back or got an error code back
            }

        }

        // ##############################################################################################################
        // Function to write 1 byte, and check if it returns an ACK or NACK by clocking in one bit
        // This function combines the data and the Read/Write bit to make a single 8-bit value
        //     We clock one byte out to the I2C Slave
        //     We then clock in one bit from the Slave which is the ACK/NAK bit
        //	   Put lines back to the idle state (idle between start and stop is clock low, data high (open-drain)
        // Returns TRUE if the write was ACKed by the slave
        // ##############################################################################################################

        bool SendAddrAndCheckACK(byte dwDataSend, bool Read)
        {
            dwNumBytesToSend = 0;			// Clear output buffer
            FTDI.FT_STATUS ftStatus = FT_OK;

            // Combine the Read/Write bit and the actual data to make a single byte with 7 data bits and the R/W in the LSB
            if (Read == true)
            {
                dwDataSend = (byte)((dwDataSend << 1) | 0x01);
            }
            else
            {
                dwDataSend = (byte)((dwDataSend << 1) & 0xFE);
            }

            OutputBuffer[dwNumBytesToSend++] = 0x11; 		// command to clock data bytes out MSB first on clock falling edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// 
            OutputBuffer[dwNumBytesToSend++] = 0x00;		// Data length of 0x0000 means 1 byte data to clock out
            OutputBuffer[dwNumBytesToSend++] = dwDataSend;	// Actual byte to clock out

            // Put I2C line back to idle (during transfer) state... Clock line driven low, Data line high (open drain)
            OutputBuffer[dwNumBytesToSend++] = 0x80;		// Command to set lower 8 bits of port (ADbus 0-7 on the FT232H)
            OutputBuffer[dwNumBytesToSend++] = 0xFE;		// Set the value of the pins (only affects those set as output)
            OutputBuffer[dwNumBytesToSend++] = 0xFB;		// Set the directions - all pins as output except Bit2(data_in)

            // AD0 (SCL) is output driven low
            // AD1 (DATA OUT) is output high (open drain)
            // AD2 (DATA IN) is input (therefore the output value specified is ignored)
            // AD3 to AD7 are inputs driven high (not used in this application)

            OutputBuffer[dwNumBytesToSend++] = 0x22; 	// Command to clock in bits MSB first on clock rising edge
            OutputBuffer[dwNumBytesToSend++] = 0x00;	// Length of 0x00 means to scan in 1 bit

            // This command then tells the MPSSE to send any results gathered back immediately
            OutputBuffer[dwNumBytesToSend++] = 0x87;	//Send answer back immediate command

            ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands
            Sleep(10);
            //Check if ACK bit received by reading the byte sent back from the FT232H containing the ACK bit
            ftStatus = mDevice.Read(InputBuffer, 1, ref dwNumBytesRead);  	//Read one byte from device receive buffer

            if ((ftStatus != FT_OK) || (dwNumBytesRead == 0))
            {
                //printf("Failed to get ACK from I2C Slave \n");
                return false; //Error, can't get the ACK bit
            }
            else
            {
                if (((InputBuffer[0] & 0x01) != 0x00))		//Check ACK bit 0 on data byte read out
                {
                    //printf("Failed to get ACK from I2C Slave \n");
                    return false; //Error, can't get the ACK bit 
                }

            }
            return true;		// Return True if the ACK was received
        }


        /// <summary>
        /// Scan i2c devices connected
        /// return 7bit addresses 
        /// </summary>
        /// <returns></returns>
        public byte[] SacnDevices()
        {
            ArrayList devices = new ArrayList();

            for (byte i = 1; i < 128; i++)
            {
                SetI2CLinesIdle();							// Set idle line condition
                SetI2CStart();								// Send the start condition
                if (SendAddrAndCheckACK(i, false))
                {
                    devices.Add(i);
                }
                SetI2CStop();								// Send the stop condition	
            }
            return (byte[])devices.ToArray(typeof(byte));
        }



        // ##############################################################################################################
        // Function to set all lines to idle states
        // For I2C lines, it releases the I2C clock and data lines to be pulled high externally
        // For the remainder of port AD, it sets AD3/4/5/6/7 as inputs as they are unused in this application
        // For the LED control, it sets AC6 as an output with initial state high (LED off)
        // For the remainder of port AC, it sets AC0/1/2/3/4/5/7 as inputs as they are unused in this application
        // ##############################################################################################################

        private  void SetI2CLinesIdle()
        {
	        dwNumBytesToSend = 0;			//Clear output buffer

	        // Set the idle states for the AD lines
	        OutputBuffer[dwNumBytesToSend++] = 0x80;	// Command to set directions of ADbus and data values for pins set as o/p
	        OutputBuffer[dwNumBytesToSend++] = 0xFF;    // Set all 8 lines to high level (only affects pins which are output)
	        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in

	        // IDLE line states are ...
	        // AD0 (SCL) is output high (open drain, pulled up externally)
	        // AD1 (DATA OUT) is output high (open drain, pulled up externally)
	        // AD2 (DATA IN) is input (therefore the output value specified is ignored)
	        // AD3 to AD7 are inputs (not used in this application)

	        // Set the idle states for the AC lines
	        OutputBuffer[dwNumBytesToSend++] = 0x82;	// Command to set directions of ACbus and data values for pins set as o/p
	        OutputBuffer[dwNumBytesToSend++] = 0xFF;	// Set all 8 lines to high level (only affects pins which are output)
	        OutputBuffer[dwNumBytesToSend++] = 0x40;	// Only bit 6 is output

	        // IDLE line states are ...
	        // AC6 (LED) is output driving high
	        // AC0/1/2/3/4/5/7 are inputs (not used in this application)

	        ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands
        }

        // ##############################################################################################################
        // Function to set the I2C Start state on the I2C clock and data lines
        // It pulls the data line low and then pulls the clock line low to produce the start condition
        // It also sends a GPIO command to set bit 6 of ACbus low to turn on the LED. This acts as an activity indicator
        // Turns on (low) during the I2C Start and off (high) during the I2C stop condition, giving a short blink.  
        // ##############################################################################################################
        void SetI2CStart()
        {
	        dwNumBytesToSend = 0;			//Clear output buffer
	        uint dwCount;
        	
	        // Pull Data line low, leaving clock high (open-drain)
	        for(dwCount=0; dwCount < 4; dwCount++)	// Repeat commands to ensure the minimum period of the start hold time is achieved
	        {
		        OutputBuffer[dwNumBytesToSend++] = 0x80;	// Command to set directions of ADbus and data values for pins set as o/p
		        OutputBuffer[dwNumBytesToSend++] = 0xFD;	// Bring data out low (bit 1)
		        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in
	        }
        	
	        // Pull Clock line low now, making both clcok and data low
	        for(dwCount=0; dwCount < 4; dwCount++)	// Repeat commands to ensure the minimum period of the start setup time is achieved
	        {
		        OutputBuffer[dwNumBytesToSend++] = 0x80; 	// Command to set directions of ADbus and data values for pins set as o/p
		        OutputBuffer[dwNumBytesToSend++] = 0xFC; 	// Bring clock line low too to make clock and data low
		        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in
	        }

	        // Turn the LED on by setting port AC6 low.
	        OutputBuffer[dwNumBytesToSend++] = 0x82;	// Command to set directions of upper 8 pins and force value on bits set as output
	        OutputBuffer[dwNumBytesToSend++] = 0xBF;	// Bit 6 is going low 
	        OutputBuffer[dwNumBytesToSend++] = 0x40;	// Only bit 6 is output

	        ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands
        }



        // ##############################################################################################################
        // Function to set the I2C Stop state on the I2C clock and data lines
        // It takes the clock line high whilst keeping data low, and then takes both lines high
        // It also sends a GPIO command to set bit 6 of ACbus high to turn off the LED. This acts as an activity indicator
        // Turns on (low) during the I2C Start and off (high) during the I2C stop condition, giving a short blink.  
        // ##############################################################################################################

        void SetI2CStop()
        {
	        dwNumBytesToSend = 0;			//Clear output buffer
	        uint dwCount;

	        // Initial condition for the I2C Stop - Pull data low (Clock will already be low and is kept low)
	        for(dwCount=0; dwCount<4; dwCount++)		// Repeat commands to ensure the minimum period of the stop setup time is achieved
	        {
		        OutputBuffer[dwNumBytesToSend++] = 0x80;	// Command to set directions of ADbus and data values for pins set as o/p
		        OutputBuffer[dwNumBytesToSend++] = 0xFC;	// put data and clock low
		        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in
	        }

	        // Clock now goes high (open drain)
	        for(dwCount=0; dwCount<4; dwCount++)		// Repeat commands to ensure the minimum period of the stop setup time is achieved
	        {
		        OutputBuffer[dwNumBytesToSend++] = 0x80;	// Command to set directions of ADbus and data values for pins set as o/p
		        OutputBuffer[dwNumBytesToSend++] = 0xFD;	// put data low, clock remains high (open drain, pulled up externally)
		        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in
	        }

	        // Data now goes high too (both clock and data now high / open drain)
	        for(dwCount=0; dwCount<4; dwCount++)	// Repeat commands to ensure the minimum period of the stop hold time is achieved
	        {
		        OutputBuffer[dwNumBytesToSend++] = 0x80;	// Command to set directions of ADbus and data values for pins set as o/p
		        OutputBuffer[dwNumBytesToSend++] = 0xFF;	// both clock and data now high (open drain, pulled up externally)
		        OutputBuffer[dwNumBytesToSend++] = 0xFB;	// Set all pins as output except bit 2 which is the data_in
	        }
        		
	        // Turn the LED off by setting port AC6 high.
		        OutputBuffer[dwNumBytesToSend++] = 0x82;	// Command to set directions of upper 8 pins and force value on bits set as output
		        OutputBuffer[dwNumBytesToSend++] = 0xFF;	// All lines high (including bit 6 which drives the LED) 
		        OutputBuffer[dwNumBytesToSend++] = 0x40;	// Only bit 6 is output

	        ftStatus = mDevice.Write(OutputBuffer, dwNumBytesToSend, ref dwNumBytesSent);		//Send off the commands
        }








    }
}
