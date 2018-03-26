Public Class Address
    Private _line1 As String
    Private _line2 As String
    Private _line3 As String
    Private _line4 As String
    Private _postcode As String
    Private _singleLineAddress As String
    Private _multiLineAddress As String

    Public Property multiLineAddress As String
        Get
            Return _multiLineAddress
        End Get
        Set(value As String)
            _multiLineAddress = value
        End Set
    End Property

    Public Property singleLineAddress As String
        Get
            Return _singleLineAddress
        End Get
        Set(value As String)
            _singleLineAddress = value
        End Set
    End Property

    Public Property postcode As String
        Get
            Return _postcode
        End Get
        Set(value As String)
            _postcode = value
        End Set
    End Property

    Public Property line4 As String
        Get
            Return _line4
        End Get
        Set(value As String)
            _line4 = value
        End Set
    End Property

    Public Property line3 As String
        Get
            Return _line3
        End Get
        Set(value As String)
            _line3 = value
        End Set
    End Property

    Public Property line2 As String
        Get
            Return _line2
        End Get
        Set(value As String)
            _line2 = value
        End Set
    End Property

    Public Property line1 As String
        Get
            Return _line1
        End Get
        Set(value As String)
            _line1 = value
        End Set
    End Property
End Class
