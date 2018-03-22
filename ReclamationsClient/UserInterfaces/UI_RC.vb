Public Class UI_RC

    Property _maClsSQLReclamationClient As New ClsSQLReclamationClient

    Property _lesClients As List(Of ClsClient)

    Private Sub UI_RC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For Each unClient As ClsClient In _lesClients
        '    Cmb_Clients.Items.Add(unClient._Code)
        'Next

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
            _lesClients = _maClsSQLReclamationClient.readLesClientsByCode(Cmb_Clients.Text.ToUpper)

            For Each leClient As ClsClient In _lesClients
                Cmb_Clients.Items.Add(leClient._Code)
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
End Class
