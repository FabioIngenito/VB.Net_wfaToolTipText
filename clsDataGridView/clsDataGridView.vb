Public Class clsDados
    Private _Marca As Boolean
    Private _ID As Integer
    Private _Nome As String
    Private _Comentario As String
    Private _total As Integer

    Public Sub New(ByVal _Marca As Boolean, ByVal _ID As Integer, ByVal _Nome As String, ByVal _Comentario As String, ByVal _total As Integer)
        Me.Marca = _Marca
        Me.ID = _ID
        Me.Nome = _Nome
        Me.Comentario = _Comentario
        Me.total = _total
    End Sub

    Public Property Marca() As Boolean
        Get
            Return _Marca
        End Get
        Set(ByVal Value As Boolean)
            _Marca = Value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal Value As Integer)
            _ID = Value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal Value As String)
            _Nome = Value
        End Set
    End Property

    Public Property Comentario() As String
        Get
            Return _Comentario
        End Get
        Set(ByVal Value As String)
            _Comentario = Value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return _total
        End Get
        Set(ByVal Value As Integer)
            _total = Value
        End Set
    End Property

End Class
