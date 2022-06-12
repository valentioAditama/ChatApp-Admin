Imports MySql.Data.MySqlClient
Public Class DataUsers
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
        ManageDataUsers.Show()
    End Sub

    Public Sub load_data()
        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM users"
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

    Private Sub DataUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ManageDataUsers.Show()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        load_data()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ManageDataUsersEdit.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        ManageDataUsersEdit.txtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataUsersEdit.TxtboxFullname.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataUsersEdit.TxtboxEmail.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataUsersEdit.TxtboxUsername.Text = selectedRow.Cells(3).Value.ToString()
        ManageDataUsersEdit.TxtboxPassword.Text = selectedRow.Cells(4).Value.ToString()

        ManageDataUsersDelete.txtboxId.Text = selectedRow.Cells(0).Value.ToString()
        ManageDataUsersDelete.TxtboxFullname.Text = selectedRow.Cells(1).Value.ToString()
        ManageDataUsersDelete.TxtboxEmail.Text = selectedRow.Cells(2).Value.ToString()
        ManageDataUsersDelete.TxtboxUsername.Text = selectedRow.Cells(3).Value.ToString()
        ManageDataUsersDelete.TxtboxPassword.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ManageDataUsersDelete.Show()
    End Sub
End Class