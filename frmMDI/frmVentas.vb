Public Class frmVentas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Shared _instancia As frmVentas
    Public Function GetInstancia() As frmVentas
        If (_instancia Is Nothing) Then
            _instancia = New frmVentas
        End If
        Return _instancia

    End Function

    Public Sub setcliente(cliente As String)
        //Me.Combobo.Text = cliente
    End Sub
End Class