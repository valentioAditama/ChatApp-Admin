Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub BtnlinkRegister_Click(sender As Object, e As EventArgs) Handles BtnlinkRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnForgotpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnForgotpassword.LinkClicked
        ForgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles txtShowPassword.CheckedChanged
        If txtShowPassword.CheckState = CheckState.Checked Then
            TxtboxPassword.UseSystemPasswordChar = False
        Else
            TxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtxboxUsername.Text = "" Or TxtboxPassword.Text = "" Then
            MsgBox("Field Tidak boleh kosong!")
        Else
            Try
                Dim fullname, username, email, password As String
                username = TxtxboxUsername.Text
                password = TxtboxPassword.Text
                Dim dt As DataTable = func_login(username, password)
                If dt.Rows.Count > 0 Then
                    MsgBox("Berhasil Login", vbInformation)
                    MsgBox("Selamat Datang admin!", vbInformation)
                    Home2.Show()
                    Me.Hide()
                    'Home2.Label1.Text = "Welcome, " + username + "!"
                    Home2.Label4.Text = "Welcome Back, " + username + "!"

                    Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                    connection.Open()

                    Dim cmd As New MySqlCommand("SELECT( SELECT COUNT(*) FROM users ) AS Total_users, (SELECT COUNT(*) FROM feedback ) AS Total_feedback, (SELECT COUNT(*) FROM chat ) AS Total_chat", connection)

                    Dim myreader As MySqlDataReader

                    myreader = cmd.ExecuteReader()

                    myreader.Read()

                    Home2.lblShowTotalUsers.Text = myreader("Total_users")
                    Home2.lblShowFeedback.Text = myreader("Total_feedback")
                    Home2.LblShowTotalChat.Text = myreader("Total_chat")

                Else
                    MsgBox("Username atau Password Salah!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox("error! ; " & ex.Message)
            End Try
        End If
    End Sub
End Class
