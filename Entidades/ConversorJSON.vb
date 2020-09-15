Imports System.Web.Script.Serialization
Public Class ConversorJSON
    Private Shared serializador As JavaScriptSerializer = New JavaScriptSerializer
    Public Shared Function ConvertirObj_JSON(Obj As Object) As String
        Return serializador.Serialize(Obj)
    End Function
    Public Shared Function ConvertirArray_JSON(ArrConvertir As ArrayList) As String
        Return serializador.Serialize(ArrConvertir)
    End Function
    Public Shared Function ConvertirJSON_Array(ObjJSON As String) As ArrayList
        Return serializador.Deserialize(Of ArrayList)(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_Dictionary(ObjJSON As String) As Dictionary(Of String, String)
        Return serializador.Deserialize(Of Dictionary(Of String, String))(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_ListOfDictionary(ObjJSON As String) As List(Of Dictionary(Of String, String))
        Return serializador.Deserialize(Of List(Of Dictionary(Of String, String)))(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_ListOfEspacioRecreativo(ObjJSON As String) As List(Of EspacioRecreativo)
        Return serializador.Deserialize(Of List(Of EspacioRecreativo))(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_ListOfServicioAdicional(ObjJSON As String) As List(Of ServicioAdicional)
        Return serializador.Deserialize(Of List(Of ServicioAdicional))(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_ListOfSucursal(ObjJSON As String) As List(Of Sucursal)
        Return serializador.Deserialize(Of List(Of Sucursal))(ObjJSON)
    End Function
    Public Shared Function ConvertirJSON_ListOfHorario(ObjJSON As String) As List(Of Horario)
        Return serializador.Deserialize(Of List(Of Horario))(ObjJSON)
    End Function

    Public Shared Function ConvertirJSON_ListOfReserva(ObjJSON As String) As List(Of Reserva)
        Return serializador.Deserialize(Of List(Of Reserva))(ObjJSON)
    End Function
End Class
