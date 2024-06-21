Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Net.Sockets
Imports System.Runtime.InteropServices.ComTypes
Imports System.Text
Public Class frm_bottle_handle

    Dim WithEvents ActiveSerialPort As New IO.Ports.SerialPort
    Dim p1
    Dim p2

    Private Sub frm_bottle_handle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p1 = Process.Start("cmd", "/k py C:\py\pose\work.py")
        p2 = Process.Start("cmd", "/k py C:\py\pose\ikin.py")
        Dim AvailablePorts() As String = SerialPort.GetPortNames()
        For Each Port In AvailablePorts
            ComboBox_Serial.Items.Add(Port.ToString)
        Next
        ComboBox_Baudrate.SelectedItem = "9600"
        Me.BringToFront()


    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ActiveSerialPort.DataReceived
        ' Read the data from the serial port
        Dim data As String = ActiveSerialPort.ReadLine()

        ' Update the textbox with the received data
        UpdateTextBox(data)
    End Sub
    Private Sub UpdateTextBox(data As String)
        ' InvokeRequired compares the thread ID of the calling thread to the thread ID of the creating thread
        ' If these threads are different, it returns true
        If Me.txt_serial.InvokeRequired Then
            Dim d As New Action(Of String)(AddressOf UpdateTextBox)
            Me.Invoke(d, New Object() {data})
        Else

            'Me.TextBox_Serial.AppendText(data & Environment.NewLine)
            Me.txt_serial.AppendText(data + vbNewLine)
        End If
    End Sub
    Private Sub OpenSerial()
        Try
            ActiveSerialPort.BaudRate = Val(ComboBox_Baudrate.SelectedItem.ToString)
            ActiveSerialPort.PortName = ComboBox_Serial.SelectedItem
            ActiveSerialPort.Open()
        Catch
            ActiveSerialPort.Close()
        End Try
    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        If Button_Connect.Tag = "Connect" And Not ActiveSerialPort.IsOpen Then
            OpenSerial()
            If ActiveSerialPort.IsOpen Then
                Button_Connect.Tag = "Disconnect"
                Button_Connect.Text = "Disconnect"
                ComboBox_Serial.Enabled = False
                ComboBox_Baudrate.Enabled = False
            End If
        ElseIf Button_Connect.Tag = "Disconnect" And ActiveSerialPort.IsOpen Then
            CloseSerial()
            If Not ActiveSerialPort.IsOpen Then
                Button_Connect.Tag = "Connect"
                Button_Connect.Text = "Connect"
                ComboBox_Serial.Enabled = True
                ComboBox_Baudrate.Enabled = True
            End If
        End If
    End Sub
    Private Sub CloseSerial()
        ActiveSerialPort.Close()
    End Sub

    Private Sub SendSerial(payload As String)
        If ActiveSerialPort.IsOpen Then
            Try
                ActiveSerialPort.WriteLine(payload)       ' Write data to the send buffer
            Catch ex As Exception           ' Exception handling            
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Dim line As String()

    Private Sub btn_execute_Click(sender As Object, e As EventArgs) Handles btn_execute.Click
        SendSerial(txt_j_code.Text)
        txt_j_code.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txt_j_code.Text.Length > 1 Then
            btn_execute.PerformClick()
        End If
    End Sub


    'Private BackgroundWorker1 As New BackgroundWorker()

    Private image_process_client As TcpClient
    Private image_process_stream As NetworkStream


    Private Sub btn_connect_image_process_Click(sender As Object, e As EventArgs) Handles btn_connect_image_process.Click
        If btn_connect_image_process.Tag = "Connect" Then
            If Not BackgroundWorker1.IsBusy Then
                BackgroundWorker1.RunWorkerAsync()
                disable_image_process_connect()
            End If
        ElseIf btn_connect_image_process.Tag = "Disconnect" Then
            If image_process_client IsNot Nothing Then
                image_process_stream.Close()
            End If

            If image_process_client IsNot Nothing Then
                image_process_client.Close()
            End If
            btn_connect_image_process.Text = "Connect"
            btn_connect_image_process.Tag = "Connect"
        End If

    End Sub

    Private Sub frm_bottle_handle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If image_process_stream IsNot Nothing Then
            image_process_stream.Close()
        End If

        If image_process_client IsNot Nothing Then
            image_process_client.Close()
        End If
        p1.kill()
        p2.kill()
        Form1.Show()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            ' Connect to the server
            ' client = New TcpClient("localhost", 12345)
            image_process_client = New TcpClient(txt_image_process_host.Text, Val(txt_image_process_port.Text))
            image_process_stream = image_process_client.GetStream()

            ' Start receiving data
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer

            Do
                bytesRead = image_process_stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then
                    ' Server closed the connection
                    Exit Do
                End If

                Dim data As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                ' Call the HandleReceivedData method with the received data
                BeginInvoke(New Action(Of String)(AddressOf HandleReceivedData), data)
            Loop

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
            enable_image_process_connect()
        ElseIf e.Cancelled Then
            MessageBox.Show("Operation cancelled.")
            enable_image_process_connect()
        ElseIf e.Result Is Nothing Then
            MessageBox.Show("No data received from the server.")
            enable_image_process_connect()
        Else
            Dim data As String = TryCast(e.Result, String)
            If data IsNot Nothing Then
                txt_image_process.AppendText(Environment.NewLine + data)

            End If
        End If
    End Sub

    Private Sub HandleReceivedData(data As String)
        ' Display the received data in the TextBox
        txt_image_process.AppendText(Environment.NewLine + data)
        If Not data = "Connection Established to Pose Detection" And Not data = Environment.NewLine Then
            list_fallen_data.Items.Add(data)
        End If
    End Sub

    Private Sub HandleReceivedData_ikin(data As String)
        ' Display the received data in the TextBox
        txt_j_code.AppendText(data)
    End Sub

    Private Sub disable_image_process_connect()
        txt_image_process_host.Enabled = False
        txt_image_process_port.Enabled = False
        btn_connect_image_process.Text = "Disconnect"
        btn_connect_image_process.Tag = "Disconnect"
    End Sub
    Private Sub enable_image_process_connect()
        txt_image_process_host.Enabled = True
        txt_image_process_port.Enabled = True
        btn_connect_image_process.Text = "Connect"
        btn_connect_image_process.Tag = "Connect"
    End Sub


    Private ik_client As TcpClient
    Private ik_stream As NetworkStream

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            ' Connect to the server
            ' client = New TcpClient("localhost", 12345)
            ik_client = New TcpClient(txt_ik_host.Text, Val(txt_ik_port.Text))
            ik_stream = ik_client.GetStream()

            ' Start receiving data
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer

            Do
                bytesRead = ik_stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then
                    ' Server closed the connection
                    Exit Do
                End If

                Dim data As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                ' Call the HandleReceivedData method with the received data
                BeginInvoke(New Action(Of String)(AddressOf HandleReceivedData_ikin), data)
            Loop

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub disable_ik_connect()
        txt_ik_host.Enabled = False
        txt_ik_port.Enabled = False
        btn_connect_ik.Text = "Disconnect"
        btn_connect_ik.Tag = "Disconnect"
    End Sub
    Private Sub enable_ik_connect()
        txt_ik_host.Enabled = True
        txt_ik_port.Enabled = True
        btn_connect_ik.Text = "Connect"
        btn_connect_ik.Tag = "Connect"
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
            enable_ik_connect()
        ElseIf e.Cancelled Then
            MessageBox.Show("Operation cancelled.")
            enable_ik_connect()
        ElseIf e.Result Is Nothing Then
            MessageBox.Show("No data received from the server.")
            enable_ik_connect()
        Else
            Dim data As String = TryCast(e.Result, String)
            If data IsNot Nothing Then
                txt_inverse_kinematics.AppendText(Environment.NewLine + data)
            End If
        End If
    End Sub

    Private Sub btn_connect_ik_Click(sender As Object, e As EventArgs) Handles btn_connect_ik.Click
        If btn_connect_ik.Tag = "Connect" Then
            If Not BackgroundWorker2.IsBusy Then
                BackgroundWorker2.RunWorkerAsync()
                disable_ik_connect()
            End If
        ElseIf btn_connect_ik.Tag = "Disconnect" Then
            If ik_client IsNot Nothing Then
                ik_stream.Close()
            End If

            If ik_client IsNot Nothing Then
                ik_client.Close()
            End If
            enable_ik_connect()
        End If
    End Sub

    Private Sub btn_auto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_auto_ip_Click(sender As Object, e As EventArgs) Handles btn_auto_ip.Click
        If btn_auto_ip.Tag = "-" Then
            pic_ip.Image = My.Resources.connect_4
            btn_auto_ip.Text = "|"
            btn_auto_ip.Tag = "|"
            btn_auto_ip.ForeColor = Color.DarkCyan
            Timer2.Enabled = True

        ElseIf btn_auto_ip.Tag = "|" Then
            pic_ip.Image = My.Resources.connect_3
            btn_auto_ip.Text = "-"
            btn_auto_ip.Tag = "-"
            btn_auto_ip.ForeColor = Color.Black
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub btn_auto_ikin_Click(sender As Object, e As EventArgs) Handles btn_auto_ikin.Click
        If btn_auto_ikin.Tag = "-" Then
            pic_ikin.Image = My.Resources.connect_4
            btn_auto_ikin.Text = "|"
            btn_auto_ikin.Tag = "|"
            btn_auto_ikin.ForeColor = Color.DarkCyan
            Timer1.Enabled = True
        ElseIf btn_auto_ikin.Tag = "|" Then
            pic_ikin.Image = My.Resources.connect_3
            btn_auto_ikin.Text = "-"
            btn_auto_ikin.Tag = "-"
            btn_auto_ikin.ForeColor = Color.Black
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If list_fallen_data.Items.Count > 0 Then
            SendData_ik(list_fallen_data.Items(0).ToString)
            list_fallen_data.Items.RemoveAt(0)
            txt_inverse_kinematics.AppendText("Sending : " + txt_image_process.Lines.Last() + vbNewLine)
        End If
    End Sub

    Private Sub SendData_ik(data As String)
        If ik_client IsNot Nothing AndAlso ik_client.Connected AndAlso ik_stream IsNot Nothing Then
            Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
            ik_stream.Write(buffer, 0, buffer.Length)
            ik_stream.Flush()
        Else
            MessageBox.Show("Connection is not established.")
        End If
    End Sub
End Class