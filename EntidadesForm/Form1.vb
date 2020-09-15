Imports Entidades
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAll()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        getBusqueda(txtBuscar.Text)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        addServicio(txtAgregar.Text)
    End Sub


    Private Sub printTabla(JSONresp As String)
        Dim arrayResp As New List(Of ServicioAdicional)
        arrayResp = ConversorJSON.ConvertirJSON_ListOfServicioAdicional(JSONresp)

        If TableLayoutPanel1.RowCount > 1 Then
            For x As Integer = 1 To TableLayoutPanel1.RowCount - 1
                For y As Integer = 0 To TableLayoutPanel1.ColumnCount - 1
                    Dim control As Control = TableLayoutPanel1.GetControlFromPosition(y, x)
                    TableLayoutPanel1.Controls.Remove(control)
                Next
            Next

        End If

        For x As Integer = 0 To arrayResp.Count - 1
            TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            TableLayoutPanel1.AutoSize = True
            TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            TableLayoutPanel1.SuspendLayout()
            TableLayoutPanel1.RowCount += 1
            Dim txtDesc As New TextBox
            txtDesc.ReadOnly = True
            txtDesc.TextAlign = HorizontalAlignment.Center
            'txtDesc.Name = arrayResp.Item(x).Id
            txtDesc.Text = arrayResp.Item(x).Descripcion
            TableLayoutPanel1.Controls.Add(txtDesc, 0, TableLayoutPanel1.RowCount - 1)
            Dim btnMod As New Button
            btnMod.Text = "Mod."
            TableLayoutPanel1.Controls.Add(btnMod, 1, TableLayoutPanel1.RowCount - 1)
            Dim btnBorrar As New Button
            btnBorrar.Text = "Borrar"
            TableLayoutPanel1.Controls.Add(btnBorrar, 2, TableLayoutPanel1.RowCount - 1)
            TableLayoutPanel1.ResumeLayout()

        Next
    End Sub

    Public Sub getAll()
        Dim conexion As New Conexion("http://pruebasWamp/pruebaServiciosAdicionales.php")
        printTabla(conexion.RealizarGET())
    End Sub

    Private Sub getBusqueda(strBusqueda As String)
        Dim conexion As New Conexion("http://pruebasWamp/pruebaServiciosAdicionales.php?accion=buscar&value=" & strBusqueda)
        printTabla(conexion.RealizarGET())
    End Sub

    Private Sub addServicio(strAgregar As String)
        Dim conexion As New Conexion("http://pruebasWamp/pruebaServiciosAdicionales.php?accion=add&value=", "value=" & strAgregar)
        conexion.RealizarPOST()
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php"
        conexion.Datos = ""
        printTabla(conexion.RealizarGET())
    End Sub

End Class
