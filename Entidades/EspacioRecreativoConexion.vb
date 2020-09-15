Public Class EspacioRecreativoConexion
    Public Shared Function getEspaciosByIdSucursal(sucursal As Sucursal) As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=EspacioRecreativo&action=getEspaciosValidosByIdSucursal"
        conexion.Datos = "id=" & sucursal.Id_Sucursal
        Return conexion.RealizarPOST
    End Function
End Class
