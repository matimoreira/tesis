Imports System.Net
Public Class Conexion
    Private _url As String
    Private _datos As String
    Protected Shared _cookies As New CookieContainer

    Public Sub New()
        _url = ""
        _datos = ""
    End Sub

    Public Sub New(url As String)
        Me.New()
        Me.URL = url
    End Sub

    Public Sub New(url As String, datos As String)
        Me.New()
        Me.URL = url
        Me.Datos = datos
    End Sub

    Property URL As String
        Get
            Return _url
        End Get
        Set(value As String)
            _url = value
        End Set
    End Property

    Property Datos As String
        Get
            Return _datos
        End Get
        Set(value As String)
            _datos = value
        End Set
    End Property

    'Friend Shared ReadOnly Property Cookies As CookieContainer
    '    Get
    '        Return _cookies
    '    End Get
    'End Property

    Public Function RealizarPOST() As String
        Dim uri As New Uri(URL)
        If (uri.Scheme = Uri.UriSchemeHttp) Or (uri.Scheme = Uri.UriSchemeHttps) Then

            Dim datosPost As String
            datosPost = Datos
            Dim encoding As New Text.UTF8Encoding
            Dim byteData As Byte() = encoding.GetBytes(datosPost)

            Dim request As HttpWebRequest = WebRequest.Create(uri)
            request.Method = WebRequestMethods.Http.Post
            request.AllowAutoRedirect = False
            request.CookieContainer = _cookies
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteData.Length

            Dim postreqstream As IO.Stream = request.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()

            Dim response As HttpWebResponse = request.GetResponse()
            Dim reader As New IO.StreamReader(response.GetResponseStream(), encoding)
            Dim tmp As String = reader.ReadToEnd()
            response.Close()
            Return tmp
        End If
        Return "FALLO"
    End Function

    Public Function RealizarGET() As String
        Dim uri As New Uri(URL)
        If (uri.Scheme = Uri.UriSchemeHttp) Or (uri.Scheme = Uri.UriSchemeHttps) Then
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = WebRequestMethods.Http.Get
            request.AllowAutoRedirect = False
            request.CookieContainer = _cookies
            Dim response As HttpWebResponse = request.GetResponse()
            Dim reader As New IO.StreamReader(response.GetResponseStream())
            Dim tmp As String = reader.ReadToEnd()
            response.Close()
            Return tmp
        End If
        Return "FALLO"
    End Function

    Public Overrides Function ToString() As String
        Return "URL: " & URL & vbNewLine & "Datos: " & Datos
    End Function
End Class
