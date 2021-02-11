Public Class fm_taajeel 

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        If MessageBox.Show("", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

            Dim dept As New Dept
            Dim d As New DateTimePicker
            Dim taajeel_date As New DateTimePicker
            d.Value = Convert.ToDateTime(tb_payment_date.Text)
            taajeel_date.Value = d.Value.AddDays(NumericUpDown1.Value)
            dept.taajeel(__(tb_id.Text), NumericUpDown1.Value, taajeel_date.Value)
            fm_months_shoud_push.search()

        End If

    End Sub
End Class