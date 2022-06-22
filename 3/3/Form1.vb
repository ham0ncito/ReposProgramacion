Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'declaracion de variables'
        Dim salario As Double
        Dim antiguedad As Integer
        Dim pago As Double



        'entrada de datos'

        salario = Val(txtSalario.Text)
        antiguedad = Val(cmbAntiguedad.Text)
        'proceso'

        If (antiguedad < 1) Then
            pago = salario + salario * 0.06
        ElseIf (antiguedad >= 1) And (antiguedad < 2) Then
            pago = salario + salario * 0.07
        ElseIf (antiguedad >= 2 And antiguedad < 5) Then
            pago = salario + salario * 0.11
        ElseIf (antiguedad >= 5 And antiguedad < 10) Then
            pago = salario + salario * 0.16
        ElseIf (antiguedad >= 10) Then
            pago = salario + salario * 0.25
        End If
        'salida de datos'
        txtPago.Text = pago


    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPago.Clear()
        txtSalario.Clear()
        cmbAntiguedad.SelectedIndex = 0

    End Sub

    Private Sub cmbAntiguedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAntiguedad.SelectedIndexChanged

    End Sub
End Class
