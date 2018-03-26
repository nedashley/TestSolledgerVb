Public Interface LedgerBranchService
    Function GetPaginatedBranches(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfBranch
    Function GetBranch(database As Database, username As String, apiKey As String, id As Long) As Branch
    Function CreateBranch(database As Database, username As String, apiKey As String, branch As Branch) As Branch
    Function UpdateBranch(database As Database, username As String, apiKey As String, branch As Branch) As Branch
End Interface
