Imports MySql.Data.MySqlClient

Public Class fm_back_option

    Public sell_menu_id As Integer = 0

  
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If fm_sell.tb_customer_id.Text.Trim <> "" Then


            reback()
            ' reback_inside_menu()
         

        End If

    End Sub

    Private Sub reback_inside_menu()
    
1:
        Try
            Dim item As New sell_menu_item
            item.item_cost = _i(tb_cost.Text) * -1
            item.item_count = _i(tb_count.Text)
            item.item_name = tb_item_name.Text
            item.item_price = _i(tb_item_price.Text) * -1
            item.sell_menu_id = _i(fm_sell.tb_menu_id.Text)
            item.datetime = Date.Now.ToString
            item.f1 = "راجع"
            item.user_sell_it_id = user.id
            item.save()

            Dim itemback As New Item
            itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)

            Dim sell_menu As New sell_menu(_i(fm_sell.tb_menu_id.Text))
            sell_menu.status = 0
            sell_menu.save()

            fm_sell.menu_state = "قائمة استرجاع"
            fm_sell.put_message(" استرجاع مادة ", tb_item_name.Text)
            fm_sell.btn_finish.Focus()
            fm_sell.tb_status.Text = "0"
            fm_sell.menu_state = "قائمة استرجاع - اعادة طباعة"
            fm_sell.sett_button_text()

            fm_sell.menu_search(_i(tb_sell_menu_id.Text))




            'fm_sell.tb_menu_id.Text = fm_sell.tb_menu_id.Text
            'Dim d As New DataSet
            'Dim id As Integer
            'id = Convert.ToInt32(fm_sell.tb_menu_id.Text)
            'fm_sell.tb_status.EditValue = 0

            'Dim sell_menu_item As New sell_menu_item
            'sell_menu_item.sell_menu_id = id
            'd = sell_menu_item.get_menu_items()
            'fm_sell.fill_li_menu_item(d)


            Me.Close()






        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    'ارجاع من اجل الاستبدال
    Private Sub reback_2020()
        Dim basic_menu_id = fm_sell.tb_menu_id.Text

        'add new menu to customer_id
        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        sell_menu.customer_id = _i(fm_sell.tb_customer_id.Text.Trim)

        sell_menu.discount = 0



        sell_menu.f1 = "استبدال"
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 1
        sell_menu.user_finshed_id = user.id

        sell_menu.save()
        fm_sell.tb_search.Text = fm_sell.tb_customer_id.Text.Trim
        fm_sell.r_customer_id.Checked = True
        fm_sell.search()
        fm_sell.tb_menu_id.Text = fm_sell.tb_menu_id.Text
        fm_sell.menu_state = "قائمة استبدال - اعادة طباعة"
        fm_sell.sett_button_text()

1:
        Try
            Dim itemback As New Item
            itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)

            Dim item As New sell_menu_item
            item.item_cost = _i(tb_cost.Text) * -1
            item.item_count = _i(tb_count.Text)
            item.item_id = _i(tb_item_id.Text)
            item.item_name = tb_item_name.Text
            item.item_price = _i(tb_item_price.Text) * -1
            item.sell_menu_id = _i(fm_sell.li_sell_menu.Items(0).Text)
            item.datetime = Date.Now.ToString
            item.f1 = "استبدال"
            item.f2 = "نعم"
            item.f3 = basic_menu_id
            item.f4 = "مستبدلة"
            item.user_sell_it_id = user.id
            item.save()


            Dim old_item As New sell_menu_item(_i(tb_id.Text))
            old_item.f2 = "نعم"
            old_item.f3 = fm_sell.tb_menu_id.Text
            old_item.save()

            fm_sell.put_message(" استبدال مادة ", tb_item_name.Text)
            fm_sell.menu_search(_i(fm_sell.li_sell_menu.Items(0).Text))
            fm_sell.btn_finish.Focus()
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub
    Private Sub reback()
        Dim basic_menu_id = fm_sell.tb_menu_id.Text

        'add new menu to customer_id
        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        sell_menu.customer_id = _i(fm_sell.tb_customer_id.Text.Trim)
        If (get_discount_number()) Then
            sell_menu.discount = -1 * discount_amount
        Else
            sell_menu.discount = 0
        End If

        sell_menu.f1 = "استرجاع"
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 1
        sell_menu.user_finshed_id = user.id
        sell_menu.save()
        fm_sell.tb_search.Text = fm_sell.tb_customer_id.Text.Trim
        fm_sell.r_customer_id.Checked = True
        fm_sell.search()
        fm_sell.tb_menu_id.Text = fm_sell.tb_menu_id.Text
        fm_sell.menu_state = "قائمة استرجاع - اعادة طباعة"
        fm_sell.sett_button_text()

