Imports MySql.Data.MySqlClient
Public Class ManageDataUsersDelete
    Private Sub ManageDataUsersDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.CheckState = CheckState.Checked Then
            TxtboxPassword.UseSystemPasswordChar = False
        Else
            TxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
            connection.Open()

            Dim cmd As New MySqlCommand("DELETE FROM users WHERE id='" & txtboxId.Text & "' ", connection)

            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader()
            MsgBox("Delete Berhasil!")
            Me.Hide()
            DataUsers.load_data()
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
        End Try
    End Sub
End Class