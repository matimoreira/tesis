Public Class Horario
    Private _id_horario As Integer
    Private _dia As Dia
    Private _horaDesde As String
    Private _horaHasta As String
    Private _precioSesion As Double

    Sub New()
        _id_horario = 0
        _dia = New Dia
        _horaDesde = ""
        _horaHasta = ""
        _precioSesion = 0
    End Sub

    Sub New(p_id_horario As Integer, p_horaDesde As String, p_horaHasta As String, p_precioSesion As Double)
        Me.New()
        Me.Id_Horario = p_id_horario
        Me.HoraDesde = p_horaDesde
        Me.HoraHasta = p_horaHasta
        Me.PrecioSesion = p_precioSesion
    End Sub


    Public Property Id_Horario As String
        Get
            Return _id_horario
        End Get
        Set(ByVal value As String)
            _id_horario = value
        End Set
    End Property
    Public Property Dia As Dia
        Get
            Return _dia
        End Get
        Set(ByVal value As Dia)
            _dia = value
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

    Public Property PrecioSesion As Double
        Get
            Return _precioSesion
        End Get
        Set(ByVal value As Double)
            _precioSesion = value
        End Set
    End Property

    Public Function getCantidadSesiones(p_minimoAlquilable As String) As Integer
        'var minutosMinimoAlquilable = convertMinutes(respuesta.espacio.minimoAlquilable);
        'var minutosHoraDesde = convertMinutes(respuesta.horario.horaDesde);
        'var minutosHoraHasta = convertMinutes(respuesta.horario.horaHasta);
        'var minutosTotalesHorario = minutosHoraHasta - minutosHoraDesde;
        'var cantSesiones = minutosTotalesHorario / minutosMinimoAlquilable;

        Dim minutosMinimoAlquilable As Integer = Me.getMinutos(p_minimoAlquilable)
        Dim minutosHoraDesde = Me.getMinutos(Me.HoraDesde)
        Dim minutosHoraHasta = Me.getMinutos(Me._horaHasta)
        Dim minutosTotalesHorario = minutosHoraHasta - minutosHoraDesde
        Return minutosTotalesHorario / minutosMinimoAlquilable
    End Function

    Public Function getMinutos(hora As String) As Integer
        Dim fechaHora As DateTime
        Dim minutosHora As Integer
        fechaHora = DateTime.Parse("0001-01-01T" + hora)
        minutosHora = fechaHora.Hour * 60 + fechaHora.Minute
        Return minutosHora
    End Function



    Public Overrides Function ToString() As String
        Return Me.HoraDesde + " - " + Me.HoraHasta
    End Function


End Class
