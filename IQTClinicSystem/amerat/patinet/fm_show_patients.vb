Imports MySql.Data.MySqlClient

Public Class fm_show_patients
    Dim re As String = ""
    Dim image_path As String = ""


    Private Sub fm_show_patients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If re = "" Then
            fm_main.Show()
       

        End If
    End Sub

    Private Sub fm_show_patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        lv_queue.Columns.Add("رقم الزبون", 122)
        lv_queue.Columns.Add("اسم الزبون", 200)
        lv_queue.Columns.Add("هاتف", 150)
        lv_queue.Columns.Add("بلوك", 110)
        lv_queue.Columns.Add("رقم الدار", 110)
        lv_queue.Columns.Add("المبلغ الكلي", 110)
        lv_queue.Columns.Add("تأريخ الشراء", 150)



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
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' order by f2,f1,f3  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' and  f2 like '%" & tb_f2.Text & "%'   order by f2,f1,f3  limit " & num_limit.Value & ""

                    End If

                End If
            Else
                If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'   order by id desc limit " & num_limit.Value & ""
                Else

                    If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' order by id desc  limit " & num_limit.Value & ""

                    Else
                        s = "select * from patient WHERE name like '%" & tb_name.Text & "%' and f1 like '%" & tb_f1.Text & "%' and  f2 like '%" & tb_f2.Text & "%'   order by id desc  limit " & num_limit.Value & ""

                    End If

                End If
            End If


            Dim DataSet = getdatat1(s)
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

          

            Dim id As Integer = Convert.ToInt32(lv_queue.SelectedItems.Item(0).Text)


            Dim patient As New Patient(id)

            fm_add_patient.tb_id.Text = patient.id.ToString
            fm_add_patient.tb_name.Text = patient.name
            fm_add_patient.tb_note.Text = patient.note
            Try
                fm_add_patient.dt_birthdate.Value = Convert.ToDateTime(patient.birthdate)
                fm_add_patient.dt_register_date.Value = Convert.ToDateTime(patient.register_date)

            Catch ex As Exception

            End Try

            fm_add_patient.tb_wieght.Text = patient.wieght
            fm_add_patient.tb_phone.Text = patient.phone
            fm_add_patient.tb_ref_by.Text = patient.ref_by



            fm_add_patient.tb_wieght.Text = patient.f1
            fm_add_patient.nu_blok_num.Value = __(patient.f2)
            fm_add_patient.num_home_num.Value = __(patient.f3)

            fm_add_patient.tb_f6.Text = patient.f6
            fm_add_patient.tb_f7.Text = patient.f7
            fm_add_patient.tb_f8.Text = patient.f8

      
            fm_add_patient.Show()
            fm_add_patient.cb_plan.Text = patient.f5


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
        If lv_queue.SelectedItems.Count > 0 Then

            fm_add_other_required.tb_id.Text = lv_queue.SelectedItems.Item(0).Text
            fm_add_other_required.tb_name.Text = lv_queue.SelectedItems.Item(0).SubItems(1).Text
            fm_add_other_required.Show()



        End If

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
End Class