<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_calibration = New System.Windows.Forms.Button()
        Me.Button_Camera = New System.Windows.Forms.Button()
        Me.Button_Countour = New System.Windows.Forms.Button()
        Me.Button_Detection = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(430, 724)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Designed && developed by Jezzah Junaideen (B.Tech Eng in MMT)"
        '
        'btn_calibration
        '
        Me.btn_calibration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_calibration.Location = New System.Drawing.Point(12, 706)
        Me.btn_calibration.Name = "btn_calibration"
        Me.btn_calibration.Size = New System.Drawing.Size(171, 35)
        Me.btn_calibration.TabIndex = 1
        Me.btn_calibration.Text = "Calibration Mode"
        Me.btn_calibration.UseVisualStyleBackColor = True
        '
        'Button_Camera
        '
        Me.Button_Camera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button_Camera.Location = New System.Drawing.Point(12, 12)
        Me.Button_Camera.Name = "Button_Camera"
        Me.Button_Camera.Size = New System.Drawing.Size(171, 35)
        Me.Button_Camera.TabIndex = 2
        Me.Button_Camera.Text = "Camera"
        Me.Button_Camera.UseVisualStyleBackColor = True
        '
        'Button_Countour
        '
        Me.Button_Countour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button_Countour.Location = New System.Drawing.Point(12, 53)
        Me.Button_Countour.Name = "Button_Countour"
        Me.Button_Countour.Size = New System.Drawing.Size(171, 35)
        Me.Button_Countour.TabIndex = 2
        Me.Button_Countour.Text = "Countour"
        Me.Button_Countour.UseVisualStyleBackColor = True
        '
        'Button_Detection
        '
        Me.Button_Detection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button_Detection.Location = New System.Drawing.Point(12, 94)
        Me.Button_Detection.Name = "Button_Detection"
        Me.Button_Detection.Size = New System.Drawing.Size(171, 35)
        Me.Button_Detection.TabIndex = 2
        Me.Button_Detection.Text = "Detection"
        Me.Button_Detection.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(357, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Grid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LawnGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(12, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Activate Bottle Handling"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(12, 665)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Camera Detection"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Tomato
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(12, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 56)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Stop Handling"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_Detection)
        Me.Controls.Add(Me.Button_Countour)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button_Camera)
        Me.Controls.Add(Me.btn_calibration)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arm Controller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_calibration As Button
    Friend WithEvents Button_Camera As Button
    Friend WithEvents Button_Countour As Button
    Friend WithEvents Button_Detection As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
