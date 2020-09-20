Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel

Partial Public Class fm_queue

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub fm_queue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub
    Sub Default_StyleChanged(sender As Object, e As EventArgs)
        Settings.Default.Skin = UserLookAndFeel.Default.SkinName
        Settings.Default.Save()
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim p As New Patient(1)
        'p.f10 = "f10
        'p.delete()

  
   

        tb_user.Caption = user.name






        Me.RibbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False
        Me.RibbonControl2.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False

        UserLookAndFeel.Default.SkinName = My.Settings.Skin


        formatlist()



        search()


        'excute1("insert into queue (`note`,patient_id,state) values ('1',1,0)")


        'conn = New MySqlConnection()
        'conn.ConnectionString = serverInfo
        'Try
        '    conn.Open()
        '    excute2("insert into queue (`note`,patient_id,state) values ('1',1,0)", conn)
        '    excute2("insert into queue (`note`,patient_id,state) values ('1',1,0)", conn)
        '    conn.Close()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed " + myerror.Message)

        'End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

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

    End Sub

    Public Sub search()
1:

        Try


            '  Dim s As String = "select queue.id as queueID  , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` = '" & dt_queue.Value.ToShortDateString & "' and queue.state <>'" & entered_state & "' and patient.id = queue.patient_id order by queue.id"
            Dim s As String = "select * , queue.id as queueID  , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` = '" & dt_queue.Value.ToShortDateString & "' and patient.id = queue.patient_id order by queue.id"
            Dim DataSet = getdatat1(s)
            Dim c_enter = 0
            Dim time As New DateTimePicker
            br_count1.Caption = DataSet.Tables(0).Rows.Count.ToString
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


                If DataSet.Tables(0).Rows(i).Item("state").ToString = "إستلام" Then
                    lv_queue.Items(i).BackColor = Color.LightGreen
                    c_enter = c_enter + 1
                Else
                    lv_queue.Items(i).BackColor = Color.LightPink

                End If

            Next

            l_entered.Text = c_enter.ToString


        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub search2()
1:

        Try


            '  Dim s As String = "select queue.id as queueID  , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` = '" & dt_queue.Value.ToShortDateString & "' and queue.state <>'" & entered_state & "' and patient.id = queue.patient_id order by queue.id"
            Dim s As String = "select * , queue.id as queueID  , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE queue.`date` < '" & DateTimePicker1.Value.ToShortDateString & "' and queue.state = 'انتظار' and patient.id = queue.patient_id order by queue.id"
            Dim DataSet = getdatat1(s)
            Dim c_enter = 0
            Dim time As New DateTimePicker
            br_count1.Caption = DataSet.Tables(0).Rows.Count.ToString
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


                If DataSet.Tables(0).Rows(i).Item("state").ToString = "إستلام" Then
                    lv_queue.Items(i).BackColor = Color.LightGreen
                    c_enter = c_enter + 1
                Else
                    lv_queue.Items(i).BackColor = Color.LightPink

                End If

            Next

            l_entered.Text = c_enter.ToString


        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub lv_queue_DoubleClick(sender As Object, e As EventArgs)
        If lv_queue.SelectedItems.Count = 1 Then
            fm_queue_option.id = lv_queue.SelectedItems.Item(0).SubItems(6).Text
            fm_queue_option.current_name = lv_queue.SelectedItems.Item(0).SubItems(2).Text
            fm_queue_option.currnet_state = lv_queue.SelectedItems.Item(0).SubItems(5).Text
            fm_queue_option.title = lv_queue.SelectedItems.Item(0).SubItems(8).Text
            fm_queue_option.number = lv_queue.SelectedItems.Item(0).Text
            fm_queue_option.Show()

        End If
    End Sub

    Private Sub lv_queue_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub hgh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        fm_add_patient.Show()
        Me.Hide()

    End Sub

    Private Sub p_fingerPrint_Click(sender As Object, e As EventArgs) Handles p_fingerPrint.Click
        fm_show_patients.Show()
        Me.Hide()


    End Sub

    Private Sub lv_queue_DoubleClick1(sender As Object, e As EventArgs) Handles lv_queue.DoubleClick

        If lv_queue.SelectedItems.Count = 1 Then
            If lv_queue.SelectedItems.Item(0).SubItems(5).Text = entered_state Then
                MessageBox.Show("المريض في الفحص الان")
                Exit Sub

            End If
            fm_queue_option.id = lv_queue.SelectedItems.Item(0).SubItems(6).Text
            fm_queue_option.current_name = lv_queue.SelectedItems.Item(0).SubItems(2).Text
            fm_queue_option.currnet_state = lv_queue.SelectedItems.Item(0).SubItems(5).Text
            fm_queue_option.title = lv_queue.SelectedItems.Item(0).SubItems(8).Text
            fm_queue_option.number = lv_queue.SelectedItems.Item(0).Text
            fm_queue_option.tb_patient_id.Text = lv_queue.SelectedItems.Item(0).SubItems(1).Text

            fm_queue_option.Show()

        End If
    End Sub

    Private Sub lv_queue_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lv_queue.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        dt_queue.Value = Date.Now.AddDays(1)


        search()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        dt_queue.Value = Date.Now


        search()
    End Sub

    Private Sub dt_queue_ValueChanged(sender As Object, e As EventArgs) Handles dt_queue.ValueChanged
        search()
    End Sub

    Private Sub تعديلالحجزToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلالحجزToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count = 1 Then

            fm_add_queue.tb_id.Text = lv_queue.SelectedItems.Item(0).SubItems(6).Text
            fm_add_queue.tb_patient_id.Text = lv_queue.SelectedItems.Item(0).SubItems(1).Text
            fm_add_queue.tb_patient_name.Text = lv_queue.SelectedItems.Item(0).SubItems(2).Text
            fm_add_queue.dt_queue.Value = Convert.ToDateTime(lv_queue.SelectedItems.Item(0).SubItems(4).Text)

            fm_add_queue.Show()




        End If

    End Sub


    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs) Handles RibbonControl2.Click

    End Sub

    Private Sub تعديلالاسمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلالاسمToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            Try
                fm_add_patient.Close()

            Catch ex As Exception

            End Try
            Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).SubItems(1).Text)
            fm_add_patient.tb_id.Text = id.ToString

            fm_add_patient.Show()

        End If











    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub الغائالحجزToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الغائالحجزToolStripMenuItem.Click
        Try
            change_state(cancel_state)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub change_state(state As String)
        If lv_queue.SelectedItems.Count > 0 Then
            Dim id As Int32 = Convert.ToInt16(lv_queue.SelectedItems.Item(0).SubItems(6).Text)

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


                    '   Dim conent As String = "تم تعديل حالة حجز المراجع  : " & tb_name.Text & " الى حالة  " & state & ""

                    ' add_event(conn, s_update, conent)

                    Me.Close()
                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                End Try

                conn.Close()
                search()
                'excute1("update queue set `test_time` = " & Date.Now.ToLongTimeString & " where id = " & id & "")


        End If


    End Sub

    Private Sub عرضملفالمراجعToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not is_doctor() Then
            MessageBox.Show("يرجى الدخول بحساب طبيب")
            Exit Sub

        End If
        Try
            If lv_queue.SelectedItems.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).SubItems(1).Text)
                fm_doctor_main.patient_name = lv_queue.SelectedItems.Item(0).SubItems(2).Text
                fm_doctor_main.patient_id = id
                fm_doctor_main.select_one()
                fm_doctor_main.Show()

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub print_report()
        If lv_queue.SelectedItems.Count > 0 Then
