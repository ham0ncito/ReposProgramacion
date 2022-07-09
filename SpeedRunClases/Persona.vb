Public Class Persona
    Private _nombre As String
    Private _apellido As String
    Private _identidad As String
    Private _tipo As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Identidad As String
        Get
            Return _identidad
        End Get
        Set(value As String)
            _identidad = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
End Class
