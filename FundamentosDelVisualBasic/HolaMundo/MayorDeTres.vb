'1.13. Elabore un programa que lea tres números y muestre el mayor. 

Module MayorDeTres
    Dim valor1, valor2, valor3, mayor As Integer

    Sub main()
        Console.WriteLine("Ingrese  Valor1: ")
        valor1 = Console.ReadLine()
        If valor1 > mayor Then
            mayor = valor1
        End If
        Console.WriteLine()

        Console.WriteLine("Ingrese  Valor2: ")
        valor2 = Console.ReadLine()
        If valor2 > mayor Then
            mayor = valor2
        End If
        Console.WriteLine()

        Console.WriteLine("Ingrese  Valor3: ")
        valor3 = Console.ReadLine()
        If valor3 > mayor Then
            mayor = valor3
        End If
        Console.WriteLine()

        Console.WriteLine("El Mayor de los Numero Ingresados es: " & mayor)
        Console.ReadKey()

    End Sub
End Module