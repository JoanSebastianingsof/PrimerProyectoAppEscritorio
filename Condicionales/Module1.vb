Module Module1

    Sub Main()
        Dim num1 As Double = 0
        Dim num2 As Double = 0
        'leer valores por consola
        Console.WriteLine("Introduzca un valor #1")
        num1 = Console.ReadLine()
        Console.WriteLine("Introduzca un valor #2")
        num2 = Console.ReadLine()


        'Condicional simple
        If (num1 > num2) Then
            Console.WriteLine("num1 es mayor a num2")
        Else
            Console.WriteLine("num2 es mayor a num1")
        End If
        'Anidados
        If (num1 >= num2) Then
            Console.WriteLine("num1 es mayor a num2")
        Else
            If (num2 Mod 2 = 0) Then
                Console.WriteLine("num2 es mayor a num1 y es par")
            ElseIf (num2 > 100) Then
                Console.WriteLine("num2 es mayor a num1,es impar")
            End If
        End If

    End Sub

End Module
