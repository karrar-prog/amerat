Imports MySql.Data.MySqlClient

Public Class fm_add_item
    Dim store_count As Integer = 0
    Public f1 As String = ""


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        li_item.Hide()
        clear_values()
       
    End Sub

    Private Sub tb_barcode_EditValueChanged(sender As Object, e As EventArgs) Handles tb_barcode.EditValueChanged
        li_item.Hide()

    End Sub
    Public Sub name_search()


1:
        Try
            Dim item As New Item
                item.store_id = -1
   
                item.type = -1
          


            Dim d As New DataSet
            d = item.name_search(tb_name.Text.Trim, item, 30)


            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Private Sub fill_data(d As DataSet)

1:
        Try


            Dim dt As New DateTimePicker
        
            li_item.Items.Clear()

        

            If d.Tables(0).Rows.Count > 0 Then


                For i As Integer = 0 To d.Tables(0).Rows.Count - 1


                    li_item.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("barcode").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("name").ToString)

                    li_item.Items(i).SubItems.Add(type_title.Item(Convert.ToInt32(d.Tables(0).Rows(i).Item("type").ToString)))
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("price").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("count").ToString)
                    li_item.Items(i).SubItems.Add(store_title.Item(Convert.ToInt32(d.Tables(0).Rows(i).Item("store_id").ToString)))
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("place").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("detail").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("last_update").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    '  li_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("cost").ToString)



                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub tb_barcode_Enter(sender As Object, e As EventArgs) Handles tb_barcode.Enter
        li_item.Hide()

    End Sub

    Private Sub tb_barcode_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_barcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            'فحص  باركود مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.barcode = tb_barcode.Text.Trim
            get_info_from_barcode(item)


        End If
    End Sub
    Private Sub get_info_from_barcode(item As Item)
        Try
            Dim ds_barcode As New DataSet
            ds_barcode = item.barcode_check()
            If ds_barcode.Tables(0).Rows.Count > 0 Then
                tb_barcode.ReadOnly = True
                tb_name.ReadOnly = True
                btn_add.Visible = True
                tb_count.Focus()



                tb_id.Text = (ds_barcode.Tables(0).Rows(0).Item("id").ToString())
                tb_name.Text = (ds_barcode.Tables(0).Rows(0).Item("name").ToString())
                tb_barcode.Text = (ds_barcode.Tables(0).Rows(0).Item("barcode").ToString())
                tb_cost.Text = (ds_barcode.Tables(0).Rows(0).Item("cost").ToString())
                tb_price.Text = (ds_barcode.Tables(0).Rows(0).Item("price").ToString())
                tb_detail.Text = (ds_barcode.Tables(0).Rows(0).Item("detail").ToString())
                tb_f1.Text = (ds_barcode.Tables(0).Rows(0).Item("f1").ToString())
                tb_f2.Text = (ds_barcode.Tables(0).Rows(0).Item("f2").ToString())
                tb_f3.Text = (ds_barcode.Tables(0).Rows(0).Item("f3").ToString())
                tb_f4.Text = (ds_barcode.Tables(0).Rows(0).Item("f4").ToString())
                cb_store.Text = store_title.Item(Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("store_id").ToString()))
                cb_type.Text = type_title.Item(Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("type").ToString()))
                tb_id.BackColor = Color.Green
                l_old_item.Text = "  المادة موجودة بهذا الباركود  " + (ds_barcode.Tables(0).Rows(0).Item("name").ToString())
                l_add_count.Text = " موجود بالمخزن " + ds_barcode.Tables(0).Rows(0).Item("count").ToString()
                store_count = _i(ds_barcode.Tables(0).Rows(0).Item("count").ToString())
                Beep()
                fill_sizes()

                'add direct
                If tb_detail.Text.Trim = "" Then

                    add_new_item()
                End If

            Else
                clear_values()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_name_Click(sender As Object, e As EventArgs) Handles tb_name.Click
        li_item.Show()

    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        name_search()

    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If e.KeyCode = Keys.Enter Then
            'فحص  الاسم مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.name = tb_name.Text.Trim

            Dim ds As New DataSet
            ds = item.name_check()
            If ds.Tables(0).Rows.Count > 0 Then
                tb_barcode.ReadOnly = True
                tb_name.ReadOnly = True
                btn_add.Visible = True
                tb_count.Focus()



                tb_id.Text = (ds.Tables(0).Rows(0).Item("id").ToString())
                tb_name.Text = (ds.Tables(0).Rows(0).Item("name").ToString())
                tb_barcode.Text = (ds.Tables(0).Rows(0).Item("barcode").ToString())
                tb_price.Text = (ds.Tables(0).Rows(0).Item("price").ToString())
                tb_detail.Text = (ds.Tables(0).Rows(0).Item("detail").ToString())
                tb_cost.Text = (ds.Tables(0).Rows(0).Item("cost").ToString())
                tb_f1.Text = (ds.Tables(0).Rows(0).Item("f1").ToString())
                tb_f2.Text = (ds.Tables(0).Rows(0).Item("f2").ToString())
                tb_f3.Text = (ds.Tables(0).Rows(0).Item("f3").ToString())
                tb_f4.Text = (ds.Tables(0).Rows(0).Item("f4").ToString())
                cb_store.Text = store_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("store_id").ToString()))
                cb_type.Text = type_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("type").ToString()))
                tb_id.BackColor = Color.Green
                l_old_item.Text = " المادة موجودة بهذا الاسم  " + (ds.Tables(0).Rows(0).Item("name").ToString())
                l_add_count.Text = " موجود بالمخزن " + ds.Tables(0).Rows(0).Item("count").ToString()
                store_count = _i(ds.Tables(0).Rows(0).Item("count").ToString())
                Beep()
                btn_add.Focus()
                fill_sizes()

                If tb_detail.Text.Trim = "" Then

                    add_new_item()
              
                End If
            Else
                clear_values()
            End If

        End If
    End Sub

    Private Sub fm_add_item_Click(sender As Object, e As EventArgs) Handles Me.Click
        li_item.Hide()

    End Sub

    Private Sub fm_add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        li_item.Hide()

        btn_add.Visible = False
        li_size.View = View.Details
        li_size.Columns.Add("القياس", 280)
        'tb_saller_id.Text = user.id.ToString
        'tb_saller_name.Text = user.name
        'list
        li_user.View = View.Details
        li_user.Columns.Add("ت", 0)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 200)
        li_user.Columns.Add("نوع الحساب", 120)
        li_user.Columns.Add("حالة المستخدم", 200)
        li_user.Columns.Add("حقل2", 200)
        li_user.Columns.Add("حقل3", 200)
        li_user.Columns.Add("حقل4", 200)

        get_all_user()



        li_item.View = View.Details
        li_item.Columns.Add("ت", 0)
        li_item.Columns.Add("باركود", 0)
        li_item.Columns.Add("الاسم", 270)
        li_item.Columns.Add("النوع", 200)
        li_item.Columns.Add("السعر", 200)
        li_item.Columns.Add("العدد", 200)
        li_item.Columns.Add("المخزن", 200)
        li_item.Columns.Add("المكان", 200)
        li_item.Columns.Add("تفاصيل", 200)
        li_item.Columns.Add("اخر تحديث", 170)
        li_item.Columns.Add("حقل1", 1)
        li_item.Columns.Add("حقل2", 1)
        li_item.Columns.Add("حقل3", 1)
        li_item.Columns.Add("المستخدم", 120)
    End Sub
    Public Sub get_all_user()
