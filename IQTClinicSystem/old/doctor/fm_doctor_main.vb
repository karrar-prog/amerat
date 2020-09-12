Imports System.IO
Imports AForge.Video.DirectShow
Imports AForge.Video
Imports MySql.Data.MySqlClient

Public Class fm_doctor_main
    Dim dt_enterd_select As New DateTimePicker
    Public patient_id As Integer = 0
    Public patient_name As String
    Public visit_id As Integer = 0
    Public age As Integer
    Public whieght As Integer
    Dim plan As New DataSet
    Dim c_kedny As Integer

    Dim c_child As Integer
    Dim c_recome As Integer

    Dim w As Int32 = 0


    Public CAMERA As VideoCaptureDevice
    Public bmp As Bitmap
    Public cameras As VideoCaptureDeviceForm

    Private Sub fm_doctor_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

        Try
            CAMERA.Stop()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fm_doctor_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        formatlist_enterd(lv_enterd)
        formatlists(lv_visit)
        formatlists(lv_ar_report)
        formatlists(lv_en_report)
        formatlists(lv_hospital_enter)
        formatlists(lv_operation)
        formatlists(lv_treat)
        formatlist_suggest(lv_suggest)
        formatlist_category(lv_treatment_category)
        fill_category(lv_treatment_category)
        formatlist_treatment(lv_treatment)
        formatlist_treat_table(lv_treat_table)
        get_suggested("")

        Timer1.Start()
        change_visit_list()

        '----------------------
        p_print.Hide()

        format_list_images()
        fill_combo_hospital_enter()

        serjery_notification()

        '  get_plans()

        '-------------------
        '  cam_sitting()


        'GroupControl4.Hide()
        'GroupControl5.Hide()
        'GroupControl6.Hide()
        'GroupControl7.Hide()
        'GroupControl8.Hide()
        'GroupControl3.Hide()
        'GroupControl11.Hide()


    End Sub

    Private Sub fill_list()
1:


        Try
            Dim ds_enterd As New DataSet

            ds_enterd = getdatat1("select patient.id as id ,queue.test_type as test_type , 	queue.booking_number as booking_number ,queue.`time` as time , patient.name as name  from queue , patient where queue.`state` like '1' and queue.`date` = '" & dt_date_enterd.Value.ToShortDateString & "' and patient.id = queue.patient_id order by queue.`time` desc")

            If lv_enterd.Items.Count <> ds_enterd.Tables(0).Rows.Count Then
                c_kedny = 0
                c_child = 0
                c_recome = 0

                Beep()
                lv_enterd.Items.Clear()
                tb_number.Caption = ds_enterd.Tables(0).Rows.Count.ToString & " العدد الكلي "
                For i = 0 To ds_enterd.Tables(0).Rows.Count - 1
                    lv_enterd.Items().Add(ds_enterd.Tables(0).Rows(i).Item("id").ToString)
                    lv_enterd.Items(i).SubItems.Add(ds_enterd.Tables(0).Rows(i).Item("name").ToString)
                    lv_enterd.Items(i).SubItems.Add(ds_enterd.Tables(0).Rows(i).Item("booking_number").ToString)

                    lv_enterd.Items(0).ForeColor = Color.Red


                    If ds_enterd.Tables(0).Rows(i).Item("test_type").ToString = "مراجعة" Then
                        c_recome = c_recome + 1
                        tb_recome.Caption = c_recome.ToString & " مراجعة  "

                    End If


                    If ds_enterd.Tables(0).Rows(i).Item("test_type").ToString = "اطفال" Then
                        c_child = c_child + 1
                        tb_c_child.Caption = c_child.ToString & " اطفال "
                    End If


                    If ds_enterd.Tables(0).Rows(i).Item("test_type").ToString = "فحص" Then
                        c_child = c_child + 1
                        tb_c_child.Caption = c_child.ToString & " فحص "
                    End If


                    If ds_enterd.Tables(0).Rows(i).Item("test_type").ToString = "كلى" Then
                        c_kedny = c_kedny + 1
                        tb_c_kedny.Caption = c_kedny.ToString & " كلى  "
                    End If

                    If ds_enterd.Tables(0).Rows(i).Item("test_type").ToString = "قسطرة قنوات صفراوية" Then
                        c_kedny = c_kedny + 1
                        tb_c_kedny.Caption = c_kedny.ToString & " قسطرة قنوات صفراوية  "
                    End If


                Next


            End If



        Catch ex As Exception
            Timer1.Stop()

            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                Timer1.Start()

                GoTo 1

            End If
        End Try


    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fill_list()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Timer1.Start()

        Catch ex As Exception

        End Try
        change_visit_list()


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        dt_date_enterd.Value = Date.Now
        fill_list()
    End Sub

    Private Sub lv_enterd_DoubleClick(sender As Object, e As EventArgs) Handles lv_enterd.DoubleClick

    End Sub



    Private Sub dt_date_enterd_ValueChanged(sender As Object, e As EventArgs) Handles dt_date_enterd.ValueChanged
        fill_list()

    End Sub

    Private Sub change_visit_list()

        Timer1.Stop()
1:

        Try
            fill_list()
            Timer1.Interval = Convert.ToInt32(n_timer.Value) * 1000
            Timer1.Start()
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                Timer1.Interval = Convert.ToInt32(n_timer.Value) * 1000
                GoTo 1

            End If

        End Try


    End Sub

    Private Sub TabNavigationPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage1.Paint

    End Sub

    Private Sub lv_enterd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_enterd.SelectedIndexChanged
        If lv_enterd.SelectedItems.Count > 0 Then
            patient_id = Convert.ToInt32(lv_enterd.SelectedItems.Item(0).Text)

            select_one()

        End If




    End Sub

    Private Sub get_visits()

        Dim visit As New Visit

        visit.patient_id = patient_id

        fill_visits(lv_visit, visit)
        Try
            tb_name.Text = lv_enterd.SelectedItems.Item(0).SubItems(1).Text
        Catch ex As Exception
            Try
                tb_name.Text = patient_name
            Catch ex2 As Exception

            End Try

        End Try

        Dim dt As New DateTimePicker
        If lv_visit.Items.Count > 0 Then
            dt.Value = Convert.ToDateTime(lv_visit.Items(0).SubItems(1).Text)
        End If

        set_visit_value(patient_id, dt)




    End Sub
    Private Sub get_treats()
        Dim treat As New Treat
        treat.patient_id = patient_id
        tb_treat_content.Text = ""
        tb_treat_date.Text = ""
        tb_treat_id.Text = ""
        tb_treat_note.Text = ""
        tb_treat_other.Text = ""
        tb_treat_time.Text = ""
        lv_treat_table.Items.Clear()

        fill_treats(lv_treat, treat)
        format_templet_treat(cb_templet_treat)
        'format_templet_treat(tb_hospital)
    End Sub

    Private Sub get_hospital_enter()
        Dim hospital_enter As New HospitalEnter
        hospital_enter.patient_id = patient_id

        fill_hospital_enter(lv_hospital_enter, hospital_enter)
    End Sub

    Public Sub get_medical_operation()
        Dim obj As New MedicalOperation
        obj.patient_id = patient_id
        fill_medical_operation(lv_operation, obj)
    End Sub

    Private Sub get_report()
        Dim obj As New Report
        obj.patient_id = patient_id
        fill_reports(lv_ar_report, lv_en_report, obj)


    End Sub

    Private Sub lv_visit_DoubleClick(sender As Object, e As EventArgs) Handles lv_visit.DoubleClick

    End Sub

    Private Sub lv_visit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_visit.SelectedIndexChanged
