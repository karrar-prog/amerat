Imports MySql.Data.MySqlClient

Public Class fm_fesha_collectiom
    Public id_list_int As List(Of Integer)
    Public f_id As Integer

    Private Sub fm_fesha_collectiom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatlist()
        search()
    End Sub
    Private Sub formatlist()
        lv_queue.View = View.Details

        lv_queue.Columns.Add("رقم الدفعة", 0)
        lv_queue.Columns.Add("رقم العقد", 120)
        lv_queue.Columns.Add("اسم الزبون", 0)
        lv_queue.Columns.Add("المبلغ", 140)
        lv_queue.Columns.Add("تأريخ الارسال", 0)
        lv_queue.Columns.Add("الحالة", 0)
        lv_queue.Columns.Add("تسلسل الفيشة", 0)
        lv_queue.Columns.Add("تأريخ الاستلام", 0)
        lv_queue.Columns.Add("تسلسل الدفعة", 0)
        lv_queue.Columns.Add("ملاحظة", 0)
        lv_queue.Columns.Add("الدفعة", 120)
        lv_queue.Columns.Add("", 0)
        lv_queue.Columns.Add("", 0)
        lv_queue.Columns.Add("رقم الدار", 200)

    End Sub
    Public Sub search()
1:

        Try
            Dim values = String.Join(",", id_list_int.Select(Function(f) String.Format("{0}", f)).ToArray())


            Dim s As String = String.Format("select * , queue.id as queueID ,queue.f1 as f1 ,queue.f2 as f2 , queue.f3 as f3 , queue.note as note ,  queue.`date` as queue_date , queue.booking_number as booking_number , queue.test_type as test_type  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id ,patient.f1 as p1,patient.f2 as p2 ,patient.f3 as p3,patient.name as p_name from queue , patient WHERE queue.id IN ({0}) and patient.id = queue.patient_id order by queue.id", values)
            Dim DataSet = getdatat1(s)
            Dim c_enter = 0
            Dim time As New DateTimePicker

            Dim td_date As New DateTimePicker
            lv_queue.Items.Clear()
            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1

            
             

                lv_queue.Items.Add(DataSet.Tables(0).Rows(i).Item("booking_number").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("patient_id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("amount").ToString)
                td_date.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("date").ToString)
                lv_queue.Items(i).SubItems.Add(td_date.Value.ToShortDateString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("state").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("recived_date").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("dept_id").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f2").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("p1").ToString & DataSet.Tables(0).Rows(i).Item("p2").ToString & "." & DataSet.Tables(0).Rows(i).Item("p3").ToString)



            Next



        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If MessageBox.Show(tb_fesha_amount.EditValue.ToString & vbNewLine & tb_amount_text.Text, "  هل تم استلام المبلغ", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim p_id As Integer
            Dim dept_id As Integer
            Dim dept_amount As Integer

            Dim fesha_id As Integer

            For i = 0 To lv_queue.Items.Count - 1

                p_id = __(lv_queue.Items.Item(i).SubItems(1).Text)
                dept_id = __(lv_queue.Items.Item(i).SubItems(8).Text)
                dept_amount = __(lv_queue.Items.Item(i).SubItems(3).Text)

                fesha_id = __(lv_queue.Items.Item(i).SubItems(6).Text)



                Dim p As New Patient(p_id)
                If dept_id = 0 Then

                    'يعني الدفعة الاولى

                    If p.diagonosis.Trim <> "" Then

                        MessageBox.Show("تم استلام الدفعه الاولى في تأريخ " & p.diagonosis)

                    End If

                    p.first_push_amount_arrived = dept_amount
                    p.diagonosis = Date.Now.ToString
                    Dim fesha As New Queue(fesha_id)

                    If p.save() Then
                        Dim content = "فيشة رقم" & fesha_id.ToString & " تسديد قسط : " & p.name & " الدفعة الاولى " & "للدار " & p.f1 & p.f2 & "." & p.f3
                        new_event2("استلام فيشة متعددة" & tb_fesha_id.Text, content, dept_amount)
                        fesha.state = "إستلام"
                        fesha.recived_date = Date.Now.ToString
                        fesha.save()

                    Else
                        MessageBox.Show("لم يتم الحفظ")
                    End If
                Else
                    Dim dept As New Dept(dept_id)
                    Dim fesha As New Queue(fesha_id)
                    If dept.arrive_amount >= dept.amount Then
                        If MessageBox.Show("هل تريد حذف هذه الفيشة ؟", "تم استلام هذه الدفعة من فيشة اخرى", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                            fesha.delete()
                      
                        End If
                    Else
                        dept.arrive_amount = dept_amount
                        dept.arrive_date = Date.Now.ToString
                        dept.status = "إستلام"
                        dept.f5 = tb_fesha_id.Text
                        If dept.update Then
                            Dim content = "فيشة رقم" & fesha_id.ToString & " تسديد قسط : " & p.name & dept.title & "للدار " & p.f1 & p.f2 & "." & p.f3
                            new_event2("استلام فيشة متعددة" & tb_fesha_id.Text, content, dept_amount)
                            fesha.state = "إستلام"
                            fesha.recived_date = Date.Now.ToString
                            fesha.save()
                        
                        Else
                            MessageBox.Show("لم تتم العملية")
                        End If
                    End If
                End If


            Next
            Dim s As String = ""

            For Each id In id_list_int
                s = s & " - " & id.ToString

            Next
            Dim c_fesha As New Queue(fesha_id)
            c_fesha.state = "إستلام"
            c_fesha.recived_date = Date.Now.ToString
            c_fesha.save()
            fm_queue.search()
            fm_queue.Show()
            MessageBox.Show("تم استلام الفيشة المتعددة")
            Me.Close()

        End If
    End Sub
End Class