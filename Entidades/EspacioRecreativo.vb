Public Class EspacioRecreativo
    Private _id As Integer
    Private _id_sucursal As Integer
    Private _id_tipo_espacio As Integer
    Private _descripcion As String
    'Private _precioHora As Double
    Private _minimoAlquilable As String
    Private _anticipo As Double
    Private _id_estado As Integer
    Private _serviciosAdicionales As List(Of ServicioAdicional)
    Private _horarios As List(Of Horario)

    Sub New()
        _id = 0
        _id_sucursal = 0
        _descripcion = ""
        '_precioHora = 0
        _minimoAlquilable = New DateTime
        _anticipo = 0
        _serviciosAdicionales = New List(Of ServicioAdicional)
        _horarios = New List(Of Horario)
    End Sub

    Sub New(pId As Integer, pDescripcion As String)
        Me.New()
        Id_Espacio = pId
        Descripcion = pDescripcion
    End Sub

    Public Property Id_Espacio As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Id_Sucursal As Integer
        Get
            Return _id_sucursal
        End Get
        Set(ByVal value As Integer)
            _id_sucursal = value
        End Set
    End Property
    Public Property Id_Tipo_Espacio As Integer
        Get
            Return _id_tipo_espacio
        End Get
        Set(ByVal value As Integer)
            _id_tipo_espacio = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Anticipo As Double
        Get
            Return _anticipo
        End Get
        Set(value As Double)
            _anticipo = value
        End Set
    End Property

    'Public Property PrecioHora As Double
    '    Get
    '        Return _precioHora
    '    End Get
    '    Set(value As Double)
    '        _precioHora = value
    '    End Set
    'End Property

    Public Property MinimoAlquilable As String
        Get
            Return _minimoAlquilable
        End Get
        Set(value As String)
            _minimoAlquilable = value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return _id_estado
        End Get
        Set(ByVal value As Integer)
            _id_estado = value
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

    Public Property Horarios As List(Of Horario)
        Get
            Return _horarios
        End Get
        Set(value As List(Of Horario))
            _horarios = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
