Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel

Public Class fm_add_queue

    Dim plan As New DataSet
    Public house_price As Decimal = 0




    Private Sub fm_add_queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
        If tb_number.Text.Trim = "1" Then
            GroupControl1.Show()
        Else
            GroupControl1.Hide()

        End If
        Me.CenterToScreen()

        Combo_format()
        cal_money()


    End Sub
    Private Sub Combo_format()
        plan = New DataSet

        plan = getdatat1("select * from amount_plan")
        If plan.Tables(0).Rows.Count > 0 Then
            For i = 0 To plan.Tables(0).Rows.Count - 1
                cb_plan.Items.Add(plan.Tables(0).Rows(i).Item("title").ToString)
            Next


            If plan.Tables(0).Rows.Count > 0 Then

                cb_plan.SelectedItem = cb_plan.Items(0)


            End If

        End If

    End Sub

    Private Sub get_plan(ByVal title As String)
        Dim queue = New DataSet


        queue = getdatat1("SELECT * FROM amount_plan WHERE title LIKE '" & title & "' ")
        If queue.Tables(0).Rows.Count > 0 Then


            tb_munite.Text = queue.Tables(0).Rows(0).Item("time").ToString()
            tb_amount.Text = queue.Tables(0).Rows(0).Item("amount").ToString()


        Else

        End If

    End Sub

    Private Sub cb_plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plan.SelectedIndexChanged
        get_plan(cb_plan.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        save_booking2(wait_state)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub dt_queue_ValueChanged(sender As Object, e As EventArgs) Handles dt_queue.ValueChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)

        save_booking(entered_state)



    End Sub

    Private Sub save_booking(mysatate As String)


1:
        PictureBox1.Hide()

        Try
            If cb_plan.Text.Trim = "" Then
                MessageBox.Show("اختر نوع الحجز")
                PictureBox1.Show()

                Exit Sub

            End If


            Dim q As New Queue
            If tb_id.Text.Trim = "" Then
                q.id = 0
            Else
                q.id = Convert.ToInt32(tb_id.Text)
            End If


            q.q_date = dt_queue.Value
            q.patient_id = Convert.ToInt32(tb_patient_id.Text)
            q.note = tb_note.Text
            q.state = mysatate

            q.test_amount = tb_amount.Text
            q.test_min = tb_munite.Text
            q.test_type = cb_plan.Text

            If q.save() Then

                enter_to_doctor()
                Me.Close()
            Else
                MessageBox.Show("لم  تتم العملية")

            End If


        Catch ex As Exception
            PictureBox1.Show()

            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then

                GoTo 1

            End If
        End Try
    End Sub
    Private Sub save_booking2(mysatate As String)


1:
        PictureBox1.Hide()

        Try

            If (tb_number.Text.Trim = "1") Then
                Dim p As New Patient(__(tb_patient_id.Text))
                If p.first_push_amount_arrived > 0 Then
                    MessageBox.Show("تم استلام اول دفعة في تأريخ" & p.diagonosis)
                    Exit Sub
                End If
                save_first_push(p)
            End If



            If cb_plan.Text.Trim = "" Then
                MessageBox.Show("اختر اسم المصرف  ")
                PictureBox1.Show()

                Exit Sub

            End If

            Dim q As New Queue
            If tb_id.Text.Trim = "" Then
                q.id = 0
            Else
                q.id = Convert.ToInt32(tb_id.Text)
            End If


            q.q_date = dt_queue.Value
            q.patient_id = Convert.ToInt32(tb_patient_id.Text)
            q.note = tb_note.Text
            q.state = mysatate

            q.test_amount = tb_amount.Text
            q.test_min = tb_munite.Text
            q.test_type = cb_plan.Text

            q.amount = __(tb_fesha_amount.EditValue.ToString)
            q.amount_text = tb_amount_text.Text

            Try
                q.booking_number = __(tb_number.Text)
            Catch ex As Exception
                q.booking_number = 0
            End Try

            q.f1 = tb_dept_title.Text

            Try
                q.dept_id = __(tb_dept_id.Text)
            Catch ex As Exception
                q.dept_id = 0

            End Try

            If q.save() Then



                'Dim id As Integer = get_last_id(q.patient_id)
                print_report()
                Me.Close()
            Else
                MessageBox.Show("لم  تتم العملية")

            End If


        Catch ex As Exception
            PictureBox1.Show()

            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then

                GoTo 1

            End If
        End Try
    End Sub
    Private Sub print_report()
        Dim query As String

