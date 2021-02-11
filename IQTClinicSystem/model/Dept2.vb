Imports MySql.Data.MySqlClient

Public Class Dept2

    Public id As Integer
    Public user_id As Integer
    Public amount As Integer
    Public arrive_amount As Integer
    Public title As String
    Public type As String
    Public user_did_id As Integer
    Public create_at As String
    Public payment_date As String
    Public arrive_date As String
    Public status As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String



    Sub New(id As Integer)

        Dim query As String = "select * from dept2 where id = " & id & " "
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
                Me.type = (ds.Tables(0).Rows(0).Item("type").ToString)
                Me.user_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_id").ToString))
                Me.amount = Convert.ToInt32((ds.Tables(0).Rows(0).Item("amount").ToString))
                Me.arrive_amount = Convert.ToInt32((ds.Tables(0).Rows(0).Item("arrive_amount").ToString))
                Me.user_did_id = Convert.ToInt32((ds.Tables(0).Rows(0).Item("user_did_id").ToString))
                Me.create_at = (ds.Tables(0).Rows(0).Item("create_at").ToString)
                Me.payment_date = (ds.Tables(0).Rows(0).Item("payment_date").ToString)
                Me.arrive_date = (ds.Tables(0).Rows(0).Item("arrive_date").ToString)
                Me.status = (ds.Tables(0).Rows(0).Item("status").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)
                Me.f5 = (ds.Tables(0).Rows(0).Item("f5").ToString)



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
              INSERT INTO dept2
              (
                    user_id,   
                    title,   
                    amount,
                    arrive_amount,
                    type,      
                    create_at,      
                    payment_date,      
                    arrive_date,      
                    user_did_id,           
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
                    @title,   
                    @amount,
                    @arrive_amount,
                    @type,      
                    @create_at,      
                    @payment_date,      
                    @arrive_date,      
                    @user_did_id,           
                    @status,      
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
            SQLCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Me.amount
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@type", MySqlDbType.String).Value = Me.type
            SQLCommand.Parameters.Add("@status", MySqlDbType.String).Value = Me.type
            SQLCommand.Parameters.Add("@user_did_id", MySqlDbType.Int32).Value = Me.user_did_id
            SQLCommand.Parameters.Add("@create_at", MySqlDbType.String).Value = Me.create_at
            SQLCommand.Parameters.Add("@payment_date", MySqlDbType.String).Value = Me.payment_date
            SQLCommand.Parameters.Add("@arrive_date", MySqlDbType.String).Value = Me.arrive_date
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.ExecuteNonQuery()
            conn.Close()
            Return True





        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False


        End Try
    End Function
    Public Function tasded() As Boolean

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
              update dept set2
                    arrive_amount = amount
where id = @id
                        </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount

            SQLCommand.ExecuteNonQuery()


            'Dim content = "تم التسديد" & "  " & Me.user_id
            'new_event_opened(e_edit, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function tasded2() As Boolean

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
              update dept2 set
                    arrive_amount = @arrive_amount
where id = @id
                        </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount

            SQLCommand.ExecuteNonQuery()


            Dim content = "تم التسديد" & "  " & Me.user_id
            new_event_opened(e_edit, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function update() As Boolean

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
              update dept2 set
                    arrive_amount = @arrive_amount , arrive_date = @arrive_date , status = @status , f5 = @f5
where id = @id
                        </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@arrive_amount", MySqlDbType.Int32).Value = Me.arrive_amount
            SQLCommand.Parameters.Add("@arrive_date", MySqlDbType.String).Value = Me.arrive_date
            SQLCommand.Parameters.Add("@status", MySqlDbType.String).Value = Me.status
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5

            SQLCommand.ExecuteNonQuery()


            'Dim content = "تم التسديد" & "  " & Me.user_id
            'new_event_opened(e_edit, content)





            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Public Function delete() As Boolean

        excute1("delete from dept2 where id = " & Me.id & "")
        Dim content = "تم حذف فيشة الزبون" & Me.user_id.ToString & "/" & Me.amount

        new_event(e_delete, content)
        Return True





    End Function
    Function get_not_payed_for_print() As DataSet

        Dim query As String = "select * from dept2 where status like 'لا' and user_id = " & Me.user_id & " "
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

        Dim query As String = "select * from dept2 where user_id = " & Me.user_id & " "
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

        Dim query As String = "select * from dept2 where user_id = " & Me.user_id & " AND  CAST(create_at AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(create_at AS DATE) <= '" & date2.Value.ToShortDateString & "'"
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

        Dim query As String = "select * from dept2 "
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

    Function get_date(date1 As String) As DataSet
        Dim query As String = "select * ,patient2.f1 as patient_f1 ,patient2.f2  as patient_f2,patient2.f3 as patient_f3 from dept2 , patient2 where dept2.id NOT IN( SELECT dept_id FROM queue) AND CAST(payment_date AS DATE) <= '" & date1 & "' AND arrive_amount = 0 AND patient2.id = dept2.user_id "
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

    Function get_date_beteen(date1 As String, date2 As String) As DataSet
        Dim query As String = "select * , patient2.f1 as patient_f1 ,patient2.f2  as patient_f2,patient2.f3 as patient_f3 from dept2 , patient2 where dept.id NOT IN( SELECT dept_id FROM queue)  AND CAST(payment_date AS DATE) >= '" & date1 & "' AND CAST(payment_date AS DATE) < '" & date2 & "' AND arrive_amount = 0 AND patient2.id = dept2.user_id"
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
    Function get_date_beteen2(date1 As String, date2 As String) As DataSet
        Dim query As String = "select * , queue.id as queue_id ,patient2.f1 as patient_f1 ,patient2.f2  as patient_f2,patient2.f3 as patient_f3 from dept2 , patient2 , queue where CAST(payment_date AS DATE) >= '" & date1 & "' AND CAST(payment_date AS DATE) < '" & date2 & "' AND arrive_amount = 0 AND patient2.id = dept2.user_id  AND dept2.id = queue.dept_id order by queue.id desc"
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