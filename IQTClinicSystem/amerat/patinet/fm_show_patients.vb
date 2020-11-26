Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel

Public Class fm_show_patients
    Dim re As String = ""
    Dim image_path As String = ""


    Private Sub fm_show_patients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If re = "" Then
            fm_main.Show()
        Else
            fm_main.Show()


        End If
    End Sub

    Private Sub fm_show_patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
        If user.type = user_admin Then
            SimpleButton2.Visible = True
        Else
            SimpleButton2.Visible = False

        End If
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

        lv_queue.Columns.Add("حالة البيع", 150)
        lv_queue.Columns.Add("حالة ألفيشة", 150)
        lv_queue.Columns.Add("", 220)



    End Sub


    Public Sub search4()

1:

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
        fill_db(DataSet)

        '    GridControl1.DataSource = DataSet.Tables(0)

        '    Dim dt As New DateTimePicker
        '    Dim c As Integer

        '    lv_queue.Items.Clear()

        '    tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString


        '    If DataSet.Tables(0).Rows.Count > 0 Then

        '        For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
        '            lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)
        '            lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)

        '            If DataSet.Tables(0).Rows(i).Item("is_token").ToString <> s_not_booking Then
        '                lv_queue.Items(i).BackColor = Color.LightPink
        '            ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString <> s_booking Then
        '                lv_queue.Items(i).BackColor = Color.LightGreen

        '            Else

        '                lv_queue.Items(i).BackColor = Color.Gold

        '            End If
        '            'lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
        '            '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)

        '        Next
        '    End If
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        '    If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
        '        GoTo 1

        '    End If
        'End Try



    End Sub
    Public Sub search()

