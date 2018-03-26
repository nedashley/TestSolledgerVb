Public Interface LedgerClientService
    Function GetPaginatedClients(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfClient
    Function GetClient(database As Database, username As String, apiKey As String, code As String) As Client
    Function CreateClient(database As Database, username As String, apiKey As String, client As Client) As Client
    Function UpdateClient(database As Database, username As String, apiKey As String, client As Client) As Client
End Interface
