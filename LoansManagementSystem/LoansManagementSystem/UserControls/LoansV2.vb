Public Class LoansV2

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        gbxAddEdit.Visible = True
        btnFind_Click(Me, e)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        gbxShowClient.Visible = True
        gbxShowClient.Enabled = True
        gbxShowClient.BringToFront()
    End Sub

    Private Sub btnClientBack_Click(sender As Object, e As EventArgs) Handles btnClientBack.Click
        gbxShowClient.Visible = False
        gbxShowClient.Enabled = False
    End Sub
End Class
