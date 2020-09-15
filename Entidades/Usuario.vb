Imports System.IO
Public Class Usuario
    Private _id As Integer
    Private _nick As String
    Private _email As String
    Private _pass As String

    Public Sub New()
        _id = 0
        _nick = ""
        _email = ""
        _pass = ""
    End Sub

    Public Sub New(idUsuario As Integer, pNick As String, pEmail As String, pPass As String)
        id_usuario = idUsuario
        Nick = pNick
        Email = pEmail
        Pass = pPass
    End Sub

    Public Property id_usuario As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Nick As String
        Get
            Return _nick
        End Get
        Set(value As String)
            _nick = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return id_usuario
    End Function
End Class
