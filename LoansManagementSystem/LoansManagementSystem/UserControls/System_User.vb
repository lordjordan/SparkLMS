Imports System.Data.SQLite
Public Class System_User
    Dim itm As ListViewItem
    '### Change the "Data Source" path to point to our own LMS Database
    Dim db As New DBHelper("Data Source=C:\LMS.s3db; Version=3;")
    Dim dr As SQLite.SQLiteDataReader
    Dim cmd As SQLite.SQLiteCommand

    Private Sub showAddEdit(mode As Boolean)
        gbxAddEdit.Visible = mode
        pnlMain.Enabled = Not mode
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        showUSC(uscMainmenu)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        AddItemToListView()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditItemInListView()
    End Sub

    Private Sub AddItemToListView()

        btnSave.Enabled = True
        dr = db.ExecuteReader("select * from tbl_users")
        Dim maxId As Integer = 0
        gbxAddEdit.Text = "Add User Information"
        showAddEdit(True)

        While dr.Read = True
            If maxId < dr.Item(0) Then maxId = dr.Item(0)
        End While

        txtusername.Focus()
        txtUid.Text = maxId + 1
        txtusername.Text = ""
        txtPassword.Text = ""
        cmbUtype.Text = ""
    End Sub

    Private Sub EditItemInListView()

        gbxAddEdit.Text = "Edit User Information"
        If ListView1.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            showAddEdit(True)
            txtUid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtusername.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtPassword.Text = ListView1.SelectedItems(0).SubItems(2).Text
            cmbUtype.Text = ListView1.SelectedItems(0).SubItems(3).Text
        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showAddEdit(False)
    End Sub

    Private Sub LoadListview()
        ListView1.Items.Clear()
        Try
            dr = db.ExecuteReader("SELECT * from tbl_users")
            If dr.HasRows Then

                '### You can also use loops for multiple-row result
                Do While dr.Read
                    itm = Me.ListView1.Items.Add(dr.Item("user_id").ToString)
                    itm.SubItems.Add(dr.Item("user_name").ToString)
                    itm.SubItems.Add(dr.Item("user_password").ToString)
                    itm.SubItems.Add(dr.Item("user_type").ToString)
                Loop
            Else
                MsgBox("No record of System Users", vbInformation + vbOKOnly, "No User")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub System_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAddEdit(False)
        LoadListview()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gbxAddEdit.Text = "Add User Information" Then
            'validation empty fields
            'If txtusername.Text = "" Or txtPassword.Text = "" Then
            '    MsgBox("Please provide username and password.", MsgBoxStyle.Exclamation, "Fill in the fields.")
            '    Exit Sub
            'End If

            'add
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("user_name", txtusername.Text)
                data.Add("user_password", txtPassword.Text)
                data.Add("user_type", cmbUtype.Text)

                rec = db.ExecuteNonQuery("INSERT INTO tbl_users values(NULL,@user_name,@user_password,@user_type)", data)

                If Not rec < 1 Then
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    showAddEdit(False)
                    LoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        ElseIf gbxAddEdit.Text = "Edit User Information" Then
            'update
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                data.Add("user_name", txtusername.Text)
                data.Add("user_password", txtPassword.Text)
                data.Add("user_type", cmbUtype.Text)

                rec = db.ExecuteNonQuery("UPDATE tbl_users SET user_name=@user_name, user_password=@user_password, user_type=@user_type WHERE user_id=" & txtUid.Text, data)

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
    Private con As New SQLiteConnection
   

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs)
        EditItemInListView()
        showAddEdit(True)
    End Sub

End Class
