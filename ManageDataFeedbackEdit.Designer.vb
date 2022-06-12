<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDataFeedbackEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDataFeedbackEdit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtboxId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtboxCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxDescribe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtboxFullname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtboxCategory)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtboxDescribe)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtboxFullname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 521)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Data Feedback Edit"
        '
        'txtboxId
        '
        Me.txtboxId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxId.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxId.Location = New System.Drawing.Point(67, 81)
        Me.txtboxId.Name = "txtboxId"
        Me.txtboxId.ReadOnly = True
        Me.txtboxId.Size = New System.Drawing.Size(628, 36)
        Me.txtboxId.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(64, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 31)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Id"
        '
        'TxtboxCategory
        '
        Me.TxtboxCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxCategory.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxCategory.Location = New System.Drawing.Point(70, 250)
        Me.TxtboxCategory.Name = "TxtboxCategory"
        Me.TxtboxCategory.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxCategory.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(67, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 31)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Category"
        '
        'txtboxDescribe
        '
        Me.txtboxDescribe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxDescribe.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxDescribe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxDescribe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxDescribe.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxDescribe.Location = New System.Drawing.Point(67, 340)
        Me.txtboxDescribe.Multiline = True
        Me.txtboxDescribe.Name = "txtboxDescribe"
        Me.txtboxDescribe.Size = New System.Drawing.Size(628, 168)
        Me.txtboxDescribe.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(64, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 31)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Describe"
        '
        'TxtboxFullname
        '
        Me.TxtboxFullname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxFullname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxFullname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxFullname.Location = New System.Drawing.Point(67, 158)
        Me.TxtboxFullname.Name = "TxtboxFullname"
        Me.TxtboxFullname.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxFullname.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(64, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Fullname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(31, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 30
        '
        'btnKembali
        '
        Me.btnKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.btnKembali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKembali.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKembali.Location = New System.Drawing.Point(629, 585)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(137, 48)
        Me.btnKembali.TabIndex = 60
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEdit.Location = New System.Drawing.Point(486, 585)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(137, 48)
        Me.BtnEdit.TabIndex = 61
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'ManageDataFeedbackEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 653)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.BtnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageDataFeedbackEdit"
        Me.Text = "Manage Data Feedback Edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtboxId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtboxCategory As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxDescribe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtboxFullname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents BtnEdit As Button
End Class
