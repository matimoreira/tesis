Imports Entidades
Public Class MenuPrincipalForm
    Private Sub MenuPrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empresaUsuario As Dictionary(Of String, String)
        empresaUsuario = ConversorJSON.ConvertirJSON_Dictionary(EmpresaConexion.getEmpresaUsuario())
        LblUsuario.Text = empresaUsuario.Item("usuario")
        LblEmpresa.Text = empresaUsuario.Item("empresa")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UsuarioConexion.logout()
        Dim loginForm As New LoginForm
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub EsquemaDeHorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsquemaDeHorariosToolStripMenuItem.Click
        Dim esquemaHorarioForm As New EsquemaHorarioForm
        esquemaHorarioForm.Show()
        Me.Hide()
    End Sub
End Class