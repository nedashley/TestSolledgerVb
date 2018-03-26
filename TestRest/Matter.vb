Imports TestRest

Public Class Matter
    Private _archiveref As String
    Private _bfdate As DateTime?
    Private _branch As Branch
    Private _client As Client
    Private _clientbal As Double
    Private _code As String
    Private _contingfee As Boolean
    Private _court As String
    Private _ddbal As Double
    Private _description As String
    Private _description2 As String
    Private _feeearner As String
    Private _feesbal As Double
    Private _freeClientbal As Double
    Private _lastactdate As DateTime?
    Private _legalaidref As String
    Private _limdate As DateTime?
    Private _mattype As String
    Private _note As String
    Private _officebal As Double
    Private _otherdate As DateTime?
    Private _source As String
    Private _spancode As String
    Private _startdate As DateTime?
    Private _status As String
    Private _tag As String
    Private _type As String
    Private _ufn As String
    Private _wipbal As Double
    Private _wipballimit As Double
    Private _workcat As String
    Private _zeroBalances As Boolean

    Public Property archiveref As String
        Get
            Return _archiveref
        End Get
        Set(value As String)
            _archiveref = value
        End Set
    End Property

    Public Property bfdate As Date?
        Get
            Return _bfdate
        End Get
        Set(value As Date?)
            _bfdate = value
        End Set
    End Property

    Public Property branch As Branch
        Get
            Return _branch
        End Get
        Set(value As Branch)
            _branch = value
        End Set
    End Property

    Public Property client As Client
        Get
            Return _client
        End Get
        Set(value As Client)
            _client = value
        End Set
    End Property

    Public Property clientbal As Double
        Get
            Return _clientbal
        End Get
        Set(value As Double)
            _clientbal = value
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

    Public Property contingfee As Boolean
        Get
            Return _contingfee
        End Get
        Set(value As Boolean)
            _contingfee = value
        End Set
    End Property

    Public Property court As String
        Get
            Return _court
        End Get
        Set(value As String)
            _court = value
        End Set
    End Property

    Public Property ddbal As Double
        Get
            Return _ddbal
        End Get
        Set(value As Double)
            _ddbal = value
        End Set
    End Property

    Public Property description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property description2 As String
        Get
            Return _description2
        End Get
        Set(value As String)
            _description2 = value
        End Set
    End Property

    Public Property feeearner As String
        Get
            Return _feeearner
        End Get
        Set(value As String)
            _feeearner = value
        End Set
    End Property

    Public Property feesbal As Double
        Get
            Return _feesbal
        End Get
        Set(value As Double)
            _feesbal = value
        End Set
    End Property

    Public Property freeClientbal As Double
        Get
            Return _freeClientbal
        End Get
        Set(value As Double)
            _freeClientbal = value
        End Set
    End Property

    Public Property lastactdate As Date?
        Get
            Return _lastactdate
        End Get
        Set(value As Date?)
            _lastactdate = value
        End Set
    End Property

    Public Property legalaidref As String
        Get
            Return _legalaidref
        End Get
        Set(value As String)
            _legalaidref = value
        End Set
    End Property

    Public Property limdate As Date?
        Get
            Return _limdate
        End Get
        Set(value As Date?)
            _limdate = value
        End Set
    End Property

    Public Property mattype As String
        Get
            Return _mattype
        End Get
        Set(value As String)
            _mattype = value
        End Set
    End Property

    Public Property note As String
        Get
            Return _note
        End Get
        Set(value As String)
            _note = value
        End Set
    End Property

    Public Property officebal As Double
        Get
            Return _officebal
        End Get
        Set(value As Double)
            _officebal = value
        End Set
    End Property

    Public Property otherdate As Date?
        Get
            Return _otherdate
        End Get
        Set(value As Date?)
            _otherdate = value
        End Set
    End Property

    Public Property source As String
        Get
            Return _source
        End Get
        Set(value As String)
            _source = value
        End Set
    End Property

    Public Property spancode As String
        Get
            Return _spancode
        End Get
        Set(value As String)
            _spancode = value
        End Set
    End Property

    Public Property startdate As Date?
        Get
            Return _startdate
        End Get
        Set(value As Date?)
            _startdate = value
        End Set
    End Property

    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property Tag As String
        Get
            Return _tag
        End Get
        Set(value As String)
            _tag = value
        End Set
    End Property

    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property ufn As String
        Get
            Return _ufn
        End Get
        Set(value As String)
            _ufn = value
        End Set
    End Property

    Public Property wipbal As Double
        Get
            Return _wipbal
        End Get
        Set(value As Double)
            _wipbal = value
        End Set
    End Property

    Public Property wipballimit As Double
        Get
            Return _wipballimit
        End Get
        Set(value As Double)
            _wipballimit = value
        End Set
    End Property

    Public Property workcat As String
        Get
            Return _workcat
        End Get
        Set(value As String)
            _workcat = value
        End Set
    End Property

    Public Property zeroBalances As Boolean
        Get
            Return _zeroBalances
        End Get
        Set(value As Boolean)
            _zeroBalances = value
        End Set
    End Property
End Class
