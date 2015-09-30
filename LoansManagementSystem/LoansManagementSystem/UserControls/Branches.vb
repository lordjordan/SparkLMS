Public Class Branches
    Dim itm As ListViewItem
    '### Change the "Data Source" path to point to our own LMS Database
    Dim db As New DBHelper("Data Source=" & My.Settings.ConString & "; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Dim cmd As SQLite.SQLiteCommand
    Private Sub showAddEdit(mode As Boolean)
        gbxAddEdit.Visible = mode
        pnlMain.Enabled = Not mode

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        showUSC(uscMainmenu)
    End Sub

    Private Sub btnAddbranch_Click(sender As Object, e As EventArgs)
        AddItemToListView()
    End Sub

    Private Sub AddItemToListView()
        txtBranchName.Focus()
        showAddEdit(True)
        dr = db.ExecuteReader("select * from tbl_branches")
        Dim maxId As Integer = 0
        gbxAddEdit.Text = "Add New Branch Information"
        showAddEdit(True)

        While dr.Read = True
            If maxId < dr.Item(0) Then maxId = dr.Item(0)
        End While

        txtBranchName.Focus()
        txtBranchID.Text = maxId + 1
        txtBranchName.Text = ""
        txtBranchCon.Text = ""
        txtBranchAd.Text = ""
    End Sub
    Private Sub LoadListview()
        ListView1.Items.Clear()
        showAddEdit(False)
        Try
            dr = db.ExecuteReader("SELECT * from tbl_branches")
            If dr.HasRows Then

                '### You can also use loops for multiple-row result
                Do While dr.Read
                    itm = Me.ListView1.Items.Add(dr.Item("branch_id").ToString)
                    itm.SubItems.Add(dr.Item("branch_name").ToString)
                    itm.SubItems.Add(dr.Item("branch_contact").ToString)
                    itm.SubItems.Add(dr.Item("branch_address").ToString)
                Loop
            Else
                MsgBox("No record of Branches.", vbInformation + vbOKOnly, "No Branch")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If gbxAddEdit.Text = "Add New Branch Information" Then
            'add
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("branch_name", txtBranchName.Text)
                data.Add("branch_contact", txtBranchCon.Text)
                data.Add("branch_address", txtBranchAd.Text)

                rec = db.ExecuteNonQuery("INSERT INTO tbl_branches values(NULL,@branch_name,@branch_address,@branch_contact)", data)

                If Not rec < 1 Then
                    showAddEdit(False)
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        ElseIf gbxAddEdit.Text = "Edit Branch Information" Then
            'update 
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("branch_name", txtBranchName.Text)
                data.Add("branch_contact", txtBranchCon.Text)
                data.Add("branch_address", txtBranchAd.Text)

                rec = db.ExecuteNonQuery("UPDATE tbl_branches SET branch_name=@branch_name, branch_address=@branch_address, branch_contact=@branch_contact WHERE branch_id=" & txtBranchID.Text, data)

                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")

            End Try
        End If




    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        showAddEdit(False)
    End Sub

    Private Sub Branches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListview()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        EditItemInListView()
    End Sub
    Private Sub EditItemInListView()
        txtBranchName.Focus()
        gbxAddEdit.Text = "Edit Branch Information"
        If ListView1.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            showAddEdit(True)
            txtBranchID.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtBranchName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtBranchCon.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtBranchAd.Text = ListView1.SelectedItems(0).SubItems(3).Text
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub
End Class