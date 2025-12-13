Option Explicit On
Option Strict On

Imports System.IO.Ports

Public Class HVAC
    ' ISU Color Palette
    Public GrowlGreyLight As Color = Color.FromArgb(230, 231, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)

    Sub Connect()

        SerialPort1.Close()
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        Try
            If ComboBox1.SelectedItem.ToString Is Nothing Then
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

    Private Sub HVAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LowTextBox.Text = $"{50}°F"
        HighTextBox.Text = $"{90}°F"
        ComStatusTextBox.Text = "Disconnected"
        ComboBox1.Items.Clear()
        For port = 0 To SerialPort.GetPortNames.Length - 1
            ComboBox1.Items.Add(SerialPort.GetPortNames()(port))
        Next
        ComboBox1.SelectedIndex = 0
        Connect()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data(0) As Byte 'put bytes into array
        Dim writeData(0) As Byte 'put bytes into array
        Dim wait%
        Dim aWhile1$ = "0"
        Dim aWhile$ = "0"
        Dim Value(3) As Integer
        Dim newX%
        Dim newY%
        Static oldX, oldY As Integer
        Try
            DateAndTimeTextBox.Text = DateAndTime.Now.ToString("hh:mm:ss tt")
            'y position
            data(0) = &H51 'actual data as byte
            SerialPort1.Write(data, 0, 1)

            Do Until aWhile IsNot "0" Or aWhile1 IsNot "0"
                Dim ADC(SerialPort1.BytesToRead) As Byte
                Try
                    SerialPort1.Read(ADC, 0, SerialPort1.BytesToRead)
                    aWhile = CStr(ADC(1))
                    aWhile1 = CStr(ADC(0))
                    Value(0) = ADC(0)
                    Value(1) = ADC(1)
                Catch ex As Exception

                End Try
                wait += 1
                If wait = 1000 Then
                    newY = CInt(0)
                    Exit Do
                End If
            Loop

            Try
                newY = CInt((Value(0) * 4) + (Value(1) / 64))
            Catch ex As Exception
                MsgBox("Bad Data.")
            End Try
            aWhile = "0"
            aWhile1 = "0"
            'x position
            data(0) = &H52 'actual data as byte
            SerialPort1.Write(data, 0, 1)

            Do Until aWhile IsNot "0" Or aWhile1 IsNot "0"
                Dim ADC2(SerialPort1.BytesToRead) As Byte
                Try
                    SerialPort1.Read(ADC2, 0, SerialPort1.BytesToRead)
                    aWhile = CStr(ADC2(1))
                    aWhile1 = CStr(ADC2(0))
                    Value(2) = ADC2(0)
                    Value(3) = ADC2(1)
                Catch ex As Exception

                End Try
                wait += 1
                If wait = 1000 Then
                    newX = CInt(0)
                    Exit Do
                End If
            Loop

            Try
                newX = CInt((Value(2) * 4) + (Value(3) / 64))
                Me.Text = CStr($"{newX},{newY}")

            Catch ex As Exception
                MsgBox("Bad Data.")
            End Try

            RoomTextBox.Text = ($"{((60 / 1023) * (newX)) + 40}")
            MachineTextBox.Text = ($"{((60 / 1023) * (newY)) + 40}")

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

End Class
