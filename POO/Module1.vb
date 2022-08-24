Module Module1

    Sub Main()
        'Instanciar objeto person 
        Dim person1 = New Person()
        person1.printing()
        Dim person2 = New Person("Carlos Mauricion", "Perez", 34, 1234564)
        person2.printing()
        Dim person3 = New Person(12)
        Console.WriteLine(person3.statusAge())
    End Sub

End Module
