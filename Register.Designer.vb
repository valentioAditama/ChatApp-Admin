<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.btnLinkLogin = New System.Windows.Forms.LinkLabel()
        Me.btnShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxFullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtboxPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegister.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegister.Location = New System.Drawing.Point(936, 526)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(297, 59)
        Me.BtnRegister.TabIndex = 28
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'btnLinkLogin
        '
        Me.btnLinkLogin.AutoSize = True
        Me.btnLinkLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinkLogin.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.btnLinkLogin.Location = New System.Drawing.Point(1100, 493)
        Me.btnLinkLogin.Name = "btnLinkLogin"
        Me.btnLinkLogin.Size = New System.Drawing.Size(145, 21)
        Me.btnLinkLogin.TabIndex = 27
        Me.btnLinkLogin.TabStop = True
        Me.btnLinkLogin.Text = "Sudah punya akun?"
        '
        'btnShowPassword
        '
        Me.btnShowPassword.AutoSize = True
        Me.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnShowPassword.Location = New System.Drawing.Point(938, 461)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.btnShowPassword.TabIndex = 26
        Me.btnShowPassword.Text = "Show Password"
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(929, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 40)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Email"
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxEmail.Location = New System.Drawing.Point(936, 227)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(297, 36)
        Me.txtboxEmail.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 24.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(990, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 49)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(929, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 40)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fullname"
        '
        'txtboxFullname
        '
        Me.txtboxFullname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxFullname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxFullname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxFullname.Location = New System.Drawing.Point(936, 140)
        Me.txtboxFullname.Name = "txtboxFullname"
        Me.txtboxFullname.Size = New System.Drawing.Size(297, 36)
        Me.txtboxFullname.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(929, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 40)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Username"
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxUsername.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxUsername.Location = New System.Drawing.Point(936, 319)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(297, 36)
        Me.txtboxUsername.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(929, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 40)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Password"
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
        Me.TxtboxPassword.Location = New System.Drawing.Point(936, 419)
        Me.TxtboxPassword.Name = "TxtboxPassword"
        Me.TxtboxPassword.Size = New System.Drawing.Size(297, 36)
        Me.TxtboxPassword.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.chatApp_admin.My.Resources.Resources.Checklist
        Me.PictureBox1.Location = New System.Drawing.Point(12, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 629)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtboxPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxUsername)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.btnLinkLogin)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxFullname)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegister As Button
    Friend WithEvents btnLinkLogin As LinkLabel
    Friend WithEvents btnShowPassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxFullname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtboxPassword As TextBox
End Class
