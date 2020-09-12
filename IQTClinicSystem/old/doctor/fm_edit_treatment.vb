Public Class fm_edit_treatment 
    Dim from = "treat"

    Private Sub fm_edit_treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        tb_selected_money.Value = 0
        tb_selected_money.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tb_note.Text = ""

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
      
        If tb_treatment_name.EditValue.ToString.Trim = "" Then

            tb_treatment_name.BackColor = Color.LightPink
            Exit Sub
        End If
        If tb_treatment_name.Text.Trim = "" Then

            tb_treatment_name.BackColor = Color.LightPink
            Exit Sub
        End If
        'lv.Columns.Add("ت", 1)
        'lv.Columns.Add("العنوان", 140)
        'lv.Columns.Add("المبلغ", 120)
        'lv.Columns.Add("النسبة", 60)
        'lv.Columns.Add("المبلغ كتابة", 290)
        'lv.Columns.Add("عدد الاشهر", 100)
        'lv.Columns.Add("تأريخ الاستحقاق", 100)

        If from = "treat" Then
            fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(1).Text = tb_treatment_name.Text
            fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(2).Text = tb_selected_money.Value.ToString
            fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(3).Text = tb_present.Value.ToString
            fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(3).Text = tb_present.Value.ToString
            fm_add_other_required.calculating_amount()
        Else

        End If


        Me.Close()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub
End Class