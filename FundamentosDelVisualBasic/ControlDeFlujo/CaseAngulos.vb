
'2.7. CASE: Elaborar un algoritmo que lea el tamaño de un ángulo en grados e imprimir el mensaje
'correspondiente según la siguiente tabla:
'Agudo si es menor a 90°
'Recto si es igual a 90°
'Obtuso si es mayor que 90° pero menor que 180°
'Llano si es igual a 180°
'Cóncavo si es mayor que 180° pero menor que 360°
'Error Si el valor es menor a 0º o mayor de 360º

Module CaseAngulos
    Dim aux As Integer

    Sub main()
        Carga()

        Select Case aux
            Case 1 To 89
                Console.WriteLine("El Angulo es Agudo! ")
            Case 90
                Console.WriteLine("El Angulo es Recto! ")
            Case 91 To 179
                Console.WriteLine("El Angulo es Obstuso! ")
            Case 180
                Console.WriteLine("El Angulo es Llano! ")
            Case 181 To 359
                Console.WriteLine("El Angulo es Concavo")
            Case Else
                Console.WriteLine("El Valor Ingresado Esta Fuera Del Rango Permitido, Intente de Nuevo.")
                Carga()
        End Select

        Console.ReadKey()
    End Sub

    Sub Carga()
        Console.WriteLine("Ingrese El Valor Del Angulo: ")
        aux = Console.ReadLine()
    End Sub
End Module
