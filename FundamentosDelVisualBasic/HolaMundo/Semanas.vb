'1.7. Crear un módulo llamado semanas y en el declarar las siguientes constantes: días del año, días
'laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas semanas son
'laborables.

Module Semanas

    Public Const DiasDelAño As Integer = 365
    Public Const DiasDeLaSemana As Integer = 7

    Sub main()

        Console.WriteLine("Cantidad de Semanas del año: " & DiasDelAño / DiasDeLaSemana)
        Console.WriteLine()
        Console.WriteLine("Cantidad de Semanas Laborales del año: " & DiasDelAño / (DiasDeLaSemana - 2))
        Console.ReadKey()

    End Sub
End Module
