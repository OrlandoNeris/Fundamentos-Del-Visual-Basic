'1.8. Crear un módulo llamado concatenación y en el declarar variables para almacenar los siguientes
'datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de inicio de
'actividades.Mostrar los mismos concatenados en la salida de la consola dos veces: la primera
'utilizando conversión explícita y la segunda conversión implícita.

Module Concatenacion

    Dim NombreEmpresa As String = "Pizzeria Coki"
    Dim NombreCalle As String = "Almirante Brown"
    Dim Altura As String = "1234"
    Dim FechaInicio As Date = Date.Today

    Sub main()
        'conversión explícita
        Console.WriteLine("En el dia " + FechaInicio + " da Inicio La Empresa " + NombreEmpresa)
        Console.WriteLine("Domiciliada en la calle " + NombreCalle + " a la altura " + Altura)
        Console.WriteLine()

        'conversión implicita 
        Console.WriteLine("En el dia " & FechaInicio & " da Inicio La Empresa " & NombreEmpresa)
        Console.WriteLine("Domiciliada en la calle " & NombreCalle & " a la altura " & Altura)
        Console.ReadKey()

    End Sub
End Module