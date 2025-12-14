'Payden Hoskins
'Fall 2025
'RCET3371
'HVAC_System
'https://github.com/PaydenHoskins/CircuitSolver.git

Option Explicit On
Option Strict On

Imports System.IO.Ports
Imports System.Net.Security

Public Class HVAC
    ' ISU Color Palette
    Public GrowlGreyLight As Color = Color.FromArgb(230, 231, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)

    Public Buttons As String
    Public Array(7) As String

    Sub Connect()

        SerialPort1.Close()
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        Try
            If ComboBox1.Items.Count = 0 Then
                MsgBox("Select a valid COM port", MsgBoxStyle.Critical)

            ElseIf ComboBox1.SelectedItem.ToString Is Nothing Then
                MsgBox("Select a valid COM port", MsgBoxStyle.Critical)

            ElseIf ComboBox1.SelectedItem.ToString <> Nothing Then
                SerialPort1.PortName = ComboBox1.SelectedItem.ToString

            End If
        Catch ex As Exception
            MsgBox("Select a valid COM port", MsgBoxStyle.Critical)
        End Try
        Try
            SerialPort1.Open()
            ComStatusTextBox.Text = "Connected"
        Catch ex As Exception

        End Try

    End Sub

    Public Function ByteToBinary(ByVal b As Byte) As String()
        ' Create an 8-character binary string, MSB..LSB
        Dim bin As String = Convert.ToString(b, 2).PadLeft(8, "0"c)

        ' Prepare an array where index 0 = LSB (bit0) ... index 7 = MSB (bit7)
        Dim bits(7) As String
        For i As Integer = 0 To 7
            ' bin(0) is MSB, bin(7) is LSB; reverse so bits(0) == LSB
            bits(i) = bin(7 - i).ToString()
        Next

        ' Store into the class-level Array field for existing code that reads Array(0) etc.
        Me.Array = bits

        Return bits
    End Function

    Private Sub HVAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LowTextBox.Text = $"{50}°F"
        HighTextBox.Text = $"{90}°F"
        AutoRadioButton.Checked = True
        OffRadioButton.Checked = True
        ComStatusTextBox.Text = "Disconnected"
        ComboBox1.Items.Clear()
        For port = 0 To SerialPort.GetPortNames.Length - 1
            ComboBox1.Items.Add(SerialPort.GetPortNames()(port))
        Next
        Try
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception

        End Try

        Connect()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data(1) As Byte 'put bytes into array
        Dim writeData(0) As Byte 'put bytes into array
        Dim aWhile1$ = "0"
        Dim aWhile$ = "0"
        Dim Value(3) As Integer
        Dim roomTempStr$
        Dim roomTempDbl#
        Dim highTempStr$
        Dim highTempDbl#
        Dim lowTempStr$
        Dim lowTempDbl#
        Dim machineTempStr$
        Dim machineTempDbl#
        Dim caseSet As Boolean = False

        If Array(3) = "0" Then
            StatusTextBox.Text = "Off"
            OffRadioButton.Checked = True
            ErrorTextBox.Text = "No Error"
        Else
            Select Case Array(0)
                Case "1"

                    caseSet = False
                Case "0"
                    StatusTextBox.Text = "Off"
                    OffRadioButton.Checked = True
                    ErrorTextBox.Text = "No Error"
                    caseSet = True
            End Select

            If caseSet = True Then
            Else
                Select Case Array(1)
                    Case "1"

                        caseSet = False
                    Case "0"
                        StatusTextBox.Text = "On"
                        HeatingRadioButton.Checked = True
                        caseSet = True
                End Select
            End If

            If caseSet = True Then
            Else
                Select Case Array(2)
                    Case "1"

                        caseSet = False
                    Case "0"
                        FanOnRadioButton.Checked = True
                        roomTempStr = Replace(RoomTextBox.Text, "°F", "")
                        roomTempDbl = CDbl(roomTempStr)

                        machineTempStr = Replace(MachineTextBox.Text, "°F", "")
                        machineTempDbl = CDbl(machineTempStr)

                        highTempStr = Replace(HighTextBox.Text, "°F", "")
                        highTempDbl = CDbl(highTempStr)

                        lowTempStr = Replace(LowTextBox.Text, "°F", "")
                        lowTempDbl = CDbl(lowTempStr)

                        If roomTempDbl > highTempDbl Then
                            StatusTextBox.Text = "On"
                            CoolingRadioButton.Checked = True
                            If machineTempDbl < roomTempDbl Then
                                ErrorTextBox.Text = "No Error"
                            ElseIf machineTempDbl > roomTempDbl Then
                                ErrorTextBox.Text = "Error: High Machine Temp"
                            End If

                        ElseIf roomTempDbl < lowTempDbl Then
                            StatusTextBox.Text = "On"
                            HeatingRadioButton.Checked = True
                            If machineTempDbl > roomTempDbl Then
                                ErrorTextBox.Text = "No Error"
                            ElseIf machineTempDbl < roomTempDbl Then
                                ErrorTextBox.Text = "Error: Low Machine Temp"
                            End If


                        ElseIf roomTempDbl < highTempDbl - 2 And roomTempDbl > lowTempDbl + 2 Then
                            StatusTextBox.Text = "On"
                            OffRadioButton.Checked = True
                            ErrorTextBox.Text = "No Error"
                        End If
                        caseSet = True
                End Select
            End If

            If caseSet = True Then
            Else
                Select Case Array(4)
                    Case "1"

                        caseSet = False
                    Case "0"
                        StatusTextBox.Text = "On"
                        CoolingRadioButton.Checked = True
                        ErrorTextBox.Text = "No Error"
                        caseSet = True
                End Select
            End If

            If Array(0) = "1" And Array(1) = "1" And Array(2) = "1" And Array(2) = "1" And Array(4) = "1" Then
                AutoRadioButton.Checked = True
                roomTempStr = Replace(RoomTextBox.Text, "°F", "")
                roomTempDbl = CDbl(roomTempStr)

                machineTempStr = Replace(MachineTextBox.Text, "°F", "")
                machineTempDbl = CDbl(machineTempStr)

                highTempStr = Replace(HighTextBox.Text, "°F", "")
                highTempDbl = CDbl(highTempStr)

                lowTempStr = Replace(LowTextBox.Text, "°F", "")
                lowTempDbl = CDbl(lowTempStr)

                If roomTempDbl > highTempDbl Then
                    StatusTextBox.Text = "On"
                    CoolingRadioButton.Checked = True
                    If machineTempDbl < roomTempDbl Then
                        ErrorTextBox.Text = "No Error"
                    ElseIf machineTempDbl > roomTempDbl Then
                        ErrorTextBox.Text = "Error: High Machine Temp"
                    End If

                ElseIf roomTempDbl < lowTempDbl Then
                    StatusTextBox.Text = "On"
                    HeatingRadioButton.Checked = True
                    If machineTempDbl > roomTempDbl Then
                        ErrorTextBox.Text = "No Error"
                    ElseIf machineTempDbl < roomTempDbl Then
                        ErrorTextBox.Text = "Error: Low Machine Temp"
                    End If


                ElseIf roomTempDbl < highTempDbl - 2 And roomTempDbl > lowTempDbl + 2 Then
                    StatusTextBox.Text = "Off"
                    OffRadioButton.Checked = True
                    ErrorTextBox.Text = "No Error"
                End If
                caseSet = False
            End If
        End If


        DateAndTimeTextBox.Text = DateAndTime.Now.ToString("hh:mm:ss tt")
        'y position
        data(0) = &H53 'actual data as byte
        data(1) = &H30 'actual data as byte
        Try
            SerialPort1.Write(data, 0, 1)
            SerialPort1.Write(data, 1, 1)
        Catch ex As Exception
            Timer1.Stop()
            ComStatusTextBox.Text = "Disconnected"
            MsgBox("No COM ports found.", MsgBoxStyle.Exclamation)

            Do Until ComboBox1 IsNot Nothing AndAlso ComboBox1.Items.Count > 0
                ComboBox1.Items.Clear()
                For port = 0 To SerialPort.GetPortNames.Length - 1
                    ComboBox1.Items.Add(SerialPort.GetPortNames()(port))
                Next
            Loop

            ComboBox1.SelectedIndex = 0
            Connect()
            ComStatusTextBox.Text = "Connected"
            Timer1.Start()
        End Try


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub LowUpButton_Click(sender As Object, e As EventArgs) Handles LowUpButton.Click
        Dim temp$
        Dim temp2$
        Dim compare#
        Dim compare2#

        temp = Replace(LowTextBox.Text, "°F", "")
        temp2 = Replace(HighTextBox.Text, "°F", "")
        compare = CDbl(temp)
        compare2 = CDbl(temp2)


        If compare = compare2 Then
            LowTextBox.Text = $"{compare - 0.5}°F"
        ElseIf compare = compare2 - 0.5 Then
            LowTextBox.Text = $"{compare}°F"
        ElseIf compare >= 89.5 Then
            LowTextBox.Text = $"{89.5}°F"
        ElseIf compare < 89.5 Then
            LowTextBox.Text = $"{compare + 0.5}°F"
        End If
    End Sub

    Private Sub LowDownButton_Click(sender As Object, e As EventArgs) Handles LowDownButton.Click
        Dim temp$
        Dim compare#

        temp = Replace(LowTextBox.Text, "°F", "")
        compare = CDbl(temp)

        If compare <= 50 Then
            LowTextBox.Text = $"{50}°F"
        ElseIf compare > 50 Then
            LowTextBox.Text = $"{compare - 0.5}°F"
        End If
    End Sub

    Private Sub HighUpButton_Click(sender As Object, e As EventArgs) Handles HighUpButton.Click
        Dim temp$
        Dim compare#

        temp = Replace(HighTextBox.Text, "°F", "")
        compare = CDbl(temp)

        If compare >= 90 Then
            HighTextBox.Text = $"{90}°F"
        ElseIf compare < 90 Then
            HighTextBox.Text = $"{compare + 0.5}°F"
        End If
    End Sub

    Private Sub HighDownButton_Click(sender As Object, e As EventArgs) Handles HighDownButton.Click
        Dim temp$
        Dim temp2$
        Dim compare#
        Dim compare2#

        temp = Replace(HighTextBox.Text, "°F", "")
        temp2 = Replace(LowTextBox.Text, "°F", "")
        compare = CDbl(temp)
        compare2 = CDbl(temp2)

        compare = CDbl(temp)
        If compare = compare2 Then
            HighTextBox.Text = $"{compare + 0.5}°F"
        ElseIf compare = compare2 + 0.5 Then
            HighTextBox.Text = $"{compare}°F"
        ElseIf compare <= 50.5 Then
            HighTextBox.Text = $"{50.5}°F"
        ElseIf compare > 50.5 Then
            HighTextBox.Text = $"{compare - 0.5}°F"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim roomTempStr$
        Dim roomTempDbl#
        Dim highTempStr$
        Dim highTempDbl#
        Dim lowTempStr$
        Dim lowTempDbl#
        Dim machineTempStr$
        Dim machineTempDbl#

        roomTempStr = Replace(RoomTextBox.Text, "°F", "")
            roomTempDbl = CDbl(roomTempStr)

            machineTempStr = Replace(MachineTextBox.Text, "°F", "")
            machineTempDbl = CDbl(machineTempStr)

            highTempStr = Replace(HighTextBox.Text, "°F", "")
            highTempDbl = CDbl(highTempStr)

            lowTempStr = Replace(LowTextBox.Text, "°F", "")
            lowTempDbl = CDbl(lowTempStr)

            If roomTempDbl > highTempDbl Then
                StatusTextBox.Text = "On"
                CoolingRadioButton.Checked = True
                If machineTempDbl < roomTempDbl Then
                    ErrorTextBox.Text = "No Error"
                ElseIf machineTempDbl > roomTempDbl Then
                    ErrorTextBox.Text = "Error: High Machine Temp"
                    FileOpen(1, "HVACSystem-YYmmDD.log", OpenMode.Append)
                    WriteLine(1, $"Error: High Machine Temp {DateAndTime.Now.ToString("yy:MM:dd-HH:mm:ss")}")
                    FileClose(1)
                End If

            ElseIf roomTempDbl < lowTempDbl Then
                StatusTextBox.Text = "On"
                HeatingRadioButton.Checked = True
                If machineTempDbl > roomTempDbl Then
                    ErrorTextBox.Text = "No Error"
                ElseIf machineTempDbl < roomTempDbl Then
                    ErrorTextBox.Text = "Error: Low Machine Temp"
                    FileOpen(1, "HVACSystem-YYmmDD.log", OpenMode.Append)
                    WriteLine(1, $"Error: Low Machine Temp {DateAndTime.Now.ToString("yy:MM:dd-HH:mm:ss")}")
                    FileClose(1)
                End If


            ElseIf roomTempDbl < highTempDbl - 2 And roomTempDbl > lowTempDbl + 2 Then
                StatusTextBox.Text = "Off"
                OffRadioButton.Checked = True
                ErrorTextBox.Text = "No Error"
            End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        Dim buffer(numberOfBytes - 1) As Byte
        Dim got% = SerialPort1.Read(buffer, 0, numberOfBytes)
        Static roomTemp#
        Static machineTemp#
        Static buttonsPressed%
        Dim Temp1%
        Dim Temp2%

        If got > 0 Then
            If buffer.Length >= 5 Then
                Temp1 = CInt((buffer(0)) * 4)
                Temp2 = CInt((buffer(1)) / 64)
                machineTemp = (Temp1 + Temp2)
                Temp1 = CInt((buffer(2)) * 4)
                Temp2 = CInt((buffer(3)) / 64)
                roomTemp = (Temp1 + Temp2)
                buttonsPressed = CInt(buffer(4))
                Buttons = $"{ByteToBinary(buffer(4))}"
                RoomTextBox.Text = CDec(($"{((60 / 1023) * (roomTemp)) + 40}")).ToString("000.00°F")
                MachineTextBox.Text = CDec(($"{((60 / 1023) * (machineTemp)) + 40}")).ToString("000.00°F")
            End If
        End If


    End Sub

End Class
