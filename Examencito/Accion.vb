Public Class Accion
    Inherits Peliculas
    Dim _balas As String
    Dim _policias As String

    Public Property Balas As String
        Get
            Return _balas
        End Get
        Set(value As String)
            _balas = value
        End Set
    End Property

    Public Property Policias As String
        Get
            Return _policias
        End Get
        Set(value As String)
            _policias = value
        End Set
    End Property

    Public Function explosion()
        _balas = "piu piu"
        _policias = "iu iu iu"
        Return ("booooooooommmmmmm " & Balas & " " & Policias & " " & Nombre & " es la mejor pelicula")
    End Function
End Class
