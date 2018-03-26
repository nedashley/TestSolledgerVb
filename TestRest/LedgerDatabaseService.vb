Public Interface LedgerDatabaseService
    Function GetDatabases(ByVal username As String, ByVal apiKey As String) As List(Of Database)
    Function GetCurrentDatabase(ByVal username As String, ByVal apiKey As String) As Database
End Interface
