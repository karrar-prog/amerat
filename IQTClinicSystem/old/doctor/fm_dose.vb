Public Class fm_dose 
    Dim final_dose_per_day As Decimal
    Dim final_dose_per_times As Decimal
    Public new_treat As Integer = 0

    Private s_note2 As String = "يضاف مخدر رايلوكابين في 1\4 سي سي"

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub fm_dose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cb_type_format()
        radi_chechked()
        set_note()
        run_all_event()

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        If new_treat = 1 Then
            Dim t As New Treatment
        
            t.name = tb_treatment_name.Text.Trim
            t.f3 = tb_note.Text

            t.f1= tb_f1.Text

            t.priority = "9"

            t.children = tb_children.Text

            t.children_kidney = tb_adult_kedny.Text

            t.adult = tb_adult.Text

            t.adult_kidney = tb_adult_kedny.Text
            t.category = ""


            t.f2 = tb_f2.Text

1:

            Try
                If t.save() Then
                    '  MessageBox.Show("تمت العملية")
            

                End If
            Catch ex As Exception
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End Try


        End If




        If check_values() Then
            fm_doctor_main.lv_treat_table.Items.Add("0")
            fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add(tb_treatment_name.Text)
            fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add(tb_dose_to_patient.Text)
            fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add("")
            fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add(tb_note.Text)
            Me.Close()

        End If
    End Sub

    Private Function check_values() As Boolean

   
            Return True



    End Function

    Private Sub cb_type_format()
        tb_f1.Items.Add(s_type1)
        tb_f1.Items.Add(s_type2)
        tb_f1.Items.Add(s_type3)
        tb_f1.Items.Add(s_type4)
        tb_f1.Items.Add(s_type5)
        tb_f1.Items.Add(s_type6)
        tb_f1.Items.Add(s_type7)
        tb_f1.Items.Add(s_type8)
        tb_f1.Items.Add(s_type9)
        tb_f1.Items.Add(s_type10)
        tb_f1.Items.Add(s_type11)
        tb_f1.Items.Add(s_type12)
    End Sub

    Private Sub tb_note_EditValueChanged(sender As Object, e As EventArgs) Handles tb_note.EditValueChanged

    End Sub

    Private Sub f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_f1.SelectedIndexChanged

        run_all_event()


   

    End Sub

    Private Sub set_note()
        If tb_f1.Text = s_type1 Then
            TabPane1.SelectedPage = tab_syrup


        ElseIf tb_f1.Text = s_type2 Then
            TabPane1.SelectedPage = tab_vial


        ElseIf tb_f1.Text = s_type3 Then
            TabPane1.SelectedPage = tab_amp



        ElseIf tb_f1.Text = s_type4 Then
            TabPane1.SelectedPage = tab_cap

        ElseIf tb_f1.Text = s_type5 Then
            TabPane1.SelectedPage = tab_tab

        ElseIf tb_f1.Text = s_type9 Then
            TabPane1.SelectedPage = tab_drog

        Else
            TabPane1.SelectedPage = tab_cream

        End If

    End Sub

    Private Function get_hours() As String
        If r_once.Checked Then
            Return " 24 ساعة "
        ElseIf r_bid.Checked Then
            Return " 12 ساعة "
        ElseIf r_tip.Checked Then
            Return " 8 "
        ElseIf r_qid.Checked Then
            Return " 6 ساعات "
        ElseIf RadioButton1.Checked Then
            Return "2 يوم"
        ElseIf RadioButton2.Checked Then
            Return "3 يوم"
        ElseIf RadioButton3.Checked Then
            Return "اسبوع"
        ElseIf RadioButton4.Checked Then
            Return "اسبوعين"
        ElseIf RadioButton5.Checked Then
            Return "شهر"
        End If
        Return " "
    End Function

    Private Sub radi_chechked()
        If Val(tb_age.Text) >= 18 Then
            r_adult.Checked = True
        Else
            r_child.Checked = True

        End If



    End Sub

 

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub r_child_CheckedChanged(sender As Object, e As EventArgs) Handles r_child.CheckedChanged

        set_readios(tb_child_take_paln)
     
    End Sub

    Private Sub r_child_kedny_CheckedChanged(sender As Object, e As EventArgs) Handles r_child_kedny.CheckedChanged
        set_readios(tb_child_kedny_take_paln)

    End Sub

    Private Sub set_readios(textEdit As DevExpress.XtraEditors.TextEdit)
        If textEdit.Text = s_once Then
            r_once.Checked = True
        ElseIf textEdit.Text = s_tid Then
            r_tip.Checked = True
        ElseIf textEdit.Text = s_qid Then
            r_qid.Checked = True
        ElseIf textEdit.Text = s_bid Then
            r_bid.Checked = True
        End If
    End Sub

    Private Sub r_adult_CheckedChanged(sender As Object, e As EventArgs) Handles r_adult.CheckedChanged
        set_readios(tb_adult_take_paln)

    End Sub

    Private Sub r_adult_kedny_CheckedChanged(sender As Object, e As EventArgs) Handles r_adult_kedny.CheckedChanged
        set_readios(tb_adult_kedny_take_paln)

    End Sub

  
    Private Sub tab_syrup_Paint(sender As Object, e As PaintEventArgs) Handles tab_syrup.Paint

    End Sub

    Private Sub dose_calculate()
        tb_note.Text = ""

        If r_child.Checked = True Then
            dose_solve(tb_children)

        ElseIf r_child_kedny.Checked = True Then
            dose_solve(tb_children_kedny)

        ElseIf r_adult.Checked = True Then
            dose_solve(tb_adult)

        ElseIf r_adult_kedny.Checked = True Then
            dose_solve(tb_adult_kedny)

        End If
    End Sub

    Private Sub dose_solve(t_dose As DevExpress.XtraEditors.TextEdit)
      
        If t_dose.Text.Trim = "" Then

            t_dose.BackColor = Color.LightPink
            Exit Sub

        End If
        If Val(t_dose.Text) = 0 Then

            t_dose.BackColor = Color.LightPink
            Exit Sub
        End If
     
        Dim wieght As Decimal = 0

        Try
            wieght = Convert.ToDecimal(tb_wieght.Text)
        Catch ex As Exception

        End Try

        Dim dose As Decimal = Convert.ToDecimal(t_dose.Text)
        Dim dose_perCC As Decimal = Convert.ToDecimal(tb_f2.Text)
        Dim dose_with_out_CC As Decimal
        '---------------------------------------
    

            '------------------ set values --------------------------
            If tb_f1.Text = s_type1 Or tb_f1.Text = s_type2 Or tb_f1.Text = s_type3 Then
            If r_adult.Checked Or r_adult_kedny.Checked Then
                dose_with_out_CC = dose
            Else
                dose_with_out_CC = dose * wieght
            End If


            ElseIf tb_f1.Text = s_type4 Or tb_f1.Text = s_type5 Or tb_f1.Text = s_type9 Then

            dose_with_out_CC = dose

            'تصفير الجرعة في حالات الكبسول والحب والقطرات
            dose_perCC = 0
            Else
            dose_with_out_CC = 0

        End If




        If dose_perCC > 0 Then

            final_dose_per_day = dose_with_out_CC / dose_perCC
            NumericUpDown1.Value = final_dose_per_day
            final_dose_per_day = NumericUpDown1.Value


        Else
            final_dose_per_day = dose_with_out_CC
        End If



        '------------------ divided on times---------------------
        If r_once.Checked Then
            final_dose_per_times = final_dose_per_day

        ElseIf r_bid.Checked Then
            final_dose_per_times = final_dose_per_day / 2

        ElseIf r_tip.Checked Then
            final_dose_per_times = final_dose_per_day / 3

        ElseIf r_qid.Checked Then
            final_dose_per_times = final_dose_per_day / 4
        ElseIf RadioButton1.Checked Then
            final_dose_per_times = final_dose_per_day
        ElseIf RadioButton2.Checked Then
            final_dose_per_times = final_dose_per_day
        ElseIf RadioButton3.Checked Then
            final_dose_per_times = final_dose_per_day
        ElseIf RadioButton4.Checked Then
            final_dose_per_times = final_dose_per_day
        ElseIf RadioButton5.Checked Then
            final_dose_per_times = final_dose_per_day
        Else

            final_dose_per_times = 0
        End If

        '--------------------------------------
        set_values()


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles r_ear.CheckedChanged
        dose_calculate()

    End Sub

    Private Sub set_values()

      

        If tb_f1.Text = s_type1 Or tb_f1.Text = s_type2 Or tb_f1.Text = s_type3 Then

            '-----------  syrup ---------------
            tb_syrup_t2_cc.Text = Val(final_dose_per_times).ToString
            tb_syrup_t4_times.Text = get_hours()

            '-----------  vial -------------------
            tb_vial_t1_cc.Text = Val(final_dose_per_times).ToString
            tb_vial_t3_times.Text = get_hours()

            '------------ amp  ------------------
            tb_amp_t2_cc.Text = Val(final_dose_per_times).ToString
            tb_amp_t4_times.Text = get_hours()

            '------------ cap  ------------------
            tb_cap_t2_cc.Text = "0"
            tb_cap_t4_times.Text = "0"

            '------------ tab  ------------------
            tb_tab_t2_cc.Text = "0"
            tb_tab_t4_times.Text = "0"

            '------------ cream  ------------------
            tb_cream_t2_times.Text = "0"

            '------------ drog  ------------------
            tb_drog_t1_cc.Text = "0"
            tb_drog_t4_times.Text = "0"

        ElseIf tb_f1.Text = s_type4 Or tb_f1.Text = s_type5 Or tb_f1.Text = s_type9 Then

            '-----------  syrup ---------------
            tb_syrup_t2_cc.Text = "0"
            tb_syrup_t4_times.Text = "0"

            '-----------  vial -------------------
            tb_vial_t1_cc.Text = "0"
            tb_vial_t3_times.Text = "0"

            '------------ amp  ------------------
            tb_amp_t2_cc.Text = "0"
            tb_amp_t4_times.Text = "0"

            '------------ cap  ------------------
            tb_cap_t2_cc.Text = Val(final_dose_per_times).ToString
            tb_cap_t4_times.Text = get_hours()

            '------------ tab  ------------------
            tb_tab_t2_cc.Text = Val(final_dose_per_times).ToString
            tb_tab_t4_times.Text = get_hours()

            '------------ cream  ------------------
            tb_cream_t2_times.Text = "0"

            '------------ drog  ------------------
            tb_drog_t1_cc.Text = Val(final_dose_per_times).ToString
            tb_drog_t4_times.Text = get_hours()

        Else
            '-----------  syrup ---------------
            tb_syrup_t2_cc.Text = "0"
            tb_syrup_t4_times.Text = "0"

            '-----------  vial -------------------
            tb_vial_t1_cc.Text = "0"
            tb_vial_t3_times.Text = "0"

            '------------ amp  ------------------
            tb_amp_t2_cc.Text = "0"
            tb_amp_t4_times.Text = "0"

            '------------ cap  ------------------
            tb_cap_t2_cc.Text = "0"
            tb_cap_t4_times.Text = "0"

            '------------ tab  ------------------
            tb_tab_t2_cc.Text = "0"
            tb_tab_t4_times.Text = "0"

            '------------ cream  ------------------
            tb_cream_t2_times.Text = get_hours()


            '------------ drog  ------------------
            tb_drog_t1_cc.Text = "0"
            tb_drog_t4_times.Text = "0"
        End If

        Try
            put_resut_from(TabPane1.SelectedPage.Name)

        Catch ex As Exception

        End Try






    End Sub

    Private Sub r_once_CheckedChanged(sender As Object, e As EventArgs) Handles r_once.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub r_bid_CheckedChanged(sender As Object, e As EventArgs) Handles r_bid.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub r_tip_CheckedChanged(sender As Object, e As EventArgs) Handles r_tip.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub r_qid_CheckedChanged(sender As Object, e As EventArgs) Handles r_qid.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub tab_drog_Paint(sender As Object, e As PaintEventArgs) Handles tab_drog.Paint

    End Sub

    Private Sub put_resut_from(opened_tab As String)


        If opened_tab = "tab_syrup" Then
            tb_dose_to_patient.Text = tb_syrup_t0.Text & tb_syrup_t1.Text & tb_syrup_t2_cc.Text & tb_syrup_t3.Text & tb_syrup_t4_times.Text & tb_syrup_t5.Text
        ElseIf opened_tab = "tab_vial" Then
            tb_dose_to_patient.Text = tb_vial_t1_cc.Text & tb_vial_t2.Text & tb_vial_t3_times.Text & tb_vial_t4.Text & get_take_way("tab_vial")
        ElseIf opened_tab = "tab_amp" Then
            tb_dose_to_patient.Text = tb_amp_t1.Text & tb_amp_t2_cc.Text & tb_amp_t3.Text & tb_amp_t4_times.Text & get_take_way("tab_amp")
        ElseIf opened_tab = "tab_cap" Then
            tb_dose_to_patient.Text = tb_cap_t1.Text & tb_cap_t2_cc.Text & tb_cap_t3.Text & tb_cap_t4_times.Text & get_after_eat()

        ElseIf opened_tab = "tab_tab" Then
            tb_dose_to_patient.Text = tb_tab_t1.Text & tb_tab_t2_cc.Text & tb_tab_t3.Text & tb_tab_t4_times.Text & get_after_eat_cab()

        ElseIf opened_tab = "tab_cream" Then
            tb_dose_to_patient.Text = tb_cream_t1.Text & tb_cream_t2_times.Text

        ElseIf opened_tab = "tab_drog" Then

            tb_dose_to_patient.Text = tb_drog_t1_cc.Text & tb_drog_t2.Text & get_grog_way() & tb_drog_t3.Text & tb_drog_t4_times.Text

        End If

    End Sub

    Private Sub run_all_event()
      
        set_note()
        ' set_readios(tb_child_take_paln)

        dose_calculate()
        'radi_chechked()

    End Sub

  

   
    Private Function get_take_way(p1 As String) As String
        If p1.Equals("tab_amp") Then

            If ch_amp_note.Checked Then
                tb_note.Text = ch_amp_note.Text
            Else
                tb_note.Text = ""

            End If


            If r_im_amp.Checked Then
                Return r_im_amp.Text
            ElseIf r_iv_amp.Checked Then
                Return r_iv_amp.Text
            ElseIf r_iv_im_amp.Checked Then
                Return r_iv_im_amp.Text
            ElseIf r_sc_amp.Checked Then
                Return r_sc_amp.Text
            Else
                MessageBox.Show("يرجى اختيار طريقة الزرق")
                Return " "
            End If
        ElseIf p1.Equals("tab_vial") Then

            If ch_vial_note.Checked Then
                tb_note.Text = ch_vial_note.Text
            Else
                tb_note.Text = ""
            End If
            If r_im_vial.Checked Then
                Return r_im_vial.Text
            ElseIf r_iv_vial.Checked Then
                Return r_iv_vial.Text
            ElseIf r_iv_im_vial.Checked Then
                Return r_iv_im_vial.Text
            ElseIf r_sc_vial.Checked Then
                Return r_sc_vial.Text
            Else
                MessageBox.Show("يرجى اختيار طريقة الزرق")
                Return " "
            End If
        Else
            Return " "
        End If
    End Function

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ch_amp_note.CheckedChanged
        set_values()

    End Sub

    Private Sub ch_vial_note_CheckedChanged(sender As Object, e As EventArgs) Handles ch_vial_note.CheckedChanged
        set_values()

    End Sub



   
  

    Private Function get_after_eat() As String
        If r_cap_before_eat.Checked Then
            Return r_cap_before_eat.Text
        Else
            r_cap_after_eat.Checked = True
            Return r_cap_after_eat.Text

        End If
    End Function

    Private Function get_after_eat_cab() As String
        If r_tap_before_eat.Checked Then
            Return r_tap_before_eat.Text
        Else
            r_tap_after_eat.Checked = True
            Return r_tap_after_eat.Text

        End If
    End Function

    Private Function get_grog_way() As String
        If r_eye.Checked Then
            Return r_eye.Text

        ElseIf r_mouth.Checked Then
            Return r_mouth.Text

        ElseIf r_nose.Checked Then
            Return r_nose.Text

        ElseIf r_palce.Checked Then
            Return r_palce.Text

        ElseIf r_ear.Checked Then
            Return r_ear.Text
        Else
            MessageBox.Show("يرجى اختيار مكان وضع القطرات")
            Return " "
        End If
    
    End Function

   
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        run_all_event()
        add_duration()

    End Sub

    Private Sub rr_syrup_CheckedChanged(sender As Object, e As EventArgs) Handles rr_syrup.CheckedChanged
        tb_syrup_t0.Text = ""
        set_values()

    End Sub

    Private Sub rr_powder_CheckedChanged(sender As Object, e As EventArgs) Handles rr_powder.CheckedChanged
        tb_syrup_t0.Text = "يحل الباكيت ب30 سي سي في ماء معقم"
        set_values()

    End Sub

    Private Sub rr_eff_CheckedChanged(sender As Object, e As EventArgs) Handles rr_eff.CheckedChanged
        tb_syrup_t0.Text = "يحل الباودر ب30 سي سي في ماء معقم"
        set_values()

    End Sub

    Private Sub rr_sachet_CheckedChanged(sender As Object, e As EventArgs) Handles rr_sachet.CheckedChanged
        tb_syrup_t0.Text = "يحل الباكيت ب30 سي سي في ماء معقم"
        set_values()

    End Sub

 
    Private Sub ch_cream_CheckedChanged(sender As Object, e As EventArgs) Handles ch_cream.CheckedChanged
        If ch_cream.Checked Then
            tb_note.Text = ch_cream.Text
        Else
            tb_note.Text = ""
        End If
    End Sub


    Private Sub r_eye_CheckedChanged(sender As Object, e As EventArgs) Handles r_eye.CheckedChanged
        dose_calculate()

    End Sub

    Private Sub r_mouth_CheckedChanged(sender As Object, e As EventArgs) Handles r_mouth.CheckedChanged
        dose_calculate()

    End Sub

    Private Sub r_palce_CheckedChanged(sender As Object, e As EventArgs) Handles r_palce.CheckedChanged
        dose_calculate()

    End Sub

    Private Sub tb_wieght_EditValueChanged(sender As Object, e As EventArgs) Handles tb_wieght.EditValueChanged
        If tb_wieght.Text.Trim = "" Then
            tb_wieght.BackColor = Color.LightPink

        End If
    End Sub

   

  
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        tb_treatment_name.Text = ""
        tb_treatment_name.Focus()

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        add_duration()
      
    End Sub

    Private Sub add_duration()
        set_values()

        If RadioButton6.Checked Then
            tb_note.Text = tb_note.Text & RadioButton6.Text
        ElseIf RadioButton7.Checked Then
            tb_note.Text = tb_note.Text & RadioButton7.Text
        ElseIf RadioButton8.Checked Then
            tb_note.Text = tb_note.Text & RadioButton8.Text
        ElseIf RadioButton9.Checked Then
            tb_note.Text = tb_note.Text & RadioButton9.Text
        ElseIf RadioButton10.Checked Then
            tb_note.Text = tb_note.Text & RadioButton10.Text
        ElseIf RadioButton11.Checked Then
            tb_note.Text = tb_note.Text & RadioButton11.Text
        ElseIf RadioButton12.Checked Then
            tb_note.Text = tb_note.Text & RadioButton12.Text
        ElseIf RadioButton13.Checked Then
            tb_note.Text = tb_note.Text & RadioButton13.Text
        ElseIf RadioButton14.Checked Then
            tb_note.Text = tb_note.Text & RadioButton14.Text
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        add_duration()

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        add_duration()

    End Sub

   
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        dose_calculate()
        add_duration()

    End Sub

    Private Sub CheckEdit1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            tb_cream_t1.Text = "  توضع في المقعد كل  "
        Else
            tb_cream_t1.Text = "  مسح موضعي كل  "
        End If
    End Sub

    Private Sub r_iv_amp_CheckedChanged(sender As Object, e As EventArgs) Handles r_iv_amp.CheckedChanged

    End Sub

    Private Sub r_im_amp_CheckedChanged(sender As Object, e As EventArgs) Handles r_im_amp.CheckedChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        tb_dose_to_patient.Text = ""

    End Sub

    Private Sub tb_vial_t4_EditValueChanged(sender As Object, e As EventArgs) Handles tb_vial_t4.EditValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class