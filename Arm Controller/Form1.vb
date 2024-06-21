Public Class Form1
    Private Sub btn_calibration_Click(sender As Object, e As EventArgs) Handles btn_calibration.Click
        Form_Calibration.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_bottle_handle.Show()
        Me.Hide()

    End Sub

End Class