1:
        Try
            Dim users As New Login
            Dim d As New DataSet
            d = users.get_all
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

    Private Sub clear_values()
        tb_barcode.Text = ""
        tb_barcode.Focus()


        tb_id.Text = "0"
        tb_barcode.Text = ""

        tb_count.Text = "1"
        tb_detail.Text = ""
        tb_f1.Text = ""
        tb_f2.Text = ""
        tb_f3.Text = ""
        tb_f4.Text = ""
        tb_name.Text = ""
        tb_place.Text = ""
        cb_store.Text = ""
        cb_type.Text = ""
        tb_select_size.Text = ""
        tb_price.Text = ""
        tb_id.BackColor = Color.WhiteSmoke

        l_old_item.Text = " "
        l_add_count.Text = ""
        tb_barcode.Focus()
        tb_barcode.ReadOnly = False
        tb_name.ReadOnly = False
        btn_add.Visible = False
        li_size.Items.Clear()
        li_size.Visible = False

       
    End Sub

    Private Sub tb_count_EditValueChanged(sender As Object, e As EventArgs) Handles tb_count.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If _i(tb_count.Text) < store_count Then
            tb_count.EditValue = _i(tb_count.Text) + 1

        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If _i(tb_count.Text) > 1 Then
            tb_count.EditValue = _i(tb_count.Text) - 1

        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        add_new_item()



    End Sub

    Private Sub add_new_item()

        If tb_select_size.Text.Trim = "" And tb_detail.Text.Trim <> "" Then

            MessageBox.Show("اختر القياس", "")

            Exit Sub
        End If


        If tb_saller_id.Text.Trim = "" Then

            tb_saller_id.BackColor = Color.Red


            Beep()


            Exit Sub
        End If




       

