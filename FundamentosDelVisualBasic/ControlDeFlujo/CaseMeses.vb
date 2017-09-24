'Case .Crear un programa con una enumeración para los meses del año.
'Ingresar un valor numérico y mostrar a que mes corresponde.
'Si el valor es inválido mostrar el mensaje correspondiente.

Module CaseMeses
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

    Dim aux As Integer

    Sub main()

        Carga()

        Select Case aux
            Case 1
                Console.WriteLine("El Mes Ingresado Es: " & Meses.enero.ToString)
            Case 2
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Febrero.ToString)
            Case 3
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Marzo.ToString)
            Case 4
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Abril.ToString)
            Case 5
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Mayo.ToString)
            Case 6
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Junio.ToString)
            Case 7
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Julio.ToString)
            Case 8
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Agosto.ToString)
            Case 9
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Septiembre.ToString)
            Case 10
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Octubre.ToString)
            Case 11
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Noviembre.ToString)
            Case 12
                Console.WriteLine("El Mes Ingresado Es: " & Meses.Diciembre.ToString)
            Case Else
                Console.WriteLine("Valor Ingresado Fuera de Rango")
                Carga()
        End Select
        Console.ReadKey()
    End Sub

    Sub Carga()
        Console.WriteLine("Ingrese El Valor Del mes a buscar: ")
        aux = Console.ReadLine()
    End Sub
End Module
