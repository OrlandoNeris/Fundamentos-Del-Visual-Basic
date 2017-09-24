'Realizar un programa que dé como resultado los intereses producidos y el capital
'acumulado de un monto m invertido a un interés anual r durante t días. La fórmula utilizada es
'I = m * r * t / 360 * 100 
'∗
'donde I es el interés producido. Ingresar por teclado el monto, el interés y el tiempo.

Module CapitalAcumulado

    Dim InteresesProducidos As Integer
    Dim Monto As Integer
    Dim InteresAnual As Integer
    Dim CantDias As Integer

    Sub main()

        Console.WriteLine("Ingrese Monto a Calcular: ")
        Monto = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Ingrese Interes: ")
        InteresAnual = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Ingrese Cantidad de Dias : ")
        CantDias = Console.ReadLine()
        Console.WriteLine()

        InteresesProducidos = (Monto * InteresAnual * CantDias) / (360 * 100)
        Console.WriteLine("Interes Generado: " & InteresesProducidos)

        Console.ReadKey()
    End Sub
End Module