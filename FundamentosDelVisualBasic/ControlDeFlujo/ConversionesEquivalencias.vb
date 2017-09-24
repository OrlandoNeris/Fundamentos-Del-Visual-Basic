'2.9. Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros,
'centímetros, yardas, pies y pulgadas:  
' Presentar un menú y preguntar que unidad de medida desea convertir,
'el valor a convertir y después mostrar las equivalencias.
' Utilizar únicamente las equivalencias conocidas
' 1 pie = 12 pulgadas,
' 1 yarda = 3 pies,
' 1 pulgada = 2.54 cm,
' 1 metro = 100 cm.
' Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, 
'luego imprimir la equivalencia en centímetros, pies, yardas y pulgadas. 

Module ConversionesEquivalencias

    Dim Metro As Integer = 100
    Dim Pulgada As Integer = 2.54
    Dim Pie As Integer = Pulgada * 12
    Dim Yarda As Integer = Pie * 3


End Module
