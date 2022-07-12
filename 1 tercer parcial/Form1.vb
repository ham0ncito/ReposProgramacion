Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=localhost;Initial Catalog=prueba;Integrated Security=True")
        Dim sql As String = "Select idProducto, nombreProducto, fecha from Productos"
        Dim cmd As New SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Productos")
            Me.DataGridView1.DataSource = ds.Tables("Productos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
