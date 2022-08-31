Module Module1

    Sub Main()
        'Instanciar objeto person 
        Dim person1 = New Person(20)
        person1.printing()
        Dim person2 = New Person("Carlos Mauricio", " Perez", 34)
        person2.printing()
        ' Dim person3 = New Person(12)
        ' Console.WriteLine(person3.statusAge())
        Console.WriteLine(person1.calculateAge())
        Console.WriteLine(person2.calculateAge())
    End Sub

End Module
