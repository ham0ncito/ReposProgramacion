Public Class ClienteSubClase

    Inherit PersonaSuperClase

    Private _categoria As String
    Private _codigo As String

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property


End Class
