Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class SolledgerApiClientForm

    Property LedgerDatabaseService As LedgerDatabaseService = New ILedgerDatabaseService
    Property LedgerClientService As LedgerClientService = New ILedgerClientService
    Property LedgerMatterService As LedgerMatterService = New ILedgerMatterService
    Property LedgerBranchService As LedgerBranchService = New ILedgerBranchService
    Property database As Database

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListDatabases_Click(sender As Object, e As EventArgs) Handles btnListDatabases.Click
        database = LedgerDatabaseService.GetCurrentDatabase(txtUsername.Text, txtApiKey.Text)
        If database IsNot Nothing Then
            LabelDatabase.Text = database.name
            ButtonSearchClients.Enabled = True
            ButtonSearchMatters.Enabled = True
            ButtonCreateBranch.Enabled = True
            ButtonCreateMatter.Enabled = True
        End If
    End Sub

    Private Sub ButtonSearchClients_Click(sender As Object, e As EventArgs) Handles ButtonSearchClients.Click
        Dim clients As PaginatedListOfClient = LedgerClientService.GetPaginatedClients(database, txtUsername.Text, txtApiKey.Text)
        DataGridViewClients.Rows.Clear()
        For Each client As Client In clients.Results
            DataGridViewClients.Rows.Add(client.code, client.name, client.address.singleLineAddress)
        Next
    End Sub

    Private Sub ButtonSearchMatters_Click(sender As Object, e As EventArgs) Handles ButtonSearchMatters.Click
        Dim matters As PaginatedListOfMatter = LedgerMatterService.GetPaginatedMatters(database, txtUsername.Text, txtApiKey.Text)
        DataGridViewMatters.Rows.Clear()
        For Each matter As Matter In matters.Results
            DataGridViewMatters.Rows.Add(matter.code, matter.description)
        Next
    End Sub

    Private Sub ButtonCreateBranch_Click(sender As Object, e As EventArgs) Handles ButtonCreateBranch.Click
        Dim branch As Branch = New Branch
        branch.Name = "Test Branch"
        branch = LedgerBranchService.CreateBranch(database, txtUsername.Text, txtApiKey.Text, branch)
        MsgBox("Created Branch with ID: " & branch.Id)
    End Sub

    Private Sub ButtonCreateMatter_Click(sender As Object, e As EventArgs) Handles ButtonCreateMatter.Click
        Dim _client As Client = New Client
        _client.code = "TEST-API123"
        _client.name = "Test Clent via API"
        Dim _matter As Matter = New Matter
        _matter.code = "TEST-API123"
        _matter.description = "Test Matter via API"
        _matter.client = _client
        LedgerMatterService.CreateMatter(database, txtUsername.Text, txtApiKey.Text, _matter)
    End Sub
End Class
