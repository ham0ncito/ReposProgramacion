Public Class Persona
    'Declaracion de atributos de la clase'
    Private _nombre As String
    Private _edad As String
    'Encapsulamiento de los atributos'
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Edad As Short
        Get
            Return _edad
        End Get
        Set(value As Short)
            _edad = value
        End Set
    End Property

    'Metodo de la clase Persona'
    Public Sub saludarn()
        Print("Hola me llamo", _nombre)
    End Sub

End Class
