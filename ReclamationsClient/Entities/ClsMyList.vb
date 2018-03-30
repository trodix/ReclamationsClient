Class ClsMyList
    Public MyId As Integer
    Public MyStr As String

    Public Sub New(ByVal i As Integer, ByVal s As String)
        MyStr = s
        MyId = i
    End Sub

    '//VB.net will decide DisplayMember using this function
    Public Overrides Function ToString() As String
        ToString = MyStr
    End Function
End Class