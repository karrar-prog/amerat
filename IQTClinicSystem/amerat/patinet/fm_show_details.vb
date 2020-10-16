﻿Imports MySql.Data.MySqlClient

Public Class fm_show_details

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
    Private Sub formatlist()

        lv.View = View.Details

        lv.Columns.Add("", 220)
        lv.Columns.Add("", 270)
        lv.Columns.Add("", 270)
        lv.Columns.Add("", 270)
        lv.Columns.Add("", 320)
        lv.Columns.Add("", 300)
        lv.Columns.Add("تسلسل", 0)


        lv_queue.View = View.Details

        lv_queue.Columns.Add("العقد", 60)
        lv_queue.Columns.Add("اسم الزبون", 200)
        lv_queue.Columns.Add("هاتف", 150)
        lv_queue.Columns.Add("بلوك", 110)
        lv_queue.Columns.Add("رقم الدار", 110)
        lv_queue.Columns.Add("المبلغ الكلي", 200)
        lv_queue.Columns.Add("تأريخ الشراء", 150)




    End Sub

    Public Sub search()

1:
        Try
            Dim s As String

            If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                s = "select * from patient WHERE name like '%" & tb_name.Text & "%'   and is_token like '%" & cb_plan.Text & "%'   order by id desc limit " & num_limit.Value & ""
            Else

                If tb_f2.Text.Trim = "" Or tb_f2.Text.Trim = "0" Then
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' order by id desc  limit " & num_limit.Value & ""

                Else
                    s = "select * from patient WHERE name like '%" & tb_name.Text & "%'  and is_token like '%" & cb_plan.Text & "%'   and f1 like '%" & tb_f1.Text & "%' and  f2 like '%" & tb_f2.Text & "%'   order by id desc  limit " & num_limit.Value & ""

                End If

            End If

            Dim DataSet = getdatat1(s)

            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_queue.Items.Clear()



            If DataSet.Tables(0).Rows.Count > 0 Then
                lv_queue.Show()

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
            Else
                lv_queue.Hide()

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try



    End Sub
    Private Sub fm_show_details_Load(sender As Object, e As EventArgs) Handles Me.Load
        formatlist()
        lv_queue.Hide()

    End Sub

    Private Sub tb_patient_id_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_patient_id.KeyUp
        If e.KeyCode = Keys.Enter Then
            If tb_patient_id.Text.Trim = "" Then
                lv.Items.Clear()

                Exit Sub
            Else
                get_all_info()

            End If




        End If
    End Sub

    Private Sub tb_patient_id_TextChanged(sender As Object, e As EventArgs) Handles tb_patient_id.TextChanged

    End Sub



    Private Sub get_all_info()
        Dim p As New Patient(__(tb_patient_id.Text))
        If p.id = 0 Then
            lv.Items.Clear()

            Exit Sub
        End If
        lv.Items.Clear()

        lv.Items.Add("رقم العقد")
        lv.Items(0).SubItems.Add(p.id.ToString)

        lv.Items.Add("الاسم")
        lv.Items(1).SubItems.Add(p.name)

        lv.Items.Add("رقم الهاتف")
        lv.Items(2).SubItems.Add(p.phone)

        lv.Items.Add("اسم الام")
        lv.Items(3).SubItems.Add(p.f7)


        lv.Items.Add("رقم ألهوية")
        lv.Items(4).SubItems.Add(p.f6)


        lv.Items.Add("الدار")
        lv.Items(5).SubItems.Add(p.f1 & p.f2 & "." & p.f3)

        lv.Items.Add("المساحة")
        lv.Items(6).SubItems.Add(p.ref_by)

        lv.Items.Add("رقم السند")
        lv.Items(7).SubItems.Add(p.f8)

        lv.Items.Add("القطاع")
        lv.Items(8).SubItems.Add(p.f9)

        lv.Items.Add("ألموقع")
        lv.Items(9).SubItems.Add(p.f10)

        lv.Items.Add("ملاحظة")
        lv.Items(10).SubItems.Add(p.note)


        lv.Items.Add("تأريخ التسجيل")
        Dim ddd As New DateTimePicker
        Try
            ddd.Value = Convert.ToDateTime(p.register_date)
            lv.Items(11).SubItems.Add(ddd.Value.ToShortDateString)

        Catch ex As Exception
            lv.Items(11).SubItems.Add(p.register_date)

        End Try


        lv.Items.Add("مبلغ الدار الكلي")
        lv.Items(12).SubItems.Add(p.house_price.ToString)

        lv.Items.Add("القسم الاول من المبلغ")
        lv.Items(13).SubItems.Add(p.first_part.ToString & " ( " & p.first_present & " % )")

        lv.Items.Add("القسم الاخير من المبلغ")
        lv.Items(14).SubItems.Add(p.last_part.ToString & " ( " & p.last_present & " % )")

        lv.Items.Add("حالة الشراء")
        lv.Items(15).SubItems.Add(p.is_token)

        lv.Items.Add("مبلغ الدفعة الاولى المحدد")
        lv.Items(16).SubItems.Add(p.first_push_amount.ToString & " (" & p.first_push_present & "% )")

        lv.Items.Add("مبلغ الدفعة الاولى المستلمة")
        lv.Items(17).SubItems.Add(p.first_push_amount_arrived.ToString)
        lv.Items(17).SubItems.Add(p.diagonosis.ToString)

        Dim d As New DataSet

        d = getdatat1("select * from dept where user_id = " & tb_patient_id.Text & " order by id ")

        Dim id2 As Integer = 18

        If d.Tables(0).Rows.Count > 0 Then
            For i = 0 To d.Tables(0).Rows.Count - 1

                lv.Items.Add("الدفعة " & d.Tables(0).Rows(i).Item("title").ToString)

                lv.Items(id2).SubItems.Add("مبلغ الدفعة " & d.Tables(0).Rows(i).Item("amount").ToString)

                Dim dd As New DateTimePicker
                Try
                    dd.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("payment_date").ToString)

                    lv.Items(id2).SubItems.Add("تأريخ الاستحقاق " & dd.Value.ToShortDateString)

                Catch ex As Exception
                    lv.Items(id2).SubItems.Add("تأريخ الاستحقاق " & d.Tables(0).Rows(i).Item("payment_date").ToString)

                End Try
                If d.Tables(0).Rows(i).Item("arrive_amount").ToString = "0" Then
                    lv.Items(id2).SubItems.Add("لم يتم الاستلام بعد")
                Else
                    lv.Items(id2).SubItems.Add("المبلغ المستلم " & d.Tables(0).Rows(i).Item("arrive_amount").ToString)

                End If

                If d.Tables(0).Rows(i).Item("arrive_date").ToString.Trim = "" Then

                    lv.Items(id2).SubItems.Add("")

                Else

                    lv.Items(id2).SubItems.Add("تأريخ الاستلام " & d.Tables(0).Rows(i).Item("arrive_date").ToString)

                End If

                If d.Tables(0).Rows(i).Item("f5").ToString.Trim = "" Then
                    lv.Items(id2).SubItems.Add("")

                Else
                    lv.Items(id2).SubItems.Add("رقم الفيشة" & d.Tables(0).Rows(i).Item("f5").ToString)

                End If

                lv.Items(id2).SubItems.Add(d.Tables(0).Rows(i).Item("id").ToString)



                id2 = id2 + 1
            Next

        Else
            lv.Items.Add("اسم المحامي")
            lv.Items(id2).SubItems.Add(p.lower_name.ToString)

            lv.Items.Add("مبلغ السبتتنك")
            lv.Items(id2 + 1).SubItems.Add(p.water_price.ToString)


        End If



        tb_patient_id.Text = ""


    End Sub

    Private Sub طباعةفيشةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةفيشةToolStripMenuItem.Click


        If Not hasPermission(i_fesha) Then
            Exit Sub
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If
        If lv.SelectedItems.Count = 1 Then
            Try
                If lv.SelectedItems(0).SubItems(6).ToString.Trim <> "" Then
                    Dim dept As New Dept(__(lv.SelectedItems(0).SubItems(6).Text))
                    If dept.amount = dept.arrive_amount Then
                        MessageBox.Show("تم التسديد مسبقا")
                    Else



                        Try
                            fm_add_queue.Close()

                        Catch ex As Exception

                        End Try
                        fm_add_queue.tb_id.Text = "0"
                        fm_add_queue.tb_patient_id.Text = lv.Items(0).SubItems(1).Text
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
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged

    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If tb_name.Text.Trim = "" Then
            lv_queue.Hide()

        Else
            search()

        End If
    End Sub

    Private Sub lv_queue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_queue.SelectedIndexChanged
        If lv_queue.SelectedItems.Count > 0 Then
            tb_patient_id.Text = lv_queue.SelectedItems(0).Text
            get_all_info()
        End If
    End Sub

    Private Sub tb_f2_EditValueChanged(sender As Object, e As EventArgs) Handles tb_f2.EditValueChanged

    End Sub

    Private Sub tb_f2_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_f2.KeyUp
        search()

    End Sub

    Private Sub tb_f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f1.SelectedIndexChanged
        search()

    End Sub

    Private Sub cb_plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plan.SelectedIndexChanged
        search()

    End Sub
End Class