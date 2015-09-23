<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tmrTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnCollectibles = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSystemUser = New System.Windows.Forms.Button()
        Me.btnAttachments = New System.Windows.Forms.Button()
        Me.btnBranches = New System.Windows.Forms.Button()
        Me.btnLoans = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 39)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Main Menu"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblTime.Location = New System.Drawing.Point(813, 421)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(213, 39)
        Me.lblTime.TabIndex = 24
        Me.lblTime.Text = "5:03:00 P.M."
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(669, 460)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(357, 39)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Monday, 7 September"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrTimeDate
        '
        Me.tmrTimeDate.Enabled = True
        Me.tmrTimeDate.Interval = 1000
        '
        'btnClients
        '
        Me.btnClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.ForeColor = System.Drawing.Color.White
        Me.btnClients.Image = CType(resources.GetObject("btnClients.Image"), System.Drawing.Image)
        Me.btnClients.Location = New System.Drawing.Point(321, 306)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(287, 195)
        Me.btnClients.TabIndex = 14
        Me.btnClients.Text = "Client List"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnClients.UseVisualStyleBackColor = False
        '
        'btnCollectibles
        '
        Me.btnCollectibles.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCollectibles.FlatAppearance.BorderSize = 0
        Me.btnCollectibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollectibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollectibles.ForeColor = System.Drawing.Color.White
        Me.btnCollectibles.Image = CType(resources.GetObject("btnCollectibles.Image"), System.Drawing.Image)
        Me.btnCollectibles.Location = New System.Drawing.Point(28, 306)
        Me.btnCollectibles.Name = "btnCollectibles"
        Me.btnCollectibles.Size = New System.Drawing.Size(287, 195)
        Me.btnCollectibles.TabIndex = 15
        Me.btnCollectibles.Text = "Collectibles"
        Me.btnCollectibles.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCollectibles.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Indigo
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(468, 205)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(141, 95)
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnSystemUser
        '
        Me.btnSystemUser.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnSystemUser.FlatAppearance.BorderSize = 0
        Me.btnSystemUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSystemUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSystemUser.ForeColor = System.Drawing.Color.White
        Me.btnSystemUser.Image = CType(resources.GetObject("btnSystemUser.Image"), System.Drawing.Image)
        Me.btnSystemUser.Location = New System.Drawing.Point(468, 104)
        Me.btnSystemUser.Name = "btnSystemUser"
        Me.btnSystemUser.Size = New System.Drawing.Size(141, 95)
        Me.btnSystemUser.TabIndex = 17
        Me.btnSystemUser.Text = "System User"
        Me.btnSystemUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSystemUser.UseVisualStyleBackColor = False
        '
        'btnAttachments
        '
        Me.btnAttachments.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAttachments.FlatAppearance.BorderSize = 0
        Me.btnAttachments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachments.ForeColor = System.Drawing.Color.White
        Me.btnAttachments.Image = CType(resources.GetObject("btnAttachments.Image"), System.Drawing.Image)
        Me.btnAttachments.Location = New System.Drawing.Point(321, 205)
        Me.btnAttachments.Name = "btnAttachments"
        Me.btnAttachments.Size = New System.Drawing.Size(141, 95)
        Me.btnAttachments.TabIndex = 18
        Me.btnAttachments.Text = "Attachments"
        Me.btnAttachments.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAttachments.UseVisualStyleBackColor = False
        '
        'btnBranches
        '
        Me.btnBranches.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBranches.FlatAppearance.BorderSize = 0
        Me.btnBranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBranches.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBranches.ForeColor = System.Drawing.Color.White
        Me.btnBranches.Image = CType(resources.GetObject("btnBranches.Image"), System.Drawing.Image)
        Me.btnBranches.Location = New System.Drawing.Point(321, 104)
        Me.btnBranches.Name = "btnBranches"
        Me.btnBranches.Size = New System.Drawing.Size(141, 95)
        Me.btnBranches.TabIndex = 19
        Me.btnBranches.Text = "Branches"
        Me.btnBranches.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBranches.UseVisualStyleBackColor = False
        '
        'btnLoans
        '
        Me.btnLoans.BackColor = System.Drawing.Color.DarkViolet
        Me.btnLoans.FlatAppearance.BorderSize = 0
        Me.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoans.ForeColor = System.Drawing.Color.White
        Me.btnLoans.Image = CType(resources.GetObject("btnLoans.Image"), System.Drawing.Image)
        Me.btnLoans.Location = New System.Drawing.Point(28, 105)
        Me.btnLoans.Name = "btnLoans"
        Me.btnLoans.Size = New System.Drawing.Size(287, 195)
        Me.btnLoans.TabIndex = 20
        Me.btnLoans.Text = "Loans Master List"
        Me.btnLoans.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLoans.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1126, 557)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1015, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(615, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 95)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "System User"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.btnCollectibles)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSystemUser)
        Me.Controls.Add(Me.btnAttachments)
        Me.Controls.Add(Me.btnBranches)
        Me.Controls.Add(Me.btnLoans)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Size = New System.Drawing.Size(1075, 557)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClients As System.Windows.Forms.Button
    Friend WithEvents btnCollectibles As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSystemUser As System.Windows.Forms.Button
    Friend WithEvents btnAttachments As System.Windows.Forms.Button
    Friend WithEvents btnBranches As System.Windows.Forms.Button
    Friend WithEvents btnLoans As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tmrTimeDate As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
