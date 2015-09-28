Public Class frmCollectibles
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

    Private Sub showAdvanceSearch(mode As Boolean)
        gbxAdvanceSearch.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub showCollectibles(mode As Boolean)
        gbxClientCollectible.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)

    End Sub

    Private bOWCheck() As Boolean
    'Dim mycb As New CheckBox

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        showAdvanceSearch(False)
        'gbxAdvanceSearch.Visible = False
    End Sub

    Private Sub advsearch_Click_1(sender As Object, e As EventArgs) Handles advsearch.Click
        gbxAdvanceSearch.Visible = True
        pnlMain.Enabled = False
    End Sub

    Private Structure MyCell
        Dim Row As Integer
        Dim Col As Integer
    End Structure

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
                itm = Me.ListView1.Items.Add(dr.Item("loan_id").ToString)
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
        dateStart = CDate(dr.Item("date_start"))
        dateEnd = CDate(dr.Item("date_end"))

        'calculate the range at bilang ng hulog
        'ilagay ang bilang ng months sa variable
        'loop ang pag add until ma reach ang date end
        daysNgmonth = DateTime.DaysInMonth(dateStart.Year, dateStart.Month)

        Do Until dateStart >= dateEnd
            'if february?
            'kunin nextdate para mag fixed e.g 30-15 , 15-30 or 2-17, 17 - 2
            Select Case daysNgmonth

                Case 28
                    If dateStart.Day < 13 Then
                        dateStart = dateStart.AddDays(+15)
                    ElseIf dateStart.Day = 28 Then
                        dateStart = dateStart.AddDays(+15)
                        'Continue Do
                    Else
                        dateStart = dateStart.AddDays(+13)
                    End If
                Case 29
                    If dateStart.Day < 13 Then
                        dateStart = dateStart.AddDays(+15)
                    ElseIf dateStart.Day = 29 Then
                        dateStart = dateStart.AddDays(+15)
                        'Continue Do
                    Else
                        dateStart = dateStart.AddDays(+14)
                    End If
                Case 31
                    If dateStart.Day < 16 Then
                        dateStart = dateStart.AddDays(+15)
                    Else
                        dateStart = dateStart.AddDays(+16)
                    End If
                Case Else
                    dateStart = dateStart.AddDays(+15)
            End Select
            daysNgmonth = DateTime.DaysInMonth(dateStart.Year, dateStart.Month)
            bilangNGhulog += 1
            'MsgBox(dateStart & " " & bilangNGhulog & " " & dateEnd)


            If dr.HasRows Then
                Do While dr.Read
                    'MsgBox(dr.Item("loan_id"))
                    itm = Me.ListView1.Items.Add(dr.Item("loan_id").ToString)
                    itm.SubItems.Add(Format(CDate(dr.Item("date_start").ToString), "MM-dd-yyyy"))
                    itm.SubItems.Add(dr.Item("name").ToString)
                    'itm.SubItems.Add(principal)
                    'itm.SubItems.Add(monthlyRate)
                    'itm.SubItems.Add(interest)
                    'itm.SubItems.Add(totalPaymentBiMonth)
                Loop
                'Else
                '    MsgBox("No records of collectibles.", vbInformation + vbOKOnly, "No Collectibles")
            End If


        Loop

        bilangNGhulog = 0
    End Sub

    Private Sub frmCollectibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gbxAdvanceSearch.Visible = False
        ShowData()
    End Sub


    Private Sub btnCancelColl_Click(sender As Object, e As EventArgs) Handles btnCancelColl.Click
        showCollectibles(False)
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        frmManagePenalties.Show()
        gbxClientCollectible.Visible = False
        'frmManagePenalties.ListView2.SubItems.Add(uscCollectibles.ListView1.SelectedItems(0).SubItems(1).Text)
        'frmManagePenalties.ListView2.SubItems.Add(uscCollectibles.ListView1.SelectedItems(0).SubItems(5).Text)

    End Sub


    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        txtAmount.Focus()
        If ListView1.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            showCollectibles(True)
            txtAmount.Text = " "
            txtAmount.Focus()
            itm = Me.ListView1.SelectedItems(0)
        Else
            MessageBox.Show("Please select Client Collectibles.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not IsNothing(itm) Then
            'itm.Text = Me.txtAmount.Text
            itm.SubItems(4).Text = Me.txtAmount.Text
            showCollectibles(False)
            itm = Nothing
        Else
            MessageBox.Show("Please Select an Item")
        End If

    End Sub
    Private Sub EditItemInListView()

        If ListView1.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            'frmManagePenalties.ListView2.subitems.add()

            'txtUid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            'txtusername.Text = ListView1.SelectedItems(0).SubItems(1).Text
            'txtPassword.Text = ListView1.SelectedItems(0).SubItems(2).Text
            'cmbUtype.Text = ListView1.SelectedItems(0).SubItems(3).Text
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class
