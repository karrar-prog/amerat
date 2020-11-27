Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel

Public Class fm_add_collection_fesha
    Public p_id As Integer = 0
    Dim id_list As String
    Dim id_list_int As List(Of Integer)
    Dim my_p As New Patient
    Private Sub fm_add_collection_fesha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatlist()
        search()
        put_values(p_id)
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
        If tb_number.Text.Trim = "1" Then

            tb_note.Text = "يعتمد هذا الوصل خلال فترة اقصاها 7 أيام من تأريخ اصداره وبعدها يعتبر لاغياً لحجز الدار"
        Else

            tb_note.Text = ""
        End If
        Me.CenterToScreen()

        Combo_format()
     
        If hasPermission(i_edit_customer) Then
            tb_patient_name.ReadOnly = False

        End If
    End Sub
    Private Sub formatlist()
        lv_queue.View = View.Details

        lv_queue.Columns.Add("رقم الدفعة", 0)
        lv_queue.Columns.Add("رقم العقد", 0)
        lv_queue.Columns.Add("اسم الزبون", 300)
        lv_queue.Columns.Add("المبلغ", 140)
        lv_queue.Columns.Add("تأريخ الارسال", 120)
        lv_queue.Columns.Add("الحالة", 120)
        lv_queue.Columns.Add("تسلسل الفيشة", 100)
        lv_queue.Columns.Add("تأريخ الاستلام", 230)
        lv_queue.Columns.Add("تسلسل الدفعة", 0)
        lv_queue.Columns.Add("", 200)
        lv_queue.Columns.Add("", 200)
        lv_queue.Columns.Add("", 200)

    End Sub

    Public Sub search()
1:

        Try


            '  Dim s As String = "select queue.id as queueID  , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` = '" & dt_queue.Value.ToShortDateString & "' and queue.state <>'" & entered_state & "' and patient.id = queue.patient_id order by queue.id"
            Dim s As String = "select * , queue.id as queueID ,queue.f1 as f1 ,queue.f2 as f2 , queue.f3 as f3 , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` = '" & dt_queue.Value.ToShortDateString & "' and queue.f1 <> 'متعددة' and queue.state <> 'إستلام' and patient.id = queue.patient_id order by queue.id"
            Dim DataSet = getdatat1(s)
            Dim c_enter = 0
            Dim time As New DateTimePicker

            Dim td_date As New DateTimePicker
            lv_queue.Items.Clear()
            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1






                lv_queue.Items.Add(DataSet.Tables(0).Rows(i).Item("booking_number").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("patient_id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("amount").ToString)
                td_date.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("date").ToString)
                lv_queue.Items(i).SubItems.Add(td_date.Value.ToShortDateString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("state").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("recived_date").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("dept_id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)


                If DataSet.Tables(0).Rows(i).Item("state").ToString = "إستلام" Then
                    lv_queue.Items(i).BackColor = Color.LightGreen
                    c_enter = c_enter + 1
                Else
                    lv_queue.Items(i).BackColor = Color.LightPink

                End If

            Next



        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub put_values(p_id As Integer)
        Dim p As New Patient(p_id)
        tb_patient_name.Text = p.name
        tb_patient_id.Text = p.id.ToString
        my_p = p


    End Sub

    Private Sub lv_queue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_queue.SelectedIndexChanged
        tb_fesha_amount.Text = "0"

        If lv_queue.SelectedItems.Count > 0 Then
            For i = 0 To lv_queue.SelectedItems.Count - 1
                tb_fesha_amount.Text = (__(tb_fesha_amount.Text) + __(lv_queue.SelectedItems(i).SubItems(3).Text)).ToString
            Next
            tb_amount_text.Text = ToArabicLetter(__(tb_fesha_amount.Text))
        End If
    End Sub

    Private Sub حفظوطباعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حفظوطباعةToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count < 2 Then
            MessageBox.Show("لايمكن انشاء فيشة متعدة لاقل من 2 فيشة")

        Else
            save_fesha()

        End If
    End Sub

    Private Sub save_fesha()
        id_list = get_id_list()
        id_list_int = get_id_list_int()

        Dim fesha As New Queue()

        If cb_plan.Text.Trim = "" Then
            MessageBox.Show("اختر اسم المصرف  ")

            Exit Sub

        End If

        Dim q As New Queue
        q.q_date = dt_queue.Value

        q.q_time = Date.Now
        q.patient_id = Convert.ToInt32(tb_patient_id.Text)
        q.note = tb_note.Text
        q.state = "انتظار"
        q.test_amount = tb_amount.Text
        q.test_min = tb_munite.Text
        q.test_type = cb_plan.Text
        q.f2 = tb_patient_name.Text
        q.amount = __(tb_fesha_amount.EditValue.ToString)
        q.amount_text = tb_amount_text.Text
        q.f3 = id_list.Trim

        q.booking_number = -1

        q.f1 = tb_dept_title.Text


        q.dept_id = -1


        If q.save() Then



            'Dim id As Integer = get_last_id(q.patient_id)
            print_report(id_list)
            Me.Close()
        Else
            MessageBox.Show("لم  تتم العملية")

        End If


    End Sub
    Private Sub Combo_format()
        Dim plan = New DataSet

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
    Private Sub print_report(ids As String)
        'Combine your Values wrapping each value in single quotes'
        Dim values = String.Join(",", id_list_int.Select(Function(f) String.Format("{0}", f)).ToArray())

1:
        Try
            Dim sql As String = String.Format("select * , queue.id as fesha_id , queue.note as fesha_note ,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where queue.id IN ({0})  and patient.id = queue.patient_id order by queue.id", values)

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_print_fesha_collection
            Dim q As New Queue(id_list, 1, 1)

            fm.p1 = "C" & q.id.ToString
            fm.p2 = tb_patient_name.Text
            fm.p3 = my_p.phone
            fm.p4 = q.test_type
            fm.p5 = q.test_amount
            fm.p6 = q.test_min
            fm.p7 = q.amount
            fm.p8 = q.amount_text

            fm.p9 = q.note
            fm.p10 = q.q_date.ToString




            fm.ds = getdatat1(sql)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Function get_id_list() As String
        Dim ids As String = ""

        For i = 0 To lv_queue.SelectedItems.Count - 1
            ids = ids & "-" & lv_queue.SelectedItems(i).SubItems(6).Text
        Next
        Return ids
    End Function

    Private Function get_id_list_int() As List(Of Integer)
        Dim ids As New List(Of Integer)

        For i = 0 To lv_queue.SelectedItems.Count - 1
            ids.Add(__(lv_queue.SelectedItems(i).SubItems(6).Text))
        Next
        Return ids
    End Function


End Class