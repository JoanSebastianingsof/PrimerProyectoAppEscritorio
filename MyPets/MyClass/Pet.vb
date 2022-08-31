Public Class Pet
    Private idPet As Integer
    Private namePet As String
    Private breedPet As String
    Private agePet As Integer
    Private owner As Person
    Public Sub New()
    End Sub

    Public Sub New(idPet As Integer, namePet As String, breedPet As String, agePet As Integer, owner As Person)
        Me.idPet = idPet
        Me.namePet = namePet
        Me.breedPet = breedPet
        Me.agePet = agePet
        Me.owner = owner
    End Sub

    Public Property IdPet1 As Integer
        Get
            Return idPet
        End Get
        Set(value As Integer)
            idPet = value
        End Set
    End Property

    Public Property NamePet1 As String
        Get
            Return namePet
        End Get
        Set(value As String)
            namePet = value
        End Set
    End Property

    Public Property BreedPet1 As String
        Get
            Return breedPet
        End Get
        Set(value As String)
            breedPet = value
        End Set
    End Property

    Public Property AgePet1 As Integer
        Get
            Return agePet
        End Get
        Set(value As Integer)
            agePet = value
        End Set
    End Property

    Public Property Owner1 As Person
        Get
            Return owner
        End Get
        Set(value As Person)
            owner = value
        End Set
    End Property

    Public Function registerPet() As Boolean
        Return True
    End Function
    Public Function updatePet() As Boolean
        Return True
    End Function
    Public Function unsubscribe()
        Return True

    End Function
End Class
