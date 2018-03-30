Public Class FrmAvoir

    Property _NomClient As String = ""

    Private Sub Btn_Envoi_Click(sender As Object, e As EventArgs) Handles Btn_Envoi.Click
        Close()
    End Sub

    Private Sub FrmAvoir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_NomClient.Text = _NomClient
    End Sub
End Class