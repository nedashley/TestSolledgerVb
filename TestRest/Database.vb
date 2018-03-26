Public Class Database
    Private nameValue As String
    Private currentValue As Boolean

    Public Property name() As String
        Get
            ' Gets the property value.
            Return nameValue
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            nameValue = Value
        End Set
    End Property

    Public Property current() As Boolean
        Get
            ' Gets the property value.
            Return currentValue
        End Get
        Set(ByVal Value As Boolean)
            ' Sets the property value.
            currentValue = Value
        End Set
    End Property
End Class
