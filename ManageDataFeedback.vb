Public Class ManageDataFeedback
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        DataFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtboxFullname.Text = "" Or TxtboxDescribe.Text = "" Or TxtboxCategory.Text = "" Then
            MsgBox("Field Tidak boleh kosong")
        Else
            Try
                func_InsertFeedback(TxtboxFullname.Text, TxtboxCategory.Text, TxtboxDescribe.Text)
                MsgBox("Berhasil Menambahkan Data!", vbInformation)
                Me.Hide()
                DataFeedback.load_data()
                TxtboxFullname.Text = ""
                TxtboxCategory.Text = ""
                TxtboxDescribe.Text = ""
            Catch ex As Exception
                MsgBox("Error! : " & ex.Message)
            End Try
        End If
    End Sub
End Class