Imports Entidades
Public Class AgregarReservas
    Private Sub AgregarReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtPkrHoraDesde.CustomFormat = "HH:mm"
        DtPkrHoraHasta.CustomFormat = "HH:mm"
        DtPkrHoraDesde.ShowUpDown = True
        DtPkrHoraHasta.ShowUpDown = True
        Dim usuario As New Usuario()
        usuario.Email = "matiempleado1@gmail.com"
        usuario.Pass = "1234"

        Dim objetoResp1 As Dictionary(Of String, String)
        objetoResp1 = ConversorJSON.ConvertirJSON_Dictionary(UsuarioConexion.login(usuario))

        Dim listSucursales As New List(Of Sucursal)
        Dim resp As String = SucursalConexion.getSucursalesByIdEmpresa
        MsgBox(resp)
        listSucursales = ConversorJSON.ConvertirJSON_ListOfSucursal(resp)
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
        Dim espacio As EspacioRecreativo
        espacio = ComboBoxEspacio.SelectedItem
        Dim listHorariosRaw As String = DiaConexion.getTurnoByEspacioFecha(espacio.Id_Espacio, fecha)
        ComboBoxHorario.Items.Clear()
        If listHorariosRaw = "false" Then
            ComboBoxHorario.Items.Add("Cerrado")
            ComboBoxHorario.Refresh()


            'ComboBoxHorario.SelectedTex

        Else
            Dim listHorarios As New List(Of Horario)
            listHorarios = ConversorJSON.ConvertirJSON_ListOfHorario(listHorariosRaw)

            For Each horario As Horario In listHorarios
                ComboBoxHorario.Items.Add(horario)
            Next
        End If

        'printListBox(resp)
    End Sub

    Private Sub ComboBoxHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxHorario.SelectedIndexChanged
        LblFecha.Show()
        DtPkrFecha.Show()
        Dim fecha As String = DtPkrFecha.Value.ToString("yyyy-MM-dd")
        Dim espacio As EspacioRecreativo
        espacio = ComboBoxEspacio.SelectedItem
        Dim resp As String = ReservaConexion.getReservasByEspacioFecha(espacio, fecha)
        printListBox(resp)
    End Sub

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
            'Dim listViewReserva As New ListViewItem()
            'listViewReserva.SubItems.Add(reserva.Item("horaDesde"))
            'listViewReserva.SubItems.Add(reserva.Item("horaHasta"))
            'listViewReserva.SubItems.Add(reserva.Item("estado"))
            LvwReservas.Items.Add(reserva.Item("horaDesde"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("horaHasta"))
            LvwReservas.Items.Item(i).SubItems.Add(reserva.Item("estado"))
        Next
    End Sub



    Private Sub BtnReservar_Click(sender As Object, e As EventArgs) Handles BtnReservar.Click


        Dim espacio As EspacioRecreativo
        espacio = ComboBoxEspacio.SelectedItem
        Dim horario As Horario = ComboBoxHorario.SelectedItem
        Dim fecha As String = DtPkrFecha.Value.ToString("yyyy-MM-dd")
        Dim horaDesde As String = DtPkrHoraDesde.Value.ToString("HH:mm")
        Dim horaHasta As String = DtPkrHoraHasta.Value.ToString("HH:mm")

        Dim reserva As New Reserva
        reserva.HoraDesde = horaDesde
        reserva.HoraHasta = horaHasta

        Dim precioReserva As Double = reserva.calcularPrecioReserva(espacio, horario)
        'MsgBox("id_espacio: " + espacio.Id_Espacio.ToString + " descripcion: " + espacio.Descripcion + " horario: " + horario.ToString + " horaDesde: " + horaDesde + " horaHasta: " + horaHasta + " horaDesdeReserva: " + reserva.HoraDesde.ToString + " HoraHastaReserva: " + reserva.HoraHasta.ToString)
        Dim Respuesta As String
        Respuesta = ReservaConexion.solicitarReserva(espacio, horario, fecha, precioReserva, horaDesde, horaHasta)
        If Respuesta = "false" Then
            MsgBox("Respuesta false")
        Else
            MsgBox(Respuesta)
        End If
    End Sub

End Class