Public Class EmpresaConexion
    Public Shared Function getEmpresaUsuario() As String
        Dim conexion As New Conexion
        conexion.URL = "http://tesis/SourceFiles/index.php?controller=Empresa&action=getEmpresaUsuario"
        Return conexion.RealizarGET()
    End Function
End Class
