Public Class fm_edit_treatment 

    Private Sub fm_edit_treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        tb_dose_to_patient.EditValue = 0
        tb_dose_to_patient.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tb_note.Text = ""

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If tb_dose_to_patient.Text.Trim = "" Then

            tb_dose_to_patient.BackColor = Color.LightPink
            Exit Sub
        End If
        If tb_treatment_name.EditValue.ToString.Trim = "" Then

            tb_treatment_name.BackColor = Color.LightPink
            Exit Sub
        End If
        If tb_treatment_name.Text.Trim = "" Then

            tb_treatment_name.BackColor = Color.LightPink
            Exit Sub
        End If

        fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(1).Text = tb_treatment_name.Text
        fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(2).Text = tb_dose_to_patient.EditValue.ToString
        fm_add_other_required.lv_treat_table.SelectedItems.Item(0).SubItems(3).Text = tb_note.Text
        fm_add_other_required.calculating_amount()

        Me.Close()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub
End Class