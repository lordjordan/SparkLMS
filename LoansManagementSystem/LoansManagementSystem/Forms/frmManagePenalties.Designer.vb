<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePenalties
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.btnEditPenalties = New System.Windows.Forms.Button()
        Me.btnRemovePenalties = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCancelPenalties = New System.Windows.Forms.Button()
        Me.btnAddPenalties = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveExit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSaveExit.FlatAppearance.BorderSize = 0
        Me.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveExit.ForeColor = System.Drawing.Color.White
        Me.btnSaveExit.Location = New System.Drawing.Point(383, 297)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(108, 60)
        Me.btnSaveExit.TabIndex = 86
        Me.btnSaveExit.Text = "Save / Exit"
        Me.btnSaveExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveExit.UseVisualStyleBackColor = False
        '
        'btnEditPenalties
        '
        Me.btnEditPenalties.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditPenalties.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEditPenalties.FlatAppearance.BorderSize = 0
        Me.btnEditPenalties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPenalties.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPenalties.ForeColor = System.Drawing.Color.White
        Me.btnEditPenalties.Location = New System.Drawing.Point(155, 297)
        Me.btnEditPenalties.Name = "btnEditPenalties"
        Me.btnEditPenalties.Size = New System.Drawing.Size(108, 60)
        Me.btnEditPenalties.TabIndex = 85
        Me.btnEditPenalties.Text = "Edit"
        Me.btnEditPenalties.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditPenalties.UseVisualStyleBackColor = False
        '
        'btnRemovePenalties
        '
        Me.btnRemovePenalties.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemovePenalties.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRemovePenalties.FlatAppearance.BorderSize = 0
        Me.btnRemovePenalties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePenalties.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePenalties.ForeColor = System.Drawing.Color.White
        Me.btnRemovePenalties.Location = New System.Drawing.Point(41, 297)
        Me.btnRemovePenalties.Name = "btnRemovePenalties"
        Me.btnRemovePenalties.Size = New System.Drawing.Size(108, 60)
        Me.btnRemovePenalties.TabIndex = 84
        Me.btnRemovePenalties.Text = "Remove"
        Me.btnRemovePenalties.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemovePenalties.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader13})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(128, 25)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(415, 252)
        Me.ListView2.TabIndex = 83
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = ""
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date"
        Me.ColumnHeader9.Width = 180
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Amount"
        Me.ColumnHeader13.Width = 170
        '
        'btnCancelPenalties
        '
        Me.btnCancelPenalties.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelPenalties.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelPenalties.FlatAppearance.BorderSize = 0
        Me.btnCancelPenalties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPenalties.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPenalties.ForeColor = System.Drawing.Color.White
        Me.btnCancelPenalties.Location = New System.Drawing.Point(497, 297)
        Me.btnCancelPenalties.Name = "btnCancelPenalties"
        Me.btnCancelPenalties.Size = New System.Drawing.Size(108, 60)
        Me.btnCancelPenalties.TabIndex = 82
        Me.btnCancelPenalties.Text = "Cancel"
        Me.btnCancelPenalties.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPenalties.UseVisualStyleBackColor = False
        '
        'btnAddPenalties
        '
        Me.btnAddPenalties.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddPenalties.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddPenalties.FlatAppearance.BorderSize = 0
        Me.btnAddPenalties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPenalties.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPenalties.ForeColor = System.Drawing.Color.White
        Me.btnAddPenalties.Location = New System.Drawing.Point(269, 297)
        Me.btnAddPenalties.Name = "btnAddPenalties"
        Me.btnAddPenalties.Size = New System.Drawing.Size(108, 60)
        Me.btnAddPenalties.TabIndex = 81
        Me.btnAddPenalties.Text = "Add"
        Me.btnAddPenalties.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddPenalties.UseVisualStyleBackColor = False
        '
        'frmManagePenalties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 402)
        Me.Controls.Add(Me.btnSaveExit)
        Me.Controls.Add(Me.btnEditPenalties)
        Me.Controls.Add(Me.btnRemovePenalties)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.btnCancelPenalties)
        Me.Controls.Add(Me.btnAddPenalties)
        Me.Name = "frmManagePenalties"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Penalties"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveExit As System.Windows.Forms.Button
    Friend WithEvents btnEditPenalties As System.Windows.Forms.Button
    Friend WithEvents btnRemovePenalties As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancelPenalties As System.Windows.Forms.Button
    Friend WithEvents btnAddPenalties As System.Windows.Forms.Button
End Class
