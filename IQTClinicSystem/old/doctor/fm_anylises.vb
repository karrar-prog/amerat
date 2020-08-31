Public Class fm_anylises 

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        save_all_anylises()
    End Sub

    Private Sub save_all_anylises()


        fm_doctor_main.lv_treat_table.Items.Clear()
        fm_doctor_main.tb_treat_other.Text = to_lab



        If ch1.Checked Then
            fun_add(ch1)
        End If
        If ch2.Checked Then
            fun_add(ch2)
        End If
        If ch3.Checked Then
            fun_add(ch3)
        End If
        If ch4.Checked Then
            fun_add(ch4)
        End If
        If ch5.Checked Then
            fun_add(ch5)
        End If
        If ch6.Checked Then
            fun_add(ch6)
        End If
        If ch7.Checked Then
            fun_add(ch7)
        End If
        If ch8.Checked Then
            fun_add(ch8)
        End If
        If CheckEdit1.Checked Then
            fun_add(CheckEdit1)
        End If
        If CheckEdit2.Checked Then
            fun_add(CheckEdit2)
        End If
        If CheckEdit3.Checked Then
            fun_add(CheckEdit3)
        End If
        If CheckEdit4.Checked Then
            fun_add(CheckEdit4)
        End If
        If CheckEdit5.Checked Then
            fun_add(CheckEdit5)
        End If
        If CheckEdit6.Checked Then
            fun_add(CheckEdit6)
        End If
        If CheckEdit7.Checked Then
            fun_add(CheckEdit7)
        End If
        If CheckEdit8.Checked Then
            fun_add(CheckEdit8)
        End If
        If CheckEdit9.Checked Then
            fun_add(CheckEdit9)
        End If
        If CheckEdit10.Checked Then
            fun_add(CheckEdit10)
        End If
        If CheckEdit11.Checked Then
            fun_add(CheckEdit11)
        End If
        If CheckEdit12.Checked Then
            fun_add(CheckEdit12)
        End If
        If CheckEdit13.Checked Then
            fun_add(CheckEdit13)
        End If
        If CheckEdit14.Checked Then
            fun_add(CheckEdit14)
        End If
        If CheckEdit15.Checked Then
            fun_add(CheckEdit15)
        End If
        If CheckEdit16.Checked Then
            fun_add(CheckEdit16)
        End If
        If CheckEdit17.Checked Then
            fun_add(CheckEdit17)
        End If
        If CheckEdit18.Checked Then
            fun_add(CheckEdit18)
        End If
        If CheckEdit19.Checked Then
            fun_add(CheckEdit19)
        End If
        If CheckEdit20.Checked Then
            fun_add(CheckEdit20)
        End If
        If CheckEdit21.Checked Then
            fun_add(CheckEdit21)
        End If
        If CheckEdit22.Checked Then
            fun_add(CheckEdit22)
        End If
        If CheckEdit23.Checked Then
            fun_add(CheckEdit23)
        End If
        If CheckEdit24.Checked Then
            fun_add(CheckEdit24)
        End If
    

        Me.Close()


    End Sub

    Private Sub fun_add(checkEdit As DevExpress.XtraEditors.CheckEdit)
        fm_doctor_main.lv_treat_table.Items.Add("0")
        fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add(checkEdit.Text)
        fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add("  ")
        fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add("  ")
        fm_doctor_main.lv_treat_table.Items(fm_doctor_main.lv_treat_table.Items.Count - 1).SubItems.Add("  ")

    End Sub

End Class