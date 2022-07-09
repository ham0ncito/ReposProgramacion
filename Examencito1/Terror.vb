Public Class Terror
    Inherits Peliculas
    Dim _sangre As String
    Dim _gritos As String

    Public Property Sangre As String
        Get
            Return _sangre
        End Get
        Set(value As String)
            _sangre = value
        End Set
    End Property

    Public Property Gritos As String
        Get
            Return _gritos
        End Get
        Set(value As String)
            _gritos = value
        End Set
    End Property

    Public Function acuchillar()
        _sangre = " bloooo bloo"
        _gritos = " ayyyyy me muerto "
        Return (Nombre & " fue acuchillada violentamente y grita " & Sangre & " " & Gritos)
    End Function
End Class
