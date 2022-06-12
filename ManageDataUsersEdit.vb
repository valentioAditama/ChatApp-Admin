Imports MySql.Data.MySqlClient

Public Class ManageDataUsersEdit
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If txtboxId.Text = "" Or TxtboxEmail.Text = "" Or TxtboxFullname.Text = "" Or TxtboxUsername.Text = "" Or TxtboxPassword.Text = "" Then
            MsgBox("FIeld Tidak Boleh Kosong!", vbInformation)
        Else
            Try
                Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                connection.Open()

                Dim cmd As New MySqlCommand("update users set fullname='" & TxtboxFullname.Text & "', email='" & TxtboxEmail.Text & "', username='" & TxtboxUsername.Text & "', password='" & TxtboxPassword.Text & "' WHERE id='" & txtboxId.Text & "' ", connection)

                Dim myreader As MySqlDataReader
                myreader = cmd.ExecuteReader()
                MsgBox("Data berhasil di Edit!", vbInformation)
                Me.Hide()
                DataUsers.load_data()
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.CheckState = CheckState.Checked Then
            TxtboxPassword.UseSystemPasswordChar = False
        Else
            TxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ManageDataUsersEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
    End Sub
End Class