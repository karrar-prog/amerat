Imports MySql.Data.MySqlClient

Public Class Serjury


    Public id As Integer
    Public name As String
    Public age As String
    Public ser_type As String
    Public date_enter As Date
    Public date_out As Date
    Public doctor1 As String
    Public doctor2 As String
    Public total As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String
    Public f6 As String
    Public f7 As String
    Public f8 As String
    Public f9 As String
    Public f10 As String
    Public f11 As String
    Public f12 As String
    Public f20 As String
    Public f21 As String
    Public note As String


    Sub New()
        Me.id = 0
    End Sub

    Sub New(id As Integer)

        Dim query As String = "select * from serjury where id = " & id & " "
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
                Me.name = (ds.Tables(0).Rows(0).Item("name").ToString)
                Me.age = (ds.Tables(0).Rows(0).Item("age").ToString)
                Me.date_enter = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date_enter").ToString)
                Me.date_out = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date_out").ToString)
                Me.doctor1 = (ds.Tables(0).Rows(0).Item("doctor1").ToString)
                Me.doctor2 = (ds.Tables(0).Rows(0).Item("doctor2").ToString)
                Me.total = (ds.Tables(0).Rows(0).Item("total").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)
                Me.f5 = (ds.Tables(0).Rows(0).Item("f5").ToString)
                Me.f6 = (ds.Tables(0).Rows(0).Item("f6").ToString)
                Me.f7 = (ds.Tables(0).Rows(0).Item("f7").ToString)
                Me.f8 = (ds.Tables(0).Rows(0).Item("f8").ToString)
                Me.f9 = (ds.Tables(0).Rows(0).Item("f9").ToString)
                Me.f10 = (ds.Tables(0).Rows(0).Item("f10").ToString)
                Me.f11 = (ds.Tables(0).Rows(0).Item("f11").ToString)
                Me.f12 = (ds.Tables(0).Rows(0).Item("f12").ToString)
                Me.f20 = (ds.Tables(0).Rows(0).Item("f20").ToString)
                Me.f21 = (ds.Tables(0).Rows(0).Item("f21").ToString)

                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
            

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
  
    Public Function get_all(d1 As DateTimePicker, d2 As DateTimePicker, d As String) As DataSet ' most set patient_id

        Dim query As String = "select * from serjury where doctor1 like '%" & d & "%' and date_enter between '" & d1.Value.ToShortDateString & "' and '" & d2.Value.ToShortDateString & "' order by id desc"
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

        Dim query As String = "select * from serjury where name  like '%" & searshed_word & "%' order by id desc"
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
            MsgBox("failed to get treat" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function no_search(searshed_no As String) As DataSet

        Dim query As String = "select * from serjury where id  = " & searshed_no & " order by id desc"
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
            MsgBox("failed to get treat" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function


    Public Function save() As Boolean

        If Me.id = 0 Then
            Return save_new_serjury()
        Else
            Return update_serjury()
        End If


    End Function
    Public Function delete() As Boolean

        excute1("delete from serjury where id = " & Me.id & "")

        Return True





    End Function
    Private Function update_serjury() As Boolean

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
            SQLCommand.CommandText = "UPDATE serjury SET name = @name , age = @age , ser_type = @ser_type , note = @note , doctor1 = @doctor1 , doctor2 = @doctor2 , total = @total, f1 = @f1, f2 = @f2, f3 = @f3, f4 = @f4, f5 = @f5, f6 = @f6, f7 = @f7, f8 = @f8, f9 = @f9, f10 = @f10, f11 = @f11, f12 = @f12, f20 = @f20, f21 = @f21 WHERE id = @id"


            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@age", MySqlDbType.String).Value = Me.age
            SQLCommand.Parameters.Add("@doctor1", MySqlDbType.String).Value = Me.doctor1
            SQLCommand.Parameters.Add("@doctor2", MySqlDbType.String).Value = Me.doctor2
            SQLCommand.Parameters.Add("@ser_type", MySqlDbType.String).Value = Me.ser_type
            SQLCommand.Parameters.Add("@date_enter", MySqlDbType.Date).Value = Me.date_enter.ToShortDateString
            SQLCommand.Parameters.Add("@date_out", MySqlDbType.Date).Value = Me.date_out.ToShortDateString
            SQLCommand.Parameters.Add("@total", MySqlDbType.String).Value = Me.total
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9
            SQLCommand.Parameters.Add("@f10", MySqlDbType.String).Value = Me.f10
            SQLCommand.Parameters.Add("@f11", MySqlDbType.String).Value = Me.f11
            SQLCommand.Parameters.Add("@f12", MySqlDbType.String).Value = Me.f12
            SQLCommand.Parameters.Add("@f20", MySqlDbType.String).Value = Me.f20
            SQLCommand.Parameters.Add("@f21", MySqlDbType.String).Value = Me.f21
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note

            SQLCommand.ExecuteNonQuery()





    
            conn.Close()
         
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function update2() As Boolean

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
            SQLCommand.CommandText = "UPDATE serjury SET f20 = @f20, f21 = @f21 WHERE id = @id"


            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@f20", MySqlDbType.String).Value = Me.f20
            SQLCommand.Parameters.Add("@f21", MySqlDbType.String).Value = Me.f21


            SQLCommand.ExecuteNonQuery()






            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Private Function save_new_serjury() As Boolean
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
            SQLCommand.CommandText = "INSERT INTO serjury(name ,age, date_enter, date_out , total ,f1  ,f2  ,f3  ,f4  ,f5  ,f6  ,f7  ,f8  ,f9  ,f10  ,f11  ,f12 ,f20,f21 ,note,doctor1,doctor2,ser_type) " +
                                                " VALUES(@name ,@age, @date_enter, @date_out , @total ,@f1  ,@f2 ,@f3,@f4,@f5,@f6,@f7,@f8,@f9,@f10,@f11,@f12,@f20,@f21,@note,@doctor1,@doctor2,@ser_type)"


            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@age", MySqlDbType.String).Value = Me.age
            SQLCommand.Parameters.Add("@date_enter", MySqlDbType.Date).Value = Me.date_enter.ToShortDateString

            SQLCommand.Parameters.Add("@date_out", MySqlDbType.Date).Value = Me.date_out.ToShortDateString

            SQLCommand.Parameters.Add("@total", MySqlDbType.String).Value = Me.total
            SQLCommand.Parameters.Add("@doctor1", MySqlDbType.String).Value = Me.doctor1
            SQLCommand.Parameters.Add("@doctor2", MySqlDbType.String).Value = Me.doctor2
            SQLCommand.Parameters.Add("@ser_type", MySqlDbType.String).Value = Me.ser_type
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9
            SQLCommand.Parameters.Add("@f10", MySqlDbType.String).Value = Me.f10
            SQLCommand.Parameters.Add("@f11", MySqlDbType.String).Value = Me.f11
            SQLCommand.Parameters.Add("@f12", MySqlDbType.String).Value = Me.f12
            SQLCommand.Parameters.Add("@f20", MySqlDbType.String).Value = Me.f20
            SQLCommand.Parameters.Add("@f21", MySqlDbType.String).Value = Me.f21
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note



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
