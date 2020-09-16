Imports MySql.Data.MySqlClient

Public Class fmdaily

    Private Sub fm_daily_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_format()
        co_format()

        date_search()
        GroupControl6.Hide()
        GroupControl7.Hide()

    End Sub

    Private Sub lv_format()
        lv_serjury.View = View.Details
        lv_serjury.Columns.Add("ت")
        lv_serjury.Columns.Add("اسم المراجع", 200)
        lv_serjury.Columns.Add("العمر", 66)
        lv_serjury.Columns.Add("نوع العملية", 155)
        lv_serjury.Columns.Add("تأريخ الدخول", 155)
        lv_serjury.Columns.Add("تأريخ الخروج", 155)
        lv_serjury.Columns.Add("الطبيب", 122)
        lv_serjury.Columns.Add("طبيب التخدير", 155)
        lv_serjury.Columns.Add("المبلغ الكلي", 155)
        lv_serjury.Columns.Add("فتح فايل", 88)
        lv_serjury.Columns.Add("العلمية", 88)
        lv_serjury.Columns.Add("طبيب جراح", 88)
        lv_serjury.Columns.Add("طبيب تخدير", 88)
        lv_serjury.Columns.Add("مستلزمات", 88)
        lv_serjury.Columns.Add("صاله", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("مبلغ", 88)
        lv_serjury.Columns.Add("ملاحظات", 200)

    End Sub



    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        date_search()
    End Sub

    Private Sub date_search()
        lv_serjury.Items.Clear()
        Dim tb_5 As Double = 0
        Dim tb_2 As Double = 0
        Dim total As Double = 0
        Dim d_money As Double = 0

        Dim s = New Serjury
        Dim DataSet As New DataSet
        DataSet = s.get_all(DateTimePicker1, DateTimePicker2, tb_doctor1_search.Text.Trim)
        If DataSet.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                lv_serjury.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("age").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("ser_type").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_enter").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_out").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("total").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f4").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f6").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f7").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f8").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f9").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f10").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f11").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f12").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                total = total + Val(DataSet.Tables(0).Rows(i).Item("total").ToString)
                tb_5 = tb_5 + Val(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                tb_2 = tb_2 + Val(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                d_money = d_money + Val(DataSet.Tables(0).Rows(i).Item("f3").ToString)

            Next
            tb_acount.Caption = DataSet.Tables(0).Rows.Count.ToString
            fm_money.tb22.Text = tb_2.ToString
            fm_money.tb55.Text = tb_5.ToString
            fm_money.tb_total_total.Text = total.ToString
            fm_money.tb_d_money.Text = d_money.ToString
            fm_money.TextEdit1.Text = DateTimePicker1.Value.ToShortDateString
            fm_money.TextEdit2.Text = DateTimePicker2.Value.ToShortDateString
            If tb_doctor1_search.Text.Trim = "%" Or tb_doctor1_search.Text.Trim = "" Then
                fm_money.TextEdit3.Text = "الكل"
            Else
                fm_money.TextEdit3.Text = tb_doctor1_search.Text


            End If


        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        name_search()
    End Sub

    Private Sub name_search()
        Dim tb_5 As Double = 0
        Dim tb_2 As Double = 0
        Dim total As Double = 0
        Dim d_money As Double = 0

        lv_serjury.Items.Clear()
        TabPane1.Pages(1).Caption = "اضافة"
        LabelControl18.Text = "حفظ جديد"
        Dim s = New Serjury
        Dim DataSet As New DataSet
        DataSet = s.name_search(tb_name.Text)
        If DataSet.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                lv_serjury.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("age").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("ser_type").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_enter").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_out").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("total").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f4").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f6").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f7").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f8").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f9").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f10").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f11").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f12").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                total = total + Val(DataSet.Tables(0).Rows(i).Item("total").ToString)
                tb_5 = tb_5 + Val(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                tb_2 = tb_2 + Val(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                d_money = d_money + Val(DataSet.Tables(0).Rows(i).Item("f3").ToString)

            Next
            tb_acount.Caption = DataSet.Tables(0).Rows.Count.ToString
            fm_money.tb22.Text = tb_2.ToString
            fm_money.tb55.Text = tb_5.ToString
            fm_money.tb_total_total.Text = total.ToString
            fm_money.tb_d_money.Text = d_money.ToString
            fm_money.TextEdit1.Text = DateTimePicker1.Value.ToShortDateString
            fm_money.TextEdit2.Text = DateTimePicker2.Value.ToShortDateString
            fm_money.TextEdit3.Text = tb_doctor1_search.Text


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        no_search()

    End Sub

    Private Sub no_search()
        If tb_id.Text.Trim = "" Then
            Exit Sub
        End If
        lv_serjury.Items.Clear()
        Dim tb_5 As Double = 0
        Dim tb_2 As Double = 0
        Dim total As Double = 0
        Dim d_money As Double = 0

        Dim s = New Serjury
        Dim DataSet As New DataSet
        DataSet = s.no_search(tb_id.Text)
        If DataSet.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                lv_serjury.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("age").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("ser_type").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_enter").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date_out").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("doctor2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("total").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f4").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f6").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f7").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f8").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f9").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f10").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f11").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f12").ToString)
                lv_serjury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                total = total + Val(DataSet.Tables(0).Rows(i).Item("total").ToString)
                tb_5 = tb_5 + Val(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                tb_2 = tb_2 + Val(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                d_money = d_money + Val(DataSet.Tables(0).Rows(i).Item("f3").ToString)

            Next
            tb_acount.Caption = DataSet.Tables(0).Rows.Count.ToString
            fm_money.tb22.Text = tb_2.ToString
            fm_money.tb55.Text = tb_5.ToString
            fm_money.tb_total_total.Text = total.ToString
            fm_money.tb_d_money.Text = d_money.ToString
            fm_money.TextEdit1.Text = DateTimePicker1.Value.ToShortDateString
            fm_money.TextEdit2.Text = DateTimePicker2.Value.ToShortDateString
            fm_money.TextEdit3.Text = tb_doctor1_search.Text

5:
        End If
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلToolStripMenuItem.Click
        show_p_details()

        GroupControl6.Hide()
        GroupControl7.Hide()
        GroupControl8.Hide()


    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If lv_serjury.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل تريد الحذف", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim id = Convert.ToInt32(lv_serjury.SelectedItems.Item(0).Text)
                Dim s = New Serjury(id)
                Try
                    s.delete()
                    date_search()
                Catch ex As Exception

                End Try

            End If

        End If
        GroupControl6.Hide()
        GroupControl7.Hide()
        GroupControl8.Hide()

    End Sub

    Private Sub tb_enter_note_TextChanged(sender As Object, e As EventArgs) Handles tb_note.TextChanged

    End Sub

    Private Sub TextEdit15_EditValueChanged(sender As Object, e As EventArgs) Handles tb9.EditValueChanged
        changeMoney()

    End Sub



    Private Sub changeMoney()
        tb5.Text = Convert.ToString(Val(tb7.Text) + Val(tb8.Text) + Val(tb9.Text) + Val(tb10.Text) + Val(tb11.Text) + Val(tb12.Text))
        tb_total.Text = Convert.ToString(Val(tb1.Text) + Val(tb2.Text) + Val(tb5.Text))

    End Sub
    Private Sub tb1_EditValueChanged(sender As Object, e As EventArgs) Handles tb1.EditValueChanged
        changeMoney()

    End Sub
    Private Sub tb2_EditValueChanged(sender As Object, e As EventArgs) Handles tb2.EditValueChanged
        changeMoney()
        fun_ser()

    End Sub


    Private Sub tb3_EditValueChanged(sender As Object, e As EventArgs) Handles tb3.EditValueChanged
        fun_ser()
        changeMoney()
    End Sub

    Private Sub tb4_EditValueChanged(sender As Object, e As EventArgs) Handles tb4.EditValueChanged
        fun_ser()
        changeMoney()
        'Try
        '    NumericUpDown1.Value = Convert.ToInt32(Val(tb4.Text) / Val(tb2.Text))
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub tb5_EditValueChanged(sender As Object, e As EventArgs) Handles tb5.EditValueChanged
        changeMoney()

    End Sub

    Private Sub tb6_EditValueChanged(sender As Object, e As EventArgs) Handles tb6.EditValueChanged
        fun_ser()
        changeMoney()
    End Sub

    Private Sub tb7_EditValueChanged(sender As Object, e As EventArgs) Handles tb7.EditValueChanged
        changeMoney()

    End Sub

    Private Sub tb8_EditValueChanged(sender As Object, e As EventArgs) Handles tb8.EditValueChanged
        changeMoney()

    End Sub

    Private Sub tb10_EditValueChanged(sender As Object, e As EventArgs) Handles tb10.EditValueChanged
        changeMoney()

    End Sub

    Private Sub tb11_EditValueChanged(sender As Object, e As EventArgs) Handles tb11.EditValueChanged
        changeMoney()

    End Sub

    Private Sub tb12_EditValueChanged(sender As Object, e As EventArgs) Handles tb12.EditValueChanged
        changeMoney()

    End Sub

    Private Sub co_format()

        tb_doctor1.Items.Add("علاء الوديس")
        tb_doctor1.Items.Add("فرزدق التميمي")
        tb_doctor1.Items.Add("محمد الشمري")
        tb_doctor1.Items.Add("سامر الحكاك")
        tb_doctor1.Items.Add("حيدر الشيخ راضي")
        tb_doctor1.Items.Add("مجاهد الهاشمي")
        tb_doctor1.Items.Add("مصطفى الزجراوي")
        tb_doctor1.Items.Add("كاظم شبع")
        tb_doctor1.Items.Add("علي عبار")
        tb_doctor1.Items.Add("حيدر كبة")
        tb_doctor1.Items.Add("ميس شمسة")
        tb_doctor1.Items.Add("ميثم السعدي")
        tb_doctor1.Items.Add("وجدي الفتلاوي")
        tb_doctor1.Items.Add("زهير المله")
        tb_doctor1.Items.Add("احسان تويج")
        tb_doctor1.Items.Add("كرار الجبوري")
        tb_doctor1.Items.Add("ماجد الحمداني")
        tb_doctor1.Items.Add("عدنان الكلابي")
        tb_doctor1.Items.Add("هناء الصغير")
        tb_doctor1.Items.Add("اسراء النداوي")
        tb_doctor1.Items.Add("محمد الخفاجي")
        tb_doctor1.Items.Add("حسن زيني")
        tb_doctor1.Items.Add("قصي زوين")
        tb_doctor1.Items.Add("قصي العبيدي")
        tb_doctor1.Items.Add("ناصر مظلوم")
        tb_doctor1.Items.Add("محمد عبد زيد عاكول")
        tb_doctor1.Items.Add("علي عبد الجبار")
        tb_doctor1.Items.Add("حيدر الجبري")
        tb_doctor1.Items.Add("احمد ال شريف")
        tb_doctor1.Items.Add("منتظر الخرسان")
        tb_doctor1.Items.Add("محمد الموسوي")
        tb_doctor1.Items.Add("ازهار الطريحي")
        tb_doctor1.Items.Add("صالحة علي")
        tb_doctor1.Items.Add("منتهى العابدي")
        tb_doctor1.Items.Add("رسول معله")
        tb_doctor1.Items.Add("علاء عبد الكريم")
        tb_doctor1.Items.Add("زينب عبد المحسن")
        tb_doctor1.Items.Add("نورهان شاكر")
        tb_doctor1.Items.Add("جنان البغداداي")
        tb_doctor1.Items.Add("زين العابدين")
        tb_doctor1.Items.Add("مؤيد الحارس")
        tb_doctor1.Items.Add("رحمن الجنابي")
        tb_doctor1.Items.Add("احمد جمعة")


        tb_doctor1_search.Items.Add("%")
        tb_doctor1_search.Items.Add("علاء الوديس")
        tb_doctor1_search.Items.Add("فرزدق التميمي")
        tb_doctor1_search.Items.Add("محمد الشمري")
        tb_doctor1_search.Items.Add("سامر الحكاك")
        tb_doctor1_search.Items.Add("حيدر الشيخ راضي")
        tb_doctor1_search.Items.Add("مجاهد الهاشمي")
        tb_doctor1_search.Items.Add("مصطفى الزجراوي")
        tb_doctor1_search.Items.Add("كاظم شبع")
        tb_doctor1_search.Items.Add("علي عبار")
        tb_doctor1_search.Items.Add("حيدر كبة")
        tb_doctor1_search.Items.Add("ميس شمسة")
        tb_doctor1_search.Items.Add("ميثم السعدي")
        tb_doctor1_search.Items.Add("وجدي الفتلاوي")
        tb_doctor1_search.Items.Add("زهير المله")
        tb_doctor1_search.Items.Add("احسان تويج")
        tb_doctor1_search.Items.Add("كرار الجبوري")
        tb_doctor1_search.Items.Add("ماجد الحمداني")
        tb_doctor1_search.Items.Add("عدنان الكلابي")
        tb_doctor1_search.Items.Add("هناء الصغير")
        tb_doctor1_search.Items.Add("اسراء النداوي")
        tb_doctor1_search.Items.Add("محمد الخفاجي")
        tb_doctor1_search.Items.Add("حسن زيني")
        tb_doctor1_search.Items.Add("قصي زوين")
        tb_doctor1_search.Items.Add("قصي العبيدي")
        tb_doctor1_search.Items.Add("ناصر مظلوم")
        tb_doctor1_search.Items.Add("محمد عبد زيد عاكول")
        tb_doctor1_search.Items.Add("علي عبد الجبار")
        tb_doctor1_search.Items.Add("حيدر الجبري")
        tb_doctor1_search.Items.Add("احمد ال شريف")
        tb_doctor1_search.Items.Add("منتظر الخرسان")
        tb_doctor1_search.Items.Add("محمد الموسوي")
        tb_doctor1_search.Items.Add("ازهار الطريحي")
        tb_doctor1_search.Items.Add("صالحة علي")
        tb_doctor1_search.Items.Add("منتهى العابدي")
        tb_doctor1_search.Items.Add("رسول معله")
        tb_doctor1_search.Items.Add("علاء عبد الكريم")
        tb_doctor1_search.Items.Add("زينب عبد المحسن")
        tb_doctor1_search.Items.Add("نورهان شاكر")
        tb_doctor1_search.Items.Add("جنان البغداداي")
        tb_doctor1_search.Items.Add("زين العابدين")
        tb_doctor1_search.Items.Add("مؤيد الحارس")
        tb_doctor1_search.Items.Add("رحمن الجنابي")
        tb_doctor1_search.Items.Add("احمد جمعة")

        tb_doctor1_search.SelectedItem = tb_doctor1_search.Items(0)



        tb_doctor2.Items.Add("د.كريم نجرس")
        tb_doctor2.SelectedItem = tb_doctor2.Items(0)



        tb_ser_type.Items.Add("كوتاج")
        tb_ser_type.Items.Add("فطر شرجي")
        tb_ser_type.Items.Add("خياط جرح")
        tb_ser_type.Items.Add("عملية فتق")
        tb_ser_type.Items.Add("بواسير")
        tb_ser_type.Items.Add("ناسور عصعصي")
        tb_ser_type.Items.Add("قيله مائية")
        tb_ser_type.Items.Add("ناسور شرجي")
        tb_ser_type.Items.Add("كيس شحمي")
        tb_ser_type.Items.Add("عقدة ثدي")
        tb_ser_type.Items.Add("كيس دهني")
        tb_ser_type.Items.Add("تنظيف جرح")
        tb_ser_type.Items.Add("خياظة جرح ثانوية")
        tb_ser_type.Items.Add("بتر اصبع")
        tb_ser_type.Items.Add("ناظور مثانة")
        tb_ser_type.Items.Add("ناظور حالب")
        tb_ser_type.Items.Add("تجميل انف")
        tb_ser_type.Items.Add("لوزتين")
        tb_ser_type.Items.Add("زرع سماعة اذن")
        tb_ser_type.Items.Add("تعديل كسر الانف")
        tb_ser_type.Items.Add("تثبيت كسر")
        tb_ser_type.Items.Add("رفع تثيت كسر")

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If Val(tb_age.Text) > 99 Then
            MessageBox.Show("العمر غير صحيح")
            Exit Sub

        End If
        savenew()

    End Sub

    Private Sub savenew()
        If name2.Text.Trim = "" Or tb_age.Text.Trim = "" Or tb_ser_type.Text.Trim = "" Or tb_doctor1.Text.Trim = "" Or tb_doctor2.Text.Trim = "" Then
            MessageBox.Show("املئ الحقول الرئيسية")
            name2.BackColor = Color.LightPink
            tb_age.BackColor = Color.LightPink
            tb_ser_type.BackColor = Color.LightPink
            tb_doctor1.BackColor = Color.LightPink
            tb_doctor2.BackColor = Color.LightPink

            Exit Sub
        End If
        Try
            Dim s As New Serjury
            s.id = Convert.ToInt32(tb_p_id.Text.Trim)
            s.name = name2.Text
            s.age = tb_age.Text
            s.date_enter = dt_enter.Value
            s.date_out = dt_out.Value
            s.doctor1 = tb_doctor1.Text
            s.doctor2 = tb_doctor2.Text
            s.ser_type = tb_ser_type.Text
            s.total = tb_total.Text
            s.f1 = tb1.Text
            s.f2 = tb2.Text
            s.f3 = tb3.Text
            s.f4 = tb4.Text
            s.f5 = tb5.Text
            s.f6 = tb6.Text
            s.f7 = tb7.Text
            s.f8 = tb8.Text
            s.f9 = tb9.Text
            s.f10 = tb10.Text
            s.f11 = tb11.Text
            s.f12 = tb12.Text
            s.note = tb_note.Text
            s.save()
            date_search()
            TabPane1.SelectPrevPage()
            tb_p_id.Text = ""


        Catch ex As Exception

        End Try

        Try
            save_new()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        clear_val()

    End Sub
    Private Sub save_new()
        Dim patient As New Patient

        patient.name = name2.Text

        patient.wieght = ""
        patient.f1 = ""
        patient.f2 = ""
        patient.f3 = ""
        patient.f4 = ""
        patient.f5 = ""
        patient.f6 = ""
        patient.f7 = ""
        patient.f8 = ""
        patient.f9 = ""
        patient.f10 = ""


        If patient.save() Then
            save_booking(Convert.ToInt32(patient.get_id()))

        Else

        End If


    End Sub
    Private Sub save_booking(id As Integer)




            Dim q As New Queue
         


        q.q_date = Date.Now
        q.patient_id = id
            q.note = tb_note.Text
        q.state = "1"

        q.test_amount = 0
        q.test_min = 10
        q.test_type = "عمليه"

            If q.save() Then

            enter_to_doctor(id)

            Else
           
            End If


      
    End Sub
    Private Sub enter_to_doctor(id As Integer)
1:

        Try
            Dim tb_wieght = "0.00"
            conn = New MySqlConnection()
            conn.ConnectionString = serverInfo
            conn.Open()
            Try
                Dim SQLCommand As New MySqlCommand()
                SQLCommand.Connection = conn
                'جلب مواليد المراجع
                SQLCommand = New MySqlCommand()
                SQLCommand.Connection = conn
                Dim query As String = "select * from patient  where id = " & id & ""
                Dim da As New MySqlDataAdapter(query, conn)
                Dim ds As New DataSet()
                da.Fill(ds)
            
                'اضافة زيارة لمراجع
                SQLCommand = New MySqlCommand()
                SQLCommand.Connection = conn
                SQLCommand.CommandText = "INSERT INTO visit(patient_id , doctor_ID , age , `date` , `time` , test_type , test_amount ,note , weight) VALUES(@patient_id , @doctor_ID , @age , @date , @time , @test_type , @test_amount , @note , @weight)"
                SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Decimal).Value = id
                SQLCommand.Parameters.Add("@doctor_ID", MySqlDbType.Decimal).Value = doctor_id_in_visit
                SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Convert.ToDecimal(tb_wieght)

                SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
                SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToShortDateString)
                SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = ""
                SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = tb_note.Text
                SQLCommand.Parameters.Add("@test_amount", MySqlDbType.Decimal).Value = 0
                SQLCommand.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Sub tb_age_EditValueChanged(sender As Object, e As EventArgs) Handles tb_age.EditValueChanged
        If Val(tb_age.Text) > 170 Then
            tb_age.Text = "170"

        End If
    End Sub

    Private Sub LabelControl14_Click(sender As Object, e As EventArgs) Handles LabelControl14.Click

    End Sub

    Private Sub LabelControl26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        fun_ser()
        changeMoney()
    End Sub

    Private Sub fun_ser()
        Try
            ' tb4.Text = Convert.ToString(NumericUpDown1.Value * Convert.ToInt32(Val(tb2.Text) / 100))


        Catch ex As Exception

        End Try


        tb2.Text = Convert.ToString(Val(tb3.Text) + (Val(tb4.Text) + Val(tb6.Text)))
    End Sub

    Private Sub lv_serjury_DoubleClick(sender As Object, e As EventArgs) Handles lv_serjury.DoubleClick

        show_p_details()

    End Sub

    Private Sub lv_serjury_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_serjury.SelectedIndexChanged
        If lv_serjury.SelectedItems.Count > 0 Then

            GroupControl6.Show()
            GroupControl7.Show()
            GroupControl8.Show()
        Else
            GroupControl6.Hide()
            GroupControl7.Hide()
            GroupControl8.Hide()

        End If
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub show_p_details()
        If lv_serjury.SelectedItems.Count > 0 Then
            TabPane1.Pages(1).Caption = "تعديل"
            LabelControl8.Text = "حفظ التعديلات"
            TabPane1.SelectNextPage()
            tb_p_id.Text = lv_serjury.SelectedItems.Item(0).Text
            name2.Text = lv_serjury.SelectedItems.Item(0).SubItems(1).Text
            tb_age.Text = lv_serjury.SelectedItems.Item(0).SubItems(2).Text
            tb_ser_type.Text = lv_serjury.SelectedItems.Item(0).SubItems(3).Text
            dt_enter.Value = Convert.ToDateTime(lv_serjury.SelectedItems.Item(0).SubItems(4).Text)
            dt_out.Value = Convert.ToDateTime(lv_serjury.SelectedItems.Item(0).SubItems(5).Text)
            tb_doctor1.Text = lv_serjury.SelectedItems.Item(0).SubItems(6).Text
            tb_doctor2.Text = lv_serjury.SelectedItems.Item(0).SubItems(7).Text
            tb_total.Text = lv_serjury.SelectedItems.Item(0).SubItems(8).Text

            tb1.Text = lv_serjury.SelectedItems.Item(0).SubItems(9).Text
            tb2.Text = lv_serjury.SelectedItems.Item(0).SubItems(10).Text
            tb3.Text = lv_serjury.SelectedItems.Item(0).SubItems(11).Text
            tb4.Text = lv_serjury.SelectedItems.Item(0).SubItems(12).Text
            tb5.Text = lv_serjury.SelectedItems.Item(0).SubItems(13).Text
            tb6.Text = lv_serjury.SelectedItems.Item(0).SubItems(14).Text
            tb7.Text = lv_serjury.SelectedItems.Item(0).SubItems(15).Text
            tb8.Text = lv_serjury.SelectedItems.Item(0).SubItems(16).Text
            tb9.Text = lv_serjury.SelectedItems.Item(0).SubItems(17).Text
            tb10.Text = lv_serjury.SelectedItems.Item(0).SubItems(18).Text
            tb11.Text = lv_serjury.SelectedItems.Item(0).SubItems(19).Text
            tb12.Text = lv_serjury.SelectedItems.Item(0).SubItems(20).Text
            tb_note.Text = lv_serjury.SelectedItems.Item(0).SubItems(21).Text

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If lv_serjury.SelectedItems.Count > 0 Then
            print_report()

        End If

    End Sub
    Private Sub print_report()
