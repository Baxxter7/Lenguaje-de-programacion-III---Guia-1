'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'5. Dado el siguiente arreglo a= {3,6,9,2,1,5,8,9,12,34,98}, desarrolle un programa que 
'encuentre el menor número del arreglo y lo despliegue en un textbox.
Public Class Form5
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim a = {3, 6, 9, 2, 1, 5, 8, 9, 12, 34, 98}

        'Ordenación inserccion
        Dim i, j, aux As Integer

        For i = 1 To a.Length - 1 Step 1

            For j = i To 1 Step -1
                If a(j) < a(j - 1) Then

                    aux = a(j)
                    a(j) = a(j - 1)
                    a(j - 1) = aux
                End If
            Next

        Next

        txtResultado.Text = Str(a(0))
    End Sub
End Class