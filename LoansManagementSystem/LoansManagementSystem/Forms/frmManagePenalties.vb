Public Class frmManagePenalties
    Public principal, monthlyRate, totalPaymentBiMonth As Double
    Public biMonInterest As Decimal
    Public interest As Double
    Public bilangNGhulog, daysNgmonth As Integer
    Public dateStart As DateTime
    Public dateEnd As DateTime
    Public interest1 As Double
    Public interest01 As Double
    Public amortization As Double
    Dim itm As ListViewItem
    '### Change the "Data Source" path to point to our own LMS Database
    Dim db As New DBHelper("Data Source=" & My.Settings.ConString & "; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Private Sub btnCancelPenalties_Click(sender As Object, e As EventArgs) Handles btnCancelPenalties.Click
        Me.Close()
        uscCollectibles.gbxClientCollectible.Visible = True
    End Sub


    Public Sub ShowData()
        Dim penalty As Double
        Dim previous_bal As Double

        Dim x As Integer
        x = 0
        Dim arrLoan As New ArrayList
        dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end FROM tbl_loans " & _
                             "INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE loan_status=1")

        If dr.HasRows Then
            Do While dr.Read
                interest = CDbl(dr.Item("interest_percentage"))
                monthlyRate = CDbl(dr.Item("amortization"))
                interest01 = (interest / 100) * monthlyRate
                totalPaymentBiMonth = monthlyRate + interest01
                arrLoan.Add(dr.Item("loan_id").ToString)
                'MsgBox(arrLoan(x))
                itm = uscCollectibles.ListView1.Items.Add("")
                itm.SubItems.Add(Format(CDate(dr.Item("date_start").ToString), "MM-dd-yyyy"))
                itm.SubItems.Add(dr.Item("name").ToString)
                itm.SubItems.Add(Math.Round(totalPaymentBiMonth, 2))
                itm.SubItems.Add("")
                itm.SubItems.Add(penalty)
                itm.SubItems.Add(previous_bal)
                itm.SubItems.Add(Math.Round(monthlyRate, 2))
                itm.SubItems.Add(Math.Round(interest01, 2))
                itm.SubItems.Add(dr.Item("principal").ToString)

                'itm.SubItems.Add(dr.Item("totalPaymentBiMonth").ToString)
                x += 1
            Loop
        End If

        Exit Sub
    End Sub

    Private Sub frmManagePenalties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If uscCollectibles.ListView1.SelectedItems.Count > 0 Then

            itm.SubItems.Add(uscCollectibles.ListView1.SelectedItems(0).SubItems(1).Text)
            itm.SubItems.Add(uscCollectibles.ListView1.SelectedItems(0).SubItems(5).Text)
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class