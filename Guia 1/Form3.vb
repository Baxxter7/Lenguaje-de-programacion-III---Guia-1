'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'3 Dado el siguiente arreglo a={98,34,21,45,67,12,32,14}, desarrolle un programa que recorra 
'el arreglo e indique si un valor existe o no. El valor a buscar debe ser ingresado por un 
'textbox.Si el valor existe despliegue el mensaje “Si Existe”, caso contrario despliegue el
'mensaje “No Existe”

Public Class Form3
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click

        'Ordenación inserccion
        Dim a = {98, 34, 21, 45, 67, 12, 32, 14}
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

        'Busqueda binaria
        Dim central, bajo, alto As Integer
        Dim valorCentral As Integer
        Dim clave As Integer
        Dim flag As Boolean = False

        'Buscar
        clave = CType(txtResultado.Text, Integer)

        bajo = 0
        alto = a.Length - 1

        While (bajo <= alto)
            central = (bajo + alto) / 2

            valorCentral = a(central)

            If (clave = valorCentral) Then
                'flag = True
                MsgBox("El elemento" + Str(clave) + " SI existe")
                Exit Sub

            ElseIf (clave < valorCentral) Then
                alto = central - 1
            Else
                bajo = central + 1
            End If

        End While

        'Mostrar los datos ordenados
        MsgBox("El elemento" + Str(clave) + " NO existe")
    End Sub
End Class
