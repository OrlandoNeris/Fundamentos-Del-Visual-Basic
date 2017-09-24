
'    1.5. Crear un programa que resuelva la siguiente ecuación
'    
'       X=b^2-4.a.c % 2.a

'   donde a = 1, b = 5 y c=2.
'Mostrar el resultado obtenido

Module Resolvente


    Sub main()

        Dim A As Integer = 1
        Dim B As Integer = 5
        Dim C As Integer = 2
        Dim Resultado As Integer = 0

        Resultado = (Math.Pow(B, 2) - (4 * A * C)) / (2 * A)



        Console.WriteLine("Calculo de Resolvente: " & Resultado)
        Console.ReadKey()

    End Sub

End Module
