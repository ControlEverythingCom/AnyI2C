
Imports AnyI2C


Public Class ACCurrentMonitoring

    Dim CommObj As CommInterface = Nothing

    Public UsingAPI As Boolean = True 'frmBASE.APISupport ' flag for if using API mode
    Public ACChannels As Byte
    Public MaxCurrent As Integer
    Public WattHours1 As Decimal
    Public WattHours2 As Decimal
    Public WattHours3 As Decimal
    Public WattHours4 As Decimal
    Public WattHours5 As Decimal
    Public WattHours6 As Decimal
    Public DeviceAddress As Integer = 84
    Public formloading As Boolean = True


    Public Sub Attach(com As CommInterface)
        CommObj = com
    End Sub


    Private Sub ACCurrentMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error GoTo Ending
        '  NCDLib.WriteBytesAPI(NCDComponent1, UsingAPI, 188, 50, 10, DeviceAddress, 146, 106, 2, 0, 0, 0, 0, 254, (DeviceAddress + 1), 7)
        '  Dim rData2 As Byte() = NCDLib.ReadBytesAPI(NCDComponent1, UsingAPI, 7)
        '  Debug.Print("Get Device Data")
        '  Debug.Print("Read Device Data 1: " + rData2(0).ToString) 'Sensor Type
        '  Debug.Print("Read Device Data 2: " + rData2(1).ToString) 'Max Current 
        '  Debug.Print("Read Device Data 3: " + rData2(2).ToString) 'Number of Channels
        '  Debug.Print("Read Device Data 4: " + rData2(3).ToString) 'Firmware Version
        '  Debug.Print("Read Device Data 5: " + rData2(4).ToString) 'Reserved
        '  Debug.Print("Read Device Data 6: " + rData2(5).ToString) 'Reserved
        '  Debug.Print("Read Device Data 7: " + rData2(6).ToString) 'Checksum
        '
        '  Dim ckSum As Integer = rData2(0) + rData2(1) + rData2(2) + rData2(3) + rData2(4) + rData2(5)
        '  If rData2(6) <> (ckSum And 255) Then
        '      MsgBox("Invalid Checksum, Cannot Communicate with Secondary CPU")
        '      Exit Sub
        '  End If
        '  Dim sensor As String = ""
        '  If rData2(0) = 1 Then sensor = "DLCT03C20"
        '  If rData2(0) = 2 Then sensor = "DLCT27C10"
        '  If rData2(0) = 3 Then sensor = "DLCT03CL20"
        '  If rData2(0) = 4 Then sensor = "OPCT16AL"
        '  If rData2(0) = 5 Then sensor = "SCT013"
        '  If rData2(0) = 6 Then sensor = "OPCT38AL"
        '  ModelVariant.Text = "For Use with " + sensor + " Sensors Only."
        '  ACChannels = rData2(2)
        '  MaxChannels.Text = ACChannels.ToString + " Channels Available"
        '  If rData2(0) < 6 Then 'If Sensor type is small range sensors
        '      MaxCurrent = rData2(1)
        '      MaxAmps.Text = MaxCurrent.ToString + " Amps Max per Channel"
        '  Else
        '      MaxCurrent = rData2(1) * 10
        '      MaxAmps.Text = MaxCurrent.ToString + " Amps Max per Channel"
        '  End If
        '  FWVersion.Text = "Version: 4." + frmBASE.FirmwareVersionLarge.ToString + "." + frmBASE.FirmwareVersionSmall.ToString + "." + rData2(3).ToString
        '
        '  'Setup UI: Destruct Interface based on Channels available
        '  If ACChannels < 6 Then AC6.Visible = False : Label7.Visible = False : ACC6.Visible = False : RefreshRate.Minimum = 7 '5 Channel
        '  If ACChannels < 5 Then AC5.Visible = False : Label8.Visible = False : ACC5.Visible = False : RefreshRate.Minimum = 6 '4 Channel
        '  If ACChannels < 4 Then AC4.Visible = False : Label4.Visible = False : ACC4.Visible = False : RefreshRate.Minimum = 5 '3 Channel
        '  If ACChannels < 3 Then AC3.Visible = False : Label3.Visible = False : ACC3.Visible = False : RefreshRate.Minimum = 3 '2 Channel
        '  If ACChannels < 2 Then AC2.Visible = False : Label2.Visible = False : ACC2.Visible = False : RefreshRate.Minimum = 2 '1 Channel
        '
        '  '600 Amps is the maximum sensor we support (6,000 to show changes in .1Amp Changes)
        '  AC1.Maximum = MaxCurrent * 10
        '  AC2.Maximum = AC1.Maximum
        '  AC3.Maximum = AC1.Maximum
        '  AC4.Maximum = AC1.Maximum
        '  AC5.Maximum = AC1.Maximum
        '  AC6.Maximum = AC1.Maximum

        ReadDeviceSettings()

        Timer1.Interval = RefreshRate.Value * 100 'Change to 1000 before release
        Timer1.Start()
        kWhTimer.Start()
        formloading = False

        Exit Sub

