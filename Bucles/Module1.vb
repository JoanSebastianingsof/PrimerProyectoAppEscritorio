Module Module1
    Dim ejemplo2Scope As String = "Existo dentro del main"

    Sub Main()

        'While,For,For Each, Do Loop While Until
        Dim i As Integer = 0
        'While i <= 10
        'Console.WriteLine("Valor del indice:" & i)
        'i += 1
        'End While
        Do
            Console.WriteLine("Valor del indice:" & i)
            i += 1
        Loop Until (i > 10)
        For j As Short = 0 To 10 Step 3

            Console.WriteLine("Valor del indice:" & j)
            If (j >= 9) Then
                Console.WriteLine(ejemplo2Scope)

            End If
        Next



    End Sub

    Sub procedimiento1() 'Como declarar un procedimieto
        Console.WriteLine(ejemplo2Scope)

    End Sub

End Module
