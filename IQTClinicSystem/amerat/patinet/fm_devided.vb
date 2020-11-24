Imports DevExpress.LookAndFeel

Public Class fm_devided

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Me.Close()

    End Sub
    Private Sub pusts_devided()
1:
        Dim my_amount As Decimal = nu_first_part.Value - tb_first_money.Value
        Dim my_months_count As Decimal = tb_count_devided.Value - 1
        Dim money_per_one_month As Decimal = my_amount / my_months_count
        Dim present_one As Decimal = (money_per_one_month / fm_add_other_required.nu_house_price.Value) * 100
        Try
            'lv.Columns.Add("ت", 1)
            'lv.Columns.Add("العنوان", 220)
            'lv.Columns.Add("المبلغ", 170)
            'lv.Columns.Add("النسبة", 80)
            'lv.Columns.Add("المبلغ كتابة", 250)
            'lv.Columns.Add("عدد الاشهر", 150)
            'lv.Columns.Add("تأريخ الاستحقاق", 100)


            fm_add_other_required.lv_treat_table.Items.Clear()
            Dim i2 As Decimal = 0
            fm_add_other_required.lv_treat_table.Items.Add("0")
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(get_text(1))
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(tb_first_money.Value.ToString)
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(nu_first_money_present.Value.ToString)
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(ToArabicLetter(tb_first_money.Value))

            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(tb_months_period.Value.ToString)
            fm_add_other_required.first_push_present = nu_first_money_present.Value
            fm_add_other_required.first_push = tb_first_money.Value
            fm_add_other_required.first_push_text = ToArabicLetter(tb_first_money.Value)

            For i = 1 To __(my_months_count.ToString)

                i2 = i + 1
                fm_add_other_required.lv_treat_table.Items.Add("0")
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(get_text(i + 1))
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(money_per_one_month.ToString)
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(FormatNumber(CDbl(present_one.ToString), 0))
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(ToArabicLetter(money_per_one_month))

                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(tb_months_period.Value.ToString)




            Next

            fm_add_other_required.calculating_amount()
            Me.Close()

        Catch ex As Exception
            If MessageBox.Show(ex.Message & "Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Private Sub new_pusts_devided()
1:
        Dim my_amount As Decimal = nu_first_part.Value - tb_first_money.Value
        Dim my_months_count As Decimal = tb_count_devided.Value - 1
        'Dim money_per_one_month As Decimal = my_amount / my_months_count
        'Dim present_one As Decimal = (money_per_one_month / fm_add_other_required.nu_house_price.Value) * 100
        Try
            'lv.Columns.Add("ت", 1)
            'lv.Columns.Add("العنوان", 220)
            'lv.Columns.Add("المبلغ", 170)
            'lv.Columns.Add("النسبة", 80)
            'lv.Columns.Add("المبلغ كتابة", 250)
            'lv.Columns.Add("عدد الاشهر", 150)
            'lv.Columns.Add("تأريخ الاستحقاق", 100)


            fm_add_other_required.lv_treat_table.Items.Clear()
            Dim i2 As Decimal = 0
            fm_add_other_required.lv_treat_table.Items.Add("0")
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(get_text(1))
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(Math.Floor(tb_first_money.Value).ToString)
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(nu_first_money_present.Value.ToString)
            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(ToArabicLetter(Math.Floor(tb_first_money.Value)))

            fm_add_other_required.lv_treat_table.Items(0).SubItems.Add(tb_months_period.Value.ToString)
            fm_add_other_required.first_push_present = nu_first_money_present.Value
            fm_add_other_required.first_push = Math.Floor(tb_first_money.Value)
            fm_add_other_required.first_push_text = ToArabicLetter(Math.Floor(tb_first_money.Value))

            For i = 1 To __(my_months_count.ToString) - 1

                fm_add_other_required.lv_treat_table.Items.Add("0")
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(get_text(i + 1))
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(Math.Floor(tb_midel_amount.Value).ToString)
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(nu_midel.Value.ToString)
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(ToArabicLetter(Math.Floor(tb_midel_amount.Value)))

                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(tb_months_period.Value.ToString)




            Next
            Dim ii As Integer = __(my_months_count.ToString)
            fm_add_other_required.lv_treat_table.Items.Add("0")
            fm_add_other_required.lv_treat_table.Items(ii).SubItems.Add(get_text(ii + 1))
            fm_add_other_required.lv_treat_table.Items(ii).SubItems.Add(Math.Floor(tb_last_amount.Value).ToString)
            fm_add_other_required.lv_treat_table.Items(ii).SubItems.Add(nu_last.Value.ToString)
            fm_add_other_required.lv_treat_table.Items(ii).SubItems.Add(ToArabicLetter(Math.Floor(tb_last_amount.Value)))

            fm_add_other_required.lv_treat_table.Items(ii).SubItems.Add(tb_months_period.Value.ToString)


            fm_add_other_required.calculating_amount()
            Me.Close()

        Catch ex As Exception
            If MessageBox.Show(ex.Message & "Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If money_equal() Then
            new_pusts_devided()
        Else
            MessageBox.Show("المبلغ غير متساوي")
        End If

    End Sub


    Private Sub fm_devided_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
        check_first_push()

        cal_first_money()

    End Sub

    Private Sub nu_first_money_present_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_first_money_present.KeyUp
        cal_first_money()

    End Sub

    Private Sub nu_first_present_ValueChanged(sender As Object, e As EventArgs) Handles nu_first_money_present.ValueChanged
        cal_first_money()

    End Sub

    Private Sub cal_first_money()
        precent_cal()
        tb_first_money.Value = fm_add_other_required.nu_house_price.Value * nu_first_money_present.Value / 100
        tb_midel_amount.Value = fm_add_other_required.nu_house_price.Value * nu_midel.Value / 100
        tb_last_amount.Value = fm_add_other_required.nu_house_price.Value * nu_last.Value / 100
        tb_total_amount.Value = tb_first_money.Value + (tb_midel_amount.Value * (tb_count_devided.Value - 2)) + tb_last_amount.Value

        If money_equal() Then
            tb_total_amount.BackColor = Color.LightGreen
            nu_total.BackColor = Color.LightGreen
        Else
            tb_total_amount.BackColor = Color.LightPink
            nu_total.BackColor = Color.LightPink

        End If

    End Sub

    Private Sub tb_count_devided_ValueChanged(sender As Object, e As EventArgs) Handles tb_count_devided.ValueChanged
        precent_cal()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub precent_cal()
        nu_total.Value = nu_first_money_present.Value + (nu_midel.Value * (tb_count_devided.Value - 2)) + nu_last.Value
    End Sub

    Private Sub nu_midel_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_midel.KeyUp
        cal_first_money()
    End Sub

    Private Sub nu_midel_ValueChanged(sender As Object, e As EventArgs) Handles nu_midel.ValueChanged
        cal_first_money()
    End Sub

    Private Sub nu_last_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_last.KeyUp
        cal_first_money()
    End Sub

    Private Sub nu_last_ValueChanged(sender As Object, e As EventArgs) Handles nu_last.ValueChanged
        cal_first_money()
    End Sub

    Private Sub nu_total_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_total.KeyUp
        cal_first_money()
    End Sub

    Private Sub nu_total_ValueChanged(sender As Object, e As EventArgs) Handles nu_total.ValueChanged
        cal_first_money()
    End Sub

    Private Sub tb_first_money_ValueChanged(sender As Object, e As EventArgs) Handles tb_first_money.ValueChanged

    End Sub

    Private Function money_equal() As Boolean
        If tb_total_amount.Value = nu_first_part.Value Then
            Return True
        Else
            Return False

        End If
    End Function

    Private Sub check_first_push()
        Try
            Dim p As New Patient(__(fm_add_other_required.tb_id.Text))

            If p.first_push_amount_arrived > 0 Then
                nu_first_part.Value = p.first_part

                nu_first_part.Enabled = False

                nu_first_money_present.Value = p.first_push_present
                nu_first_money_present.Enabled = False
                nu_first_money_present.BackColor = Color.Green
                Label14.Text = "تم استلام الدفعة الاولى"

            End If

        Catch ex As Exception

        End Try


    End Sub

End Class