1:
        Dim id As Integer
        id = Convert.ToInt32(lv_serjury.SelectedItems.Item(0).Text)
        Try
            Dim query = "select * from serjury where  serjury.id = " & id & ""

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_ser_report
            fm.filePath = Application.StartupPath & "/serjury.repx"
            fm.ds = getdatat1(query)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub
    Private Sub print_report2()

        If lv_serjury.SelectedItems.Count < 1 Then
            Exit Sub

        End If
1:
        Dim id As Integer
        id = Convert.ToInt32(lv_serjury.SelectedItems.Item(0).Text)
        Try
            Dim query = "select * from serjury where  serjury.id = " & id & ""

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_ser_report
            fm.filePath = Application.StartupPath & "/serjury2.repx"
            fm.ds = getdatat1(query)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        print_report2()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            tb3.Text = "الطبيب متنازل عن المبلغ"
            fun_ser()
            changeMoney()
        Else

            tb3.Text = "0"
            fun_ser()
            changeMoney()
        End If
    End Sub

    Private Sub clear_val()
        tb_p_id.Text = "0"
        name2.Text = ""
        tb_age.Text = "0"

        tb_doctor1.Text = ""
        tb_doctor2.Text = ""
        tb_ser_type.Text = ""
        tb_total.Text = "0"
        tb1.Text = "0"
        tb2.Text = "0"
        tb3.Text = "0"
        tb4.Text = "0"
        tb5.Text = "0"
        tb6.Text = "0"
        tb7.Text = "0"
        tb8.Text = "0"
        tb9.Text = "0"
        tb10.Text = "0"
        tb11.Text = "0"
        tb12.Text = "0"
        tb_note.Text = ""
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        date_search()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        date_search()
    End Sub

    Private Sub tb_id_EditValueChanged(sender As Object, e As EventArgs) Handles tb_id.EditValueChanged

    End Sub

    Private Sub tb_id_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_id.KeyUp
        If e.KeyValue = Keys.Enter Then
            no_search()

        End If
    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged

    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If e.KeyValue = Keys.Enter Then
            name_search()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TabNavigationPage3_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage3.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If lv_serjury.SelectedItems.Count < 1 Then
            Exit Sub

        End If
        fm_bookto.tb_id.Text = lv_serjury.SelectedItems.Item(0).Text

        fm_bookto.Show()

    End Sub

    Private Sub تحاليلوسوناراتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تحاليلوسوناراتToolStripMenuItem.Click
        Try
            If lv_serjury.SelectedItems.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(lv_serjury.SelectedItems.Item(0).Text)
                fm_doctor_main.patient_name = lv_serjury.SelectedItems.Item(0).SubItems(1).Text
                fm_doctor_main.patient_id = id
                fm_doctor_main.tb_patient_number.Text = id.ToString
                fm_doctor_main.select_one()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.TabPane1.SelectNextPage()
                fm_doctor_main.GroupControl1.Hide()
                fm_doctor_main.GroupControl3.Hide()
                fm_doctor_main.GroupControl4.Hide()
                fm_doctor_main.GroupControl9.Hide()
                fm_doctor_main.GroupControl10.Hide()
                fm_doctor_main.SimpleButton7.Hide()
            
                fm_doctor_main.Show()
                fm_doctor_main.patient_id = id
                fm_doctor_main.tb_visit_number.Text = "1"
                fm_doctor_main.tb_patient_number.Text = id.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick
        If is_doctor() Then
            fm_money.Show()

        Else
            MessageBox.Show("ليس لديك الصلاحية")
        End If

    End Sub

    Private Sub tb_doctor1_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_doctor1_search.KeyUp
        date_search()
