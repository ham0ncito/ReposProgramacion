Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cachoro As Perro = New Perro()
        'los constructores se llaman igual a las clases'
        'en otros lenguajes Perro cachorro = new perro()
        cachoro.nombre = "Chilaquil"
        cachoro.raza = "Pastor"
        cachoro.altura = "0.75"

        TextBox1.Text = cachoro.comer("carne")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cachoro2 As Perro = New Perro()
        cachoro2.nombre = "Perrito Sin Nombre"
        cachoro2.raza = "Aguacaterrier"
        cachoro2.altura = "1.2"

        TextBox1.Text = cachoro2.comer("nada")
    End Sub
End Class
