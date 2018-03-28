Public Class Fichier

    Property _Id As Integer
    Property _Nom As String
    Property _Ext As String
    Property _Contenu As Byte()

    Public Sub New(Nom As String, Ext As String, Contenu() As Byte, Optional id As Integer = -1)
        _Nom = Nom
        _Ext = Ext
        _Contenu = Contenu
        _Id = id
    End Sub

End Class
