﻿Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Queue
    Public id As Integer
    Public patient_id As Integer
    Public q_date As Date
    Public q_time As Date
    Public note As String
    Public state As String
    Public test_type As String
    Public test_amount As String
    Public test_min As String
    Public booking_number As Integer



    Public dept_id As Integer
    Public amount As Decimal
    Public amount_text As String
    Public recived_date As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String


    Sub New()
        Me.id = 0
    End Sub
    Sub New(id As Integer)
        Me.id = id
        Dim query As String = "select * from queue where id = " & id & ""
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
                Me.patient_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("patient_id").ToString)
                Try
                    Me.q_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)

                Catch ex As Exception

                End Try
                Try
                   Me.q_time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Catch ex As Exception
                End Try
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.state = ds.Tables(0).Rows(0).Item("state").ToString
                Me.test_amount = ds.Tables(0).Rows(0).Item("test_amount").ToString
                Me.test_type = ds.Tables(0).Rows(0).Item("test_type").ToString
                Me.test_min = ds.Tables(0).Rows(0).Item("test_min").ToString
                Me.booking_number = Convert.ToInt32(ds.Tables(0).Rows(0).Item("booking_number").ToString)
                Me.dept_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("dept_id").ToString)
                Me.amount = Convert.ToDecimal(ds.Tables(0).Rows(0).Item("amount").ToString)
                Try
                    Me.recived_date = ds.Tables(0).Rows(0).Item("recived_date").ToString
                Catch ex As Exception
                    Me.recived_date = ""
                End Try
                Me.amount_text = ds.Tables(0).Rows(0).Item("amount_text").ToString
                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f4 = ds.Tables(0).Rows(0).Item("f4").ToString
                Me.f5 = ds.Tables(0).Rows(0).Item("f5").ToString

            Else
                Me.id = -1
                conn.Close()
                MessageBox.Show("لاتوجد فيشة بهذا الباركود")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub



    Sub New(f3 As String, t1 As Integer, t2 As Integer)

        Dim query As String = "select * from queue where f3 = '" & f3.Trim & "' order by id desc "
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
                Me.patient_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("patient_id").ToString)
                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Try
                    Me.q_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)

                Catch ex As Exception

                End Try
                Try
                    Me.q_time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Catch ex As Exception
                End Try
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.state = ds.Tables(0).Rows(0).Item("state").ToString
                Me.test_amount = ds.Tables(0).Rows(0).Item("test_amount").ToString
                Me.test_type = ds.Tables(0).Rows(0).Item("test_type").ToString
                Me.test_min = ds.Tables(0).Rows(0).Item("test_min").ToString
                Me.booking_number = Convert.ToInt32(ds.Tables(0).Rows(0).Item("booking_number").ToString)
                Me.dept_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("dept_id").ToString)
                Me.amount = Convert.ToDecimal(ds.Tables(0).Rows(0).Item("amount").ToString)
                Try
                    Me.recived_date = ds.Tables(0).Rows(0).Item("recived_date").ToString
                Catch ex As Exception
                    Me.recived_date = ""
                End Try
                Me.amount_text = ds.Tables(0).Rows(0).Item("amount_text").ToString
                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f4 = ds.Tables(0).Rows(0).Item("f4").ToString
                Me.f5 = ds.Tables(0).Rows(0).Item("f5").ToString

            Else
                Me.id = -1
                conn.Close()
                MessageBox.Show("لاتوجد فيشة بهذا الباركود")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get " + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Sub New(id As Integer, p_id As Integer)
        Me.id = id
        Dim query As String = "select * from queue where patient_id = " & p_id & ""
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
                Me.patient_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("patient_id").ToString)
                Try
                    Me.q_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)

                Catch ex As Exception

                End Try
                Try
                    Me.q_time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Catch ex As Exception
                End Try
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.state = ds.Tables(0).Rows(0).Item("state").ToString
                Me.test_amount = ds.Tables(0).Rows(0).Item("test_amount").ToString
                Me.test_type = ds.Tables(0).Rows(0).Item("test_type").ToString
                Me.test_min = ds.Tables(0).Rows(0).Item("test_min").ToString
                Me.booking_number = Convert.ToInt32(ds.Tables(0).Rows(0).Item("booking_number").ToString)
                Me.dept_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("dept_id").ToString)
                Me.amount = Convert.ToDecimal(ds.Tables(0).Rows(0).Item("amount").ToString)
                Try
                    Me.recived_date = ds.Tables(0).Rows(0).Item("recived_date").ToString
                Catch ex As Exception
                    Me.recived_date = ""
                End Try
                Me.amount_text = ds.Tables(0).Rows(0).Item("amount_text").ToString
                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f4").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f5").ToString

            Else
                Me.id = -1
             
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


    Public Function save() As Boolean



        If Me.id = 0 Then
            Return save_new_queue()
        Else
            Return update_queue()
        End If


    End Function

    Private Function save_new_queue() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return False
        'End Try
        Try
            Dim dt_date As New DateTimePicker
            dt_date.Value = Me.q_date


            'Dim query As String = "select * from queue where `date` = '" & dt_date.Value.ToShortDateString & "'"
            'Dim da As New MySqlDataAdapter(query, conn)
            'Dim ds As New DataSet()


            'da.Fill(ds)
            'Me.booking_number = Convert.ToInt32(ds.Tables(0).Rows.Count) + 1

            'query = "select * from queue where `date` = '" & dt_date.Value.ToShortDateString & "' and patient_id = " & Me.patient_id & ""
            'da = New MySqlDataAdapter(query, conn)
            'ds = New DataSet()


            'da.Fill(ds)
            'If ds.Tables(0).Rows.Count > 0 Then
            '    conn.Close()
            '    MessageBox.Show("تمت طباعة فيشة اليوم")
            '    Return False
            'End If





            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO queue(patient_id ,`time`,`date` , note , state ,test_type, test_amount , test_min ,booking_number,dept_id,amount,amount_text,recived_date,f1,f2,f3,f4,f5) " +
                                                " VALUES(@patient_id, @time, @date ,@note , @state , @test_type ,@test_amount , @test_min,@booking_number,@dept_id,@amount,@amount_text,@recived_date,@f1,@f2,@f3,@f4,@f5)"
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.String).Value = Me.patient_id
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.q_date
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.q_time
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = Me.state
            SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = Me.test_type
            SQLCommand.Parameters.Add("@test_amount", MySqlDbType.String).Value = Me.test_amount
            SQLCommand.Parameters.Add("@test_min", MySqlDbType.String).Value = Me.test_min
            SQLCommand.Parameters.Add("@booking_number", MySqlDbType.Int32).Value = Me.booking_number
            SQLCommand.Parameters.Add("@dept_id", MySqlDbType.Int32).Value = Me.dept_id
            SQLCommand.Parameters.Add("@amount_text", MySqlDbType.String).Value = Me.amount_text
            SQLCommand.Parameters.Add("@amount", MySqlDbType.Decimal).Value = Me.amount
            SQLCommand.Parameters.Add("@recived_date", MySqlDbType.String).Value = Me.recived_date
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.ExecuteNonQuery()

            'اضافة حدث
            Dim conent As String = "تمت حفظ فيشة  : " & Me.q_date.ToShortDateString & "  للزبون رقم :" & Me.patient_id & ""

            add_event(conn, s_add, conent)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'اذا كان يوجد حجز فقد تمت الاضافة الان - هنا نجلب البيانات لكي نرسلها للطباعه
            'query = "select patient.name as current_name , queue.`date` as date , queue.test_type as type  , queue.test_amount as amount  , queue.booking_number as number  from queue , patient where `date` = '" & dt_date.Value.ToShortDateString & "' and patient_id = " & Me.patient_id & " and patient.id = queue.patient_id"

            ''query = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where `date` = '" & dt_date.Value.ToShortDateString & "' and patient_id = " & Me.patient_id & " and patient.id = queue.patient_id"
            'da = New MySqlDataAdapter(query, conn)
            'ds = New DataSet()


            'da.Fill(ds)
            'If ds.Tables(0).Rows.Count > 0 Then
            '    conn.Close()
            '    Dim fm = New fm_report_viewr

            '    fm.ds = ds
            '    fm.Show()

            '    Return True
            'End If
            ''''''''''''''''''''''''''''''''''''''''''''''

            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

    Private Function update_queue() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return False

        'End Try

        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "UPDATE queue SET state = @state ,recived_date = @recived_date , note = @note , `date` = @date , test_type = @test_type , test_amount = @test_amount , test_min = @test_min WHERE id = @id"

            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.q_date
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = Me.test_type
            SQLCommand.Parameters.Add("@test_amount", MySqlDbType.String).Value = Me.test_amount
            SQLCommand.Parameters.Add("@test_min", MySqlDbType.String).Value = Me.test_min
            SQLCommand.Parameters.Add("@recived_date", MySqlDbType.String).Value = Me.recived_date
            SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = Me.state

            SQLCommand.ExecuteNonQuery()

            Dim conent As String = "تم تعديل الحجز للمراجع رقم : " & Me.patient_id & " الى حالة : " & Me.state & " ونوع الفحص : " & Me.test_type & ""
            ' add_event(conn, s_update, conent)

            conn.Close()
            fm_queue.search()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try





    End Function

    Sub delete()
        excute1("delete from queue where id = " & Me.id & "")
    End Sub



End Class