1:
            Try
                Dim item As New sell_menu_item
                item.item_cost = _i(tb_cost.Text)
                item.item_count = _i(tb_count.Text)
                item.item_name = tb_name.Text
                item.item_id = _i(tb_id.Text)
            item.item_price = _i(tb_price.Text)
            If (fm_sell.ch_user_pull.Checked = True) Then
                item.f1 = user_pull_it
            Else
                item.f1 = "بيع"
            End If
            item.f4 = tb_select_size.Text

                item.sell_menu_id = _i(tb_sell_menu_id.Text)
                item.datetime = Date.Now.ToString
            item.user_sell_it_id = __(tb_saller_id.Text)
                item.save()


                fm_sell.put_message(" اضافة مادة للقائمة", tb_name.Text)
                fm_sell.menu_search(_i(tb_sell_menu_id.Text))
            fm_sell.btn_add_new.Focus()
            clear_values()
            Me.Close()


            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1

                End If
            End Try







    End Sub

    Private Sub li_size_KeyUp(sender As Object, e As KeyEventArgs) Handles li_size.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()

        End If
    End Sub

    Private Sub li_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_size.SelectedIndexChanged

        If li_size.SelectedItems.Count > 0 Then
            tb_select_size.Text = li_size.SelectedItems.Item(0).Text.Trim

        End If
    End Sub

    Private Sub fill_sizes()

        If tb_detail.Text.Trim <> "" Then
            li_size.Visible = True

            Dim s As String = tb_detail.Text
            ' Split the string on the backslash character.
            Dim parts As String() = s.Split(New Char() {"\"c})
            ' Loop through result strings with For Each.
            Dim part As String
            For Each part In parts
                If part.Trim <> "" Then
                    li_size.Items.Add(part)
                End If

            Next
            li_size.Focus()

        Else
            li_size.Visible = False
            tb_select_size.Text = ""


        End If

    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_saller_id.Text = li_user.SelectedItems.Item(0).Text
            tb_saller_name.Text = li_user.SelectedItems.Item(0).SubItems(1).Text

        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles tb_from_menu.EditValueChanged

    End Sub

    Private Sub TextEdit1_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_from_menu.KeyUp
        If e.KeyCode = Keys.Enter Then
            If tb_from_menu.Text.Trim <> "" Then
                menu_search(__(tb_from_menu.Text))

            End If


        End If
    End Sub
    Public Sub menu_search(sell_menu_id As Integer)
1:
        Try
            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = sell_menu_id
            Dim d As New DataSet
            d = sell_menu_item.get_menu_items()

            Dim sell_menu As New sell_menu
            sell_menu.id = sell_menu_id
            sell_menu.status = 1
            sell_menu.f1 = "تم دمجها"
            sell_menu.user_finshed_id = user.id
            sell_menu.datevalue = Date.Now.ToShortDateString
            sell_menu.timevalue = Date.Now.ToLongTimeString
            sell_menu.status = 1
            sell_menu.discount = 0
            sell_menu.save()
           

            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1

2:
                    Try
                        Dim item As New sell_menu_item()
                        item.id = _i(d.Tables(0).Rows(i).Item("id").ToString)
                        item.item_cost = _i(d.Tables(0).Rows(i).Item("item_cost").ToString)
                        item.item_count = _i(d.Tables(0).Rows(i).Item("item_count").ToString)
                        item.item_name = d.Tables(0).Rows(i).Item("item_name").ToString
                        item.item_id = _i(d.Tables(0).Rows(i).Item("item_id").ToString)
                        item.item_price = _i(d.Tables(0).Rows(i).Item("item_price").ToString)
                        item.f1 = d.Tables(0).Rows(i).Item("f1").ToString
                        item.f2 = d.Tables(0).Rows(i).Item("f2").ToString
                        item.f3 = d.Tables(0).Rows(i).Item("f3").ToString
                        item.f4 = d.Tables(0).Rows(i).Item("f4").ToString
                        item.sell_menu_id = _i(tb_sell_menu_id.Text)
                        item.datetime = d.Tables(0).Rows(i).Item("datetime").ToString
                        item.user_sell_it_id = __(d.Tables(0).Rows(i).Item("userid").ToString)
                        item.save()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                        If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                            GoTo 1
                        End If
                    End Try
                Next
                fm_sell.put_message(" اضافة قائمة الى قائمة", tb_name.Text)
                fm_sell.menu_search(_i(tb_sell_menu_id.Text))
                fm_sell.btn_add_new.Focus()
                clear_values()
                Me.Close()
            Else
                Beep()
                tb_from_menu.Text = ""
                tb_from_menu.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub li_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item.SelectedIndexChanged
        If li_item.SelectedItems.Count > 0 Then
            li_item.Hide()

            tb_barcode.Text = li_item.SelectedItems.Item(0).SubItems(1).Text
            Dim item As New Item
            item.barcode = tb_barcode.Text.Trim
            get_info_from_barcode(item)

        End If
      
    End Sub
End Class