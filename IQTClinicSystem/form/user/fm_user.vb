Imports MySql.Data.MySqlClient

Public Class fm_user

 
    Private Sub fm_user_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub

    Private Sub fm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '     DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-7)
        formating()
        get_all()

    End Sub
    Public Sub fill_li_menu_item(d As DataSet)


1:
        Try

            Dim count As Integer = 0
            Dim money As Integer = 0
            Dim not_cashe As Integer = 0
            Dim not_cashe_count As Integer = 0
            tb_money.Text = ""


            tb_c1.Text = "0"
            tb_c2.Text = "0"
            tb_c3.Text = "0"
            tb_c4.Text = "0"
            tb_c5.Text = "0"
            tb_back_count.Text = "0"
            tb_not_complete.Text = "0"
            tb_user_not_cashe.Text = "0"

            Dim c1 As Integer = 0


            li_sell_menu_item.Items.Clear()
            li_category.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_sell_menu_item.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("sell_menu_id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_name").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_price").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_count").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(tb_username.Text)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("datetime").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_cost").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_finshed_id").ToString)

                    If _i(d.Tables(0).Rows(i).Item("item_price").ToString) <= 0 Then
                        li_sell_menu_item.Items(i).BackColor = Color.LightPink
                        tb_back_count.Text = (__(tb_back_count.Text) + 1).ToString

                    ElseIf _i(d.Tables(0).Rows(i).Item("user_finshed_id").ToString) = 0 Then

                        tb_not_complete.Text = (__(tb_not_complete.Text) + 1).ToString
                    Else
                      
                        li_sell_menu_item.Items(i).BackColor = Color.LightGreen
                        If d.Tables(0).Rows(i).Item("f1").ToString = user_pull_it Then
                            not_cashe = not_cashe + __(d.Tables(0).Rows(i).Item("item_price").ToString)
                            not_cashe_count = not_cashe_count + 1
                            li_sell_menu_item.Items(i).BackColor = Color.Yellow
                        Else
                        count = count + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                        money = money + __(d.Tables(0).Rows(i).Item("item_price").ToString)
                       
                            calculate_catogory(__(d.Tables(0).Rows(i).Item("item_price").ToString))
                            If c1 = 0 Then
                                li_category.Items().Add("1")
                                li_category.Items(c1).SubItems.Add(d.Tables(0).Rows(i).Item("item_name").ToString)
                                li_category.Items(c1).SubItems.Add(d.Tables(0).Rows(i).Item("item_price").ToString)
                                c1 = c1 + 1
                            Else
                                If li_category.Items(c1 - 1).SubItems(1).Text = d.Tables(0).Rows(i).Item("item_name").ToString Then
                                    li_category.Items(c1 - 1).Text = (__(li_category.Items(c1 - 1).Text) + 1).ToString
                                Else
                                    li_category.Items().Add("1")
                                    li_category.Items(c1).SubItems.Add(d.Tables(0).Rows(i).Item("item_name").ToString)
                                    li_category.Items(c1).SubItems.Add(d.Tables(0).Rows(i).Item("item_price").ToString)
                                    c1 = c1 + 1
                                End If
                            End If

                        End If



                    End If



                Next
                tb_count.Text = count.ToString
                tb_money.Text = money.ToString
                tb_user_not_cashe.Text = not_cashe.ToString
                tb_not_chash_count.Text = not_cashe_count.ToString()
                tb_not_chash_count.BackColor = Color.Yellow
                tb_user_not_cashe.BackColor = Color.White


                tb_clear_money_menu.Text = (money - __(tb_discounts.Text)).ToString
                tb_final_money.EditValue = (money - __(tb_discounts.Text) - __(tb_final_pull.Text)).ToString



            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub


    Private Sub formating()
        tb_count.BackColor = Color.LightGreen
        tb_back_count.BackColor = Color.LightPink
       
        'list
        li_user.View = View.Details
        li_user.Columns.Add("ت", 40)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 200)
        li_user.Columns.Add("نوع الحساب", 120)
        li_user.Columns.Add("حالة المستخدم", 200)
        li_user.Columns.Add("حقل2", 200)
        li_user.Columns.Add("حقل3", 200)
        li_user.Columns.Add("حقل4", 200)


        'list
        li_category.View = View.Details
        li_category.Columns.Add("عدد المباع", 120)

        li_category.Columns.Add("اسم المادة", 300)
        li_category.Columns.Add("السعر", 140)
      
        'list
        li_my_permission.View = View.Details
        li_my_permission.Columns.Add("ت", 0)
        li_my_permission.Columns.Add("عنوان الصلاحية", 250)
        li_my_permission.Columns.Add("تأريخ المنح", 250)
        li_my_permission.Columns.Add("رقم المانح", 250)

        'list
        li_permission.View = View.Details
        li_permission.Columns.Add("عنوان الصلاحية", 200)
        li_permission.Columns.Add("توضيح", 450)
        permistion_titles(li_permission)

        'list
        li_sell_menu_item.View = View.Details
        li_sell_menu_item.Columns.Add("ت", 50)
        li_sell_menu_item.Columns.Add("رقم القائمة", 0)
        li_sell_menu_item.Columns.Add("اسم المادة", 200)
        li_sell_menu_item.Columns.Add("السعر", 160)
        li_sell_menu_item.Columns.Add("العدد", 100)

        li_sell_menu_item.Columns.Add("البائع", 200)
        li_sell_menu_item.Columns.Add("التاريخ", 240)
        li_sell_menu_item.Columns.Add("الحالة", 200)
        li_sell_menu_item.Columns.Add("استرجع", 200)
        li_sell_menu_item.Columns.Add("قائمة الاسترجاع", 200)
        li_sell_menu_item.Columns.Add("قياس و لون", 200)
        li_sell_menu_item.Columns.Add("رقم المادة", 200)
        li_sell_menu_item.Columns.Add("idid", 0)
        li_sell_menu_item.Columns.Add("رقم الكاشير", 100)


        li_sell_menu.View = View.Details
        li_sell_menu.Columns.Add("ت", 0)
        li_sell_menu.Columns.Add("التاريخ", 120)
        li_sell_menu.Columns.Add("الوقت", 120)
        li_sell_menu.Columns.Add("المبلغ الاجمالي", 0)
        li_sell_menu.Columns.Add("الخصم", 140)
        li_sell_menu.Columns.Add("رقم الكاشير", 120)
        li_sell_menu.Columns.Add("الحالة", 180)
        li_sell_menu.Columns.Add("اسم الزبون", 180)
        li_sell_menu.Columns.Add("العملية", 180)
        li_sell_menu.Columns.Add("رقم العامل", 180)
     
    End Sub
    Public Sub get_all()
