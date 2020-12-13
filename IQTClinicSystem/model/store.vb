Imports MySql.Data.MySqlClient

Public Class store
    Public id As Integer
    Public name As String
    Public place As String
    Public Function all() As DataSet
        Dim query As String = "select * from store"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
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
    Public Function contract_item() As DataSet
        Dim query As String = "select * from store where id = 1"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
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

    Sub save_new()
        Dim query As String = "insert into store (name) values('" & Me.name & "')"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)

        End Try
        conn.Close()

    End Sub

    Sub update_items()
        Dim query As String = "update store  set name = '" & Me.name & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)

        End Try
        conn.Close()
    End Sub

End Class
