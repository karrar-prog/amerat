Imports MySql.Data.MySqlClient

Public Class OtherRequired
    Public id, title, amount, note As Integer

    Public used As Boolean

    Public Function all(id As Integer) As DataSet
        Dim query As String = "select * from customer_discount where id = " & id & " and used = false"
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
    Private Function save_new() As Boolean
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
              INSERT INTO customer_discount
              (
                    user_id,
                    amount,
                    menu_id,
                    got_date,
                    used_date,
                    used,
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
                 
              )
              VALUES
              (
                    @user_id,
                    @amount,
                    @menu_id,
                    @got_date,
                    @used_date,
                    @used,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            'SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            'SQLCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Me.amount
            'SQLCommand.Parameters.Add("@menu_id", MySqlDbType.Int32).Value = Me.menu_id
            'SQLCommand.Parameters.Add("@got_date", MySqlDbType.String).Value = Me.got_date
            'SQLCommand.Parameters.Add("@used_date", MySqlDbType.String).Value = Me.used_date
            'SQLCommand.Parameters.Add("@used", MySqlDbType.String).Value = Me.used

            'SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            'SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            'SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            'SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4



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
