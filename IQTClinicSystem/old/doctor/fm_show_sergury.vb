Imports MySql.Data.MySqlClient

Public Class fm_show_sergury

    Private Sub fm_show_sergury_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_doctor_main.Show()

    End Sub

    Private Sub fm_show_sergury_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        format_list()
        MySearch()


    End Sub

    Private Sub format_list()
        lv_sergury.View = View.Details
        lv_sergury.Columns.Add("ت", 50)
        lv_sergury.Columns.Add("اسم المراجع", 200)
        lv_sergury.Columns.Add("العنوان", 122)
        lv_sergury.Columns.Add("التأريخ", 150)
        lv_sergury.Columns.Add("الوقت", 130)
        lv_sergury.Columns.Add("التشخيص", 122)
        lv_sergury.Columns.Add("تفاصيل", 222)
        lv_sergury.Columns.Add("ملاحظات", 282)
        lv_sergury.Columns.Add("تسلسل المريض", 400)
    End Sub

    Public Sub MySearch()
        Dim ser_status As String
        If r_yes.Checked Then
            ser_status = r_yes.Text
        Else
            ser_status = r_no.Text
        End If

1:
        Try
            Dim s As String = "SELECT patient.id AS p_id , patient.name AS name , medical_operation.title AS `title` ,medical_operation.id AS `id` ,medical_operation.content AS `content` ,medical_operation.other AS `other`,medical_operation.note AS `note` , medical_operation.treatment AS treatment , medical_operation.`date` AS `date` , medical_operation.`time` as `time`  FROM medical_operation , patient WHERE patient.id = medical_operation.patient_id AND  medical_operation.treatment like  '%" & ser_status & "%' AND ( medical_operation.date between '" & tb_date.Value.ToShortDateString & "' AND '" & DateTimePicker1.Value.ToShortDateString & "' )  order by medical_operation.date"

            Dim DataSet = getdatat1(s)
            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_sergury.Items.Clear()

            tb_count.Caption = DataSet.Tables(0).Rows.Count.ToString & "  عملية  "


            If DataSet.Tables(0).Rows.Count > 0 Then

                fm_doctor_main.btn_notification.Text = DataSet.Tables(0).Rows.Count.ToString

                If DataSet.Tables(0).Rows.Count - 1 > 90 Then
                    c = 88
                Else

                    c = DataSet.Tables(0).Rows.Count - 1
                End If
                For i As Integer = 0 To c
                    lv_sergury.Items().Add(DataSet.Tables(0).Rows(i).Item("id").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("title").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("date").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("time").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("other").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("content").ToString)
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)

                    If DataSet.Tables(0).Rows(i).Item("treatment").ToString = "نعم" Then
                        lv_sergury.Items(i).BackColor = Color.LightGreen

                    End If
                    lv_sergury.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("p_id").ToString)

                Next
            End If
        Catch ex As MySqlException

            If MessageBox.Show("Retry اعد الاتصال واضغط " & vbNewLine & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MySearch()

    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If lv_sergury.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل تريد الحذف ؟ ", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim id = Convert.ToInt32(lv_sergury.SelectedItems.Item(0).Text)
                Try
                    excute1("delete from medical_operation where id = " & id)
                    MySearch()


                Catch ex As Exception
                    MessageBox.Show("لم يتم الحذف")
                End Try

            End If

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tb_date.Value = Date.Now
        DateTimePicker1.Value = Date.Now
        MySearch()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        tb_date.Value = Date.Now.AddDays(1)
        DateTimePicker1.Value = Date.Now.AddDays(1)
        MySearch()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        tb_date.Value = Date.Now.AddDays(1)
        DateTimePicker1.Value = Date.Now.AddDays(7)
        MySearch()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_date.Value = Date.Now.AddDays(1)
        DateTimePicker1.Value = Date.Now.AddDays(30)
        MySearch()

    End Sub

    Private Sub عرضملفالمريضToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضملفالمريضToolStripMenuItem.Click
        If Not is_doctor() Then
            MessageBox.Show("يرجى الدخول بحساب طبيب")
            Exit Sub

        End If
        If lv_sergury.SelectedItems.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(lv_sergury.SelectedItems.Item(0).SubItems(8).Text)
            fm_doctor_main.patient_name = lv_sergury.SelectedItems.Item(0).SubItems(1).Text
            fm_doctor_main.patient_id = id
            fm_doctor_main.select_one()
            fm_doctor_main.Show()

        End If
     
    End Sub
End Class