Ending:
        MsgBox("Communications Error with Secondary Processor, Remove Address Jumpers and Re-Boot Controller")
        Exit Sub


    End Sub


    Public Sub ReadDeviceSettings()

        ModelVariant.Text = ""
        MaxAmps.Text = ""
        MaxChannels.Text = ""
        FWVersion.Text = ""
        ACC1.Text = ""
        ACC2.Text = ""
        ACC3.Text = ""
        ACC4.Text = ""
        ACC5.Text = ""
        ACC6.Text = ""

        Watts1.Text = ""
        Watts2.Text = ""
        Watts3.Text = ""
        Watts4.Text = ""
        Watts5.Text = ""
        Watts6.Text = ""

        KWH1.Text = ""
        KWH2.Text = ""
        KWH3.Text = ""
        KWH4.Text = ""
        KWH5.Text = ""
        KWH6.Text = ""

        Cost1.Text = ""
        Cost2.Text = ""
        Cost3.Text = ""
        Cost4.Text = ""
        Cost5.Text = ""
        Cost6.Text = ""

        TotalWatts.Text = ""
        TotalCost.Text = ""
        TotalKWH.Text = ""


        Debug.Print("--------------------------------------------ADDRESS " + DeviceAddress.ToString)
        On Error GoTo Ending
        'NCDLib.WriteBytesAPI(NCDComponent1, UsingAPI, 188, 50, 10, DeviceAddress, 146, 106, 2, 0, 0, 0, 0, 254, (DeviceAddress + 1), 7)
        'Dim rData2 As Byte() = NCDLib.ReadBytesAPI(NCDComponent1, UsingAPI, 7)
        Dim rData2 As Byte() = CommObj.Send(New Byte() {DeviceAddress, 146, 106, 2, 0, 0, 0, 0, 254, (DeviceAddress + 1)}, 7)

        Debug.Print("Get Device Data")
        Debug.Print("Read Device Data 1: " + rData2(0).ToString) 'Sensor Type
        Debug.Print("Read Device Data 2: " + rData2(1).ToString) 'Max Current 
        Debug.Print("Read Device Data 3: " + rData2(2).ToString) 'Number of Channels
        Debug.Print("Read Device Data 4: " + rData2(3).ToString) 'Firmware Version
        Debug.Print("Read Device Data 5: " + rData2(4).ToString) 'Reserved
        Debug.Print("Read Device Data 6: " + rData2(5).ToString) 'Reserved
        Debug.Print("Read Device Data 7: " + rData2(6).ToString) 'Checksum

        Dim ckSum As Integer = rData2(0) + rData2(1) + rData2(2) + rData2(3) + rData2(4) + rData2(5)
        If rData2(6) <> (ckSum And 255) Then
            MsgBox("Invalid Checksum, Cannot Communicate with Secondary CPU")
            Exit Sub
        End If
        Dim sensor As String = ""
        If rData2(0) = 1 Then sensor = "DLCT03C20"
        If rData2(0) = 2 Then sensor = "DLCT27C10"
        If rData2(0) = 3 Then sensor = "DLCT03CL20"
        If rData2(0) = 4 Then sensor = "OPCT16AL"
        If rData2(0) = 5 Then sensor = "SCT013"
        If rData2(0) = 6 Then sensor = "OPCT38AL"
        ModelVariant.Text = "For Use with " + sensor + " Sensors Only."
        ACChannels = rData2(2)
        MaxChannels.Text = ACChannels.ToString + " Channels Available"
        If rData2(0) < 6 Then 'If Sensor type is small range sensors
            MaxCurrent = rData2(1)
            MaxAmps.Text = MaxCurrent.ToString + " Amps Max per Channel"
        Else
            MaxCurrent = rData2(1) * 10
            MaxAmps.Text = MaxCurrent.ToString + " Amps Max per Channel"
        End If
        'FWVersion.Text = "Version: 4." + frmBASE.FirmwareVersionLarge.ToString + "." + frmBASE.FirmwareVersionSmall.ToString + "." + rData2(3).ToString

        'Setup UI: Destruct Interface based on Channels available
        If ACChannels < 6 Then AC6.Visible = False : Label7.Visible = False : ACC6.Visible = False : RefreshRate.Minimum = 7 '5 Channel
        If ACChannels < 5 Then AC5.Visible = False : Label8.Visible = False : ACC5.Visible = False : RefreshRate.Minimum = 6 '4 Channel
        If ACChannels < 4 Then AC4.Visible = False : Label4.Visible = False : ACC4.Visible = False : RefreshRate.Minimum = 5 '3 Channel
        If ACChannels < 3 Then AC3.Visible = False : Label3.Visible = False : ACC3.Visible = False : RefreshRate.Minimum = 3 '2 Channel
        If ACChannels < 2 Then AC2.Visible = False : Label2.Visible = False : ACC2.Visible = False : RefreshRate.Minimum = 2 '1 Channel


        '600 Amps is the maximum sensor we support (6,000 to show changes in .1Amp Changes)
        AC1.Maximum = MaxCurrent * 10
        AC2.Maximum = AC1.Maximum
        AC3.Maximum = AC1.Maximum
        AC4.Maximum = AC1.Maximum
        AC5.Maximum = AC1.Maximum
        AC6.Maximum = AC1.Maximum

        '  Timer1.Interval = RefreshRate.Value * 100 'Change to 1000 before release
        '  Timer1.Start()
        '  kWhTimer.Start()

        Exit Sub

