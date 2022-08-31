Public Class Person
    Implements IPerson

    Private _name As String
    Private _lastname As String
    Private _document As Long
    Private _phoneNumber As String

    Public Sub New(name As String, lastname As String, document As Long, phoneNumber As String)
        _name = name
        _lastname = lastname
        _document = document
        _phoneNumber = phoneNumber
    End Sub

    Public Sub New()
        _name = ""
        _lastname = ""
        _document = 0
        _phoneNumber = ""
    End Sub

    Public Property name As String Implements IPerson.name
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property lastname As String Implements IPerson.lastname
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Public Property document As Long Implements IPerson.document
        Get
            Return _document
        End Get
        Set(value As Long)
            _document = value
        End Set
    End Property

    Public Property phoneNumber As String Implements IPerson.phoneNumber
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property
End Class
