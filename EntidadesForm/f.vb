'Imports Entidades
'Public Class f

'    Private Sub printListBox(respJSON As String)
'        Dim listaServicios As List(Of ServicioAdicional)
'        listaServicios = ConversorJSON.ConvertirJSON_ListOfServicioAdicional(respJSON)
'        ListBox1.Items.Clear()
'        For Each servicio As ServicioAdicional In listaServicios
'            ListBox1.Items.Add(servicio)
'        Next
'    End Sub

'    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        printListBox(ServicioAdicionalConexion.getAll())
'    End Sub

'    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
'        Try
'            TextBox3.Name = ListBox1.Items.Item(ListBox1.SelectedIndex).id_servicio
'            TextBox3.Text = ListBox1.Items.Item(ListBox1.SelectedIndex).descripcion
'        Catch
'        End Try
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        printListBox(ServicioAdicionalConexion.getBusqueda(TextBox1.Text))
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        ServicioAdicionalConexion.addServicio(TextBox2.Text)
'        printListBox(ServicioAdicionalConexion.getAll())
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        ServicioAdicionalConexion.modificarServicio(TextBox3.Name, TextBox3.Text)
'        TextBox3.Name = "0"
'        TextBox3.Text = ""
'        printListBox(ServicioAdicionalConexion.getAll())
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'        ServicioAdicionalConexion.borrarServicio(TextBox3.Name)
'        TextBox3.Name = "0"
'        TextBox3.Text = ""
'        printListBox(ServicioAdicionalConexion.getAll())
'    End Sub

'    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
'        TextBox3.Name = "0"
'        TextBox3.Text = ""
'    End Sub
'End Class