Imports MySql.Data.MySqlClient

Public Class Months

    Public id As Integer
    Public user_id As Integer
    Public year As Integer
    Public month As Integer
    Public status As String
    Public user_did_id As Integer
    Public create_at As String
    Public amber_price As Integer
    Public amber_count As Integer
    Public total_amount As Integer
    Public arrive_amount As Integer
    Public payment_date As String
    Public note As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String



    Sub New(id As Integer)

        Dim query As String = "select * from months where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)   
                Me.user_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_id").ToString))
                Me.amber_count = Convert.ToInt32((ds.Tables(0).Rows(0).Item("amber_count").ToString))
                Me.total_amount = Convert.ToInt32((ds.Tables(0).Rows(0).Item("total_amount").ToString))
                Me.amber_price = Convert.ToInt32((ds.Tables(0).Rows(0).Item("amber_price").ToString))
                Me.arrive_amount = Convert.ToInt32((ds.Tables(0).Rows(0).Item("arrive_amount").ToString))
                Me.user_did_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_did_id").ToString))
                Me.month = Convert.ToInt32((ds.Tables(0).Rows(0).Item("month").ToString))
                Me.year = Convert.ToInt32((ds.Tables(0).Rows(0).Item("year").ToString))
                Me.user_did_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_did_id").ToString))
                Me.create_at = (ds.Tables(0).Rows(0).Item("create_at").ToString)
                Me.payment_date = (ds.Tables(0).Rows(0).Item("payment_date").ToString)
                Me.status = (ds.Tables(0).Rows(0).Item("status").ToString)
                Me.note = (ds.Tables(0).Rows(0).Item("note").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)
                Me.f5 = (ds.Tables(0).Rows(0).Item("f5").ToString)



            Else
                conn.Close()

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
              INSERT INTO months
              (
                    user_id,   
                    total_amount,
                    amber_count,
                    amber_price,
                    arrive_amount,   
                    year,      
                    month,      
                    create_at,      
                    payment_date,      
                    user_did_id,  
                    note,           
                    status,      
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 ,
                    f5 
               
              )
              VALUES
              (
                   
                    @user_id,   
                    @total_amount,
                    @amber_count,
                    @amber_price,
                    @arrive_amount,     
                    @year,      
                    @month,      
                    @create_at,      
                    @payment_date,      
                    @user_did_id,           
                    @status,      
                    @note,      
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 ,
                    @f5 
              )

          </sql>
            Dim d As New DateTimePicker
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            SQLCommand.Parameters.Add("@total_amount", MySqlDbType.Int32).Value = Me.total_amount
            SQLCommand.Parameters.Add("@amber_count", MySqlDbType.Int32).Value = Me.amber_count
            SQLCommand.Parameters.Add("@amber_price", MySqlDbType.Int32).Value = Me.amber_price
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.Parameters.Add("@year", MySqlDbType.Int32).Value = Me.year
            SQLCommand.Parameters.Add("@month", MySqlDbType.Int32).Value = Me.month
            SQLCommand.Parameters.Add("@status", MySqlDbType.String).Value = Me.status
            SQLCommand.Parameters.Add("@user_did_id", MySqlDbType.Int32).Value = Me.user_did_id
            SQLCommand.Parameters.Add("@create_at", MySqlDbType.String).Value = Me.create_at
            SQLCommand.Parameters.Add("@payment_date", MySqlDbType.String).Value = Me.payment_date
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.ExecuteNonQuery()
            conn.Close()

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show("خطا " & ex.Message)
            Return False


        End Try
    End Function
    Private Function update() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try


            ' غير مكتمله
            Dim sql = <sql>
              INSERT INTO dept
              (



                    user_id=   @user_id,    
                    title,   
                    amount,
                    arrive_amount,
                    type,      
                    create_at,      
                    payment_date,      
                    user_did_id,           
                    status,      
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 ,
                    f5 
               
                
                 
                    @title,   
                    @amount,
                    @arrive_amount,
                    @type,      
                    @create_at,      
                    @payment_date,      
                    @user_did_id,           
                    @status,      
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 ,
                    @f5     
              )

          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Me.user_id
            SQLCommand.Parameters.Add("@total_amount", MySqlDbType.Int32).Value = Me.total_amount
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.Parameters.Add("@amber_price", MySqlDbType.Int32).Value = Me.amber_price
            SQLCommand.Parameters.Add("@amber_count", MySqlDbType.Int32).Value = Me.amber_count
            SQLCommand.Parameters.Add("@year", MySqlDbType.Int32).Value = Me.year
            SQLCommand.Parameters.Add("@month", MySqlDbType.Int32).Value = Me.month
            SQLCommand.Parameters.Add("@status", MySqlDbType.String).Value = Me.status
            SQLCommand.Parameters.Add("@user_did_id", MySqlDbType.Int32).Value = Me.user_did_id
            SQLCommand.Parameters.Add("@create_at", MySqlDbType.String).Value = Me.create_at
            SQLCommand.Parameters.Add("@payment_date", MySqlDbType.String).Value = Me.payment_date
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.ExecuteNonQuery()


            Dim content = "تم تعديل " & "  " & Me.user_id
            new_event_opened(e_edit, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function put_arrive() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try


            ' غير مكتمله
            Dim sql = <sql>
              update  months set                        
                    arrive_amount = @arrive_amount ,
                    note = @note
             where id = @id
       

          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.ExecuteNonQuery()


            'Dim content = "تم تسديد شهر  " & "  " & Me.user_id
            'new_event_opened(e_tasded, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function all_arrive() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try


            ' غير مكتمله
            Dim sql = <sql>
              update  months set                        
                    arrive_amount = @total_amount 
             where id = @id
       

          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.ExecuteNonQuery()


            Dim content = "تم تسديد شهر   " & "  " & Me.user_id
            new_event_opened(e_tasded, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Public Function delete() As Boolean

        excute1("delete from month where id = " & Me.id & "")
        Dim content = " تم حذف استحقاق المشترك" & Me.user_id.ToString & "/شهر" & Me.year & "/" & Me.month

        new_event(e_delete, content)
        Return True





    End Function
    Function get_not_payed_for_print() As DataSet

        Dim query As String = "select * from month where status like 'لا' and user_id = " & Me.user_id & " "
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
    Function get_all_months(query As String) As DataSet

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
    Function get_all_user_dept(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from dept where user_id = " & Me.user_id & " AND  CAST(create_at AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(create_at AS DATE) <= '" & date2.Value.ToShortDateString & "'"
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

        Dim query As String = "select * from dept "
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

    Function get_one(id As Integer) As DataSet
        Dim query = "select *  , patient.f1 as patient_f1  ,patient.f2 as patient_f2  ,patient.f3 as patient_f3 ,patient.f4 as patient_f4 , months.id as months_id   ,months.f1 as months_f1  ,months.f2 as months_f2 ,months.f3 as months_f3  ,months.f4 as months_f4  ,months.f5 as months_f5 from months , patient where months.id =" & id & " and patient.id = months.user_id "

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