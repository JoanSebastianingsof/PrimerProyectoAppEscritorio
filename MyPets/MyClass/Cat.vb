Public Class Cat : Inherits Pet
    Private numberLifes As Short

    Public Sub New(idPet As Integer, namePet As String, breedPet As String, agePet As Integer, owner As Person, numberLifes As Short)
        MyBase.New(idPet, namePet, breedPet, agePet, owner)
        Me.numberLifes = numberLifes
    End Sub

    Public Property NumberLifes1 As Short
        Get
            Return numberLifes
        End Get
        Set(value As Short)
            numberLifes = value
        End Set
    End Property
End Class
