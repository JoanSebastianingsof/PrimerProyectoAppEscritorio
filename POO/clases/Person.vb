Public Class Person
    'Private _name As String
    'Public lastName As String
    'Private _age As Short
    'Private _phoneNumber As Integer


    ''constructores

    'Public Sub New()
    '    Me._name = ""
    '    Me.lastName = ""
    '    Me._age = 0
    '    Me._phoneNumber = 0

    'End Sub

    'Public Sub New(name As String, lastName As String, age As Short, phoneNumber As Integer)
    '    _name = name
    '    Me.lastName = lastName
    '    _age = age
    '    _phoneNumber = phoneNumber
    'End Sub

    'Public Sub New(age As Short)
    '    _age = age
    'End Sub
    'Public Property Name As String
    '    Get
    '        Return _name
    '    End Get
    '    Set(value As String)
    '        _name = value
    '    End Set
    'End Property

    'Public Property Age As Short
    '    Get
    '        Return _age
    '    End Get
    '    Set(value As Short)
    '        _age = value
    '    End Set
    'End Property

    'Public Property PhoneNumber As Integer
    '    Get
    '        Return _phoneNumber
    '    End Get
    '    Set(value As Integer)
    '        _phoneNumber = value
    '    End Set
    'End Property
    ''metodos
    'Public Sub printing()
    '    Console.WriteLine("Datos de la persona: ")
    '    Console.WriteLine("Nombres : {0} Apellidos:{1} ", _name, lastName)
    '    Console.WriteLine("Edad : {0} Telefono:{1} ", _age, PhoneNumber)


    'End Sub
    'Public Function statusAge() As String
    '    Dim response As String
    '    If _age >= 18 Then
    '        response = "Mayor de edad"
    '    Else
    '        response = " Menor de edad"
    '    End If
    '    Return response
    'End Function

    Implements IPersona, IOtro

    Private _name As String
    Private _lastName As String
    Private _age As Integer

    Public Sub New(age As Integer)
        _age = age
    End Sub

    Public Sub New(name As String, lastName As String, age As Integer)
        _name = name
        _lastName = lastName
        _age = age
    End Sub

    Public Property name As String Implements IPersona.name
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property lastName As String Implements IPersona.lastName
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property age As Integer Implements IPersona.age
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property otro As String Implements IOtro.otro
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub printing() Implements IPersona.printing
        Console.WriteLine("Sus datos: nombre{0} apellidos{1} edad {2}", _name, _lastName, _age)
    End Sub

    Public Function calculateAge() As String Implements IPersona.calculateAge
        Dim message = ""
        If (_age >= 18) Then
            message = "Es mayor de edad"
        Else
            message = "Es menor de edad"
        End If
        Return message
    End Function
End Class
