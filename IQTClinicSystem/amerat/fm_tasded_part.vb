Public Class fm_tasded_part 

    Private Sub tb_arrive_EditValueChanged(sender As Object, e As EventArgs) Handles tb_arrive.EditValueChanged

    End Sub

    Private Sub tb_arrive_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_arrive.KeyUp
        If __(tb_arrive.EditValue.ToString) > (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString)) Then
            tb_arrive.EditValue = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString))
            tb_remand.Text = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString) - __(tb_arrive.EditValue.ToString)).ToString

        Else
            tb_remand.Text = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString) - __(tb_arrive.EditValue.ToString)).ToString


        End If
    End Sub

    Private Sub fm_tasded_part_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_remand.Text = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString) - __(tb_arrive.EditValue.ToString)).ToString
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If hasPermission("تسديد") Then
         
        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        Dim d As New Dept()
        d.id = __(tb_id.Text)
        d.arrive_amount = __(tb_arrive.EditValue.ToString) + __(tb_arrived.EditValue.ToString)
        d.f1 = tb_f1.Text
        excute1("update patient set f4 = f4 - " & tb_arrive.EditValue.ToString & " where id = " & tb_user_id.Text & "")

        d.tasded2()
        Dim content = "تسديد ديون  "
        new_event2("تسديد", content, (__(tb_arrive.EditValue.ToString)))

        fm_add_other_required.all_depts()
        Me.Close()

    End Sub
End Class