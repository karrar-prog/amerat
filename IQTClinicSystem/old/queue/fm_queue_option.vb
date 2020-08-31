Imports MySql.Data.MySqlClient
Imports System.Speech.Synthesis

Public Class fm_queue_option
    Public id As String
    Public number As String
    Public queue As New ds_queue
    Public p_id As Integer

    Public current_name As String
    Dim plan As New DataSet
    Public currnet_state As String
    Public title As String
    Public report_enable As Integer = 0

    Private Sub fm_queue_option_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_queue.lv_queue.SelectedItems.Clear()
        fm_queue.Show()
    End Sub


    Private Sub fm_queue_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = True
        GroupControl1.Hide()
        tb_name.Text = current_name
        Combo_format()

        '   cb_plan.Enabled = False   'remove if the doctor accept 
        '--------------------------

    End Sub

    Private Sub TileControl1_Click(sender As Object, e As EventArgs) Handles TileControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick

        get_plan(title)

        GroupControl1.Show()

        fm_wait.tb_name_entered.Text = current_name
        fm_wait.tb_number_enterd.Text = number
        If (BackgroundWorker2.IsBusy) Then

        Else
            BackgroundWorker2.RunWorkerAsync()

        End If


    End Sub

    Private Sub change_state(state As String)


        If state = ready_state Then

            conn = New MySqlConnection()
            conn.ConnectionString = serverInfo
            conn.Open()
            Try

                Dim SQLCommand As New MySqlCommand()
                SQLCommand.Connection = conn
                SQLCommand.CommandText = "UPDATE queue SET `time` = @time , `state` = @state  WHERE id = @id"

                SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)

                SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = state

                SQLCommand.Parameters.Add("@id", MySqlDbType.Decimal).Value = id

                SQLCommand.ExecuteNonQuery()


                Dim conent As String = "تم تعديل حالة حجز المراجع  : " & tb_name.Text & " الى حالة  " & state & ""

                add_event(conn, s_update, conent)

                Me.Close()
            Catch ex As Exception

                MessageBox.Show(ex.Message)
            End Try

            conn.Close()
            fm_queue.search()
            'excute1("update queue set `test_time` = " & Date.Now.ToLongTimeString & " where id = " & id & "")

        Else
            excute1("update queue set `state` = '" & state & "' where id = " & id & "")
            fm_queue.search()

            conn = New MySqlConnection()
            conn.ConnectionString = serverInfo
            Try
                conn.Open()
                Dim conent As String = "تم ارجاع حالة حجز المراجع  : " & tb_name.Text & " الى حالة  " & state & ""

                add_event(conn, s_update, conent)

                conn.Close()

            Catch ex As Exception

            End Try

            '---------------------------


        End If


    End Sub
    Private Sub sound(ByVal Str As String)
        Dim Synth As New SpeechSynthesizer()

        Synth.SpeakAsyncCancelAll()

        Synth.SpeakAsync(Str)

    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick



        If currnet_state = ready_state Then
1:
            Try
                change_state(wait_state)
                fm_wait.tb_name_ready.Text = ""
                fm_wait.tb_number_ready.Text = ""
                fm_queue.search()

                Me.Close()
            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End Try



        Else
2:
            Try
                change_state(ready_state)
                fm_wait.tb_name_ready.Text = current_name
                fm_wait.tb_number_ready.Text = number

                fm_wait.ProgressPanel1.Caption = "يرجى حضور"
                If (BackgroundWorker1.IsBusy) Then

                Else
                    BackgroundWorker1.RunWorkerAsync()

                End If
            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 2

                End If
            End Try

        End If


    End Sub
    Sub PlayBackgroundSoundFile(ByVal sound_name As String)
        My.Computer.Audio.Play(Application.StartupPath + "\" + sound_name + ".wav",
            AudioPlayMode.WaitToComplete)



    End Sub





    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        sound("next")
        ' PlayBackgroundSoundFile("v")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        sound("next")

    End Sub



    Private Sub Combo_format()
        plan = New DataSet

        plan = getdatat1("select * from amount_plan")
        If plan.Tables(0).Rows.Count > 0 Then
            For i = 0 To plan.Tables(0).Rows.Count - 1
                cb_plan.Items.Add(plan.Tables(0).Rows(i).Item("title").ToString)
            Next
        End If
    End Sub

    Private Sub cb_plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plan.SelectedIndexChanged
        get_amount(cb_plan.SelectedItem.ToString)
        report_enable = 1



    End Sub

    Private Sub get_amount(ByVal title As String)
        Dim queue2 = New DataSet

        queue2 = getdatat1("select * from amount_plan where title ='" & title & "'")
        If plan.Tables(0).Rows.Count > 0 Then
            cb_plan.Text = queue2.Tables(0).Rows(0).Item("title").ToString()
            tb_munite.Text = queue2.Tables(0).Rows(0).Item("time").ToString()
            tb_amount.Text = queue2.Tables(0).Rows(0).Item("amount").ToString()
        Else

        End If

    End Sub
    Private Sub get_plan(ByVal title As String)
        Dim queue = New DataSet


        queue = getdatat1("SELECT * FROM queue WHERE test_type LIKE '" & title & "' ")
        If queue.Tables(0).Rows.Count > 0 Then
            tb_name.Text = current_name

            cb_plan.Text = queue.Tables(0).Rows(0).Item("test_type").ToString()
            tb_munite.Text = queue.Tables(0).Rows(0).Item("test_min").ToString()


        Else

        End If

    End Sub

    Private Sub TileItem8_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem8.ItemClick


        print_report()






        'queue.Tables("t_queue").Rows.Add(current_name, number, title, tb_amount.Text)



        'fm_win_report.Show()

        'Me.Close()

    End Sub
    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Private Sub enter_patient()


        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()


        Try
          

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "UPDATE queue SET `time` = @time , `state` = @state  WHERE id = @id"

            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
            SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = entered_state
            SQLCommand.Parameters.Add("@id", MySqlDbType.Decimal).Value = id

            SQLCommand.ExecuteNonQuery()



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
            If tb_wieght.Text.Trim = "" Then
                SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = 0.0
            Else
                SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Convert.ToDecimal(tb_wieght.Text)
            End If

            SQLCommand.Parameters.Add("@age", MySqlDbType.Decimal).Value = GetCurrentAge(d)
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToShortDateString)
            SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = cb_plan.Text
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = tb_note.Text
            SQLCommand.Parameters.Add("@test_amount", MySqlDbType.Decimal).Value = Val(tb_amount.Text)

            Dim conent As String = "تم تحويل المراجع  : " & tb_name.Text & " الى الطبيب"
            add_event(conn, s_convert, conent)

            SQLCommand.ExecuteNonQuery()


            Me.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

        fm_queue.search()
        conn.Close()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
1:
        If tb_wieght.Text.Trim = "" Then
            tb_wieght.Text = "0.00"
        End If
        Try
            If cb_plan.Text.Trim <> "" Then
                'If report_enable = 1 Then
                '    print_report()
                'End If
                fm_wait.ProgressPanel1.Caption = "دخول الى الطبيب"
                enter_patient()
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

    Private Sub print_report()
1:
        Try
            Dim query = "select patient.name as current_name , queue.`date` as date , queue.test_type as type  , queue.test_amount as amount  , queue.booking_number as number  from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"

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

    Private Sub tb_munite_TextChanged(sender As Object, e As EventArgs) Handles tb_munite.TextChanged

    End Sub
End Class