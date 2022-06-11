Public Class Form1
    Private Sub BtnlinkRegister_Click(sender As Object, e As EventArgs) Handles BtnlinkRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnForgotpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnForgotpassword.LinkClicked
        ForgotPassword.Show()
        Me.Hide()
    End Sub
End Class
