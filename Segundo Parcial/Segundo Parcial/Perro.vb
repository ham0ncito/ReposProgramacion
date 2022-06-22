Public Class Perro
    'atributos: son caracteristicas'
    Public nombre As String
    Public raza As String
    Public altura As String
    'metodos : son acciones'

    'no se pueden eliminar datos de una base de datos'
    Public Sub dormir()

    End Sub

    Public Sub ladrar()

    End Sub


    Public Function comer(costilla As String) As String
        Return Me.nombre & " mide " & Me.altura & ", es de raza " & Me.raza & " comera " & costilla
    End Function

End Class
