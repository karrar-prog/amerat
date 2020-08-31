Imports MySql.Data.MySqlClient

Public Class fm_months
    Dim p_DataSet As DataSet

    Private Sub fm_months_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub


    Private Sub fm_months_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_f1.SelectedItem = tb_f1.Items(1)
        tb_months.Text = dt_years.Value.Month.ToString
        formatlist()


    End Sub
    Private Sub formatlist()

        lv_queue.View = View.Details

        lv_queue.Columns.Add("تسلسل", 66)
        lv_queue.Columns.Add("اسم المشترك", 200)
        lv_queue.Columns.Add("هاتف", 150)
        lv_queue.Columns.Add("عدد الامبيرات", 150)
        lv_queue.Columns.Add("بلوك", 110)
        lv_queue.Columns.Add("رقم الدار", 110)
        lv_queue.Columns.Add("نوع الاشتراك", 150)

        lv_dept.View = View.Details


        lv_dept.Columns.Add("تسلسل", 66)
        lv_dept.Columns.Add("رقم المشترك", 0)
        lv_dept.Columns.Add("اسم المشترك", 200)
        lv_dept.Columns.Add("شهر", 50)
        lv_dept.Columns.Add("لسنة", 70)
        lv_dept.Columns.Add("الامبيرات", 90)
        lv_dept.Columns.Add("سعر الامبير", 110)

        lv_dept.Columns.Add("تم التسديد؟", 100)
        lv_dept.Columns.Add("المبلغ الكلي", 90)
        lv_dept.Columns.Add("الواصل", 110)
        lv_dept.Columns.Add("تأريخ التسديد", 210)
        lv_dept.Columns.Add("ملاحظة", 110)
         lv_dept.Columns.Add("", 110)
        lv_dept.Columns.Add("", 110)
        lv_dept.Columns.Add("", 110)
        lv_dept.Columns.Add("", 110)
        lv_dept.Columns.Add("", 110)
        lv_dept.Columns.Add("تم الانشاء", 210)



    End Sub
    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub
    Public Sub search()

1:
        Try
            Dim s As String


            If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                If tb_f9.Text.Trim = "" Or tb_f9.Text.Trim = "الكل" Then
                    s = "select * from patient where id not in ( select user_id from months where month = " & __(tb_months.Text) & " and year = " & dt_years.Value.Year & " ) and deleted = 0  order by id desc "

                Else
                    s = "select * from patient where id not in ( select user_id from months where month = " & __(tb_months.Text) & " and year = " & dt_years.Value.Year & " )  and f9 like '%" & tb_f9.Text & "%' and  deleted = 0  order by id desc "

                End If
                   Else
                If tb_f9.Text.Trim = "" Or tb_f9.Text.Trim = "الكل" Then
                    s = "select * from patient where id not in ( select user_id from months where month = " & __(tb_months.Text) & " and year = " & dt_years.Value.Year & " ) and f1 like '%" & tb_f1.Text & "%'  and deleted = 0  order by id desc "

                Else
                    s = "select * from patient where id not in ( select user_id from months where month = " & __(tb_months.Text) & " and year = " & dt_years.Value.Year & " ) and f1 like '%" & tb_f1.Text & "%'  and f9 like '%" & tb_f9.Text & "%'  and deleted = 0  order by id desc "

                End If

            End If


          

            Dim DataSet = getdatat1(s)
            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_queue.Items.Clear()

            'tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString
            l_count1.Text = " عدد النتائج  :" & DataSet.Tables(0).Rows.Count.ToString



            If DataSet.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                    lv_queue.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("phone").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("ref_by").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f1").ToString & DataSet.Tables(0).Rows(i).Item("f2").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f3").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f5").ToString)
                    'lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
        search2()



    End Sub
    Public Sub search2()

