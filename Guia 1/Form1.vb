'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'1. Dado el siguiente arreglo a = {4,5,1,8,2,0}, desarrolle un programa que recorra el arreglo y 
'despliegue en un textbox el resultado de la suma de los elementos.

Public Class Form1

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        'Dim a = {4, 5, 1, 8, 2, 0}
        Dim a = {4, 5, 1, 8, 2, 1}
        Dim i, suma, mitad As Integer

        Dim size As Integer
        mitad = (a.Length / 2)

        size = a.Length
        suma = 0

        If size Mod 2 = 0 Then
            For i = 0 To mitad - 1
                suma = suma + (a(i) + a(mitad + i))
            Next
            MsgBox("Soy par")
            txtResultado.Text = Str(suma)
        Else
            'Para sumar de las esquinas
            'size = a.Length - 1
            size = size - 1
            mitad = ((a.Length - 1) / 2)

            For i = 0 To mitad

                If i = mitad Then
                    suma = suma + a(size - i)
                Else

                    suma = suma + (a(i) + a(size - i))
                End If
            Next
            MsgBox("Soy impar")
            txtResultado.Text = Str(suma)
        End If
    End Sub
End Class
