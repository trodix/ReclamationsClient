Public Class UI_RC

    Property _laSQLReclamationClient As New ClsSQLReclamationClient
    Property _leSQLClient As New ClsSQLClient
    Property _FileManager As New FilesIntoDatabase.FileManager("Server=SRV-BDD\SQLEXPRESS2008;Database=dbReclamationsClient;Uid=sa;Pwd=+BTS08;")

    Property _laReclamationClient As New ClsReclamation()
    Property _lesClients As List(Of ClsClient)

    Property _idRC As Integer = -1
    Property _selectedTypeCause As String = ""
    Property _lesPJ As List(Of Fichier)

    Private Sub UI_RC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Btn_AnalyseRejet.Click, AddressOf Btn_Analyse_Click
        AddHandler Btn_AnalyseValider.Click, AddressOf Btn_Analyse_Click

        For Each item As String In _laSQLReclamationClient.ReadLesCategCause.Values
            Cmb_CategCause.Items.Add(item)
        Next

        For Each item As String In _laSQLReclamationClient.ReadLesTypesCause(_selectedTypeCause).Values
            Cmb_TypeCause.Items.Add(item)
        Next

        AfficherPJ()

        If Not _idRC = -1 Then
            _laReclamationClient = _laSQLReclamationClient.ReadUneReclamationById(_idRC)

            Label_Statut.Text = _laReclamationClient._Statut
            RTB_Commentaire.Text = _laReclamationClient._Commentaires
            If _laReclamationClient._leClient._TypeClient = RB_Soustraitance.Text Then
                RB_Soustraitance.Checked = True
            ElseIf _laReclamationClient._leClient._TypeClient = RB_Agencement.Text Then
                RB_Agencement.Checked = True
            End If
            Dtp_DateReception.Value = _laReclamationClient._DateReception
            Cmb_Clients.Text = _laReclamationClient._leClient._Code
            Label_NomCli.Text = _laReclamationClient._leClient._Nom
            Label_ContactCli.Text = _laReclamationClient._leClient._Contact
            Label_TelCli.Text = _laReclamationClient._leClient._Tel
            Label_MailCli.Text = _laReclamationClient._leClient._Mail
            Tbx_RefClient.Text = _laReclamationClient._leClient._RefClient
            Tbx_ConfIni.Text = _laReclamationClient._ConfIni
            RTB_AnalyseCommentaire.Text = _laReclamationClient._CommentairesAnalyse
            Nud_NbPieces.Value = _laReclamationClient._NbPieces
            Nud_ValMarchande.Value = _laReclamationClient._ValeurMarchande
            Nud_CoutTransport.Value = _laReclamationClient._CoutTransport
            If _laReclamationClient._PieceRetour = True Then
                RB_PieceRetour_Oui.Checked = True
            ElseIf _laReclamationClient._PieceRetour = False Then
                RB_PieceRetour_Non.Checked = True
            End If
        End If

    End Sub

    Private Sub Cmb_Clients_KeyUp(sender As Object, e As KeyEventArgs) Handles Cmb_Clients.KeyUp

        If e.KeyCode = Keys.Enter Then
            Try
                Cmb_Clients.SelectedIndex = 0
            Catch ex As Exception

            End Try
        Else
            Cmb_Clients.Items.Clear()
            Cmb_Clients.Select(Cmb_Clients.Text.Length, 0)
            _lesClients = _leSQLClient.readLesClientsByCode(Cmb_Clients.Text.ToUpper)

            For Each leClient As ClsClient In _lesClients
                _laReclamationClient._leClient = leClient
                Cmb_Clients.Items.Add(_laReclamationClient._leClient._Code)
            Next
        End If
    End Sub

    Private Sub Cmb_Clients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Clients.SelectedIndexChanged

        Dim result = From cli In _lesClients
                     Where cli._Code = Cmb_Clients.Text

        For Each res As ClsClient In result

            Label_NomCli.Text = res._Nom
            Label_ContactCli.Text = res._Contact
            Label_TelCli.Text = res._Tel
            Label_MailCli.Text = res._Mail

        Next

        'For Each cli As ClsClient In _lesClients
        '    If cli._Code.Equals(Cmb_Clients.Text) Then MsgBox("Trouvé " & Cmb_Clients.Text)
        'Next

    End Sub

    Private Sub Btn_Enreg_Click(sender As Object, e As EventArgs) Handles Btn_Enreg.Click

        _laReclamationClient._DateReception = Dtp_DateReception.Value
        _laReclamationClient._ConfIni = Tbx_ConfIni.Text
        _laReclamationClient._leClient._RefClient = Tbx_RefClient.Text
        _laReclamationClient._Commentaires = RTB_Commentaire.Text
        _laReclamationClient._Statut = "Analyse"
        _laReclamationClient._leClient._Code = Cmb_Clients.SelectedItem
        _laReclamationClient._leClient._Nom = Label_NomCli.Text
        _laReclamationClient._leClient._Contact = Label_ContactCli.Text
        _laReclamationClient._leClient._Mail = Label_MailCli.Text
        _laReclamationClient._leClient._Tel = Label_TelCli.Text
        If RB_Agencement.Checked Then _laReclamationClient._leClient._TypeClient = RB_Agencement.Text
        If RB_Soustraitance.Checked Then _laReclamationClient._leClient._TypeClient = RB_Soustraitance.Text

        Dim laReclamationClient As New ClsReclamation(_laReclamationClient._DateReception, _laReclamationClient._ConfIni, _laReclamationClient._Commentaires, _laReclamationClient._Statut, _laReclamationClient._leClient)
        _laReclamationClient._idRC = _laSQLReclamationClient.InsertEnreg(laReclamationClient)

    End Sub

    Private Sub RB_Soustraitance_CheckedChanged(sender As RadioButton, e As EventArgs) Handles RB_Soustraitance.CheckedChanged
        _laReclamationClient._leClient._TypeClient = sender.Text
    End Sub

    Private Sub RB_Agencement_CheckedChanged(sender As RadioButton, e As EventArgs) Handles RB_Agencement.CheckedChanged
        _laReclamationClient._leClient._TypeClient = sender.Text
    End Sub

    Private Sub Btn_Analyse_Click(sender As Object, e As EventArgs)

        _laReclamationClient._Commentaires = RTB_Commentaire.Text
        _laReclamationClient._CommentairesAnalyse = RTB_AnalyseCommentaire.Text
        If sender.name = Btn_AnalyseValider.Name Then
            _laReclamationClient._Statut = "Recencement"
        ElseIf sender.name = Btn_AnalyseRejet.Name Then
            _laReclamationClient._Statut = "Rejeté"
        End If

        Dim laReclamationClient As New ClsReclamation(_laReclamationClient._idRC, _laReclamationClient._Statut, _laReclamationClient._Commentaires,
                                                      _laReclamationClient._CommentairesAnalyse)
        _laSQLReclamationClient.InsertAnalyse(laReclamationClient)

    End Sub

    Private Sub Btn_Recencement_Click(sender As Object, e As EventArgs) Handles Btn_Recencement.Click

        _laReclamationClient._NbPieces = Nud_NbPieces.Value
        _laReclamationClient._ValeurMarchande = Nud_ValMarchande.Value
        _laReclamationClient._CoutTransport = Nud_CoutTransport.Value
        _laReclamationClient._Commentaires = RTB_Commentaire.Text

        Dim laReclamationClient As New ClsReclamation(_laReclamationClient._idRC, _laReclamationClient._Statut, _laReclamationClient._Commentaires, _laReclamationClient._NbPieces,
                                                      _laReclamationClient._ValeurMarchande, _laReclamationClient._CoutTransport)
        _laSQLReclamationClient.InsertRecencement(laReclamationClient)

    End Sub

    Private Sub RB_PieceRetour_Oui_CheckedChanged(sender As RadioButton, e As EventArgs) Handles RB_PieceRetour_Oui.CheckedChanged
        _laReclamationClient._PieceRetour = True
    End Sub

    Private Sub RB_PieceRetour_Non_CheckedChanged(sender As RadioButton, e As EventArgs) Handles RB_PieceRetour_Non.CheckedChanged
        _laReclamationClient._PieceRetour = False
    End Sub

    Private Sub Btn_AjouterPJ_Click(sender As Object, e As EventArgs) Handles Btn_AjouterPJ.Click
        OpenFileDialog1.Filter = "All files (*.*) |*.*"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                _FileManager.Sauvegarde("INSERT INTO [dbReclamationsClient].[dbo].[PIECES_JOINTES] (NomFichier, ExtensionFichier, Fichier, idRC) VALUES(@Nom, @Extension, @Fichier, " & _idRC & ")", OpenFileDialog1)
            Catch ex As Exception
                MsgBox("Problème d'insertion du fichier dans la base de données" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
            End Try
            AfficherPJ()
        End If
    End Sub

    Private Sub AfficherPJ()
        _lesPJ = _laSQLReclamationClient.ReadLesPJByRC(_idRC)
        For Each pj As Fichier In _lesPJ
            LB_PiecesJointes.Items.Add(pj._Nom & pj._Ext)
        Next
    End Sub

    Private Sub LB_PiecesJointes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LB_PiecesJointes.MouseDoubleClick

        Dim result = From pj In _lesPJ
                     Where sender.Text = (pj._Nom & pj._Ext)

        For Each item As Fichier In result
            _FileManager.ConstruireEtOuvrir(item._Nom, item._Ext, item._Contenu)
        Next

    End Sub

    Private Sub Btn_SupprPJ_Click(sender As Object, e As EventArgs) Handles Btn_SupprPJ.Click
        '_FileManager.Supprimer()
    End Sub
End Class
