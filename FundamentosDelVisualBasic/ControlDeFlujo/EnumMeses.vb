

'Crear un programa con una enumeración para los meses del año. Ingresar un valor
'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
'correspondiente.

Enum Meses
    enero = 1
    Febrero
    Marzo
    Abril
    Mayo
    Junio
    Julio
    Agosto
    Septiembre
    Octubre
    Noviembre
    Diciembre
End Enum
Module EnumMeses


    Sub main()


        Console.WriteLine("Ingrese mes a buscar: ")
        Dim aux As Integer = Console.ReadLine

        'For Each mes In Meses
        '    If mes = aux Then
        '        Console.WriteLine("El Mes Ingresado Es: " & mes.ToString)
        '    End If

        'Next

        Console.ReadKey()
    End Sub

End Module
