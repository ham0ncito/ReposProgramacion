Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtn2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtdiv.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'declaracion de variable'
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma, resta, mult As Integer
        Dim div, potencia, raiz As Double

        'entrada de datos'
        num1 = Val(txtn1.Text)
        num2 = Val(txtn2.Text)


        'proceso'
        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        potencia = num1 ^ num2
        raiz = num1 ^ (1 / num2)

        'salida de datos'
        txtsuma.Text = suma
        txtresta.Text = resta
        txtmul.Text = mult
        txtdiv.Text = div
        txtpotencia.Text = potencia
        txtraiz.Text = raiz
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtsuma.Clear()
        txtresta.Clear()
        txtmul.Clear()
        txtdiv.Clear()
        txtpotencia.Clear()
        txtraiz.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
