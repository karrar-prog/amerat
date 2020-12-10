Imports MySql.Data.MySqlClient

Public Class EventRecord
    Public id As Integer
    Public title As String
    Public content As String
    Public d_date As String
    Public person As Integer
    Public amount As Integer






    Sub New(id As Integer)

        Dim query As String = "select * from event_record where id = " & id & ""
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)

                Me.title = (ds.Tables(0).Rows(0).Item("title").ToString)
                Me.content = (ds.Tables(0).Rows(0).Item("content").ToString)
                Me.d_date = (ds.Tables(0).Rows(0).Item("date").ToString)
                Me.person = Convert.ToInt32(ds.Tables(0).Rows(0).Item("person").ToString)




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


    Public Function user_event(user_id As Integer, d1 As DateTimePicker, d2 As DateTimePicker) As DataSet

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try

            Dim sql = <sql>
           SELECT * , user.name as user_name from event_record , user  
           WHERE 
           user.id = event_record.person
           AND
           person = @person
           AND
           CAST(date AS DATE) >= @d1 and  CAST(date AS DATE) >= @d2   
           order by event_record.id desc 
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@person", MySqlDbType.String).Value = user_id
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
    Public Function event_between(d1 As DateTimePicker, d2 As DateTimePicker) As DataSet

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try

            Dim sql = <sql>
          SELECT * , user.name as user_name from event_record , user  
           WHERE 
           user.id = event_record.person
           AND
           CAST(date AS DATE) BETWEEN  @d1 And  @d2 
           order by event_record.id desc  
           </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
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
        Me.amount = 0

    End Sub

    Public Function all_search() As DataSet

        Dim query As String = "select * from event_record"


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





    Public Function delete_less_than(d As DateTimePicker) As Boolean

        excute1("delete from event_record where id = " & Me.id & "and CAST(date AS DATE) <='" & d.Value.ToShortDateString & "' ")

        Return True





    End Function
    Public Function delete() As Boolean

        excute1("delete from event_record where id = " & Me.id & "")

        Return True





    End Function









    Public Function save() As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try



            Dim sql = <sql>
              INSERT INTO event_record
              (
                    title,
                    content,
                    date,
                    person,
                    amount
                  
                  
              )
              VALUES
              (
                    @title,
                    @content,
                    @date,
                    @person,
                    @amount
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@person", MySqlDbType.Int32).Value = Me.person
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Me.amount
            SQLCommand.ExecuteNonQuery()



            conn.Close()

            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function
    Public Function save(ByRef conn As MySqlConnection) As Boolean


        Try



            Dim sql = <sql>
              INSERT INTO event_record
              (
                    title,
                    content,
                    date,
                    person,
                    amount
                  
                  
              )
              VALUES
              (
                    @title,
                    @content,
                    @date,
                    @person,
                    @amount
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@person", MySqlDbType.Int32).Value = Me.person
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Me.amount
            SQLCommand.ExecuteNonQuery()
            Return True

        Catch ex As MySqlException
            Return False

        End Try
    End Function

    Sub set_is_ok(id As Integer)
        conn = New MySqlConnection
        conn.ConnectionString = serverInfo

        Try
            conn.Open()




            Dim sql = <sql>
              UPDATE  event_record         
                    SET title = @title,
                    content = @content
                WHERE id = @id
                  
           
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = "مشاهدة الاحصائيات"
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = "تمت مشاهدة الاحصائيات من قبل " & user.name

            SQLCommand.ExecuteNonQuery()
            conn.Close()

        Catch ex As MySqlException
            conn.Close()

        End Try
    End Sub


End Class
