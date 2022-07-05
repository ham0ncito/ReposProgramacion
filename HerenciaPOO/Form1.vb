Imports Clases

Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As Empleado = New Empleado
        emp.Apellido = txtapellido.Text
        emp.Nombre = txtnombre.Text
        emp.Documento = txtdocumento.Text
        emp.Contrato = cmbcontrato.Text
        emp.Tipo = cmbtipo.Text

        emp.calcularSueldo(1000)
        data.Rows.Insert(0, emp.Tipo, emp.Nombre, emp.Apellido,
emp.Documento, emp.Sueldo)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
