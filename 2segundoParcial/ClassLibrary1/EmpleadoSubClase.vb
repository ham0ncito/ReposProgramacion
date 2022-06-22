Public Class EmpleadoSubClase
    Inherit PersonaSuperClase


    Private _contrado As String
    Private sueldo As Double



    Public Property Contrado As String
        Get
            Return _contrado
        End Get
        Set(value As String)
            _contrado = value
        End Set
    End Property

    Public Property Sueldo1 As Double
        Get
            Return sueldo
        End Get
        Set(value As Double)
            sueldo = value
        End Set
    End Property
End Class
