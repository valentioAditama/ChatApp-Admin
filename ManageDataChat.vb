Public Class ManageDataChat
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        DataChat.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtboxUsername.Text = "" Or TxtboxRoom.Text = "" Or TxtboxMessage.Text = "" Then
            MsgBox("Field Tidak Boleh kosong!")
        Else
            Try
                func_InsertMessage(TxtboxRoom.Text, TxtboxUsername.Text, TxtboxMessage.Text)
                MsgBox("Berhasil Menambahkan Data!", vbInformation)
                Me.Hide()
                DataChat.load_data()

                TxtboxRoom.Text = ""
                TxtboxUsername.Text = ""
                TxtboxMessage.Text = ""

            Catch ex As Exception
                MsgBox("Error! : " & ex.Message)
            End Try
        End If
    End Sub
End Class