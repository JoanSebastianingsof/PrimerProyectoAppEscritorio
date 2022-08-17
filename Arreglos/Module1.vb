Module Module1

    Sub Main()
        Dim myArray(10) As Double
        ' For i = 0 To 9 Step 1
        'Variable iteradora indica la posicion del valor
        'myArray(i) = i * 3
        'Next
        'For i = 0 To 9 Step 1
        'Variable iteradora indica la posicion del valor
        'Console.WriteLine(myArray(i))
        'Next

        'Pedir los valores al usuario y el tamaño
        Console.WriteLine("Introduzca el tamaño del arreglo")
        Dim Tam As Short = Console.ReadLine()
        ReDim myArray(Tam)

        For i = 0 To Tam Step 1
            'Variable iteradora indica la posicion del valor
            Console.WriteLine("Introduz el valor del arreglo en la posicion {0}", i)
            myArray(i) = Console.ReadLine()
        Next

        For i = 0 To Tam Step 1
            'Variable iteradora indica la posicion del valor
            Console.WriteLine(myArray(i))
        Next
    End Sub

End Module
