Module MenorDeTres
    Sub main()

        Console.WriteLine("Ingrese Primer numero: ")
        Dim a As Integer = Console.ReadLine
        Console.WriteLine("Ingrese Segundo Numero: ")
        Dim b As Integer = Console.ReadLine
        Console.WriteLine("Ingrese tercer numero: ")
        Dim c As Integer = Console.ReadLine

        If a > b And a > c Then
            Console.WriteLine("El mayor numero es: " & a)
        End If
        If b > a And b > c Then
            Console.WriteLine("El Mayor numero es: " & b)
        End If
        If c > a And c > b Then
            Console.WriteLine("El Mayor numero es: " & c)
        End If

        Console.ReadKey()

    End Sub
End Module
