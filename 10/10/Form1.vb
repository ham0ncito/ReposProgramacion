Public Class Form1
    Private Sub btnvector_Click(sender As Object, e As EventArgs) Handles btnvector.Click
        Dim edad(8) As Integer
        edad(0) = 10
        edad(1) = 20
        edad(2) = 30
        edad(3) = 40
        edad(4) = 25
        edad(5) = 15
        edad(6) = 17
        edad(7) = 99
        Dim sum As Integer
        Dim prom As Double
        'proceso

        For i As Integer = 0 To 7 Step 1
            cmbnota.Items.Add(edad(i))
            sum = sum + edad(i)

        Next
        prom = sum / 8


        'salida de informacion'
        cmbpromedio.Text = prom

    End Sub

    Private Sub btnnevo_Click(sender As Object, e As EventArgs) Handles btnnevo.Click
        cmbnota.Items.Clear()
        cmbpromedio.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
