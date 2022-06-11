<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtxboxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnForgotpassword = New System.Windows.Forms.LinkLabel()
        Me.BtnlinkRegister = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtxboxUsername
        '
        Me.TxtxboxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtxboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxUsername.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxUsername.Location = New System.Drawing.Point(924, 230)
        Me.TxtxboxUsername.Name = "TxtxboxUsername"
        Me.TxtxboxUsername.Size = New System.Drawing.Size(297, 36)
        Me.TxtxboxUsername.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(917, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 24.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(996, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 49)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Login "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(917, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 40)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
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
        Me.TxtboxPassword.Location = New System.Drawing.Point(924, 342)
        Me.TxtboxPassword.Name = "TxtboxPassword"
        Me.TxtboxPassword.Size = New System.Drawing.Size(297, 36)
        Me.TxtboxPassword.TabIndex = 11
        '
        'txtShowPassword
        '
        Me.txtShowPassword.AutoSize = True
        Me.txtShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtShowPassword.Location = New System.Drawing.Point(924, 384)
        Me.txtShowPassword.Name = "txtShowPassword"
        Me.txtShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.txtShowPassword.TabIndex = 16
        Me.txtShowPassword.Text = "Show Password"
        Me.txtShowPassword.UseVisualStyleBackColor = True
        '
        'btnForgotpassword
        '
        Me.btnForgotpassword.AutoSize = True
        Me.btnForgotpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotpassword.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.btnForgotpassword.Location = New System.Drawing.Point(1089, 417)
        Me.btnForgotpassword.Name = "btnForgotpassword"
        Me.btnForgotpassword.Size = New System.Drawing.Size(132, 21)
        Me.btnForgotpassword.TabIndex = 17
        Me.btnForgotpassword.TabStop = True
        Me.btnForgotpassword.Text = "Forgot Password"
        '
        'BtnlinkRegister
        '
        Me.BtnlinkRegister.AutoSize = True
        Me.BtnlinkRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnlinkRegister.Font = New System.Drawing.Font("Candara Light", 12.0!)
        Me.BtnlinkRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnlinkRegister.Location = New System.Drawing.Point(1132, 585)
        Me.BtnlinkRegister.Name = "BtnlinkRegister"
        Me.BtnlinkRegister.Size = New System.Drawing.Size(170, 24)
        Me.BtnlinkRegister.TabIndex = 18
        Me.BtnlinkRegister.Text = "Belum punya akun?"
        '
        'BtnLogin
        '
        Me.BtnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.Location = New System.Drawing.Point(924, 452)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(297, 59)
        Me.BtnLogin.TabIndex = 19
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.chatApp_admin.My.Resources.Resources._5127314
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 629)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnlinkRegister)
        Me.Controls.Add(Me.btnForgotpassword)
        Me.Controls.Add(Me.txtShowPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtboxPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtxboxUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Login "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtxboxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtboxPassword As TextBox
    Friend WithEvents txtShowPassword As CheckBox
    Friend WithEvents btnForgotpassword As LinkLabel
    Friend WithEvents BtnlinkRegister As Label
    Friend WithEvents BtnLogin As Button
End Class
