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

            For i = 1 To __(my_months_count.ToString)

                i2 = i + 1
                fm_add_other_required.lv_treat_table.Items.Add("0")
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(get_text(i + 1))
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(money_per_one_month.ToString)
                fm_add_other_required.lv_treat_table.Items(i).SubItems.Add(FormatNumber(CDbl(present_one.ToString), 1))
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

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        pusts_devided()
    End Sub

  
    Private Sub fm_devided_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cal_first_money()
    End Sub

    Private Sub nu_first_money_present_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_first_money_present.KeyUp
        cal_first_money()
    End Sub

    Private Sub nu_first_present_ValueChanged(sender As Object, e As EventArgs) Handles nu_first_money_present.ValueChanged
        cal_first_money()

    End Sub

    Private Sub cal_first_money()

        tb_first_money.Value = fm_add_other_required.nu_house_price.Value * nu_first_money_present.Value / 100
    End Sub

    Private Sub tb_count_devided_ValueChanged(sender As Object, e As EventArgs) Handles tb_count_devided.ValueChanged

    End Sub
End Class