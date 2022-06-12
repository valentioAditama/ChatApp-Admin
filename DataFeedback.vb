Imports MySql.Data.MySqlClient

Public Class DataFeedback
    Dim COMMAND As New MySqlCommand

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Home2.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageData_Click(sender As Object, e As EventArgs)
        ManageDataFeedback.Show()
    End Sub

    Public Sub load_data()
        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM feedback"
            COMMAND = New MySqlCommand(Query, connection)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            connection.Close()

        Catch ex As Exception
            MsgBox("error", ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ManageDataFeedbackEdit.txtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataFeedbackEdit.TxtboxFullname.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataFeedbackEdit.TxtboxCategory.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataFeedbackEdit.TxtboxDescribe.Text = selectedRow.Cells(3).Value.ToString()

        ManageDataFeedbackDelete.txtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataFeedbackDelete.TxtboxFullname.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataFeedbackDelete.TxtboxCategory.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataFeedbackDelete.TxtboxDescribe.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        load_data()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ManageDataFeedbackEdit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ManageDataFeedbackDelete.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ManageDataFeedback.Show()
    End Sub
End Class