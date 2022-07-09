Public Class Peliculas
    Private _nombre As String
    Private _fechaLanzamiento As String
    Private _genero As String
    Private _duracion As String
    Private _titulo As String
    Private _año As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property FechaLanzamiento As String
        Get
            Return _fechaLanzamiento
        End Get
        Set(value As String)
            _fechaLanzamiento = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property

    Public Property Duracion As String
        Get
            Return _duracion
        End Get
        Set(value As String)
            _duracion = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property Año As String
        Get
            Return _año
        End Get
        Set(value As String)
            _año = value
        End Set
    End Property
End Class
