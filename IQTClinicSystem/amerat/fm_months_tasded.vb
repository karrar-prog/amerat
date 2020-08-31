Public Class fm_months_tasded 

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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            tb_arrive.EditValue = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString))
            tb_remand.Text = (__(tb_amount.EditValue.ToString) - __(tb_arrived.EditValue.ToString) - __(tb_arrive.EditValue.ToString)).ToString
        Else
            tb_arrive.EditValue = 0

        End If
        tb_arrive.Focus()

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
        Dim m As New Months()
        m.id = __(tb_id.EditValue.ToString)
        m.arrive_amount = __(tb_arrive.EditValue.ToString) + __(tb_arrived.EditValue.ToString)
        m.note = tb_f1.Text
        m.payment_date = Date.Now.ToString


        excute1("update patient set f4 = f4 - " & tb_arrive.EditValue.ToString & " where id = " & tb_user_id.Text & "")

        m.put_arrive()
        Dim content = ""

        If __(tb_remand.EditValue.ToString) <> 0 Then
            content = " تسديد جزء من جباية " & TextEdit1.Text

        Else
            content = " تسديد جباية " & TextEdit1.Text

        End If



        new_event2("تسديد", content, (__(tb_arrive.EditValue.ToString)))

        fm_add_other_required.all_depts()
        fm_months.search()

        Me.Close()

    End Sub

    Private Sub fm_months_tasded_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class