Public Class ReservaConexion
    Public Shared Function getReservasByEspacioFecha(espacio As EspacioRecreativo, fecha As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Reserva&action=getInfoByEspacioFecha"
        conexion.Datos = "espacio=" & espacio.Id_Espacio & "&fecha=" & fecha
        Return conexion.RealizarPOST
    End Function

    Public Shared Function getReservasTurno(espacio As EspacioRecreativo, horario As Horario, fecha As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Reserva&action=getReservasTurno"
        conexion.Datos = "id_espacio=" & espacio.Id_Espacio & "&id_horario=" & horario.Id_Horario & "&fecha=" & fecha & "&platform=desktop"
        Return conexion.RealizarPOST
    End Function

    Public Shared Function solicitarReserva(espacio As EspacioRecreativo, horario As Horario, p_fechaReserva As String, p_precioReserva As Double, p_horaDesde As String, p_horaHasta As String)
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Reserva&action=solicitarReserva"
        conexion.Datos = "espacio=" & espacio.Id_Espacio & "&horario=" & horario.Id_Horario & "&fechaReserva=" & p_fechaReserva & "&precioReserva=" & p_precioReserva & "&horaDesde=" & p_horaDesde & "&horaHasta=" & p_horaHasta & "&platform=desktop"
        Return conexion.RealizarPOST
    End Function
End Class
