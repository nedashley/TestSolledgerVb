Imports TestRest
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ILedgerMatterService
    Implements LedgerMatterService

    Public Function GetPaginatedMatters(database As Database, username As String, apiKey As String, Optional search As String = "", Optional page As Short = 0) As PaginatedListOfMatter Implements LedgerMatterService.GetPaginatedMatters
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim requestUri As String = "https://api.redmonkeysoftware.com/ledger/" & database.name & "/matters?search=" & search & "&page=" & CStr(page)
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
            Dim matters As PaginatedListOfMatter = JsonConvert.DeserializeObject(Of PaginatedListOfMatter)(json)
            Return matters
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

    Public Function GetMatter(database As Database, username As String, apiKey As String, code As String) As Matter Implements LedgerMatterService.GetMatter
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/matters/" + code)
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
            Dim matter As Matter = JsonConvert.DeserializeObject(Of Matter)(json)
            Return matter
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

    Public Function CreateMatter(database As Database, username As String, apiKey As String, _matter As Matter) As Matter Implements LedgerMatterService.CreateMatter
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/matters")
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "POST"
            Dim postData As String = JsonConvert.SerializeObject(_matter)
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
            Dim matter As Matter = JsonConvert.DeserializeObject(Of Matter)(json)
            Return matter
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

    Public Function UpdateMatter(database As Database, username As String, apiKey As String, _matter As Matter) As Matter Implements LedgerMatterService.UpdateMatter
        Dim reader As StreamReader = Nothing
        Dim response As WebResponse = Nothing
        Try
            Dim request As WebRequest =
              WebRequest.Create("https://api.redmonkeysoftware.com/ledger/" & database.name & "/matters/" & _matter.code)
            Dim authInfo = username + ":" + apiKey
            authInfo = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authInfo))
            request.Headers.Add("Authorization", "Basic " + authInfo)
            request.ContentType = "application/json"
            request.Method = "PUT"
            Dim postData As String = JsonConvert.SerializeObject(_matter)
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
            Dim matter As Matter = JsonConvert.DeserializeObject(Of Matter)(json)
            Return matter
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
