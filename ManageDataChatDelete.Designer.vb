<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDataChatDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDataChatDelete))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtboxMessage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtboxUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtboxRoom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtboxId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtboxMessage)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtboxUsername)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtboxRoom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtboxId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 542)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Data Chat Hapus"
        '
        'TxtboxMessage
        '
        Me.TxtboxMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxMessage.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxMessage.Location = New System.Drawing.Point(67, 373)
        Me.TxtboxMessage.Multiline = True
        Me.TxtboxMessage.Name = "TxtboxMessage"
        Me.TxtboxMessage.ReadOnly = True
        Me.TxtboxMessage.Size = New System.Drawing.Size(628, 150)
        Me.TxtboxMessage.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(64, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 31)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Message"
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
        Me.TxtboxUsername.Location = New System.Drawing.Point(67, 280)
        Me.TxtboxUsername.Name = "TxtboxUsername"
        Me.TxtboxUsername.ReadOnly = True
        Me.TxtboxUsername.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxUsername.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(64, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 31)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Username"
        '
        'TxtboxRoom
        '
        Me.TxtboxRoom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxRoom.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxRoom.Location = New System.Drawing.Point(67, 192)
        Me.TxtboxRoom.Name = "TxtboxRoom"
        Me.TxtboxRoom.ReadOnly = True
        Me.TxtboxRoom.Size = New System.Drawing.Size(628, 36)
        Me.TxtboxRoom.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(64, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Room"
        '
        'TxtboxId
        '
        Me.TxtboxId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtboxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxId.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxId.Location = New System.Drawing.Point(67, 97)
        Me.TxtboxId.Name = "TxtboxId"
        Me.TxtboxId.ReadOnly = True
        Me.TxtboxId.Size = New System.Drawing.Size(146, 36)
        Me.TxtboxId.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(64, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 31)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Id"
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
        'BtnHapus
        '
        Me.BtnHapus.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnHapus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHapus.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHapus.Location = New System.Drawing.Point(486, 578)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(137, 48)
        Me.BtnHapus.TabIndex = 62
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnHapus.UseVisualStyleBackColor = False
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
        Me.btnKembali.Location = New System.Drawing.Point(629, 578)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(137, 48)
        Me.btnKembali.TabIndex = 61
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'ManageDataChatDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 653)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.btnKembali)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageDataChatDelete"
        Me.Text = "Manage Data Chat Hapus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtboxMessage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtboxUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtboxRoom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtboxId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents btnKembali As Button
End Class
