Public Class Comedia
    Inherits Peliculas
    Dim _bromas As String
    Dim _finalFeliz As String

    Public Property Bromas As String
        Get
            Return _bromas
        End Get
        Set(value As String)
            _bromas = value
        End Set
    End Property

    Public Property FinalFeliz As String
        Get
            Return _finalFeliz
        End Get
        Set(value As String)
            _finalFeliz = value
        End Set
    End Property

    Public Function risa()
        _bromas = "  Que le dijo un tomate a otro tomate? tomatelaaa eeeh!!!"
        _finalFeliz = " Y pasaron la clase de programacion"
        Return "jajajajajajajaja me muero de la risa" & Bromas & " " & _finalFeliz
    End Function
End Class
