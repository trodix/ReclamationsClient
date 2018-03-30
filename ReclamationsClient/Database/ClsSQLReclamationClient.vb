Public Class ClsSQLReclamationClient

    Property _lesReclamations As New Dictionary(Of Integer, ClsReclamation)

    Public Sub New()
        readLesReclamations()
    End Sub

    ''' <summary>
    ''' Retourne une réclamation
    ''' </summary>
    ''' <param name="idRC">id de la réclamation</param>
    ''' <remarks></remarks>
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
                Dim TypeCause As String = ""
                Dim CategCause As String = ""

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
                If Not IsDBNull(.OdbcReader("TypeCause")) Then TypeCause = .OdbcReader("TypeCause")
                If Not IsDBNull(.OdbcReader("Categorie")) Then CategCause = .OdbcReader("Categorie")

                Dim leClient As New ClsClient(CodeClient, NomClient, ContactClient, TelephoneClient, MailClient, ReferenceClient, TypeClient)
                laReclamation = New ClsReclamation(.OdbcReader("idReclamation"), DateReception, Statut, NbPieces, NumConfInitiale, ValeurMarchande, CoutTransport, TypeCause,
                                                            CategCause, Commentaires, CommentairesAnalyse, ConfIni, PieceRetour, leClient)
            End With
        End Using

        Return laReclamation
    End Function

    ''' <summary>
    ''' Retourne toutes les réclamations
    ''' </summary>
    ''' <remarks></remarks>
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
                    Dim NbPieces As Integer = 0
                    Dim ValeurMarchande As Decimal = 0
                    Dim CoutTransport As Decimal = 0
                    Dim TypeCause As String = ""
                    Dim CategCause As String = ""
                    Dim ConfIni As String = ""
                    Dim PieceRetour As Boolean = Nothing

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
                    If Not IsDBNull(.OdbcReader("TypeCause")) Then TypeCause = .OdbcReader("TypeCause")
                    If Not IsDBNull(.OdbcReader("Categorie")) Then CategCause = .OdbcReader("Categorie")
                    If Not IsDBNull(.OdbcReader("NumConfInitiale")) Then ConfIni = .OdbcReader("NumConfInitiale")
                    If Not IsDBNull(.OdbcReader("PieceRetour")) Then PieceRetour = .OdbcReader("PieceRetour")

                    Dim leClient As New ClsClient(CodeClient, NomClient, ContactClient, TelephoneClient, MailClient, TypeClient)
                    ' idRC As Integer, DateReception As Date, Statut As String, NbPieces As Integer, NumConfInitiale As String, ValeurMarchande As Decimal, CoutTransport As Decimal,
                    'TypeCause As String, CategCause As String, Commentaires As String, CommentairesAnalyse As String, ConfIni As String, PieceRetour As Boolean, leClient As ClsClient
                    Dim laReclamation As New ClsReclamation(.OdbcReader("idReclamation"), DateReception, Statut, NbPieces, NumConfInitiale, ValeurMarchande, CoutTransport, TypeCause,
                                                            CategCause, Commentaires, CommentairesAnalyse, ConfIni, PieceRetour, leClient)
                    'Dim laReclamation As New ClsReclamation(.OdbcReader("idReclamation"), DateReception, NumConfInitiale, Commentaires, CommentairesAnalyse, Statut, leClient)
                    _lesReclamations.Add(laReclamation._idRC, laReclamation)
                End While
            End With
        End Using
    End Sub

    ''' <summary>
    ''' Ajoute les information des champs de la section 'Enregistrement' pour une réclamation
    ''' </summary>
    ''' <param name="laReclamation">la réclamation</param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Retourne le dernier id de réclamation inséré dans la base de données
    ''' </summary>
    ''' <remarks></remarks>
    Public Function getLastId() As Integer

        Dim req2 As String = "SELECT MAX(idReclamation) AS lastId FROM [dbReclamationsClient].[dbo].[RECLAMATIONS]"

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req2, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        s_FbMyReader.OdbcReader.Read()
        Return s_FbMyReader.OdbcReader("lastId")

    End Function

    ''' <summary>
    ''' Ajoute les information des champs de la section 'Analyse' pour une réclamation
    ''' </summary>
    ''' <param name="laReclamation">la réclamation</param>
    ''' <remarks></remarks>
    Public Sub InsertAnalyse(laReclamation As ClsReclamation)
        Dim req As String = "UPDATE [dbReclamationsClient].[dbo].[RECLAMATIONS] SET Statut = '" & laReclamation._Statut &
            "', Commentaires = '" & ReplaceSpecialChars(laReclamation._Commentaires) & "', CommentairesAnalyse = '" &
            ReplaceSpecialChars(laReclamation._CommentairesAnalyse) & "' WHERE idReclamation = " & laReclamation._idRC

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Sub

    ''' <summary>
    ''' Ajoute les information des champs de la section 'Recencement' pour une réclamation
    ''' </summary>
    ''' <param name="laReclamation">la réclamation</param>
    ''' <remarks></remarks>
    Public Sub InsertRecencement(laReclamation As ClsReclamation)
        Dim req As String = "UPDATE [dbReclamationsClient].[dbo].[RECLAMATIONS] SET Statut = '" & laReclamation._Statut &
            "', Commentaires = '" & ReplaceSpecialChars(laReclamation._Commentaires) &
            "', NbPieces = " & laReclamation._NbPieces &
            ", ValeurMarchande = " & laReclamation._ValeurMarchande &
            ", CoutTransport = " & laReclamation._CoutTransport &
            ", TypeCause = '" & laReclamation._TypeCause &
            "', Categorie = '" & laReclamation._CategCause &
            "', PieceRetour = '" & laReclamation._PieceRetour & "' WHERE idReclamation = " & laReclamation._idRC

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using
    End Sub

    ''' <summary>
    ''' Retourne la liste des causes
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ReadLesTypesCause() As Dictionary(Of Integer, String)

        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[TYPES_CAUSE]"
        'RIGHT JOIN [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE] 
        'on [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE].idCategCause = [dbReclamationsClient].[dbo].[TYPES_CAUSE].idCategCause
        'WHERE LibelleCateg = '" & LibCateg & "'"

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        Dim result As New Dictionary(Of Integer, String)
        While s_FbMyReader.OdbcReader.Read()

            Dim idTypeCause As Integer = -1
            Dim LibType As String = ""
            If Not IsDBNull(s_FbMyReader.OdbcReader("idTypeCause")) Then idTypeCause = s_FbMyReader.OdbcReader("idTypeCause")
            If Not IsDBNull(s_FbMyReader.OdbcReader("LibelleType")) Then LibType = s_FbMyReader.OdbcReader("LibelleType")
            'result.Add(1, "Categorie")
            result.Add(idTypeCause, LibType)

        End While

        Return result

    End Function

    ''' <summary>
    ''' Retourne la liste des categories
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ReadLesCategCause() As Dictionary(Of Integer, String)

        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[CATEGORIES_CAUSE]"

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        Dim result As New Dictionary(Of Integer, String)
        While s_FbMyReader.OdbcReader.Read()

            result.Add(s_FbMyReader.OdbcReader("idCategCause"), s_FbMyReader.OdbcReader("LibelleCateg"))

        End While

        Return result

    End Function

    ''' <summary>
    ''' Retourne la liste des pieces-jointes d'une reclamation
    ''' </summary>
    ''' <param name="idRC">id de la reclamation</param>
    ''' <remarks></remarks>
    Public Function ReadLesPJByRC(idRC As Integer) As List(Of ClsFichier)

        Dim req As String = "SELECT * FROM [dbReclamationsClient].[dbo].[PIECES_JOINTES] WHERE idRC = " & idRC

        Dim s_FbMyReader As New ClassConnection.ClsOdbcConnection(req, ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
        Dim result As New List(Of ClsFichier)

        While s_FbMyReader.OdbcReader.Read()

            Dim leFichier As New ClsFichier(s_FbMyReader.OdbcReader("NomFichier"), s_FbMyReader.OdbcReader("ExtensionFichier").replace(" ", ""), s_FbMyReader.OdbcReader("Fichier"), s_FbMyReader.OdbcReader("idPieceJointe"))
            result.Add(leFichier)

        End While

        Return result

    End Function

    ''' <summary>
    ''' Supprime une piece-jointe
    ''' </summary>
    ''' <param name="idPJ">id de la piece-jointe</param>
    ''' <remarks></remarks>
    Public Sub SupprimerPJ(idPJ As Integer)

        Dim req As String = "DELETE FROM [dbReclamationsClient].[dbo].[PIECES_JOINTES] WHERE idPieceJointe = " & idPJ

        Using _odbcConnection As New ClassConnection.ClsOdbcConnection(ClassConnection.ClsChaineConnection.ChaineConnection.ENTRETIEN)
            _odbcConnection.OdbcNotSelectQuery(req)
        End Using

    End Sub


    Private Function ReplaceSpecialChars(laChaine As String) As String
        laChaine = laChaine.Replace("'", "''")
        Return laChaine
    End Function

End Class
