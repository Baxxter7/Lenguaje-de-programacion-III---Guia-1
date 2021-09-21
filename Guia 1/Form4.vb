'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'4. Dado el siguiente arreglo a={2,5,4,9,0,2,8,7,4,2,1,10,11,2}, desarrolle un programa que 
'recorra el arreglo e indique sin un valor, ingresado a través de textbox existe, y además 
'cuántas veces se encuentra en el arreglo.

Public Class Form4
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        'Ordenación inserccion
        Dim a = {2, 5, 4, 9, 0, 2, 8, 7, 4, 2, 1, 10, 11, 2}
        Dim i, j, aux As Integer
        Dim contador As Integer = 0

        For i = 1 To a.Length - 1 Step 1

            For j = i To 1 Step -1
                If a(j) < a(j - 1) Then

                    aux = a(j)
                    a(j) = a(j - 1)
                    a(j - 1) = aux
                End If
            Next

        Next

        'Busqueda binaria
        Dim clave As Integer

        'Buscar
        clave = CType(txtResultado.Text, Integer)


        For i = 0 To a.Length - 1
            If clave = a(i) Then
                contador = contador + 1
            End If
        Next


        MsgBox("Del elemento" + Str(clave) + " se han encontrado " + Str(contador) + " coincidencias")
    End Sub
End Class