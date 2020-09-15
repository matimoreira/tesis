Public Class SucursalConexion
    Public Shared Function getSucursalesByIdEmpresa() As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Sucursal&action=getSucursalesByIdEmpresa"
        Return conexion.RealizarGET()
    End Function
End Class
