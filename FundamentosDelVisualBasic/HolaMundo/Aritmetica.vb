Module Aritmetica
    Sub main()
        Dim Entero1 As Integer = 20
        Dim Entero2 As Integer = 2
        Dim Float1 As Single = 1.4
        Dim Float2 As Single = 3.5

        Console.WriteLine("Suma Entero1 con Entero2 = " & Entero1 + Entero2)
        Console.WriteLine("Multiplicacion Entero1 con Entero2 = " & Entero1 * Entero2)
        Console.WriteLine("Division Entero1 con Entero2 = " & Entero1 / Entero2)
        Console.WriteLine("Resta Entero1 con Entero2 = " & Entero1 - Entero2)
        Console.WriteLine()

        Console.WriteLine("Suma Float1 con Entero2 = " & Float1 + Entero2)
        Console.WriteLine("Multiplicacion Float1 con Entero2 = " & Float1 * Entero2)
        Console.WriteLine("Division Float1 con Entero2 = " & Float1 / Entero2)
        Console.WriteLine("Resta Float1 con Float2 = " & Float1 - Entero2)
        Console.WriteLine()

        Console.WriteLine("Suma Float1 con Float2 = " & Float1 + Float2)
        Console.WriteLine("Multiplicacion Float1 con Float2 = " & Float1 * Float2)
        Console.WriteLine("Division Float1 con Float2 = " & Float1 / Float2)
        Console.WriteLine("Resta Float1 con Float2 = " & Float1 - Float2)
        Console.ReadKey()

    End Sub
End Module
