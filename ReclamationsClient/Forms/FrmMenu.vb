Public Class FrmMenu

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPage(New UI_ListeRC)

    End Sub

    Private Sub Btn_Liste_Click(sender As Object, e As EventArgs) Handles Btn_Liste.Click

        LoadPage(New UI_ListeRC)

    End Sub

    Private Sub Btn_Nouveau_Click(sender As Object, e As EventArgs) Handles Btn_Nouveau.Click

        LoadPage(New UI_RC)

    End Sub

    ''' <summary>
    ''' Affiche une nouvelle instance d'une interface utilisateur dans le Formulaire principal de l'application
    ''' <param name="MyUserInterface"></param> 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadPage(MyUserInterface As Object)

        Panel_Main.Controls.Clear()
        Panel_Main.Controls.Add(MyUserInterface)
        MyUserInterface.Dock = DockStyle.Fill

    End Sub


End Class