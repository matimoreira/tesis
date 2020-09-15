Imports Entidades
Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TxtEmail.Text
        Dim pass As String = TxtPass.Text
        Dim usuario As New Usuario
        usuario.Email = email
        usuario.Pass = pass

        Dim respuestaLoginJSON As String = UsuarioConexion.login(usuario)
        Dim respuestaLogin As Dictionary(Of String, String) = ConversorJSON.ConvertirJSON_Dictionary(respuestaLoginJSON)
        Try
            If respuestaLogin.Item("resultado") = "1" Then
                Dim menu As New MenuPrincipalForm
                menu.Show()
                Me.Hide()
                Return
            Else
                MsgBox("Lo sentimos, la cuenta ingresada no es valida")
            End If
        Catch
            MsgBox("Lo sentimos, la cuenta ingresada no es valida")
        End Try
    End Sub
End Class