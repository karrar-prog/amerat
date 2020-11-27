Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports DevExpress.LookAndFeel

Public Class fm_add_other_required

    Public p_DataSet As DataSet
    Public first_push As Decimal = 0
    Public first_push_text As String = ""
    Public first_push_present As Decimal = 0



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
        Dim p As New Patient(__(tb_id.Text))
        If p.finger_print = "نعم" Then
            SimpleButton2.Text = "طباعة فقط"
            SimpleButton5.Text = "التعديلات مقفلة"
            SimpleButton5.Enabled = False

        End If
        Try

            tb_name.Text = p.name


            tb_net_dept.EditValue = 0
            tb_all_dept.EditValue = 0
            tb_arrive.EditValue = 0
            nu_first_present.Value = p.first_present
            nu_last_present.Value = p.last_present

            nu_first_part.Value = p.first_part
            nu_last_part.Value = p.last_part

            nu_house_price.Value = p.house_price

        Catch ex As Exception
            nu_first_present.Value = 0
            nu_last_present.Value = 0

            nu_first_part.Value = 0
            nu_last_part.Value = 0

            nu_house_price.Value = 1
            Beep()
        End Try



        Try
            Dim dt As New DateTimePicker
            Dim ds_contract_items As New DataSet
            ds_contract_items = getdatat1("select *  from dept where user_id = " & __(tb_id.Text) & " order by id asc ")
            lv_dept.Items.Clear()
            If ds_contract_items.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds_contract_items.Tables(0).Rows.Count - 1

                    lv_dept.Items.Add(ds_contract_items.Tables(0).Rows(i).Item("id").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("title").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("amount").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("arrive_amount").ToString)

                    Try
                        Dim d As New DateTimePicker
                        d.Value = Convert.ToDateTime(ds_contract_items.Tables(0).Rows(i).Item("payment_date").ToString)
                        lv_dept.Items(i).SubItems.Add(d.Value.ToShortDateString)
                    Catch ex As Exception
                        lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("payment_date").ToString)

                    End Try
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("f1").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("type").ToString)

                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("create_at").ToString)

                    If ds_contract_items.Tables(0).Rows(i).Item("amount").ToString = ds_contract_items.Tables(0).Rows(i).Item("arrive_amount").ToString Then
                        lv_dept.Items(i).SubItems.Add("تم التسديد")
                        lv_dept.Items(i).BackColor = Color.LightGreen
                    ElseIf __(ds_contract_items.Tables(0).Rows(i).Item("arrive_amount").ToString) <> 0 Then
                        lv_dept.Items(i).SubItems.Add("تسديد جزء")
                        lv_dept.Items(i).BackColor = Color.LightYellow

                    Else
                        lv_dept.Items(i).SubItems.Add("لا")


                    End If

                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("user_did_id").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("f2").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("f3").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("f4").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("f5").ToString)
                    lv_dept.Items(i).SubItems.Add(ds_contract_items.Tables(0).Rows(i).Item("user_id").ToString)

                    tb_all_dept.EditValue = __(tb_all_dept.EditValue.ToString) + __(ds_contract_items.Tables(0).Rows(i).Item("amount").ToString)
                    tb_arrive.EditValue = __(tb_arrive.EditValue.ToString) + __(ds_contract_items.Tables(0).Rows(i).Item("arrive_amount").ToString)

                Next





                item3.Text = " يكون تسديد مبلغ الدار على  " & ds_contract_items.Tables(0).Rows.Count + 2 & " دفعات "
                Dim last_part_value As New Decimal
                last_part_value = nu_last_part.Value
                tb_net_dept.EditValue = __(tb_all_dept.EditValue.ToString) - __(tb_arrive.EditValue.ToString)
                tb_l_5.Text = " الدفعة " & get_text(ds_contract_items.Tables(0).Rows.Count + 2) & " والاخيرة " & " ( " & nu_last_present.Value.ToString & "%) من قيمة شراء الدار" &
                tb_l_5.Text & " ( " & Format(last_part_value, "###,###,###,###,###") & " ) " & ToArabicLetter(nu_last_part.Value)

                Dim house_value As New Decimal
                house_value = p.house_price
                item2.Text = "ثانياً - إن بدل شراءالدار مبلغاً إجمالياً قدره" & " ( " & Format(house_value, "###,###,###,###,###") & " ) " & ToArabicLetter(p.house_price)
                put_defult_items()

                If p.is_token = "تعاقد" Then
                    item2.Text = p.item2

                    item3.Text = p.item3
                    tb_2.Text = p.tb_2
                    tb_l_5.Text = p.tb_l_5
                    item4.Text = p.item4
                    first_push = p.first_push_amount
                    first_push_text = ToArabicLetter(first_push)
                    first_push_present = p.first_push_present
                    tb_admin_name.Text = p.admin_name
                End If




                calculating_amount()

            End If

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
                    lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("months").ToString)




                Next

            End If
            calculating_amount()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub fm_add_other_required_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub fm_add_other_required_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin

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
            Dim title As String = InputBox("ادخل عنوان هذه المتطلبات ", "دفعات ")
            If title.Trim <> "" Then
                Dim t As New Treat
