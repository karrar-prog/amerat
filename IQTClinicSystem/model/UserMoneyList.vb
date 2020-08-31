Imports MySql.Data.MySqlClient

Public Class UserMoneyList





    Public id As Integer

    Public user_id As Integer
    Public amount As Integer

    Public type As String

    Public user_did_id As Integer

    Public date1 As String
    Public time As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
   


    Sub New(id As Integer)

        Dim query As String = "select * from user_money_list where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.type = (ds.Tables(0).Rows(0).Item("type").ToString)
                Me.user_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_id").ToString))
                Me.amount = Convert.ToInt32((ds.Tables(0).Rows(0).Item("amount").ToString))
                Me.user_did_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_did_id").ToString))
                Me.date1 = (ds.Tables(0).Rows(0).Item("date").ToString)
                Me.time = (ds.Tables(0).Rows(0).Item("time").ToString)
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
            MsgBox("failed to get " + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Sub New()
        Me.id = 0

    End Sub

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
              INSERT INTO user_money_list
              (
                    user_id,   
                    amount,
                    type,      
                    user_did_id,      
                    date,      
                    time,      
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
               
              )
              VALUES
              (
                   
                    @user_id,   
                    @amount,
                    @type,      
                    @user_did_id,      
                    @date,      
                    @time,      
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4        
              )

          </sql>
            Dim d As New DateTimePicker
            Dim code As String = d.Value.Year.ToString & d.Value.Month.ToString & d.Value.Day.ToString & d.Value.Hour.ToString & d.Value.Minute.ToString & d.Value.Second.ToString & d.Value.Millisecond.ToString
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            SQLCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Me.amount
            SQLCommand.Parameters.Add("@type", MySqlDbType.String).Value = Me.type
            SQLCommand.Parameters.Add("@user_did_id", MySqlDbType.Int32).Value = Me.user_did_id
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.date1
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time

            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.ExecuteNonQuery()
            conn.Close()





        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False


        End Try
    End Function

    Function get_for_print() As DataSet

        Dim query As String = "select * from user_money_list where id = " & Me.id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_user_money() As DataSet

        Dim query As String = "select * from user_money_list where user_id = " & Me.user_id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_user_money(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from user_money_list where user_id = " & Me.user_id & " AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_user_money2(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * , user.name as user_name from user_money_list , user where user_id = " & Me.user_id & " AND user_money_list.user_id = user.id  AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_user_money3() As DataSet

        Dim query As String = "select * , user.name as user_name from user_money_list , user where user_id = " & Me.user_id & " AND user_money_list.user_id = user.id "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_money2(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * , user.name as user_name from user_money_list , user where user_money_list.user_id = user.id  AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_money3() As DataSet

        Dim query As String = "select * , user.name as user_name from user_money_list , user where user_money_list.user_id = user.id  "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_casher_money(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from user_money_list where 	user_did_id = " & Me.user_did_id & " AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function
    Function get_all_money(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from user_money_list where CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function

    Function get_all() As DataSet

        Dim query As String = "select * from user_money_list "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function


 
End Class
