Imports TestRest
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ILedgerDatabaseService
    Implements LedgerDatabaseService

    Public Function GetDatabases(username As String, apiKey As String) As List(Of Database) Implements LedgerDatabaseService.GetDatabases
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger")
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            response = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            Dim dataStream As Stream = response.GetResponseStream()
            reader = New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As String = responseFromServer
            Dim databases As List(Of Database) = JsonConvert.DeserializeObject(Of List(Of Database))(json)
            Return databases
        Catch exc As Exception
            ' Handle exceptions that occur within
            ' the Try block, here.
            Console.WriteLine(exc.Message)
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try
        Return Nothing
    End Function

    Public Function GetCurrentDatabase(username As String, apiKey As String) As Database Implements LedgerDatabaseService.GetCurrentDatabase
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger")
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            response = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            Dim dataStream As Stream = response.GetResponseStream()
            reader = New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As String = responseFromServer
            Dim databases As List(Of Database) = JsonConvert.DeserializeObject(Of List(Of Database))(json)
            For Each database As Database In databases
                If database.current Then
                    Return database
                End If
            Next
        Catch exc As Exception
            ' Handle exceptions that occur within
            ' the Try block, here.
            Console.WriteLine(exc.Message)
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try
        Return Nothing
    End Function
End Class
