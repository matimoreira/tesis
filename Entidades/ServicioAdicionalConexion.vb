Public Class ServicioAdicionalConexion
    Public Shared Function getAll() As String
        Dim conexion As New Conexion
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php"
        Return Conexion.RealizarGET()
    End Function

    Public Shared Function getBusqueda(strBusqueda As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php?accion=buscar&value=" & strBusqueda
        Return Conexion.RealizarGET()
    End Function

    Public Shared Function addServicio(strAgregar As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php?accion=add"
        conexion.Datos = "value=" & strAgregar
        Return Conexion.RealizarPOST()
    End Function

    Public Shared Function modificarServicio(idModificar As Integer, strModificar As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php?accion=modificar"
        conexion.Datos = "idMod=" & idModificar & "&value=" & strModificar
        Return conexion.RealizarPOST()
    End Function

    Public Shared Function borrarServicio(idBorrar As String) As String
        Dim conexion As New Conexion
        conexion.URL = "http://pruebasWamp/pruebaServiciosAdicionales.php?accion=borrar"
        conexion.Datos = "idBorrar=" & idBorrar
        Return conexion.RealizarPOST()
    End Function
End Class
