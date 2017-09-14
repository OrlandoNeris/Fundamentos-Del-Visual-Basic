Module MayorMenorIgual

    Sub Main()
        Console.WriteLine("Ingrese primer numero: ")
        Dim num1 = Console.ReadLine
        Console.WriteLine("Ingrese segundo numero: ")
        Dim num2 = Console.ReadLine

        If (num1 = num2) Then
            Console.WriteLine("Los numeros ingresados son iguales")
        End If
        If (num1 > num2) Then
            Console.WriteLine("El primer valor es mayor al segundo")
        ElseIf (num1 < num2) Then
            Console.WriteLine("El segundo valor es mayor")
        End If

        Console.ReadKey()

    End Sub

End Module
