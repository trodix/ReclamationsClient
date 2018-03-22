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

    Public Sub New(DateReception As Date, Statut As String, NbPieces As Integer, NumConfInitiale As String, ValeurMarchande As Decimal,
                   CoutTransport As Decimal, TypeCause As String, CategCause As String, Commentaires As String)
        _DateReception = DateReception
        _Statut = Statut
        _NbPieces = NbPieces
        _NumConfInitiale = NumConfInitiale
        _ValeurMarchande = ValeurMarchande
        _CoutTransport = CoutTransport
        _TypeCause = TypeCause
        _CategCause = CategCause
        _Commentaires = Commentaires
    End Sub

    Public Sub New()

    End Sub

End Class
