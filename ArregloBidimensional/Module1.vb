Module Module1

    Sub Main()
        Dim matriz(0, 0) As Double
        Dim filas As Integer
        Dim columnas As Integer
        Dim contador As Integer = 0
        Do
            Console.WriteLine("Introduzaca la cantidad de filas")
            filas = Console.ReadLine
        Loop While filas < 2
        Do
            Console.WriteLine("Introduzaca la cantidad de columnas")
            columnas = Console.ReadLine
        Loop While columnas < 2
        If filas >= 2 And columnas >= 2 Then
            ReDim matriz(filas, columnas)
            Console.WriteLine("valor del length" & matriz.Length)
            Console.WriteLine("valor del fila" & matriz.GetLength(0))
            Console.WriteLine("valor del columna" & matriz.GetLength(1))

        Else
            Console.WriteLine("Valores invalidos")
        End If
        'Get sirve para leer la cantidad que hay en la matriz
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = contador
                contador = contador + 0.67
            Next

        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()

        Next
    End Sub

End Module
