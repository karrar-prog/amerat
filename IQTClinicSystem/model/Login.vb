Imports MySql.Data.MySqlClient
Imports System.Collections

Public Class Login

    Public id As Integer
    Public name As String
    Public type As Integer
    Public secret_word As String
    Public phone As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String

    Sub New()

        Me.id = 0

    End Sub
    Sub New(id As Integer)

        Dim query As String = "select * from user where id = " & id & ""
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.name = (ds.Tables(0).Rows(0).Item("name").ToString)
                Me.type = Convert.ToInt32((ds.Tables(0).Rows(0).Item("type").ToString))
                Me.secret_word = (ds.Tables(0).Rows(0).Item("secret_word").ToString)
                Me.phone = (ds.Tables(0).Rows(0).Item("phone").ToString)
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

    Public Function isExsit() As Boolean
        Me.id = id
        Dim query As String = "select * from user where secret_word like '" & secret_word & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try

            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.name = ds.Tables(0).Rows(0).Item("name").ToString
                Me.type = Convert.ToInt32(ds.Tables(0).Rows(0).Item("type").ToString)
                Me.phone = ds.Tables(0).Rows(0).Item("phone").ToString

                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f4 = ds.Tables(0).Rows(0).Item("f4").ToString
                '   add_event(conn, s_login, "تسجيل دخول الى النظام ")
                Return True

            Else
                conn.Close()

                Return False


            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get patient" + ex.Message)
            Return False


        End Try


        conn.Close()
    End Function
    Public Function save() As Boolean

        If Me.id = 0 Then
            Return save_new()
        Else
            Return update()
        End If


    End Function
    Public Function get_all2() As DataSet

        Dim query As String = "select * from user order by f3 asc "


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
    Public Function get_all() As DataSet

        Dim query As String = "select * from user where f1 like 'فعال' order by f3 asc "


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
              INSERT INTO user
              (
                
                    name,
                    type,
                    secret_word,
                    phone,
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
                  
              )
              VALUES
              (
                    @name,
                    @type,
                    @secret_word,
                    @phone,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 
            
              )
          </sql>
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = Me.type
            SQLCommand.Parameters.Add("@secret_word", MySqlDbType.String).Value = Me.secret_word
            SQLCommand.Parameters.Add("@phone", MySqlDbType.String).Value = Me.phone
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.ExecuteNonQuery()
            Dim content = " تمت اضافة مستخدم جديد " & Me.name
            new_event_opened(e_add, content)

            conn.Close()
            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
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
              UPDATE user SET
                    name=@name,
                    secret_word=@secret_word ,
                    type=@type ,
                    phone=@phone ,
                    f1 =@f1 ,
                    f2 =@f2 ,
                    f3 =@f3 ,
                    f4 =@f4        
              WHERE id = @id
          </sql>
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = Me.type
            SQLCommand.Parameters.Add("@phone", MySqlDbType.String).Value = Me.phone
            SQLCommand.Parameters.Add("@secret_word", MySqlDbType.String).Value = Me.secret_word
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
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
