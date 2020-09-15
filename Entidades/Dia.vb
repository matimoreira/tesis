Public Class Dia
    Private _id_dia As Integer
    Private _espacio As EspacioRecreativo
    Private _id_numeroDia As Integer
    Private _fechaDesde As Date
    Private _fechaHasta As Date

    Public Sub New()
        _id_dia = 0
        _espacio = New EspacioRecreativo
        _id_numeroDia = 0
        _fechaDesde = Nothing
        _fechaDesde = Nothing
    End Sub

    Public Sub New(p_id_dia As Integer, p_espacio As EspacioRecreativo, p_numeroDia As Integer, p_fechaDesde As Date, p_fechaHasta As Date)
        Me.New()

    End Sub

    Public Property Id_Dia As Integer
        Get
            Return _id_dia
        End Get
        Set(ByVal value As Integer)
            _id_dia = value
        End Set
    End Property

    Public Property Espacio As EspacioRecreativo
        Get
            Return _espacio
        End Get
        Set(ByVal value As EspacioRecreativo)
            _espacio = value
        End Set
    End Property

    Public Property Id_NumeroDia As Integer
        Get
            Return _id_numeroDia
        End Get
        Set(ByVal value As Integer)
            _id_numeroDia = value
        End Set
    End Property

    Public Property FechaDesde As Date
        Get
            Return _fechaDesde
        End Get
        Set(ByVal value As Date)
            _fechaDesde = value
        End Set
    End Property

    Public Property FechaHasta As Date
        Get
            Return _fechaHasta
        End Get
        Set(ByVal value As Date)
            _fechaHasta = value
        End Set
    End Property
End Class
