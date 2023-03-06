Public Class Eusuario
    Private users As String
    Private passwords As String
    Private nivel As String

    Public Property _users
        Get
            Return users
        End Get
        Set(ByVal value)
            users = value
        End Set
    End Property
    Public Property _passwords
        Get
            Return passwords
        End Get
        Set(ByVal value)
            passwords = value
        End Set
    End Property
    Public Property _nivel
        Get
            Return nivel
        End Get
        Set(ByVal value)
            nivel = value
        End Set
    End Property
    Public Sub New()
    End Sub
    Public Sub New(ByVal users As String, ByVal passwords As String, ByVal nivel As String)
        _users = users
        _passwords = passwords
        _nivel = nivel
    End Sub
End Class
