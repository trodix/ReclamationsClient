Public Class ClsClient

    Property _Code As String
    Property _Nom As String
    Property _Contact As String
    Property _Tel As String
    Property _Mail As String

    Public Sub New(Code As String, Nom As String, Contact As String, Tel As String, Mail As String)

        _Code = Code
        _Nom = Nom
        _Contact = Contact
        _Tel = Tel
        _Mail = Mail

    End Sub


End Class
