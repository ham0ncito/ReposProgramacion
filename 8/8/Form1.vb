Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiar()
        cmbDivsion.Items.Clear()
        cmbMultiplicacion.Items.Clear()
        cmbResta.Items.Clear()
        cmbSuma.Items.Clear()
        txtNumero.Clear()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiar()


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'llamada'


        'declaracion'
        Dim numero, suma, resta, multiplicacion As Integer
        Dim division As Double
        'entrada de datos
        numero = Val(txtNumero.Text)

        'proceso'
        For i = 1 To numero Step 1
            suma = numero + i
            resta = numero - i
            multiplicacion = numero * i
            division = numero / i

            'salida'
            cmbSuma.Items.Add(numero & " + " & i & "= " & suma)
            cmbResta.Items.Add(numero & " - " & i & "= " & resta)
            cmbDivsion.Items.Add(numero & " / " & i & "= " & division)
            cmbMultiplicacion.Items.Add(numero & " * " & i & "= " & multiplicacion)

        Next

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class
