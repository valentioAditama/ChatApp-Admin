Imports MySql.Data.MySqlClient
Module Module_koneksi
    Public connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
    Public Sub connect()
        If connection.State = ConnectionState.Open Then
            connection.Close()
            connection.Open()
        Else
            connection.Open()
        End If
    End Sub

    Public Function func_login(username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("SELECT * from `admin` where username = @1 and password = @2", connection)
        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        End With
        Return True
    End Function

    Public Function func_register(fullname As String, email As String, username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `admin`(`fullname`, `email`, `username`, `password`) VALUES (@1, @2, @3, @4)", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", email)
            .Parameters.AddWithValue("@3", username)
            .Parameters.AddWithValue("@4", password)
            .ExecuteNonQuery()
        End With
        Return True
    End Function
    Public Function func_InsertUsers(fullname As String, email As String, username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `users`(`fullname`, `email`, `username`, `password`) VALUES (@1, @2, @3, @4)", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", email)
            .Parameters.AddWithValue("@3", username)
            .Parameters.AddWithValue("@4", password)
            .ExecuteNonQuery()
        End With
        Return True
    End Function
    Public Function func_InsertFeedback(fullname As String, Category As String, Describe As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `feedback`(`fullname`, `category`, `describe`) VALUES (@1, @2, @3)", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", Category)
            .Parameters.AddWithValue("@3", Describe)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function func_InsertMessage(room As String, username As String, message As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `chat`(`room`, `username`, `message`) VALUES (@1, @2, @3)", connection)
        With cmd
            .Parameters.AddWithValue("@1", room)
            .Parameters.AddWithValue("@2", username)
            .Parameters.AddWithValue("@3", message)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

End Module
