﻿Imports TestRest

Public Class PaginatedListOfClient
    Private _results As List(Of Client)
    Private _nextPage As String
    Private _previousPage As String
    Private _totalCount As Long

    Public Property Results As List(Of Client)
        Get
            Return _results
        End Get
        Set(value As List(Of Client))
            _results = value
        End Set
    End Property

    Public Property NextPage As String
        Get
            Return _nextPage
        End Get
        Set(value As String)
            _nextPage = value
        End Set
    End Property

    Public Property PreviousPage As String
        Get
            Return _previousPage
        End Get
        Set(value As String)
            _previousPage = value
        End Set
    End Property

    Public Property TotalCount As Long
        Get
            Return _totalCount
        End Get
        Set(value As Long)
            _totalCount = value
        End Set
    End Property
End Class
