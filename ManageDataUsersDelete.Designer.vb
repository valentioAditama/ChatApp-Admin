<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDataUsersDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDataUsersDelete))
        Me.TxtboxFullname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.TxtboxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtboxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtboxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.txtboxId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TxtboxFullname.Location = New System.Drawing.Point(64, 176)
        Me.TxtboxFullname.Name = "TxtboxFullname"
        Me.TxtboxFullname.ReadOnly = True
        Me.TxtboxFullname.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxFullname.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShowPassword)
        Me.GroupBox1.Controls.Add(Me.TxtboxPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtboxUsername)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtboxEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtboxFullname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 567)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Data Users Delete"
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Location = New System.Drawing.Point(64, 514)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.ShowPassword.TabIndex = 41
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'TxtboxPassword
        '
        Me.TxtboxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxPassword.Location = New System.Drawing.Point(64, 472)
        Me.TxtboxPassword.Name = "TxtboxPassword"
        Me.TxtboxPassword.ReadOnly = True
        Me.TxtboxPassword.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxPassword.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(61, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 31)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Password"
        '
        'TxtboxUsername
        '
        Me.TxtboxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxUsername.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxUsername.Location = New System.Drawing.Point(64, 371)
        Me.TxtboxUsername.Name = "TxtboxUsername"
        Me.TxtboxUsername.ReadOnly = True
        Me.TxtboxUsername.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxUsername.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(61, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 31)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Username"
        '
        'TxtboxEmail
        '
        Me.TxtboxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxEmail.Location = New System.Drawing.Point(64, 270)
        Me.TxtboxEmail.Name = "TxtboxEmail"
        Me.TxtboxEmail.ReadOnly = True
        Me.TxtboxEmail.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxEmail.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(61, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 31)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(61, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Fullname"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnSimpan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSimpan.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSimpan.Location = New System.Drawing.Point(474, 585)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(137, 48)
        Me.BtnSimpan.TabIndex = 51
        Me.BtnSimpan.Text = "Delete"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnKembali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnKembali.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKembali.Location = New System.Drawing.Point(629, 585)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(137, 48)
        Me.BtnKembali.TabIndex = 50
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnKembali.UseVisualStyleBackColor = False
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
        Me.txtboxId.Location = New System.Drawing.Point(64, 98)
        Me.txtboxId.Name = "txtboxId"
        Me.txtboxId.ReadOnly = True
        Me.txtboxId.Size = New System.Drawing.Size(628, 36)
        Me.txtboxId.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(61, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 31)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Id"
        '
        'ManageDataUsersDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 653)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnKembali)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageDataUsersDelete"
        Me.Text = "Manage Data Users Delete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtboxFullname As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents TxtboxPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtboxUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtboxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents txtboxId As TextBox
    Friend WithEvents Label1 As Label
End Class
