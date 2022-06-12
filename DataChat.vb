Imports MySql.Data.MySqlClient
Public Class DataChat
    Dim MysqlCon As New MySqlConnection
    Dim COMMAND As New MySqlCommand
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

    Private Sub btnManageData_Click(sender As Object, e As EventArgs)
        ManageDataChat.Show()
    End Sub

    Public Sub load_data()
        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM chat"
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

    Private Sub DataChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ManageDataChatEdit.TxtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataChatEdit.TxtboxRoom.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataChatEdit.TxtboxUsername.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataChatEdit.TxtboxMessage.Text = selectedRow.Cells(3).Value.ToString()

        ManageDataChatDelete.TxtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataChatDelete.TxtboxRoom.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataChatDelete.TxtboxUsername.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataChatDelete.TxtboxMessage.Text = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        load_data()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ManageDataChatEdit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ManageDataChatDelete.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ManageDataChat.Show()
    End Sub
End Class