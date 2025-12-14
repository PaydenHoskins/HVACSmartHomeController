<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVAC
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateAndTimeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HighLabel = New System.Windows.Forms.Label()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.ModeGroupBox = New System.Windows.Forms.GroupBox()
        Me.OffRadioButton = New System.Windows.Forms.RadioButton()
        Me.CoolingRadioButton = New System.Windows.Forms.RadioButton()
        Me.HeatingRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AutoRadioButton = New System.Windows.Forms.RadioButton()
        Me.FanOnRadioButton = New System.Windows.Forms.RadioButton()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PortSelectLabel = New System.Windows.Forms.Label()
        Me.ComStatusTextBox = New System.Windows.Forms.TextBox()
        Me.ComStatusLabel = New System.Windows.Forms.Label()
        Me.MachineTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HighTextBox = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LowTextBox = New System.Windows.Forms.TextBox()
        Me.LowLabel = New System.Windows.Forms.Label()
        Me.HighDownButton = New System.Windows.Forms.Button()
        Me.HighUpButton = New System.Windows.Forms.Button()
        Me.LowUpButton = New System.Windows.Forms.Button()
        Me.LowDownButton = New System.Windows.Forms.Button()
        Me.ErrorTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorStatusLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ModeGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'DateAndTimeTextBox
        '
        Me.DateAndTimeTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAndTimeTextBox.Location = New System.Drawing.Point(12, 43)
        Me.DateAndTimeTextBox.Name = "DateAndTimeTextBox"
        Me.DateAndTimeTextBox.Size = New System.Drawing.Size(228, 43)
        Me.DateAndTimeTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room Temp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Current Mode"
        '
        'HighLabel
        '
        Me.HighLabel.AutoSize = True
        Me.HighLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighLabel.Location = New System.Drawing.Point(452, 359)
        Me.HighLabel.Name = "HighLabel"
        Me.HighLabel.Size = New System.Drawing.Size(116, 21)
        Me.HighLabel.TabIndex = 5
        Me.HighLabel.Text = "High Setpoint"
        '
        'RoomTextBox
        '
        Me.RoomTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTextBox.Location = New System.Drawing.Point(339, 295)
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.ReadOnly = True
        Me.RoomTextBox.Size = New System.Drawing.Size(154, 43)
        Me.RoomTextBox.TabIndex = 7
        '
        'ModeGroupBox
        '
        Me.ModeGroupBox.Controls.Add(Me.OffRadioButton)
        Me.ModeGroupBox.Controls.Add(Me.CoolingRadioButton)
        Me.ModeGroupBox.Controls.Add(Me.HeatingRadioButton)
        Me.ModeGroupBox.Location = New System.Drawing.Point(655, 43)
        Me.ModeGroupBox.Name = "ModeGroupBox"
        Me.ModeGroupBox.Size = New System.Drawing.Size(133, 98)
        Me.ModeGroupBox.TabIndex = 8
        Me.ModeGroupBox.TabStop = False
        '
        'OffRadioButton
        '
        Me.OffRadioButton.AutoSize = True
        Me.OffRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffRadioButton.Location = New System.Drawing.Point(22, 60)
        Me.OffRadioButton.Name = "OffRadioButton"
        Me.OffRadioButton.Size = New System.Drawing.Size(52, 25)
        Me.OffRadioButton.TabIndex = 2
        Me.OffRadioButton.TabStop = True
        Me.OffRadioButton.Text = "Off"
        Me.OffRadioButton.UseVisualStyleBackColor = True
        '
        'CoolingRadioButton
        '
        Me.CoolingRadioButton.AutoSize = True
        Me.CoolingRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolingRadioButton.Location = New System.Drawing.Point(22, 37)
        Me.CoolingRadioButton.Name = "CoolingRadioButton"
        Me.CoolingRadioButton.Size = New System.Drawing.Size(88, 25)
        Me.CoolingRadioButton.TabIndex = 1
        Me.CoolingRadioButton.TabStop = True
        Me.CoolingRadioButton.Text = "Cooling"
        Me.CoolingRadioButton.UseVisualStyleBackColor = True
        '
        'HeatingRadioButton
        '
        Me.HeatingRadioButton.AutoSize = True
        Me.HeatingRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatingRadioButton.Location = New System.Drawing.Point(22, 14)
        Me.HeatingRadioButton.Name = "HeatingRadioButton"
        Me.HeatingRadioButton.Size = New System.Drawing.Size(89, 25)
        Me.HeatingRadioButton.TabIndex = 0
        Me.HeatingRadioButton.TabStop = True
        Me.HeatingRadioButton.Text = "Heating"
        Me.HeatingRadioButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(672, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fan Mode"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AutoRadioButton)
        Me.GroupBox1.Controls.Add(Me.FanOnRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(655, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'AutoRadioButton
        '
        Me.AutoRadioButton.AutoSize = True
        Me.AutoRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoRadioButton.Location = New System.Drawing.Point(22, 37)
        Me.AutoRadioButton.Name = "AutoRadioButton"
        Me.AutoRadioButton.Size = New System.Drawing.Size(65, 25)
        Me.AutoRadioButton.TabIndex = 1
        Me.AutoRadioButton.TabStop = True
        Me.AutoRadioButton.Text = "Auto"
        Me.AutoRadioButton.UseVisualStyleBackColor = True
        '
        'FanOnRadioButton
        '
        Me.FanOnRadioButton.AutoSize = True
        Me.FanOnRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FanOnRadioButton.Location = New System.Drawing.Point(22, 14)
        Me.FanOnRadioButton.Name = "FanOnRadioButton"
        Me.FanOnRadioButton.Size = New System.Drawing.Size(50, 25)
        Me.FanOnRadioButton.TabIndex = 0
        Me.FanOnRadioButton.TabStop = True
        Me.FanOnRadioButton.Text = "On"
        Me.FanOnRadioButton.UseVisualStyleBackColor = True
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(645, 262)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(154, 43)
        Me.StatusTextBox.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(675, 349)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'PortSelectLabel
        '
        Me.PortSelectLabel.AutoSize = True
        Me.PortSelectLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortSelectLabel.Location = New System.Drawing.Point(700, 320)
        Me.PortSelectLabel.Name = "PortSelectLabel"
        Me.PortSelectLabel.Size = New System.Drawing.Size(88, 21)
        Me.PortSelectLabel.TabIndex = 12
        Me.PortSelectLabel.Text = "PortSelect"
        '
        'ComStatusTextBox
        '
        Me.ComStatusTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComStatusTextBox.Location = New System.Drawing.Point(642, 401)
        Me.ComStatusTextBox.Name = "ComStatusTextBox"
        Me.ComStatusTextBox.ReadOnly = True
        Me.ComStatusTextBox.Size = New System.Drawing.Size(154, 43)
        Me.ComStatusTextBox.TabIndex = 13
        '
        'ComStatusLabel
        '
        Me.ComStatusLabel.AutoSize = True
        Me.ComStatusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComStatusLabel.Location = New System.Drawing.Point(731, 377)
        Me.ComStatusLabel.Name = "ComStatusLabel"
        Me.ComStatusLabel.Size = New System.Drawing.Size(57, 21)
        Me.ComStatusLabel.TabIndex = 14
        Me.ComStatusLabel.Text = "Status"
        '
        'MachineTextBox
        '
        Me.MachineTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineTextBox.Location = New System.Drawing.Point(337, 191)
        Me.MachineTextBox.Name = "MachineTextBox"
        Me.MachineTextBox.ReadOnly = True
        Me.MachineTextBox.Size = New System.Drawing.Size(154, 43)
        Me.MachineTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(337, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 30)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Machine Temp"
        '
        'HighTextBox
        '
        Me.HighTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighTextBox.Location = New System.Drawing.Point(484, 386)
        Me.HighTextBox.Name = "HighTextBox"
        Me.HighTextBox.ReadOnly = True
        Me.HighTextBox.Size = New System.Drawing.Size(51, 25)
        Me.HighTextBox.TabIndex = 18
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(17, 401)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 33)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'LowTextBox
        '
        Me.LowTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowTextBox.Location = New System.Drawing.Point(291, 386)
        Me.LowTextBox.Name = "LowTextBox"
        Me.LowTextBox.ReadOnly = True
        Me.LowTextBox.Size = New System.Drawing.Size(51, 25)
        Me.LowTextBox.TabIndex = 21
        '
        'LowLabel
        '
        Me.LowLabel.AutoSize = True
        Me.LowLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowLabel.Location = New System.Drawing.Point(256, 359)
        Me.LowLabel.Name = "LowLabel"
        Me.LowLabel.Size = New System.Drawing.Size(110, 21)
        Me.LowLabel.TabIndex = 20
        Me.LowLabel.Text = "Low Setpoint"
        '
        'HighDownButton
        '
        Me.HighDownButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HighDownButton.Location = New System.Drawing.Point(466, 417)
        Me.HighDownButton.Name = "HighDownButton"
        Me.HighDownButton.Size = New System.Drawing.Size(38, 23)
        Me.HighDownButton.TabIndex = 22
        Me.HighDownButton.Text = "<"
        Me.HighDownButton.UseVisualStyleBackColor = False
        '
        'HighUpButton
        '
        Me.HighUpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HighUpButton.Location = New System.Drawing.Point(519, 417)
        Me.HighUpButton.Name = "HighUpButton"
        Me.HighUpButton.Size = New System.Drawing.Size(38, 23)
        Me.HighUpButton.TabIndex = 23
        Me.HighUpButton.Text = ">"
        Me.HighUpButton.UseVisualStyleBackColor = False
        '
        'LowUpButton
        '
        Me.LowUpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LowUpButton.Location = New System.Drawing.Point(322, 417)
        Me.LowUpButton.Name = "LowUpButton"
        Me.LowUpButton.Size = New System.Drawing.Size(38, 23)
        Me.LowUpButton.TabIndex = 25
        Me.LowUpButton.Text = ">"
        Me.LowUpButton.UseVisualStyleBackColor = False
        '
        'LowDownButton
        '
        Me.LowDownButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LowDownButton.Location = New System.Drawing.Point(269, 417)
        Me.LowDownButton.Name = "LowDownButton"
        Me.LowDownButton.Size = New System.Drawing.Size(38, 23)
        Me.LowDownButton.TabIndex = 24
        Me.LowDownButton.Text = "<"
        Me.LowDownButton.UseVisualStyleBackColor = False
        '
        'ErrorTextBox
        '
        Me.ErrorTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorTextBox.Location = New System.Drawing.Point(12, 191)
        Me.ErrorTextBox.Name = "ErrorTextBox"
        Me.ErrorTextBox.ReadOnly = True
        Me.ErrorTextBox.Size = New System.Drawing.Size(172, 25)
        Me.ErrorTextBox.TabIndex = 26
        '
        'ErrorStatusLabel
        '
        Me.ErrorStatusLabel.AutoSize = True
        Me.ErrorStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorStatusLabel.Location = New System.Drawing.Point(14, 171)
        Me.ErrorStatusLabel.Name = "ErrorStatusLabel"
        Me.ErrorStatusLabel.Size = New System.Drawing.Size(80, 17)
        Me.ErrorStatusLabel.TabIndex = 27
        Me.ErrorStatusLabel.Text = "Error Status"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 10
        '
        'HVAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 456)
        Me.Controls.Add(Me.ErrorStatusLabel)
        Me.Controls.Add(Me.ErrorTextBox)
        Me.Controls.Add(Me.LowUpButton)
        Me.Controls.Add(Me.LowDownButton)
        Me.Controls.Add(Me.HighUpButton)
        Me.Controls.Add(Me.HighDownButton)
        Me.Controls.Add(Me.LowTextBox)
        Me.Controls.Add(Me.LowLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HighTextBox)
        Me.Controls.Add(Me.MachineTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComStatusLabel)
        Me.Controls.Add(Me.ComStatusTextBox)
        Me.Controls.Add(Me.PortSelectLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ModeGroupBox)
        Me.Controls.Add(Me.RoomTextBox)
        Me.Controls.Add(Me.HighLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateAndTimeTextBox)
        Me.Name = "HVAC"
        Me.Text = "HVAC"
        Me.ModeGroupBox.ResumeLayout(False)
        Me.ModeGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateAndTimeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HighLabel As Label
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents ModeGroupBox As GroupBox
    Friend WithEvents HeatingRadioButton As RadioButton
    Friend WithEvents OffRadioButton As RadioButton
    Friend WithEvents CoolingRadioButton As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AutoRadioButton As RadioButton
    Friend WithEvents FanOnRadioButton As RadioButton
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PortSelectLabel As Label
    Friend WithEvents ComStatusTextBox As TextBox
    Friend WithEvents ComStatusLabel As Label
    Friend WithEvents MachineTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents HighTextBox As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ExitButton As Button
    Friend WithEvents LowTextBox As TextBox
    Friend WithEvents LowLabel As Label
    Friend WithEvents HighDownButton As Button
    Friend WithEvents HighUpButton As Button
    Friend WithEvents LowUpButton As Button
    Friend WithEvents LowDownButton As Button
    Friend WithEvents ErrorTextBox As TextBox
    Friend WithEvents ErrorStatusLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
