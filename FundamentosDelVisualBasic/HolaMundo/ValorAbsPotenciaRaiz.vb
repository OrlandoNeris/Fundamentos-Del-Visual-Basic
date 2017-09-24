'1.11. Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la
'décima potencia y su raíz cuadrada

Module ValorAbsPotenciaRaiz
    Sub main()

        Console.WriteLine("Ingrese un Valor: ")
        Dim Valor As Integer = Console.ReadLine

        Console.WriteLine("Valor Absoluto: " & Math.Abs(Valor))
        Console.WriteLine()
        Console.WriteLine("Decima Potencia: " & Math.Pow(Valor, 10))
        Console.WriteLine()
        Console.WriteLine("Raiz Cuadrada: " & Math.Sqrt(Valor))
        Console.ReadKey()

    End Sub
End Module