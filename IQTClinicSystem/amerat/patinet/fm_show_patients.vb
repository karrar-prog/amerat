﻿Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel

Public Class fm_show_patients
    Dim re As String = ""
    Dim image_path As String = ""


    Private Sub fm_show_patients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If re = "" Then
            fm_main.Show()


        End If
    End Sub

    Private Sub fm_show_patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin

        Me.CenterToScreen()

        formatlist()
1:
        Try
            search()
            tb_user.Caption = user.name

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Private Sub formatlist()

        lv_queue.View = View.Details

        lv_queue.Columns.Add("رقم العقد", 122)
        lv_queue.Columns.Add("اسم الزبون", 250)
        lv_queue.Columns.Add("هاتف", 150)
        lv_queue.Columns.Add("بلوك", 110)
        lv_queue.Columns.Add("رقم الدار", 110)
        lv_queue.Columns.Add("المبلغ الكلي", 200)
        lv_queue.Columns.Add("تأريخ الشراء", 150)



    End Sub


    Public Sub search4()

1:
        Try
            Dim s As String
            If RadioButton2.Checked = True Then
                If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'  order by f2,f1,f3 limit " & num_limit.Value & ""
                Else

                    If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%'  and is_token like '%" & cb_plan.Text & "%'  order by f2,f1,f3  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' and  and is_token like '%" & cb_plan.Text & "%'    f2 like '%" & tb_f2.Text & "%'   order by f2,f1,f3  limit " & num_limit.Value & ""

                    End If

                End If
            Else
                If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'   and is_token like '%" & cb_plan.Text & "%'   order by id desc limit " & num_limit.Value & ""
                Else

                    If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' order by id desc  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' and  f2 like '%" & tb_f2.Text & "%'   order by id desc  limit " & num_limit.Value & ""

                    End If

                End If
            End If


            Dim DataSet = getdatat1(s)
            GridControl1.DataSource = DataSet.Tables(0)

            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_queue.Items.Clear()

            tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString


            If DataSet.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                    lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)

                    If DataSet.Tables(0).Rows(i).Item("deleted").ToString = "1" Then
                        lv_queue.Items(i).BackColor = Color.LightPink
                    End If
                    'lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try



    End Sub
    Public Sub search()

