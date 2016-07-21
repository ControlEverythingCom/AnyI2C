Imports AnyI2C

Public Class frmI2CS
    Dim CommObj As CommInterface = Nothing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommObj.LogText("GUI Opened")
        numAddress.Value = CommObj.GetDefaultAddress()
        numPort.Value = CommObj.GetPort()
    End Sub

    Public Sub Attach(com As CommInterface)
        CommObj = com
    End Sub

    Private Function GetAddress(read As Boolean) As Byte
        If (read) Then
            Return numAddress.Value * 2 + 1
        End If
        Return numAddress.Value * 2
    End Function

    Private Function ReadSensor()
        Try
            _ERROR.Visible = False
            Dim addr As Byte = GetAddress(False)
            Dim value() As Byte = CommObj.Send(New Byte() {addr, 0}, 4)
            Threading.Thread.Sleep(500)
            If (value IsNot Nothing) Then
                If (value.Length = 4) Then
                    Dim pressure As Double = (value(0) And &HFF) * 256 + (value(1) And &HFF)
                    Dim temp As Double = (value(2) And &HFF) * 256 + (value(3) And &HFF)
                    pressure = (pressure - 3277.0) / (26124.0 / 10.0) - 5.0
                    Dim cTemp As Double = (temp - 3277.0) / (26214.0 / 110.0) - 25.0
                    lbC.Text = cTemp.ToString("F2")
                    lbP.Text = pressure.ToString("F2")
                End If
            End If
            Return "OK"
        Catch ex As Exception
            _ERROR.Visible = True
        End Try
        Return "Error"
    End Function

    Private Sub btnReadCh0_Click(sender As Object, e As EventArgs) Handles btnReadCh0.Click
        ReadSensor()
    End Sub

    Private Sub chkAutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoUpdate.CheckedChanged
        btnReadCh0.Enabled = Not chkAutoUpdate.Checked
        If (chkAutoUpdate.Checked) Then
            timer1.Enabled = True
        Else
            timer1.Enabled = False
        End If
    End Sub

    Private Sub frmI2CS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        ReadSensor()
    End Sub
End Class

Public Class MyGUI : Implements AnyI2C.GuiInterface

    Public Sub Show(com As CommInterface) Implements GuiInterface.Show
        Dim frm As frmI2CS = New frmI2CS()
        frm.Attach(com)
        frm.ShowDialog()
    End Sub
End Class