1:
        Try
            Dim itemback As New Item
            itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)

            Dim item As New sell_menu_item
            item.item_cost = _i(tb_cost.Text) * -1
            item.item_count = _i(tb_count.Text)
            item.item_id = _i(tb_item_id.Text)
            item.item_name = tb_item_name.Text
            item.item_price = _i(tb_item_price.Text) * -1
            item.sell_menu_id = _i(fm_sell.li_sell_menu.Items(0).Text)
            item.datetime = Date.Now.ToString
            item.f1 = "استرجاع"
            item.f2 = "نعم"
            item.f3 = basic_menu_id
            item.f4 = "مسترجعة"
            item.user_sell_it_id = user.id
            item.save()


            Dim old_item As New sell_menu_item(_i(tb_id.Text))
            old_item.f2 = "نعم"
            old_item.f3 = fm_sell.tb_menu_id.Text
            old_item.save()

            fm_sell.put_message(" استرجاع مادة ", tb_item_name.Text)
            fm_sell.menu_search(_i(fm_sell.li_sell_menu.Items(0).Text))
            fm_sell.btn_finish.Focus()
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub
    Private Sub new_replace()
        Dim basic_menu_id = fm_sell.tb_menu_id.Text

        'add new menu to customer_id
        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        sell_menu.customer_id = _i(fm_sell.tb_customer_id.Text.Trim)
        If (get_discount_number()) Then
            sell_menu.discount = -1 * discount_amount
        Else
            sell_menu.discount = 0
        End If

        sell_menu.f1 = "استبدال"
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 1
        sell_menu.user_finshed_id = user.id
        sell_menu.save()
        fm_sell.tb_search.Text = fm_sell.tb_customer_id.Text.Trim
        fm_sell.r_customer_id.Checked = True
        fm_sell.search()
        fm_sell.tb_menu_id.Text = fm_sell.tb_menu_id.Text
        fm_sell.menu_state = "وصل استبدال قطعة"
        fm_sell.sett_button_text()

1:
        Try
            Dim item As New sell_menu_item
            item.item_cost = _i(tb_cost.Text) * -1
            item.item_count = _i(tb_count.Text)
            item.item_id = _i(tb_item_id.Text)
            item.item_name = tb_item_name.Text
            item.item_price = _i(tb_item_price.Text) * -1
            item.sell_menu_id = _i(fm_sell.li_sell_menu.Items(0).Text)
            item.datetime = Date.Now.ToString
            item.f1 = "استبدال"
            item.f2 = "نعم"
            item.f3 = basic_menu_id
            item.user_sell_it_id = user.id
            item.save()


            Dim old_item As New sell_menu_item(_i(tb_id.Text))
            old_item.f2 = "نعم"
            old_item.f3 = fm_sell.tb_menu_id.Text
            old_item.save()

            Dim itemback As New Item
            itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)

            fm_sell.put_message(" استرجاع مادة ", tb_item_name.Text)
            fm_sell.menu_search(_i(fm_sell.li_sell_menu.Items(0).Text))
            fm_sell.btn_finish.Focus()
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If fm_sell.tb_customer_id.Text.Trim <> "" Then
            '  replace_outside_menu()
            'replace_inside_menu()
            new_replace()
        End If



    End Sub
    Private Sub replace_inside_menu()

1:
        Try
            Dim item As New sell_menu_item
            item.item_cost = _i(tb_cost.Text) * -1
            item.item_count = _i(tb_count.Text)
            item.item_name = tb_item_name.Text
            item.item_price = _i(tb_item_price.Text) * -1
            item.sell_menu_id = _i(fm_sell.tb_menu_id.Text)
            item.datetime = Date.Now.ToString
            item.f1 = "راجع"
            item.user_sell_it_id = user.id
            item.save()

            Dim itemback As New Item
            itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)

            Dim sell_menu As New sell_menu(_i(fm_sell.tb_menu_id.Text))
            sell_menu.status = 0
            sell_menu.save()

            fm_sell.menu_state = "قائمة استبدال"
            fm_sell.put_message(" استبدال مادة ", tb_item_name.Text)
            fm_sell.btn_finish.Focus()
            fm_sell.tb_status.Text = "0"
            fm_sell.menu_state = "قائمة استبدال - اعادة طباعة"
            fm_sell.sett_button_text()
            fm_sell.menu_search(_i(tb_sell_menu_id.Text))

            Dim fm_add_item As New fm_add_item
            fm_add_item.tb_sell_menu_id.Text = fm_sell.tb_menu_id.Text
            fm_add_item.f1 = "مضاف"
            fm_add_item.Show()

            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub
    Private Sub replace_outside_menu()

