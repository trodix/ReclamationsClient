Public Class ClsClient

    Property _Code As String
    Property _Nom As String
    Property _Contact As String
    Property _Tel As String
    Property _Mail As String
    Property _TypeClient As String
    Property _RefClient As String

    Public Sub New(Code As String, Nom As String, Contact As String, Tel As String, Mail As String, Optional RefClient As String = Nothing, Optional TypeClient As String = Nothing)

        _Code = Code
        _Nom = Nom
        _Contact = Contact
        _Tel = Tel
        _Mail = Mail
        _TypeClient = TypeClient
        _RefClient = RefClient

    End Sub

    Public Sub New()

    End Sub


End Class
