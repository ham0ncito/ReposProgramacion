Public Class Cliente
    Inherits Persona
    Dim _categoria As String
    Dim _codigo As String

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

    Public Sub GenerarCodigo()
        Me.Codigo = "c" & Me.Apellido.Substring(0, 3) & "2022"
    End Sub


End Class
