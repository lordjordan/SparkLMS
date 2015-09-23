Public Class Collectibles
    Public principal, monthlyRate, totalPaymentBiMonth As Double
    Public biMonInterest As Decimal
    Public interest As Double
    Public bilangNGhulog, daysNgmonth As Integer
    Public dateStart As DateTime
    Public dateEnd As DateTime
    Dim itm As ListViewItem
    '### Change the "Data Source" path to point to our own LMS Database
    Dim db As New DBHelper("Data Source=C:\LMS.s3db; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Private Sub showAdvanceSearch(mode As Boolean)
        gbxAdvanceSearch.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub ShowDueDate()
        dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, date_start, date_end, principal, amortization, interest_percentage  FROM tbl_loans WHERE loan_status=1")
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
            MsgBox(dateStart & " " & bilangNGhulog & "" & dateEnd)


        Loop
        'principal/bilangNghulog  = bayad w/out interest /Monthly rate
        'principal*interestRate = totalPaymentPerMonth
        'monthlyrate/2 =bi-Monthly Interest
        principal = CDbl(dr.Item("principal"))
        monthlyRate = principal / bilangNGhulog
        biMonInterest = (CInt(dr.Item("interest_percentage")) / 100) / 2
        interest = principal * biMonInterest
        totalPaymentBiMonth = monthlyRate + interest
        'lblAmort.Text = totalPaymentBiMonth

        Do While dr.Read

            itm = Me.ListView1.Items.Add(dr.Item("loan_id").ToString)
            itm.SubItems.Add(Format(CDate(dr.Item("date_start").ToString), "MM-dd-yyyy"))
            itm.SubItems.Add(dr.Item("name").ToString)
            itm.SubItems.Add(principal)
            itm.SubItems.Add(monthlyRate)
            itm.SubItems.Add(interest)
            itm.SubItems.Add(totalPaymentBiMonth)
        Loop




        bilangNGhulog = 0
    End Sub

    Private bOWCheck() As Boolean


    'Dim mycb As New CheckBox
    Private Sub Collectibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbxAdvanceSearch.Visible = False

        'Try
        '    dr = db.ExecuteReader("SELECT loan_id, last_name || ' ' || first_name || ' ' || middle_name  as name, principal, amortization, interest_percentage, date_start, date_end" & _
        '                          ", application_status, loan_status FROM tbl_loans INNER JOIN tbl_clients ON tbl_loans.client_id = tbl_clients.client_id")
        '    If dr.HasRows Then

        '        '### You can also use loops for multiple-row result
        '        Do While dr.Read
        '            itm = Me.ListView1.Items.Add(dr.Item("loan_id").ToString)
        '            itm.SubItems.Add(dr.Item("date_start").ToString)
        '            itm.SubItems.Add(dr.Item("name").ToString)
        '            itm.SubItems.Add(dr.Item("principal").ToString)
        '            itm.SubItems.Add(dr.Item("amortization").ToString)
        '            itm.SubItems.Add(dr.Item("interest_percentage").ToString)
        '            itm.SubItems.Add(dr.Item("amortization").ToString)
        '        Loop
        '    Else
        '        MsgBox("No record of Collectibles", vbInformation + vbOKOnly, "No Collectible")
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        ShowDueDate()


    End Sub


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
End Class
