<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSSD1306
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Port = New System.Windows.Forms.NumericUpDown()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Address = New System.Windows.Forms.NumericUpDown()
        Me._ERROR = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnPic = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Address, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.btnSetup)
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(305, 346)
        Me.GroupBox6.TabIndex = 496
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Setup SSD1306 I2COLED"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.Port)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(287, 68)
        Me.GroupBox4.TabIndex = 485
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choose an I2C Communication Port"
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
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(372, 84)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox7.TabIndex = 487
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
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
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(6, 190)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(287, 23)
        Me.btnSetup.TabIndex = 493
        Me.btnSetup.Text = "Setup SSD1306 OLED"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 68)
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
        '_ERROR
        '
        Me._ERROR.BackColor = System.Drawing.Color.Red
        Me._ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ERROR.Location = New System.Drawing.Point(424, 304)
        Me._ERROR.Name = "_ERROR"
        Me._ERROR.Size = New System.Drawing.Size(233, 57)
        Me._ERROR.TabIndex = 499
        Me._ERROR.Text = "ubuntu"
        Me._ERROR.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(338, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 500
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 43)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 117)
        Me.TextBox1.TabIndex = 501
        Me.TextBox1.Text = "1234567890ABCDEFGHIJ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KLMNOPQRSTUVWXYZ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Line 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & _
    "ine 8"
        '
        'btnText
        '
        Me.btnText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnText.Location = New System.Drawing.Point(483, 12)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(131, 23)
        Me.btnText.TabIndex = 502
        Me.btnText.Text = "Update Text"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnPic
        '
        Me.btnPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPic.Location = New System.Drawing.Point(338, 202)
        Me.btnPic.Name = "btnPic"
        Me.btnPic.Size = New System.Drawing.Size(131, 23)
        Me.btnPic.TabIndex = 502
        Me.btnPic.Text = "Show Picture"
        Me.btnPic.UseVisualStyleBackColor = True
        Me.btnPic.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(345, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 36)
        Me.Label1.TabIndex = 503
        Me.Label1.Text = "The screen can show 8 lines of text.  Each line can have 20 characters."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(345, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 36)
        Me.Label2.TabIndex = 504
        Me.Label2.Text = "The Screen can show picture of 128x64 pixels"
        Me.Label2.Visible = False
        '
        'frmSSD1306
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPic)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me._ERROR)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frmSSD1306"
        Me.Text = "SSD1306 I2COLED Control Panel"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Address, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Port As System.Windows.Forms.NumericUpDown
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
End Class
