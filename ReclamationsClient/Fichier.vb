Public Class Fichier

    Property _Nom As String
    Property _Ext As String
    Property _Contenu As Byte()

    Public Sub New(Nom As String, Ext As String, Contenu() As Byte)
        _Nom = Nom
        _Ext = Ext
        _Contenu = Contenu
    End Sub

End Class