1:

        Try
            put_visit_info()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub set_visit_value(patient_id As Integer, dt_enterd_select As DateTimePicker)



        clear_visit_value()

        Dim Visit As New Visit(patient_id, dt_enterd_select)
        tb_age.Text = Visit.age.ToString
        tb_note.Text = Visit.note
        tb_patient_number.Text = Visit.patient_id.ToString
        tb_test_amont.Text = Visit.test_amount.ToString
        If Visit.weight.ToString.Trim = "" Then
            tb_wieght.Text = "0.0"
        Else
            tb_wieght.Text = Visit.weight.ToString
        End If

        tb_test_type.Text = Visit.test_type
        tb_visit_number.Text = Visit.id.ToString
        tb_visit_date.Text = Visit.d_date.ToShortDateString
        visit_id = Convert.ToInt32(Visit.id.ToString)
        'Dim p As New Patient(patient_id)
        'tb_wieght.Text = p.wieght.ToString







    End Sub

    Private Sub clear_visit_value()
        tb_age.Text = ""
        tb_note.Text = ""
        tb_patient_number.Text = ""
        tb_test_amont.Text = ""
        tb_wieght.Text = ""
        tb_test_type.Text = ""
        tb_visit_number.Text = ""
        tb_visit_date.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        save()

    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lv_treatment_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treatment_category.SelectedIndexChanged
1:

        Try
            If lv_treatment_category.SelectedItems.Count > 0 Then
                tb_search_name_treatment.Text = ""
                tb_categort.Text = ""
                tb_categort.Text = lv_treatment_category.SelectedItems.Item(0).Text()

                get_treatment()


            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub get_treatment()

1:
        Try
            Dim obj As New Treatment
            obj.name = tb_search_name_treatment.Text


            obj.category = tb_categort.Text
            fill_treatment_lv(lv_treatment, obj)
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub tb_search_name_treatment_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search_name_treatment.EditValueChanged
        get_treatment()

    End Sub

    Private Sub lv_treatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treatment.SelectedIndexChanged

1:
        Try
            l_message.Hide()

            Dim date_of_visit As String = ""
            Try
                date_of_visit = lv_visit.Items(0).SubItems(1).Text
            Catch ex As Exception
                date_of_visit = ""
            End Try

            If date_of_visit.Trim = "" Then
                'MessageBox.Show("لايوجد مراجع")


                'Exit Sub

            End If
            set_in_last_visit()


            If lv_treatment.SelectedItems.Count > 0 Then
                fm_dose.tb_visit_number.Text = visit_id.ToString
                fm_dose.tb_wieght.Text = tb_wieght.Text
                fm_dose.tb_treatment_name.Text = lv_treatment.SelectedItems.Item(0).Text
                fm_dose.tb_age.Text = tb_age.Text
                fm_dose.tb_patient_number.Text = tb_patient_number.Text
                fm_dose.tb_f1.Text = lv_treatment.SelectedItems.Item(0).SubItems(5).Text
                fm_dose.tb_f2.Text = lv_treatment.SelectedItems.Item(0).SubItems(6).Text



                If fm_dose.tb_f2.Text.Trim = "" Then
                    fm_dose.tb_f2.Text = "0.000"
                End If
                set_children()
                set_children_kedny()
                set_adult()
                set_adult_kedny()




                fm_dose.Show()
                fm_dose.tb_note.Text = lv_treatment.SelectedItems.Item(0).SubItems(7).Text
                lv_treatment.SelectedItems.Clear()

            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub set_in_last_visit()
        If lv_visit.Items.Count > 0 Then
            Dim dt As New DateTimePicker
            Dim current_dt As New DateTimePicker
            current_dt.Value = Convert.ToDateTime(tb_visit_date.Text)





            dt.Value = Convert.ToDateTime(lv_visit.Items.Item(0).SubItems(1).Text)
            If dt.Value.ToShortDateString <> current_dt.Value.ToShortDateString Then
                set_visit_value(patient_id, dt)
            End If

        End If
    End Sub

    Private Sub TabNavigationPage2_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage2.Paint

    End Sub

    Private Sub lv_treat_table_DoubleClick(sender As Object, e As EventArgs) Handles lv_treat_table.DoubleClick
        l_message.Hide()
        If lv_treat_table.SelectedItems.Count > 0 Then

            fm_edit_treatment.tb_treatment_name.Text = lv_treat_table.SelectedItems.Item(0).SubItems(1).Text
            fm_edit_treatment.tb_selected_money.Value = __(lv_treat_table.SelectedItems.Item(0).SubItems(2).Text)
            fm_edit_treatment.tb_note.Text = lv_treat_table.SelectedItems.Item(0).SubItems(3).Text

            fm_edit_treatment.Show()


        End If
    End Sub

    Private Sub lv_treat_table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treat_table.SelectedIndexChanged

    End Sub

    Private Sub set_children()


        Dim Str As String = lv_treatment.SelectedItems.Item(0).SubItems(1).Text
        Dim strarr() As String
        strarr = Str.Split("||")

        Try
            fm_dose.tb_children.Text = strarr(2)
            fm_dose.tb_child_take_paln.Text = strarr(0)

        Catch ex As Exception
            fm_dose.tb_children.Text = "0.000"
            fm_dose.tb_child_take_paln.Text = ""

        End Try

    End Sub

    Private Sub set_children_kedny()
        fm_dose.tb_children_kedny.Text = lv_treatment.SelectedItems.Item(0).SubItems(2).Text

        Dim Str As String = lv_treatment.SelectedItems.Item(0).SubItems(2).Text
        Dim strarr() As String
        strarr = Str.Split("||")

        Try
            fm_dose.tb_children_kedny.Text = strarr(2)
            fm_dose.tb_child_kedny_take_paln.Text = strarr(0)

        Catch ex As Exception
            fm_dose.tb_children_kedny.Text = "0.000"
            fm_dose.tb_child_kedny_take_paln.Text = " "
        End Try
    End Sub

    Private Sub set_adult()
        fm_dose.tb_adult.Text = lv_treatment.SelectedItems.Item(0).SubItems(3).Text


        Dim Str As String = lv_treatment.SelectedItems.Item(0).SubItems(3).Text
        Dim strarr() As String
        strarr = Str.Split("||")

        Try
            fm_dose.tb_adult.Text = strarr(2)
            fm_dose.tb_adult_take_paln.Text = strarr(0)

        Catch ex As Exception
            fm_dose.tb_adult.Text = "0.000"
            fm_dose.tb_adult_take_paln.Text = " "
        End Try

    End Sub

    Private Sub set_adult_kedny()
        fm_dose.tb_adult_kedny.Text = lv_treatment.SelectedItems.Item(0).SubItems(4).Text


        Dim Str As String = lv_treatment.SelectedItems.Item(0).SubItems(4).Text
        Dim strarr() As String
        strarr = Str.Split("||")

        Try
            fm_dose.tb_adult_kedny.Text = strarr(2)
            fm_dose.tb_adult_kedny_take_paln.Text = strarr(0)

        Catch ex As Exception
            fm_dose.tb_adult_kedny.Text = "0.000"
            fm_dose.tb_adult_take_paln.Text = " "
        End Try

    End Sub

    Private Sub lv_treat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treat.SelectedIndexChanged

