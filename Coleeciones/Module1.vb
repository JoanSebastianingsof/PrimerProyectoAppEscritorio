Module Module1

    Sub Main()
        'arrayList1()
        dictionaryCollection()
    End Sub
    Sub arrayList1()
        'Declarar una coleccion
        Dim myCollection As New List(Of String)
        Dim values As String
        For i = 0 To 3
            Console.WriteLine("Introduza el nombre del estudiante" & i + 1 & ":")
            values = Console.ReadLine()
            'Agregar el valor a la coleccion 
            myCollection.Add(values)
        Next
        For Each j As String In myCollection
            Console.WriteLine(j)
        Next


    End Sub
    Sub dictionaryCollection()
        'Decalaracion de diccionario
        Dim myDictiorary As New Dictionary(Of String, String)
        myDictiorary.Add(key:="uno ", value:="Soy Uno")
        myDictiorary.Add(key:="dos ", value:="Soy dos")
        myDictiorary.Add(key:="tres ", value:="Soy tres")
        For Each y In myDictiorary
            Console.Write(y.Key)
            Console.WriteLine(y.Value)
        Next
    End Sub
End Module

