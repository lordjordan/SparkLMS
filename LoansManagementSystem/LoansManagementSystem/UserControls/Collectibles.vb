Public Class frmCollectibles
    Public principal, monthlyRate, totalPaymentBiMonth As Double
    Public biMonInterest As Decimal
    Public interest As Double
    Public bilangNGhulog, daysNgmonth As Integer
    Public dateStart, dateEnd, dueDate As DateTime

    Public interest1 As Double
    Public interest01 As Double
    Public amortization As Double

    'Dim dateFrom, getLastmonth As DateTime
    Dim penalty, previous_bal As Double
    Dim a, b, c As String
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

   

    Private Structure MyCell
        Dim Row As Integer
        Dim Col As Integer
    End Structure

    Public Sub ShowData()




        dr = db.ExecuteReader("SELECT tblCol.loan_id as LoanID, MAX(due_date) as petsa, first_name || ' ' || middle_name || ' ' || last_name as Name, " & _
        "payable_amt, previous_balance, principal, date_start, date_end , interest_percentage " & _
        "FROM  (SELECT ctb_id , loan_id , due_date , payable_amt, previous_balance " & _
        "FROM tbl_collectibles  WHERE due_date <= '" & Format(Date.Now, "yyyyMMdd") & "') as tblCol " & _
        "INNER JOIN tbl_loans ON tbl_loans.loan_id = tblCol.loan_id INNER JOIN " & _
        "tbl_clients ON tbl_loans.client_id = tbl_clients.client_id " & _
        "GROUP BY tblCol.loan_id")

        If dr.HasRows Then

            Do While dr.Read
                itm = lvCollectibles.Items.Add(dr.Item("loanID").ToString)
                'converstion of string date (yyyyMMdd) to date
                a = dr.Item("petsa").ToString().Substring(0, 4)
                b = dr.Item("petsa").ToString().Substring(4, 2)
                c = dr.Item("petsa").ToString().Substring(6, 2)
                dueDate = CDate(b & "/" & c & "/" & a)
                itm.SubItems.Add(dueDate) 'casted
                itm.SubItems.Add(dr.Item("Name").ToString)
                itm.SubItems.Add(":)") 'try to check next process payable amount

                itm.SubItems.Add("") 'collected amount

                itm.SubItems.Add("") 'inputted amount


                itm.SubItems.Add(checkPenalty(CDbl(dr.Item("principal").ToString), dueDate)) 'checking status for penalty next process



                'getting the terms
                dateStart = CDate(dr.Item("date_start").ToString().Substring(4, 2) & "/" & dr.Item("date_start").ToString().Substring(6, 2) _
                     & "/" & dr.Item("date_start").ToString().Substring(0, 4))

                dateEnd = CDate(dr.Item("date_end").ToString().Substring(4, 2) & "/" & dr.Item("date_end").ToString().Substring(6, 2) _
                     & "/" & dr.Item("date_end").ToString().Substring(0, 4))
                daysNgmonth = DateTime.DaysInMonth(dateStart.Year, dateStart.Month)
                bilangNGhulog = 1

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

                Loop
                'txtTerms.Text = bilangNGhulog / 2
                principal = CDbl(dr.Item("principal").ToString)
                monthlyRate = principal / bilangNGhulog
                biMonInterest = (CInt(dr.Item("interest_percentage").ToString) / 100) / 2
                interest = principal * biMonInterest

                itm.SubItems.Add("")    'previous balance next process
                itm.SubItems.Add(Math.Round(monthlyRate, 2)) 'may formula principal amount

                itm.SubItems.Add(interest)    'interest

                itm.SubItems.Add("")    'oustanding balance next process
            Loop

        End If

        'payable amount , penalty , previous balance kung meronn
        Dim pangIlan As Integer
        Dim payableAmount, balance, penaltyVal As Double
        pangIlan = 0
        payableAmount = 0
        balance = 0
        For x = 1 To lvCollectibles.Items.Count Step 1
            dr = db.ExecuteReader("SELECT * FROM tbl_collectibles WHERE loan_id = " & lvCollectibles.Items(x - 1).SubItems(0).Text & _
                                  " ORDER BY due_date ASC")
            If dr.HasRows Then

                Do While dr.Read

                    a = dr.Item("due_date").ToString().Substring(0, 4)
                    b = dr.Item("due_date").ToString().Substring(4, 2)
                    c = dr.Item("due_date").ToString().Substring(6, 2)
                    dueDate = CDate(b & "/" & c & "/" & a)

                    If dueDate = lvCollectibles.Items(x - 1).SubItems(1).Text Then

                        lvCollectibles.Items(x - 1).SubItems(3).Text = CDbl(dr.Item("payable_amt").ToString.Insert(6, ".")) + previous_bal '+ previous collected amount round off ba ito.

                        If Not lvCollectibles.Items(x - 1).SubItems(3).Text.Contains(".") Then
                            lvCollectibles.Items(x - 1).SubItems(3).Text &= ".00"
                        End If
                        
                        lvCollectibles.Items(x - 1).SubItems(6).Text = penaltyVal + CDbl(lvCollectibles.Items(x - 1).SubItems(6).Text)
                        lvCollectibles.Items(x - 1).SubItems(7).Text = payableAmount
                        Exit Do

                    Else

                        previous_bal = dr.Item("previous_balance").ToString
                        'if condition sa penalty val status
                        penaltyVal += CDbl(lvCollectibles.Items(x - 1).SubItems(6).Text)
                        'payableAmount = CDbl(dr.Item("payable_amt").ToString.Insert(6, "."))

                    End If
                    pangIlan += 1
                Loop
                pangIlan = 0
                payableAmount = 0
                balance = 0
                penaltyVal = 0
            End If
        Next

        Exit Sub


        dr = db.ExecuteReader("SELECT tbl_loans.loan_id as 'loanID' , last_name || ' ' || first_name || ' ' || middle_name  as name, payable_amt, penalty_amt, previous_balance, date_end FROM tbl_loans " & _
                             "INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id INNER JOIN tbl_collectibles ON " & _
                             "tbl_loans.loan_id = tbl_collectibles.loan_id WHERE loan_status= 1")


        If dr.HasRows Then
            Do While dr.Read
                interest = CDbl(dr.Item("interest_percentage"))
                monthlyRate = CDbl(dr.Item("amortization"))
                interest01 = (interest / 100) * monthlyRate
                totalPaymentBiMonth = monthlyRate + interest01
                'arrLoan.Add(dr.Item("loan_id").ToString)
                'MsgBox(arrLoan(x))
                itm = Me.lvCollectibles.Items.Add(dr.Item("loan_id").ToString)
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
                'x += 1
            Loop
        End If

        Exit Sub
        'dateStart = CDate(dr.Item("date_start"))
        'dateEnd = CDate(dr.Item("date_end"))

        ''calculate the range at bilang ng hulog
        ''ilagay ang bilang ng months sa variable
        ''loop ang pag add until ma reach ang date end
        'daysNgmonth = DateTime.DaysInMonth(dateStart.Year, dateStart.Month)

        'Do Until dateStart >= dateEnd
        '    'if february?
        '    'kunin nextdate para mag fixed e.g 30-15 , 15-30 or 2-17, 17 - 2
        '    Select Case daysNgmonth

        '        Case 28
        '            If dateStart.Day < 13 Then
        '                dateStart = dateStart.AddDays(+15)
        '            ElseIf dateStart.Day = 28 Then
        '                dateStart = dateStart.AddDays(+15)
        '                'Continue Do
        '            Else
        '                dateStart = dateStart.AddDays(+13)
        '            End If
        '        Case 29
        '            If dateStart.Day < 13 Then
        '                dateStart = dateStart.AddDays(+15)
        '            ElseIf dateStart.Day = 29 Then
        '                dateStart = dateStart.AddDays(+15)
        '                'Continue Do
        '            Else
        '                dateStart = dateStart.AddDays(+14)
        '            End If
        '        Case 31
        '            If dateStart.Day < 16 Then
        '                dateStart = dateStart.AddDays(+15)
        '            Else
        '                dateStart = dateStart.AddDays(+16)
        '            End If
        '        Case Else
        '            dateStart = dateStart.AddDays(+15)
        '    End Select
        '    daysNgmonth = DateTime.DaysInMonth(dateStart.Year, dateStart.Month)
        '    bilangNGhulog += 1
        '    'MsgBox(dateStart & " " & bilangNGhulog & " " & dateEnd)


        '    If dr.HasRows Then
        '        Do While dr.Read
        '            'MsgBox(dr.Item("loan_id"))
        '            itm = Me.lvCollectibles.Items.Add(dr.Item("loan_id").ToString)
        '            itm.SubItems.Add(Format(CDate(dr.Item("date_start").ToString), "MM-dd-yyyy"))
        '            itm.SubItems.Add(dr.Item("name").ToString)
        '            'itm.SubItems.Add(principal)
        '            'itm.SubItems.Add(monthlyRate)
        '            'itm.SubItems.Add(interest)
        '            'itm.SubItems.Add(totalPaymentBiMonth)
        '        Loop
        '        'Else
        '        '    MsgBox("No records of collectibles.", vbInformation + vbOKOnly, "No Collectibles")
        '    End If


        'Loop

        'bilangNGhulog = 0
        '' Catch ex As Exception
        ''MsgBox(ex.ToString, MsgBoxStyle.Critical)
        ''End Try
    End Sub

    Private Sub frmCollectibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gbxAdvanceSearch.Visible = False
        ShowData()
    End Sub


    Private Sub btnCancelColl_Click(sender As Object, e As EventArgs) Handles btnCancelColl.Click
        showCollectibles(False)
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        frmManagePenalties.ShowDialog()

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


    Private Sub lvCollectibles_DoubleClick(sender As Object, e As EventArgs) Handles lvCollectibles.DoubleClick
        lvDuedates.Items.Clear()
        txtAmount.Focus()
        If lvCollectibles.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            showCollectibles(True)

            txtAmount.Text = ""
            txtAmount.Focus()
            itm = Me.lvCollectibles.SelectedItems(0)
            lblPayableAmount.Text = lvCollectibles.FocusedItem.SubItems(3).Text
           
            dr = db.ExecuteReader("SELECT due_date, principal FROM tbl_collectibles INNER JOIN tbl_loans ON tbl_collectibles.loan_id " & _
                                  "= tbl_loans.loan_id WHERE penalty_status= 0 AND due_date <='" & _
                                  Format(CDate(lvCollectibles.FocusedItem.SubItems(1).Text), "yyyyMMdd") & "' AND tbl_collectibles.loan_id = " & lvCollectibles.FocusedItem.SubItems(0).Text _
                                  & " ORDER BY due_date ASC")
            If dr.HasRows Then

                Do While dr.Read
                    a = dr.Item("due_date").ToString().Substring(0, 4)
                    b = dr.Item("due_date").ToString().Substring(4, 2)
                    c = dr.Item("due_date").ToString().Substring(6, 2)
                    dueDate = CDate(b & "/" & c & "/" & a)
                    itm = lvDuedates.Items.Add(dueDate) 'casted
                    itm.SubItems.Add(checkPenalty(dr.Item("principal").ToString, dueDate))
                    
                Loop
                For x = 1 To lvDuedates.Items.Count Step 1
                    If lvDuedates.Items(x - 1).Text = dueDate Then
                        lvDuedates.Items(x - 1).Checked = True
                    End If
                Next
            End If
            
            


        Else
            MessageBox.Show("Please select Client Collectibles.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
        gbxClientCollectible.BringToFront()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not IsNothing(itm) Then
            'itm.Text = Me.txtAmount.Text
            itm.SubItems(5).Text = Me.txtAmount.Text
            showCollectibles(False)
            itm = Nothing
        Else
            MessageBox.Show("Please Select an Item")
        End If

    End Sub
    Private Sub EditItemInListView()

        If lvCollectibles.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            'frmManagePenalties.ListView2.subitems.add()

            'txtUid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            'txtusername.Text = ListView1.SelectedItems(0).SubItems(1).Text
            'txtPassword.Text = ListView1.SelectedItems(0).SubItems(2).Text
            'cmbUtype.Text = ListView1.SelectedItems(0).SubItems(3).Text
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function checkPenalty(principal As Double, dueDate As Date)
        Dim amount As Integer

        If dueDate < Date.Now Then

            If principal <= 10000 Then
                amount = 300
            ElseIf principal >= 10000 And principal = 20000 Then
                amount = 400
            Else
                amount = 500
            End If
      
        Else
            amount = 0
        End If


        Return amount
    End Function

    Private Sub lvCollectibles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCollectibles.SelectedIndexChanged

    End Sub
End Class
