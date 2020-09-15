Public Class ServicioAdicional
    Private _id As Integer
    Private _descripcion As String
    Public Sub New()
        _id = 0
        _descripcion = ""
    End Sub

    Public Sub New(id As Integer, descripcion As String)
        Me.Id_Servicio = id
        Me.Descripcion = descripcion
    End Sub

    Public Sub New(descripcion As String)
        Me.Descripcion = descripcion
    End Sub

    Public Property Id_Servicio As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
End Class
