Module MayorDeCinco

    ' Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”

    Sub main()
        Dim mayor As Integer
        Dim pos As Integer

        Console.WriteLine("Ingrese primer numero")
        Dim a As Integer = Console.ReadLine
        mayor = a
        pos = 1

        Console.WriteLine("Ingrese segundo numero")
        Dim b As Integer = Console.ReadLine
        If (b > mayor) Then
            mayor = b
            pos = 2
        End If

        Console.WriteLine("Ingrese primer numero")
        Dim c As Integer = Console.ReadLine
        If c > mayor Then
            mayor = c
            pos = 3
        End If

        Console.WriteLine("Ingrese primer numero")
        Dim d As Integer = Console.ReadLine
        If d > mayor Then
            mayor = d
            pos = 4
        End If

        Console.WriteLine("Ingrese primer numero")
        Dim e As Integer = Console.ReadLine
        If e > mayor Then
            mayor = e
            pos = 5
        End If

        Console.WriteLine("El mayor de los numeros ingresados es " & mayor & " ingresado en " & pos & " lugar")
        Console.ReadKey()

    End Sub

End Module
