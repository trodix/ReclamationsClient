Public Class UI_ListeRC

    Property _maSQLRC As New ClsSQLReclamationClient
    Property _lesReclamations As Dictionary(Of Integer, ClsReclamation)

    Property _idRcClicked As Integer = -1

    Private Sub UI_ListeRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _lesReclamations = _maSQLRC._lesReclamations

        For Each reclamation As ClsReclamation In _lesReclamations.Values
            DGV_Liste.Rows.Add(reclamation._idRC, reclamation._DateReception, reclamation._leClient._Code, reclamation._NumConfInitiale, reclamation._Statut)
        Next
    End Sub

    Private Sub DGV_Liste_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Liste.CellMouseClick
        Dim ligneCourante As Integer = e.RowIndex
        _idRcClicked = sender.Rows(ligneCourante).Cells(0).Value
    End Sub

    Private Sub Btn_OuvrirRC_Click(sender As Button, e As EventArgs) Handles Btn_OuvrirRC.Click
        If Not _idRcClicked = -1 Then
            Dim parent As FrmMenu = Me.FindForm()
            Dim myUI_RC As New UI_RC
            myUI_RC._idRC = _idRcClicked
            parent.LoadPage(myUI_RC)
        End If
    End Sub
End Class
