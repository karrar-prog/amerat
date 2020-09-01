Imports MySql.Data.MySqlClient

Public Class fm_add_other_required

    Public p_DataSet As DataSet

    Private Sub cb_templet_treat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_templet_treat.SelectedIndexChanged

        If cb_templet_treat.Text <> s_temp Then
            'If MessageBox.Show("اضافة ؟", "استحقاقات ", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            'MessageBox.Show("غير متوفر")
            'Exit Sub
            'End If
            put_template(cb_templet_treat.Text)


        End If
    End Sub

    Public Sub format_templet_treat(ByVal cb As ComboBox)

        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        ds = getdatat1("select * from template order by id desc ")
        cb.Items.Clear()
        cb.Items().Add(s_temp)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            cb.Items().Add(ds.Tables(0).Rows(i).Item("title").ToString)
        Next
        cb.SelectedItem = cb.Items(0)

    End Sub



    Private Sub put_depts()
1:

        tb_net_dept.EditValue = 0
        tb_all_dept.EditValue = 0
        tb_arrive.EditValue = 0
        Try
            Dim dt As New DateTimePicker
            Dim ds_treat_table As New DataSet
            ds_treat_table = getdatat1("select * from dept where user_id = " & __(tb_id.Text) & " order by id desc ")
            lv_dept.Items.Clear()
            If ds_treat_table.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds_treat_table.Tables(0).Rows.Count - 1

                    lv_dept.Items.Add(ds_treat_table.Tables(0).Rows(i).Item("id").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("title").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("amount").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("arrive_amount").ToString)

                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("f1").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("type").ToString)
                    If ds_treat_table.Tables(0).Rows(i).Item("amount").ToString = ds_treat_table.Tables(0).Rows(i).Item("arrive_amount").ToString Then
                        lv_dept.Items(i).SubItems.Add("تم التسديد")
                        lv_dept.Items(i).BackColor = Color.LightGreen
                    ElseIf __(ds_treat_table.Tables(0).Rows(i).Item("arrive_amount").ToString) <> 0 Then
                        lv_dept.Items(i).SubItems.Add("تسديد جزء")
                        lv_dept.Items(i).BackColor = Color.LightYellow

                    Else
                        lv_dept.Items(i).SubItems.Add("لا")


                    End If
                     lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("create_at").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("payment_date").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("user_did_id").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("f2").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("f3").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("f4").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("f5").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("user_id").ToString)

                    tb_all_dept.EditValue = __(tb_all_dept.EditValue.ToString) + __(ds_treat_table.Tables(0).Rows(i).Item("amount").ToString)
                    tb_arrive.EditValue = __(tb_arrive.EditValue.ToString) + __(ds_treat_table.Tables(0).Rows(i).Item("arrive_amount").ToString)
                  
                Next
                tb_net_dept.EditValue = __(tb_all_dept.EditValue.ToString) - __(tb_arrive.EditValue.ToString)

            End If
            calculating_amount()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Private Sub put_template(template_title As String)
1:

        Try
            Dim dt As New DateTimePicker
            Dim ds_treat_table As New DataSet
            ds_treat_table = getdatat1("select * from template_treatment where template like '" & template_title & "'  ")
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
            calculating_amount()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub fm_add_other_required_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub

    Private Sub fm_add_other_required_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatlist_treat_table(lv_treat_table)
        formatlist_dept_table(lv_dept)
        format_templet_treat(cb_templet_treat)
    
        all_depts()
      
    End Sub

    Private Sub lv_treat_table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treat_table.SelectedIndexChanged
      
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'MessageBox.Show("غير متوفر")
        'Exit Sub
        save_new_temp()
        format_templet_treat(cb_templet_treat)

    End Sub

    Private Sub save_temp()
        Try

            Dim t As New Treat
