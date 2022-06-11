<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.BtnVerifyEmail = New System.Windows.Forms.Button()
        Me.btnLinklogin = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnVerifyEmail.Location = New System.Drawing.Point(932, 385)
        Me.BtnVerifyEmail.Name = "BtnVerifyEmail"
        Me.BtnVerifyEmail.Size = New System.Drawing.Size(297, 59)
        Me.BtnVerifyEmail.TabIndex = 41
        Me.BtnVerifyEmail.Text = "Verify Email"
        Me.BtnVerifyEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnVerifyEmail.UseVisualStyleBackColor = False
        '
        'btnLinklogin
        '
        Me.btnLinklogin.AutoSize = True
        Me.btnLinklogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinklogin.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.btnLinklogin.Location = New System.Drawing.Point(1096, 352)
        Me.btnLinklogin.Name = "btnLinklogin"
        Me.btnLinklogin.Size = New System.Drawing.Size(145, 21)
        Me.btnLinklogin.TabIndex = 40
        Me.btnLinklogin.TabStop = True
        Me.btnLinklogin.Text = "Sudah punya akun?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(925, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 40)
        Me.Label3.TabIndex = 38
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
        Me.txtboxEmail.Location = New System.Drawing.Point(932, 298)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(297, 36)
        Me.txtboxEmail.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 24.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(923, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 49)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Forgot Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.chatApp_admin.My.Resources.Resources._20944201
        Me.PictureBox1.Location = New System.Drawing.Point(21, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 629)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.BtnVerifyEmail)
        Me.Controls.Add(Me.btnLinklogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPassword"
        Me.Text = "Forgot Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVerifyEmail As Button
    Friend WithEvents btnLinklogin As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
