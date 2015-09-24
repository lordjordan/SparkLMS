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
    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        Dim cellLoc As MyCell
        'cellLoc = WhichCell(ListView1, e.X, e.Y)
        'Label1.Text = cellLoc.Row.ToString & "  " & cellLoc.Col.ToString
        If cellLoc.Col = 2 Then
            If bOWCheck(cellLoc.Row) = True Then
                ListView1.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(168)
                bOWCheck(cellLoc.Row) = False
            Else
                ListView1.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(254)
                bOWCheck(cellLoc.Row) = True
            End If

        End If
        Label1.Focus()
        ListView1.Select()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Try
        dr = db.ExecuteReader("")
        'condition
        If LCase(txtSearchCollectibles.Text) Like "*in process*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE application_status= 0")
        ElseIf LCase(txtSearchCollectibles.Text) Like "*active*" Or LCase(txtSearchCollectibles.Text) Like "*approved*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE application_status= 1")
        ElseIf LCase(txtSearchCollectibles.Text) Like "*completed*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE loan_status= 2")
        ElseIf LCase(txtSearchCollectibles.Text) Like "*restructured*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE loan_status= 3")
        ElseIf LCase(txtSearchCollectibles.Text) Like "*returned*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE application_status= 4")
        ElseIf LCase(txtSearchCollectibles.Text) Like "*declined*" Then
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id WHERE application_status= 5")
        Else
            dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
                                  ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id" & _
                                  " WHERE loan_id LIKE  '%" & txtSearchCollectibles.Text.Trim & "%' " & _
                                  " or first_name LIKE '%" & txtSearchCollectibles.Text.Trim & "%' " & _
                                  " or last_name LIKE '%" & txtSearchCollectibles.Text.Trim & "%' " & _
                                  " or middle_name LIKE '%" & txtSearchCollectibles.Text.Trim & "%' " & _
                                  " or branch_id LIKE '%" & txtSearchCollectibles.Text.Trim & "%' " & _
                                  " or employee_no LIKE '%" & txtSearchCollectibles.Text.Trim & "%' ")
        End If

        If dr.HasRows Then
            Do While dr.Read

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

    End Sub
    Public Sub ShowDueDate()
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
                itm.SubItems.Add(dr.Item("principal").ToString)
                itm.SubItems.Add(Math.Round(monthlyRate, 2))
                itm.SubItems.Add(Math.Round(interest01, 2))
                itm.SubItems.Add(Math.Round(totalPaymentBiMonth, 2))
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

        'principal/bilangNghulog  = bayad w/out interest /Monthly rate
        'principal*interestRate = totalPaymentPerMonth
        'monthlyrate/2 =bi-Monthly Interest
        'principal = CDbl(dr.Item("principal"))
        'monthlyRate = principal / bilangNGhulog
        'biMonInterest = (CInt(dr.Item("interest_percentage")) / 100) / 2
        'interest = principal * biMonInterest
        'totalPaymentBiMonth = monthlyRate + interest
        'lblAmort.Text = totalPaymentBiMonth



        bilangNGhulog = 0
    End Sub

    Private Sub frmCollectibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbxAdvanceSearch.Visible = False
        ShowDueDate()
    End Sub



End Class
