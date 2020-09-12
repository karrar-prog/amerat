Imports System.IO

Public Class fm_add_patient
    Public re As String = from_main

    Dim plan As New DataSet

    Private Sub fm_add_patient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If re = "1" Then
            fm_main.Show()
        ElseIf re = "2" Then
            fm_show_patients.Show()
        ElseIf re = "5" Then
            fm_months.Show()

        End If

    End Sub

    Private Sub fm_add_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ProgressPanel1.Hide()
        finger_show()
        saveOrAdd()
        'combo_city()

        Combo_format()
      
    
    End Sub
 
    Private Sub Combo_format()

        cb_plan.SelectedItem = "لا"
        'plan = New DataSet

        'plan = getdatat1("select * from amount_plan")
        'If plan.Tables(0).Rows.Count > 0 Then
        '    For i = 0 To plan.Tables(0).Rows.Count - 1
        '        cb_plan.Items.Add(plan.Tables(0).Rows(i).Item("title").ToString)
        '    Next


        '    If plan.Tables(0).Rows.Count = 1 Then

        '        cb_plan.SelectedItem = cb_plan.Items(0)


        '    End If

        'End If

    End Sub
    Private Sub get_plan(ByVal title As String)
        Dim queue = New DataSet


        queue = getdatat1("SELECT * FROM amount_plan WHERE title LIKE '" & title & "' ")
        If queue.Tables(0).Rows.Count > 0 Then


            tb_munite.Text = queue.Tables(0).Rows(0).Item("time").ToString()
            nu_house_price.Value = ___(queue.Tables(0).Rows(0).Item("amount").ToString())


        Else

        End If

    End Sub
    Private Sub LabelControl12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim p As New Patient(tb_wieght.Text, nu_blok_num.Value, num_home_num.Value)
        If p.id = 0 Or p.id = __(tb_id.Text) Then
            add()
        Else

            MessageBox.Show(p.is_token & "  للزبون  " & p.name, "لايمكن الحفظ")

        End If



    End Sub

    Private Sub save_new()
        Dim patient As New Patient

        patient.name = tb_name.Text.Trim

        patient.gender = ""
         patient.note = tb_note.Text.Trim
        patient.phone = tb_phone.Text.Trim
        patient.ref_by = tb_ref_by.Text.Trim
        patient.wieght = tb_wieght.Text.Trim
        patient.f1 = tb_wieght.Text.Trim
        patient.f2 = nu_blok_num.Value.ToString
        patient.f3 = num_home_num.Value.ToString
        patient.f5 = cb_plan.Text.Trim
        patient.f6 = tb_f6.Text.Trim
        patient.f7 = tb_f7.Text.Trim
        patient.f8 = tb_f8.Text.Trim
        patient.f10 = tb_note.Text.Trim
        patient.first_part = nu_first_part.Value
        patient.last_part = nu_last_part.Value
        patient.first_present = __(nu_first_present.Value.ToString)
        patient.last_present = __(nu_last_present.Value.ToString)
        patient.house_price = nu_house_price.Value
        patient.is_token = cb_plan.Text

        Try
            patient.register_date = dt_register_date.Value
        Catch ex As Exception

        End Try
        Try
            patient.birthdate = dt_birthdate.Value
        Catch ex As Exception

        End Try

        If patient.save() Then


            operatin_click(0)

            tb_id.Text = patient.get_id()

        Else
            MessageBox.Show("لم تتم الاضافة")
            operatin_click(0)
        End If


    End Sub

    Private Sub update_patient()
        Dim patient As New Patient
        patient.id = Convert.ToInt32(tb_id.Text.Trim)
        patient.name = tb_name.Text.Trim

        patient.gender = ""
        patient.note = tb_note.Text.Trim
        patient.phone = tb_phone.Text.Trim
        patient.ref_by = tb_ref_by.Text.Trim
        patient.wieght = tb_wieght.Text.Trim
        patient.f1 = tb_wieght.Text.Trim
        patient.f2 = nu_blok_num.Value.ToString
        patient.f3 = num_home_num.Value.ToString
        patient.f5 = cb_plan.Text.Trim
        patient.f6 = tb_f6.Text.Trim
        patient.f7 = tb_f7.Text.Trim
        patient.f8 = tb_f8.Text.Trim
        patient.f10 = tb_note.Text.Trim
        patient.first_part = nu_first_part.Value
        patient.last_part = nu_last_part.Value
        patient.first_present = __(nu_first_present.Value.ToString)
        patient.last_present = __(nu_last_present.Value.ToString)
        patient.house_price = nu_house_price.Value
        patient.is_token = cb_plan.Text
    


        If patient.save() Then

            tb_name.BackColor = Color.LightGreen

            operatin_click(0)
            '    MessageBox.Show("تم التعديل")
            tb_id.Text = patient.get_id()

        Else
            ' MessageBox.Show("لم يتم التعديل")
            operatin_click(0)
        End If
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt_birthdate.ValueChanged

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function validate_vale() As Boolean
        If tb_name.Text.Trim = "" Then
            tb_name.BackColor = Color.LightPink
            tb_name.Focus()
            Return False
        Else
            tb_name.BackColor = Color.White

        End If

        If tb_phone.Text.Trim = "" Then
            tb_phone.BackColor = Color.LightPink
            tb_phone.Focus()
            Return False
        Else
            tb_phone.BackColor = Color.White

        End If
        If tb_f6.Text.Trim = "" Then
            tb_f6.BackColor = Color.LightPink
            tb_f6.Focus()
            Return False
        Else
            tb_f6.BackColor = Color.White

        End If
        If tb_f7.Text.Trim = "" Then
            tb_f7.BackColor = Color.LightPink
            tb_f7.Focus()
            Return False
        Else
            tb_f7.BackColor = Color.White

        End If
        If tb_wieght.Text.Trim = "" Then

            tb_wieght.BackColor = Color.LightPink
            tb_wieght.Focus()
            Return False
        Else


            If tb_ref_by.Text.Trim = "" Then

                tb_ref_by.BackColor = Color.LightPink
                tb_ref_by.Focus()
                Return False
            Else
                tb_ref_by.BackColor = Color.White
            End If
         

            tb_wieght.BackColor = Color.White
        End If
        If cb_plan.Text.Trim = "" Then

            cb_plan.BackColor = Color.LightPink
            cb_plan.Focus()
            Return False
        Else
            cb_plan.BackColor = Color.White
        End If

    
        Return True


    End Function

    Private Sub clear_value()

        tb_name.Text = ""


     
        tb_phone.Text = ""
        tb_ref_by.Text = ""
        tb_wieght.Text = ""

     
        tb_f6.Text = ""
        tb_f7.Text = ""
        tb_f8.Text = ""

        tb_note.Text = ""
    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        tb_name.BackColor = Color.White


    End Sub

    Private Sub operatin_click(ByVal i As Integer)
        If i = 0 Then
            PictureBox1.Show()
            ProgressPanel1.Hide()



        Else
            ProgressPanel1.Show()
            PictureBox1.Hide()

        End If

    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        clear_value()
        tb_id.Text = ""
    End Sub

    Private Sub finger_show()
        If tb_id.Text.Trim = "" Then
            GroupControl6.Hide()

        Else
            GroupControl6.Show()

        End If

    End Sub

    Private Sub saveOrAdd()
        If tb_id.Text.Trim = "" Then
            Label2.Text = "حفظ الجديد"

        Else
            Label2.Text = "حفظ التعديل"

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

       
        If tb_id.Text.Trim <> "" Then

            fm_camera.patient_id = Convert.ToInt32(tb_id.Text)

            fm_camera.Show()
            fm_camera.re = "add_new"
        End If


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

        fm_add_queue.tb_patient_id.Text = tb_id.Text
        fm_add_queue.tb_patient_name.Text = tb_name.Text
        fm_add_queue.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub save_new_image()












        OpenFileDialog1.Title = "Please select a image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All files|*.*|png|*.png|jpg|*.jpg"
        Dim path As String



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path = OpenFileDialog1.FileName

            If path.Trim <> "" Then
                Dim new_path = images_path & "\p" & tb_id.Text
                If (Not System.IO.Directory.Exists(new_path)) Then
                    System.IO.Directory.CreateDirectory(new_path)
                End If

                Dim new_file_path = new_path & "\" & "imatt " & generate_image_id() & ".png"

                If Not System.IO.File.Exists(new_file_path) = True Then
                    File.Copy(path, new_file_path, True)
                End If

            Else
                MessageBox.Show("لم تقم باختيار صورة")
            End If

        End If













        'OpenFileDialog1.Title = "Please select a image"
        'OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = "C:\"
        'OpenFileDialog1.Filter = "All files|*.*|png|*.png|jpg|*.jpg"
        'Dim path As String



        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    path = OpenFileDialog1.FileName

        '    If path.Trim <> "" Then
        '        Dim new_path = images_path & "p" & tb_id.Text
        '        If (Not System.IO.Directory.Exists(new_path)) Then
        '            System.IO.Directory.CreateDirectory(new_path)
        '        End If

        '        Dim new_file_path = new_path & "\image" & generate_image_id() & ".png"

        '        If Not System.IO.File.Exists(new_file_path) = True Then
        '            File.Copy(path, new_file_path, True)
        '        End If

        '    Else
        '        MessageBox.Show("لم تقم باختيار صورة")
        '    End If

        'End If
    End Sub
    Private Sub show_images()



        'Dim proc As New System.Diagnostics.Process()
        'For Each sf In Directory.GetFiles(new_path & "\")
        '    Try
        '        proc = Process.Start(sf, "فتح الصورة")
        '    Catch ex As Exception
        '        MessageBox.Show("fff")


        '    End Try
        'Next



    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
      
        save_images()


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        
        If tb_id.Text.Trim = "" Then
            MessageBox.Show("لم تقم بحفظ معلومات المراجع")
            Exit Sub

        End If
        Try
            Dim new_path = images_path & "\p" & tb_id.Text
            Process.Start("explorer.exe", new_path)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub save_images()
