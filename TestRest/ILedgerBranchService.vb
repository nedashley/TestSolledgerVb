Imports TestRest
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ILedgerBranchService
    Implements LedgerBranchService

    Public Function GetPaginatedBranches(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfBranch Implements LedgerBranchService.GetPaginatedBranches
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim requestUri As String = "https://api.redmonkeysoftware.com/ledger/" & database.name & "/branches?search=" & search & "&page=" & CStr(page)
            Console.WriteLine(requestUri)
            Dim request As WebRequest =
              WebRequest.Create(requestUri)
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
            Dim branches As PaginatedListOfBranch = JsonConvert.DeserializeObject(Of PaginatedListOfBranch)(json)
            Return branches
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

    Public Function GetBranch(database As Database, username As String, apiKey As String, id As Long) As Branch Implements LedgerBranchService.GetBranch
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/branches/" & CStr(id))
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
            Dim branch As Branch = JsonConvert.DeserializeObject(Of Branch)(json)
            Return branch
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

    Public Function CreateBranch(database As Database, username As String, apiKey As String, branchhj As Branch) As Branch Implements LedgerBranchService.CreateBranch
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/branches")
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "POST"
            Dim postData As String = JsonConvert.SerializeObject(branchhj)
            Console.WriteLine(postData)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            response = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            Dim responseStream As Stream = response.GetResponseStream()
            reader = New StreamReader(responseStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As String = responseFromServer
            Dim branch As Branch = JsonConvert.DeserializeObject(Of Branch)(json)
            Return branch
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

    Public Function UpdateBranch(database As Database, username As String, apiKey As String, _branch As Branch) As Branch Implements LedgerBranchService.UpdateBranch
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/branches/" & _branch.id)
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "PUT"
            Dim postData As String = JsonConvert.SerializeObject(_branch)
            Console.WriteLine(postData)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            response = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            Dim responseStream As Stream = response.GetResponseStream()
            reader = New StreamReader(responseStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As String = responseFromServer
            Dim branch As Branch = JsonConvert.DeserializeObject(Of Branch)(json)
            Return branch
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
