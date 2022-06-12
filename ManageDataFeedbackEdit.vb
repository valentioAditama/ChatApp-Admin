Imports MySql.Data.MySqlClient
Public Class ManageDataFeedbackEdit
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If txtboxId.Text = "" Or TxtboxFullname.Text = "" Or TxtboxCategory.Text = "" Or txtboxDescribe.Text = "" Then
            MsgBox("FIeld Tidak Boleh Kosong!", vbInformation)
        Else
            Try
                Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                connection.Open()

                Dim cmd As New MySqlCommand("UPDATE `feedback` SET `fullname`='" & TxtboxFullname.Text & "',`describe`='" & txtboxDescribe.Text & "',`category`='" & TxtboxCategory.Text & "' WHERE id = '" & txtboxId.Text & "'", connection)

                Dim myreader As MySqlDataReader
                myreader = cmd.ExecuteReader()
                MsgBox("Data berhasil di Edit!", vbInformation)
                Me.Hide()
                DataFeedback.load_data()
                txtboxId.Text = ""
                TxtboxFullname.Text = ""
                TxtboxCategory.Text = ""
                txtboxDescribe.Text = ""
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
            End Try
        End If
    End Sub
End Class