1:
        Try

            Dim months As New Months


            months.year = dt_years.Value.Year
            months.month = __(tb_months.Text)




            Dim query As String

            If tb_f1.Text.Trim = "الكل" Or tb_f1.Text.Trim = "" Then
                If tb_f9.Text.Trim = "" Or tb_f9.Text.Trim = "الكل" Then
                  
                    query = "select *  , patient.f1 as patient_f1  ,patient.f2 as patient_f2  ,patient.f3 as patient_f3 ,patient.f4 as patient_f4 , months.id as months_id   ,months.f1 as months_f1  ,months.f2 as months_f2 ,months.f3 as months_f3  ,months.f4 as months_f4  ,months.f5 as months_f5 from months , patient where year = " & months.year & " and  month = " & months.month & "  and  deleted = 0 and patient.id = months.user_id order by  patient.f1 , patient.f2 , patient.f3 "

                Else

                    query = "select *  , patient.f1 as patient_f1  ,patient.f2 as patient_f2  ,patient.f3 as patient_f3,patient.f4 as patient_f4, months.id as months_id   ,months.f1 as months_f1  ,months.f2 as months_f2 ,months.f3 as months_f3  ,months.f4 as months_f4  ,months.f5 as months_f5 from months , patient where year = " & months.year & " and  month = " & months.month & " and patient.f9 like '%" & tb_f9.Text & "%' and  deleted = 0 and patient.id = months.user_id  order by patient.f1 ,  patient.f2 , patient.f3"

              
                End If
            Else
                If tb_f9.Text.Trim = "" Or tb_f9.Text.Trim = "الكل" Then
                    query = "select *  , patient.f1 as patient_f1  ,patient.f2 as patient_f2  ,patient.f3 as patient_f3 ,patient.f4 as patient_f4 , months.id as months_id   ,months.f1 as months_f1  ,months.f2 as months_f2 ,months.f3 as months_f3  ,months.f4 as months_f4  ,months.f5 as months_f5 from months , patient where year = " & months.year & " and  month = " & months.month & "  and  deleted = 0  and patient.f1 like '%" & tb_f1.Text & "%'  and patient.id = months.user_id  order by patient.f1 , patient.f2 , patient.f3"

           
                Else
                    query = "select *  , patient.f1 as patient_f1  ,patient.f2 as patient_f2  ,patient.f3 as patient_f3,patient.f4 as patient_f4, months.id as months_id   ,months.f1 as months_f1  ,months.f2 as months_f2 ,months.f3 as months_f3  ,months.f4 as months_f4  ,months.f5 as months_f5 from months , patient where year = " & months.year & " and  month = " & months.month & "  and patient.f1 like '%" & tb_f1.Text & "%'  and patient.f9 like '%" & tb_f9.Text & "%' and  deleted = 0 and patient.id = months.user_id  order by patient.f2 ,  patient.f1 , patient.f3  "

      
                End If

            End If




            p_DataSet = months.get_all_months(query)

            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_dept.Items.Clear()

            'tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString

            l_count2.Text = " عدد النتائج  :" & p_DataSet.Tables(0).Rows.Count.ToString

            If p_DataSet.Tables(0).Rows.Count > 0 Then

                For i As Integer = 0 To p_DataSet.Tables(0).Rows.Count - 1
                    lv_dept.Items().Add(p_DataSet.Tables(0).Rows(i).Item("months_id").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("user_id").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("name").ToString & "/" & p_DataSet.Tables(0).Rows(i).Item("patient_f1").ToString & p_DataSet.Tables(0).Rows(i).Item("patient_f2").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("month").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("year").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("amber_count").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("amber_price").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("status").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("total_amount").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("arrive_amount").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("payment_date").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("note").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("months_f1").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("months_f2").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("months_f3").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("months_f4").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("months_f5").ToString)
                    lv_dept.Items(i).SubItems.Add(p_DataSet.Tables(0).Rows(i).Item("create_at").ToString)


                    'lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)


                    If p_DataSet.Tables(0).Rows(i).Item("arrive_amount").ToString = p_DataSet.Tables(0).Rows(i).Item("total_amount").ToString Then
                        lv_dept.Items(i).BackColor = Color.LightGreen
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        search()
    
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        add_all()

      
    End Sub

    Private Sub tb_f9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f9.SelectedIndexChanged
        search()

    End Sub
    Private Function get_plan(ByVal title As String) As Integer
        Dim queue = New DataSet


        queue = getdatat1("SELECT * FROM amount_plan WHERE title LIKE '" & title & "' ")
        If queue.Tables(0).Rows.Count > 0 Then



            Return __(queue.Tables(0).Rows(0).Item("amount").ToString())


        Else
            Return 0

        End If

    End Function
    Private Sub اضافةالىالمستحقينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةالىالمستحقينToolStripMenuItem.Click


        If lv_queue.SelectedItems.Count > 0 Then
            For i = 0 To lv_queue.SelectedItems.Count - 1

                Dim months As New Months
                months.month = __(tb_months.Text.Trim)
                months.status = "لا"
                months.arrive_amount = 0
                months.user_did_id = user.id
                months.year = dt_years.Value.Year
                months.user_id = __(lv_queue.SelectedItems.Item(i).Text)
                months.amber_count = __(lv_queue.SelectedItems.Item(i).SubItems(3).Text)
                months.f5 = lv_queue.SelectedItems.Item(i).SubItems(6).Text
                months.amber_price = get_plan(lv_queue.SelectedItems.Item(i).SubItems(6).Text)
                months.total_amount = get_plan(lv_queue.SelectedItems.Item(i).SubItems(6).Text) * __(lv_queue.SelectedItems.Item(i).SubItems(3).Text)
                months.create_at = Date.Now.ToString
                months.note = ""

                months.save()

                excute1("update patient set f4 = f4 + " & months.total_amount & " where id = " & months.user_id & "")


            Next
            search()
            
        End If
    End Sub

    Private Sub tb_months_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_months.SelectedIndexChanged
        search()

    End Sub

    Private Sub tb_f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f1.SelectedIndexChanged
        search()

    End Sub

    Private Sub dt_years_ValueChanged(sender As Object, e As EventArgs) Handles dt_years.ValueChanged
        search()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If lv_dept.SelectedItems.Count > 0 Then
            For i = 0 To lv_dept.SelectedItems.Count - 1
                Dim id = __(lv_dept.SelectedItems.Item(i).Text)
                Dim months = New Months
                Dim dataset As New DataSet
                dataset = months.get_one(id)
                Dim f As New fm_x_viewer_treat

                f.ds = dataset

                f.user_name = ""
                f.final_price = ""
                f.arrive = ""
                f.remaind = ""
                f.admin_name = user.name
                f.path = "months"


                f.user_dar = ""
                f.user_block = ""


                f.Show()
            Next



        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        add_all()
        print_all()

    End Sub

    Private Sub add_all()
        If lv_queue.Items.Count > 0 Then
            For i = 0 To lv_queue.Items.Count - 1

                Dim months As New Months
                months.month = __(tb_months.Text.Trim)
                months.status = "لا"
                months.arrive_amount = 0
                months.user_did_id = user.id
                months.year = dt_years.Value.Year
                months.user_id = __(lv_queue.Items.Item(i).Text)
                months.amber_count = __(lv_queue.Items.Item(i).SubItems(3).Text)
                months.f5 = lv_queue.Items.Item(i).SubItems(6).Text
                months.amber_price = get_plan(lv_queue.Items.Item(i).SubItems(6).Text)
                months.total_amount = months.amber_price * __(lv_queue.Items.Item(i).SubItems(3).Text)
                months.create_at = Date.Now.ToString
                months.note = ""
                months.save()
                excute1("update patient set f4 = f4 + " & months.total_amount & " where id = " & months.user_id & "")
            Next
            search()

        End If
    End Sub

    Private Sub print_all()




    End Sub
    Private Sub print()

        Dim f As New fm_x_viewer_treat

        f.ds = p_DataSet

        f.user_name = ""
        f.final_price = ""
        f.arrive = ""
        f.remaind = ""
        f.admin_name = user.name
        f.path = "months"


        f.user_dar = ""
        f.user_block = ""


        f.Show()


    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        print()
    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click

        If hasPermission("حذف") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_dept.SelectedItems.Count > 0 Then
          
            If MessageBox.Show("حل تريد الحذف ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                For i = 0 To lv_dept.SelectedItems.Count - 1

                    delete_month(__(lv_dept.SelectedItems.Item(i).Text), __(lv_dept.SelectedItems.Item(i).SubItems(8).Text) - __(lv_dept.SelectedItems.Item(i).SubItems(9).Text), __(lv_dept.SelectedItems.Item(i).SubItems(1).Text))

                Next

            End If
            search()

        End If
    End Sub

    Private Sub delete_month(id As Integer, price As Integer, user_id As Integer)
        excute1("delete from months where id = " & id & "")
        excute1("update patient set f4 = f4 - " & price & " where id = " & user_id & "")
    End Sub

    Private Sub الديونToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الديونToolStripMenuItem.Click
        If lv_dept.SelectedItems.Count > 0 Then

            fm_add_other_required.tb_id.Text = lv_dept.SelectedItems.Item(0).SubItems(1).Text
            fm_add_other_required.tb_name.Text = lv_dept.SelectedItems.Item(0).SubItems(2).Text
            fm_add_other_required.Show()



        End If
    End Sub

    Private Sub تسديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسديدToolStripMenuItem.Click
        If lv_dept.SelectedItems.Count = 1 Then
            fm_months_tasded.tb_id.Text = lv_dept.SelectedItems.Item(0).Text
            fm_months_tasded.tb_amount.Text = lv_dept.SelectedItems.Item(0).SubItems(8).Text
            fm_months_tasded.tb_arrived.Text = lv_dept.SelectedItems(0).SubItems(9).Text
            fm_months_tasded.tb_arrive.Text = (__(fm_months_tasded.tb_amount.EditValue.ToString) - __(fm_months_tasded.tb_arrived.EditValue.ToString)).ToString
            fm_months_tasded.tb_user_id.Text = lv_dept.SelectedItems(0).SubItems(1).Text

            fm_months_tasded.TextEdit1.Text = "(  " & lv_dept.SelectedItems.Item(0).SubItems(3).Text & "-" & lv_dept.SelectedItems.Item(0).SubItems(4).Text & "  )" & lv_dept.SelectedItems.Item(0).SubItems(2).Text
            fm_months_tasded.Show()
        Else
            MessageBox.Show("اختر واحد")
        End If

    End Sub

    Private Sub تعديلمعلوماتالمشتركToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلمعلوماتالمشتركToolStripMenuItem.Click
        If hasPermission("ادارة") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If lv_dept.SelectedItems.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(lv_dept.SelectedItems.Item(0).SubItems(1).Text)


            Dim patient As New Patient(id)

            fm_add_patient.tb_id.Text = patient.id.ToString
            fm_add_patient.tb_name.Text = patient.name
            fm_add_patient.tb_note.Text = patient.note
            Try
                fm_add_patient.dt_birthdate.Value = Convert.ToDateTime(patient.birthdate)
                fm_add_patient.dt_register_date.Value = Convert.ToDateTime(patient.register_date)

            Catch ex As Exception

            End Try

            fm_add_patient.tb_wieght.Text = patient.wieght
            fm_add_patient.tb_phone.Text = patient.phone
            fm_add_patient.tb_ref_by.Text = patient.ref_by



            fm_add_patient.tb_wieght.Text = patient.f1
            fm_add_patient.nu_blok_num.Value = __(patient.f2)
            fm_add_patient.num_home_num.Value = __(patient.f3)

            fm_add_patient.tb_f6.Text = patient.f6
            fm_add_patient.tb_f7.Text = patient.f7
            fm_add_patient.tb_f8.Text = patient.f8

            fm_add_patient.tb_note.Text = patient.f10


            fm_add_patient.Show()
            fm_add_patient.cb_plan.Text = patient.f5


            fm_add_patient.re = "5"
            Me.Hide()



        End If
    End Sub
End Class