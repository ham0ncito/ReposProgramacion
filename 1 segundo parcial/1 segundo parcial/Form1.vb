Public Class Form1
    Private Sub limpiar()

        txtnumero1.Clear()
        txtnumero2.Clear()
        txtresultado.Clear()

    End Sub

    Private Function sumar(n1 As Integer, n2 As Integer) As Integer
        Dim resultado As Integer
        resultado = n1 + n2

        Return resultado
    End Function

    Private Function calculos(n1 As Integer, n2 As Integer, cal As String) As Double

        Dim resultado As Double

        If (cal = "s") Then
            resultado = n1 + n2
        ElseIf (cal = "r") Then
            resultado = n1 - n2
        ElseIf (cal = "m") Then
            resultado = n1 * n2
        Else
            resultado = n1 / n2
        End If
        Return resultado
    End Function

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Call limpiar()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        'declaracion de variables'
        Dim numero1 As Integer
        Dim numero2 As Integer

        'captura de datos'

        numero1 = Val(txtnumero1.Text)
        numero2 = Val(txtnumero2.Text)

        'mostrar informacion' 
        txtresultado.Text = sumar(numero1, numero2)



    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        'declaracion de variables
        Dim numero1, numero2 As Integer
        Dim resultado As Double
        'entrada de datos

        numero1 = Val(txtnumero1.Text)
        numero2 = Val(txtnumero2.Text)

        'proceso
        resultado = calculos(numero1, numero2, "r")
        txtresultado.Text = resultado

    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        'declaracion de variables
        Dim numero1, numero2 As Integer
        Dim resultado As Double
        'entrada de datos

        numero1 = Val(txtnumero1.Text)
        numero2 = Val(txtnumero2.Text)

        'proceso
        resultado = calculos(numero1, numero2, "m")
        txtresultado.Text = resultado
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        'declaracion de variables
        Dim numero1, numero2 As Integer
        Dim resultado As Double
        'entrada de datos

        numero1 = Val(txtnumero1.Text)
        numero2 = Val(txtnumero2.Text)

        'proceso
        resultado = calculos(numero1, numero2, "d")
        txtresultado.Text = resultado
    End Sub
End Class