1:

        Try
            If tb_id.Text.Trim <> "" Then

                save_new_image()
            Else
                MessageBox.Show("اختر مراجع قبل ادخال الصور")
            End If

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub




    Private Sub tb_f9_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    ''Private Sub combo_city()
    '    tb_f9.Items.Add("أربيل")
    '    tb_f9.Items.Add("الأنبار")
    '    tb_f9.Items.Add("بابل")
    '    tb_f9.Items.Add("بغداد")
    '    tb_f9.Items.Add("البصرة")
    '    tb_f9.Items.Add("دهوك")
    '    tb_f9.Items.Add("القادسية")
    '    tb_f9.Items.Add("ديالى")
    '    tb_f9.Items.Add("ذي قار")
    '    tb_f9.Items.Add("السليمانية")
    '    tb_f9.Items.Add("صلاح الدين")
    '    tb_f9.Items.Add("كركوك")
    '    tb_f9.Items.Add("كربلاء")
    '    tb_f9.Items.Add("المثنى")
    '    tb_f9.Items.Add("ميسان")
    '    tb_f9.Items.Add("النجف")
    '    tb_f9.Items.Add("نينوى")
    '    tb_f9.Items.Add("واسط")
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_note.TextChanged

    End Sub

    Public Sub add()
        operatin_click(1)
        finger_show()


        If Not validate_vale() Then
            operatin_click(0)
            Exit Sub
        End If

        Dim patient As New Patient()
        patient.name = tb_name.Text
        If patient.findByName() And tb_id.Text.Trim = "" Then
            operatin_click(0)
            tb_name.BackColor = Color.LightBlue
            MessageBox.Show("هذا الاسم موجود")
            Exit Sub
        End If


        If tb_id.Text = "0" Then

        ElseIf tb_id.Text.Trim = "" Then
