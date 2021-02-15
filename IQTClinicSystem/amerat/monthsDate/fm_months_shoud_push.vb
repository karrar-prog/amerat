Imports MySql.Data.MySqlClient

Public Class fm_months_shoud_push

    Private Property searched As Integer

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        searched = 1

        search()

    End Sub

    Public Sub search()
        Select Case searched
            Case 1
                today_search()
            Case 2
                tommorw_search()
            Case 3
                next_week_search()
            Case 4
                beteen_search()
            Case 5
                name_search()

        End Select


    End Sub

    Private Sub today_search()

        Dim months As New Dept
        Dim d As New DataSet
        Dim dt As New DateTimePicker
        If r_without.Checked = True Then
            d = months.get_date(Date.Now.ToShortDateString)
        Else

            d = months.get_date2(Date.Now.ToShortDateString)

        End If
        fill_list(d)

    End Sub

    Private Sub tommorw_search()
        Dim months As New Dept
        Dim d As New DataSet
        Dim dt As New DateTimePicker
        dt.Value.AddDays(1)
        If r_without.Checked = True Then
            d = months.get_date(dt.Value.ToShortDateString)
        Else
            d = months.get_date2(dt.Value.ToShortDateString)
        End If
        fill_list(d)
    End Sub

    Private Sub next_week_search()
        Dim months As New Dept
        Dim d As New DataSet
        Dim dt1 As New DateTimePicker
        Dim dt2 As New DateTimePicker
        dt2.Value = dt1.Value.AddDays(7)
        If r_without.Checked = True Then
            d = months.get_date(dt2.Value.ToShortDateString)

        Else

            d = months.get_date2(dt2.Value.ToShortDateString)

        End If
        fill_list(d)
    End Sub

    Private Sub beteen_search()
        Dim months As New Dept
        Dim d As New DataSet
        If r_without.Checked = True Then
            d = months.get_date_beteen(DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)

        Else
            d = months.get_date_beteen2(DateTimePicker1.Value.ToShortDateString, DateTimePicker2.Value.ToShortDateString)

        End If
        fill_list(d)
    End Sub

    Private Sub name_search()
        Throw New NotImplementedException
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        searched = 2

        search()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        searched = 3

        search()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        searched = 4

        search()
    End Sub

    Private Sub tb_username_EditValueChanged(sender As Object, e As EventArgs) Handles tb_username.EditValueChanged

    End Sub

    Private Sub tb_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_username.KeyPress

    End Sub

    Private Sub tb_username_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_username.KeyUp
        If e.KeyCode = Keys.Enter Then
            searched = 5

            search()
        End If
    End Sub

    Private Sub fill_list(d As DataSet)

1:
        Try
            li_dept.Items.Clear()
            GridControl1.DataSource = d.Tables(0)

            If d.Tables(0).Rows.Count > 0 Then

                Dim i = 0
                For i2 As Integer = 0 To d.Tables(0).Rows.Count - 1
                    'اذا كان لايساوي صفر فانه مؤجل ويجب معرفة تأريخ التأجيل
                    If d.Tables(0).Rows(i2).Item("days").ToString.Trim <> "0" Then
                        Dim d_date As New DateTimePicker
                        d_date.Value = Convert.ToDateTime(d.Tables(0).Rows(i2).Item("taajeel_date").ToString)

                        If d_date.Value <= Date.Now Then
                            li_dept.Items().Add(d.Tables(0).Rows(i2).Item("id").ToString)
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("name").ToString)
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("title").ToString)
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("amount").ToString)
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("payment_date").ToString)
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("user_id").ToString)
                            If r_with.Checked Then
                                li_dept.Items(i).SubItems.Add("نعم")
                                li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("queue_id").ToString)
                                li_dept.Items(i).BackColor = Color.LightGreen
                            Else
                                li_dept.Items(i).SubItems.Add("لا")
                                li_dept.Items(i).SubItems.Add("")

                            End If
                            li_dept.Items(i).BackColor = Color.LightYellow
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("patient_f1").ToString & d.Tables(0).Rows(i2).Item("patient_f2").ToString & "." & d.Tables(0).Rows(i2).Item("patient_f3").ToString)

                            i = i + 1
                        End If
                    Else
                        li_dept.Items().Add(d.Tables(0).Rows(i2).Item("id").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("name").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("title").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("amount").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("payment_date").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("user_id").ToString)
                        If r_with.Checked Then
                            li_dept.Items(i).SubItems.Add("نعم")
                            li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("queue_id").ToString)
                            li_dept.Items(i).BackColor = Color.LightGreen
                        Else
                            li_dept.Items(i).SubItems.Add("لا")
                            li_dept.Items(i).SubItems.Add("")

                        End If
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("patient_f1").ToString & d.Tables(0).Rows(i2).Item("patient_f2").ToString & "." & d.Tables(0).Rows(i2).Item("patient_f3").ToString)
                        li_dept.Items(i).SubItems.Add(d.Tables(0).Rows(i2).Item("phone").ToString)

                        i = i + 1
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
    Private Sub lv_format()
        li_dept.View = View.Details
        li_dept.Columns.Add("تسلسل الدفعة", 0)
        li_dept.Columns.Add("اسم الزبون", 240)
        li_dept.Columns.Add("عنوان الدفعة", 140)
        li_dept.Columns.Add("مبلغ الدفعة", 120)
        li_dept.Columns.Add("تأريخ الاستحقاق", 120)
        li_dept.Columns.Add("رقم العقد", 100)
        li_dept.Columns.Add("تمت طباعة الفيشة؟", 120)
        li_dept.Columns.Add("رقم الفيشة", 140)
        li_dept.Columns.Add("الدار", 100)

        li_dept.Columns.Add("هاتف", 140)


    End Sub
    Private Sub fm_months_shoud_push_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_format()

    End Sub
    Private Sub print_report(id As Integer)

