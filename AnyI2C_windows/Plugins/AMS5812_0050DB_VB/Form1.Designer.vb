<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmI2CS
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
        Me.components = New System.ComponentModel.Container()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.numPort = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.lbC = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnReadCh0 = New System.Windows.Forms.Button()
        Me._ERROR = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numAddress = New System.Windows.Forms.NumericUpDown()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbP = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.groupBox4)
        Me.groupBox3.Controls.Add(Me.numPort)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(179, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(120, 68)
        Me.groupBox3.TabIndex = 567
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Port"
        '
        'groupBox4
        '
        Me.groupBox4.Location = New System.Drawing.Point(372, 84)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(200, 52)
        Me.groupBox4.TabIndex = 487
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "GroupBox2"
        '
        'numPort
        '
        Me.numPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPort.Location = New System.Drawing.Point(11, 21)
        Me.numPort.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numPort.Name = "numPort"
        Me.numPort.Size = New System.Drawing.Size(82, 35)
        Me.numPort.TabIndex = 490
        Me.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.AutoSize = True
        Me.chkAutoUpdate.Location = New System.Drawing.Point(335, 201)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(86, 17)
        Me.chkAutoUpdate.TabIndex = 566
        Me.chkAutoUpdate.Text = "Auto Update"
        Me.chkAutoUpdate.UseVisualStyleBackColor = True
        '
        'lbC
        '
        Me.lbC.AutoSize = True
        Me.lbC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbC.Location = New System.Drawing.Point(415, 100)
        Me.lbC.Name = "lbC"
        Me.lbC.Size = New System.Drawing.Size(23, 16)
        Me.lbC.TabIndex = 565
        Me.lbC.Text = "---"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(484, 100)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(18, 16)
        Me.label3.TabIndex = 564
        Me.label3.Text = "C"
        '
        'btnReadCh0
        '
        Me.btnReadCh0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReadCh0.Location = New System.Drawing.Point(335, 24)
        Me.btnReadCh0.Name = "btnReadCh0"
        Me.btnReadCh0.Size = New System.Drawing.Size(249, 29)
        Me.btnReadCh0.TabIndex = 563
        Me.btnReadCh0.Text = "Read "
        Me.btnReadCh0.UseVisualStyleBackColor = True
        '
        '_ERROR
        '
        Me._ERROR.BackColor = System.Drawing.Color.Red
        Me._ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me._ERROR.Location = New System.Drawing.Point(9, 102)
        Me._ERROR.Name = "_ERROR"
        Me._ERROR.Size = New System.Drawing.Size(290, 63)
        Me._ERROR.TabIndex = 562
        Me._ERROR.Text = "ERROR: Device did Not Respond"
        Me._ERROR.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 68)
        Me.GroupBox1.TabIndex = 561
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hardware Address"
        '
        'numAddress
        '
        Me.numAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.numAddress.Location = New System.Drawing.Point(11, 21)
        Me.numAddress.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numAddress.Name = "numAddress"
        Me.numAddress.Size = New System.Drawing.Size(82, 35)
        Me.numAddress.TabIndex = 0
        Me.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numAddress.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'timer1
        '
        Me.timer1.Interval = 500
        '
        'lbP
        '
        Me.lbP.AutoSize = True
        Me.lbP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbP.Location = New System.Drawing.Point(415, 134)
        Me.lbP.Name = "lbP"
        Me.lbP.Size = New System.Drawing.Size(23, 16)
        Me.lbP.TabIndex = 569
        Me.lbP.Text = "---"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label2.Location = New System.Drawing.Point(484, 134)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 16)
        Me.label2.TabIndex = 568
        Me.label2.Text = "mBar"
        '
        'frmI2CS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 236)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.chkAutoUpdate)
        Me.Controls.Add(Me.lbC)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnReadCh0)
        Me.Controls.Add(Me._ERROR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbP)
        Me.Controls.Add(Me.label2)
        Me.Name = "frmI2CS"
        Me.Text = "AMS5812-0050DB Control Panel"
        Me.groupBox3.ResumeLayout(False)
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.numAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents groupBox4 As GroupBox
    Friend WithEvents numPort As NumericUpDown
    Private WithEvents chkAutoUpdate As CheckBox
    Friend WithEvents lbC As Label
    Friend WithEvents label3 As Label
    Friend WithEvents btnReadCh0 As Button
    Friend WithEvents _ERROR As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents numAddress As NumericUpDown
    Private WithEvents timer1 As Timer
    Friend WithEvents lbP As Label
    Friend WithEvents label2 As Label
End Class
