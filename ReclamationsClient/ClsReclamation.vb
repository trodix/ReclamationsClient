Public Class ClsReclamation

    Property _idRC As Integer = -1
    Property _DateReception As Date
    Property _Statut As String
    Property _NbPieces As Integer
    Property _NumConfInitiale As String
    Property _ValeurMarchande As Decimal
    Property _CoutTransport As Decimal
    Property _TypeCause As String
    Property _CategCause As String
    Property _Commentaires As String
    Property _CommentairesAnalyse As String
    Property _ConfIni As String
    Property _PieceRetour As Boolean
    Property _RefClient As String
    Property _leClient As New ClsClient

    Public Sub New(idReclamation As Integer, DateReception As Date, NumConfInitiale As String, Commentaires As String, CommentairesAnalyse As String, Statut As String, leClient As ClsClient)
        _idRC = idReclamation
        _DateReception = DateReception
        _Statut = Statut
        _NumConfInitiale = NumConfInitiale
        _Commentaires = Commentaires
        _CommentairesAnalyse = CommentairesAnalyse
        _leClient = leClient
    End Sub

    Public Sub New(DateReception As Date, NumConfInitiale As String, RefClient As String, Commentaires As String, Statut As String, leClient As ClsClient)
        _DateReception = DateReception
        _Statut = Statut
        _NumConfInitiale = NumConfInitiale
        _Commentaires = Commentaires
        _RefClient = RefClient
        _leClient = leClient
    End Sub

    Public Sub New(idRC As Integer, statut As String, commentaires As String, commentairesAnalyse As String)
        _idRC = idRC
        _Statut = statut
        _Commentaires = commentaires
        _CommentairesAnalyse = commentairesAnalyse
    End Sub

    Public Sub New(idRC As Integer, statut As String, commentaires As String, nbPieces As String, valeurMarchande As Decimal, coutTransport As Decimal)
        _idRC = idRC
        _Statut = statut
        _Commentaires = commentaires
        _NbPieces = nbPieces
        _ValeurMarchande = valeurMarchande
        _CoutTransport = coutTransport

    End Sub

    Public Sub New()

    End Sub

End Class
