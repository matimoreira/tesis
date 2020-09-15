Imports Entidades
Public Class EsquemaHorarioForm

    Private Sub printListBox(resp As String)

        If resp = "false" Then
            MsgBox("No hay reservas en esta fecha")
            Return
        End If
        LvwReservas.Show()
        LvwReservas.Show()
        Dim reservas As List(Of Dictionary(Of String, String))
        reservas = ConversorJSON.ConvertirJSON_ListOfDictionary(resp)
        LvwReservas.Items.Clear()
        Dim cantReservas As Int16 = reservas.Count
        For i As Int16 = 0 To cantReservas - 1
            Dim reserva As Dictionary(Of String, String)
            reserva = reservas.Item(i)
            LvwReservas.Items.Add(reserva.Item("nombre"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("importe"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("horaDesde"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("horaHasta"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("estado"))
        Next
    End Sub

    Private Sub EsquemaHorarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblFecha.Hide()
        DtPkrFecha.Hide()
        LblReservas.Hide()
        LvwReservas.Hide()
        Dim listSucursales As New List(Of Sucursal)
        listSucursales = ConversorJSON.ConvertirJSON_ListOfSucursal(SucursalConexion.getSucursalesByIdEmpresa)
        ComboBoxSucursal.Items.Clear()
        For Each sucursal As Sucursal In listSucursales
            ComboBoxSucursal.Items.Add(sucursal)
        Next
    End Sub

    Private Sub ComboBoxSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSucursal.SelectedIndexChanged
        Dim sucursal As New Sucursal
        sucursal = ComboBoxSucursal.SelectedItem()
        Dim listEspaciosRaw As String = EspacioRecreativoConexion.getEspaciosByIdSucursal(sucursal)
        Dim listEspacios As New List(Of EspacioRecreativo)
        listEspacios = ConversorJSON.ConvertirJSON_ListOfEspacioRecreativo(listEspaciosRaw)
        ComboBoxEspacio.Items.Clear()
        For Each espacio As EspacioRecreativo In listEspacios
            ComboBoxEspacio.Items.Add(espacio)
        Next
    End Sub

    Private Sub ComboBoxEspacio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEspacio.SelectedIndexChanged
        LblFecha.Show()
        DtPkrFecha.Show()
        Dim fecha As String = DtPkrFecha.Value.ToString("yyyy-MM-dd")
        Dim resp As String = ReservaConexion.getReservasByEspacioFecha(ComboBoxEspacio.SelectedItem, fecha)
        printListBox(resp)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim oMenuPrincipalForm As New MenuPrincipalForm
        oMenuPrincipalForm.Show()
        Hide()
    End Sub

    Private Sub DtPkrFecha_ValueChanged(sender As Object, e As EventArgs) Handles DtPkrFecha.ValueChanged
        Dim fecha As String = DtPkrFecha.Value.ToString("yyyy-MM-dd")
        Dim resp As String = ReservaConexion.getReservasByEspacioFecha(ComboBoxEspacio.SelectedItem, fecha)
        printListBox(resp)
    End Sub

    Private Sub LvwReservas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvwReservas.SelectedIndexChanged

    End Sub
End Class