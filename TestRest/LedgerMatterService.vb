Public Interface LedgerMatterService
    Function GetPaginatedMatters(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfMatter
    Function GetMatter(database As Database, username As String, apiKey As String, code As String) As Matter
    Function CreateMatter(database As Database, username As String, apiKey As String, matter As Matter) As Matter
    Function UpdateMatter(database As Database, username As String, apiKey As String, matter As Matter) As Matter
End Interface
