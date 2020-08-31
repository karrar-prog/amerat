Imports MySql.Data.MySqlClient

Public Class Analyses


    Public id As Integer
    Public title As String
    Public category As String



    Sub New()
        Me.id = 0
    End Sub

    Sub New(id As Integer)

        Dim query As String = "select * from analyses where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Exit Sub
        'End Try
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.title = (ds.Tables(0).Rows(0).Item("title").ToString)
                Me.category = (ds.Tables(0).Rows(0).Item("category").ToString)


            Else
                conn.Close()
                MessageBox.Show("there is no ")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Public Function get_all() As DataSet

        Dim query As String = "select * from analyses order by id desc"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return ds
        'End Try
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()
            Return ds

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function

    Public Function name_search(searshed_word As String) As DataSet

        Dim query As String = "select * from analyses where title  like '%" & searshed_word & "%' order by id desc"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return ds
        'End Try
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()
            Return ds

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function

    Public Function save() As Boolean

        If Me.id = 0 Then
            Return save_new_analyses()
        Else
            Return update_analyses()
        End If


    End Function
    Public Function delete() As Boolean

        excute1("delete from analyses where id = " & Me.id & "")

        Return True





    End Function
    Private Function update_analyses() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "UPDATE analyses SET title = @title , category = @category WHERE id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@category", MySqlDbType.String).Value = Me.category
            SQLCommand.ExecuteNonQuery()
            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Private Function save_new_analyses() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO analyses(title,category) VALUES(@title , @category)"
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@category", MySqlDbType.String).Value = Me.category
            SQLCommand.ExecuteNonQuery()


            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function





End Class
