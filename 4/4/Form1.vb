Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'declaracion de variables'
        Dim numero As Integer
        Dim dia As String
        'entrada de datos'
        numero = Val(txtnumero.Text)
        'proceso'
        Select Case (numero)
            Case 1
                dia = "Lunes"
            Case 2
                dia = "martes"
            Case 3
                dia = "Miercoles"
            Case 4
                dia = "Jueves"
            Case 5
                dia = "Viernes"
            Case 6
                dia = "Sabado"
            Case 7
                dia = "numero"
            Case Else
                dia = "Ese dia no existe"


        End Select

        'salida de datos'
        txtdia.Text = dia

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtdia.Clear()
        txtnumero.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