Ending:
        MsgBox("Communications Error with Secondary Processor, Remove Address Jumpers and Re-Boot Controller")
        Exit Sub

    End Sub


    Private Sub frmAD8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If UsingAPI = True Then
            Me.Text = Me.Text + " (API Mode)"
        End If
    End Sub

    Public Sub CMD_Data(Description As String, Component As String, OneWay As Boolean)
        If UsingAPI = False Then
            CMD_Description.Text = Description
        Else
            CMD_Description.Text = Description & "  Data Shown in API Format"
        End If
        If OneWay = False Then
            CMD_Transmit.Text = GetDataString(CommObj.GetLastTransmitData())
        Else
            CMD_Transmit.Text = "No Bytes Received from This Command"
        End If
        CMD_Receive.Text = GetDataString(CommObj.GetLastReceivingData())
        CMD_Method.Text = Component '"NCDComponent1.ProXR.RelayBanks.TurnOnRelay(1)"
    End Sub

    ''' <summary>
    ''' convert data to view string
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Private Function GetDataString(data As Byte())

    End Function

    Public Sub LinkTo(ByVal Address As String)
        Try
            System.Diagnostics.Process.Start(Address) ' start browser for that link
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkTo("http://assets.controlanything.com/QSG/AD8_Quick_Start_Guide.pdf")
    End Sub

    Private Sub MORE_Click(sender As System.Object, e As System.EventArgs) Handles MORE.Click
        'If MORE.Text = "MORE" Then
        '    MORE.Text = "LESS"
        '    ' Me.Height = 449 'TALL
        '    Me.Height = GroupBox23.Top + GroupBox23.Height + frmBASE.OSOffset + 20
        'Else
        '    MORE.Text = "MORE"
        '    ' Me.Height = 319 'SHORT
        '    Me.Height = Res.Top + Res.Height + frmBASE.OSOffset
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Debug.Print(TimeOfDay)

        Dim ACChannelsCkSum As Byte = ((146 + 106 + 1 + 1 + ACChannels) And 255)
        Dim ACChannelsBytes As Byte = ((ACChannels * 3) + 1)
        'NCDLib.WriteBytesAPI(NCDComponent1, UsingAPI, 188, 50, 10, DeviceAddress, 146, 106, 1, 1, ACChannels, 0, 0, ACChannelsCkSum, (DeviceAddress + 1), ACChannelsBytes)

        'Dim CurrentReadings As Byte() = NCDLib.ReadBytesAPI(NCDComponent1, UsingAPI, ACChannelsBytes)
        Dim CurrentReadings As Byte() = CommObj.Send(New Byte() {DeviceAddress, 146, 106, 1, 1, ACChannels, 0, 0, ACChannelsCkSum, (DeviceAddress + 1)}, ACChannelsBytes)
        If CurrentReadings IsNot Nothing Then

            Dim CkSum As Integer = CurrentReadings((ACChannels * 3))
            Dim CalcSum As Integer = 0

            For X As Integer = 0 To ((ACChannels * 3) - 1)
                CalcSum = CalcSum + CurrentReadings(X)
            Next X
            If (CalcSum And 255) <> CkSum Then
                Debug.Print("Checksum Calculation Error: " + CalcSum.ToString + ":" + CkSum.ToString)
            Else
                'Display Data in Console
                On Error GoTo ExitTimer

                If ACChannels >= 1 Then
                    Dim CalcACCurrent1 As Integer = ((CurrentReadings(0) * 65536) + (CurrentReadings(1) * 256) + CurrentReadings(2))
                    ACC1.Text = (CalcACCurrent1 / 1000).ToString + " Amps"
                    AC1.Value = Int(CalcACCurrent1 / 100)
                    Watts1.Text = ((CalcACCurrent1 / 1000) * SystemVolts.Value).ToString("0.00")
                End If
                If ACChannels >= 2 Then
                    Dim CalcACCurrent2 As Integer = ((CurrentReadings(3) * 65536) + (CurrentReadings(4) * 256) + CurrentReadings(5))
                    ACC2.Text = (CalcACCurrent2 / 1000).ToString + " Amps"
                    AC2.Value = Int(CalcACCurrent2 / 100)
                    Watts2.Text = ((CalcACCurrent2 / 1000) * SystemVolts.Value).ToString("0.00")
                End If
                If ACChannels >= 3 Then
                    Dim CalcACCurrent3 As Integer = ((CurrentReadings(6) * 65536) + (CurrentReadings(7) * 256) + CurrentReadings(8))
                    ACC3.Text = (CalcACCurrent3 / 1000).ToString + " Amps"
                    AC3.Value = Int(CalcACCurrent3 / 100)
                    Watts3.Text = ((CalcACCurrent3 / 1000) * SystemVolts.Value).ToString("0.00")
                End If
                If ACChannels >= 4 Then
                    Dim CalcACCurrent4 As Integer = ((CurrentReadings(9) * 65536) + (CurrentReadings(10) * 256) + CurrentReadings(11))
                    ACC4.Text = (CalcACCurrent4 / 1000).ToString + " Amps"
                    AC4.Value = Int(CalcACCurrent4 / 100)
                    Watts4.Text = ((CalcACCurrent4 / 1000) * SystemVolts.Value).ToString("0.00")
                End If
                If ACChannels >= 5 Then
                    Dim CalcACCurrent5 As Integer = ((CurrentReadings(12) * 65536) + (CurrentReadings(13) * 256) + CurrentReadings(14))
                    ACC5.Text = (CalcACCurrent5 / 1000).ToString + " Amps"
                    AC5.Value = Int(CalcACCurrent5 / 100)
                    Watts5.Text = ((CalcACCurrent5 / 1000) * SystemVolts.Value).ToString("0.00")
                End If
                If ACChannels >= 6 Then
                    Dim CalcACCurrent6 As Integer = ((CurrentReadings(15) * 65536) + (CurrentReadings(16) * 256) + CurrentReadings(17))
                    ACC6.Text = (CalcACCurrent6 / 1000).ToString + " Amps"
                    AC6.Value = Int(CalcACCurrent6 / 100)
                    Watts6.Text = ((CalcACCurrent6 / 1000) * SystemVolts.Value).ToString("0.00")
                End If

            End If
        End If