1:
        Try
            l_message.Hide()
            If lv_treat.SelectedItems.Count > 0 Then
                get_treat_and_treat_table(Convert.ToInt32(lv_treat.SelectedItems.Item(0).Text))


            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lv_treat_table.Items.Clear()

        tb_treat_id.BackColor = Color.LightGray
        p_print.Hide()
        tb_treat_id.Text = "0"
        tb_treat_content.Text = ""
        tb_treat_date.Text = ""
        tb_treat_note.Text = ""
        tb_treat_other.Text = ""
        tb_treat_time.Text = ""




        'Try
        '    If Date.Now.ToShortDateString = Convert.ToDateTime(lv_treat.Items(0).SubItems(1).Text).ToShortDateString Then
        '        MessageBox.Show("المراجع لدية وصفة لهذة الزيارة")
        '        get_treat_and_treat_table(Convert.ToInt32(lv_treat.Items(0).Text))

        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("لايوجد مراجع")
            Exit Sub

        End If

        If tb_treat_id.Text.Trim = "" Then
            tb_treat_id.Text = "0"
        End If
        If check_treat() Then
            Dim t As New Treat
            Dim d_date, t_time As New DateTimePicker
            t.id = Convert.ToInt32(tb_treat_id.Text)
            t.note = tb_treat_note.Text '
            t.other = tb_treat_other.Text
            t.time = t_time.Value
            t.d_date = d_date.Value
            t.visit_id = Convert.ToInt32(tb_visit_number.Text)

            t.patient_id = Convert.ToInt32(tb_patient_number.Text)
            t.content = tb_treat_content.Text
            t.save()

            p_print.Show()


        End If



    End Sub

    Private Function check_treat() As Boolean
        If tb_patient_number.Text = "" Then
            MessageBox.Show("لايوجد مراجع")
            Return False

        End If
        If lv_treat_table.Items.Count < 1 Then
            MessageBox.Show("لايوجد دواء")
            Return False
        End If

        Return True

    End Function

    Private Sub get_treat_and_treat_table(ByVal id As Integer)

        Dim t As New Treat(id)

        t.fill_treat_info()
        p_print.Show()






    End Sub

    Private Sub cb_templet_treat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_templet_treat.SelectedIndexChanged
        If cb_templet_treat.Text <> s_temp Then
            If MessageBox.Show("هل انت متأكد من استبدال الوصفة الحالية ؟", "وصفة جاهزة", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                put_template(cb_templet_treat.Text)

            End If

        End If


    End Sub

    Private Sub put_template(template_title As String)
1:

        Try
            Dim dt As New DateTimePicker
            Dim ds_treat_table As New DataSet
            ds_treat_table = getdatat1("select * from template_treatment where template like '" & template_title & "' ")
            lv_treat_table.Items.Clear()
            If ds_treat_table.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds_treat_table.Tables(0).Rows.Count - 1

                    lv_treat_table.Items.Add(ds_treat_table.Tables(0).Rows(i).Item("id").ToString)
                    lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("treatment").ToString)
                    lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("dose").ToString)
                    lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("take_number").ToString)
                    lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("note").ToString)




                Next

            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        save_new_temp()
        format_templet_treat(cb_templet_treat)

    End Sub




    Private Sub p_print_Click(sender As Object, e As EventArgs) Handles p_print.Click
