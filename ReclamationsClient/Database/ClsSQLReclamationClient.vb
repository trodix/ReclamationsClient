Public Class ClsSQLReclamationClient

    Property _lesReclamations As New Dictionary(Of Integer, ClsReclamation)

    Public Sub New()
        readLesReclamations()
    End Sub

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

    Private Sub readLesReclamations()
        Dim lesReclamations As New Dictionary(Of Integer, ClsReclamation)
        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[RECLAMATIONS]"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read
                    Dim laReclamation As New ClsReclamation()
                    _lesReclamations.Add(laReclamation._idRC, laReclamation)
                End While
            End With
        End Using
    End Sub

End Class