1:
            Try
                Dim query As String = "select * , queue.id as fesha_id ,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  queue.id = " & __(lv_queue.SelectedItems(0).SubItems(6).Text) & " and patient.id = queue.patient_id"

                'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
                Dim fm = New fm_report_viewr

                fm.ds = getdatat1(query)

                fm.Show()

            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End Try

        End If

    End Sub

    Private Sub طباعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةToolStripMenuItem.Click
        print_report()
    End Sub

    Private Sub DateTimePicker1_KeyUp(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyUp
        search2()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        search2()
    End Sub

    Private Sub الغاءحجزهذاالزبونToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الغاءحجزهذاالزبونToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            If no_item_in_dept(__(lv_queue.SelectedItems(0).SubItems(1).Text)) Then
                If MessageBox.Show("هل تريد الغاء الحجز ؟", "تأكيد", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    Dim p As New Patient(__(lv_queue.SelectedItems(0).SubItems(1).Text))
                    p.delete()
                    Dim que As New Queue()
                    que.id = __(lv_queue.SelectedItems(0).SubItems(6).Text)
                    que.delete()
                    search()

                End If

            Else
                MessageBox.Show("هذا الزبون لدية عقد بيع")
            End If
        End If

    End Sub

    Private Function no_item_in_dept(p_id As Integer) As Boolean
        Dim D As New DataSet
        D = getdatat1("select * from dept where user_id = " & p_id & "")
        If D.Tables(0).Rows.Count = 0 Then
            Return True

        Else
            Return False
        End If
    End Function

    Private Sub حذفهذهالفيشةفقطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفهذهالفيشةفقطToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then

            If MessageBox.Show("هل تريد حذف الفيشة ؟", "تأكيد", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

                Dim que As New Queue()
                que.id = __(lv_queue.SelectedItems(0).SubItems(6).Text)
                que.delete()
                search()

            End If


        End If

    End Sub

    Private Sub tb_id_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

   

    Private Sub feash_search()

        fm_fesha.tb_fesha_id.Text = tb_fesha_id.Text
        Dim fesha As New Queue(__(tb_fesha_id.Text))
        If fesha.id = -1 Then
           
        Else
            fm_fesha.fesha = fesha

            fm_fesha.Show()

        End If


    End Sub

    Private Sub tb_fesha_id_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_fesha_id.KeyUp
        If e.KeyCode = Keys.Enter Then
            feash_search()
            tb_fesha_id.Text = ""

        End If
    End Sub

  
    Private Sub tb_fesha_id_TextChanged(sender As Object, e As EventArgs) Handles tb_fesha_id.TextChanged

    End Sub
End Class
