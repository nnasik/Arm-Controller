﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Calibration
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.TrackBar5 = New System.Windows.Forms.TrackBar()
        Me.TrackBar6 = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Baudrate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_Serial = New System.Windows.Forms.ComboBox()
        Me.Text_angle6 = New System.Windows.Forms.TextBox()
        Me.Text_angle5 = New System.Windows.Forms.TextBox()
        Me.Text_angle4 = New System.Windows.Forms.TextBox()
        Me.Text_angle3 = New System.Windows.Forms.TextBox()
        Me.Text_angle2 = New System.Windows.Forms.TextBox()
        Me.Text_angle1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_Connect = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(179, 453)
        Me.TrackBar1.Maximum = 90
        Me.TrackBar1.Minimum = -90
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickFrequency = 5
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(179, 391)
        Me.TrackBar2.Maximum = 90
        Me.TrackBar2.Minimum = -90
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar2.TabIndex = 0
        Me.TrackBar2.TickFrequency = 5
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(179, 329)
        Me.TrackBar3.Maximum = 90
        Me.TrackBar3.Minimum = -90
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar3.TabIndex = 0
        Me.TrackBar3.TickFrequency = 5
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(179, 267)
        Me.TrackBar4.Maximum = 90
        Me.TrackBar4.Minimum = -90
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar4.TabIndex = 0
        Me.TrackBar4.TickFrequency = 5
        '
        'TrackBar5
        '
        Me.TrackBar5.Location = New System.Drawing.Point(179, 205)
        Me.TrackBar5.Maximum = 90
        Me.TrackBar5.Minimum = -90
        Me.TrackBar5.Name = "TrackBar5"
        Me.TrackBar5.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar5.TabIndex = 0
        Me.TrackBar5.TickFrequency = 5
        '
        'TrackBar6
        '
        Me.TrackBar6.Location = New System.Drawing.Point(179, 143)
        Me.TrackBar6.Maximum = 90
        Me.TrackBar6.Minimum = -90
        Me.TrackBar6.Name = "TrackBar6"
        Me.TrackBar6.Size = New System.Drawing.Size(500, 56)
        Me.TrackBar6.TabIndex = 0
        Me.TrackBar6.TickFrequency = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Baudrate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Serial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 98)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Communication"
        '
        'ComboBox_Baudrate
        '
        Me.ComboBox_Baudrate.FormattingEnabled = True
        Me.ComboBox_Baudrate.Items.AddRange(New Object() {"300", "600", "750", "1200", "2400", "4800", "9600", "19200", "31250", "38400", "57600", "74880", "115200", "230400", "250000", "460800", "500000", "921600", "1000000", "2000000"})
        Me.ComboBox_Baudrate.Location = New System.Drawing.Point(346, 40)
        Me.ComboBox_Baudrate.Name = "ComboBox_Baudrate"
        Me.ComboBox_Baudrate.Size = New System.Drawing.Size(156, 28)
        Me.ComboBox_Baudrate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Serial Port"
        '
        'ComboBox_Serial
        '
        Me.ComboBox_Serial.FormattingEnabled = True
        Me.ComboBox_Serial.Location = New System.Drawing.Point(113, 40)
        Me.ComboBox_Serial.Name = "ComboBox_Serial"
        Me.ComboBox_Serial.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox_Serial.TabIndex = 0
        '
        'Text_angle6
        '
        Me.Text_angle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle6.Location = New System.Drawing.Point(140, 143)
        Me.Text_angle6.Name = "Text_angle6"
        Me.Text_angle6.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle6.TabIndex = 2
        Me.Text_angle6.Text = "0"
        Me.Text_angle6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_angle5
        '
        Me.Text_angle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle5.Location = New System.Drawing.Point(140, 205)
        Me.Text_angle5.Name = "Text_angle5"
        Me.Text_angle5.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle5.TabIndex = 2
        Me.Text_angle5.Text = "0"
        Me.Text_angle5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_angle4
        '
        Me.Text_angle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle4.Location = New System.Drawing.Point(140, 267)
        Me.Text_angle4.Name = "Text_angle4"
        Me.Text_angle4.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle4.TabIndex = 2
        Me.Text_angle4.Text = "0"
        Me.Text_angle4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_angle3
        '
        Me.Text_angle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle3.Location = New System.Drawing.Point(140, 329)
        Me.Text_angle3.Name = "Text_angle3"
        Me.Text_angle3.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle3.TabIndex = 2
        Me.Text_angle3.Text = "0"
        Me.Text_angle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_angle2
        '
        Me.Text_angle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle2.Location = New System.Drawing.Point(140, 390)
        Me.Text_angle2.Name = "Text_angle2"
        Me.Text_angle2.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle2.TabIndex = 2
        Me.Text_angle2.Text = "0"
        Me.Text_angle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Text_angle1
        '
        Me.Text_angle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_angle1.Location = New System.Drawing.Point(140, 451)
        Me.Text_angle1.Name = "Text_angle1"
        Me.Text_angle1.Size = New System.Drawing.Size(35, 27)
        Me.Text_angle1.TabIndex = 2
        Me.Text_angle1.Text = "0"
        Me.Text_angle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gripper"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Wrist Rotate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Wrist"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Elbow"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Shoulder"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Base"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(512, 38)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(134, 31)
        Me.Button_Connect.TabIndex = 3
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Form_Calibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 526)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text_angle1)
        Me.Controls.Add(Me.Text_angle2)
        Me.Controls.Add(Me.Text_angle3)
        Me.Controls.Add(Me.Text_angle4)
        Me.Controls.Add(Me.Text_angle5)
        Me.Controls.Add(Me.Text_angle6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TrackBar6)
        Me.Controls.Add(Me.TrackBar5)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "Form_Calibration"
        Me.Text = "Servo Calibration Mode"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents TrackBar5 As TrackBar
    Friend WithEvents TrackBar6 As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_Serial As ComboBox
    Friend WithEvents ComboBox_Baudrate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_angle6 As TextBox
    Friend WithEvents Text_angle5 As TextBox
    Friend WithEvents Text_angle4 As TextBox
    Friend WithEvents Text_angle3 As TextBox
    Friend WithEvents Text_angle2 As TextBox
    Friend WithEvents Text_angle1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Connect As Button
End Class