1:

            Try
                save_new()
                tb_name.BackColor = Color.LightGreen

            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1

                End If
            End Try

        Else
2:
            Try
                update_patient()
                operatin_click(0)
            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 2

                End If
            End Try


        End If
        finger_show()
        saveOrAdd()
    End Sub

    Private Sub tb_phone_EditValueChanged(sender As Object, e As EventArgs) Handles tb_phone.EditValueChanged
        tb_name.BackColor = Color.White

    End Sub

    Private Sub tb_f9_SelectedIndexChanged(sender As Object, e As EventArgs)
        tb_name.BackColor = Color.White

    End Sub

    Private Sub tb_wieght_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_wieght.SelectedIndexChanged
        tb_name.BackColor = Color.White

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nu_blok_num.ValueChanged
        tb_name.BackColor = Color.White

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles num_home_num.ValueChanged
        tb_name.BackColor = Color.White

    End Sub

    Private Sub tb_diagonosis_SelectedIndexChanged(sender As Object, e As EventArgs)
        tb_name.BackColor = Color.White

    End Sub

    Private Sub tb_ref_by_EditValueChanged(sender As Object, e As EventArgs) Handles tb_ref_by.EditValueChanged
        tb_name.BackColor = Color.White

    End Sub

    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cb_plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plan.SelectedIndexChanged
        'get_plan(cb_plan.Text)
    End Sub

    Private Sub ProgressPanel1_Click(sender As Object, e As EventArgs) Handles ProgressPanel1.Click

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If tb_id.Text.Trim = "" Then
            MessageBox.Show("اختر مشترك")
            Exit Sub
        End If
        fm_add_other_required.tb_id.Text = tb_id.Text
        fm_add_other_required.tb_name.Text = tb_name.Text
        fm_add_other_required.nu_first_part.Value = nu_first_part.Value
        fm_add_other_required.nu_house_price.Value = nu_house_price.Value
        fm_add_other_required.nu_last_part.Value = nu_last_part.Value
        fm_add_other_required.nu_first_present.Value = nu_first_present.Value
        fm_add_other_required.nu_last_present.Value = nu_last_present.Value

        fm_add_other_required.Show()

    End Sub



    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nu_first_present_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_first_present.KeyUp
        nu_last_present.Value = 100 - nu_first_present.Value

        cal_moneys()

    End Sub


    Private Sub nu_first_present_ValueChanged(sender As Object, e As EventArgs) Handles nu_first_present.ValueChanged
        nu_last_present.Value = 100 - nu_first_present.Value

        cal_moneys()


    End Sub

    Private Sub nu_last_present_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_last_present.KeyUp
        nu_first_present.Value = 100 - nu_last_present.Value
        cal_moneys()
    End Sub

    Private Sub nu_last_present_ValueChanged(sender As Object, e As EventArgs) Handles nu_last_present.ValueChanged
        nu_first_present.Value = 100 - nu_last_present.Value
        cal_moneys()

    End Sub

    Private Sub cal_moneys()

        nu_first_part.Value = (nu_house_price.Value * nu_first_present.Value) / 100
        nu_last_part.Value = nu_house_price.Value - nu_first_part.Value


    End Sub
   

    Private Sub nu_first_part_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_first_part.KeyUp
        If nu_first_part.Value > nu_house_price.Value Then
            nu_first_part.Value = nu_house_price.Value
            nu_last_part.Value = 0
        Else

            nu_last_part.Value = nu_house_price.Value - _nu_first_part.Value


        End If
    End Sub




    Private Sub nu_first_part_ValueChanged(sender As Object, e As EventArgs) Handles nu_first_part.ValueChanged

      If nu_first_part.Value > nu_house_price.Value Then
            nu_first_part.Value = nu_house_price.Value
            nu_last_part.Value = 0
        Else

            nu_last_part.Value = nu_house_price.Value - nu_first_part.Value


        End If

    End Sub

    Private Sub nu_last_part_KeyUp(sender As Object, e As KeyEventArgs) Handles nu_last_part.KeyUp
        If nu_last_part.Value > nu_house_price.Value Then
            nu_last_part.Value = nu_house_price.Value
            nu_first_part.Value = 0
        Else

            nu_first_part.Value = nu_house_price.Value - nu_last_part.Value


        End If
    End Sub

    Private Sub nu_last_part_ValueChanged(sender As Object, e As EventArgs) Handles nu_last_part.ValueChanged
        If nu_last_part.Value > nu_house_price.Value Then
            nu_last_part.Value = nu_house_price.Value
            nu_first_part.Value = 0
        Else

            nu_first_part.Value = nu_house_price.Value - nu_last_part.Value


        End If

    End Sub

    Private Sub GroupControl7_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl7.Paint

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        fm_add_other_required.tb_id.Text = tb_id.Text
        fm_add_other_required.Show() '
    End Sub

  

End Class