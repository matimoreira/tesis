Public Class DiaConexion
    Public Shared Function getTurnoByEspacioFecha(p_id_espacio As Integer, p_fecha As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Dia&action=getTurnoByEspacioFecha"
        conexion.Datos = "id_espacio=" & p_id_espacio & "&fecha=" & p_fecha & "&platform=desktop"
        Return conexion.RealizarPOST
    End Function
End Class
