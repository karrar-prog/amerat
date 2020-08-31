Public Class fm_add_other_dept_item 

    Private Sub fm_add_other_dept_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
   

  
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If tb_dose_to_patient.Text.Trim = "" Then

            tb_dose_to_patient.BackColor = Color.LightPink
            Exit Sub
        End If
        If tb_treatment_name.EditValue.ToString.Trim = "" Then

            tb_treatment_name.BackColor = Color.LightPink
            Exit Sub
        End If
        fm_add_other_required.lv_treat_table.Items.Add("1")

        fm_add_other_required.lv_treat_table.Items(fm_add_other_required.lv_treat_table.Items.Count - 1).SubItems.Add(tb_treatment_name.Text)
        fm_add_other_required.lv_treat_table.Items(fm_add_other_required.lv_treat_table.Items.Count - 1).SubItems.Add(tb_dose_to_patient.EditValue.ToString)
        fm_add_other_required.lv_treat_table.Items(fm_add_other_required.lv_treat_table.Items.Count - 1).SubItems.Add(tb_note.Text)
        fm_add_other_required.lv_treat_table.Items(fm_add_other_required.lv_treat_table.Items.Count - 1).SubItems.Add(tb_note.Text)

        fm_add_other_required.calculating_amount()

        Me.Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_dose_to_patient.EditValue = 0
        tb_dose_to_patient.Focus()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        tb_note.Text = ""

    End Sub
End Class