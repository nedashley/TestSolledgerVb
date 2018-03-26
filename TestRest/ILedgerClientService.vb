Imports TestRest
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ILedgerClientService
    Implements LedgerClientService

    Public Function GetPaginatedClients(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfClient Implements LedgerClientService.GetPaginatedClients
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim requestUri As String = "https://api.redmonkeysoftware.com/ledger/" & database.name & "/clients?search=" & search & "&page=" & CStr(page)
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
            Dim clients As PaginatedListOfClient = JsonConvert.DeserializeObject(Of PaginatedListOfClient)(json)
            Return clients
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

    Public Function GetClient(database As Database, username As String, apiKey As String, code As String) As Client Implements LedgerClientService.GetClient
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/clients/" & code)
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
            Dim client As Client = JsonConvert.DeserializeObject(Of Client)(json)
            Return client
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

    Public Function CreateClient(database As Database, username As String, apiKey As String, _client As Client) As Client Implements LedgerClientService.CreateClient
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/clients")
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "POST"
            Dim postData As String = JsonConvert.SerializeObject(_client)
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
            Dim client As Client = JsonConvert.DeserializeObject(Of Client)(json)
            Return client
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

    Public Function UpdateClient(database As Database, username As String, apiKey As String, _client As Client) As Client Implements LedgerClientService.UpdateClient
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/clients/" & _client.code)
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "PUT"
            Dim postData As String = JsonConvert.SerializeObject(_client)
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
            Dim client As Client = JsonConvert.DeserializeObject(Of Client)(json)
            Return client
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
