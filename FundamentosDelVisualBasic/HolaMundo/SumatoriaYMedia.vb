'1.6. Crear un programa que calcule la sumatoria y la media de cuatro números enteros ingresados
'por teclado

Module SumatoriaYMedia
    Sub main()

        Console.WriteLine("Programa de carga y Media de numeros!! ")
        Console.WriteLine()

        Dim Acumulador As Integer = 0

        Console.WriteLine("Ingrese Numero 1: ")
        Dim Numero1 As Integer = Console.ReadLine()

        Console.WriteLine("Ingrese Numero 2: ")
        Dim Numero2 As Integer = Console.ReadLine()

        Console.WriteLine("Ingrese Numero 3: ")
        Dim Numero3 As Integer = Console.ReadLine()

        Console.WriteLine("Ingrese Numero 4: ")
        Dim Numero4 As Integer = Console.ReadLine()

        Console.WriteLine("La Sumatoria de los Numeros ingresados es: " & Numero1 + Numero2 + Numero3 + Numero4)
        Console.WriteLine()
        Console.WriteLine("El Promedio de los Numeros Ingresados es: " & (Numero1 + Numero2 + Numero3 + Numero4) / 4)
        Console.ReadKey()

    End Sub
End Module