1:
        Try
            Dim s As String
            If RadioButton2.Checked = True Then
                If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'   order by f2,f1,f3 limit " & num_limit.Value & ""
                Else

                    If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%'  and is_token like '%" & cb_plan.Text & "%'  order by f2,f1,f3  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' and  and is_token like '%" & cb_plan.Text & "%'    f2 like '%" & tb_f2.Text & "%'   order by f2,f1,f3  limit " & num_limit.Value & ""

                    End If

                End If
            Else
                If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'   and is_token like '%" & cb_plan.Text & "%'   order by id desc limit " & num_limit.Value & ""
                Else

                    If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' order by id desc  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' and  f2 like '%" & tb_f2.Text & "%'   order by id desc  limit " & num_limit.Value & ""

                    End If

                End If
            End If


            Dim DataSet = getdatat1(s)
            GridControl1.DataSource = DataSet.Tables(0)

            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_queue.Items.Clear()

            tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString


            If DataSet.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                    lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)

                    If DataSet.Tables(0).Rows(i).Item("deleted").ToString = "1" Then
                        lv_queue.Items(i).BackColor = Color.LightPink
                    End If
                    'lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try



    End Sub


    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        search()
    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        search()
    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If e.KeyValue = Keys.Enter Then
            search()
        End If
    End Sub

    Private Sub lv_queue_DoubleClick(sender As Object, e As EventArgs) Handles lv_queue.DoubleClick


        'If lv_queue.SelectedItems.Count = 1 Then
        '    fm_add_queue.tb_patient_id.Text = lv_queue.SelectedItems.Item(0).Text

        '    fm_add_queue.tb_patient_name.Text = lv_queue.SelectedItems.Item(0).SubItems(1).Text
        '    fm_add_queue.Show()

        'End If


    End Sub

    Private Sub lv_queue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_queue.SelectedIndexChanged
        If lv_queue.SelectedItems.Count > 0 Then
            Try
                Dim id = __(lv_queue.SelectedItems.Item(0).Text)
                p_patient.Image = Image.FromFile(images_path & "\im" & id & ".png")
                image_path = images_path & "\im" & id & ".png"
            Catch ex As Exception
                p_patient.Image = Nothing

                image_path = ""
            End Try
        End If

    End Sub



    Private Sub عرضاوتعديلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضاوتعديلToolStripMenuItem.Click

        Try
            p_patient.Image.Dispose()

            p_patient.Image = Nothing
        Catch ex As Exception

        End Try


        If hasPermission("ادارة") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_queue.SelectedItems.Count > 0 Then

            Try
                fm_add_patient.Close()

            Catch ex As Exception

            End Try

            Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)
            fm_add_patient.tb_id.Text = id.ToString



            fm_add_patient.Show()
            fm_add_patient.re = "2"
            re = "2"
            Me.Close()



        End If
    End Sub

    Private Sub ارشفةبياناتالمراجعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارشفةبياناتالمراجعToolStripMenuItem.Click

        If hasPermission("حذف") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_queue.SelectedItems.Count = 0 Then
            Exit Sub

        End If


        Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)

        Dim patient As New Patient(id)
        If MessageBox.Show("هل تريد تعطيل الحساب؟", "يمكن تفعيلة في وقت لاحق", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = System.Windows.Forms.DialogResult.Yes Then
            patient.delete()
            search()
        End If



    End Sub

    Private Sub tb_id_EditValueChanged(sender As Object, e As EventArgs) Handles tb_id.EditValueChanged

    End Sub

    Private Sub search2()

        If tb_id.Text.Trim = "" Then
            search()
            Exit Sub
        End If

        Dim s As String = "select * from patient WHERE f3 like " & tb_id.Text & "  order by f2,f1,f3  limit " & num_limit.Value & ""

        Dim DataSet = getdatat1(s)
        Dim dt As New DateTimePicker
        Dim c As Integer
        tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

        lv_queue.Items.Clear()
        If DataSet.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)

                If DataSet.Tables(0).Rows(i).Item("deleted").ToString = "1" Then
                    lv_queue.Items(i).BackColor = Color.LightPink
                End If
            Next
        End If
    End Sub
    Private Sub search3()

        If tb_patient_id.Text.Trim = "" Then
            search()
            Exit Sub
        End If

        Dim s As String = "select * from patient WHERE id = " & tb_patient_id.Text & "  order by f2,f1,f3  limit " & num_limit.Value & ""

        Dim DataSet = getdatat1(s)
        Dim dt As New DateTimePicker
        Dim c As Integer
        tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

        lv_queue.Items.Clear()
        If DataSet.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)

                If DataSet.Tables(0).Rows(i).Item("deleted").ToString = "1" Then
                    lv_queue.Items(i).BackColor = Color.LightPink
                End If
            Next
        End If
    End Sub

    Private Sub tb_id_InvalidValue(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles tb_id.InvalidValue

    End Sub

    Private Sub tb_id_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_id.KeyUp
        If e.KeyCode = Keys.Enter Then
            search2()
            tb_id.Text = ""

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        search2()
    End Sub

    Private Sub اضافةحجزToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If lv_queue.SelectedItems.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)
            Dim patient As New Patient(id)
            fm_add_queue.tb_patient_id.Text = id.ToString

            fm_add_queue.tb_patient_name.Text = lv_queue.SelectedItems.Item(0).SubItems(1).Text
            fm_add_queue.Show()

        End If

    End Sub

    Private Sub اضافةحجزعمليةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةحجزعمليةToolStripMenuItem.Click
    

    End Sub

    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs) Handles RibbonControl2.Click

    End Sub

    Private Sub عرضالملفالشخصيToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not is_doctor() Then
            MessageBox.Show("يرجى الدخول بحساب طبيب")
            Exit Sub

        End If
        Try
            If lv_queue.SelectedItems.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)


                fm_doctor_main.lv_enterd.Items.Clear()

                fm_doctor_main.lv_enterd.Items().Add(id.ToString)
                fm_doctor_main.lv_enterd.Items(0).SubItems.Add(lv_queue.SelectedItems.Item(0).SubItems(1).Text)

                fm_doctor_main.lv_enterd.Items(0).ForeColor = Color.Red

                fm_doctor_main.tb_visit_date.Text = Date.Now.ToShortDateString

                fm_doctor_main.Show()
                fm_doctor_main.patient_name = lv_queue.SelectedItems.Item(0).SubItems(1).Text
                fm_doctor_main.patient_id = id
                fm_doctor_main.select_one()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        fm_add_patient.tb_name.Text = tb_name.Text
        fm_add_patient.Show()

    End Sub

    Private Sub tb_f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f1.SelectedIndexChanged
        search()
    End Sub

    Private Sub tb_f2_EditValueChanged(sender As Object, e As EventArgs) Handles tb_f2.EditValueChanged
        search()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If lv_queue.SelectedItems.Count > 0 Then

            Try
                Dim new_path = images_path & "\p" & __(lv_queue.SelectedItems.Item(0).Text)
                Process.Start("explorer.exe", new_path)


            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("اختر كتاب")
            Exit Sub

        End If
    End Sub

    Private Sub تفعيلالحسابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تفعيلالحسابToolStripMenuItem.Click
        If hasPermission("الغاء تفعيل الحسابات") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_queue.SelectedItems.Count = 0 Then
            Exit Sub

        End If


        Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)

        Dim patient As New Patient(id)
        If MessageBox.Show("هل تريد تفعيل هذا الحساب؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = System.Windows.Forms.DialogResult.Yes Then
            patient.undelete()
            search()
        End If


    End Sub

    Private Sub GroupControl6_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl6.Paint

    End Sub

    Private Sub اضافةملفاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةملفاتToolStripMenuItem.Click
        Try
            p_patient.Image.Dispose()

            p_patient.Image = Nothing
        Catch ex As Exception

        End Try
        If lv_queue.SelectedItems.Count > 0 Then
            fm_camera.patient_id = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)

            fm_camera.Show()
            fm_camera.re = "search"
        End If

    End Sub

    Private Sub p_patient_Click(sender As Object, e As EventArgs) Handles p_patient.Click
        Try
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(image_path, "فتح الصورة")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cb_plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plan.SelectedIndexChanged
        search()
    End Sub

    Private Sub اتصالToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اتصالToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            call_report(__(lv_queue.SelectedItems(0).Text))
        End If
    End Sub
    Private Sub print_list(id As Integer)
        Dim p As New Patient(id)

        Dim d As New DataSet
        d = getdatat1("select * from dept where user_id = " & id & " order by id asc")

        Dim f2 As New fm_x_viewer_treat
        f2.ds = d
        f2.user_name = p.name
        f2.final_price = p.house_price.ToString
        f2.path = "contract_list"

        f2.user_dar = " ( " & p.f3 & " ) "
        f2.user_block = " ( " & p.f1 & " ) "
        f2.remaind = p.tb_l_5
        f2.arrive = p.tb_2
        f2.user_name = " ( " & p.name & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "
        f2.contract_date = p.register_date
        f2.user_block_number = " ( " & p.f2 & " ) "
        f2.user_id_number = " ( " & p.f6 & " ) "
        f2.dar_area = " ( " & p.ref_by & " ) "
        f2.item2 = p.item2
        f2.item3 = p.item3
        f2.item4 = p.item4
        f2.item9 = p.f1 & p.f2 & "." & p.f3
        f2.item10 = p.name
        f2.admin_name = p.admin_name
        f2.Show()


    End Sub

    Private Sub print_contract(id As Integer)
        Dim p As New Patient(id)

        Dim d As New DataSet
        d = getdatat1("select * from dept where user_id = " & id & " order by id asc")


        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = p.name
        f.final_price = p.house_price.ToString


        f.user_dar = " ( " & p.f3 & " ) "
        f.user_block = " ( " & p.f1 & " ) "
        f.remaind = p.tb_l_5
        f.arrive = p.tb_2

        f.user_name = " ( " & p.name & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "
        f.contract_date = p.register_date
        f.user_block_number = " ( " & p.f2 & " ) "
        f.user_id_number = " ( " & p.f6 & " ) "
        f.dar_area = " ( " & p.ref_by & " ) "
        f.item2 = p.item2
        f.item3 = p.item3
        f.item4 = p.item4
        f.item9 = p.f1 & p.f2 & "." & p.f3
        f.item10 = p.name
        f.admin_name = p.admin_name



        f.Show()



    End Sub

    Private Sub عرضالعقدToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub عرضسجلالتسديدToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub طباعةالخارطةToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub عقدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عقدToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            print_contract(__(lv_queue.SelectedItems(0).Text))
        End If
    End Sub

    Private Sub سجلتسديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles سجلتسديدToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            print_list(__(lv_queue.SelectedItems(0).Text))
        End If
    End Sub

    Private Sub طباعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            Dim p As New Patient(__(lv_queue.SelectedItems.Item(0).Text))
            fm_add_other_required.tb_id.Text = p.id.ToString
            fm_add_other_required.tb_name.Text = p.name
            fm_add_other_required.nu_first_part.Value = p.first_part
            fm_add_other_required.nu_house_price.Value = p.house_price
            fm_add_other_required.nu_last_part.Value = p.last_part
            fm_add_other_required.nu_first_present.Value = p.first_present
            fm_add_other_required.nu_last_present.Value = p.last_present

            fm_add_other_required.Show()



        End If
    End Sub

    Private Sub tb_patient_id_EditValueChanged(sender As Object, e As EventArgs) Handles tb_patient_id.EditValueChanged

    End Sub

    Private Sub tb_patient_id_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_patient_id.KeyUp
        If e.KeyCode = Keys.Enter Then
            search3()
            tb_patient_id.Text = ""

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        search3()

    End Sub
End Class