1:
        Try
            Dim users As New Login
            Dim d As New DataSet
            d = users.get_all2
            fill_li_user(d)
      
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub fill_li_user(d As DataSet)

1:
        Try
            li_user.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_user.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("name").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("phone").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("type").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_user.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    If d.Tables(0).Rows(i).Item("f1").ToString = blocked_user Then
                        li_user.Items(i).BackColor = Color.Red
                        li_user.Items(i).ForeColor = Color.White

                    End If
                    If d.Tables(0).Rows(i).Item("type").ToString = "1" Then
                        li_user.Items(i).BackColor = Color.Green
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



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        clear_values()

    End Sub

    Private Sub clear_values()
        tb_id.Text = "0"
        tb_name.Text = ""
        tb_phone.Text = ""
        tb_f1.Text = ""
        tb_f2.Text = ""
        tb_f3.Text = ""
        tb_password.Text = ""
        tb_repassword.Text = ""
        GroupControl1.Visible = True
        CheckBox1.Checked = True

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If check_values() Then
            add_new()
            clear_values()
           

        End If

    End Sub

    Private Sub add_new()
        Dim user As New Login
        user.id = _i(tb_id.Text)
        user.type = 2
        user.name = tb_name.Text
        user.secret_word = tb_password.Text
        user.phone = tb_phone.Text
        user.f1 = tb_f1.Text
        user.f2 = tb_f2.Text
        user.f3 = tb_f3.Text
        user.f4 = tb_f4.Text
        user.save()
        get_all()

    End Sub

    Private Function check_values() As Boolean
        set_color_white()

        If tb_name.Text.Trim = "" Then
            tb_name.BackColor = Color.LightPink
            Return False
        ElseIf tb_phone.Text.Trim = "" Then
            tb_phone.BackColor = Color.LightPink
            Return False
        ElseIf tb_password.Text.Length < 6 Then
            tb_password.BackColor = Color.LightPink
            tb_repassword.BackColor = Color.LightPink
            MessageBox.Show("يجب ان تكون كلمة المرور 6 احرف أو 6 ارقام")
            Return False
        ElseIf tb_password.Text.Trim <> tb_repassword.Text.Trim Then
            tb_password.BackColor = Color.LightPink
            tb_repassword.BackColor = Color.LightPink
            MessageBox.Show("كلمة المرور غير متطابقة")
            Return False
        ElseIf li_my_permission.Items.Count <= 0 Then
            MessageBox.Show("يجب اعطاء صلاحية", "")
            Return False

        End If
        Return True

    End Function

    Private Sub set_color_white()
        tb_name.BackColor = Color.White
        tb_phone.BackColor = Color.White
        tb_password.BackColor = Color.White
        tb_repassword.BackColor = Color.White

    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        tb_name.BackColor = Color.White


    End Sub

    Private Sub tb_phone_EditValueChanged(sender As Object, e As EventArgs) Handles tb_phone.EditValueChanged

        tb_phone.BackColor = Color.White

    End Sub

    Private Sub tb_password_EditValueChanged(sender As Object, e As EventArgs) Handles tb_password.EditValueChanged

        tb_password.BackColor = Color.White

    End Sub

    Private Sub tb_repassword_EditValueChanged(sender As Object, e As EventArgs) Handles tb_repassword.EditValueChanged

        tb_repassword.BackColor = Color.White

    End Sub

    Private Sub TabNavigationPage2_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage2.Paint

    End Sub

    Private Sub li_permission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_permission.SelectedIndexChanged
        If li_permission.SelectedItems.Count > 0 Then
            Dim per As String = li_permission.SelectedItems.Item(0).Text
            If not_tokent(per) Then
                Dim permission As New Permission
                permission.title = per
                permission.user_did_it = user.id
                permission.user_id = _i(tb_id.Text)
                permission.save()
                get_my_permission()
            End If
        End If

    End Sub

    Private Function not_tokent(per As String) As Boolean
        If li_my_permission.Items.Count > 0 Then
            For i = 0 To li_my_permission.Items.Count - 1
                If per = li_my_permission.Items(i).SubItems(1).Text Then
                    Return False
                End If
            Next
        End If
        Return True

    End Function

    Private Sub li_user_Disposed(sender As Object, e As EventArgs) Handles li_user.Disposed

    End Sub

    Private Sub li_user_DoubleClick(sender As Object, e As EventArgs) Handles li_user.DoubleClick
    
    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_user_id.Text = li_user.SelectedItems.Item(0).Text
            tb_username.Text = li_user.SelectedItems.Item(0).SubItems(1).Text

        End If
    End Sub

    Private Sub تعديلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلToolStripMenuItem.Click
        If li_user.SelectedItems.Count > 0 Then
            If li_user.SelectedItems.Item(0).SubItems(3).Text <> "1" Then
                put_user_info(_i(li_user.SelectedItems.Item(0).Text))
            Else
                MessageBox.Show("لايمكن تحرير معلومات المدير")

            End If

        End If
    End Sub

    Private Sub put_user_info(id As Integer)
        Dim user As New Login(id)
        tb_id.Text = user.id.ToString
        tb_name.Text = user.name
        tb_phone.Text = user.phone
        tb_password.Text = user.secret_word
        tb_repassword.Text = user.secret_word
        GroupControl1.Visible = False
        CheckBox1.Checked = False

        tb_f1.Text = user.f1
        tb_f2.Text = user.f2
        tb_f3.Text = user.f3
        tb_f4.Text = user.f4
        TabPane1.SelectedPageIndex = 1
        get_my_permission()

    End Sub

    Private Sub حظرالمستخدمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حظرالمستخدمToolStripMenuItem.Click
        If li_user.SelectedItems.Count > 0 Then
            If li_user.SelectedItems.Item(0).SubItems(3).Text <> "1" Then
                block_user(blocked_user)
            Else
                MessageBox.Show("لايمكن تحرير معلومات المدير")

            End If

        End If
    End Sub

    Private Sub block_user(p1 As String)
        Try
            Dim user As New Login(_i(li_user.SelectedItems.Item(0).Text))
            user.f1 = p1
            user.save()
            get_all()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub enable_user()
        Try
            Dim user As New Login(_i(li_user.SelectedItems.Item(0).Text))
            user.f1 = "فعال"
            user.save()
            get_all()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub تفعيلالمستخدمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تفعيلالمستخدمToolStripMenuItem.Click
        If li_user.SelectedItems.Count > 0 Then
                enable_user()
           
        End If
    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If li_my_permission.SelectedItems.Count > 0 Then
            If MessageBox.Show("هل انت متأكد ؟", "سوف تقوم بحذف الصلاحية", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim permission As New Permission
                permission.id = _i(li_my_permission.SelectedItems.Item(0).Text)
                permission.delete()
                get_my_permission()

            End If


        End If
    End Sub

    Private Sub li_my_permission_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_my_permission.SelectedIndexChanged

    End Sub

    Private Sub get_my_permission()
        Dim per As New Permission
        per.user_id = _i(tb_id.Text)
        Dim d As New DataSet
        d = per.get_user_permission()
        fill_per(d)

    End Sub

    Private Sub fill_per(d As DataSet)

1:
        Try
            li_my_permission.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_my_permission.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_my_permission.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("title").ToString)
                    li_my_permission.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("date_got").ToString)
                    li_my_permission.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_did_id").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupControl1.Visible = True

        Else
            GroupControl1.Visible = False



        End If
    End Sub

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs) Handles LabelControl8.Click

    End Sub

    Private Sub TabNavigationPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage1.Paint

    End Sub

    Private Sub c1_to_EditValueChanged(sender As Object, e As EventArgs) Handles c1_to.EditValueChanged

    End Sub

    Private Sub c1_to_KeyUp(sender As Object, e As KeyEventArgs) Handles c1_to.KeyUp
        c2_from.Text = (_i(c1_to.Text) + 1).ToString


    End Sub

    Private Sub c2_to_EditValueChanged(sender As Object, e As EventArgs) Handles c2_to.EditValueChanged

    End Sub

    Private Sub c2_to_KeyUp(sender As Object, e As KeyEventArgs) Handles c2_to.KeyUp
        c3_from.Text = (_i(c2_to.Text) + 1).ToString


    End Sub

    Private Sub c3_to_EditValueChanged(sender As Object, e As EventArgs) Handles c3_to.EditValueChanged

    End Sub

    Private Sub c3_to_KeyUp(sender As Object, e As KeyEventArgs) Handles c3_to.KeyUp
        c4_from.Text = (_i(c3_to.Text) + 1).ToString


    End Sub

    Private Sub c4_to_EditValueChanged(sender As Object, e As EventArgs) Handles c4_to.EditValueChanged

    End Sub

    Private Sub c4_to_KeyUp(sender As Object, e As KeyEventArgs) Handles c4_to.KeyUp
        c5_from.Text = (_i(c4_to.Text) + 1).ToString


    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        GroupControl6.Hide()
        tb_final_money.Hide()
        LabelControl39.Hide()
        btn_tb_things_pull.Hide()
        tb_things_pull.Hide()
        btn_tb_other_pull.Hide()
        tb_other_pull.Hide()
        tb_user_not_cashe.Show()
        btn_tb_user_not_cashe.Show()

        clear_money()

        get_user_pull()
        li_sell_menu.Items.Clear()

        get_items_for_user()
        l_title.Text = SimpleButton6.Text
        l_old_item.Text = "سحب هذا العامل خلال هذه الفتره"
    End Sub

    Private Sub get_items_for_user()
        Dim sell_menu_item As New sell_menu_item
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet

        d = sell_menu_item.get_menu_items_for_user(id, DateTimePicker1, DateTimePicker2)
        fill_li_menu_item(d)
    End Sub
    Private Sub get_items_for_casher()
        Dim sell_menu_item As New sell_menu_item
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet

        d = sell_menu_item.get_menu_items_for_casher(id, DateTimePicker1, DateTimePicker2)
        fill_li_menu_item(d)
    End Sub
    Private Sub get_items_for_all()
        Dim sell_menu_item As New sell_menu_item
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet

        d = sell_menu_item.get_menu_items_all(DateTimePicker1, DateTimePicker2)
        fill_li_menu_item(d)
    End Sub

    Private Sub calculate_catogory(price As Integer)
        If price >= __(c1_from.Text) And price <= __(c1_to.Text) Then
            tb_c1.Text = (__(tb_c1.Text) + 1).ToString
        End If
        If price >= __(c2_from.Text) And price <= __(c2_to.Text) Then
            tb_c2.Text = (__(tb_c2.Text) + 1).ToString
        End If
        If price >= __(c3_from.Text) And price <= __(c3_to.Text) Then
            tb_c3.Text = (__(tb_c3.Text) + 1).ToString
        End If
        If price >= __(c4_from.Text) And price <= __(c4_to.Text) Then
            tb_c4.Text = (__(tb_c4.Text) + 1).ToString
        End If
        If price >= __(c5_from.Text) Then
            tb_c5.Text = (__(tb_c5.Text) + 1).ToString
        End If
    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_final_money.Show()
        LabelControl39.Show()

        tb_things_pull.Show()
        btn_tb_things_pull.Show()
        btn_tb_other_pull.Show()
        tb_other_pull.Show()
        tb_user_not_cashe.Hide()
        btn_tb_user_not_cashe.Hide()

        clear_money()
        get_caher_pull()
        chasher_sell_menu_search()
        get_items_for_casher()
        l_title.Text = SimpleButton4.Text
        l_old_item.Text = "المبالغ التي اعطاها الكاشير هذه لفتره"
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        GroupControl6.Show()
        tb_final_money.Show()
        LabelControl39.Show()
        tb_things_pull.Show()
        btn_tb_things_pull.Show()

        btn_tb_other_pull.Show()
        tb_other_pull.Show()
        tb_user_not_cashe.Hide()
        btn_tb_user_not_cashe.Hide()

        clear_money()

        get_all_pull()
        all_sell_menu_search()
        get_items_for_all()
        l_title.Text = SimpleButton5.Text
        l_old_item.Text = "مبلغ السحب الكلي لهذه الفتره"
    End Sub
    Private Sub chasher_sell_menu_search()
        Try
            Dim sell_menu As New sell_menu
            'sell_menu.customer_id = customer_id
            Dim d As New DataSet
            d = sell_menu.get_chasher_menus_date(__(tb_user_id.Text), DateTimePicker1, DateTimePicker2)
            fill_li_menu(d)

        Catch ex As Exception

        End Try


    End Sub
    Private Sub all_sell_menu_search()
        Try
            Dim sell_menu As New sell_menu
            'sell_menu.customer_id = customer_id
            Dim d As New DataSet
            d = sell_menu.get_all_menus_date(DateTimePicker1, DateTimePicker2)
            fill_li_menu(d)

        Catch ex As Exception

        End Try


    End Sub
    Private Sub fill_li_menu(d As DataSet)

        Dim dt As New DateTimePicker
        Dim dt2 As New DateTimePicker
        Dim count = 0
        Dim not_cash_count As Int64 = 0
