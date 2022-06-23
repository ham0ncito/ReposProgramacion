Public Class Empleado
    Inherits Persona
    Dim _contrato As String
    Dim _sueldo As Double

    Public Property Contrato As String
        Get
            Return _contrato
        End Get
        Set(value As String)
            _contrato = value
        End Set
    End Property

    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.Contrato = "C") Then
            Me.Sueldo = sueldoBase + 500
        ElseIf Me.Contrato = "N" Then
            Me.Sueldo = sueldoBase + 200
        Else
            Me.Sueldo = 0
        End If

    End Sub
End Class
