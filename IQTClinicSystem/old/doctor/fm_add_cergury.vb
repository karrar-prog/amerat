Public Class fm_add_cergury 

    Private Sub fm_add_cergury_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
1:
        Try
            Dim m As New MedicalOperation
            m.content = tb_content.Text
            m.d_date = tb_date.Value
            m.time = tb_time.Value
            m.note = tb_note.Text
            m.patient_id = Convert.ToInt32(tb_patient_number.Text)
            m.title = tb_title.Text
            m.other = tb_diagonosis.Text
            If m.save() Then

                fm_doctor_main.get_medical_operation()


                Me.Close()

            Else
                MessageBox.Show("لم تتم الاضافة")
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class