1:
        Try
            If tb_dept_id.Text.Trim = "0" Or tb_dept_id.Text.Trim = "" Then
                query = "select * , queue.id as fesha_id , queue.note as fesha_note ,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  patient.id = " & tb_patient_id.Text & " and patient.id = queue.patient_id order by queue.id desc limit 1 "

            Else
                query = "select * , queue.id as fesha_id , queue.note as fesha_note,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  queue.dept_id = " & tb_dept_id.Text & " and patient.id = queue.patient_id order by queue.id desc limit 1 "

            End If

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_report_viewr

            fm.ds = getdatat1(query)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Sub print_report(id As Integer)
1:
        Try
            '       Dim query As String = "select patient.name as current_name , queue.`date` as date , queue.test_type as type  , queue.test_amount as amount  , queue.booking_number as number  from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim query As String = "select * , queue.note as fesha_note , queue.id as fesha_id ,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_report_viewr

            fm.ds = getdatat1(query)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub
    Private Sub enter_to_doctor()
1:
        Dim tb_wieght = "0.00"

        Try
            If cb_plan.Text.Trim <> "" Then
                'If report_enable = 1 Then
                '    print_report()
                'End If
                Try
                    fm_wait.ProgressPanel1.Caption = "دخول الى الطبيب"

                Catch ex As Exception

                End Try



                conn = New MySqlConnection()
                conn.ConnectionString = serverInfo
                conn.Open()

                Try


                    Dim SQLCommand As New MySqlCommand()
                    SQLCommand.Connection = conn
                    'SQLCommand.CommandText = "UPDATE queue SET `time` = @time , `state` = @state  WHERE id = @id"

                    'SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
                    'SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = entered_state
                    'SQLCommand.Parameters.Add("@id", MySqlDbType.Decimal).Value = id

                    'SQLCommand.ExecuteNonQuery()



                    'جلب مواليد المراجع
                    SQLCommand = New MySqlCommand()
                    SQLCommand.Connection = conn
                    Dim query As String = "select * from patient  where id = " & tb_patient_id.Text & ""
                    Dim da As New MySqlDataAdapter(query, conn)
                    Dim ds As New DataSet()
                    da.Fill(ds)




                    'اضافة زيارة لمراجع
                    SQLCommand = New MySqlCommand()
                    SQLCommand.Connection = conn

                    SQLCommand.CommandText = "INSERT INTO visit(patient_id , doctor_ID , age , `date` , `time` , test_type , test_amount ,note , weight) VALUES(@patient_id , @doctor_ID , @age , @date , @time , @test_type , @test_amount , @note , @weight)"




                    SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Decimal).Value = tb_patient_id.Text
                    SQLCommand.Parameters.Add("@doctor_ID", MySqlDbType.Decimal).Value = doctor_id_in_visit
                    SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Convert.ToDecimal(tb_wieght)
                    SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
                    SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToShortDateString)
                    SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = cb_plan.Text
                    SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = tb_note.Text
                    SQLCommand.Parameters.Add("@test_amount", MySqlDbType.Decimal).Value = Val(tb_amount.Text)

                    'Dim conent As String = "تم تحويل المراجع  : " & tb_name.Text & " الى الطبيب"
                    'add_event(conn, s_convert, conent)

                    SQLCommand.ExecuteNonQuery()


                    Me.Close()
                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                End Try

                'fm_queue.search()
                conn.Close()





                fm_queue.search()




            Else
                cb_plan.Enabled = True
                MessageBox.Show("اختر نوع الفحص")

                Exit Sub
            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Function get_last_id(patient_id As Integer) As Integer

        Dim d As New DataSet
        d = getdatat1("select max(id) from queue where patient_id = " & patient_id & "")
        If d.Tables(0).Rows.Count > 0 Then
            Return __(d.Tables(0).Rows(0).Item("id").ToString)
        Else
            Return 0
        End If


    End Function

    Private Sub tb_fesha_amount_EditValueChanged(sender As Object, e As EventArgs) Handles tb_fesha_amount.EditValueChanged

    End Sub

    Private Sub tb_fesha_amount_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_fesha_amount.KeyUp

        Try
            tb_amount_text.Text = ToArabicLetter(__(tb_fesha_amount.EditValue.ToString))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub nu_first_money_present_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_first_money_present.KeyUp
        cal_money()
    End Sub

    Private Sub nu_first_money_present_ValueChanged(sender As Object, e As EventArgs) Handles nu_first_money_present.ValueChanged
        cal_money()

    End Sub

    Private Sub cal_money()
        tb_fesha_amount.Text = Math.Floor((house_price / 100 * nu_first_money_present.Value)).ToString
        tb_amount_text.Text = ToArabicLetter(__(tb_fesha_amount.Text))
    End Sub

    Private Sub save_first_push(p As Patient)

        p.first_push_amount = __(tb_fesha_amount.Text)
        p.first_push_present = nu_first_money_present.Value
        p.save()

    End Sub

End Class