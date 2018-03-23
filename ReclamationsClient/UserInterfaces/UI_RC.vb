Public Class UI_RC

    Property _laSQLReclamationClient As New ClsSQLReclamationClient
    Property _leSQLClient As New ClsSQLClient

    Property _laReclamationClient As New ClsReclamation()
    Property _lesClients As List(Of ClsClient)

    Private Sub UI_RC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Btn_AnalyseRejet.Click, AddressOf Btn_Analyse_Click
        AddHandler Btn_AnalyseValider.Click, AddressOf Btn_Analyse_Click

        'If Not _laReclamationClient._Statut = "" Then Label_Statut.Text = _laReclamationClient._Statut

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
        _laReclamationClient._RefClient = Tbx_RefClient.Text
        _laReclamationClient._Commentaires = RTB_Commentaire.Text
        _laReclamationClient._Statut = "Analyse"
        _laReclamationClient._leClient._Code = Cmb_Clients.SelectedItem
        _laReclamationClient._leClient._Nom = Label_NomCli.Text
        _laReclamationClient._leClient._Contact = Label_ContactCli.Text
        _laReclamationClient._leClient._Mail = Label_MailCli.Text
        _laReclamationClient._leClient._Tel = Label_TelCli.Text

        Dim laReclamationClient As New ClsReclamation(_laReclamationClient._DateReception, _laReclamationClient._ConfIni, _laReclamationClient._RefClient, _laReclamationClient._Commentaires, _laReclamationClient._Statut, _laReclamationClient._leClient)
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
End Class
