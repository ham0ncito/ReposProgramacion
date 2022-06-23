Public Class Empleado
    Inherits Persona

    Dim _contrato As String
    Dim _sueldo As Double

    Public Property Contrato As String
        Get
            Return Contrato
        End Get
        Set(value As String)
            Contrato = value
        End Set
    End Property

    Public Property Sueldo As Double
        Get
            Return Sueldo
        End Get
        Set(value As Double)
            Sueldo = value
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
