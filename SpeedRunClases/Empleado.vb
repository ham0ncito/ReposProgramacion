Public Class Empleado
    Inherits Persona

    Dim _contrato As String
    Dim _sueldo As String

    Public Property Contrato As String
        Get
            Return _contrato
        End Get
        Set(value As String)
            _contrato = value
        End Set
    End Property

    Public Property Sueldo As String
        Get
            Return _sueldo
        End Get
        Set(value As String)
            _sueldo = value
        End Set
    End Property

    Public Sub CalcularSueldo(sueldoBase As String)
        If sueldoBase > 1000 Then
            Sueldo = sueldoBase + 5000
        Else
            Sueldo = sueldoBase + 1000
        End If
    End Sub
End Class
