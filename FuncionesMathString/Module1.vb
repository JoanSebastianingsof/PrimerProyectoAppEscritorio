Module Module1

    Sub Main()
        Dim num1 As Double = 3.564
        Dim num2 As Double = 9.43
        'numero Pi

        Console.WriteLine(Math.PI)
        'Euler
        Console.WriteLine(Math.E)
        'Potencia
        Console.WriteLine(Math.Round(Math.Pow(num1, 4), 2))
        'Raiz cuadrada
        Console.WriteLine(Math.Round(Math.Sqrt(num2), 2))
        '***********************************
        Dim cad1 As String = "Holaaaaaaaaa"
        Dim cad2 As String = "Holaaaaaaaaa2"
        Dim cad3 As String = "HOLAAAAAAAAA3"
        'Volver cadena mayuscula
        Console.WriteLine(cad1.ToUpper)
        Console.WriteLine(UCase(cad2))
        Console.WriteLine(cad3.ToLower)
        'equals , Replace
        'Len y Length
        Console.WriteLine(cad3.Length & "   " & Len(cad1))







    End Sub

End Module
