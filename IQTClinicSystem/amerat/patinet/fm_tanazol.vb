Imports MySql.Data.MySqlClient

Public Class fm_tanazol
    Dim p As New Patient

    Private Sub fm_tanazol_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub fm_tanazol_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        p_patient.Image = Nothing
    End Sub
    Private Sub fm_tanazol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatlist()
        search()
        p = New Patient(__(tb_patient_id.Text))
        tb_f7.Text = p.note
        TextEdit1.Text = p.f1 & p.f2 & "." & p.f3
        TextEdit2.Text = p.name

        Try
            p_patient.Image = Image.FromFile(images_path & "\im" & p.id & ".png")
        Catch ex As Exception
            p_patient.Image = Nothing
        End Try


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
        lv_queue.Columns.Add("ملاحظات", 10)
        lv_queue.Columns.Add("نص التنازل", 200)



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

                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("note").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("f7").ToString)

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
            tb_gender.BackColor = Color.Pink
            Exit Sub
        End If
        If tb_gender.Text.Length < 5 Then
            MessageBox.Show("اسم الزبون قصير")
            tb_gender.BackColor = Color.Pink
            Exit Sub
        End If
        If tb_f7.Text.Length < 5 Then
            MessageBox.Show("نص التنازل فارغ")
            tb_f7.BackColor = Color.Pink
            Exit Sub
        End If
        If MessageBox.Show("هل انت متأكد", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

            SimpleButton4.Enabled = False
            SimpleButton1.Enabled = False
            tb_f7.ReadOnly = True
            tb_gender.ReadOnly = True
            lv_queue.Enabled = False

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
            old_p.f7 = tb_f7.Text


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
            print_tanazol(__(lv_queue.Items(0).Text))
            save_images(lv_queue.Items(0).SubItems(1).Text, lv_queue.Items(0).Text)
            tb_gender.Text = ""
            tb_f7.Text = ""
            lv_queue.Enabled = True



        End If
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub lv_queue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_queue.SelectedIndexChanged
        If lv_queue.SelectedItems.Count = 1 Then
            tb_f7.Text = lv_queue.SelectedItems(0).SubItems(15).Text
            put_image(lv_queue.SelectedItems(0).SubItems(1).Text, lv_queue.SelectedItems(0).Text)
            SimpleButton4.Enabled = False
            SimpleButton1.Enabled = False
            tb_f7.ReadOnly = True
            tb_gender.ReadOnly = True


        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click


        If tb_gender.Text.Trim = "" Then
            MessageBox.Show("ادخل اسم الزبون الجديد")
            tb_gender.BackColor = Color.Pink
            Exit Sub
        End If
        If tb_gender.Text.Length < 5 Then
            MessageBox.Show("اسم الزبون قصير")
            tb_gender.BackColor = Color.Pink
            Exit Sub
        End If


        Dim total_amount As Decimal
        Dim old_name As String
        Dim new_name As String
        Dim block As String
        Dim dar As String
        Dim contract_date As String


        total_amount = get_total_amount(p)
        old_name = p.name
        new_name = tb_gender.Text
        block = p.f1 & "." & p.f2
        dar = "H." & p.f3
        contract_date = p.register_date

        tb_f7.Text = " إني السيد ( "
        tb_f7.Text = tb_f7.Text & old_name
        tb_f7.Text = tb_f7.Text & " ) اتنازل عن العقد المرقم ( "
        tb_f7.Text = tb_f7.Text & tb_patient_id.Text
        tb_f7.Text = tb_f7.Text & " ) بتاريخ  "
        tb_f7.Text = tb_f7.Text & Date.Now.ToShortDateString & " " & vbNewLine
        tb_f7.Text = tb_f7.Text & " ( " & dar & " ) " & " على الدار المرقم " & vbNewLine
        tb_f7.Text = tb_f7.Text & " ( " & block & " ) بلوك  " & vbNewLine
        tb_f7.Text = tb_f7.Text & "حيث تنازلت عن حقوقي في العقد إلى ( "
        tb_f7.Text = tb_f7.Text & new_name
        tb_f7.Text = tb_f7.Text & " ) ولا يحق لي بعد التوقيع المطالبة باي حق يتعلق بهذا العقد قباله الشركه ( شركه كاسو وشركه الجسور العاليه للمقاولات ) ويعتبر هذا التنازل اسقاط لجميع حقوقي بما في ذلك استلامي للمبلغ المذكور في العقد والبالغ" & vbNewLine
        tb_f7.Text = tb_f7.Text & " ( " & Format(total_amount, "###,###,###,###,###") & " ) " & vbNewLine
        tb_f7.Text = tb_f7.Text & " ( " & ToArabicLetter(total_amount) & " ) " & vbNewLine
        tb_f7.Text = tb_f7.Text & "حيث استلمته من المتنازل له ويعتبر تنازلي هذا فسخا للعقد المذكور واستلامي جميع حقوقي في العقد٠"


    End Sub

    Private Function get_total_amount(p As Patient) As Decimal

        Dim first_push As Decimal
        first_push = p.first_push_amount_arrived

        Dim total_pusths As Decimal

        total_pusths = func_total_pusths(p)

        Return first_push + total_pusths

    End Function

    Private Function func_total_pusths(p As Patient) As Decimal

        Dim dept As New Dept
        Return dept.get_all_pushs(p.id)
    End Function

    Private Sub طباعةالتنازلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةالتنازلToolStripMenuItem.Click

        If lv_queue.SelectedItems.Count = 1 Then

            print_tanazol(__(lv_queue.SelectedItems(0).Text))


        End If
      
    End Sub

    Private Sub print_tanazol(id As Integer)
        Dim p As New patient2(id)

        Dim d As New DataSet
        d = getdatat1("select * from dept2 where user_id = 0 order by id asc")


        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = p.name
        f.final_price = "0"
        f.user_dar = ""
        f.user_block = ""
        f.remaind = ""
        f.arrive = ""
        f.user_name = ""
        f.contract_date = ""
        f.user_block_number = ""
        f.user_id_number = "0"
        f.dar_area = " "
        f.item1 = ""
        f.item2 = ""
        f.item3 = ""
        f.item4 = ""
        f.item9 = ""
        f.item10 = ""
        f.admin_name = ""


        'realy used
        f.item1 = p.id.ToString
        f.item2 = p.f7
        f.item3 = p.name
        f.item4 = p.f6
        f.item5 = p.phone
        f.item6 = p.token_date
        f.path = "tanazol"
        f.Show()

    End Sub
    Private Sub save_images(id As String, tanasol_id As String)
1:

        Dim path As String = patient_image_path
        Try

            Dim new_path = images_path & "\p" & id & "\tanazolat"
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            p_patient.Image.Save(new_path & "\" & tanasol_id & ".png", Imaging.ImageFormat.Png)
        Catch

            MessageBox.Show("لم يتم ارشفة الصورة - الصورة غير متوفرة")

        End Try
    End Sub
    Private Sub put_image(id As String, tanasol_id As String)
        If lv_queue.SelectedItems.Count > 0 Then
            Try

                p_patient.Image = Image.FromFile(images_path & "\p" & id & "\tanazolat\" & tanasol_id & ".png")

            Catch ex As Exception
                p_patient.Image = Nothing

            End Try
        End If
    End Sub

    Private Sub عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count = 1 Then
            If user.type = user_admin Then
                If MessageBox.Show("هل انت متأكد ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Dim p2 As New patient2
                    p2.id = __(lv_queue.SelectedItems(0).Text)
                    p2.delete()
                    search()

                End If
            End If
        End If

    End Sub

    Private Sub اضافةصورةالتنازلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةصورةالتنازلToolStripMenuItem.Click
        If lv_queue.SelectedItems.Count = 1 Then
            If user.type = user_admin Then

                fm_camera.id = Convert.ToInt32(lv_queue.SelectedItems(0).Text)
                fm_camera.patient_id = Convert.ToInt32(lv_queue.SelectedItems(0).SubItems(1).Text)
                fm_camera.tb_type.Text = lv_queue.SelectedItems(0).SubItems(2).Text
                fm_camera.Show()
                fm_camera.re = "tanasol"
            End If
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        If Not hasPermission(i_add_booking) Then
            Exit Sub
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If

       
        Try
            Dim new_path = images_path & "\p" & tb_patient_id.Text & "\tanazolat"
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            Process.Start("explorer.exe", new_path)


        Catch ex As Exception

        End Try
    End Sub
End Class