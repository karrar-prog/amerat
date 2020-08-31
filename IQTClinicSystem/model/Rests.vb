Imports MySql.Data.MySqlClient

Public Class Rests
    Public id As Integer
    Public user_id As Integer
    Public user_name As String
    Public type As String
    Public d_left As String
    Public minutes As Integer
    Public d_should As String
    Public d_back As String 
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
  

    Sub New(id As Integer)

        Dim query As String = "select * from rests where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.user_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("user_id").ToString)
                Me.user_name = (ds.Tables(0).Rows(0).Item("user_name").ToString)
                Me.type = (ds.Tables(0).Rows(0).Item("type").ToString)
                Me.d_left = (ds.Tables(0).Rows(0).Item("d_left").ToString)
                Me.d_should = (ds.Tables(0).Rows(0).Item("d_should").ToString)
                Me.d_back = (ds.Tables(0).Rows(0).Item("d_back").ToString)
                Me.minutes = Convert.ToInt32(ds.Tables(0).Rows(0).Item("minutes").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)



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


    Public Function barcode_check() As DataSet


        Dim sql = <sql>
              select * from rests where id like @id
          </sql>

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            Dim da As New MySqlDataAdapter(SQLCommand)
            da.Fill(ds)
            conn.Close()
            Return ds

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function user_rests(user_id As Integer, d1 As DateTimePicker, d2 As DateTimePicker) As DataSet

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try

            Dim sql = <sql>
              select * from rests where user_id = @user_id and CAST(d_left AS DATE) BETWEEN  @d1 And  @d2
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.String).Value = user_id
            SQLCommand.Parameters.Add("@d1", MySqlDbType.String).Value = d1.Value.ToShortDateString
            SQLCommand.Parameters.Add("@d2", MySqlDbType.String).Value = d2.Value.ToShortDateString
            Dim da As New MySqlDataAdapter(SQLCommand)

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


    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Function all_search() As DataSet

        Dim query As String = "select * from rests"


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
            Return save_new()
        Else
            Return update()
        End If


    End Function
    Public Function delete() As Boolean

        excute1("delete from rests where id = " & Me.id & "")

        Return True





    End Function
    Private Function update() As Boolean

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
              UPDATE rests SET
                    
                    d_back = @d_back                
    
              WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@d_back", MySqlDbType.String).Value = Me.d_back
     

            SQLCommand.ExecuteNonQuery()






            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




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
              INSERT INTO rests
              (
                    user_id,
                    user_name,
                    type,
                    d_left,
                    minutes,
                    d_should,
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
                  
              )
              VALUES
              (
                   @user_id,
                    @user_name,
                    @type,
                    @d_left,
                    @minutes,
                    @d_should,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            SQLCommand.Parameters.Add("@user_name", MySqlDbType.String).Value = Me.user_name
            SQLCommand.Parameters.Add("@type", MySqlDbType.String).Value = Me.type
            SQLCommand.Parameters.Add("@d_left", MySqlDbType.String).Value = Me.d_left
            SQLCommand.Parameters.Add("@minutes", MySqlDbType.Int32).Value = Me.minutes
            SQLCommand.Parameters.Add("@d_should", MySqlDbType.String).Value = Me.d_should
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4

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
