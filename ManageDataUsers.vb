Imports MySql.Data.MySqlClient
Public Class ManageDataUsers
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        DataUsers.Show()
        Me.Hide()
    End Sub

    Private Sub ManageDataUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtboxEmail.Text = "" Or TxtboxFullname.Text = "" Or TxtboxUsername.Text = "" Or TxtboxPassword.Text = "" Then
            MsgBox("Field Tidak boleh kosong")
        Else
            Try
                func_InsertUsers(TxtboxFullname.Text, TxtboxEmail.Text, TxtboxUsername.Text, TxtboxPassword.Text)
                MsgBox("Berhasil Menambahkan Data!", vbInformation)
                Me.Hide()
                DataUsers.load_data()
                TxtboxEmail.Text = ""
                TxtboxFullname.Text = ""
                TxtboxUsername.Text = ""
                TxtboxPassword.Text = ""
            Catch ex As Exception
                MsgBox("Error! : " & ex.Message)
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
End Class