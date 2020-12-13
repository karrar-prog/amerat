Public Class fm_save_and 

    Private Sub fm_save_and_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Print_reports(contract As Boolean, list As Boolean, map As Boolean)
        Dim p As New Patient(__(fm_add_other_required.tb_id.Text))
        Dim d As New DataSet
        d = getdatat1("select * from dept where user_id = " & p.id & " order by id asc")

        save_contract()

        
        If map Then
            print_map(p, d)
        End If
        If list Then
            print_list(p, d)
        End If



      

        If contract Then
            print_contract(p, d)
        End If




    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If fm_add_other_required.SimpleButton2.Text = "حفظ و طباعة" Then
            Dim p As New Patient(__(fm_add_other_required.tb_id.Text))

            p.item2 = fm_add_other_required.item2.Text
            p.name = fm_add_other_required.tb_name.Text
            p.item3 = fm_add_other_required.item3.Text
            p.tb_2 = fm_add_other_required.tb_2.Text
            p.tb_l_5 = fm_add_other_required.tb_l_5.Text
            p.item4 = fm_add_other_required.item4.Text
            If p.register_date.Trim = "" Then
                p.register_date = Date.Now.ToShortDateString

            End If
            p.admin_name = fm_add_other_required.tb_admin_name.Text
            p.is_token = "تعاقد"

            p.first_push_amount = fm_add_other_required.first_push
            p.first_push_present = fm_add_other_required.first_push_present


            p.set_contract()
            Dim content = " تم تحرير عقد : " & fm_add_other_required.tb_name.Text
            new_event2("تحرير عقد", content, 0)

        End If

        Print_reports(ch_contract.Checked, ch_list.Checked, ch_map.Checked)
        Me.Close()

    End Sub

    Private Sub print_contract(p As Patient, d As DataSet)
     

        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = p.name
        f.final_price = p.house_price.ToString
        f.user_dar = " ( H." & p.f3 & " ) "
        f.user_block = " ( " & p.f1 & "." & p.f2 & " )"
        f.remaind = p.tb_l_5
        f.arrive = p.tb_2
        f.user_name = p.name & " ) " & " بموجب الهوية المرقمة " & p.f6
        f.contract_date = p.register_date & "٠"
        f.user_block_number = " ( " & p.f2 & " ) "
        f.user_id_number = " ( " & p.f6 & " ) "
        f.dar_area = " ( " & p.ref_by & " ) "
        f.item1 = p.register_date
        f.item2 = p.item2 & "٠"
        f.item3 = p.item3
        f.item4 = p.item4
        f.item9 = p.f1 & p.f2 & "." & p.f3
        f.item10 = p.name
        f.admin_name = p.admin_name
        f.Show()


    End Sub

    Private Sub print_list(p As Patient, d As DataSet)

        Dim f2 As New fm_x_viewer_treat
        f2.ds = d
        f2.user_name = fm_add_other_required.tb_name.Text
        f2.final_price = fm_add_other_required.tb_all_dept.Text
        f2.path = "contract_list"

        f2.user_dar = " ( " & p.f3 & " ) "
        f2.user_block = " ( " & p.f1 & " ) "
        f2.remaind = p.tb_l_5
        f2.arrive = p.tb_2
        f2.user_name = " ( " & fm_add_other_required.tb_name.Text & " ) " & " بموجب الهوية المرقمة " & " ( " & p.f6 & " ) "
        f2.contract_date = p.register_date
        f2.user_block_number = " ( " & p.f2 & " ) "
        f2.user_id_number = " ( " & p.f6 & " ) "
        f2.dar_area = " ( " & p.ref_by & " ) "
        f2.item1 = p.diagonosis
        f2.item2 = p.item2
        f2.item3 = p.item3
        f2.item4 = p.item4
        f2.item9 = p.f1 & p.f2 & "." & p.f3
        f2.item10 = p.name
        f2.admin_name = p.admin_name



        f2.Show()

    End Sub

    Private Sub print_map(p As Patient, d As DataSet)

    

        Dim f As New fm_x_viewer_treat
        f.ds = d
        f.user_name = p.name
        f.final_price = p.house_price.ToString


        f.user_dar = " ( " & p.f3 & " ) "
        f.user_block = " ( " & p.f1 & " ) "
        f.remaind = p.tb_l_5
        f.arrive = p.tb_2

        f.user_name = p.name
        f.contract_date = p.register_date
        f.user_block_number = " ( " & p.f2 & " ) "
        f.user_id_number = " ( " & p.f6 & " ) "
        f.dar_area = " ( " & p.ref_by & " ) "
        f.item2 = p.item2
        f.item3 = p.id.ToString
        f.path = "map"
        f.item4 = images_path & "\p" & p.id.ToString & "\map\ألخارطة.png"
        f.item9 = p.f1 & p.f2 & "." & p.f3
        f.item10 = p.name
        f.admin_name = p.admin_name
        f.item6 = p.f9


        f.Show()

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs)
    

    End Sub

    Private Sub ch_contract_CheckedChanged(sender As Object, e As EventArgs) Handles ch_contract.CheckedChanged
        do_if_not_all_checked()
    End Sub

    Private Sub do_if_not_all_checked()
     
    End Sub

    Private Sub ch_list_CheckedChanged(sender As Object, e As EventArgs) Handles ch_list.CheckedChanged
        do_if_not_all_checked()
    End Sub

    Private Sub ch_map_CheckedChanged(sender As Object, e As EventArgs) Handles ch_map.CheckedChanged
        do_if_not_all_checked()
    End Sub

    Private Sub save_contract()
        If SimpleButton2.Text = "حفظ و طباعة" Then
            Dim p As New Patient(__(fm_add_other_required.tb_id.Text))

            p.item2 = fm_add_other_required.item2.Text
            p.name = fm_add_other_required.tb_name.Text
            p.item3 = fm_add_other_required.item3.Text
            p.tb_2 = fm_add_other_required.tb_2.Text
            p.tb_l_5 = fm_add_other_required.tb_l_5.Text
            p.item4 = fm_add_other_required.item4.Text
            If p.register_date.Trim = "" Then
                p.register_date = Date.Now.ToShortDateString
            End If
            p.admin_name = fm_add_other_required.tb_admin_name.Text
            p.is_token = "تعاقد"
            p.first_push_amount = fm_add_other_required.first_push
            p.first_push_present = fm_add_other_required.first_push_present


            p.set_contract()
            Dim content = " تم تحرير عقد : " & fm_add_other_required.tb_name.Text
            new_event2("تحرير عقد", content, 0)

        End If

    End Sub

End Class