1:
        Try
            If tb_treat_id.Text.Trim <> "" And tb_treat_id.Text <> "0" Then

                print_treat_report()



            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub print_treat_report()

        Dim query As String = "SELECT patient.name as p_name , patient.id as p_id , treat.id as t_id , treat_table.treatment as t_name , treat_table.dose as t_dose , treat_table.take_number as t_take_number  , treat.other as t_other , treat.time as t_time , treat.content as t_content , treat_table.note as t_note , treat.date as t_date , patient.code as  p_code , patient.gender as p_gender  , visit.age as p_age " +
          "  FROM patient , visit , treat , treat_table WHERE treat.id = " & tb_treat_id.Text & " and patient.id = treat.patient_id and treat.id = treat_table.treat_id and patient.id = visit.patient_id  and visit.id = treat.visit_id  "
        Dim f As New fm_x_viewer_treat

        f.ds = getdatat1(query)
        f.Show()


    End Sub

    Private Sub put_visit_info()
        If lv_visit.SelectedItems.Count > 0 Then
            Dim dt As New DateTimePicker
            dt.Value = Convert.ToDateTime(lv_visit.SelectedItems.Item(0).SubItems(1).Text)

            set_visit_value(patient_id, dt)
        End If

    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click

        If lv_visit.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل تريد الحذف ؟", "رسالة تأكيد ", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim visit As New Visit
                visit.id = Convert.ToInt32(tb_visit_number.Text)
                visit.delete()
                get_visits()
            End If

        End If


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If lv_treat.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل تريد الحذف ؟", "رسالة تأكيد ", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim treat As New Treat
                treat.id = Convert.ToInt32(tb_treat_id.Text)
                treat.delete()
                get_treats()

            End If

        End If
    End Sub

    Private Sub tb_categort_EditValueChanged(sender As Object, e As EventArgs) Handles tb_categort.EditValueChanged

    End Sub

    Private Sub GroupControl9_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl9.Paint

    End Sub

    Private Sub ch_review_CheckedChanged(sender As Object, e As EventArgs) Handles ch_review.CheckedChanged
        fun_review()


    End Sub

    Private Sub fun_review()
        If ch_review.Checked Then
            tb_treat_other.Text = "المراجعة بعد " & (NumericUpDown1.Value).ToString & " يوم - المصادف " & Date.Now.AddDays(NumericUpDown1.Value).ToShortDateString
        Else
            tb_treat_other.Text = ""
        End If


    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        fun_review()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("اختر اسم مراجع من القائمة على اليمين")
            Exit Sub

        End If
        Try
            fm_camera.re = from_doctor
            fm_camera.patient_id = Convert.ToInt32(tb_patient_number.Text)

            fm_camera.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("اختر مريض من القائمة على اليمين")
        End Try

    End Sub

    Private Sub format_list_images()
        lv_images.View = View.Details
        lv_images.Columns.Add("عنوان صورة", 0)
        lv_images.Columns.Add("الاسم", 200)
        lv_images.Columns.Add("الاسم", 30)

    End Sub


    Private Sub show_images()
        Dim new_path = images_path & "\p" & tb_patient_number.Text

        Dim proc As New System.Diagnostics.Process()
        For Each sf In Directory.GetFiles(new_path & "\")
            Try
                proc = Process.Start(sf, "فتح الصورة")
            Catch ex As Exception
                MessageBox.Show("لاتوجد صور")


            End Try
        Next



    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("اختر اسم مراجع من القائمة على اليمين")
            Exit Sub

        End If
        Try
            get_images()
        Catch ex As Exception
        End Try


        'Try
        '    show_images()
        'Catch ex As Exception
        '    MessageBox.Show("لاتوجد صور")
        'End Try

    End Sub

    Private Sub get_images()
        lv_images.Items.Clear()

        Dim lv_temlpate As New ListView
        lv_temlpate.View = View.Details
        lv_temlpate.Columns.Add("عنوان صورة", 0)
        lv_temlpate.Columns.Add("الاسم", 250)
        lv_temlpate.Columns.Add("الاسم", 250)
        Dim str() As String


        Dim new_path = images_path & "\p" & tb_patient_number.Text
        For Each sf In Directory.GetFiles(new_path & "\")
            str = Split(sf, "im")
            lv_temlpate.Items.Add(sf)
            Try
                lv_temlpate.Items(lv_temlpate.Items.Count - 1).SubItems.Add(str(1))
            Catch ex As Exception
                lv_temlpate.Items(lv_temlpate.Items.Count - 1).SubItems.Add("pasted picture")
            End Try
            lv_temlpate.Items(lv_temlpate.Items.Count - 1).SubItems.Add("" & lv_temlpate.Items.Count)

        Next

        Dim c = lv_temlpate.Items.Count - 1

        For i = 0 To lv_temlpate.Items.Count - 1
            lv_images.Items.Add(lv_temlpate.Items(c).Text)
            lv_images.Items(i).SubItems.Add(lv_temlpate.Items(c).SubItems(1).Text)
            lv_images.Items(i).SubItems.Add(lv_temlpate.Items(c).SubItems(2).Text)
            c = c - 1

        Next
    End Sub

    Private Sub lv_images_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_images.SelectedIndexChanged
        If lv_images.SelectedItems.Count > 0 Then
            Dim image_path = lv_images.SelectedItems.Item(0).Text

            Dim proc As New System.Diagnostics.Process()

            proc = Process.Start(image_path, "فتح الصورة")

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub p_patient_Click(sender As Object, e As EventArgs) Handles p_patient.Click
        If tb_patient_number.Text.Trim <> "" Then
            fm_add_patient.re = from_doctor

            Dim patient As New Patient(Convert.ToInt32(tb_patient_number.Text))

            fm_add_patient.tb_id.Text = patient.id.ToString
            fm_add_patient.tb_name.Text = patient.name
            fm_add_patient.tb_note.Text = patient.note
            fm_add_patient.nu_house_price.Value = patient.house_price
            Try
                fm_add_patient.dt_birthdate.Value = patient.birthdate
                fm_add_patient.dt_register_date.Value = patient.register_date

            Catch ex As Exception

            End Try

            fm_add_patient.tb_wieght.Text = patient.wieght
            fm_add_patient.tb_phone.Text = patient.phone
            fm_add_patient.tb_ref_by.Text = patient.ref_by
            fm_add_patient.cb_plan.Text = patient.diagonosis




            fm_add_patient.tb_wieght.Text = patient.f1
            fm_add_patient.nu_blok_num.Value = __(patient.f2)
            fm_add_patient.num_home_num.Value = __(patient.f3)
        
            fm_add_patient.tb_f6.Text = patient.f6
            fm_add_patient.tb_f7.Text = patient.f7
            fm_add_patient.tb_f8.Text = patient.f8
          

            fm_add_patient.Show()

            Me.Hide()



        End If
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        pring_values()


    End Sub

    Private Sub lv_ar_report_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_ar_report.SelectedIndexChanged
        If lv_ar_report.SelectedItems.Count > 0 Then
            Dim id = Convert.ToInt32(lv_ar_report.SelectedItems.Item(0).Text)
            tb_ar_r_id.Text = id.ToString

            Dim ar_report As New Report(id, s_arbic)

            tb_ar_name.Text = ar_report.patient_name
            tb_diagnosis.Text = ar_report.disease
            tb_ar_date.Text = ar_report.diagnosis_date.ToString
            tb_ar_note.Text = ar_report.note
            tb_ar_other.Text = ar_report.other
            tb_ar_table_treat.Text = ar_report.treatment




        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        fun_save(s_arbic)

    End Sub
    Private Sub print_report(ByVal lang As String)


1:
        Try
            Dim id As Integer

            If lang = s_arbic Then
                id = Convert.ToInt32(tb_ar_r_id.Text)
                fm_x_m_report_viewer.filePath = Application.StartupPath & "/ar_m_report.repx"
            Else
                id = Convert.ToInt32(tb_en_r_id.Text)
                fm_x_m_report_viewer.filePath = Application.StartupPath & "/en_m_report.repx"
            End If
            Dim query = "select * from medical_report where id = " & id & ""
            fm_x_m_report_viewer.ds = getdatat1(query)

            fm_x_m_report_viewer.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub

    Private Sub tb_ar_r_id_TextChanged(sender As Object, e As EventArgs) Handles tb_ar_r_id.TextChanged
        If tb_ar_r_id.Text.Trim = "" Then
            p_ar_print.Hide()
        Else
            p_ar_print.Show()

        End If
    End Sub

    Private Sub clear_previus_values()

        tb_ar_r_id.Text = ""
        tb_ar_name.Text = ""
        tb_ar_table_treat.Text = ""
        tb_ar_date.Text = ""



        tb_ser_content.Text = ""
        tb_ser_date.Text = ""
        tb_ser_id.Text = ""
        tb_ser_note.Text = ""
        tb_ser_other.Text = ""
        tb_ser_time.Text = ""
        tb_ser_title.Text = ""



    End Sub

    Private Sub p_ar_print_Click(sender As Object, e As EventArgs) Handles p_ar_print.Click
        If tb_ar_r_id.Text.Trim <> "" Then
            print_report(s_arbic)

        End If

    End Sub

    Private Sub pring_values()

        tb_ar_r_id.Text = ""
        tb_en_r_id.Text = ""


        tb_ar_table_treat.Text = ""
        tb_en_table_treat.Text = ""
        tb_table_tratment_enter.Text = ""

        If lv_visit.Items.Count > 0 Then
            tb_ar_date.Text = lv_visit.Items(lv_visit.Items.Count - 1).SubItems(1).Text
            tb_en_date.Text = lv_visit.Items(lv_visit.Items.Count - 1).SubItems(1).Text
        End If
        tb_ar_name.Text = tb_name.Text & " , العمر" & tb_age.Text
        tb_en_name.Text = tb_name.Text & " , age " & tb_age.Text
        tb_enter_name.Text = tb_name.Text & " , العمر " & tb_age.Text

        tb_en_name.BackColor = Color.LightPink


        If lv_treat_table.Items.Count > 0 Then

            For i = 0 To lv_treat_table.Items.Count - 1
                tb_ar_table_treat.Text = tb_ar_table_treat.Text & i + 1 & " - " & lv_treat_table.Items(i).SubItems(1).Text & vbNewLine
                tb_en_table_treat.Text = tb_en_table_treat.Text & i + 1 & " - " & lv_treat_table.Items(i).SubItems(1).Text & vbNewLine
                tb_table_tratment_enter.Text = tb_table_tratment_enter.Text & i + 1 & " - " & lv_treat_table.Items(i).SubItems(1).Text & vbNewLine

            Next

        End If
        If tb_patient_number.Text.Trim <> "" Then
            Dim id = Convert.ToInt32(tb_patient_number.Text.Trim)
            Dim p As New Patient(id)
            tb_diagnosis.Text = p.diagonosis
            tb_diagnosis_en.Text = p.diagonosis
            tb_diagnosis_en.BackColor = Color.LightPink
            tb_enter_diagnosed.Text = p.diagonosis



            'sergury text
            tb_ser_other.Text = p.diagonosis
            tb_ser_other.BackColor = Color.LightGreen


            tb_ser_note.Text = tb_note.Text



        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        pring_values()

    End Sub

    Private Sub lv_en_report_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_en_report.SelectedIndexChanged
        If lv_en_report.SelectedItems.Count > 0 Then
            Dim id = Convert.ToInt32(lv_en_report.SelectedItems.Item(0).Text)
            tb_en_r_id.Text = id.ToString

            Dim en_report As New Report(id, s_engilsh)


            tb_en_name.Text = en_report.patient_name

            tb_diagnosis_en.Text = en_report.disease
            tb_en_date.Text = en_report.diagnosis_date.ToString
            tb_en_note.Text = en_report.note
            tb_en_other.Text = en_report.other
            tb_en_table_treat.Text = en_report.treatment




        End If
    End Sub

    Private Sub fun_save(ByVal lang As String)

        If tb_patient_number.Text.Trim = "" Then
            Exit Sub

        End If

        Try
            Dim r As New Report
            If lang = s_arbic Then
                r.treatment = tb_ar_table_treat.Text
                r.lang = lang
                r.note = tb_ar_note.Text
                r.visit_id = Convert.ToInt32(tb_visit_number.Text)
                r.time = Date.Now
                r.disease = tb_diagnosis.Text
                r.other = tb_ar_other.Text
                r.patient_id = Convert.ToInt32(tb_patient_number.Text)
                r.d_date = Date.Now
                r.patient_name = tb_ar_name.Text
                Try
                    r.diagnosis_date = Convert.ToDateTime(tb_ar_date.Text)
                Catch ex As Exception
                    r.diagnosis_date = Date.Now
                End Try
            Else
                r.treatment = tb_en_table_treat.Text
                r.lang = lang
                r.note = tb_en_note.Text
                r.visit_id = Convert.ToInt32(tb_visit_number.Text)
                r.time = Date.Now
                r.disease = tb_diagnosis_en.Text
                r.other = tb_en_other.Text
                r.patient_id = Convert.ToInt32(tb_patient_number.Text)
                r.d_date = Date.Now
                r.patient_name = tb_en_name.Text
                Try
                    r.diagnosis_date = Convert.ToDateTime(tb_en_date.Text)
                Catch ex As Exception
                    r.diagnosis_date = Date.Now
                End Try
            End If

            r.save_new()
            get_report()

            'ارسال التشخيص الى معلومات المريض
            Dim id = Convert.ToInt32(tb_patient_number.Text.Trim)
            Dim p As New Patient(id)
            p.diagonosis = tb_diagnosis.Text
            p.save()


            MessageBox.Show(" تم الحفظ")
        Catch ex As Exception
            MessageBox.Show("لم يتم الحفظ")
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        fun_save(s_engilsh)
    End Sub

    Private Sub حذفToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem1.Click
        If MessageBox.Show("هل انت متأكد من الحذف", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Try
                If lv_en_report.SelectedItems.Count > 0 Then
                    Dim id = Convert.ToInt32(lv_en_report.SelectedItems.Item(0).Text)
                    Dim re As New Report
                    re.id = id
                    re.delete()
                    get_report()
                End If
            Catch ex As Exception
                MessageBox.Show("لم يتم الحذف")
            End Try
        End If


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("هل انت متأكد من الحذف", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Try
                If lv_ar_report.SelectedItems.Count > 0 Then
                    Dim id = Convert.ToInt32(lv_ar_report.SelectedItems.Item(0).Text)
                    Dim re As New Report
                    re.id = id
                    re.delete()
                    get_report()
                End If
            Catch ex As Exception
                MessageBox.Show("لم يتم الحذف")
            End Try
        End If


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If tb_en_r_id.Text.Trim <> "" Then
            print_report(s_engilsh)

        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        pring_values()

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub fill_combo_hospital_enter()
        tb_hospital.Items.Add("مدينة الصدر الطبيه")
        tb_hospital.Items.Add("مستشفى الحكيم التعليمي")
        tb_hospital.Items.Add("مستشفى الزهراء التعليمي")
        tb_hospital.Items.Add("مستشفى الصدر التعليمي")
        tb_hospital.Items.Add("مستشفى الامام علي -ع")
        tb_hospital.Items.Add("مركز الديلزة وامراض الدم")
        tb_hospital.Items.Add(" مستشفى الحياة التخصصي الاهلي")
        tb_hospital.Items.Add("مستشفى بلال الاهلي")
        tb_hospital.Items.Add("مستشفى الامير الاهلي")
        tb_hospital.Items.Add("عيادة النجف الجراحية اليومية")


        tb_hospital.SelectedItem = tb_hospital.Items(0)

        tb_department.Items.Add("مركز الجهاز الهضمي")
        tb_department.Items.Add("الجناح الخاص ط3 او ط6")
        tb_department.Items.Add("ردهة الجراحة رجال")
        tb_department.Items.Add("ردهة الجراحة نساء")
        tb_department.Items.Add("طوارء الجراحية")
        tb_department.Items.Add("طوارئ الباطنية")
        tb_department.Items.Add("الطوارئ")
        tb_department.Items.Add("وحدة الكلى")
        tb_department.Items.Add("الخدج المنزلي")
        tb_department.Items.Add("ردهه الالطفال")
        tb_department.Items.Add("وحدة الكلى")
        tb_department.Items.Add("وحدة الكلى")
        tb_department.Items.Add("مركز امراض وزرع الكلى")

    End Sub

    Private Sub lv_hospital_enter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_hospital_enter.SelectedIndexChanged
        If lv_hospital_enter.SelectedItems.Count > 0 Then

            Try
                Dim id = Convert.ToInt32(lv_hospital_enter.SelectedItems.Item(0).Text)
                Dim h As New HospitalEnter(id)
                tb_en_r_id.Text = id.ToString

                tb_table_tratment_enter.Text = h.treatment
                tb_enter_name.Text = h.patient_name
                tb_enter_diagnosed.Text = h.disease
                tb_enter_id.Text = h.id.ToString
                tb_enter_note.Text = h.note
                tb_hospital.Text = h.hospital
                tb_department.Text = h.department


            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub tb_wieght_EditValueChanged(sender As Object, e As EventArgs) Handles tb_wieght.EditValueChanged

    End Sub

    Private Sub tb_wieght_GotFocus(sender As Object, e As EventArgs) Handles tb_wieght.GotFocus


    End Sub

    Private Sub tb_age_EditValueChanged(sender As Object, e As EventArgs) Handles tb_age.EditValueChanged

    End Sub

    Private Sub tb_age_GotFocus(sender As Object, e As EventArgs) Handles tb_age.GotFocus

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        lv_treat_table.Items.Clear()

        tb_treat_id.BackColor = Color.LightGray
        p_print.Hide()
        tb_treat_id.Text = "0"
        tb_treat_content.Text = ""
        tb_treat_date.Text = ""
        tb_treat_note.Text = ""
        tb_treat_other.Text = ""
        tb_treat_time.Text = ""


        fm_anylises.Show()


    End Sub

    Private Sub get_plans()

        plan = New DataSet

        plan = getdatat1("select * from amount_plan")

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        tb_wieght.Text = TextEdit1.Text
        Try
            Dim tal = Val(tb_tal.Text) / 100
            tb_result_tal.Text = Convert.ToString(Val(tb_wieght.Text) / (tal * tal))
            tb_result_tal.Text = Convert.ToString(Math.Round(Val(tb_result_tal.Text), 2))
            If (Val(tb_result_tal.Text) >= 18.5 And Val(tb_result_tal.Text) <= 25) Then
                tb_result_tal.BackColor = Color.Green

            Else
                tb_result_tal.BackColor = Color.Red

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged

        tb_age.Text = TextEdit3.Text

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("اختر اسم مراجع من القائمة على اليمين")
            Exit Sub

        End If

        save_new_image()
    End Sub
    Private Sub save_new_image()
        OpenFileDialog1.Title = "Please select a image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All files|*.*|png|*.png|jpg|*.jpg"
        Dim path As String



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path = OpenFileDialog1.FileName

            If path.Trim <> "" Then
                Dim new_path = images_path & "\p" & tb_patient_number.Text
                If (Not System.IO.Directory.Exists(new_path)) Then
                    System.IO.Directory.CreateDirectory(new_path)
                End If

                Dim new_file_path = new_path & "\" & "imatt " & generate_image_id() & ".png"

                If Not System.IO.File.Exists(new_file_path) = True Then
                    File.Copy(path, new_file_path, True)
                End If

            Else
                MessageBox.Show("لم تقم باختيار صورة")
            End If

        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("لم يتم اختيار مراجع")
            Exit Sub
        End If
1:

        Try
            Dim h As New HospitalEnter
            h.d_date = Date.Now
            h.department = tb_department.Text
            h.patient_name = tb_enter_name.Text

            h.hospital = tb_hospital.Text
            h.patient_id = Convert.ToInt32(tb_patient_number.Text)
            h.visit_id = Convert.ToInt32(tb_visit_number.Text)
            h.treatment = tb_table_tratment_enter.Text
            h.time = Date.Now

            h.note = tb_enter_note.Text
            h.department = tb_department.Text
            h.hospital = tb_hospital.Text
            h.disease = tb_enter_diagnosed.Text
            h.save_new()
            get_hospital_enter()


        Catch ex As Exception



        End Try

    End Sub

    Private Sub حذفToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem2.Click
        If lv_hospital_enter.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل تريد الحذف ؟ ", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim id = Convert.ToInt32(lv_hospital_enter.SelectedItems.Item(0).Text)
                Dim h As New HospitalEnter(id)
                h.delete()
                get_hospital_enter()


            End If
            Try


            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            tb_treat_note.Text = "يرجى جلب الادوية وادخالها الى الطبيب ,لمعاينة النوعية ويمكن للسكرتير الشرح بعدها في حالة الازدحام فقط "
        Else
            tb_treat_note.Text = " "
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If tb_enter_id.Text.Trim <> "" Then
            print_report()

        End If

    End Sub

    Private Sub print_report()
        If tb_en_r_id.Text.Trim = "" Then
            Exit Sub

        End If
1:
        Try
            Dim id As Integer

            id = Convert.ToInt32(tb_en_r_id.Text)
            fm_x_report_h_enter.filePath = Application.StartupPath & "/h_enter.repx"

            Dim query = "select * from hospital_enter where id = " & id & ""
            fm_x_report_h_enter.ds = getdatat1(query)

            fm_x_report_h_enter.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub حذفالعلاجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالعلاجToolStripMenuItem.Click
        If lv_treat_table.SelectedItems.Count > 0 Then
            lv_treat_table.Items.RemoveAt(lv_treat_table.SelectedIndices(0))

        End If
    End Sub

    Private Sub BarHeaderItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        fm_monitoring.Show()

    End Sub



    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Picture_mo.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub BarHeaderItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem4.ItemClick
        cam_sitting()
    End Sub
    Private Sub cam_sitting()
        Try
            CAMERA.Stop()

        Catch ex As Exception

        End Try




        cameras = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()

        End If
    End Sub

    Private Sub RibbonStatusBar1_Click(sender As Object, e As EventArgs) Handles RibbonStatusBar1.Click

    End Sub

    Private Sub Picture_mo_Click(sender As Object, e As EventArgs) Handles Picture_mo.Click
        fm_monitoring.Show()
        fm_monitoring.Hide()
        fm_monitoring.Show()

    End Sub

    Private Sub SkinRibbonGalleryBarItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SkinRibbonGalleryBarItem1.ItemClick

    End Sub

    Private Sub BarHeaderItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem2.ItemClick





        cam_sitting()
        'Try
        '    CAMERA.Stop()

        'Catch ex As Exception

        'End Try




        'cameras = New VideoCaptureDeviceForm

        'If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    CAMERA = cameras.VideoDevice
        '    AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        '    CAMERA.Start()

        'End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("اختر اسم مراجع من القائمة على اليمين")
            Exit Sub

        End If
        Dim new_path = images_path & "\p" & tb_patient_number.Text
        If (Not System.IO.Directory.Exists(new_path)) Then
            System.IO.Directory.CreateDirectory(new_path)

        End If


        Process.Start("explorer.exe", new_path)


    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_en_other.Text = ""

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        tb_ar_other.Text = ""

    End Sub

    Private Sub GroupControl10_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl10.Paint

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If tb_name.Text.Trim = "" Then
            MessageBox.Show("اختر اسم مراجع من القائمة على اليمين")
            Exit Sub
        End If
        fm_add_cergury.tb_patient_number.Text = tb_patient_number.Text
        fm_add_cergury.tb_name.Text = tb_name.Text
        fm_add_cergury.tb_note.Text = tb_note.Text



        fm_add_cergury.Show()



    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If lv_operation.SelectedItems.Count > 0 Then
            Dim m As New MedicalOperation
            m.id = Convert.ToInt32(lv_operation.SelectedItems.Item(0).Text)
            If MessageBox.Show("هل تريد المسح", "رسالة تأكيد", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                If m.delete() Then
                    get_medical_operation()

                Else
                    MessageBox.Show("لم يتم المسح")
                End If
            End If

        Else
            MessageBox.Show("اختر من القائمة")
        End If

    End Sub

    Private Sub lv_operation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_operation.SelectedIndexChanged
        If lv_operation.SelectedItems.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(lv_operation.SelectedItems.Item(0).Text)
            Dim m As New MedicalOperation(id)
            tb_ser_content.Text = m.content
            tb_ser_date.Text = m.d_date.ToShortDateString
            tb_ser_time.Text = m.time.ToShortTimeString
            tb_ser_id.Text = m.id.ToString
            tb_ser_other.Text = m.other
            tb_ser_title.Text = m.title
            tb_ser_note.Text = m.note
            If m.treatment = "نعم" Then
                r_yes.Checked = True
            Else
                r_no.Checked = True


            End If


        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("اختر مراجع من القائمة على اليمين")
            Exit Sub
        End If


        If tb_ser_id.Text.Trim = "" Then
            If MessageBox.Show("هل تريد اضافة حجز عملية جديد", "رسالة تأكيد", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                fm_add_cergury.tb_patient_number.Text = tb_patient_number.Text
                fm_add_cergury.Show()
            End If


            Exit Sub

        End If


        Dim m As New MedicalOperation

        m.id = Convert.ToInt32(tb_ser_id.Text)
        m.patient_id = Convert.ToInt32(tb_patient_number.Text)
        m.content = tb_ser_content.Text
        m.d_date = Convert.ToDateTime(tb_ser_date.Text)
        m.time = Convert.ToDateTime(tb_ser_time.Text)
        m.other = tb_ser_other.Text
        m.title = tb_ser_title.Text
        m.note = tb_ser_note.Text
        If r_no.Checked Then

            m.treatment = r_no.Text
        Else
            m.treatment = r_yes.Text
        End If


        If m.save() Then
            l_ser_message.Text = "  تم التعديل بنجاح  " & Date.Now.ToLongTimeString
        Else
            l_ser_message.Text = "  فشل في التعديل  " & Date.Now.ToLongTimeString

        End If



    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        tb_note.Text = ""

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        pring_values()

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        fm_anylises.Show()

    End Sub

    Private Sub TabNavigationPage3_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage3.Paint

    End Sub

    Public Sub select_one()

1:

        TextEdit1.Text = "0"
        TextEdit3.Text = "0"
        tb_wieght.Text = "0"
        tb_age.Text = "0"

        Try

            'patient_id = Convert.ToInt32(lv_enterd.SelectedItems.Item(0).Text)
            Try
                lv_enterd.BackColor = Color.Snow
                lv_enterd.ForeColor = Color.Black
                lv_enterd.SelectedItems.Item(0).ForeColor = Color.Black
            Catch ex As Exception

            End Try

            dt_enterd_select.Value = dt_date_enterd.Value
            get_visits()
            get_treats()
            get_hospital_enter()
            get_medical_operation()
            get_report()
            clear_previus_values()



            Try
                p_patient.Image = Image.FromFile(images_path & "\im" & tb_patient_number.Text & ".png")

            Catch ex As Exception
                p_patient.Image = My.Resources.name_card_icon


            End Try
            pic_view1.Hide()
            pic_view2.Hide()
            pic_view3.Hide()

            Try
                get_images()
                Dim image_path = ""
                If lv_images.Items.Count > 0 Then
                    pic_view1.Show()

                    image_path = lv_images.Items.Item(0).Text
                    pic_view1.Image = Image.FromFile(image_path)
                    pic_view1.Tag = image_path
                Else
                    pic_view1.Hide()

                End If
                If lv_images.Items.Count > 1 Then
                    pic_view2.Show()

                    image_path = lv_images.Items.Item(1).Text
                    pic_view2.Image = Image.FromFile(image_path)
                    pic_view2.Tag = image_path
                Else
                    pic_view2.Hide()
                End If
                If lv_images.Items.Count > 2 Then
                    pic_view3.Show()
                    image_path = lv_images.Items.Item(2).Text
                    pic_view3.Image = Image.FromFile(image_path)
                    pic_view3.Tag = image_path
                Else
                    pic_view3.Hide()

                End If


            Catch ex As Exception


            End Try


        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub BarStaticItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem1.ItemClick
        GroupControl4.Hide()
        GroupControl5.Hide()
        GroupControl6.Hide()
        GroupControl7.Hide()
        GroupControl8.Hide()
        GroupControl11.Hide()


    End Sub

    Private Sub اضهار_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles اضهار.ItemClick
        GroupControl4.Show()
        GroupControl5.Show()
        GroupControl6.Show()
        GroupControl7.Show()
        GroupControl8.Show()
        GroupControl11.Show()


    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If tb_patient_number.Text.Trim <> "" Then
            fm_add_patient.re = from_doctor

            Dim patient As New Patient(Convert.ToInt32(tb_patient_number.Text))

            fm_add_patient.tb_id.Text = patient.id.ToString
            fm_add_patient.tb_name.Text = patient.name
            fm_add_patient.tb_note.Text = patient.note
            Try
                fm_add_patient.dt_birthdate.Value = patient.birthdate
                fm_add_patient.dt_register_date.Value = patient.register_date

            Catch ex As Exception

            End Try

            fm_add_patient.tb_wieght.Text = patient.wieght
            fm_add_patient.tb_phone.Text = patient.phone
            fm_add_patient.tb_ref_by.Text = patient.ref_by
            fm_add_patient.cb_plan.Text = patient.diagonosis




            fm_add_patient.tb_wieght.Text = patient.f1
            fm_add_patient.nu_blok_num.Value = __(patient.f2)
            fm_add_patient.num_home_num.Value = __(patient.f3)

            'fm_add_patient.tb_f5.Text = patient.f5
            fm_add_patient.tb_f6.Text = patient.f6
            fm_add_patient.tb_f7.Text = patient.f7
            fm_add_patient.tb_f8.Text = patient.f8

            fm_add_patient.tb_note.Text = patient.note



            fm_add_patient.Show()

            Me.Hide()



        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEdit3_KeyUp(sender As Object, e As KeyEventArgs) Handles TextEdit3.KeyUp
        If TextEdit3.Text.Trim = "" Then
            tb_age.Text = "0"
        End If

    End Sub

    Private Sub TextEdit1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyUp
        If TextEdit1.Text.Trim = "" Then
            tb_wieght.Text = "0.0"
        End If

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        fm_dose.new_treat = 1
        fm_dose.tb_treatment_name.Focus()

        fm_dose.Show()
    End Sub

    Private Sub pic_view1_Click(sender As Object, e As EventArgs) Handles pic_view1.Click
        Dim image_path = pic_view1.Tag.ToString


        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start(image_path, "فتح الصورة")
    End Sub

    Private Sub pic_view2_Click(sender As Object, e As EventArgs) Handles pic_view2.Click
        Dim image_path = pic_view2.Tag.ToString


        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start(image_path, "فتح الصورة")
    End Sub

    Private Sub pic_view3_Click(sender As Object, e As EventArgs) Handles pic_view3.Click
        Dim image_path = pic_view3.Tag.ToString


        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start(image_path, "فتح الصورة")
    End Sub

    Private Sub tb_tal_EditValueChanged(sender As Object, e As EventArgs) Handles tb_tal.EditValueChanged
        Try
            Dim tal = Val(tb_tal.Text) / 100
            tb_result_tal.Text = Convert.ToString(Val(tb_wieght.Text) / (tal * tal))
            tb_result_tal.Text = Convert.ToString(Math.Round(Val(tb_result_tal.Text), 2))
            If (Val(tb_result_tal.Text) >= 18.5 And Val(tb_result_tal.Text) <= 25) Then
                tb_result_tal.BackColor = Color.Green

            Else
                tb_result_tal.BackColor = Color.Red

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click

        If tb_patient_number.Text.Trim = "" Then
            MessageBox.Show("لايوجد مراجع")
            Exit Sub

        End If

        If tb_treat_id.Text.Trim = "" Then
            tb_treat_id.Text = "0"
        End If
        If check_treat() Then
            Dim t As New Treat
            Dim d_date, t_time As New DateTimePicker
            t.id = Convert.ToInt32(tb_treat_id.Text)
            t.note = tb_treat_note.Text '
            t.other = tb_treat_other.Text
            t.time = t_time.Value
            t.d_date = d_date.Value
            t.visit_id = Convert.ToInt32(tb_visit_number.Text)

            t.patient_id = Convert.ToInt32(tb_patient_number.Text)
            t.content = tb_treat_content.Text
            t.save()

            p_print.Show()


        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
1:
        Try
            If tb_treat_id.Text.Trim <> "" And tb_treat_id.Text <> "0" Then

                print_treat_report()



            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

   
    Private Sub TabNavigationPage6_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage6.Paint

    End Sub

    Private Sub tb_note_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_note.KeyUp
        'If e.KeyValue = Keys.Insert Then
        '    put_value()

        'End If

        If e.KeyValue = Keys.Enter Then
            save()
        End If
    End Sub

    Private Sub tb_note_TextChanged(sender As Object, e As EventArgs) Handles tb_note.TextChanged
        'Dim last_word As String = ""
        'If tb_note.Text.Trim <> "" Then


        '    last_word = tb_note.Text.Split(" ").Last

        'End If
        'get_suggested(last_word)
    End Sub
    Private Sub get_suggested(last_word As String)
        Dim suggest As New Suggest
        Dim d As New DataSet
        lv_suggest.Items.Clear()
        d = suggest.title_search(last_word)
        If d.Tables(0).Rows.Count > 0 Then
            For i = 0 To d.Tables(0).Rows.Count - 1
                lv_suggest.Items.Add(d.Tables(0).Rows(i).Item("id").ToString)
                lv_suggest.Items(i).SubItems().Add(d.Tables(0).Rows(i).Item("title").ToString)
            Next
        End If


    End Sub

    Private Sub save()
1:

        Try
            Dim visit As New Visit
            If tb_visit_number.Text.Trim <> "" Then
                visit.id = Convert.ToInt32(tb_visit_number.Text)


                visit.age = Convert.ToDecimal(tb_age.Text)
                visit.note = tb_note.Text
                visit.weight = Convert.ToDecimal(tb_wieght.Text)

                If visit.update() Then
                    l_visit_mesaage.Text = "  تم التعديل بنجاح  " & Date.Now.ToLongTimeString

                End If

            Else
                l_visit_mesaage.Text = "  يرجى اختيار زيارة  " & Date.Now.ToLongTimeString

            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub save_new_temp()
        Try
            Dim title As String = InputBox("ادخل اسم الوصفة ")
            If title.Trim <> "" Then
                Dim t As New Treat
1:

                Try
                    t.save_in_templete(title)
                Catch ex As Exception
                    If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                        GoTo 1

                    End If
                End Try

            Else
                MessageBox.Show("يرجى ادخال الاسم")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub delete_temp(ByVal s As String)
        Try
            Dim title As String = s
            If title.Trim <> "" Then
                Dim t As New Treat
1:

                Try
                    t.delete_templete(title)
                Catch ex As Exception
                    If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                        GoTo 1

                    End If
                End Try

            Else
                MessageBox.Show("يرجى ادخال الاسم")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub حذفهذهالوصفةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفهذهالوصفةToolStripMenuItem.Click
        If (cb_templet_treat.Text.Trim <> "") Then

            delete_temp(cb_templet_treat.Text)
            format_templet_treat(cb_templet_treat)
        End If

    End Sub

  
    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub lv_suggest_DoubleClick(sender As Object, e As EventArgs) Handles lv_suggest.DoubleClick

        Try
            If lv_suggest.Items.Count > 0 Then

                Try
                    tb_note.Text = tb_note.Text & vbNewLine & lv_suggest.SelectedItems.Item(0).SubItems(1).Text.ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                get_suggested("")

                tb_suggest_search.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lv_suggest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_suggest.SelectedIndexChanged
      

    End Sub

    Private Sub tb_suggest_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_suggest_search.KeyUp
    
    End Sub

    Private Sub tb_suggest_search_TextChanged(sender As Object, e As EventArgs) Handles tb_suggest_search.TextChanged
        Try
            Dim last_word As String = ""
            If tb_suggest_search.Text.Trim <> "" Then

                last_word = tb_suggest_search.Text


            End If
            get_suggested(last_word)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub put_value()
        tb_suggest_search.Text = ""
        If lv_suggest.Items.Count > 0 Then
            tb_note.Text = tb_note.Text & vbNewLine & " " & lv_suggest.Items.Item(0).SubItems(1).Text.ToString & vbNewLine

        End If
    End Sub

  
    Private Sub حذقToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذقToolStripMenuItem.Click
        If lv_suggest.SelectedItems.Count > 0 Then
            Try
                Dim s = New Suggest(Int32.Parse(lv_suggest.SelectedItems.Item(0).Text))
                s.delete()
                get_suggested("")
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub اضافةجديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةجديدToolStripMenuItem.Click
        Dim title As String
        title = InputBox("ادخل النص", "اضافة مقترحات")
        If (title.Trim <> "") Then
            Dim s = New Suggest
            s.title = title
            s.save()
            get_suggested("")

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles btn_notification.Click
        fm_show_sergury.Show()

    End Sub

    Private Sub serjery_notification()

        fm_show_sergury.tb_date.Value = Date.Now.AddDays(0)
        fm_show_sergury.DateTimePicker1.Value = Date.Now.AddDays(2)
        fm_show_sergury.MySearch()

    End Sub

End Class