Module CapitalAcumulado
    Sub main()

        Dim M As Integer 'Monto Invertido
        Dim R As Integer 'Interes Anual
        Dim T As Integer 'Dias

        M = 1000
        R = 2.5
        T = 180

        Console.WriteLine((M * R * T) / (360 * 100))

        Console.ReadKey()
    End Sub

End Module
