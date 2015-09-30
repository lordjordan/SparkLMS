Public Class Company
    Dim itm As ListViewItem

    Dim db As New DBHelper("Data Source=" & My.Settings.ConString & "; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Dim cmd As SQLite.SQLiteCommand
    Private Sub showAddEdit(mode As Boolean)
        gbxAddEdit.Visible = mode
        pnlMain.Enabled = Not mode

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        AddItemToListView()
    End Sub

    Private Sub AddItemToListView()
        txtCompanyRemarks.Focus()
        showAddEdit(True)
        dr = db.ExecuteReader("select *from tbl_company")
        Dim maxId As Integer = 0
        gbxAddEdit.Text = "Add New Company Information"
        showAddEdit(True)

        While dr.Read = True
            If maxId < dr.Item(0) Then maxId = dr.Item(0)
        End While

        txtCompanyName.Focus()
        txtCompanyID.Text = maxId + 1
        txtCompanyName.Text = ""
        txtCompanyAd.Text = ""
        txtCompanyConNum.Text = ""
        txtCompanyContPers.Text = ""
        txtCompanyRemarks.Text = ""
    End Sub
    Private Sub LoadListView()
        ListView1.Items.Clear()
        showAddEdit(False)

        dr = db.ExecuteReader("SELECT * from tbl_company")
        If dr.HasRows Then


            Do While dr.Read
                itm = Me.ListView1.Items.Add(dr.Item("company_id").ToString)
                itm.SubItems.Add(dr.Item("company_name").ToString)
                itm.SubItems.Add(dr.Item("company_address").ToString)
                itm.SubItems.Add(dr.Item("company_contact_number").ToString)
                itm.SubItems.Add(dr.Item("company_contact_person").ToString)
                itm.SubItems.Add(dr.Item("company_remarks").ToString)
            Loop
        Else
            MsgBox("No record of Company.", vbInformation + vbOKOnly, "No Company")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gbxAddEdit.Text = "Add New Company Information" Then

            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("company_name", txtCompanyName.Text)
                data.Add("company_address", txtCompanyAd.Text)
                data.Add("company_contact_number", txtCompanyConNum.Text)
                data.Add("company_contact_person", txtCompanyContPers.Text)
                data.Add("company_remarks", txtCompanyRemarks.Text)

                rec = db.ExecuteNonQuery("INSERT INTO tbl_company values(NULL,@company_name,@company_address,@company_contact_number,@company_contact_person,@company_remarks)", data)

                If Not rec < 1 Then
                    showAddEdit(False)
                    MessageBox.Show("Record Saved!", "import Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListView()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        ElseIf gbxAddEdit.Text = "Edit Company Information" Then

            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)



            Try
                data.Add("company_name", txtCompanyName.Text)
                data.Add("company_address", txtCompanyAd.Text)
                data.Add("company_contact_number", txtCompanyConNum.Text)
                data.Add("company_contact_person", txtCompanyContPers.Text)
                data.Add("compant_remarks", txtCompanyRemarks.Text)

                rec = db.ExecuteNonQuery("UPDATE tbl_company SET company_name=@company_name, company_address=@company_address, company_contact_number=@company_contac_number, company_contact_person=@company_contact_person, company_remarks=@company_remarks" & txtCompanyID.Text, data)

                If Not rec < 1 Then
                    MessageBox.Show("Record Updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListView()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Record")

            End Try
        End If



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showAddEdit(False)
    End Sub

    Private Sub Company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListView()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditItemInListView()
    End Sub

    Private Sub EditItemInListView()
        txtCompanyName.Focus()
        gbxAddEdit.Text = "Edit Company Information"
        If ListView1.SelectedItems.Count > 0 Then
            showAddEdit(True)
            txtCompanyID.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtCompanyName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtCompanyAd.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtCompanyConNum.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtCompanyContPers.Text = ListView1.SelectedItems(0).SubItems(4).Text
            txtCompanyRemarks.Text = ListView1.SelectedItems(0).SubItems(5).Text
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
