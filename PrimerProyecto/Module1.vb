Module Module1

    Sub Main()
        'Impresion por Consola
        'salto de linea
        'Console.WriteLine("otra impresion")
        ' Console.Write("Primera impresion")
        Dim num1 As Integer = 12
        Dim num2 As Integer = 24
        Dim resp As Integer = 0
        Const IVA As Double = 19.1

        resp = num1 + num2
        Console.WriteLine("La suma de num1:{0} y num2:{1} es: {2}", num1, num2, resp)
        resp = num1 * num2
        Console.WriteLine("La multiplicacion de num1:{0} y num2:{1} es: {2}", num1, num2, resp)
        resp = num2 / num1
        Console.WriteLine("La division de num1:{0} y num2:{1} es: {2}", num1, num2, resp)
        resp = num1 - num2
        Console.WriteLine("La resta de num1:{0} y num2:{1} es: {2}", num1, num2, resp)
        resp = num1 ^ num2
        Console.WriteLine("La respuesta de num1:{0} con la potencia de num2:{1} es: {2}", num1, num2, resp)
    End Sub

End Module
