Imports Examencito1
Public Class frmMovie
    Dim freddy As Terror = New Terror()
    Dim listaUltima As Accion = New Accion()
    Dim elJajas As Comedia = New Comedia()
    Private Sub frmMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listaUltima.Nombre = "La Lista Ultima "
        listaUltima.Año = "2022"
        listaUltima.FechaLanzamiento = "07/06/22 "
        listaUltima.Genero = "Accion "
        listaUltima.Duracion = "2 horas "
        listaUltima.Titulo = listaUltima.Nombre
        If (MessageBox.Show(" Nombre " & listaUltima.Nombre & " Fecha Lanzamiento " & listaUltima.FechaLanzamiento & "Año " & listaUltima.Año & " Duracion " & listaUltima.Duracion & " Genero" & listaUltima.Genero, listaUltima.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            MessageBox.Show(listaUltima.explosion())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        elJajas.Nombre = "Quien paga la cuenta "
        elJajas.Año = "2016"
        elJajas.FechaLanzamiento = "07/06/2016 "
        elJajas.Genero = " Comedia"
        elJajas.Duracion = " 2 horas"
        elJajas.Titulo = elJajas.Nombre
        If (MessageBox.Show("Nombre " & elJajas.Nombre & " Fecha Lanzamiento " & elJajas.FechaLanzamiento & "Año " & elJajas.Año & " Duracion " & elJajas.Duracion & " Genero" & elJajas.Genero, elJajas.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            MessageBox.Show(elJajas.risa())
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        freddy.Nombre = "La Bruja "
        freddy.Año = "2012"
        freddy.FechaLanzamiento = "07/06/2012 "
        freddy.Genero = " Terror"
        freddy.Duracion = "2 horas"
        freddy.Titulo = freddy.Nombre
        If (MessageBox.Show("Nombre " & freddy.Nombre & " Fecha Lanzamiento " & freddy.FechaLanzamiento & "Año " & freddy.Año & " Duracion " & freddy.Duracion & " Genero" & freddy.Genero, freddy.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            MessageBox.Show(freddy.acuchillar)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class