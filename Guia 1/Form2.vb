'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'2. Dado el siguiente arreglo b={4,7,1,0,3,5,7,2}, desarrolle un programa que recorra el 
'arreglo y despliegue en un textbox el promedio de los elementos.
Public Class Form2
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim a = {4, 7, 1, 0, 3, 5, 7, 2}
        Dim i, suma, mitad As Integer
        Dim size As Integer
        Dim promedio As Double

        mitad = (a.Length / 2)

        size = a.Length
        suma = 0

        If size Mod 2 = 0 Then
            For i = 0 To mitad - 1
                suma = suma + (a(i) + a(mitad + i))
            Next
        Else
            'Para sumar de las esquinas
            size = size - 1
            mitad = ((a.Length - 1) / 2)

            For i = 0 To mitad

                If i = mitad Then
                    suma = suma + a(size - i)
                Else
                    suma = suma + (a(i) + a(size - i))
                End If
            Next
        End If

        promedio = suma / a.Length
        txtResultado.Text = Str(promedio)
    End Sub
End Class