1:

        Try


            Try
                Dim query As String = "select * , queue.note as fesha_note, queue.id as fesha_id ,patient.f1 as blok_title ,patient.phone as phone , patient.f2 as blok_number , patient.f3 as dar_number ,   patient.name as current_name , queue.`date` as date , queue.test_type as type    , queue.booking_number as number  from queue , patient where  queue.id = " & __(id.ToString) & " and patient.id = queue.patient_id"

                'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
                Dim fm = New fm_report_viewr

                fm.ds = getdatat1(query)

                fm.Show()

            Catch ex As Exception
                save_error(ex.Message, Me.Name, "print_report")
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub طباعةفيشةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةفيشةToolStripMenuItem.Click

        If Not hasPermission(i_fesha) Then
            Exit Sub
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If

        If li_dept.SelectedItems.Count = 1 Then



            Try
                If li_dept.SelectedItems(0).ToString.Trim <> "" Then


                    Dim dept As New Dept(__(li_dept.SelectedItems(0).Text))
                    If dept.amount = dept.arrive_amount Then
                        MessageBox.Show("تم التسديد مسبقا")
                        Exit Sub
                    End If


                    If li_dept.Items(0).SubItems(7).Text.Trim <> "" Then
                        print_report(__(li_dept.Items(0).SubItems(7).Text.Trim))
                    Else
                        Try
                            fm_add_queue.Close()

                        Catch ex As Exception

                        End Try
                        fm_add_queue.tb_id.Text = "0"
                        fm_add_queue.tb_patient_id.Text = li_dept.Items(0).SubItems(5).Text
                        fm_add_queue.tb_number.Text = get_number(dept.title).ToString
                        fm_add_queue.tb_patient_name.Text = li_dept.Items(0).SubItems(1).Text
                        fm_add_queue.tb_dept_title.Text = dept.title
                        fm_add_queue.tb_dept_id.Text = dept.id.ToString
                        fm_add_queue.Show()
                        fm_add_queue.tb_fesha_amount.Text = dept.amount.ToString
                        fm_add_queue.tb_amount_text.Text = ToArabicLetter(dept.amount)

                    End If

                Else
                    MessageBox.Show("يرجى اختيار عنصر واحد")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                save_error(ex.Message, Me.Name, "طباعةفيشةToolStripMenuItem_Click")
            End Try

        End If
    End Sub

    Private Sub li_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_dept.SelectedIndexChanged

    End Sub

    Private Sub تحديثالمعلوماتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تحديثالمعلوماتToolStripMenuItem.Click

        If hasPermission(i_edit_customer) Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If li_dept.SelectedItems.Count = 1 Then
            Try
                fm_add_patient.Close()
            Catch ex As Exception
            End Try
            Dim id As Integer = Convert.ToInt32(li_dept.SelectedItems.Item(0).SubItems(5).Text)
            fm_add_patient.tb_id.Text = id.ToString
            fm_add_patient.Show()
            fm_add_patient.re = "7"

            Me.Hide()



        End If
    End Sub

    Private Sub تأجيلالموعدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تأجيلالموعدToolStripMenuItem.Click
        If user.type = user_admin Then
        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
        If li_dept.SelectedItems.Count = 1 Then
            Try
                fm_add_patient.Close()
            Catch ex As Exception
            End Try
            Dim id As Integer = Convert.ToInt32(li_dept.SelectedItems.Item(0).Text)
            fm_taajeel.tb_id.Text = id.ToString
            fm_taajeel.tb_name.Text = li_dept.SelectedItems.Item(0).SubItems(1).Text

            fm_taajeel.tb_phone.Text = li_dept.SelectedItems.Item(0).SubItems(2).Text
            fm_taajeel.tb_payment_date.Text = li_dept.SelectedItems.Item(0).SubItems(4).Text

            fm_taajeel.Show()
        End If
    End Sub

    Private Sub r_with_CheckedChanged(sender As Object, e As EventArgs) Handles r_with.CheckedChanged
        searched = 4

        search()
    End Sub

    Private Sub r_without_CheckedChanged(sender As Object, e As EventArgs) Handles r_without.CheckedChanged
        searched = 4

        search()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Export_xlsx("tanazolat", GridControl1)
    End Sub
    Private Sub Export_xlsx(output As String, ByRef gridControl As DevExpress.XtraGrid.GridControl)
        Dim path As String = "xlsx/" & output & "_Date_" & Date.Now.Year & "_" & Date.Now.Month & "_" & Date.Now.Day & "_Time_" & Date.Now.Hour & "_" & Date.Now.Minute & "_" & Date.Now.Second & Date.Now.Millisecond & ".xlsx"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(Application.StartupPath & "/" & path)
    End Sub
End Class