1:

        Dim s As String

        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' "

        If tb_f1.Text.Trim <> "" Then
            s = s & " and f1 like '" & tb_f1.Text & "' "
        End If

        If tb_f2.Text.Trim <> "" Then
            s = s & " and f2 like '" & tb_f2.Text & "' "
        End If
        If tb_house_number.Text.Trim <> "" Then
            s = s & " and f3 like '" & tb_house_number.Text & "' "
        End If

        If cb_plan.Text.Trim <> "" Then
            s = s & "  and  is_token like '" & cb_plan.Text & "'  "
        End If



        If RadioButton2.Checked = True Then
            s = s & "  order by f2,f1,f3  "
        Else
            s = s & " order by id desc "
        End If

        If CheckEdit1.Checked = False Then


            s = s & "  limit " & num_limit.Value & ""

        End If
        Dim DataSet = getdatat1(s)
        fill_db(DataSet)





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


        If hasPermission(i_edit_customer) Then

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
            Me.Hide()



        End If
    End Sub

    Private Sub ارشفةبياناتالمراجعToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
        fill_db(DataSet)

        'GridControl1.DataSource = DataSet.Tables(0)

        'Dim dt As New DateTimePicker
        'Dim c As Integer
        'tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

        'lv_queue.Items.Clear()
        'If DataSet.Tables(0).Rows.Count > 0 Then

        '    For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
        '        lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)

        '        If DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_not_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightGreen
        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightPink

        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_deal Then

        '            lv_queue.Items(i).BackColor = Color.Gold

        '        End If
        '    Next
        'End If
    End Sub
    Private Sub search3()

        If tb_patient_id.Text.Trim = "" Then
            search()
            Exit Sub
        End If

        Dim s As String = "select * from patient WHERE id = " & tb_patient_id.Text & "  order by f2,f1,f3  limit " & num_limit.Value & ""

        Dim DataSet = getdatat1(s)
        fill_db(DataSet)

        'GridControl1.DataSource = DataSet.Tables(0)

        'Dim dt As New DateTimePicker
        'Dim c As Integer
        'tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

        'lv_queue.Items.Clear()
        'If DataSet.Tables(0).Rows.Count > 0 Then

        '    For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
        '        lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)

        '        If DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_not_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightGreen
        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightPink

        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_deal Then

        '            lv_queue.Items(i).BackColor = Color.Gold

        '        End If
        '    Next
        'End If
    End Sub
    Private Sub searchfeash(d As Integer)

        Dim s As String
        If d = 1 Then
            s = "select * from patient WHERE first_push_amount_arrived > 0  order by f2,f1,f3 "
        ElseIf d = 2 Then
            s = "select * from patient WHERE first_push_amount_arrived = 0 and first_push_amount > 0  order by f2,f1,f3  "
        ElseIf d = 3 Then
            s = "select * from patient WHERE first_push_amount_arrived = 0 and first_push_amount = 0 and is_token ='حجز' order by f2,f1,f3  "
        ElseIf d = 4 Then
            s = "select * from patient WHERE  is_token ='غير محجوز' order by f2,f1,f3  "


        End If

        Dim DataSet = getdatat1(s)
        fill_db(DataSet)

        'GridControl1.DataSource = DataSet.Tables(0)

        'Dim dt As New DateTimePicker
        'Dim c As Integer
        'tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

        'lv_queue.Items.Clear()
        'If DataSet.Tables(0).Rows.Count > 0 Then

        '    For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
        '        lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)
        '        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)

        '        If DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_not_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightGreen
        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then
        '            lv_queue.Items(i).BackColor = Color.LightPink

        '        ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_deal Then

        '            lv_queue.Items(i).BackColor = Color.Gold

        '        End If
        '    Next
        'End If
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

    Private Sub tb_f1_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_f1.KeyUp
        If e.KeyCode = Keys.Enter Then
            tb_f2.Focus()

        End If
    End Sub

    Private Sub tb_f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f1.SelectedIndexChanged
        search()
        tb_f2.Focus()
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
            MessageBox.Show("اختر زبون")
            Exit Sub

        End If
    End Sub

    Private Sub تفعيلالحسابToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
        f2.item1 = p.diagonosis
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
    Private Sub print_map(id As Integer)
        Dim p As New Patient(id)

        Dim d As New DataSet
        d = getdatat1("select * from dept where user_id = " & id & " order by id asc limit 1")


        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = p.name
        f.final_price = p.house_price.ToString


        f.user_dar = " ( " & p.f3 & " ) "
        f.user_block = " ( " & p.f1 & " ) "
        f.remaind = p.tb_l_5
        f.arrive = p.tb_2

        f.user_name = p.name
        f.contract_date = p.register_date
        f.user_block_number = " ( " & p.f2 & " ) "
        f.user_id_number = " ( " & p.f6 & " ) "
        f.dar_area = " ( " & p.ref_by & " ) "
        f.item2 = p.item2
        f.item3 = p.id.ToString
        f.path = "map"
        f.item4 = images_path & "\p" & id.ToString & "\map\ألخارطة.png"
        f.item9 = p.f1 & p.f2 & "." & p.f3
        f.item10 = p.name
        f.admin_name = p.admin_name
        f.item6 = p.f9


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

    Private Sub حذفنهائيToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub حذفنهائيToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles حذفنهائيToolStripMenuItem1.Click

        If user.type <> user_admin Then
            MessageBox.Show("مركز الصلاحيات", "لايمكن الحذف")
            Exit Sub
        End If
        If lv_queue.SelectedItems.Count > 0 Then
            If fm_queue.no_item_in_dept(__(lv_queue.SelectedItems(0).Text)) Then
                If MessageBox.Show("هل تريد الحذف نهائيا-سوف يتم حذف معلومات الزبون ومستمسكاته وصورتة الشخصية ؟", "تأكيد", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    Dim p As New Patient(__(lv_queue.SelectedItems(0).Text))
                    p.delete()
                    Try
                        delete_files(p.id)

                    Catch ex As Exception

                    End Try

                    'Dim que As New Queue()
                    'que.id = __(lv_queue.SelectedItems(0).SubItems(6).Text)
                    'que.delete()
                    search()

                End If

            Else
                MessageBox.Show("هذا الزبون لدية فيش - يرجى حذفها اولاً")
            End If
        End If
    End Sub

    Private Sub عرضالفيشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضالفيشToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count = 1 Then
            fm_queue.tb_p_id.Text = lv_queue.SelectedItems(0).Text
            fm_queue.Show()
            fm_queue.ContractSearch()

        End If

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Export_xlsx("Cutomer", GridControl1)

    End Sub

    Private Sub Export_xlsx(output As String, ByRef gridControl As DevExpress.XtraGrid.GridControl)
        Dim path As String = "xlsx/" & output & "_Date_" & Date.Now.Year & "_" & Date.Now.Month & "_" & Date.Now.Day & "_Time_" & Date.Now.Hour & "_" & Date.Now.Minute & "_" & Date.Now.Second & Date.Now.Millisecond & ".xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(Application.StartupPath & "/" & path)
    End Sub

    Private Sub GridControl1_Click_1(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub tb_user_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tb_user.ItemClick
        fm_change_user.Show()

    End Sub

    Private Sub خارطةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خارطةToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count > 0 Then
            print_map(__(lv_queue.SelectedItems(0).Text))
        End If

    End Sub
    Public Sub call_report(id As Integer)

1:
        Try
            Dim query As String = "select * , queue.id as fesha_id ,patient.f1 as blok_title , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  patient.id = " & id & " and patient.id = queue.patient_id order by queue.id desc limit 1 "

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_call
            fm.rep_name = "calling"

            fm.ds = getdatat1(query)
            If fm.ds.Tables(0).Rows.Count > 0 Then
                fm.Show()
            Else
                MessageBox.Show("لم يتم طباعة اي فيشة لهذا الزبون")
            End If

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Sub num_limit_ValueChanged(sender As Object, e As EventArgs) Handles num_limit.ValueChanged

    End Sub
    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub tb_house_number_EditValueChanged(sender As Object, e As EventArgs) Handles tb_house_number.EditValueChanged

    End Sub

    Private Sub tb_house_number_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_house_number.KeyUp
        search()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        search()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        search()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        search()
    End Sub

    Private Sub fill_db(DataSet As DataSet)
1:
        Try

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
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)
                    If DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_not_booking Then
                        lv_queue.Items(i).BackColor = Color.LightGreen
                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then
                        lv_queue.Items(i).BackColor = Color.LightPink

                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_deal Then

                        lv_queue.Items(i).BackColor = Color.Gold

                    End If

                    If DataSet.Tables(0).Rows(i).Item("first_push_amount_arrived").ToString.Trim <> "0" And DataSet.Tables(0).Rows(i).Item("first_push_amount_arrived").ToString.Trim <> "" Then
                        lv_queue.Items(i).SubItems.Add("الفيشة مستلمة")
                        lv_queue.Items(i).SubItems(7).ForeColor = Color.Green
                        lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("diagonosis").ToString)


                    ElseIf DataSet.Tables(0).Rows(i).Item("first_push_amount").ToString.Trim <> "0" And DataSet.Tables(0).Rows(i).Item("first_push_amount").ToString.Trim <> "" Then
                        lv_queue.Items(i).SubItems.Add("انتظار الفيشة")
                        lv_queue.Items(i).SubItems(8).ForeColor = Color.Yellow
                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then

                        lv_queue.Items(i).SubItems.Add("حجز فقط")
                        lv_queue.Items(i).SubItems(7).BackColor = Color.LightPink
                    Else
                        lv_queue.Items(i).SubItems.Add("")
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

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        searchfeash(1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        searchfeash(2)
    End Sub

    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        searchfeash(3)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        searchfeash(4)
    End Sub

    Private Sub tb_f2_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_f2.KeyUp
        If e.KeyValue = Keys.Enter Then
            tb_house_number.Focus()

        End If
    End Sub
End Class