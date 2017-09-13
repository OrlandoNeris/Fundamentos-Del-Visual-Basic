Module Variables

    Sub Main()
        Dim Nombre As String
        Dim Dni As String
        Dim Localidad As String
        Dim FecNac As Date
        Dim Edad As UShort
        Dim Altura As Integer
        Dim Argentinidad As Boolean


        Nombre = "Orlando"
        Dni = "37.659.231"
        Localidad = "Posadas"
        FecNac = #12/12/1996#
        Edad = 89
        Altura = 1.93
        Argentinidad = True


        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Dni: " & Dni)
        Console.WriteLine("Localidad: " & Localidad)
        Console.WriteLine("Fecha de Nacimiento: " & FecNac)
        Console.WriteLine("Edad: " & Edad)
        Console.WriteLine("Altura: " & Altura)
        Console.WriteLine(If(Argentinidad, "Soy Argentino", "No soy Argentino"))

        Console.ReadKey()

    End Sub

End Module