1:
        Try

            li_sell_menu.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_sell_menu.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    Try
                        dt.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("date").ToString)
                        li_sell_menu.Items(i).SubItems.Add(dt.Value.ToShortDateString)
                    Catch ex As Exception
                        li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("date").ToString)
                    End Try


                    Try
                        dt2.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("time").ToString)
                        li_sell_menu.Items(i).SubItems.Add(dt2.Value.ToShortTimeString)
                    Catch ex As Exception
                        li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("time").ToString)
                    End Try
                    'Dim price As Integer = get_price_of_menu(__(d.Tables(0).Rows(i).Item("id").ToString))
                    li_sell_menu.Items(i).SubItems.Add("لم يتم عرضه")
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("discount").ToString)


                    If d.Tables(0).Rows(i).Item("f1").ToString = not_chash Then

                    Else
                        count = count + __(d.Tables(0).Rows(i).Item("discount").ToString)

                    End If

                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_finshed_id").ToString)


                    If d.Tables(0).Rows(i).Item("f1").ToString = "بيع" Then
                        li_sell_menu.Items(i).BackColor = Color.LightGreen
                    ElseIf d.Tables(0).Rows(i).Item("f1").ToString = "استرجاع" Then
                        li_sell_menu.Items(i).BackColor = Color.LightPink
                    ElseIf d.Tables(0).Rows(i).Item("f1").ToString = "تم دمجها" Then
                        li_sell_menu.Items(i).BackColor = Color.Blue
                    Else
                        li_sell_menu.Items(i).BackColor = Color.White
                    End If
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
            
                    If d.Tables(0).Rows(i).Item("user_finshed_id").ToString = "0" Then
                        li_sell_menu.Items(i).BackColor = Color.White
                        li_sell_menu.Items(i).SubItems.Add(not_complete)

                       
                    Else
                        If d.Tables(0).Rows(i).Item("f1").ToString = not_chash Then
                            li_sell_menu.Items(i).SubItems.Add(not_chash)

                            li_sell_menu.Items(i).BackColor = Color.Yellow

                        Else
                            li_sell_menu.Items(i).SubItems.Add("تم البيع")
                        End If


                    End If


                Next
                tb_discounts.Text = count.ToString
                btn_tb_user_not_cashe.Text = not_cash_count.ToString


            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub tb_things_pull_EditValueChanged(sender As Object, e As EventArgs) Handles tb_things_pull.EditValueChanged

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles btn_tb_user_pull.Click
        fm_view_pulls.tb_user_id.Text = tb_user_id.Text
        fm_view_pulls.tb_username.Text = tb_username.Text
        fm_view_pulls.DateTimePicker1.Value = DateTimePicker1.Value
        fm_view_pulls.DateTimePicker2.Value = DateTimePicker2.Value
        fm_view_pulls.get_user_pulls()
        fm_view_pulls.back = "user"
        fm_view_pulls.Show()

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles btn_tb_things_pull.Click

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles btn_tb_other_pull.Click

    End Sub

    Private Sub get_user_pull()
        Dim list As New UserMoneyList
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet
        list.user_id = id
        d = list.get_all_user_money(DateTimePicker1, DateTimePicker2)
        fill_list(d)
    End Sub
    Private Sub get_caher_pull()
        Dim list As New UserMoneyList
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet
        list.user_did_id = id
        d = list.get_all_casher_money(DateTimePicker1, DateTimePicker2)
        fill_list(d)
    End Sub
    Private Sub get_all_pull()
        Dim list As New UserMoneyList
        Dim id = _i(tb_user_id.Text)
        Dim d As New DataSet
        d = list.get_all_money(DateTimePicker1, DateTimePicker2)
        fill_list(d)
    End Sub

    Private Sub fill_list(d As DataSet)
        Dim final_pull As Integer = 0
        Dim things_pull As Integer = 0
        Dim user_pull As Integer = 0
        Dim other_pull As Integer = 0
     


