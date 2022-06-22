Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtPulgadas.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtMetros.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaracion de variables'
        Dim altura As Double
        Dim edad As Integer
        Dim checkbox As Boolean

        'entrada de datos'
        altura = Val(txtAltura.Text)
        edad = Val(txtEdad.Text)

        'proceso y salida de datos'
        txtHoras.Text = edad * 8766
        txtMinutos.Text = edad * 8766 * 60
        checkbox = CheckBox1.Checked

        If (checkbox) Then
            txtMetros.Text = Math.Round(altura / 60)
            txtPulgadas.Text = Math.Round(altura / 2.54)
        End If
        lblMensaje.Text = "Terminado"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        txtAltura.Clear()
        txtEdad.Clear()
        txtHoras.Clear()
        txtMetros.Clear()
        txtMinutos.Clear()
        txtPulgadas.Clear()
        lblMensaje.Text = "Ingrese sus datos"
    End Sub
End Class
