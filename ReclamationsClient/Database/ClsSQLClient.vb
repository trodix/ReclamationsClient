Public Class ClsSQLClient

    Public Function readLesClientsByCode(Code As String) As List(Of ClsClient)
        Dim lesClients As New List(Of ClsClient)
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection("SELECT CLCTABRE, CLCTNOM, CLCTCONTA1, CLCTTELEP1, CLCTEMAIL FROM [pmi].[dbo].[CLIENT] WHERE CLCTABRE LIKE '" & Code & "' ORDER BY CLCTABRE", ClassConnection.ClsChaineConnection.ChaineConnection.CEGID_ReadOnly)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim leClient As New ClsClient(.OdbcReader("CLCTABRE"), .OdbcReader("CLCTNOM"), .OdbcReader("CLCTCONTA1"), .OdbcReader("CLCTTELEP1"), .OdbcReader("CLCTEMAIL"))
                    lesClients.Add(leClient)
                End While
            End With
        End Using
        Return lesClients
    End Function

End Class
