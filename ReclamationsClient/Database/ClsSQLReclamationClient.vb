Public Class ClsSQLReclamationClient

    Property _lesReclamations As New Dictionary(Of Integer, ClsReclamation)

    Public Sub New()
        readLesReclamations()
    End Sub



    Private Sub readLesReclamations()
        Dim lesReclamations As New Dictionary(Of Integer, ClsReclamation)
        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[RECLAMATIONS]"
        Using s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With s_FbMyReader
                While .OdbcReader.Read

                    Dim CodeClient As String = ""
                    Dim NomClient As String = ""
                    Dim ContactClient As String = ""
                    Dim TelephoneClient As String = ""
                    Dim MailClient As String = ""
                    Dim TypeClient As String = ""
                    Dim DateReception As Date = Date.Now
                    Dim NumConfInitiale As String = ""
                    Dim Commentaires As String = ""
                    Dim CommentairesAnalyse As String = ""
                    Dim Statut As String = ""

                    If Not IsDBNull(.OdbcReader("CodeClient")) Then CodeClient = .OdbcReader("CodeClient")
                    If Not IsDBNull(.OdbcReader("NomClient")) Then CodeClient = .OdbcReader("NomClient")
                    If Not IsDBNull(.OdbcReader("ContactClient")) Then CodeClient = .OdbcReader("ContactClient")
                    If Not IsDBNull(.OdbcReader("TelephoneClient")) Then CodeClient = .OdbcReader("TelephoneClient")
                    If Not IsDBNull(.OdbcReader("MailClient")) Then CodeClient = .OdbcReader("MailClient")
                    If Not IsDBNull(.OdbcReader("TypeClient")) Then CodeClient = .OdbcReader("TypeClient")
                    If Not IsDBNull(.OdbcReader("DateReception")) Then CodeClient = .OdbcReader("DateReception")
                    If Not IsDBNull(.OdbcReader("NumConfInitiale")) Then CodeClient = .OdbcReader("NumConfInitiale")
                    If Not IsDBNull(.OdbcReader("Commentaires")) Then CodeClient = .OdbcReader("Commentaires")
                    If Not IsDBNull(.OdbcReader("CommentairesAnalyse")) Then CodeClient = .OdbcReader("CommentairesAnalyse")
                    If Not IsDBNull(.OdbcReader("Statut")) Then CodeClient = .OdbcReader("Statut")

                    Dim leClient As New ClsClient(CodeClient, NomClient, ContactClient, TelephoneClient, MailClient, TypeClient)
                    Dim laReclamation As New ClsReclamation(.OdbcReader("idReclamation"), DateReception, NumConfInitiale, Commentaires, CommentairesAnalyse, Statut, leClient)
                    _lesReclamations.Add(laReclamation._idRC, laReclamation)
                End While
            End With
        End Using
    End Sub

    Public Function InsertEnreg(laReclamation As ClsReclamation) As Integer
        Dim req As String = "INSERT INTO [dbReclamationsClient].[dbo].[RECLAMATIONS] (DateReception, Statut, Commentaires, NumConfInitiale, ReferenceClient, TypeClient, CodeClient, NomClient, ContactClient, TelephoneClient, MailClient) VALUES('" &
                laReclamation._DateReception & "', '" &
                laReclamation._Statut & "', '" &
                ReplaceSpecialChars(laReclamation._Commentaires) & "', '" &
                laReclamation._NumConfInitiale & "', '" &
                laReclamation._RefClient & "', '" &
                laReclamation._leClient._TypeClient & "',' " &
                laReclamation._leClient._Code & "', '" &
                laReclamation._leClient._Nom & "', '" &
                laReclamation._leClient._Contact & "', '" &
                laReclamation._leClient._Tel & "', '" &
                laReclamation._leClient._Mail & "')"

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)

        End Using

        Return getLastId()

    End Function

    Public Function getLastId() As Integer

        Dim req2 As String = "SELECT MAX(idReclamation) AS lastId FROM [dbReclamationsClient].[dbo].[RECLAMATIONS]"

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req2, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        s_FbMyReader.OdbcReader.Read()
        Return s_FbMyReader.OdbcReader("lastId")

    End Function

    Public Sub InsertAnalyse(laReclamation As ClsReclamation)
        Dim req As String = "UPDATE [dbReclamationsClient].[dbo].[RECLAMATIONS] SET Statut = '" & laReclamation._Statut &
            "', Commentaires = '" & ReplaceSpecialChars(laReclamation._Commentaires) & "', CommentairesAnalyse = '" &
            ReplaceSpecialChars(laReclamation._CommentairesAnalyse) & "' WHERE idReclamation = " & laReclamation._idRC

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Sub

    Public Sub InsertRecencement(laReclamation As ClsReclamation)
        Dim req As String = "UPDATE [dbReclamationsClient].[dbo].[RECLAMATIONS] SET Statut = '" & laReclamation._Statut &
            "', Commentaires = '" & ReplaceSpecialChars(laReclamation._Commentaires) &
            "', NbPieces = " & laReclamation._NbPieces &
            ", ValeurMarchande = " & laReclamation._ValeurMarchande &
            ", CoutTransport = " & laReclamation._CoutTransport & " WHERE idReclamation = " & laReclamation._idRC

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Sub

    Private Function ReplaceSpecialChars(laChaine As String) As String
        laChaine = laChaine.Replace("'", "''")
        laChaine = laChaine.Replace(",", "")
        Return laChaine
    End Function

End Class
