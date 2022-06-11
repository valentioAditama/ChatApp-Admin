<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataChat))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnManageData = New System.Windows.Forms.Button()
        Me.BtnVerifyEmail = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(987, 500)
        Me.DataGridView1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(47, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 31)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Logout"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.chatApp_admin.My.Resources.Resources.shutdown
        Me.PictureBox2.Location = New System.Drawing.Point(166, 463)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(68, 597)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "2020 ChatApp-Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(54, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Welcome, Admin!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.chatApp_admin.My.Resources.Resources.software_engineer
        Me.PictureBox1.Location = New System.Drawing.Point(72, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 627)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile Admin"
        '
        'btnManageData
        '
        Me.btnManageData.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.btnManageData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageData.BackColor = System.Drawing.Color.Gray
        Me.btnManageData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnManageData.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManageData.Location = New System.Drawing.Point(848, 551)
        Me.btnManageData.Name = "btnManageData"
        Me.btnManageData.Size = New System.Drawing.Size(137, 48)
        Me.btnManageData.TabIndex = 48
        Me.btnManageData.Text = "Manage Data"
        Me.btnManageData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnManageData.UseVisualStyleBackColor = False
        '
        'BtnVerifyEmail
        '
        Me.BtnVerifyEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnVerifyEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVerifyEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVerifyEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVerifyEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVerifyEmail.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerifyEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVerifyEmail.Location = New System.Drawing.Point(22, 551)
        Me.BtnVerifyEmail.Name = "BtnVerifyEmail"
        Me.BtnVerifyEmail.Size = New System.Drawing.Size(137, 48)
        Me.BtnVerifyEmail.TabIndex = 47
        Me.BtnVerifyEmail.Text = "Kembali"
        Me.BtnVerifyEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnVerifyEmail.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(999, 527)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Chat"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(1004, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 633)
        Me.Panel1.TabIndex = 45
        '
        'DataChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.btnManageData)
        Me.Controls.Add(Me.BtnVerifyEmail)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataChat"
        Me.Text = "Data Chat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnManageData As Button
    Friend WithEvents BtnVerifyEmail As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
