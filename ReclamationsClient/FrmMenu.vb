Public Class FrmMenu

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myUI_RC As New UI_RC
        Panel_Main.Controls.Add(myUI_RC)
        myUI_RC.Dock = DockStyle.Fill
    End Sub

End Class