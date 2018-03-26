Imports TestRest

Public Class Client
    Private _accountname As String
    Private _accountnumber As String
    Private _address As Address
    Private _alpha As String
    Private _code As String
    Private _dob As DateTime?
    Private _email As String
    Private _name As String
    Private _nino As String
    Private _sortcode As String
    Private _telbus As String
    Private _telfax As String
    Private _telhome As String
    Private _telmobile As String
    Private _vatno As String

    Public Property vatno As String
        Get
            Return _vatno
        End Get
        Set(value As String)
            _vatno = value
        End Set
    End Property

    Public Property telmobile As String
        Get
            Return _telmobile
        End Get
        Set(value As String)
            _telmobile = value
        End Set
    End Property

    Public Property telhome As String
        Get
            Return _telhome
        End Get
        Set(value As String)
            _telhome = value
        End Set
    End Property

    Public Property telfax As String
        Get
            Return _telfax
        End Get
        Set(value As String)
            _telfax = value
        End Set
    End Property

    Public Property telbus As String
        Get
            Return _telbus
        End Get
        Set(value As String)
            _telbus = value
        End Set
    End Property

    Public Property sortcode As String
        Get
            Return _sortcode
        End Get
        Set(value As String)
            _sortcode = value
        End Set
    End Property

    Public Property nino As String
        Get
            Return _nino
        End Get
        Set(value As String)
            _nino = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property dob As DateTime?
        Get
            Return _dob
        End Get
        Set(value As DateTime?)
            _dob = value
        End Set
    End Property

    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property alpha As String
        Get
            Return _alpha
        End Get
        Set(value As String)
            _alpha = value
        End Set
    End Property

    Public Property address As Address
        Get
            Return _address
        End Get
        Set(value As Address)
            _address = value
        End Set
    End Property

    Public Property accountnumber As String
        Get
            Return _accountnumber
        End Get
        Set(value As String)
            _accountnumber = value
        End Set
    End Property

    Public Property accountname As String
        Get
            Return _accountname
        End Get
        Set(value As String)
            _accountname = value
        End Set
    End Property
End Class
