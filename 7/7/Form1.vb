Imports System.ComponentModel

Public Class Form1
    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        Try

            If Me.ValidateChildren And txtnombre.Text <> String.Empty And Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0 And txtsalario.Text <> String.Empty Then
                MessageBox.Show("Datos ingresados", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datos no ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.Errorp.SetError(sender, "")
        Else
            Me.Errorp.SetError(sender, "Ingrese el nombre obligatoriamente")
        End If
    End Sub

    Private Sub txtsalario_TextChanged(sender As Object, e As EventArgs) Handles txtsalario.TextChanged

    End Sub

    Private Sub txtsalario_Validating(sender As Object, e As CancelEventArgs) Handles txtsalario.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.Errorp.SetError(sender, "")
        Else
            Me.Errorp.SetError(sender, "Ingrese su salario obligatoriamente")
        End If
    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If (Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0 And Val(txtedad.Text) <> 0) Then
            Me.Errorp.SetError(sender, "")
        Else
            Me.Errorp.SetError(sender, "Ingrese su edad")
        End If
    End Sub
End Class
