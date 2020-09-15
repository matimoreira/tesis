Public Class Sucursal
    Private _id As Integer
    Private _direccion As String
    Private _serviciosAdicionales As List(Of ServicioAdicional)

    Sub New()
        _id = 0
        _direccion = ""
        _serviciosAdicionales = New List(Of ServicioAdicional)
    End Sub

    Sub New(pId As Integer, pDireccion As String)
        Me.New()
        Id_Sucursal = pId
        Direccion = pDireccion
    End Sub

    Public Property Id_Sucursal As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property ServiciosAdicionales As List(Of ServicioAdicional)
        Get
            Return _serviciosAdicionales
        End Get
        Set(value As List(Of ServicioAdicional))
            _serviciosAdicionales = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Direccion
    End Function
End Class
