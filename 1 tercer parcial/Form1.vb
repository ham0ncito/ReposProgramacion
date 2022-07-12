Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "Select idProducto, nombreProducto, fecha from Productos"
        Dim com As New SqlCommand(sql, con)

    End Sub
End Class
