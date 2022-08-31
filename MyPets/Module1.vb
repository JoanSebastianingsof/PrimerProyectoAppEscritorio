Module Module1

    Sub Main()
        Dim myPerson As Person = New Person("Julio", "Calderon", 13456789, "3505045862")
        Dim cats(1) As Cat
        For i = 0 To 1 Step 1
            Dim idP, ageP, numberL As Integer
            Dim nameP, breedP As String
            Console.WriteLine("Introduzca id:")
            idP = Console.ReadLine()
            Console.WriteLine("Introduzca edad:")
            ageP = Console.ReadLine()
            Console.WriteLine("Introduzca numero de vidas :")
            numberL = Console.ReadLine()
            Console.WriteLine("Introduzca Nombre:")
            nameP = Console.ReadLine()
            Console.WriteLine("Introduzca raza:")
            breedP = Console.ReadLine()

            Dim gatito As New Cat(idP, nameP, breedP, ageP, myPerson, numberL)
            cats(i) = gatito

        Next
        For Each c As Cat In cats
            Console.WriteLine("*********************************")
            Console.WriteLine(c.Owner1.name & " " & c.Owner1.lastName)
            Console.WriteLine(c.NamePet1 & " " & c.NumberLifes1 & "" & c.AgePet1)

        Next

    End Sub

End Module
