Public Class ClsSQLReclamationClient

    Property _lesReclamations As New Dictionary(Of Integer, ClsReclamation)
    'Property _lesTypesCause As New Dictionary(Of Integer, String)
    'Property _lesCategCause As New Dictionary(Of Integer, String)

    Public Sub New()
        readLesReclamations()
    End Sub

    Public Function ReadUneReclamationById(idRC As Integer) As ClsReclamation
        Dim laReclamation As ClsReclamation
        'Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[RECLAMATIONS] " &
        '"LEFT JOIN [dbReclamationsClient].[dbo].[TYPES_CAUSE].[TYPES_CAUSE] ON [dbReclamationsClient].[dbo].[TYPES_CAUSE].idTypeCause = [dbReclamationsClient].[dbo].[RECLAMATIONS].idTypeCause " &
        '"LEFT JOIN [dbReclamationsClient].[dbo].[TYPES_CAUSE].[CATEGORIES_CAUSE] ON [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE].idCategCause = [dbReclamationsClient].[dbo].[TYPES_CAUSE].idTypeCause " &
        '"WHERE [dbReclamationsClient].[dbo].[RECLAMATIONS].idReclamation = " & idRC
        'MsgBox(req)
        ' "SELECT * FROM [dbReclamationsClient].[dbo].[RECLAMATIONS],[dbReclamationsClient].[dbo].[TYPES_CAUSE],[dbReclamationsClient].[dbo].[CATEGORIES_CAUSE] WHERE [dbReclamationsClient].[dbo].[TYPES_CAUSE].idTypeCause = [dbReclamationsClient].[dbo].[RECLAMATIONS].idTypeCause and [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE].idCategCause = [dbReclamationsClient].[dbo].[TYPES_CAUSE].idTypeCause and  [dbReclamationsClient].[dbo].[RECLAMATIONS].idReclamation = " & idRC
        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[RECLAMATIONS] WHERE idReclamation = " & idRC
        Using stmt As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            With stmt
                .OdbcReader.Read()

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
                Dim NbPieces As Integer = 0
                Dim ValeurMarchande As Decimal = 0
                Dim CoutTransport As Decimal = 0
                Dim idTypeCause As Integer = 0
                Dim idCategCause As Integer = 0
                Dim ConfIni As String = ""
                Dim PieceRetour As Integer = 0
                Dim ReferenceClient As String = ""

                If Not IsDBNull(.OdbcReader("CodeClient")) Then CodeClient = .OdbcReader("CodeClient")
                If Not IsDBNull(.OdbcReader("NomClient")) Then NomClient = .OdbcReader("NomClient")
                If Not IsDBNull(.OdbcReader("ContactClient")) Then ContactClient = .OdbcReader("ContactClient")
                If Not IsDBNull(.OdbcReader("TelephoneClient")) Then TelephoneClient = .OdbcReader("TelephoneClient")
                If Not IsDBNull(.OdbcReader("MailClient")) Then MailClient = .OdbcReader("MailClient")
                If Not IsDBNull(.OdbcReader("TypeClient")) Then TypeClient = .OdbcReader("TypeClient")
                If Not IsDBNull(.OdbcReader("DateReception")) Then DateReception = .OdbcReader("DateReception")
                If Not IsDBNull(.OdbcReader("NumConfInitiale")) Then NumConfInitiale = .OdbcReader("NumConfInitiale")
                If Not IsDBNull(.OdbcReader("Commentaires")) Then Commentaires = .OdbcReader("Commentaires")
                If Not IsDBNull(.OdbcReader("CommentairesAnalyse")) Then CommentairesAnalyse = .OdbcReader("CommentairesAnalyse")
                If Not IsDBNull(.OdbcReader("Statut")) Then Statut = .OdbcReader("Statut")
                If Not IsDBNull(.OdbcReader("NbPieces")) Then NbPieces = .OdbcReader("NbPieces")
                If Not IsDBNull(.OdbcReader("ValeurMarchande")) Then ValeurMarchande = .OdbcReader("ValeurMarchande")
                If Not IsDBNull(.OdbcReader("CoutTransport")) Then CoutTransport = .OdbcReader("CoutTransport")
                'If Not IsDBNull(.OdbcReader("idTypeCause")) Then idTypeCause = .OdbcReader("idTypeCause")
                'If Not IsDBNull(.OdbcReader("idCategCause")) Then idCategCause = .OdbcReader("idCategCause")
                If Not IsDBNull(.OdbcReader("NumConfInitiale")) Then ConfIni = .OdbcReader("NumConfInitiale")
                If Not IsDBNull(.OdbcReader("PieceRetour")) Then PieceRetour = .OdbcReader("PieceRetour")
                If Not IsDBNull(.OdbcReader("ReferenceClient")) Then ReferenceClient = .OdbcReader("ReferenceClient")

                Dim leClient As New ClsClient(CodeClient, NomClient, ContactClient, TelephoneClient, MailClient, ReferenceClient, TypeClient)
                laReclamation = New ClsReclamation(.OdbcReader("idReclamation"), DateReception, Statut, NbPieces, NumConfInitiale, ValeurMarchande, CoutTransport,
                                                   idTypeCause, idCategCause, Commentaires, CommentairesAnalyse, ConfIni, PieceRetour, leClient)
            End With
        End Using

        Return laReclamation
    End Function


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
                    If Not IsDBNull(.OdbcReader("NomClient")) Then NomClient = .OdbcReader("NomClient")
                    If Not IsDBNull(.OdbcReader("ContactClient")) Then ContactClient = .OdbcReader("ContactClient")
                    If Not IsDBNull(.OdbcReader("TelephoneClient")) Then TelephoneClient = .OdbcReader("TelephoneClient")
                    If Not IsDBNull(.OdbcReader("MailClient")) Then MailClient = .OdbcReader("MailClient")
                    If Not IsDBNull(.OdbcReader("TypeClient")) Then TypeClient = .OdbcReader("TypeClient")
                    If Not IsDBNull(.OdbcReader("DateReception")) Then DateReception = .OdbcReader("DateReception")
                    If Not IsDBNull(.OdbcReader("NumConfInitiale")) Then NumConfInitiale = .OdbcReader("NumConfInitiale")
                    If Not IsDBNull(.OdbcReader("Commentaires")) Then Commentaires = .OdbcReader("Commentaires")
                    If Not IsDBNull(.OdbcReader("CommentairesAnalyse")) Then CommentairesAnalyse = .OdbcReader("CommentairesAnalyse")
                    If Not IsDBNull(.OdbcReader("Statut")) Then Statut = .OdbcReader("Statut")

                    Dim leClient As New ClsClient(CodeClient, NomClient, ContactClient, TelephoneClient, MailClient, TypeClient)
                    Dim laReclamation As New ClsReclamation(.OdbcReader("idReclamation"), DateReception, NumConfInitiale, Commentaires, CommentairesAnalyse, Statut, leClient)
                    _lesReclamations.Add(laReclamation._idRC, laReclamation)
                End While
            End With
        End Using
    End Sub

    Public Function InsertEnreg(laReclamation As ClsReclamation) As Integer
        Dim req As String = "INSERT INTO [dbReclamationsClient].[dbo].[RECLAMATIONS] (DateReception, Statut, Commentaires, NumConfInitiale, ReferenceClient, 
            TypeClient, CodeClient, NomClient, ContactClient, TelephoneClient, MailClient) VALUES('" &
                laReclamation._DateReception & "', '" &
                laReclamation._Statut & "', '" &
                ReplaceSpecialChars(laReclamation._Commentaires) & "', '" &
                laReclamation._NumConfInitiale & "', '" &
                laReclamation._leClient._RefClient & "', '" &
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

    Public Function ReadLesTypesCause(LibCateg As String) As Dictionary(Of Integer, String)

        'Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[TYPES_CAUSE] 
        '    RIGHT JOIN [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE] 
        '    on [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE].idCategCause = [dbReclamationsClient].[dbo].[TYPES_CAUSE].idCategCause
        '    WHERE LibelleCateg = '" & LibCateg & "'"

        'Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        's_FbMyReader.OdbcReader.Read()
        Dim result As New Dictionary(Of Integer, String)
        'Dim idType As Integer = -1
        'Dim LibType As String = ""
        'If Not IsDBNull(s_FbMyReader.OdbcReader("idTypeCause")) Then idType = s_FbMyReader.OdbcReader("idTypeCause")
        'If Not IsDBNull(s_FbMyReader.OdbcReader("LibelleTypeCause")) Then idType = s_FbMyReader.OdbcReader("LibelleTypeCause")
        result.Add(1, "Categorie")
        'result.Add(idType, LibType)

        Return result

    End Function

    Public Function ReadLesCategCause() As Dictionary(Of Integer, String)

        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE]"

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        Dim result As New Dictionary(Of Integer, String)
        While s_FbMyReader.OdbcReader.Read()

            result.Add(s_FbMyReader.OdbcReader("idCategCause"), s_FbMyReader.OdbcReader("LibelleCateg"))

        End While

        Return result

    End Function

    Public Function ReadLesPJByRC(idRC As Integer) As List(Of Fichier)

        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[PIECES_JOINTES] WHERE idRC = " & idRC

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        Dim result As New List(Of Fichier)

        While s_FbMyReader.OdbcReader.Read()

            Dim leFichier As New Fichier(s_FbMyReader.OdbcReader("NomFichier"), s_FbMyReader.OdbcReader("ExtensionFichier").replace(" ", ""), s_FbMyReader.OdbcReader("Fichier"))
            result.Add(leFichier)

        End While

        Return result

    End Function

    Private Function ReplaceSpecialChars(laChaine As String) As String
        laChaine = laChaine.Replace("'", "''")
        Return laChaine
    End Function

End Class
