Public Class fm_fesha
    Public fesha As New Queue
    Private Sub fm_fesha_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Hide()
        fm_queue.Show()


    End Sub

    Private Sub fm_fesha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tb_fesha_id.Text.Trim <> "" Then
            get_info()

        Else
            MessageBox.Show("لاتوجد فيشة")
            Me.Close()

        End If
    End Sub

    Private Sub get_info()
        Try
          
            If fesha.state = "إستلام" Then

                SimpleButton1.Enabled = False
                SimpleButton1.Text = " تم استلام هذه  في " & fesha.recived_date


            End If
            If fesha.id <> 0 Then

                tb_acount_name.Text = fesha.test_amount
                tb_acount_number.Text = fesha.test_min
                tb_bank_name.Text = fesha.test_type

                tb_dept_id.Text = fesha.dept_id.ToString
                tb_dept_title.Text = get_text(fesha.booking_number)
                tb_fesha_amount.Text = fesha.amount.ToString
                tb_amount_text.Text = fesha.amount_text
                tb_number.Text = fesha.booking_number.ToString
                Dim p As New Patient(fesha.patient_id)
                tb_patient_id.Text = p.id.ToString
                tb_patient_name.Text = p.name

                If fesha.dept_id = 0 Then
                    tb1.Text = "0"
                    tb2.Text = p.register_date
                    tb3.Text = p.first_push_amount.ToString
                    tb4.Text = p.first_push_amount_arrived.ToString
                    tb5.Text = "الاولى"
                Else
                    Dim dept As New Dept(fesha.dept_id)

                    tb1.Text = dept.id.ToString
                    Try

                        Dim d As New DateTimePicker
                        d.Value = Convert.ToDateTime(dept.payment_date)
                        tb2.Text = d.Value.ToShortDateString
                    Catch ex As Exception
                        tb2.Text = dept.payment_date
                    End Try

                    tb3.Text = dept.amount.ToString
                    tb4.Text = dept.arrive_amount.ToString
                    tb5.Text = dept.title

                End If


            Else
                MessageBox.Show("اعد قراءة الباركود")
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_patient_id_TextChanged(sender As Object, e As EventArgs) Handles tb_patient_id.TextChanged

    End Sub
    Private Sub tb_patient_name_TextChanged(sender As Object, e As EventArgs) Handles tb_patient_name.TextChanged

    End Sub
    Private Sub tb_number_TextChanged(sender As Object, e As EventArgs) Handles tb_number.TextChanged

    End Sub
    Private Sub tb_acount_name_TextChanged(sender As Object, e As EventArgs) Handles tb_acount_name.TextChanged

    End Sub
    Private Sub tb_acount_number_TextChanged(sender As Object, e As EventArgs) Handles tb_acount_number.TextChanged

    End Sub
    Private Sub tb_note_TextChanged(sender As Object, e As EventArgs) Handles tb_note.TextChanged

    End Sub
    Private Sub tb_bank_name_TextChanged(sender As Object, e As EventArgs) Handles tb_bank_name.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tb3.TextChanged

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If MessageBox.Show(tb_fesha_amount.EditValue.ToString & vbNewLine & tb_amount_text.Text, "هل استلمت المبلغ", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim p As New Patient(__(tb_patient_id.Text))
            If __(tb_dept_id.Text) = 0 Then

                'يعني الدفعة الاولى

                If p.diagonosis.Trim <> "" Then

                    MessageBox.Show("تم استلام الدفعه الاولى في تأريخ " & p.diagonosis)
                    Exit Sub
                End If

                p.first_push_amount_arrived = p.first_push_amount_arrived + ___(tb_fesha_amount.EditValue.ToString)
                p.diagonosis = Date.Now.ToString
                Dim fesha As New Queue(__(tb_fesha_id.Text))

                If p.save() Then
                    Dim content = " تسديد قسط : " & p.name & " الدفعة الاولى " & "للدار " & p.f1 & p.f2 & "." & p.f3
                    new_event2("تسديد دفعة", content, __(tb_fesha_amount.Text))

                    fesha.state = "إستلام"
                    fesha.recived_date = Date.Now.ToString

                    fesha.save()

                Else
                    MessageBox.Show("لم يتم الحفظ")
                End If
            Else
                Dim dept As New Dept(__(tb1.Text))

                Dim fesha As New Queue(__(tb_fesha_id.Text))

                If dept.arrive_amount >= dept.amount Then

                    If MessageBox.Show("هل تريد حذف هذه الفيشة ؟", "تم استلام هذه الدفعة من فيشة اخرى", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

                        fesha.delete()
                        fm_queue.search()
                        SimpleButton1.Enabled = False

                    End If


                Else
                    dept.arrive_amount = __(tb_fesha_amount.Text)
                    dept.arrive_date = Date.Now.ToString
                    dept.status = "إستلام"
                    dept.f5 = tb_fesha_id.Text

                    If dept.update Then

                        Dim content = " تسديد قسط : " & p.name & dept.title & "للدار " & p.f1 & p.f2 & "." & p.f3
                        new_event2("تسديد دفعة", content, __(tb_fesha_amount.Text))

                        fesha.state = "إستلام"
                        fesha.recived_date = Date.Now.ToString
                        fesha.save()
                        fm_queue.search()
                        fm_queue.Show()

                        Me.Close()

                    Else
                        MessageBox.Show("لم تتم العملية")
                    End If


                End If







            End If


        End If
    End Sub
End Class