ExitTimer:
        Timer1.Enabled = True


        If Me.Visible = False Then
            Timer1.Enabled = False
            kWhTimer.Enabled = False
        End If


    End Sub

    Private Sub kWhTimer_Tick(sender As Object, e As EventArgs) Handles kWhTimer.Tick

        Dim KiloWattHours1 As Decimal
        Dim KiloWattHours2 As Decimal
        Dim KiloWattHours3 As Decimal
        Dim KiloWattHours4 As Decimal
        Dim KiloWattHours5 As Decimal
        Dim KiloWattHours6 As Decimal
        Dim CallsPerHour As Decimal = 0.00277777777 '(360 calls per Hour = 1/360)


        'Channel 1
        WattHours1 = WattHours1 + (Val(Watts1.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours1 = WattHours1 / 1000
        KWH1.Text = KiloWattHours1.ToString("0.000")
        Cost1.Text = (Val(KWH1.Text) * Price.Value).ToString("0.00")
        'Channel 2
        WattHours2 = WattHours2 + (Val(Watts2.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours2 = WattHours2 / 1000
        KWH2.Text = KiloWattHours2.ToString("0.000")
        Cost2.Text = (Val(KWH2.Text) * Price.Value).ToString("0.00")
        'Channel 3
        WattHours3 = WattHours3 + (Val(Watts3.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours3 = WattHours3 / 1000
        KWH3.Text = KiloWattHours3.ToString("0.000")
        Cost3.Text = (Val(KWH3.Text) * Price.Value).ToString("0.00")
        'Channel 4
        WattHours4 = WattHours4 + (Val(Watts4.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours4 = WattHours4 / 1000
        KWH4.Text = KiloWattHours4.ToString("0.000")
        Cost4.Text = (Val(KWH4.Text) * Price.Value).ToString("0.00")
        'Channel 5
        WattHours5 = WattHours5 + (Val(Watts5.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours5 = WattHours5 / 1000
        KWH5.Text = KiloWattHours5.ToString("0.000")
        Cost5.Text = (Val(KWH5.Text) * Price.Value).ToString("0.00")
        'Channel 6
        WattHours6 = WattHours6 + (Val(Watts6.Text) + CallsPerHour)  '(360 calls per Hour = 1/360)
        KiloWattHours6 = WattHours6 / 1000
        KWH6.Text = KiloWattHours6.ToString("0.000")
        Cost6.Text = (Val(KWH6.Text) * Price.Value).ToString("0.00")

        TotalWatts.Text = (Val(Watts1.Text) + Val(Watts2.Text) + Val(Watts3.Text) + Val(Watts4.Text) + Val(Watts5.Text) + Val(Watts6.Text)).ToString
        TotalKWH.Text = (Val(KWH1.Text) + Val(KWH2.Text) + Val(KWH3.Text) + Val(KWH4.Text) + Val(KWH5.Text) + Val(KWH6.Text)).ToString
        TotalCost.Text = (Val(TotalKWH.Text) * Price.Value).ToString("0.00")

    End Sub

    Private Sub Calibrate_Click(sender As Object, e As EventArgs) Handles Calibrate.Click
        'Timer1.Enabled = False
        'Dim frm As ACCurrentCalibration     ' define a form variable
        'frm = New ACCurrentCalibration      ' create the new form
        'frm.NCDComponent1 = NCDComponent1   ' pass the NcdComponent object to ProXr form
        'frm.ACChannels = ACChannels         ' pass the number of AC Channels
        'frm.DeviceAddress = DeviceAddress   ' pass the Device Address for Calibration
        'frm.ShowDialog()
        'Me.Refresh()
        'Timer1.Enabled = True
    End Sub

    Private Sub SetAddress_ValueChanged(sender As Object, e As EventArgs) Handles SetAddress.ValueChanged

        If SetAddress.Value = 42 Then A0.Text = " Removed " : A1.Text = " Removed " : A2.Text = " Removed " : A3.Text = " Removed "
        If SetAddress.Value = 43 Then A0.Text = "Installed" : A1.Text = " Removed " : A2.Text = " Removed " : A3.Text = " Removed "
        If SetAddress.Value = 44 Then A0.Text = " Removed " : A1.Text = "Installed" : A2.Text = " Removed " : A3.Text = " Removed "
        If SetAddress.Value = 45 Then A0.Text = "Installed" : A1.Text = "Installed" : A2.Text = " Removed " : A3.Text = " Removed "
        If SetAddress.Value = 46 Then A0.Text = " Removed " : A1.Text = " Removed " : A2.Text = "Installed" : A3.Text = " Removed "
        If SetAddress.Value = 47 Then A0.Text = "Installed" : A1.Text = " Removed " : A2.Text = "Installed" : A3.Text = " Removed "
        If SetAddress.Value = 48 Then A0.Text = " Removed " : A1.Text = "Installed" : A2.Text = "Installed" : A3.Text = " Removed "
        If SetAddress.Value = 49 Then A0.Text = "Installed" : A1.Text = "Installed" : A2.Text = "Installed" : A3.Text = " Removed "
        If SetAddress.Value = 50 Then A0.Text = " Removed " : A1.Text = " Removed " : A2.Text = " Removed " : A3.Text = "Installed"
        If SetAddress.Value = 51 Then A0.Text = "Installed" : A1.Text = " Removed " : A2.Text = " Removed " : A3.Text = "Installed"
        If SetAddress.Value = 52 Then A0.Text = " Removed " : A1.Text = "Installed" : A2.Text = " Removed " : A3.Text = "Installed"
        If SetAddress.Value = 53 Then A0.Text = "Installed" : A1.Text = "Installed" : A2.Text = " Removed " : A3.Text = "Installed"
        If SetAddress.Value = 54 Then A0.Text = " Removed " : A1.Text = " Removed " : A2.Text = "Installed" : A3.Text = "Installed"
        If SetAddress.Value = 55 Then A0.Text = "Installed" : A1.Text = " Removed " : A2.Text = "Installed" : A3.Text = "Installed"
        If SetAddress.Value = 56 Then A0.Text = " Removed " : A1.Text = "Installed" : A2.Text = "Installed" : A3.Text = "Installed"
        If SetAddress.Value = 57 Then A0.Text = "Installed" : A1.Text = "Installed" : A2.Text = "Installed" : A3.Text = "Installed"

        'Calculate a New Device Address based on the Set Address Numeric Up/Down Setting
        DeviceAddress = (SetAddress.Value * 2)

        'Do not execute this code when form is first loaded
        If formloading = False Then
            Timer1.Enabled = False
            kWhTimer.Enabled = False
            ReadDeviceSettings()
            Timer1.Enabled = True
            kWhTimer.Enabled = True
        End If


    End Sub


    Private Function GetAddress(read As Boolean) As Byte
        'If (read) Then
        '    Return numAddress.Value * 2 + 1
        'End If
        'Return numAddress.Value * 2
    End Function

End Class

Public Class MyGUI : Implements AnyI2C.GuiInterface

    Public Sub Show(com As CommInterface) Implements GuiInterface.Show
        Dim frm As ACCurrentMonitoring = New ACCurrentMonitoring()
        frm.Attach(com)
        frm.ShowDialog()
    End Sub
End Class


