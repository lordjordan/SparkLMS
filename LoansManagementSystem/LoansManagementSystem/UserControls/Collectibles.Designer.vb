<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectibles
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnSearchLoan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearchLoan = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Process = New System.Windows.Forms.Button()
        Me.lvCollectibles = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxAdvanceSearch = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbxClientCollectible = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelColl = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.gbxAdvanceSearch.SuspendLayout()
        Me.gbxClientCollectible.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 39)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "List of Collectibles"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(946, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 39)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.btnExport)
        Me.pnlMain.Controls.Add(Me.Label9)
        Me.pnlMain.Controls.Add(Me.LinkLabel1)
        Me.pnlMain.Controls.Add(Me.btnSearchLoan)
        Me.pnlMain.Controls.Add(Me.Label7)
        Me.pnlMain.Controls.Add(Me.txtSearchLoan)
        Me.pnlMain.Controls.Add(Me.btnPrint)
        Me.pnlMain.Controls.Add(Me.Process)
        Me.pnlMain.Controls.Add(Me.lvCollectibles)
        Me.pnlMain.Location = New System.Drawing.Point(16, 94)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1053, 599)
        Me.pnlMain.TabIndex = 48
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(237, 509)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(108, 60)
        Me.btnExport.TabIndex = 83
        Me.btnExport.Text = "Export"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Filtered:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(60, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 15)
        Me.LinkLabel1.TabIndex = 81
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Advance Search"
        '
        'btnSearchLoan
        '
        Me.btnSearchLoan.BackColor = System.Drawing.Color.Gray
        Me.btnSearchLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLoan.ForeColor = System.Drawing.Color.White
        Me.btnSearchLoan.Location = New System.Drawing.Point(279, 10)
        Me.btnSearchLoan.Name = "btnSearchLoan"
        Me.btnSearchLoan.Size = New System.Drawing.Size(61, 24)
        Me.btnSearchLoan.TabIndex = 80
        Me.btnSearchLoan.Text = "Search"
        Me.btnSearchLoan.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Search"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSearchLoan
        '
        Me.txtSearchLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchLoan.Location = New System.Drawing.Point(63, 11)
        Me.txtSearchLoan.Name = "txtSearchLoan"
        Me.txtSearchLoan.Size = New System.Drawing.Size(210, 22)
        Me.txtSearchLoan.TabIndex = 78
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(123, 509)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 60)
        Me.btnPrint.TabIndex = 77
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Process
        '
        Me.Process.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Process.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Process.FlatAppearance.BorderSize = 0
        Me.Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Process.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.ForeColor = System.Drawing.Color.White
        Me.Process.Location = New System.Drawing.Point(9, 509)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(108, 60)
        Me.Process.TabIndex = 76
        Me.Process.Text = "Process"
        Me.Process.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Process.UseVisualStyleBackColor = False
        '
        'lvCollectibles
        '
        Me.lvCollectibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCollectibles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvCollectibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCollectibles.FullRowSelect = True
        Me.lvCollectibles.GridLines = True
        Me.lvCollectibles.Location = New System.Drawing.Point(9, 120)
        Me.lvCollectibles.Name = "lvCollectibles"
        Me.lvCollectibles.Size = New System.Drawing.Size(1031, 383)
        Me.lvCollectibles.TabIndex = 30
        Me.lvCollectibles.UseCompatibleStateImageBehavior = False
        Me.lvCollectibles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Loan ID"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Due Date"
        Me.ColumnHeader4.Width = 93
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Payable Amount"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Collected Amount"
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Penalty Amount"
        Me.ColumnHeader11.Width = 120
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Previous Balance"
        Me.ColumnHeader12.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Principal Amount"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Interest"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Outstanding Balance"
        Me.ColumnHeader7.Width = 130
        '
        'gbxAdvanceSearch
        '
        Me.gbxAdvanceSearch.BackColor = System.Drawing.Color.LightGray
        Me.gbxAdvanceSearch.Controls.Add(Me.Label13)
        Me.gbxAdvanceSearch.Controls.Add(Me.ComboBox3)
        Me.gbxAdvanceSearch.Controls.Add(Me.Label3)
        Me.gbxAdvanceSearch.Controls.Add(Me.Cancel)
        Me.gbxAdvanceSearch.Controls.Add(Me.Label6)
        Me.gbxAdvanceSearch.Controls.Add(Me.cmbArea)
        Me.gbxAdvanceSearch.Controls.Add(Me.btnCancel)
        Me.gbxAdvanceSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAdvanceSearch.Location = New System.Drawing.Point(430, 56)
        Me.gbxAdvanceSearch.Name = "gbxAdvanceSearch"
        Me.gbxAdvanceSearch.Size = New System.Drawing.Size(277, 243)
        Me.gbxAdvanceSearch.TabIndex = 72
        Me.gbxAdvanceSearch.TabStop = False
        Me.gbxAdvanceSearch.Text = "Advanced Search"
        Me.gbxAdvanceSearch.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 16)
        Me.Label13.TabIndex = 130
        Me.Label13.Text = "Company"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(30, 86)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(176, 28)
        Me.ComboBox3.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(27, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Filter by:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(144, 177)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(108, 60)
        Me.Cancel.TabIndex = 69
        Me.Cancel.Text = "Cancel"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Branch"
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(30, 142)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(176, 28)
        Me.cmbArea.TabIndex = 66
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(30, 177)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 60)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Text = "Search"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'gbxClientCollectible
        '
        Me.gbxClientCollectible.BackColor = System.Drawing.Color.LightGray
        Me.gbxClientCollectible.Controls.Add(Me.ListView2)
        Me.gbxClientCollectible.Controls.Add(Me.Label12)
        Me.gbxClientCollectible.Controls.Add(Me.btnManage)
        Me.gbxClientCollectible.Controls.Add(Me.Label11)
        Me.gbxClientCollectible.Controls.Add(Me.txtAmount)
        Me.gbxClientCollectible.Controls.Add(Me.Label10)
        Me.gbxClientCollectible.Controls.Add(Me.Label8)
        Me.gbxClientCollectible.Controls.Add(Me.btnCancelColl)
        Me.gbxClientCollectible.Controls.Add(Me.btnOk)
        Me.gbxClientCollectible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxClientCollectible.Location = New System.Drawing.Point(362, 56)
        Me.gbxClientCollectible.Name = "gbxClientCollectible"
        Me.gbxClientCollectible.Size = New System.Drawing.Size(446, 448)
        Me.gbxClientCollectible.TabIndex = 73
        Me.gbxClientCollectible.TabStop = False
        Me.gbxClientCollectible.Text = "Client Payment"
        Me.gbxClientCollectible.Visible = False
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(31, 196)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(379, 151)
        Me.ListView2.TabIndex = 77
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Due date"
        Me.ColumnHeader8.Width = 132
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Penalty Amount"
        Me.ColumnHeader9.Width = 241
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(138, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 13)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "(Please check penalties below)"
        '
        'btnManage
        '
        Me.btnManage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnManage.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.ForeColor = System.Drawing.Color.White
        Me.btnManage.Location = New System.Drawing.Point(31, 353)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(108, 60)
        Me.btnManage.TabIndex = 75
        Me.btnManage.Text = "Manage Penalties"
        Me.btnManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManage.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Collected Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(31, 97)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(378, 44)
        Me.txtAmount.TabIndex = 72
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Penalties"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Payable amount:"
        '
        'btnCancelColl
        '
        Me.btnCancelColl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelColl.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelColl.FlatAppearance.BorderSize = 0
        Me.btnCancelColl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelColl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelColl.ForeColor = System.Drawing.Color.White
        Me.btnCancelColl.Location = New System.Drawing.Point(259, 353)
        Me.btnCancelColl.Name = "btnCancelColl"
        Me.btnCancelColl.Size = New System.Drawing.Size(108, 60)
        Me.btnCancelColl.TabIndex = 69
        Me.btnCancelColl.Text = "Cancel"
        Me.btnCancelColl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelColl.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(145, 353)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 60)
        Me.btnOk.TabIndex = 58
        Me.btnOk.Text = "OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'frmCollectibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.gbxClientCollectible)
        Me.Controls.Add(Me.gbxAdvanceSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmCollectibles"
        Me.Size = New System.Drawing.Size(1079, 706)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.gbxAdvanceSearch.ResumeLayout(False)
        Me.gbxAdvanceSearch.PerformLayout()
        Me.gbxClientCollectible.ResumeLayout(False)
        Me.gbxClientCollectible.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lvCollectibles As System.Windows.Forms.ListView
    Friend WithEvents gbxAdvanceSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxClientCollectible As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelColl As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnManage As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSearchLoan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSearchLoan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnExport As System.Windows.Forms.Button

End Class
