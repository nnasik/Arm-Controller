Public Class ArmController
    ' Define a structure to represent a row in the DH table
    Structure DHRow
        Dim a As Double
        Dim alpha As Double
        Dim d As Double
        Dim theta As Double
    End Structure

    Dim new_theta_1 As Double
    Dim new_theta_2 As Double
    Dim new_theta_3 As Double
    Dim new_theta_4 As Double

    Dim phi As Double
    Dim beta As Double
    Dim alpha As Double


    Dim dhTable As New Dictionary(Of String, DHRow) From {
        {"Link1", New DHRow With {.a = 0, .alpha = 90, .d = 94, .theta = 0}},
        {"Link2", New DHRow With {.a = 105, .alpha = 0, .d = 0, .theta = 0}},
        {"Link3", New DHRow With {.a = 127.5, .alpha = 0, .d = 0, .theta = 0}},
        {"Link4", New DHRow With {.a = 135, .alpha = 0, .d = 0, .theta = 0}}
    }

    Function calculateTheta(ByVal x As Double, ByVal y As Double, ByVal z As Double) As Double()
        Dim result(4) As Double

        'Solving θ₁
        new_theta_1 = Math.Atan(y / x)
        result(0) = new_theta_1

        'Solving θ₃
        new_theta_3 = Math.Acos((x ^ 2 + y ^ 2 - dhTable("Link3").a ^ 2 - dhTable("Link4").a ^ 2) / (2 * dhTable("Link3").a * dhTable("Link4").a))
        result(2) = new_theta_1

        'In order to obtain θ₂ , we first calculate the angle α and β
        beta = Math.Atan(y / x)
        alpha = Math.Acos((x ^ 2 + y ^ 2 + dhTable("Link3").a ^ 2 - dhTable("Link4").a ^ 2) / (2 * dhTable("Link3").a ^ 2 * Math.Sqrt(x ^ 2 + y ^ 2)))

        'θ₂ = α±β ; （ θ₃< 0 is+ ， θ₃ > 0 is −）
        If new_theta_3 > 0 Then
            new_theta_2 = alpha - beta
        ElseIf new_theta_3 < 0 Then
            new_theta_2 = alpha + beta
        End If
        result(1) = new_theta_2

        ' Solving 
        new_theta_4 = Math.Atan(z / 1) - new_theta_2 - new_theta_3
        result(3) = new_theta_4

        Return result
    End Function
End Class