1:

                Try
                    t.save_in_templete(title & " " & tb_amount.EditValue.ToString)
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

            calculating_amount()

        End If
    End Sub

    Public Sub calculating_amount()
        tb_amount.EditValue = 0

        For i = 0 To lv_treat_table.Items.Count - 1
            tb_amount.EditValue = ___(tb_amount.EditValue.ToString) + ___(lv_treat_table.Items(i).SubItems(2).Text)
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'If Notadded() Then
        '    Exit Sub
        'End If
        If lv_dept.Items.Count > 0 Then
            MessageBox.Show("يجب حذف الدفعات الحاله من القائمة")
            Exit Sub
        End If
        If nu_first_part.Value <> ___(tb_amount.EditValue.ToString) Then
            MessageBox.Show("يجب ان يتساوى المبلغ الكلي للدفعات مع القسم الاول من المبلغ البالغ " & nu_first_part.Value.ToString)
            Exit Sub
        End If

        add()
        put_depts()
    End Sub

    Private Function Notadded() As Boolean
        Return False

    End Function

    Private Sub add()
        If lv_treat_table.Items.Count > 0 Then
            Dim date_now As New DateTimePicker
            Dim p As New Patient(__(tb_id.Text))

            p.first_push_amount = __(lv_treat_table.Items.Item(0).SubItems(2).Text)

            p.first_push_present = ___(lv_treat_table.Items.Item(0).SubItems(3).Text)
            p.save()
            tb_2.Text = " ألدفعة الاولى " & "(" & p.first_push_present & "%)" & " (" & Format(p.first_push_amount, "###,###,###,###") & ")" & ToArabicLetter(p.first_push_amount)
            Dim dates_count As Integer = __(lv_treat_table.Items.Item(0).SubItems(5).Text)
            For i = 1 To lv_treat_table.Items.Count - 1
                Dim dept As New Dept
                dept.user_id = __(tb_id.Text)
                dept.user_did_id = user.id
                dept.title = lv_treat_table.Items.Item(i).SubItems(1).Text
                dept.amount = __(lv_treat_table.Items.Item(i).SubItems(2).Text)
                dept.status = "لا"
                dept.arrive_amount = 0
                dept.create_at = Date.Now.ToString
                dept.type = ToArabicLetter(dept.amount)
                dept.f1 = "(%" & lv_treat_table.Items.Item(i).SubItems(3).Text & ")"
                dept.f2 = ""
                dept.f3 = ""
                dept.f4 = ""
                dept.payment_date = date_now.Value.AddMonths(dates_count).ToShortDateString
                dept.f5 = ""
                dept.save()
                dates_count = dates_count + __(lv_treat_table.Items.Item(i).SubItems(5).Text)
                'excute1("update patient set f4 = f4 + " & dept.amount & " where id = " & __(tb_id.Text) & "")


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
        MessageBox.Show("سدد الدفعة من طباعة الفيشة")
        Exit Sub
        'Dim c As Integer = 0
        'For i = 0 To lv_dept.SelectedItems.Count - 1
        '    c = c + __(lv_dept.SelectedItems.Item(i).SubItems(2).Text)
        'Next
        'If MessageBox.Show(c.ToString, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then

        'End If
        Dim total = 0
        Dim my_text As String = ""
        If lv_dept.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        For i = 0 To lv_dept.SelectedItems.Count - 1
            Dim d As New Dept()
            total = total + (__(lv_dept.SelectedItems.Item(i).SubItems(2).Text) - __(lv_dept.SelectedItems.Item(i).SubItems(3).Text))

            my_text = my_text & " + " & lv_dept.SelectedItems.Item(i).SubItems(1).Text
            If lv_dept.SelectedItems.Count = 1 Then
                my_text = lv_dept.SelectedItems.Item(i).SubItems(1).Text
            End If
        Next

        If MessageBox.Show(total.ToString, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = vbYes Then
            For i = 0 To lv_dept.SelectedItems.Count - 1
                Dim d As New Dept()
                d.id = __(lv_dept.SelectedItems.Item(i).Text)


                d.tasded()

            Next
            Dim content = " تسديد قسط : " & tb_name.Text & " الدفعة " & my_text
            new_event2("تسديد دفعة", content, total)

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

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        fm_save_and.Show()


        'If SimpleButton2.Text = "حفظ و طباعة" Then
        '    Dim p As New Patient()
        '    p.id = __(tb_id.Text)
        '    p.item2 = item2.Text
        '    p.name = tb_name.Text
        '    p.item3 = item3.Text
        '    p.tb_2 = tb_2.Text
        '    p.tb_l_5 = tb_l_5.Text
        '    p.item4 = item4.Text

        '    p.admin_name = tb_admin_name.Text
        '    p.is_token = "تعاقد"

        '    p.first_push_amount = first_push
        '    p.first_push_present = first_push_present


        '    p.set_contract()
        '    Dim content = " تم تحرير عقد : " & tb_name.Text
        '    new_event2("تحرير عقد", content, 0)

        'End If

        ' print()

    End Sub
    Private Sub print()
        Dim p As New Patient(__(tb_id.Text))

        Dim d As New DataSet
        d = getdatat1("select * from dept where user_id = " & __(tb_id.Text) & " order by id asc")


        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = tb_name.Text
        f.final_price = tb_all_dept.Text


        f.user_dar = " ( H." & p.f3 & " ) "
        f.user_block = " ( " & p.f1 & "." & p.f2 & " )"
        f.remaind = p.tb_l_5
        f.arrive = p.tb_2
        f.user_name = " ( " & tb_name.Text & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "
        f.contract_date = p.register_date
        f.user_block_number = ""
        f.user_id_number = " ( " & p.f6 & " ) "
        f.dar_area = " ( " & p.ref_by & " ) "
        f.item1 = p.diagonosis
        f.item2 = p.item2
        f.item3 = p.item3
        f.item4 = p.item4
        f.item9 = p.f1 & p.f2 & "." & p.f3
        f.item10 = p.name
        f.admin_name = p.admin_name



        f.Show()



        Dim f2 As New fm_x_viewer_treat
        f2.ds = d
        f2.user_name = tb_name.Text
        f2.final_price = tb_all_dept.Text
        f2.path = "contract_list"

        f2.user_dar = " ( " & p.f3 & " ) "
        f2.user_block = " ( " & p.f1 & " ) "
        f2.remaind = p.tb_l_5
        f2.arrive = p.tb_2
        f2.user_name = " ( " & tb_name.Text & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "
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

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        fm_add_other_dept_item.Show()



    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If user.type <> user_admin Then
            MessageBox.Show("مركز الصلاحيات", "لايمكن الحذف")
            Exit Sub
        End If
        If lv_dept.SelectedItems.Count > 0 Then
            If MessageBox.Show("حل تريد الحذف ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                For i = 0 To lv_dept.Items.Count - 1

                    delete_dept(__(lv_dept.Items.Item(i).Text))

                Next
                Dim p As New Patient(__(tb_id.Text))
                p.finger_print = ""
                p.is_token = "حجز"
                p.save()

                put_depts()
            End If

        End If
    End Sub
    Private Sub delete_dept(id As Integer)
        excute1("delete from dept where id = " & id & "")
        'excute1("update patient set f4 = f4 - " & price & " where id = " & user_id & "")
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
        'tb_name.Text = ToArabicLetter(23000)
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
        MessageBox.Show("سدد الدفعة من طباعة الفيشة")
        Exit Sub
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
            fm_edit_treatment.tb_selected_money.Value = ___(lv_treat_table.SelectedItems.Item(0).SubItems(2).Text)
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



    Private Sub tb_note_TextChanged(sender As Object, e As EventArgs) Handles tb_l_5.TextChanged

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton8_Click_1(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub SimpleButton10_Click_1(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        fm_devided.nu_first_part.Value = nu_first_part.Value

        fm_devided.Show()


    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub put_defult_items()
        Try
            Dim reader As New StreamReader(Application.StartupPath & "/server/contract_items.txt", Encoding.Default)

            item4.Text = reader.ReadToEnd

            reader.Close()
            item4.Text = item4.Text & " " & Date.Now.ToShortDateString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabFormControl1_Click(sender As Object, e As EventArgs) Handles TabFormControl1.Click

    End Sub

    Private Sub SimpleButton8_Click_2(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        open_text("contract_items")
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        put_defult_items()
    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        If user.type = user_admin Then
            If MessageBox.Show("هل تريد قفل التعديلات ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim p As New Patient(__(tb_id.Text))
                p.finger_print = "نعم"
                p.save()
                SimpleButton2.Text = "طباعة فقط"
                SimpleButton5.Text = "التعديلات مقفلة"
                SimpleButton5.Enabled = False
            End If
        Else
            MessageBox.Show("يجب الدخول بحساب مدير")
        End If



    End Sub

    Private Sub طباعةفيشةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةفيشةToolStripMenuItem.Click
        If lv_dept.SelectedItems.Count = 1 Then
            Dim dept As New Dept(__(lv_dept.SelectedItems(0).Text))
            If dept.amount = dept.arrive_amount Then
                MessageBox.Show("تم التسديد مسبقا")
            Else



                Try
                    fm_add_queue.Close()

                Catch ex As Exception

                End Try
                fm_add_queue.tb_id.Text = "0"
                fm_add_queue.tb_patient_id.Text = tb_id.Text
                fm_add_queue.tb_number.Text = get_number(dept.title).ToString
                fm_add_queue.tb_dept_title.Text = dept.title
                fm_add_queue.tb_dept_id.Text = dept.id.ToString
                fm_add_queue.tb_fesha_amount.Text = dept.amount.ToString
                fm_add_queue.tb_amount_text.Text = ToArabicLetter(dept.amount)
                fm_add_queue.Show()


            End If

        Else
            MessageBox.Show("يرجى اختيار عنر واحد")
        End If
    End Sub

    Private Sub tb_admin_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_admin_name.EditValueChanged

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick
        fm_stecker.Show()

    End Sub
End Class