Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Parent = PictureBox1
        lblTime.Parent = PictureBox1
        lblDate.Parent = PictureBox1
    End Sub

    Private Sub tmrTimeDate_Tick(sender As Object, e As EventArgs) Handles tmrTimeDate.Tick
        tmrTimeDate.Enabled = False
        'lblDate.Text = Now.DayOfWeek.ToString & ", " & Now.Day.ToString & " " & Now.mo.ToString
        lblTime.Text = Format(Now, "long time") 'Now.Hour.ToString & ":" & Now.Minute.ToString
        lblDate.Text = Format(Now, "dddd, d MMMM")

        tmrTimeDate.Enabled = True
    End Sub


    Private Sub btnCollectibles_Click(sender As Object, e As EventArgs) Handles btnCollectibles.Click
        showUSC(uscCollectibles)

    End Sub

    Private Sub btnSystemUser_Click(sender As Object, e As EventArgs) Handles btnSystemUser.Click, Button1.Click
        showUSC(uscSystemUser)
    End Sub

    Private Sub btnLoans_Click(sender As Object, e As EventArgs) Handles btnLoans.Click
        showUSC(uscLoans)
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        showUSC(uscClients)
    End Sub

    Private Sub btnBranches_Click(sender As Object, e As EventArgs) Handles btnBranches.Click
        showUSC(uscBranches)
    End Sub

    Private Sub btnAttachments_Click(sender As Object, e As EventArgs) Handles btnAttachments.Click
        showUSC(uscAttachments)
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Application.Exit()
    End Sub

End Class
