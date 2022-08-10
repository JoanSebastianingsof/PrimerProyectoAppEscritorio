Module Module1
    Dim result As Double = 0
    Sub Main()
        Dim num As Integer = 2
        'addittion(3, 4)
        ' Console.WriteLine(result)
        ' Console.WriteLine(powResult(3, 4))
        Console.WriteLine(num)
        valorReferncia(num)
        Console.WriteLine(num)
        num = 0
        Console.WriteLine(num)

        valorReferncia(num)
        Console.WriteLine(num)

    End Sub

    'Procedimientos
    Sub addittion(ByVal num1 As Double, ByVal num2 As Double)
        result = num1 + num2
    End Sub

    Public Function powResult(base As Double, exp As Integer) As Double
        Return Math.Pow(base, exp)
    End Function

    Sub valorReferncia(ByRef n As Integer)
        n = 250
    End Sub

End Module
