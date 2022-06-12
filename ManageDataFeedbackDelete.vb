Imports MySql.Data.MySqlClient
Public Class ManageDataFeedbackDelete
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        connection.Open()

        Dim cmd As New MySqlCommand("DELETE FROM feedback WHERE id='" & txtboxId.Text & "' ", connection)

        Dim myreader As MySqlDataReader
        myreader = cmd.ExecuteReader()
        MsgBox("Delete Berhasil!")
        Me.Hide()
        DataFeedback.load_data()
        txtboxId.Text = ""
        TxtboxFullname.Text = ""
        TxtboxCategory.Text = ""
        TxtboxDescribe.Text = ""
    End Sub
End Class