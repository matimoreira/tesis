Public Class Reserva
    Private _id_reserva As Integer
    Private _id_espacio As Integer
    Private _id_usuario As Integer
    Private _id_horario As Integer
    Private _id_estado As Integer
    Private _fecha As Date
    Private _horaDesde As String
    Private _horaHasta As String
    Private _importe As Double

    Sub New()
        _id_reserva = 0
        _id_espacio = 0
        _id_usuario = 0
        _id_horario = 0
        _id_estado = 0
        _fecha = Nothing
        _horaDesde = Nothing
        _horaHasta = Nothing
        _importe = 0
    End Sub

    Sub New(p_id_reserva As Integer, p_id_espacio As Integer, p_id_usuario As Integer, p_id_horario As Integer, p_id_estado As Integer)
        Me.Id_Reserva = p_id_reserva
        Me.Id_Espacio = p_id_espacio
        Me.Id_Usuario = p_id_usuario
        Me.Id_Horario = p_id_horario
        Me.Id_Estado = p_id_estado
    End Sub

    Public Property Id_Reserva As Integer
        Get
            Return _id_reserva
        End Get
        Set(ByVal value As Integer)
            _id_reserva = value
        End Set
    End Property

    Public Property Id_Espacio As Integer
        Get
            Return _id_espacio
        End Get
        Set(ByVal value As Integer)
            _id_espacio = value
        End Set
    End Property

    Public Property Id_Usuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property Id_Horario As Integer
        Get
            Return _id_horario
        End Get
        Set(ByVal value As Integer)
            _id_horario = value
        End Set
    End Property

    Private newPropertyValue As Integer
    Public Property Id_Estado As Integer
        Get
            Return _id_estado
        End Get
        Set(ByVal value As Integer)
            _id_estado = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property HoraDesde As String
        Get
            Return _horaDesde
        End Get
        Set(ByVal value As String)
            _horaDesde = value
        End Set
    End Property

    Public Property HoraHasta As String
        Get
            Return _horaHasta
        End Get
        Set(ByVal value As String)
            _horaHasta = value
        End Set
    End Property
    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    Public Function calcularPrecioReserva(espacio As EspacioRecreativo, horario As Horario) As Double
        Dim minutosMinimoAlquilable As Integer = horario.getMinutos(espacio.MinimoAlquilable)
        Dim minutosHoraDesde = horario.getMinutos(Me.HoraDesde)
        Dim minutosHoraHasta = horario.getMinutos(Me.HoraHasta)
        Dim minutosTotalesHorario As Integer = minutosHoraHasta - minutosHoraDesde
        Return horario.PrecioSesion * (minutosTotalesHorario / minutosMinimoAlquilable)
    End Function

End Class
