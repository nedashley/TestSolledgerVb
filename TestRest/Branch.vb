Public Class Branch
    Private _id As Long?
    Private _name As String

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property id As Long?
        Get
            Return _id
        End Get
        Set(value As Long?)
            _id = value
        End Set
    End Property
End Class
