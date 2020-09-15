Public Class Empresa
    Private _id As Integer
    Private _nombre As String
    Private _sucursales As List(Of Sucursal)
    Private _estado As Byte

    Public Property Id_Empresa As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Sucursales As List(Of Sucursal)
        Get
            Return _sucursales
        End Get
        Set(value As List(Of Sucursal))
            _sucursales = value
        End Set
    End Property

    Public Property Estado As Byte
        Get
            Return _estado
        End Get
        Set(value As Byte)
            _estado = value
        End Set
    End Property
End Class
