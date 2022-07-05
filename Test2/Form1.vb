Imports Test2Class
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hola As Empleado = New Empleado
        Hola.Codigo = txtId.Text
        Hola.Nombre = txtNombre.Text
        Hola.Edad = txtEdad.Text
        Hola.calcularSueldo(txtSalario.Text)
        DataGridView1.Rows.Add(Hola.Codigo, Hola.Nombre, Hola.Edad, Hola.Salario)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
