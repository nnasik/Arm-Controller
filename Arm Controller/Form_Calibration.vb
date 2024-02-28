Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Runtime.Serialization

Public Class Form_Calibration
    Dim angle_1, angle_2, angle_3, angle_4, angle_5, angle_6 As Integer
    Dim WithEvents ActiveSerialPort As New IO.Ports.SerialPort

    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        angle_6 = TrackBar6.Value
        Text_angle6.Text = angle_6
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        angle_4 = TrackBar4.Value
        Text_angle4.Text = angle_4
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        angle_3 = TrackBar3.Value
        Text_angle3.Text = angle_3
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        angle_2 = TrackBar2.Value
        Text_angle2.Text = angle_2
    End Sub

    Private Sub Text_angle6_TextChanged(sender As Object, e As EventArgs) Handles Text_angle6.TextChanged
        TrackBar6.Value = Val(Text_angle6.Text)
    End Sub

    Private Sub Text_angle5_TextChanged(sender As Object, e As EventArgs) Handles Text_angle5.TextChanged
        TrackBar5.Value = Val(Text_angle5.Text)
    End Sub

    Private Sub Text_angle4_TextChanged(sender As Object, e As EventArgs) Handles Text_angle4.TextChanged
        TrackBar4.Value = Val(Text_angle4.Text)
    End Sub

    Private Sub Text_angle3_TextChanged(sender As Object, e As EventArgs) Handles Text_angle3.TextChanged
        TrackBar3.Value = Val(Text_angle3.Text)
    End Sub

    Private Sub Text_angle2_TextChanged(sender As Object, e As EventArgs) Handles Text_angle2.TextChanged
        TrackBar2.Value = Val(Text_angle2.Text)
    End Sub

    Private Sub Text_angle1_TextChanged(sender As Object, e As EventArgs) Handles Text_angle1.TextChanged
        TrackBar1.Value = Val(Text_angle1.Text)
    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        Try
            ActiveSerialPort.BaudRate = Val(ComboBox_Baudrate.SelectedItem.ToString)
            ActiveSerialPort.PortName = ComboBox_Serial.SelectedItem
            ActiveSerialPort.Open()
        Catch
            ActiveSerialPort.Close()
        End Try
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        angle_5 = TrackBar5.Value
        Text_angle5.Text = angle_5
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        angle_1 = TrackBar1.Value
        Text_angle1.Text = angle_1
    End Sub

    Private Sub Form_Calibration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AvailablePorts() As String = SerialPort.GetPortNames()
        For Each Port In AvailablePorts
            ComboBox_Serial.Items.Add(Port.ToString)
        Next
    End Sub

    Private Sub ComboBox_Serial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Serial.SelectedIndexChanged
        ComboBox_Baudrate.SelectedItem = "9600"
    End Sub

    Private Sub SendSerial()
        If ActiveSerialPort.IsOpen Then

        End If
    End Sub

    Private Sub OpenSerial()

    End Sub

    Private Sub CloseSerial()

    End Sub
End Class