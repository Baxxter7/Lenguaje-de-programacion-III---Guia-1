'Nombre: Josue Isaias Martinez
'N° Cuenta: 20201002923
'Descripción:
'7. Dado el siguiente escenario: el arreglo “a” tiene 6 elementos con valores enteros entre 0 y 
'9; el arreglo “b” tiene 7 elementos con valores enteros entre 0 y 9; el arreglo “c” será el 
'vector que contendrá la suma de los elementos de los arreglos “a” y “b”. 

Public Class Form7
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click

        Dim a = {0, 1, 0, 3, 4, 1, 8} 'Mas grande
        Dim b = {9, 1, 9, 4, 6}  'Mas pequeño
        Dim c(6) As Integer

        Dim numero As Integer = 14
        Dim i, j As Integer
        Dim suma, sobrante As Integer

        txtResultado.Text = " "
        j = b.Length - 1

        For i = a.Length - 1 To 0 Step -1

            If j <> -1 Then
                MsgBox(Str(a(i)) + " " + Str(b(j)))
                suma = a(i) + b(j)
                c(i) = suma Mod 10

                If (CType(suma / 10, Double)) < 1 Then
                    sobrante = 0
                Else
                    suma = suma / 10
                    sobrante = CInt(suma)
                End If

                a(i - 1) = a(i - 1) + sobrante


                MsgBox(c(i))
                MsgBox(" Yo soy lo que sobra" + Str(sobrante))
                j = j - 1

            Else
                MsgBox(Str(a(i)))
                suma = a(i)
                c(i) = suma
            End If

        Next

        For i = 0 To c.Length - 1 Step 1
            txtResultado.Text = txtResultado.Text + " " + Str(c(i))
        Next
    End Sub
End Class