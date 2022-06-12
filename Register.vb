Public Class Register
    Private Sub btnLinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnLinkLogin.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If txtboxEmail.Text = "" Or txtboxFullname.Text = "" Or txtboxUsername.Text = "" Or TxtboxPassword.Text = "" Then
            MsgBox("Field Tidak boleh kosong")
        Else
            Try
                func_register(txtboxFullname.Text, txtboxEmail.Text, txtboxUsername.Text, TxtboxPassword.Text)
                MsgBox("Register Berhasil!")
                Me.Dispose()
                Form1.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error! : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles btnShowPassword.CheckedChanged
        If btnShowPassword.CheckState = CheckState.Checked Then
            TxtboxPassword.UseSystemPasswordChar = False
        Else
            TxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class