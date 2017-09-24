'Ingresar un número real por teclado y mostrar su valor aproximado por exceso, su valor
'aproximado por defecto y su valor redondeado.

Module ValorAproximado
    Sub main()
        Console.WriteLine("Ingrese un valor: ")
        Dim Valor As Integer = Console.ReadLine

        Console.WriteLine("Valor Aproximado por Exceso: " & Math.Ceiling(Valor))
        Console.WriteLine("Valor Aproximado por Defecto: " & Math.Floor(Valor))
        Console.WriteLine("Valor Redondeado: " & Math.Abs(Valor))
        Console.ReadKey()

    End Sub
End Module