1:
        Try

            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1


                    final_pull = final_pull + __(d.Tables(0).Rows(i).Item("amount").ToString())
                    If d.Tables(0).Rows(i).Item("type").ToString() = "سحب" Then
                        user_pull = user_pull + __(d.Tables(0).Rows(i).Item("amount").ToString())

                    ElseIf d.Tables(0).Rows(i).Item("type").ToString() = "اثاث" Then
                        things_pull = things_pull + __(d.Tables(0).Rows(i).Item("amount").ToString())
                    ElseIf d.Tables(0).Rows(i).Item("type").ToString() = "مصاريف" Then
                        other_pull = other_pull + __(d.Tables(0).Rows(i).Item("amount").ToString())

                    End If
                Next
            End If
            tb_final_pull.Text = final_pull.ToString
            tb_other_pull.Text = other_pull.ToString
            tb_user_pull.Text = user_pull.ToString
            tb_things_pull.Text = things_pull.ToString

        Catch ex As Exception

        End Try


    End Sub

    Private Sub clear_pull()
        Throw New NotImplementedException
    End Sub

    Private Sub clear_money()
        tb_final_pull.Text = ""
        tb_things_pull.Text = ""
        tb_final_pull.Text = ""
        tb_user_pull.Text = ""
        tb_other_pull.Text = ""
        tb_final_money.Text = ""
        tb_discounts.Text = ""
        tb_clear_money_menu.Text = ""


    End Sub

    Private Sub li_sell_menu_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_sell_menu_item.SelectedIndexChanged

    End Sub

    Private Sub tb_money_EditValueChanged(sender As Object, e As EventArgs) Handles tb_money.EditValueChanged

    End Sub

    Private Sub li_sell_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_sell_menu.SelectedIndexChanged

    End Sub

    Private Sub عرضتفاصيلالقائمةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضتفاصيلالقائمةToolStripMenuItem.Click
        If li_sell_menu.SelectedItems.Count > 0 Then
           
            fm_sell.tb_menu_id.EditValue = 0

            fm_sell.tb_count.Text = "0"
            fm_sell.tb_count2.Text = "0"
            fm_sell.tb_total_price.Text = "0"
            fm_sell.tb_discount.Text = "0"
            fm_sell.tb_final_price.Text = "0"
            fm_sell.tb_status.Text = ""
            fm_sell.tb_customer_name.Text = ""
            fm_sell.tb_customer_type.Text = ""
            fm_sell.ch_user_pull.Checked = True
            fm_sell.tb_menu_id.Text = li_sell_menu.SelectedItems.Item(0).SubItems(0).Text
            fm_sell.tb_f1.Text = li_sell_menu.SelectedItems.Item(0).SubItems(4).Text
            Dim d As New DataSet
            Dim id As Integer
            id = Convert.ToInt32(li_sell_menu.SelectedItems.Item(0).SubItems(0).Text)
            fm_sell.tb_status.EditValue = "1"

            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = id

            d = sell_menu_item.get_menu_items()

            fm_sell.tb_customer_id.Text = "0"

            fm_sell.fill_li_menu_item(d)
            fm_sell.back_path = "0"
            fm_sell.GroupControl1.Hide()
            fm_sell.GroupControl3.Hide()
            fm_sell.SimpleButton7.Hide()
            fm_sell.SimpleButton9.Hide()
            fm_sell.SimpleButton9.Hide()
            fm_sell.SimpleButton10.Hide()
            fm_sell.ch_user_pull.Hide()
            fm_sell.LabelControl2.Hide()
            fm_sell.l_customer_name.Hide()
            fm_sell.btn_add_new.Hide()

            fm_sell.Show()

        End If
    End Sub

    Private Function get_price_of_menu(id As Integer) As Integer

        Dim s_m As New sell_menu_item
        Dim d2 As New DataSet


        d2 = s_m.get_menu_total_price(id)
        Dim totla_price As Integer = 0
        li_sell_menu.Items.Clear()
        If d2.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To d2.Tables(0).Rows.Count - 1
                totla_price = totla_price + __(d2.Tables(0).Rows(0).Item("item_price").ToString)
            Next
        End If
        Return totla_price






    End Function

End Class