Imports MySql.Data.MySqlClient

Public Class fm_tanazol

    Private Sub fm_tanazol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatlist()
        search()

    End Sub
    Private Sub formatlist()

        lv_queue.View = View.Details

        lv_queue.Columns.Add("رقم التنازل", 100)
        lv_queue.Columns.Add("رقم العقد", 120)
        lv_queue.Columns.Add("الزبون المتنازل", 220)
        lv_queue.Columns.Add("هاتف", 145)
        lv_queue.Columns.Add("الزبون الجديد", 220)
        lv_queue.Columns.Add("تأريخ التنازل", 200)


        lv_queue.Columns.Add("بلوك", 90)
        lv_queue.Columns.Add("رقم الدار", 90)
        lv_queue.Columns.Add("المبلغ الكلي", 120)
        lv_queue.Columns.Add("تأريخ التعاقد", 10)
        lv_queue.Columns.Add("حالة البيع", 10)
        lv_queue.Columns.Add("حالة ألفيشة", 130)
        lv_queue.Columns.Add("تأريخ الفيشة الاولى", 10)
        lv_queue.Columns.Add("حالة البصمة", 10)
    


    End Sub
    Public Sub search()


        Dim s As String = "select * from patient2 WHERE patient_id = " & tb_patient_id.Text & "  order by id desc "

        Dim DataSet = getdatat1(s)
        fill_db(DataSet)


    End Sub
    Private Sub fill_db(DataSet As DataSet)
1:
        Try
            Dim dt As New DateTimePicker
            Dim c As Integer
            lv_queue.Items.Clear()
            DataSet.Tables(0).Columns.Add("s1")
            DataSet.Tables(0).Columns.Add("s2")
            DataSet.Tables(0).Columns.Add("s3")
            DataSet.Tables(0).Columns.Add("s4")
            If DataSet.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                    lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("patient_id").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("gender").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("token_date").ToString)


                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("house_price").ToString)

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("register_date").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("is_token").ToString)


                    If DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_not_booking Then
                        lv_queue.Items(i).BackColor = Color.LightGreen
                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then
                        lv_queue.Items(i).BackColor = Color.LightPink

                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_deal Then

                        lv_queue.Items(i).BackColor = Color.Gold

                    End If

                    If DataSet.Tables(0).Rows(i).Item("first_push_amount_arrived").ToString.Trim <> "0" And DataSet.Tables(0).Rows(i).Item("first_push_amount_arrived").ToString.Trim <> "" Then
                        lv_queue.Items(i).SubItems.Add("الفيشة مستلمة")
                        lv_queue.Items(i).SubItems(7).ForeColor = Color.Green
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s1", "الفيشة مستلمة")

                    ElseIf DataSet.Tables(0).Rows(i).Item("first_push_amount").ToString.Trim <> "0" And DataSet.Tables(0).Rows(i).Item("first_push_amount").ToString.Trim <> "" Then
                        lv_queue.Items(i).SubItems.Add("انتظار الفيشة")
                        lv_queue.Items(i).SubItems(8).ForeColor = Color.Yellow
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s1", "انتظار الفيشة")

                    ElseIf DataSet.Tables(0).Rows(i).Item("is_token").ToString = s_booking Then

                        lv_queue.Items(i).SubItems.Add("حجز فقط")
                        lv_queue.Items(i).SubItems(7).BackColor = Color.LightPink
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s1", "حجز فقط")

                    Else
                        lv_queue.Items(i).SubItems.Add("")
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s1", "")

                    End If
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("diagonosis").ToString)
                    DataSet.Tables(0).Rows(i).SetField(Of String)("s2", DataSet.Tables(0).Rows(i).Item("diagonosis").ToString)

                    If DataSet.Tables(0).Rows(i).Item("finger_print").ToString = "" Then
                        lv_queue.Items(i).SubItems.Add("لم تسجل بصمة")
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s3", "لم تسجل بصمة")

                    ElseIf DataSet.Tables(0).Rows(i).Item("finger_print").ToString = "no" Then
                        lv_queue.Items(i).SubItems.Add("تعذر تسجيل البصمة")
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s3", "تعذر تسجيل البصمة")

                    Else
                        lv_queue.Items(i).SubItems.Add("تم التسجيل ")
                        DataSet.Tables(0).Rows(i).SetField(Of String)("s3", "تم التسجيل")

                    End If
               
            
                Next
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If tb_gender.Text.Trim = "" Then
            MessageBox.Show("ادخل اسم الزبون الجديد")
            Exit Sub
        End If
        If tb_gender.Text.Length < 5 Then
            MessageBox.Show("اسم الزبون قصير")
            Exit Sub
        End If
        If MessageBox.Show("هل انت متأكد", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim new_p As New Patient(__(tb_patient_id.Text))
            Dim old_p As New patient2()
            old_p.patient_id = new_p.id

            old_p.id = 0
            old_p.note = new_p.note
            old_p.code = new_p.code
            old_p.name = new_p.name
            old_p.phone = new_p.phone


            old_p.last_present = new_p.last_present
            old_p.register_date = new_p.register_date
            old_p.saller = new_p.saller
            old_p.f1 = new_p.f1
            old_p.f2 = new_p.f2

            old_p.f3 = new_p.f3
            old_p.f4 = new_p.f4
            old_p.f5 = new_p.f5
            old_p.f6 = new_p.f6
            old_p.f7 = new_p.f7

            old_p.f8 = new_p.f8
            old_p.f9 = new_p.f9
            old_p.f10 = new_p.f10
            old_p.first_present = new_p.first_present
            old_p.ref_by = new_p.ref_by

            old_p.diagonosis = new_p.diagonosis
            old_p.house_price = new_p.house_price
            old_p.first_part = new_p.first_part
            old_p.last_part = new_p.last_part
            old_p.gender = tb_gender.Text

            old_p.token_date = Date.Now.ToShortDateString
            old_p.house_price = new_p.house_price
            old_p.first_part = new_p.first_part
            old_p.last_part = new_p.last_part
            old_p.gender = tb_gender.Text

            old_p.first_push_amount = new_p.first_push_amount
            old_p.first_push_present = new_p.first_push_present
            old_p.water_price = new_p.water_price
            old_p.wieght = new_p.wieght
            old_p.note = new_p.note

            old_p.finger_print = new_p.finger_print
            
            old_p.save()

            search()

       
        End If
    End Sub
End Class