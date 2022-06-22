Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnasignar_Click(sender As Object, e As EventArgs) Handles btnasignar.Click
        'declaracion de variable'


        Dim stock, cantidadPersonas, cantidadEntregada As Integer


        'inicializar varibles'


        cantidadPersonas = 0

        'entrada de datos

        stock = Val(txtstock.Text)
        Do While (stock >= 12)
            cantidadEntregada = InputBox("Ingrese las vacunas " & (cantidadPersonas + 1), "Vacunas")
            If (stock >= cantidadEntregada) Then
                cantidadPersonas = cantidadPersonas + 1
                stock = stock - cantidadEntregada
            Else
                MessageBox.Show(" NO HAY SUFICIENTE EXISTENCIA ", " Repartir", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Loop
        MessageBox.Show("Stock es inferior al numero de unidades", "repartir", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'salida de datos

        txtstock2.Text = stock

        txtnumero.Text = cantidadPersonas
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnumero.Clear()
        txtstock.Clear()
        txtstock2.Clear()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub txtstock_TextChanged(sender As Object, e As EventArgs) Handles txtstock.TextChanged

    End Sub
End Class
