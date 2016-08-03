Imports AnyI2C

Public Class frmSSD1306
    Dim CommObj As CommInterface = Nothing
    Public UsingAPI As Boolean = True ' flag for if using API mode



    Public Sub Attach(com As CommInterface)
        CommObj = com
    End Sub

    Private Sub frmSSD1306_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        SetupOled()
    End Sub

    'only 20 char can be show each line
    Private Sub DrawLine(ByVal str As String)
        If str.Length > 20 Then
            str = str.Substring(0, 20)
        End If
        For i = 0 To str.Length - 1
            Dim asc As Integer = AscW(str(i)) * 5
            WriteI2cData(ascFont(asc), ascFont(asc + 1), ascFont(asc + 2), ascFont(asc + 3), ascFont(asc + 4), 0)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim data(15) As Byte
        For i = 0 To 15
            data(i) = 0
        Next
        ' refer the document for more details
        For i = 0 To 7
            Write_IIC_Command(&HB0 + i) 'page0-page1
            Write_IIC_Command(&H0)          'low column start address
            Write_IIC_Command(&H10) 'high column start address
            For j = 1 To 16
                WriteI2cData(0, 0, 0, 0, 0, 0, 0, 0) ' update 8 bytes one time to improve the speed
            Next
        Next
    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        Dim lnCount As Integer = 8
        If TextBox1.Lines.Length < 8 Then
            lnCount = TextBox1.Lines.Length
        End If
        For i = 0 To lnCount - 1
            Write_IIC_Command(&HB0 + i) 'page0-page1
            Write_IIC_Command(&H0)          'low column start address
            Write_IIC_Command(&H10) 'high column start address
            DrawLine(TextBox1.Lines(i))
        Next

    End Sub

    Private Sub btnPic_Click(sender As Object, e As EventArgs) Handles btnPic.Click

    End Sub


    Private Sub SetupOled()
        Write_IIC_Command(&HAE)     'display off
        Write_IIC_Command(&H20)      'Set Memory Addressing Mode	
        Write_IIC_Command(&H10)      '00,Horizontal Addressing Mode 01,Vertical Addressing Mode 10,Page Addressing Mode (RESET) 11,Invalid
        Write_IIC_Command(&HB0)      'Set Page Start Address for Page Addressing Mode,0-7
        Write_IIC_Command(&HC8)      'Set COM Output Scan Direction
        Write_IIC_Command(&H0)  '---set low column address
        Write_IIC_Command(&H10)  '---set high column address
        Write_IIC_Command(&H40)  '--set start line address
        Write_IIC_Command(&H81)  '--set contrast control register
        Write_IIC_Command(&H7F)
        Write_IIC_Command(&HA1)  '--set segment re-map 0 to 127
        Write_IIC_Command(&HA6)  '--set normal display
        Write_IIC_Command(&HA8)  '--set multiplex ratio(1 to 64)
        Write_IIC_Command(&H3F)  '
        Write_IIC_Command(&HA4)  '&ha4,Output follows RAM content &ha5,Output ignores RAM content
        Write_IIC_Command(&HD3)  '-set display offset
        Write_IIC_Command(&H0)  '-not offset
        Write_IIC_Command(&HD5)  '--set display clock divide ratio/oscillator frequency
        Write_IIC_Command(&HF0)  '--set divide ratio
        Write_IIC_Command(&HD9)  '--set pre-charge period
        Write_IIC_Command(&H22)   '
        Write_IIC_Command(&HDA)  '--set com pins hardware configuration
        Write_IIC_Command(&H12)
        Write_IIC_Command(&HDB)  '--set vcomh
        Write_IIC_Command(&H20)  '&h20,0.77xVcc
        Write_IIC_Command(&H8D)  '--set DC-DC enable
        Write_IIC_Command(&H14)  '
        Write_IIC_Command(&HAF)  '--turn on oled panel 
    End Sub



    'write a byte data to oled 
    Private Sub WriteI2cData(ByVal ParamArray data As Byte())
        Dim d2(data.Length + 1) As Byte
        d2(0) = Address.Value * 2
        d2(1) = 64  'data reg
        Array.Copy(data, 0, d2, 2, data.Length)
        CommObj.Send(d2, 0)
        'I2C_TXRX(Port.Value, 0, Address.Value * 2, d2)
    End Sub

    'write a command to oled
    Private Sub Write_IIC_Command(ByVal cmd As Byte)
        CommObj.Send(New Byte() {Address.Value * 2, 0, cmd}, 0)
    End Sub

    Public Function I2C_TXRX(I2C_Port As Integer, RXBytes As Integer, Address As Integer, ByVal ParamArray TXDAT As Byte()) As Byte()
        _ERROR.Visible = False

        Dim PortSetting As Integer = Port.Value + 50
        Dim AddressSetting As Integer = Address
        Dim TransmitCount As Integer = TXDAT.Length
        Dim ReceiveCount As Integer = RXBytes

        '     If ReceiveCount > 0 Then
        Dim aI(TransmitCount + 4) As Byte

        aI(0) = 188                  'Byte 0
        aI(1) = PortSetting          'Byte 1
        aI(2) = TransmitCount + 1    'Byte 2
        aI(3) = AddressSetting       'Byte 3
        aI(TransmitCount + 4) = ReceiveCount    'Last Byte


        For i1 As Integer = 0 To TransmitCount - 1
            aI(i1 + 4) = TXDAT(i1) 'Int(txArray(i1).Text)
        Next

        CommObj.Send(aI, 0)
        'NCDLib.WriteBytesAPI(NCDComponent1, UsingAPI, aI)
        AddDataToLog(aI)

        Debug.Print("Command:")
        For Each a In aI
            Debug.Print(a)
        Next
        Debug.Print("--------------END Command")

        _ERROR.Visible = False
        ''Dim rData As Byte() = NCDLib.ReadBytesAPI(NCDComponent1, UsingAPI, RXBytes.Value) 'Receive 22 Bytes from Buffer
        'Dim rData As Byte() = NCDLib.ReadUnknownNumberOfBytesAPI(NCDComponent1, UsingAPI)
        'If (Not (rData Is Nothing)) Then

        '    If rData(0) = 4 Then    'If we received 4 bytes of data

        '        If rData(1) = 188 Then
        '            If rData(4) = 67 Then

        '                Debug.Print("I2C Error Package:")

        '                'Error Code = rData(3)
        '                _ERROR.Visible = True

        '                If rData(2) = 90 Then
        '                    If rData(3) = (255 - 90) Then
        '                        _ERROR.Text = "ERROR: I2C Device Did Not Acknowledge.  Make Sure the Correct I2C Port and Address are Selected.  Make Sure SDA and SCL lines are not reversed."
        '                    End If
        '                End If
        '                If rData(2) = 91 Then
        '                    If rData(3) = (255 - 91) Then
        '                        _ERROR.Text = "ERROR: Device took Tool Long to Respond."
        '                    End If
        '                End If
        '                If rData(2) = 92 Then
        '                    If rData(3) = (255 - 92) Then
        '                        _ERROR.Text = "ERROR: Count Not Set the Address of the Device."
        '                    End If
        '                End If

        '                '  Exit Sub
        '            End If
        '        End If
        '    End If

        '    Return rData
        'Else
        '    Debug.Print("NO DATA RECEIVED")
        'End If


    End Function


    ' Add text to log window
    Private Sub AddTextLineToLog(ByVal str As String)
        'logWin.AddTextLineToLog(str)
    End Sub

    ' Add data to log window
    Private Sub AddDataToLog(ByVal data() As Byte)
        'logWin.AddDataToLog(data)
    End Sub


    Dim ascFont() As Byte = New Byte() {
        &H0, &H0, &H0, &H0, &H0,
    &H3E, &H5B, &H4F, &H5B, &H3E,
    &H3E, &H6B, &H4F, &H6B, &H3E,
    &H1C, &H3E, &H7C, &H3E, &H1C,
    &H18, &H3C, &H7E, &H3C, &H18,
    &H1C, &H57, &H7D, &H57, &H1C,
    &H1C, &H5E, &H7F, &H5E, &H1C,
    &H0, &H18, &H3C, &H18, &H0,
    &HFF, &HE7, &HC3, &HE7, &HFF,
    &H0, &H18, &H24, &H18, &H0,
    &HFF, &HE7, &HDB, &HE7, &HFF,
    &H30, &H48, &H3A, &H6, &HE,
    &H26, &H29, &H79, &H29, &H26,
    &H40, &H7F, &H5, &H5, &H7,
    &H40, &H7F, &H5, &H25, &H3F,
    &H5A, &H3C, &HE7, &H3C, &H5A,
    &H7F, &H3E, &H1C, &H1C, &H8,
    &H8, &H1C, &H1C, &H3E, &H7F,
    &H14, &H22, &H7F, &H22, &H14,
    &H5F, &H5F, &H0, &H5F, &H5F,
    &H6, &H9, &H7F, &H1, &H7F,
    &H0, &H66, &H89, &H95, &H6A,
    &H60, &H60, &H60, &H60, &H60,
    &H94, &HA2, &HFF, &HA2, &H94,
    &H8, &H4, &H7E, &H4, &H8,
    &H10, &H20, &H7E, &H20, &H10,
    &H8, &H8, &H2A, &H1C, &H8,
    &H8, &H1C, &H2A, &H8, &H8,
    &H1E, &H10, &H10, &H10, &H10,
    &HC, &H1E, &HC, &H1E, &HC,
    &H30, &H38, &H3E, &H38, &H30,
    &H6, &HE, &H3E, &HE, &H6,
    &H0, &H0, &H0, &H0, &H0,
    &H0, &H0, &H5F, &H0, &H0,
    &H0, &H7, &H0, &H7, &H0,
    &H14, &H7F, &H14, &H7F, &H14,
    &H24, &H2A, &H7F, &H2A, &H12,
    &H23, &H13, &H8, &H64, &H62,
    &H36, &H49, &H56, &H20, &H50,
    &H0, &H8, &H7, &H3, &H0,
    &H0, &H1C, &H22, &H41, &H0,
    &H0, &H41, &H22, &H1C, &H0,
    &H2A, &H1C, &H7F, &H1C, &H2A,
    &H8, &H8, &H3E, &H8, &H8,
    &H0, &H80, &H70, &H30, &H0,
    &H8, &H8, &H8, &H8, &H8,
    &H0, &H0, &H60, &H60, &H0,
    &H20, &H10, &H8, &H4, &H2,
    &H3E, &H51, &H49, &H45, &H3E,
    &H0, &H42, &H7F, &H40, &H0,
    &H72, &H49, &H49, &H49, &H46,
    &H21, &H41, &H49, &H4D, &H33,
    &H18, &H14, &H12, &H7F, &H10,
    &H27, &H45, &H45, &H45, &H39,
    &H3C, &H4A, &H49, &H49, &H31,
    &H41, &H21, &H11, &H9, &H7,
    &H36, &H49, &H49, &H49, &H36,
    &H46, &H49, &H49, &H29, &H1E,
    &H0, &H0, &H14, &H0, &H0,
    &H0, &H40, &H34, &H0, &H0,
    &H0, &H8, &H14, &H22, &H41,
    &H14, &H14, &H14, &H14, &H14,
    &H0, &H41, &H22, &H14, &H8,
    &H2, &H1, &H59, &H9, &H6,
    &H3E, &H41, &H5D, &H59, &H4E,
    &H7C, &H12, &H11, &H12, &H7C,
    &H7F, &H49, &H49, &H49, &H36,
    &H3E, &H41, &H41, &H41, &H22,
    &H7F, &H41, &H41, &H41, &H3E,
    &H7F, &H49, &H49, &H49, &H41,
    &H7F, &H9, &H9, &H9, &H1,
    &H3E, &H41, &H41, &H51, &H73,
    &H7F, &H8, &H8, &H8, &H7F,
    &H0, &H41, &H7F, &H41, &H0,
    &H20, &H40, &H41, &H3F, &H1,
    &H7F, &H8, &H14, &H22, &H41,
    &H7F, &H40, &H40, &H40, &H40,
    &H7F, &H2, &H1C, &H2, &H7F,
    &H7F, &H4, &H8, &H10, &H7F,
    &H3E, &H41, &H41, &H41, &H3E,
    &H7F, &H9, &H9, &H9, &H6,
    &H3E, &H41, &H51, &H21, &H5E,
    &H7F, &H9, &H19, &H29, &H46,
    &H26, &H49, &H49, &H49, &H32,
    &H3, &H1, &H7F, &H1, &H3,
    &H3F, &H40, &H40, &H40, &H3F,
    &H1F, &H20, &H40, &H20, &H1F,
    &H3F, &H40, &H38, &H40, &H3F,
    &H63, &H14, &H8, &H14, &H63,
    &H3, &H4, &H78, &H4, &H3,
    &H61, &H59, &H49, &H4D, &H43,
    &H0, &H7F, &H41, &H41, &H41,
    &H2, &H4, &H8, &H10, &H20,
    &H0, &H41, &H41, &H41, &H7F,
    &H4, &H2, &H1, &H2, &H4,
    &H40, &H40, &H40, &H40, &H40,
    &H0, &H3, &H7, &H8, &H0,
    &H20, &H54, &H54, &H78, &H40,
    &H7F, &H28, &H44, &H44, &H38,
    &H38, &H44, &H44, &H44, &H28,
    &H38, &H44, &H44, &H28, &H7F,
    &H38, &H54, &H54, &H54, &H18,
    &H0, &H8, &H7E, &H9, &H2,
    &H18, &HA4, &HA4, &H9C, &H78,
    &H7F, &H8, &H4, &H4, &H78,
    &H0, &H44, &H7D, &H40, &H0,
    &H20, &H40, &H40, &H3D, &H0,
    &H7F, &H10, &H28, &H44, &H0,
    &H0, &H41, &H7F, &H40, &H0,
    &H7C, &H4, &H78, &H4, &H78,
    &H7C, &H8, &H4, &H4, &H78,
    &H38, &H44, &H44, &H44, &H38,
    &HFC, &H18, &H24, &H24, &H18,
    &H18, &H24, &H24, &H18, &HFC,
    &H7C, &H8, &H4, &H4, &H8,
    &H48, &H54, &H54, &H54, &H24,
    &H4, &H4, &H3F, &H44, &H24,
    &H3C, &H40, &H40, &H20, &H7C,
    &H1C, &H20, &H40, &H20, &H1C,
    &H3C, &H40, &H30, &H40, &H3C,
    &H44, &H28, &H10, &H28, &H44,
    &H4C, &H90, &H90, &H90, &H7C,
    &H44, &H64, &H54, &H4C, &H44,
    &H0, &H8, &H36, &H41, &H0,
    &H0, &H0, &H77, &H0, &H0,
    &H0, &H41, &H36, &H8, &H0,
    &H2, &H1, &H2, &H4, &H2,
    &H3C, &H26, &H23, &H26, &H3C,
    &H1E, &HA1, &HA1, &H61, &H12,
    &H3A, &H40, &H40, &H20, &H7A,
    &H38, &H54, &H54, &H55, &H59,
    &H21, &H55, &H55, &H79, &H41,
    &H21, &H54, &H54, &H78, &H41,
    &H21, &H55, &H54, &H78, &H40,
    &H20, &H54, &H55, &H79, &H40,
    &HC, &H1E, &H52, &H72, &H12,
    &H39, &H55, &H55, &H55, &H59,
    &H39, &H54, &H54, &H54, &H59,
    &H39, &H55, &H54, &H54, &H58,
    &H0, &H0, &H45, &H7C, &H41,
    &H0, &H2, &H45, &H7D, &H42,
    &H0, &H1, &H45, &H7C, &H40,
    &HF0, &H29, &H24, &H29, &HF0,
    &HF0, &H28, &H25, &H28, &HF0,
    &H7C, &H54, &H55, &H45, &H0,
    &H20, &H54, &H54, &H7C, &H54,
    &H7C, &HA, &H9, &H7F, &H49,
    &H32, &H49, &H49, &H49, &H32,
    &H32, &H48, &H48, &H48, &H32,
    &H32, &H4A, &H48, &H48, &H30,
    &H3A, &H41, &H41, &H21, &H7A,
    &H3A, &H42, &H40, &H20, &H78,
    &H0, &H9D, &HA0, &HA0, &H7D,
    &H39, &H44, &H44, &H44, &H39,
    &H3D, &H40, &H40, &H40, &H3D,
    &H3C, &H24, &HFF, &H24, &H24,
    &H48, &H7E, &H49, &H43, &H66,
    &H2B, &H2F, &HFC, &H2F, &H2B,
    &HFF, &H9, &H29, &HF6, &H20,
    &HC0, &H88, &H7E, &H9, &H3,
    &H20, &H54, &H54, &H79, &H41,
    &H0, &H0, &H44, &H7D, &H41,
    &H30, &H48, &H48, &H4A, &H32,
    &H38, &H40, &H40, &H22, &H7A,
    &H0, &H7A, &HA, &HA, &H72,
    &H7D, &HD, &H19, &H31, &H7D,
    &H26, &H29, &H29, &H2F, &H28,
    &H26, &H29, &H29, &H29, &H26,
    &H30, &H48, &H4D, &H40, &H20,
    &H38, &H8, &H8, &H8, &H8,
    &H8, &H8, &H8, &H8, &H38,
    &H2F, &H10, &HC8, &HAC, &HBA,
    &H2F, &H10, &H28, &H34, &HFA,
    &H0, &H0, &H7B, &H0, &H0,
    &H8, &H14, &H2A, &H14, &H22,
    &H22, &H14, &H2A, &H14, &H8,
    &HAA, &H0, &H55, &H0, &HAA,
    &HAA, &H55, &HAA, &H55, &HAA,
    &H0, &H0, &H0, &HFF, &H0,
    &H10, &H10, &H10, &HFF, &H0,
    &H14, &H14, &H14, &HFF, &H0,
    &H10, &H10, &HFF, &H0, &HFF,
    &H10, &H10, &HF0, &H10, &HF0,
    &H14, &H14, &H14, &HFC, &H0,
    &H14, &H14, &HF7, &H0, &HFF,
    &H0, &H0, &HFF, &H0, &HFF,
    &H14, &H14, &HF4, &H4, &HFC,
    &H14, &H14, &H17, &H10, &H1F,
    &H10, &H10, &H1F, &H10, &H1F,
    &H14, &H14, &H14, &H1F, &H0,
    &H10, &H10, &H10, &HF0, &H0,
    &H0, &H0, &H0, &H1F, &H10,
    &H10, &H10, &H10, &H1F, &H10,
    &H10, &H10, &H10, &HF0, &H10,
    &H0, &H0, &H0, &HFF, &H10,
    &H10, &H10, &H10, &H10, &H10,
    &H10, &H10, &H10, &HFF, &H10,
    &H0, &H0, &H0, &HFF, &H14,
    &H0, &H0, &HFF, &H0, &HFF,
    &H0, &H0, &H1F, &H10, &H17,
    &H0, &H0, &HFC, &H4, &HF4,
    &H14, &H14, &H17, &H10, &H17,
    &H14, &H14, &HF4, &H4, &HF4,
    &H0, &H0, &HFF, &H0, &HF7,
    &H14, &H14, &H14, &H14, &H14,
    &H14, &H14, &HF7, &H0, &HF7,
    &H14, &H14, &H14, &H17, &H14,
    &H10, &H10, &H1F, &H10, &H1F,
    &H14, &H14, &H14, &HF4, &H14,
    &H10, &H10, &HF0, &H10, &HF0,
    &H0, &H0, &H1F, &H10, &H1F,
    &H0, &H0, &H0, &H1F, &H14,
    &H0, &H0, &H0, &HFC, &H14,
    &H0, &H0, &HF0, &H10, &HF0,
    &H10, &H10, &HFF, &H10, &HFF,
    &H14, &H14, &H14, &HFF, &H14,
    &H10, &H10, &H10, &H1F, &H0,
    &H0, &H0, &H0, &HF0, &H10,
    &HFF, &HFF, &HFF, &HFF, &HFF,
    &HF0, &HF0, &HF0, &HF0, &HF0,
    &HFF, &HFF, &HFF, &H0, &H0,
    &H0, &H0, &H0, &HFF, &HFF,
    &HF, &HF, &HF, &HF, &HF,
    &H38, &H44, &H44, &H38, &H44,
    &H7C, &H2A, &H2A, &H3E, &H14,
    &H7E, &H2, &H2, &H6, &H6,
    &H2, &H7E, &H2, &H7E, &H2,
    &H63, &H55, &H49, &H41, &H63,
    &H38, &H44, &H44, &H3C, &H4,
    &H40, &H7E, &H20, &H1E, &H20,
    &H6, &H2, &H7E, &H2, &H2,
    &H99, &HA5, &HE7, &HA5, &H99,
    &H1C, &H2A, &H49, &H2A, &H1C,
    &H4C, &H72, &H1, &H72, &H4C,
    &H30, &H4A, &H4D, &H4D, &H30,
    &H30, &H48, &H78, &H48, &H30,
    &HBC, &H62, &H5A, &H46, &H3D,
    &H3E, &H49, &H49, &H49, &H0,
    &H7E, &H1, &H1, &H1, &H7E,
    &H2A, &H2A, &H2A, &H2A, &H2A,
    &H44, &H44, &H5F, &H44, &H44,
    &H40, &H51, &H4A, &H44, &H40,
    &H40, &H44, &H4A, &H51, &H40,
    &H0, &H0, &HFF, &H1, &H3,
    &HE0, &H80, &HFF, &H0, &H0,
    &H8, &H8, &H6B, &H6B, &H8,
    &H36, &H12, &H36, &H24, &H36,
    &H6, &HF, &H9, &HF, &H6,
    &H0, &H0, &H18, &H18, &H0,
    &H0, &H0, &H10, &H10, &H0,
    &H30, &H40, &HFF, &H1, &H1,
    &H0, &H1F, &H1, &H1, &H1E,
    &H0, &H19, &H1D, &H17, &H12,
    &H0, &H3C, &H3C, &H3C, &H3C,
    &H0, &H0, &H0, &H0, &H0
}



End Class

Public Class MyGUI : Implements AnyI2C.GuiInterface

    Public Sub Show(com As CommInterface) Implements GuiInterface.Show
        Dim frm As frmSSD1306 = New frmSSD1306()
        frm.Attach(com)
        frm.ShowDialog()
    End Sub
End Class