1:

            Try
                t.save_in_templete(cb_templet_treat.Text)
            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1

                End If
            End Try


        Catch ex As Exception

        End Try

    End Sub
    Private Sub save_new_temp()
        Try
            Dim title As String = InputBox("ادخل عنوان هذه المتطلبات ")
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


    Private Sub حذفالعلاجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالعلاجToolStripMenuItem.Click
        If hasPermission("حذف") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_treat_table.SelectedItems.Count > 0 Then
            lv_treat_table.Items.RemoveAt(lv_treat_table.SelectedIndices(0))

        End If
    End Sub

    Public Sub calculating_amount()
        tb_amount.EditValue = 0

        For i = 0 To lv_treat_table.Items.Count - 1
            tb_amount.EditValue = __(tb_amount.EditValue.ToString) + __(lv_treat_table.Items(i).SubItems(2).Text)
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'If Notadded() Then
        '    Exit Sub
        'End If

        add()
        put_depts()
    End Sub

    Private Function Notadded() As Boolean
        Return False

    End Function

    Private Sub add()
        If lv_treat_table.Items.Count > 0 Then
            For i = 0 To lv_treat_table.Items.Count - 1
                Dim dept As New Dept
                dept.user_id = __(tb_id.Text)
                dept.user_did_id = user.id
                dept.title = lv_treat_table.Items.Item(i).SubItems(1).Text
                dept.amount = __(lv_treat_table.Items.Item(i).SubItems(2).Text)
                dept.status = "لا"
                dept.arrive_amount = 0
                dept.create_at = Date.Now.ToString
                dept.type = cb_templet_treat.Text
                dept.f1 = lv_treat_table.Items.Item(i).SubItems(3).Text
                dept.f2 = ""
                dept.f3 = ""
                dept.f4 = ""
                dept.f5 = ""
                dept.save()
                excute1("update patient set f4 = f4 + " & dept.amount & " where id = " & __(tb_id.Text) & "")


            Next
        End If

    End Sub

    Private Sub lv_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_dept.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If MessageBox.Show(tb_net_dept.Text, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then
            For i = 0 To lv_dept.Items.Count - 1
                Dim d As New Dept()
                d.id = __(lv_dept.Items.Item(i).Text)
              
                d.tasded()
                Dim content = "تسديد ديون: " & tb_name.Text
                new_event2("تسديد", content, (__(tb_net_dept.EditValue.ToString)))

            Next
            excute1("update patient set f4 = f4 - " & tb_net_dept.EditValue.ToString & " where id = " & __(tb_id.Text) & "")

            all_depts()
        End If

    End Sub

    Private Sub تسديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسديدToolStripMenuItem.Click
        'Dim c As Integer = 0
        'For i = 0 To lv_dept.SelectedItems.Count - 1
        '    c = c + __(lv_dept.SelectedItems.Item(i).SubItems(2).Text)
        'Next
        'If MessageBox.Show(c.ToString, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then

        'End If
        Dim total = 0

        For i = 0 To lv_dept.SelectedItems.Count - 1
            Dim d As New Dept()
            total = total + (__(lv_dept.SelectedItems.Item(i).SubItems(2).Text) - __(lv_dept.SelectedItems.Item(i).SubItems(3).Text))


        Next
        If MessageBox.Show(total.ToString, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then
            For i = 0 To lv_dept.SelectedItems.Count - 1
                Dim d As New Dept()
                d.id = __(lv_dept.SelectedItems.Item(i).Text)
                excute1("update patient set f4 = f4 - " & total & " where id = " & tb_id.Text & "")
                Dim content = "تسديد ديون: " & tb_name.Text
                new_event2("تسديد", content, total)

                d.tasded()

            Next
            all_depts()
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        'MessageBox.Show("غير متوفر")
        'Exit Sub
        If (cb_templet_treat.Text.Trim <> "") Then

            delete_temp(cb_templet_treat.Text)
            save_temp()
            format_templet_treat(cb_templet_treat)

        End If

    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        print()

    End Sub
    Private Sub print()

        Dim f As New fm_x_viewer_treat
        f.ds = getdatat1("select * from dept where user_id = " & __(tb_id.Text) & " order by id asc")
        f.user_name = tb_name.Text
        f.final_price = tb_all_dept.Text
        f.arrive = tb_arrive.Text
        f.remaind = tb_net_dept.Text
        Dim p As New Patient(__(tb_id.Text))
        f.user_dar = p.f3
        f.user_block = p.f1

        f.admin_name = user.name
        f.user_name = " ( " & tb_name.Text & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "

        f.dar_area = p.ref_by
        f.contract_date = p.register_date
        f.user_block_number = p.f2
        f.user_id_number = p.f6

        f.Show()


    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        fm_add_other_dept_item.Show()



    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If hasPermission("حذف") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_dept.SelectedItems.Count > 0 Then
            If MessageBox.Show("حل تريد الحذف ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                For i = 0 To lv_dept.SelectedItems.Count - 1

                    delete_dept(__(lv_dept.SelectedItems.Item(i).Text), __(lv_dept.SelectedItems.Item(i).SubItems(2).Text) - __(lv_dept.SelectedItems.Item(i).SubItems(3).Text), __(lv_dept.SelectedItems.Item(i).SubItems(14).Text))

                Next
                put_depts()
            End If

        End If
    End Sub
    Private Sub delete_dept(id As Integer, price As Integer, user_id As Integer)
        excute1("delete from dept where id = " & id & "")
        excute1("update patient set f4 = f4 - " & price & " where id = " & user_id & "")
    End Sub
 
 
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            GroupControl1.Visible = False

        Else
            GroupControl1.Visible = True

        End If
    End Sub

    Public Sub all_depts()
        If (tb_id.Text.Trim <> "") Then
            put_depts()
          

        End If


    End Sub

    Private Sub tb_user_id_barcode_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_search_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search.EditValueChanged

    End Sub

    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
        If e.KeyValue = Keys.Enter Then
            tb_id.Text = ""
            tb_name.Text = ""

            If tb_search.Text.Trim <> "" Then
                tb_id.Text = tb_search.Text
                all_depts()
             
            End If
            tb_search.Text = ""

        End If
      
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        tb_search.Focus()
        tb_search.Text = ""

        Beep()

        SimpleButton9.ForeColor = Color.Green

    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs)
     
        Beep()
        SimpleButton9.ForeColor = Color.Black
       
    End Sub

    Private Sub تسديدهذهالمتطلباتToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim total = 0

        For i = 0 To lv_dept.SelectedItems.Count - 1
            Dim d As New Dept()
            total = total + (__(lv_dept.SelectedItems.Item(i).SubItems(2).Text) - __(lv_dept.SelectedItems.Item(i).SubItems(3).Text))


        Next
        If MessageBox.Show(total.ToString, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then
            For i = 0 To lv_dept.SelectedItems.Count - 1
                Dim d As New Dept()
                d.id = __(lv_dept.SelectedItems.Item(i).Text)
                d.tasded()

            Next
        End If



    End Sub

    Private Sub تسديدجزءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسديدجزءToolStripMenuItem.Click
        If lv_dept.SelectedItems.Count = 1 Then

            fm_tasded_part.tb_id.Text = lv_dept.SelectedItems.Item(0).Text
            fm_tasded_part.tb_amount.Text = lv_dept.SelectedItems.Item(0).SubItems(2).Text
            fm_tasded_part.tb_arrived.Text = lv_dept.SelectedItems.Item(0).SubItems(3).Text
            fm_tasded_part.tb_user_id.Text = tb_id.Text
            fm_tasded_part.Show()

        Else
            MessageBox.Show("اختر عنصر واحد فقط")

        End If
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلToolStripMenuItem.Click
        If lv_treat_table.SelectedItems.Count > 0 Then

            fm_edit_treatment.tb_treatment_name.Text = lv_treat_table.SelectedItems.Item(0).SubItems(1).Text
            fm_edit_treatment.tb_dose_to_patient.Text = lv_treat_table.SelectedItems.Item(0).SubItems(2).Text
            fm_edit_treatment.tb_note.Text = lv_treat_table.SelectedItems.Item(0).SubItems(3).Text

            fm_edit_treatment.Show()


        End If
    End Sub

    Private Sub اضافةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةToolStripMenuItem.Click
        If lv_treat_table.Items.Count > 0 Then
            For i = 0 To lv_treat_table.SelectedItems.Count - 1
                Dim dept As New Dept
                dept.user_id = __(tb_id.Text)
                dept.user_did_id = user.id
                dept.title = lv_treat_table.SelectedItems.Item(i).SubItems(1).Text
                dept.amount = __(lv_treat_table.SelectedItems.Item(i).SubItems(2).Text)
                dept.status = "لا"
                dept.arrive_amount = 0
                dept.create_at = Date.Now.ToString
                dept.type = cb_templet_treat.Text
                dept.f1 = lv_treat_table.SelectedItems.Item(i).SubItems(3).Text
                dept.f2 = ""
                dept.f3 = ""
                dept.f4 = ""
                dept.f5 = ""
                dept.save()
                excute1("update patient set f4 = f4 + " & dept.amount & " where id = " & __(tb_id.Text) & "")


            Next
            all_depts()
        End If
    End Sub

 

    Private Sub tb_search2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

   

    Private Sub get_months_details(id As Integer)
        Try
            Dim m As New Months(id)

            fm_months_tasded.tb_id.Text = id.ToString
            fm_months_tasded.tb_amount.Text = m.total_amount.ToString
            fm_months_tasded.tb_arrived.Text = m.arrive_amount.ToString
            fm_months_tasded.tb_arrive.Text = (m.total_amount - m.arrive_amount).ToString
            If (m.user_id <> 0) Then
                Dim p As New Patient(m.user_id)
                fm_months_tasded.tb_user_id.Text = m.user_id.ToString
                fm_months_tasded.TextEdit1.Text = "(  " & m.month.ToString & "-" & m.year.ToString & "  )" & p.name
                fm_months_tasded.Show()
                tb_id.Text = p.id.ToString
                all_depts()
            Else

                MessageBox.Show("لايوجد")
            End If
          

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs)
        print2()
    End Sub
    Private Sub print2()

        Dim f As New fm_x_viewer_treat

        f.ds = p_DataSet

        f.user_name = ""
        f.final_price = ""
        f.arrive = ""
        f.remaind = ""
        f.admin_name = user.name
        f.path = "months"


        f.user_dar = ""
        f.user_block = ""


        f.Show()


    End Sub



End Class