Imports MySql.Data.MySqlClient

Public Class fm_add_queue

    Dim plan As New DataSet



    Private Sub fm_add_queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Combo_format()


    End Sub
    Private Sub Combo_format()
        plan = New DataSet

        plan = getdatat1("select * from amount_plan")
        If plan.Tables(0).Rows.Count > 0 Then
            For i = 0 To plan.Tables(0).Rows.Count - 1
                cb_plan.Items.Add(plan.Tables(0).Rows(i).Item("title").ToString)
            Next


            If plan.Tables(0).Rows.Count = 1 Then

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

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

        save_booking(entered_state)
       


    End Sub

    Private Sub save_booking(mysatate As String)


1:
        PictureBox1.Hide()
        PictureBox3.Hide()

        Try
            If cb_plan.Text.Trim = "" Then
                MessageBox.Show("اختر نوع الحجز")
                PictureBox1.Show()
                PictureBox3.Show()
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

            q.test_amount = Convert.ToInt32(tb_amount.Text)
            q.test_min = Convert.ToInt32(tb_munite.Text)
            q.test_type = cb_plan.Text

            If q.save() Then

                enter_to_doctor()
                Me.Close()
            Else
                MessageBox.Show("لم  تتم العملية")

            End If


        Catch ex As Exception
            PictureBox1.Show()
            PictureBox3.Show()

            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then

                GoTo 1

            End If
        End Try
    End Sub
    Private Sub save_booking2(mysatate As String)


1:
        PictureBox1.Hide()
        PictureBox3.Hide()

        Try
            If cb_plan.Text.Trim = "" Then
                MessageBox.Show("اختر نوع الحجز")
                PictureBox1.Show()
                PictureBox3.Show()
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

            q.test_amount = Convert.ToInt32(tb_amount.Text)
            q.test_min = Convert.ToInt32(tb_munite.Text)
            q.test_type = cb_plan.Text

            If q.save() Then

                Me.Close()
            Else
                MessageBox.Show("لم  تتم العملية")

            End If


        Catch ex As Exception
            PictureBox1.Show()
            PictureBox3.Show()

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
                    Dim birthdate As String = ds.Tables(0).Rows(0).Item("birthdate").ToString

                    Dim d As New DateTime
                    Try
                        d = Convert.ToDateTime(birthdate)
                    Catch ex As Exception

                    End Try


                    'اضافة زيارة لمراجع
                    SQLCommand = New MySqlCommand()
                    SQLCommand.Connection = conn

                    SQLCommand.CommandText = "INSERT INTO visit(patient_id , doctor_ID , age , `date` , `time` , test_type , test_amount ,note , weight) VALUES(@patient_id , @doctor_ID , @age , @date , @time , @test_type , @test_amount , @note , @weight)"




                    SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Decimal).Value = tb_patient_id.Text
                    SQLCommand.Parameters.Add("@doctor_ID", MySqlDbType.Decimal).Value = doctor_id_in_visit
                    SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Convert.ToDecimal(tb_wieght)
                    SQLCommand.Parameters.Add("@age", MySqlDbType.Decimal).Value = fm_queue_option.GetCurrentAge(d)
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

End Class