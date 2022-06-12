Public Class DataChat

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Home2.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageData_Click(sender As Object, e As EventArgs) Handles btnManageData.Click
        ManageDataChat.Show()
    End Sub
End Class