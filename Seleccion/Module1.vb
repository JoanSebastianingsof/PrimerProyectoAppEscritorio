Module Module1

    Sub Main()
        Dim option1 As Integer
        option1 = 3
        Select Case option1
            Case 1
                Console.WriteLine("Opcion 1")
            Case 2
                Console.WriteLine("Opcion 2")
            Case 3
                Console.WriteLine("Opcion 3")
            Case 4 To 10
                Console.WriteLine("Opcion 4 a 10")
            Case Else
                Console.WriteLine("Otras Opciones")
        End Select

    End Sub

End Module
