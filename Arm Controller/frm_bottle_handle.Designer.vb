<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bottle_handle
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
        Me.txt_j_code = New System.Windows.Forms.TextBox()
        Me.btn_execute = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.ComboBox_Baudrate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_Serial = New System.Windows.Forms.ComboBox()
        Me.txt_serial = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.list_fallen_data = New System.Windows.Forms.ListBox()
        Me.btn_connect_image_process = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_image_process_port = New System.Windows.Forms.TextBox()
        Me.txt_image_process = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_image_process_host = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_inverse_kinematics = New System.Windows.Forms.TextBox()
        Me.btn_connect_ik = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ik_port = New System.Windows.Forms.TextBox()
        Me.txt_ik_host = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_auto_ip = New System.Windows.Forms.Button()
        Me.pic_ip = New System.Windows.Forms.PictureBox()
        Me.pic_ikin = New System.Windows.Forms.PictureBox()
        Me.btn_auto_ikin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pic_ip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ikin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_j_code
        '
        Me.txt_j_code.Location = New System.Drawing.Point(6, 191)
        Me.txt_j_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_j_code.Multiline = True
        Me.txt_j_code.Name = "txt_j_code"
        Me.txt_j_code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_j_code.Size = New System.Drawing.Size(556, 110)
        Me.txt_j_code.TabIndex = 0
        '
        'btn_execute
        '
        Me.btn_execute.Location = New System.Drawing.Point(568, 191)
        Me.btn_execute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_execute.Name = "btn_execute"
        Me.btn_execute.Size = New System.Drawing.Size(78, 110)
        Me.btn_execute.TabIndex = 1
        Me.btn_execute.Text = "Manual Execute"
        Me.btn_execute.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Baudrate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Serial)
        Me.GroupBox1.Controls.Add(Me.txt_serial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 526)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 192)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Robotic Arm"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(512, 23)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(134, 31)
        Me.Button_Connect.TabIndex = 3
        Me.Button_Connect.Tag = "Connect"
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'ComboBox_Baudrate
        '
        Me.ComboBox_Baudrate.FormattingEnabled = True
        Me.ComboBox_Baudrate.Items.AddRange(New Object() {"300", "600", "750", "1200", "2400", "4800", "9600", "19200", "31250", "38400", "57600", "74880", "115200", "230400", "250000", "460800", "500000", "921600", "1000000", "2000000"})
        Me.ComboBox_Baudrate.Location = New System.Drawing.Point(393, 25)
        Me.ComboBox_Baudrate.Name = "ComboBox_Baudrate"
        Me.ComboBox_Baudrate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Baudrate.Size = New System.Drawing.Size(109, 28)
        Me.ComboBox_Baudrate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serial Port"
        '
        'ComboBox_Serial
        '
        Me.ComboBox_Serial.FormattingEnabled = True
        Me.ComboBox_Serial.Location = New System.Drawing.Point(128, 25)
        Me.ComboBox_Serial.Name = "ComboBox_Serial"
        Me.ComboBox_Serial.Size = New System.Drawing.Size(156, 28)
        Me.ComboBox_Serial.TabIndex = 0
        '
        'txt_serial
        '
        Me.txt_serial.BackColor = System.Drawing.Color.Black
        Me.txt_serial.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serial.ForeColor = System.Drawing.Color.Lime
        Me.txt_serial.Location = New System.Drawing.Point(6, 60)
        Me.txt_serial.Multiline = True
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.Size = New System.Drawing.Size(640, 120)
        Me.txt_serial.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        Me.Timer1.Tag = "-1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.list_fallen_data)
        Me.GroupBox2.Controls.Add(Me.btn_connect_image_process)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_image_process_port)
        Me.GroupBox2.Controls.Add(Me.txt_image_process)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_image_process_host)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 194)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image Process"
        '
        'list_fallen_data
        '
        Me.list_fallen_data.FormattingEnabled = True
        Me.list_fallen_data.ItemHeight = 23
        Me.list_fallen_data.Location = New System.Drawing.Point(456, 62)
        Me.list_fallen_data.Name = "list_fallen_data"
        Me.list_fallen_data.Size = New System.Drawing.Size(190, 119)
        Me.list_fallen_data.TabIndex = 9
        '
        'btn_connect_image_process
        '
        Me.btn_connect_image_process.Location = New System.Drawing.Point(512, 21)
        Me.btn_connect_image_process.Name = "btn_connect_image_process"
        Me.btn_connect_image_process.Size = New System.Drawing.Size(134, 35)
        Me.btn_connect_image_process.TabIndex = 4
        Me.btn_connect_image_process.Tag = "Connect"
        Me.btn_connect_image_process.Text = "Connect"
        Me.btn_connect_image_process.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TCP Host"
        '
        'txt_image_process_port
        '
        Me.txt_image_process_port.Location = New System.Drawing.Point(393, 24)
        Me.txt_image_process_port.Name = "txt_image_process_port"
        Me.txt_image_process_port.Size = New System.Drawing.Size(109, 30)
        Me.txt_image_process_port.TabIndex = 2
        Me.txt_image_process_port.Text = "12345"
        '
        'txt_image_process
        '
        Me.txt_image_process.BackColor = System.Drawing.Color.Black
        Me.txt_image_process.ForeColor = System.Drawing.Color.OrangeRed
        Me.txt_image_process.Location = New System.Drawing.Point(6, 62)
        Me.txt_image_process.Multiline = True
        Me.txt_image_process.Name = "txt_image_process"
        Me.txt_image_process.Size = New System.Drawing.Size(444, 120)
        Me.txt_image_process.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TCP Port"
        '
        'txt_image_process_host
        '
        Me.txt_image_process_host.Location = New System.Drawing.Point(128, 24)
        Me.txt_image_process_host.Name = "txt_image_process_host"
        Me.txt_image_process_host.Size = New System.Drawing.Size(156, 30)
        Me.txt_image_process_host.TabIndex = 0
        Me.txt_image_process_host.Text = "127.0.0.1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_execute)
        Me.GroupBox4.Controls.Add(Me.txt_j_code)
        Me.GroupBox4.Controls.Add(Me.txt_inverse_kinematics)
        Me.GroupBox4.Controls.Add(Me.btn_connect_ik)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_ik_port)
        Me.GroupBox4.Controls.Add(Me.txt_ik_host)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(663, 308)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inverse Kinematics"
        '
        'txt_inverse_kinematics
        '
        Me.txt_inverse_kinematics.BackColor = System.Drawing.Color.Black
        Me.txt_inverse_kinematics.ForeColor = System.Drawing.Color.Cyan
        Me.txt_inverse_kinematics.Location = New System.Drawing.Point(6, 64)
        Me.txt_inverse_kinematics.Multiline = True
        Me.txt_inverse_kinematics.Name = "txt_inverse_kinematics"
        Me.txt_inverse_kinematics.Size = New System.Drawing.Size(640, 120)
        Me.txt_inverse_kinematics.TabIndex = 8
        '
        'btn_connect_ik
        '
        Me.btn_connect_ik.Location = New System.Drawing.Point(512, 25)
        Me.btn_connect_ik.Name = "btn_connect_ik"
        Me.btn_connect_ik.Size = New System.Drawing.Size(134, 35)
        Me.btn_connect_ik.TabIndex = 4
        Me.btn_connect_ik.Tag = "Connect"
        Me.btn_connect_ik.Text = "Connect"
        Me.btn_connect_ik.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TCP Port"
        '
        'txt_ik_port
        '
        Me.txt_ik_port.Location = New System.Drawing.Point(393, 28)
        Me.txt_ik_port.Name = "txt_ik_port"
        Me.txt_ik_port.Size = New System.Drawing.Size(109, 30)
        Me.txt_ik_port.TabIndex = 2
        Me.txt_ik_port.Text = "3000"
        '
        'txt_ik_host
        '
        Me.txt_ik_host.Location = New System.Drawing.Point(128, 28)
        Me.txt_ik_host.Name = "txt_ik_host"
        Me.txt_ik_host.Size = New System.Drawing.Size(156, 30)
        Me.txt_ik_host.TabIndex = 1
        Me.txt_ik_host.Text = "127.0.0.1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TCP Host"
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'btn_auto_ip
        '
        Me.btn_auto_ip.Location = New System.Drawing.Point(681, 203)
        Me.btn_auto_ip.Name = "btn_auto_ip"
        Me.btn_auto_ip.Size = New System.Drawing.Size(60, 31)
        Me.btn_auto_ip.TabIndex = 9
        Me.btn_auto_ip.Tag = "-"
        Me.btn_auto_ip.Text = "-"
        Me.btn_auto_ip.UseVisualStyleBackColor = True
        '
        'pic_ip
        '
        Me.pic_ip.Image = Global.Arm_Controller.My.Resources.Resources.connect_3
        Me.pic_ip.InitialImage = Nothing
        Me.pic_ip.Location = New System.Drawing.Point(681, 130)
        Me.pic_ip.Name = "pic_ip"
        Me.pic_ip.Size = New System.Drawing.Size(60, 200)
        Me.pic_ip.TabIndex = 8
        Me.pic_ip.TabStop = False
        '
        'pic_ikin
        '
        Me.pic_ikin.Image = Global.Arm_Controller.My.Resources.Resources.connect_3
        Me.pic_ikin.Location = New System.Drawing.Point(681, 445)
        Me.pic_ikin.Name = "pic_ikin"
        Me.pic_ikin.Size = New System.Drawing.Size(60, 200)
        Me.pic_ikin.TabIndex = 10
        Me.pic_ikin.TabStop = False
        '
        'btn_auto_ikin
        '
        Me.btn_auto_ikin.Location = New System.Drawing.Point(681, 526)
        Me.btn_auto_ikin.Name = "btn_auto_ikin"
        Me.btn_auto_ikin.Size = New System.Drawing.Size(60, 31)
        Me.btn_auto_ikin.TabIndex = 11
        Me.btn_auto_ikin.Tag = "-"
        Me.btn_auto_ikin.Text = "-"
        Me.btn_auto_ikin.UseVisualStyleBackColor = True
        '
        'frm_bottle_handle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 730)
        Me.Controls.Add(Me.btn_auto_ikin)
        Me.Controls.Add(Me.pic_ikin)
        Me.Controls.Add(Me.btn_auto_ip)
        Me.Controls.Add(Me.pic_ip)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_bottle_handle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bottle Handle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pic_ip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ikin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_j_code As TextBox
    Friend WithEvents btn_execute As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Connect As Button
    Friend WithEvents ComboBox_Baudrate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_Serial As ComboBox
    Friend WithEvents txt_serial As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_image_process_host As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_image_process_port As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_connect_image_process As Button
    Friend WithEvents txt_image_process As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_inverse_kinematics As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_ik_host As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ik_port As TextBox
    Friend WithEvents btn_connect_ik As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As Timer
    Friend WithEvents pic_ip As PictureBox
    Friend WithEvents btn_auto_ip As Button
    Friend WithEvents pic_ikin As PictureBox
    Friend WithEvents btn_auto_ikin As Button
    Friend WithEvents list_fallen_data As ListBox
End Class
