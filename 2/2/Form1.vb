Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        'declaracion de variables'
        Dim cantidad As Integer
        Dim preciou, preciop, descuento, preciot As Double
        Dim checkdes As Boolean

        'entrada de datos'
        cantidad = Val(txtcantidad.Text)
        preciou = Val(txtpreciou.Text)
        checkdes = chaplicar.Checked

        'inicializacion'
        descuento = 0

        'procesamiento de datos'
        preciop = cantidad * preciou

        'evaluar'

        If (checkdes) Then
            descuento = preciop * 0.2
        End If

        preciot = preciop - descuento

        'salida de datos'
        txtpreciop.Text = preciop
        txtdescuento.Text = descuento
        txtpreciot.Text = preciot

    End Sub

    Private Sub btnsalida_Click(sender As Object, e As EventArgs) Handles btnsalida.Click
        End
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtpreciou.Clear()
        txtcantidad.Clear()
        txtdescuento.Clear()
        txtpreciop.Clear()
        txtpreciot.Clear()
        chaplicar.Checked = False


    End Sub
End Class