1:
        Try
            Dim basic_menu_id = fm_sell.tb_menu_id.Text

            'add new menu to customer_id
            Dim d As New DateTimePicker
            Dim sell_menu As New sell_menu
            sell_menu.customer_id = _i(fm_sell.tb_customer_id.Text.Trim)
            If (get_discount_number()) Then
                sell_menu.discount = -1 * discount_amount
            Else
                sell_menu.discount = 0
            End If
            sell_menu.f1 = "استبدال"
            sell_menu.datevalue = d.Value.ToShortDateString
            sell_menu.timevalue = d.Value.ToLongTimeString
            sell_menu.status = 1
            sell_menu.user_finshed_id = user.id
            sell_menu.save()
            fm_sell.tb_search.Text = fm_sell.tb_customer_id.Text.Trim
            fm_sell.r_customer_id.Checked = True
            fm_sell.search()
            fm_sell.tb_menu_id.Text = fm_sell.tb_menu_id.Text
            fm_sell.menu_state = "قائمة استبدال"
            fm_sell.sett_button_text()




            Try
                Dim item As New sell_menu_item
                item.item_cost = _i(tb_cost.Text) * -1
                item.item_count = _i(tb_count.Text)
                item.item_id = _i(tb_item_id.Text)
                item.item_name = tb_item_name.Text
                item.item_price = _i(tb_item_price.Text) * -1
                item.sell_menu_id = _i(fm_sell.li_sell_menu.Items(0).Text)
                item.datetime = Date.Now.ToString
                item.f1 = "راجع"
                item.f2 = "نعم"
                item.f3 = basic_menu_id
                item.user_sell_it_id = user.id
                item.save()


                Dim old_item As New sell_menu_item(_i(tb_id.Text))
                old_item.f2 = "نعم"
                old_item.f3 = fm_sell.tb_menu_id.Text
                old_item.save()
                Dim itemback As New Item
                itemback.count_increase(_i(tb_item_id.Text), tb_size_color.Text)
                fm_sell.put_message(" استبدال مادة ", tb_item_name.Text)
                fm_sell.menu_search(_i(fm_sell.li_sell_menu.Items(0).Text))
                fm_sell.btn_finish.Focus()
                Me.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1

                End If
            End Try

            Dim fm_add_item As New fm_add_item
            fm_add_item.tb_sell_menu_id.Text = fm_sell.tb_menu_id.Text
            fm_add_item.f1 = "بديل"
            fm_add_item.Show()

            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Public Function get_discount_number() As Boolean
        Dim count As Integer = 0

        If _i(tb_item_price.Text) >= discount_price Then


            For i = 0 To fm_sell.li_sell_menu_item.Items.Count - 1



                If fm_sell.li_sell_menu_item.Items(i).SubItems(8).Text <> "نعم" And _i(fm_sell.li_sell_menu_item.Items(i).SubItems(3).Text) >= discount_price Then
                    count = count + 1

                End If

            Next

        End If
        If count = 2 Or count = 3 Or count = 5 Or count = 6 Or count = 8 Or count = 9 Or count = 11 Or count = 12 Or count = 14 Or count = 15 Or count = 17 Or count = 18 Or count = 20 Or count = 21 Then
            Return True
        Else
            Return False

        End If


    End Function

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
      
        Dim old_item As New sell_menu_item(_i(tb_id.Text))

        old_item.item_price = 0
        old_item.gift = "هدية"

        old_item.save()
        Dim d As New DataSet

        Dim sell_menu_item As New sell_menu_item
        sell_menu_item.sell_menu_id = __(tb_sell_menu_id.Text)
        d = sell_menu_item.get_menu_items()
        fm_sell.fill_li_menu_item(d)
        Me.Close()

    End Sub

    Private Sub fm_back_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If fm_sell.tb_customer_id.Text.Trim <> "" Then
            reback_2020()
            ' reback_inside_menu()
        End If
    End Sub
End Class