5:
    End Sub

    Private Sub tb_doctor1_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_doctor1_search.SelectedIndexChanged
        date_search()

    End Sub

    Private Sub وصفةطبيهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles وصفةطبيهToolStripMenuItem.Click
        'Try
        '    If lv_serjury.SelectedItems.Count > 0 Then
        '        Dim id As Integer = getIdForThisName(lv_serjury.SelectedItems.Item(0).SubItems(1).Text)
        '        enter_to_doctor(id)


        '        fm_doctor_main.patient_name = lv_serjury.SelectedItems.Item(0).SubItems(1).Text.Trim
        '        fm_doctor_main.patient_id = id
        '        fm_doctor_main.tb_patient_number.Text = id.ToString
        '        fm_doctor_main.select_one()
        '        fm_doctor_main.TabPane1.SelectNextPage()
        '        fm_doctor_main.Show()
        '        fm_doctor_main.patient_id = id
        '        fm_doctor_main.tb_visit_number.Text = "1"
        '        fm_doctor_main.tb_visit_number.Text = "1"

        '        fm_doctor_main.lv_enterd.Items.Clear()

        '        fm_doctor_main.lv_enterd.Items().Add(id.ToString)
        '        fm_doctor_main.lv_enterd.Items(0).SubItems.Add(lv_serjury.SelectedItems.Item(0).SubItems(1).Text.Trim)

        '        fm_doctor_main.lv_enterd.Items(0).ForeColor = Color.Red

        '        fm_doctor_main.tb_visit_date.Text = Date.Now.ToShortDateString

        '        'اختيار الاسم من الجانب
        '        fm_doctor_main.tb_patient_number.Text = id.ToString

        '        fm_doctor_main.patient_id = id

        '        fm_doctor_main.select_one()
        '        fm_doctor_main.tb_treat_other.Text = lv_serjury.SelectedItems.Item(0).SubItems(6).Text

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    '    Private Sub enter_to_doctor(ByVal id As Integer)
    '1:
    '        Dim tb_wieght = "0.00"

    '        Try


    '                conn = New MySqlConnection()
    '                conn.ConnectionString = serverInfo
    '                conn.Open()

    '                Try


    '                    Dim SQLCommand As New MySqlCommand()
    '                    SQLCommand.Connection = conn
    '                    'SQLCommand.CommandText = "UPDATE queue SET `time` = @time , `state` = @state  WHERE id = @id"

    '                    'SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
    '                    'SQLCommand.Parameters.Add("@state", MySqlDbType.String).Value = entered_state
    '                    'SQLCommand.Parameters.Add("@id", MySqlDbType.Decimal).Value = id

    '                    'SQLCommand.ExecuteNonQuery()



    '                    'جلب مواليد المراجع
    '                    SQLCommand = New MySqlCommand()
    '                    SQLCommand.Connection = conn
    '                Dim query As String = "select * from patient  where id = " & id & ""
    '                    Dim da As New MySqlDataAdapter(query, conn)
    '                    Dim ds As New DataSet()
    '                    da.Fill(ds)
    '                    Dim birthdate As String = ds.Tables(0).Rows(0).Item("birthdate").ToString

    '                    Dim d As New DateTime
    '                    Try
    '                        d = Convert.ToDateTime(birthdate)
    '                    Catch ex As Exception

    '                    End Try


    '                    'اضافة زيارة لمراجع
    '                    SQLCommand = New MySqlCommand()
    '                    SQLCommand.Connection = conn

    '                    SQLCommand.CommandText = "INSERT INTO visit(patient_id , doctor_ID , age , `date` , `time` , test_type , test_amount ,note , weight) VALUES(@patient_id , @doctor_ID , @age , @date , @time , @test_type , @test_amount , @note , @weight)"




    '                SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Decimal).Value = id
    '                    SQLCommand.Parameters.Add("@doctor_ID", MySqlDbType.Decimal).Value = doctor_id_in_visit
    '                    SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Convert.ToDecimal(tb_wieght)
    '                    SQLCommand.Parameters.Add("@age", MySqlDbType.Decimal).Value = fm_queue_option.GetCurrentAge(d)
    '                    SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToLongTimeString)
    '                    SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Convert.ToString(Date.Now.ToShortDateString)
    '                SQLCommand.Parameters.Add("@test_type", MySqlDbType.String).Value = "فحص"
    '                    SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = tb_note.Text
    '                SQLCommand.Parameters.Add("@test_amount", MySqlDbType.Decimal).Value = "0"

    '                    'Dim conent As String = "تم تحويل المراجع  : " & tb_name.Text & " الى الطبيب"
    '                    'add_event(conn, s_convert, conent)

    '                    SQLCommand.ExecuteNonQuery()


    '                    Me.Close()
    '                Catch ex As Exception

    '                    MessageBox.Show(ex.Message)
    '                End Try

    '                'fm_queue.search()
    '                conn.Close()

    '        Catch ex As Exception
    '            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
    '                GoTo 1
    '            End If
    '        End Try



    '    End Sub

    Private Function getIdForThisName(name As String) As Integer

        Dim p As New Patient

        p.name = name.Trim
        Return Convert.ToInt32(p.get_id())

    End Function

End Class