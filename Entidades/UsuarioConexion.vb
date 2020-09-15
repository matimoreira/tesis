Imports System.Net
Public Class UsuarioConexion
    Inherits Conexion
    Public Shared Function login(usuario As Usuario) As String
        Dim uri As New Uri("http://tesis/SourceFiles/Login/")
        Dim datosPost As String
        datosPost = "platform=desktop&usuario=" & ConversorJSON.ConvertirObj_JSON(usuario)
        Dim encoding As New Text.UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(datosPost)

        Dim request As HttpWebRequest = WebRequest.Create(uri)
        request.Method = WebRequestMethods.Http.Post
        request.AllowAutoRedirect = False
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteData.Length

        Dim postreqstream As IO.Stream = request.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()

        Dim response As HttpWebResponse = request.GetResponse()
        Try
            Dim idSession As String = response.Headers.Item("Set-Cookie").Substring(10, 26)
            Dim cookieSesion As New Cookie("PHPSESSID", idSession)
            cookieSesion.Domain = uri.Host
            cookieSesion.Expires = DateTime.Now.AddMonths(1)
            response.Cookies.Add(cookieSesion)
        Catch
        End Try
        Conexion._cookies.Add(response.Cookies)
        Dim reader As New IO.StreamReader(response.GetResponseStream(), encoding)
        Dim tmp As String = reader.ReadToEnd()
        response.Close()
        Return tmp
    End Function

    Public Shared Sub logout()
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/Logout/"
        conexion.Datos = "platform=desktop"
        conexion.RealizarPOST()
    End Sub
End Class
