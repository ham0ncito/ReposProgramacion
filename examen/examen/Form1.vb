Public Class Form1

    Dim tiempo As Integer = 0

    Private Sub limpiar()
        txtnumero.Clear()
        cmbsuma.Items.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lbltimer_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl1.Text = TimeOfDay
        If (tiempo Mod 2 = 0) Then
            pcb1.Visible = True
            pcb2.Visible = False
        Else
            pcb1.Visible = False
            pcb2.Visible = True

        End If
        tiempo = tiempo + 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim salir As DialogResult

        salir = MessageBox.Show("¿Quiere continuar??? ", "A L E R T A", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (salir = Windows.Forms.DialogResult.Yes) Then
            End

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Call limpiar()


    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim numero(4) As Integer
        numero(0) = 10
        numero(1) = 56
        numero(2) = 2
        numero(3) = 30
        numero(4) = 56
        

        Dim sum As Integer
        Dim aux As Integer
        sum = Val(txtnumero.Text)
        aux = 0
        For i As Integer = 0 To 4 Step 1

            aux = sum + numero(i)
            cmbsuma.Items.Add(sum & " + " & numero(i) & "= " & aux)
            aux = 0

        Next
    End Sub
End Class
