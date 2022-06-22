Public Class Form1
    Private Sub btndatos_Click(sender As Object, e As EventArgs) Handles btndatos.Click
        'declaracion de variables'

        Dim nombre As String


        'entrada de datos'

        nombre = InputBox("Ingrese su nombre", "Registro", , 0, 0)
        If (nombre <> "") Then
            MessageBox.Show("Bienvenido usuario" & " " & nombre, "Registro ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim salida As DialogResult

        salida = MessageBox.Show("Desea continuar: ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (salida = Windows.Forms.DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub
End Class
