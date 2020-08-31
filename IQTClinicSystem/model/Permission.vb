Imports MySql.Data.MySqlClient

Public Class Permission
    Public id As Integer
    Public user_id As Integer
    Public title As String
    Public date_got As String
    Public user_did_it As Integer

   
  

    Public Sub getAll()

        Dim query As String = "select * from permission where user_id = " & User.id & ""
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    permissionList.Add(ds.Tables(0).Rows(i).Item("title").ToString)
                Next
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("", "failed to get " + ex.Message)

        End Try
        conn.Close()

    End Sub
    Public Function get_user_permission() As DataSet


        Dim query As String = "select * from permission where user_id = " & Me.user_id & ""
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
            MessageBox.Show("", "failed to get " + ex.Message)

        End Try
        Return ds

        conn.Close()

    End Function
    Public Function delete() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try
            Dim sql = <sql>
              delete from permission where id = @id
             
          </sql>
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id

            SQLCommand.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

    Public Function save() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try
            Dim sql = <sql>
              INSERT INTO permission
              (
                
                    title,
                    user_id,
                    user_did_id,
                    date_got
              )
              VALUES
              (
                    @title,
                    @user_id,
                    @user_did_id,
                    @date_got
            
              )
          </sql>
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            SQLCommand.Parameters.Add("@user_did_id", MySqlDbType.String).Value = Me.user_did_it
            SQLCommand.Parameters.Add("@date_got", MySqlDbType.String).Value = Date.Now
            SQLCommand.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function
End Class
