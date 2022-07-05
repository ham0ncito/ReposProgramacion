Public Class Empleado
    'Herencia de la clase persona'
    Inherits Persona

    'declaracion de los atributos de la clase
    Dim _salario As Double
    Dim _codigo As String

    Public Property Salario As Double
        Get
            Return _salario
        End Get
        Set(value As Double)
            _salario = value
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

    Public Sub generarCodigo()
        _codigo = Nombre & "2022"
    End Sub

    Public Function calcularSueldo(Valor As Double)
        _salario = Valor + Valor * 40
    End Function
End Class
