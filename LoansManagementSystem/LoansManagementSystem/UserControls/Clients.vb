Public Class Clients

    Dim itm As ListViewItem
    '### Change the "Data Source" path to point to our own LMS Database
    Dim db As New DBHelper("Data Source=" & My.Settings.ConString & "; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Private Sub showAddEdit(mode As Boolean)
        gbxAddEdit.Visible = mode
        pnlMain.Enabled = Not mode

   

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        txt_FName.Text = ""
        txt_LName.Text = ""
        txt_MName.Text = ""
        txt_address.Text = ""
        txt_Contact.Text = ""
        cbxBranch.Text = ""
        cbxEmpType.Text = ""
        txt_Credit.Text = ""
        txt_FName.Focus()
        gbxAddEdit.Text = "Add new client"
        showAddEdit(True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If gbxAddEdit.Text = "Add new client" Then
            'validation empty fields
            If txt_FName.Text = "" Or txt_MName.Text = "" Or txt_LName.Text = "" Or txt_address.Text = "" _
                Or Contact_no.Text = "" Or cbxEmpType.Text = "" Or txt_Credit.Text = "" Or cbxBranch.Text = "" _
                 Then
                MsgBox("Some fields are empty.", MsgBoxStyle.Exclamation, "Please fill up")
                Exit Sub
            End If

            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            Try

                data.Add("first_name", txt_FName.Text)
                data.Add("middle_name", txt_MName.Text)
                data.Add("last_name", txt_LName.Text)
                data.Add("birth_date", Format(DateTimePicker1.Value, "MM/dd/yyyy"))
                data.Add("address", txt_address.Text)
                data.Add("contact_number", txt_Contact.Text)
                data.Add("employee_type", cbxEmpType.Text)
                data.Add("credit_limit", txt_Credit.Text)
                data.Add("branch_id", cbxBranch.Text)
                data.Add("date_hired", Format(DateTimePicker2.Value, "MM/dd/yyyy"))

                rec = db.ExecuteNonQuery("insert into tbl_clients values(NULL,@first_name,@middle_name,@last_name, @birth_date,@address,@branch_id,@contact_number,@employee_type,NULL,@date_hired,NULL,@credit_limit)", data)

                If Not rec < 1 Then
                    MsgBox("Record saved!", MsgBoxStyle.Information)
                    showAddEdit(False)
                    LoadListView()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf gbxAddEdit.Text = "Edit client" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("first_name", txt_FName.Text)
                data.Add("middle_name", txt_MName.Text)
                data.Add("last_name", txt_LName.Text)
                data.Add("birth_date", Format(DateTimePicker1.Value, "MM/dd/yyyy"))
                data.Add("address", txt_address.Text)
                data.Add("contact_number", txt_Contact.Text)
                data.Add("employee_type", cbxEmpType.Text)
                data.Add("credit_limit", txt_Credit.Text)
                data.Add("branch_id", cbxBranch.Text)
                data.Add("date_hired", Format(DateTimePicker2.Value, "MM/dd/yyyy"))

                rec = db.ExecuteNonQuery("UPDATE tbl_clients SET first_name=@first_name, middle_name=@middle_name, last_name=@last_name, birth_date=@birth_date," & _
                                         "address=@address, contact_number=@contact_number, employee_type=@employee_type, credit_limit=@credit_limit, branch_id=@branch_id, date_hired=@date_hired WHERE client_id=" & txt_client.Text, data)

                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListView()

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")

            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If ListView1.SelectedItems.Count > 0 Then
            txt_client.Text = ListView1.FocusedItem.Text
            Try
                dr = db.ExecuteReader("SELECT * FROM tbl_clients WHERE client_id=" & ListView1.FocusedItem.Text)

                If dr.HasRows Then
                    txt_FName.Text = dr.Item("first_name").ToString
                    txt_LName.Text = dr.Item("last_name").ToString
                    txt_MName.Text = dr.Item("middle_name").ToString
                    txt_address.Text = dr.Item("address").ToString
                    txt_Contact.Text = dr.Item("contact_number").ToString
                    DateTimePicker1.Value = CDate(dr.Item("birth_date").ToString)
                    cbxBranch.Text = dr.Item("branch_id").ToString
                    cbxEmpType.Text = dr.Item("employee_type").ToString
                    DateTimePicker2.Value = CDate(dr.Item("date_hired").ToString)
                    txt_Credit.Text = dr.Item("credit_limit").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MessageBox.Show("Fetching record..." & ex.Message, "Records")
            End Try

        Else
            MsgBox("Please select a client", vbExclamation + vbOKOnly, "No client Selected")
            Exit Sub
        End If

       

        'latag sa groupbox
        gbxAddEdit.Text = "Edit client"
        showAddEdit(True)

    End Sub
    Private Sub gbxAddEdit_Enter(sender As Object, e As EventArgs) Handles gbxAddEdit.Enter

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        showAddEdit(False)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub


    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListView()

        'dr = db.ExecuteReader("Select * from tbl_branches")
        'Dim table As New DataTable()
        'Dim ds As New DataSet

        'If dr.HasRows Then

        '    '### You can also use loops for multiple-row result
        '    Do While dr.Read


        '    Loop
        'End If

        ''dr.Fill(table)
        'cbxBranch.DataSource = New BindingSource(table)
        'cbxBranch.DisplayMember = "branch_name"

    End Sub

    Private Sub LoadListView()
        ListView1.Items.Clear()
        Try
            '### Change the "Data Source" path to point to our own LMS Database

            dr = db.ExecuteReader("select * from tbl_clients")

            If dr.HasRows Then

                '### You can also use loops for multiple-row result
                Do While dr.Read
                    itm = Me.ListView1.Items.Add(dr.Item("client_id").ToString)
                    itm.SubItems.Add(dr.Item("last_name").ToString & " " & dr.Item("first_name").ToString & " " & dr.Item("middle_name").ToString)
                    'itm.SubItems.Add(dr.Item("middle_name").ToString)
                    ' itm.SubItems.Add(dr.Item("last_name").ToString)
                    itm.SubItems.Add(dr.Item("address").ToString)
                    itm.SubItems.Add(dr.Item("contact_number").ToString)



                Loop
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
 

    Private Sub gbx_req_Enter(sender As Object, e As EventArgs)

    End Sub
   

    Private Sub Btn_add_req_Click(sender As Object, e As EventArgs) Handles Btn_add_req.Click
        frmClientRequirement.ShowDialog()
    End Sub

  
    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
