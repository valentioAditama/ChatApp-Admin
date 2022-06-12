Imports MySql.Data.MySqlClient
Public Class ManageDataChatEdit
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtboxId.Text = "" Or TxtboxUsername.Text = "" Or TxtboxRoom.Text = "" Or TxtboxMessage.Text = "" Then
            MsgBox("FIeld Tidak Boleh Kosong!", vbInformation)
        Else
            Try
                Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                connection.Open()

                Dim cmd As New MySqlCommand("UPDATE `chat` SET `room`='" & TxtboxRoom.Text & "',`username`='" & TxtboxUsername.Text & "',`message`='" & TxtboxMessage.Text & "' WHERE id=" & TxtboxId.Text & "", connection)

                Dim myreader As MySqlDataReader
                myreader = cmd.ExecuteReader()
                MsgBox("Data berhasil di Edit!", vbInformation)
                Me.Hide()
                DataChat.load_data()
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
    End Sub
End Class