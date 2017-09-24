
'2.8. Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
'condiciones:
' El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
' En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.


Enum Meses2
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

Module DiasDelMes
    Dim año As UInteger = 0
    Dim aux As UInteger = 0
    Sub main()
        cargar()
        Select Case aux
            Case 1
                Console.WriteLine("Este Mes de " & Meses2.enero.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 1) & " Dias.")
            Case 2
                Console.WriteLine()
                Console.WriteLine("Ingrese El Año del Mes a Buscar: ")
                año = Console.ReadLine
                Console.WriteLine("Este Mes de " & Meses2.Febrero.ToString & " Tiene " & DateTime.DaysInMonth(año, 2) & " Dias.")
            Case 3
                Console.WriteLine("Este Mes de " & Meses2.Marzo.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 3) & " Dias.")
            Case 4
                Console.WriteLine("Este Mes de " & Meses2.Abril.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 4) & " Dias.")
            Case 5
                Console.WriteLine("Este Mes de " & Meses2.Mayo.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 5) & " Dias.")
            Case 6
                Console.WriteLine("Este Mes de " & Meses2.Junio.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 6) & " Dias.")
            Case 7
                Console.WriteLine("Este Mes de " & Meses2.Julio.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 7) & " Dias.")
            Case 8
                Console.WriteLine("Este Mes de " & Meses2.Agosto.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 8) & " Dias.")
            Case 9
                Console.WriteLine("Este Mes de " & Meses2.Septiembre.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 9) & " Dias.")
            Case 10
                Console.WriteLine("Este Mes de " & Meses2.Octubre.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 10) & " Dias.")
            Case 11
                Console.WriteLine("Este Mes de " & Meses2.Noviembre.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 11) & " Dias.")
            Case 12
                Console.WriteLine("Este Mes de " & Meses2.Diciembre.ToString & " Tiene " & DateTime.DaysInMonth(Date.Today.Year, 12) & " Dias.")
            Case Else
                Console.WriteLine("Valor Fuera del Rango Permitido. ")
                cargar()
        End Select

        Console.ReadKey()
    End Sub
    Sub cargar()
        Console.WriteLine("Ingrese mes a buscar: ")
        aux = Console.ReadLine
    End Sub
End Module
