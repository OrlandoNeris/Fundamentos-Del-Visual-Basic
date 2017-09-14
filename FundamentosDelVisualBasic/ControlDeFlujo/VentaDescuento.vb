Module VentaDescuento

    'F: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).

    Sub main()

        Console.WriteLine("Ingrese Cantidad del producto: ")
        Dim cantidad As Integer = Console.ReadLine
        Console.WriteLine("Ingrese Precio Unitario del producto: ")
        Dim precioU As Integer = Console.ReadLine

        Dim descuento As Integer = 0
        Dim total As Integer
        Dim subtotal As Integer
        Dim montodescontado As Integer


        If cantidad >= 10 And cantidad <= 50 Then
            descuento = 5
        ElseIf cantidad > 50 And cantidad <= 250 Then
            descuento = 10
        ElseIf cantidad > 250 Then
            descuento = 20
        End If

        subtotal = cantidad * precioU
        montodescontado = (subtotal * descuento) / 100
        total = subtotal - montodescontado
        Console.WriteLine("INFORMESS ><-<<<-<-<-<-<-<-<")
        Console.WriteLine("Cantidad: " & cantidad)
        Console.WriteLine("Precio Unitario: " & precioU)
        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("Porcentaje de descuento aplicado: " & descuento & "%")
        Console.WriteLine("Monto descontado: " & montodescontado)
        Console.WriteLine("Total: " & total)
        Console.ReadKey()

    End Sub

End Module
