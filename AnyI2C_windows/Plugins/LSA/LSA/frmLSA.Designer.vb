<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLSA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Address = New System.Windows.Forms.NumericUpDown()
        Me.btnPic = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._ERROR = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnText = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C6 = New System.Windows.Forms.Label()
        Me.C5 = New System.Windows.Forms.Label()
        Me.C4 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.Channel6 = New System.Windows.Forms.HScrollBar()
        Me.Channel5 = New System.Windows.Forms.HScrollBar()
        Me.Channel4 = New System.Windows.Forms.HScrollBar()
        Me.Channel3 = New System.Windows.Forms.HScrollBar()
        Me.C2 = New System.Windows.Forms.Label()
        Me.Channel2 = New System.Windows.Forms.HScrollBar()
        Me.C1 = New System.Windows.Forms.Label()
        Me.Channel1 = New System.Windows.Forms.HScrollBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Setup_PCA9685 = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Frequency = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Port = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCh3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCh2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbCh1 = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.lbCh0 = New System.Windows.Forms.Label()
        Me.btnRead9536 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbT = New System.Windows.Forms.Label()
        Me.lbP = New System.Windows.Forms.Label()
        Me.btnMPL115A2Read = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.lbADC121 = New System.Windows.Forms.Label()
        Me.btnADC121Read = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnHCPA5VU3Read = New System.Windows.Forms.Button()
        Me.lbHCPATemp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbHCPAHumidity = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Address, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnSetup)
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.Controls.Add(Me.btnPic)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(654, 207)
        Me.GroupBox6.TabIndex = 496
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SSD1306 I2COLED"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(6, 95)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(230, 23)
        Me.btnSetup.TabIndex = 493
        Me.btnSetup.Text = "Setup SSD1306 OLED"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 68)
        Me.GroupBox1.TabIndex = 491
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SSD1306  Hardware Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(372, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox2.TabIndex = 487
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Address
        '
        Me.Address.Enabled = False
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(11, 21)
        Me.Address.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(82, 35)
        Me.Address.TabIndex = 490
        Me.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Address.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'btnPic
        '
        Me.btnPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPic.Location = New System.Drawing.Point(17, 125)
        Me.btnPic.Name = "btnPic"
        Me.btnPic.Size = New System.Drawing.Size(131, 23)
        Me.btnPic.TabIndex = 502
        Me.btnPic.Text = "Show Picture"
        Me.btnPic.UseVisualStyleBackColor = True
        Me.btnPic.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 36)
        Me.Label2.TabIndex = 504
        Me.Label2.Text = "The Screen can show picture of 128x64 pixels"
        Me.Label2.Visible = False
        '
        '_ERROR
        '
        Me._ERROR.BackColor = System.Drawing.Color.Red
        Me._ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ERROR.Location = New System.Drawing.Point(682, 381)
        Me._ERROR.Name = "_ERROR"
        Me._ERROR.Size = New System.Drawing.Size(414, 57)
        Me._ERROR.TabIndex = 499
        Me._ERROR.Text = "ubuntu"
        Me._ERROR.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(338, 29)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 500
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 60)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 117)
        Me.TextBox1.TabIndex = 501
        Me.TextBox1.Text = "1234567890ABCDEFGHIJ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KLMNOPQRSTUVWXYZ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" &
    "ine 8"
        '
        'btnText
        '
        Me.btnText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnText.Location = New System.Drawing.Point(483, 29)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(131, 23)
        Me.btnText.TabIndex = 502
        Me.btnText.Text = "Update Text"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(345, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 36)
        Me.Label1.TabIndex = 503
        Me.Label1.Text = "The screen can show 8 lines of text.  Each line can have 20 characters."
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.C6)
        Me.GroupBox8.Controls.Add(Me.C5)
        Me.GroupBox8.Controls.Add(Me.C4)
        Me.GroupBox8.Controls.Add(Me.C3)
        Me.GroupBox8.Controls.Add(Me.Channel6)
        Me.GroupBox8.Controls.Add(Me.Channel5)
        Me.GroupBox8.Controls.Add(Me.Channel4)
        Me.GroupBox8.Controls.Add(Me.Channel3)
        Me.GroupBox8.Controls.Add(Me.C2)
        Me.GroupBox8.Controls.Add(Me.Channel2)
        Me.GroupBox8.Controls.Add(Me.C1)
        Me.GroupBox8.Controls.Add(Me.Channel1)
        Me.GroupBox8.Location = New System.Drawing.Point(242, 21)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(395, 164)
        Me.GroupBox8.TabIndex = 506
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Control Output Channels"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Green"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Yellow"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Red"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Beep"
        '
        'C6
        '
        Me.C6.AutoSize = True
        Me.C6.Location = New System.Drawing.Point(365, 116)
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(16, 16)
        Me.C6.TabIndex = 13
        Me.C6.Text = "0"
        '
        'C5
        '
        Me.C5.AutoSize = True
        Me.C5.Location = New System.Drawing.Point(365, 96)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(16, 16)
        Me.C5.TabIndex = 12
        Me.C5.Text = "0"
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Location = New System.Drawing.Point(365, 76)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(16, 16)
        Me.C4.TabIndex = 11
        Me.C4.Text = "0"
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Location = New System.Drawing.Point(365, 56)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(16, 16)
        Me.C3.TabIndex = 10
        Me.C3.Text = "0"
        '
        'Channel6
        '
        Me.Channel6.Location = New System.Drawing.Point(61, 116)
        Me.Channel6.Maximum = 4095
        Me.Channel6.Name = "Channel6"
        Me.Channel6.Size = New System.Drawing.Size(275, 20)
        Me.Channel6.TabIndex = 7
        '
        'Channel5
        '
        Me.Channel5.Location = New System.Drawing.Point(61, 96)
        Me.Channel5.Maximum = 4095
        Me.Channel5.Name = "Channel5"
        Me.Channel5.Size = New System.Drawing.Size(275, 20)
        Me.Channel5.TabIndex = 6
        '
        'Channel4
        '
        Me.Channel4.Location = New System.Drawing.Point(61, 76)
        Me.Channel4.Maximum = 4095
        Me.Channel4.Name = "Channel4"
        Me.Channel4.Size = New System.Drawing.Size(275, 20)
        Me.Channel4.TabIndex = 5
        '
        'Channel3
        '
        Me.Channel3.Location = New System.Drawing.Point(61, 56)
        Me.Channel3.Maximum = 4095
        Me.Channel3.Name = "Channel3"
        Me.Channel3.Size = New System.Drawing.Size(275, 20)
        Me.Channel3.TabIndex = 4
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(365, 36)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(16, 16)
        Me.C2.TabIndex = 3
        Me.C2.Text = "0"
        '
        'Channel2
        '
        Me.Channel2.Location = New System.Drawing.Point(61, 36)
        Me.Channel2.Maximum = 4095
        Me.Channel2.Name = "Channel2"
        Me.Channel2.Size = New System.Drawing.Size(275, 20)
        Me.Channel2.TabIndex = 2
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(365, 16)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(16, 16)
        Me.C1.TabIndex = 1
        Me.C1.Text = "0"
        '
        'Channel1
        '
        Me.Channel1.Location = New System.Drawing.Point(61, 16)
        Me.Channel1.Maximum = 4095
        Me.Channel1.Name = "Channel1"
        Me.Channel1.Size = New System.Drawing.Size(275, 20)
        Me.Channel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Setup_PCA9685)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(654, 203)
        Me.GroupBox3.TabIndex = 505
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PCA9685 PWM Controller"
        '
        'Setup_PCA9685
        '
        Me.Setup_PCA9685.Location = New System.Drawing.Point(12, 97)
        Me.Setup_PCA9685.Name = "Setup_PCA9685"
        Me.Setup_PCA9685.Size = New System.Drawing.Size(224, 23)
        Me.Setup_PCA9685.TabIndex = 493
        Me.Setup_PCA9685.Text = "Setup PCA9685"
        Me.Setup_PCA9685.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox13)
        Me.GroupBox12.Controls.Add(Me.Frequency)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(224, 68)
        Me.GroupBox12.TabIndex = 492
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "PCA9685 PWM Frequency"
        '
        'GroupBox13
        '
        Me.GroupBox13.Location = New System.Drawing.Point(372, 84)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox13.TabIndex = 487
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "GroupBox13"
        '
        'Frequency
        '
        Me.Frequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frequency.Location = New System.Drawing.Point(11, 21)
        Me.Frequency.Maximum = New Decimal(New Integer() {1600, 0, 0, 0})
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Size = New System.Drawing.Size(124, 35)
        Me.Frequency.TabIndex = 490
        Me.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Frequency.Value = New Decimal(New Integer() {1600, 0, 0, 0})
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(348, 473)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(287, 68)
        Me.GroupBox10.TabIndex = 491
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "PCA9685 Hardware Address"
        '
        'GroupBox11
        '
        Me.GroupBox11.Location = New System.Drawing.Point(372, 84)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox11.TabIndex = 487
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "GroupBox11"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(11, 21)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {62, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(82, 35)
        Me.NumericUpDown2.TabIndex = 490
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Port
        '
        Me.Port.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Port.Location = New System.Drawing.Point(11, 21)
        Me.Port.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(82, 35)
        Me.Port.TabIndex = 482
        Me.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(372, 84)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox7.TabIndex = 487
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 489
        Me.Label3.Text = "0 = Internal I2C Port"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.Port)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(29, 456)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(287, 68)
        Me.GroupBox4.TabIndex = 485
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choose an I2C Communication Port"
        Me.GroupBox4.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.lbCh3)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.lbCh2)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.lbCh1)
        Me.GroupBox5.Controls.Add(Me.C)
        Me.GroupBox5.Controls.Add(Me.lbCh0)
        Me.GroupBox5.Controls.Add(Me.btnRead9536)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(685, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(411, 90)
        Me.GroupBox5.TabIndex = 506
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PCA9536"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(289, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 657
        Me.Label4.Text = "CH3"
        '
        'lbCh3
        '
        Me.lbCh3.AutoSize = True
        Me.lbCh3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbCh3.Location = New System.Drawing.Point(345, 56)
        Me.lbCh3.Name = "lbCh3"
        Me.lbCh3.Size = New System.Drawing.Size(23, 16)
        Me.lbCh3.TabIndex = 658
        Me.lbCh3.Text = "---"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(171, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 655
        Me.Label5.Text = "CH2"
        '
        'lbCh2
        '
        Me.lbCh2.AutoSize = True
        Me.lbCh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbCh2.Location = New System.Drawing.Point(231, 56)
        Me.lbCh2.Name = "lbCh2"
        Me.lbCh2.Size = New System.Drawing.Size(23, 16)
        Me.lbCh2.TabIndex = 656
        Me.lbCh2.Text = "---"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(289, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 653
        Me.Label6.Text = "CH1"
        '
        'lbCh1
        '
        Me.lbCh1.AutoSize = True
        Me.lbCh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbCh1.Location = New System.Drawing.Point(345, 21)
        Me.lbCh1.Name = "lbCh1"
        Me.lbCh1.Size = New System.Drawing.Size(23, 16)
        Me.lbCh1.TabIndex = 654
        Me.lbCh1.Text = "---"
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.C.Location = New System.Drawing.Point(171, 21)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(37, 16)
        Me.C.TabIndex = 651
        Me.C.Text = "CH0"
        '
        'lbCh0
        '
        Me.lbCh0.AutoSize = True
        Me.lbCh0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbCh0.Location = New System.Drawing.Point(231, 21)
        Me.lbCh0.Name = "lbCh0"
        Me.lbCh0.Size = New System.Drawing.Size(23, 16)
        Me.lbCh0.TabIndex = 652
        Me.lbCh0.Text = "---"
        '
        'btnRead9536
        '
        Me.btnRead9536.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRead9536.Location = New System.Drawing.Point(12, 21)
        Me.btnRead9536.Name = "btnRead9536"
        Me.btnRead9536.Size = New System.Drawing.Size(143, 29)
        Me.btnRead9536.TabIndex = 650
        Me.btnRead9536.Text = "Read "
        Me.btnRead9536.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.lbT)
        Me.GroupBox9.Controls.Add(Me.lbP)
        Me.GroupBox9.Controls.Add(Me.btnMPL115A2Read)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(685, 122)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(411, 63)
        Me.GroupBox9.TabIndex = 507
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "MPL115A2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(381, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 16)
        Me.Label7.TabIndex = 651
        Me.Label7.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(256, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 652
        Me.Label8.Text = "Pa"
        '
        'lbT
        '
        Me.lbT.AutoSize = True
        Me.lbT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbT.Location = New System.Drawing.Point(323, 27)
        Me.lbT.Name = "lbT"
        Me.lbT.Size = New System.Drawing.Size(23, 16)
        Me.lbT.TabIndex = 653
        Me.lbT.Text = "---"
        '
        'lbP
        '
        Me.lbP.AutoSize = True
        Me.lbP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbP.Location = New System.Drawing.Point(200, 27)
        Me.lbP.Name = "lbP"
        Me.lbP.Size = New System.Drawing.Size(23, 16)
        Me.lbP.TabIndex = 654
        Me.lbP.Text = "---"
        '
        'btnMPL115A2Read
        '
        Me.btnMPL115A2Read.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMPL115A2Read.Location = New System.Drawing.Point(12, 21)
        Me.btnMPL115A2Read.Name = "btnMPL115A2Read"
        Me.btnMPL115A2Read.Size = New System.Drawing.Size(143, 29)
        Me.btnMPL115A2Read.TabIndex = 650
        Me.btnMPL115A2Read.Text = "Read "
        Me.btnMPL115A2Read.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.lbADC121)
        Me.GroupBox14.Controls.Add(Me.btnADC121Read)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(685, 230)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(411, 62)
        Me.GroupBox14.TabIndex = 508
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "ADC121"
        '
        'lbADC121
        '
        Me.lbADC121.AutoSize = True
        Me.lbADC121.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbADC121.Location = New System.Drawing.Point(200, 34)
        Me.lbADC121.Name = "lbADC121"
        Me.lbADC121.Size = New System.Drawing.Size(23, 16)
        Me.lbADC121.TabIndex = 655
        Me.lbADC121.Text = "---"
        '
        'btnADC121Read
        '
        Me.btnADC121Read.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnADC121Read.Location = New System.Drawing.Point(12, 21)
        Me.btnADC121Read.Name = "btnADC121Read"
        Me.btnADC121Read.Size = New System.Drawing.Size(143, 29)
        Me.btnADC121Read.TabIndex = 650
        Me.btnADC121Read.Text = "Read "
        Me.btnADC121Read.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label14)
        Me.GroupBox15.Controls.Add(Me.btnHCPA5VU3Read)
        Me.GroupBox15.Controls.Add(Me.lbHCPATemp)
        Me.GroupBox15.Controls.Add(Me.Label10)
        Me.GroupBox15.Controls.Add(Me.lbHCPAHumidity)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(685, 308)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(411, 62)
        Me.GroupBox15.TabIndex = 509
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "HCPA-5V-U3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(381, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 16)
        Me.Label14.TabIndex = 520
        Me.Label14.Text = "C"
        '
        'btnHCPA5VU3Read
        '
        Me.btnHCPA5VU3Read.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnHCPA5VU3Read.Location = New System.Drawing.Point(12, 21)
        Me.btnHCPA5VU3Read.Name = "btnHCPA5VU3Read"
        Me.btnHCPA5VU3Read.Size = New System.Drawing.Size(143, 29)
        Me.btnHCPA5VU3Read.TabIndex = 650
        Me.btnHCPA5VU3Read.Text = "Read "
        Me.btnHCPA5VU3Read.UseVisualStyleBackColor = True
        '
        'lbHCPATemp
        '
        Me.lbHCPATemp.AutoSize = True
        Me.lbHCPATemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbHCPATemp.Location = New System.Drawing.Point(319, 27)
        Me.lbHCPATemp.Name = "lbHCPATemp"
        Me.lbHCPATemp.Size = New System.Drawing.Size(23, 16)
        Me.lbHCPATemp.TabIndex = 521
        Me.lbHCPATemp.Text = "---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(262, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 16)
        Me.Label10.TabIndex = 519
        Me.Label10.Text = "%"
        '
        'lbHCPAHumidity
        '
        Me.lbHCPAHumidity.AutoSize = True
        Me.lbHCPAHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbHCPAHumidity.Location = New System.Drawing.Point(200, 27)
        Me.lbHCPAHumidity.Name = "lbHCPAHumidity"
        Me.lbHCPAHumidity.Size = New System.Drawing.Size(23, 16)
        Me.lbHCPAHumidity.TabIndex = 519
        Me.lbHCPAHumidity.Text = "---"
        '
        'frmLSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 506)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me._ERROR)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frmLSA"
        Me.Text = "SSD1306 I2COLED Control Panel"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Address, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Address As System.Windows.Forms.NumericUpDown
    Friend WithEvents _ERROR As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents btnPic As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents C6 As Label
    Friend WithEvents C5 As Label
    Friend WithEvents C4 As Label
    Friend WithEvents C3 As Label
    Friend WithEvents Channel6 As HScrollBar
    Friend WithEvents Channel5 As HScrollBar
    Friend WithEvents Channel4 As HScrollBar
    Friend WithEvents Channel3 As HScrollBar
    Friend WithEvents C2 As Label
    Friend WithEvents Channel2 As HScrollBar
    Friend WithEvents C1 As Label
    Friend WithEvents Channel1 As HScrollBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Setup_PCA9685 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Frequency As NumericUpDown
    Friend WithEvents Port As NumericUpDown
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbCh3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbCh2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbCh1 As Label
    Friend WithEvents C As Label
    Friend WithEvents lbCh0 As Label
    Friend WithEvents btnRead9536 As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents btnMPL115A2Read As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbT As Label
    Friend WithEvents lbP As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents btnADC121Read As Button
    Friend WithEvents lbADC121 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents btnHCPA5VU3Read As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lbHCPATemp As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbHCPAHumidity As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
End Class
