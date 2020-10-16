Imports MySql.Data.MySqlClient
Imports System.IO.Ports

Public Class fm_sell
    Public menu_state As String = "قائمة بيع"
    Public back_path As String = ""

    Private Sub tb_search_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search.EditValueChanged

    End Sub



    Private Sub ListView3_DoubleClick(sender As Object, e As EventArgs) Handles li_sell_menu_item.DoubleClick

        Try
            fm_back_option.Close()

        Catch ex As Exception

        End Try
        Try
            fm_delete_option.Close()

        Catch ex As Exception

        End Try

        If li_sell_menu_item.SelectedItems.Count > 0 Then

            If li_sell_menu_item.SelectedItems.Item(0).SubItems(8).Text <> "نعم" Then


                If _i(li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text) >= 0 Then
                    If tb_status.Text = "0" Then
                        'you can delete it
                        fm_delete_option.tb_item_id.Text = li_sell_menu_item.SelectedItems.Item(0).Text
                        fm_delete_option.tb_sell_menu_id.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text

                        fm_delete_option.sell_menu_id = _i(li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text)
                        fm_delete_option.tb_item_name.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(2).Text
                        fm_delete_option.tb_item_price.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text
                        fm_delete_option.Show()
                    Else

                        If li_sell_menu_item.SelectedItems.Item(0).SubItems(17).Text = "هدية" Then
                            If MessageBox.Show("هل تريد حذفها ؟", "هذه المادة اعطيت هدية", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

                                'you can delete it
                                fm_delete_option.tb_item_id.Text = li_sell_menu_item.SelectedItems.Item(0).Text
                                fm_delete_option.tb_sell_menu_id.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text

                                fm_delete_option.sell_menu_id = _i(li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text)
                                fm_delete_option.tb_item_name.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(2).Text
                                fm_delete_option.tb_item_price.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text
                                fm_delete_option.Show()

                            End If
                        Else
                            fm_back_option.tb_id.Text = li_sell_menu_item.SelectedItems.Item(0).Text
                            fm_back_option.tb_item_id.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(11).Text
                            fm_back_option.tb_count.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(4).Text
                            fm_back_option.tb_cost.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(12).Text
                            fm_back_option.tb_size_color.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(10).Text
                            fm_back_option.tb_sell_menu_id.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text
                            fm_back_option.tb_item_name.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(2).Text
                            fm_back_option.tb_item_price.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text
                            fm_back_option.Show()
                        End If

                    End If
                End If


            Else
                If MessageBox.Show("هل تريد عرض قائمتها؟", "تم استرجاع المادة مسبقا", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then


                    tb_menu_id.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(9).Text
                    Dim d As New DataSet
                    Dim id As Integer
                    id = Convert.ToInt32(tb_menu_id.Text)
                    tb_status.EditValue = 1
                    Dim sell_menu_item As New sell_menu_item
                    sell_menu_item.sell_menu_id = id
                    d = sell_menu_item.get_menu_items()
                    fill_li_menu_item(d)

                End If

            End If


            'If _i(li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text) < 1 Then

            '    If MessageBox.Show("هل تريد كانت خطوة خاطئة أحذفها من القائمة  ", "هذه المادة تم استرجاعها", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            '        'you can delete it
            '        fm_delete_option.tb_item_id.Text = li_sell_menu_item.SelectedItems.Item(0).Text
            '        fm_delete_option.sell_menu_id = _i(li_sell_menu_item.SelectedItems.Item(0).SubItems(1).Text)
            '        fm_delete_option.tb_item_name.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(2).Text

            '        fm_delete_option.tb_item_price.Text = li_sell_menu_item.SelectedItems.Item(0).SubItems(3).Text

            '        fm_delete_option.Show()
            '        Exit Sub
            '    Else
            '        Exit Sub
            '    End If
            'End If



        End If
    End Sub

  

    Private Sub fm_sell_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            fm_customer_search.Close()
        Catch ex As Exception

        End Try
        If (back_path = "0") Then

        ElseIf (back_path = "cu") Then
            fm_customer.Show()

        Else


            fm_main.Show()

        End If

    End Sub

    Private Sub fm_sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue")
        r_customer_id.Checked = True
        list_format()
        tb_search.Focus()
        tb_search.SelectAll()
        li_user.Hide()
        get_all()
        Me.Text = "الكاشير"
        SimpleButton4.Text = "الكاشير : " & user.name

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

    Public Sub get_all()
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

    Private Sub list_format()
        li_user.View = View.Details
        li_user.Columns.Add("ت", 0)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 200)
        li_user.Columns.Add("نوع الحساب", 120)
        li_user.Columns.Add("حالة المستخدم", 200)
        li_user.Columns.Add("حقل2", 200)
        li_user.Columns.Add("حقل3", 200)
        li_user.Columns.Add("حقل4", 200)


        'list
        li_sell_menu_item.View = View.Details
        li_sell_menu_item.Columns.Add("ت", 0)
        li_sell_menu_item.Columns.Add("رقم القائمة", 75)
        li_sell_menu_item.Columns.Add("اسم المادة", 200)
        li_sell_menu_item.Columns.Add("السعر", 80)
        li_sell_menu_item.Columns.Add("العدد", 50)
        li_sell_menu_item.Columns.Add("البائع", 160)
        li_sell_menu_item.Columns.Add("التاريخ", 200)
        li_sell_menu_item.Columns.Add("الحالة", 200)
        li_sell_menu_item.Columns.Add("استرجع", 200)
        li_sell_menu_item.Columns.Add("قائمة الاسترجاع", 200)
        li_sell_menu_item.Columns.Add("قياس و لون", 200)
        li_sell_menu_item.Columns.Add("رقم المادة", 200)
        li_sell_menu_item.Columns.Add("التكلفة", 5)
        li_sell_menu_item.Columns.Add("f5", 5)
        li_sell_menu_item.Columns.Add("f6", 5)
        li_sell_menu_item.Columns.Add("f7", 5)
        li_sell_menu_item.Columns.Add("f8", 5)
        li_sell_menu_item.Columns.Add("gift", 100)

        'list
        li_sell_menu.View = View.Details
        li_sell_menu.Columns.Add("ت", 0)
        li_sell_menu.Columns.Add("التاريخ", 0)
        li_sell_menu.Columns.Add("الوقت", 0)
        li_sell_menu.Columns.Add("الحالة", 0)
        li_sell_menu.Columns.Add("نوع القائمة", 100)
        li_sell_menu.Columns.Add("اسم الزبون", 180)
        li_sell_menu.Columns.Add("العملية", 180)
        li_sell_menu.Columns.Add("تفاصيل", 180)
        li_sell_menu.Columns.Add("رقم الكاشير", 180)
    
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

        search()

    End Sub

    Public Sub search()
        Try
            clear_values()
            If tb_search.Text.Trim = "" Then
                Exit Sub
            End If


            If r_sell_menu_id.Checked = True Then



                menu_search(Convert.ToInt32(tb_search.Text.Trim))
                If tb_customer_id.Text.Trim <> "" Then
                    customer_search(Convert.ToInt32(tb_customer_id.Text))
                End If

            ElseIf r_customer_id.Checked = True Then
                'main fun
                customer_search(Convert.ToInt32(tb_search.Text.Trim))

                put_last_menu()
            End If

            If (tb_customer_id.Text.Trim <> "") Then
                get_customer_info(Convert.ToInt32(tb_customer_id.Text.Trim))
            End If
            tb_search.Text = ""
            tb_search.Focus()
            Beep()
        Catch ex As Exception
            tb_search.Text = ""

        End Try


    End Sub

    Public Sub menu_search(sell_menu_id As Integer)
1:
        Try
            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = sell_menu_id
            Dim d As New DataSet
            d = sell_menu_item.get_menu_items()
            fill_li_menu_item(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub menu_search_after_union(sell_menu_id As Integer)
1:
        Try
            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = sell_menu_id
            Dim d As New DataSet
            d = sell_menu_item.get_menu_items()
            fill_li_menu_item_after_union(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub customer_search(customer_id As Integer)
        Try
            Dim sell_menu As New sell_menu
            sell_menu.customer_id = customer_id
            Dim d As New DataSet

            d = sell_menu.get_customer_menus()
            fill_li_menu(d)
            If d.Tables(0).Rows.Count >= 0 Then
                Dim c As New Customer(customer_id)
                If c.id = 0 Then
                    tb_customer_name.Text = ""
                    tb_customer_note.Text = ""
                    tb_customer_type.Text = ""
                    tb_customer_id.Text = ""

                Else
                    tb_customer_name.Text = c.name.ToString
                    tb_customer_note.Text = c.note
                    tb_customer_type.Text = c.type.ToString
                    tb_customer_id.Text = c.id.ToString


                End If

            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub lastSellMenu(count As Integer)
        Try
            Dim sell_menu As New sell_menu
            Dim d As New DataSet
            d = sell_menu.get_customer_menus()
            fill_li_menu(d)

        Catch ex As Exception

        End Try


    End Sub

    Public Sub fill_li_menu_item(d As DataSet)
        sett_button_text()

1:
        Try

            Dim count As Integer = 0
            Dim total_price As Integer = 0
            Dim discount As Integer = 0
            Dim final_price As Integer = 0
            Dim customer_id As Integer = 0
            Dim customer_type As Integer = 0
            Dim count2 As Integer = 0

            li_sell_menu_item.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_sell_menu_item.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("sell_menu_id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_name").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_price").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_count").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("username").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("datetime").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    tb_f1.Text = d.Tables(0).Rows(i).Item("f1").ToString
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_id").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_cost").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f5").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f6").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f7").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f8").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("gift").ToString)
                    If d.Tables(0).Rows(i).Item("f2").ToString = "نعم" Then
                        li_sell_menu_item.Items(i).BackColor = Color.LightPink
                    ElseIf _i(d.Tables(0).Rows(i).Item("item_price").ToString) > discount_price Then
                        li_sell_menu_item.Items(i).BackColor = Color.LightGreen
                    End If

                    If d.Tables(0).Rows(i).Item("gift").ToString = "هدية" Then
                        li_sell_menu_item.Items(i).BackColor = Color.Yellow
                    End If

                    If _i(d.Tables(0).Rows(i).Item("item_price").ToString) > 0 Then
                        count = count + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                        'Else
                        '    count = count - Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)

                    End If
                    total_price = total_price + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_price").ToString) * Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                    tb_menu_id.Text = d.Tables(0).Rows(i).Item("sell_menu_id").ToString
                    customer_id = Convert.ToInt32(d.Tables(0).Rows(i).Item("cu_id").ToString)
                    If _i(d.Tables(0).Rows(i).Item("item_price").ToString) >= discount_price Then

                        count2 = count2 + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                        'ElseIf _i(d.Tables(0).Rows(i).Item("item_price").ToString) <= -1 * discount_price Then
                        '    count2 = count2 - Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)

                    End If
                    discount = Convert.ToInt32(d.Tables(0).Rows(i).Item("discount").ToString)
                    tb_status.Text = d.Tables(0).Rows(i).Item("status").ToString


                Next

                tb_count2.Text = count2.ToString

                tb_count.Text = count.ToString
                tb_total_price.EditValue = total_price

                If tb_status.Text.Trim = "0" Then
                    discount = get_discount(count2)
                    tb_discount.EditValue = discount
                Else
                    tb_discount.EditValue = discount
                End If
                sett_button_text()

                final_price = total_price - discount
                tb_final_price.EditValue = final_price
                send_tosecreen(tb_final_price.Text)

                tb_customer_id.Text = customer_id.ToString
                get_customer_info(customer_id)

                Dim sell_menu_id As Integer = __(li_sell_menu_item.Items(0).SubItems(1).Text)
                If from_card() Then
                    unin_menus(sell_menu_id)
                    menu_search_after_union(sell_menu_id)

                Else
             
                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub fill_li_menu_item_after_union(d As DataSet)
        sett_button_text()

1:
        Try

            Dim count As Integer = 0
            Dim total_price As Integer = 0
            Dim discount As Integer = 0
            Dim final_price As Integer = 0
            Dim customer_id As Integer = 0
            Dim customer_type As Integer = 0
            Dim count2 As Integer = 0

            li_sell_menu_item.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_sell_menu_item.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("sell_menu_id").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_name").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_price").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_count").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("username").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("datetime").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_id").ToString)

                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("item_cost").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f5").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f6").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f7").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f8").ToString)
                    li_sell_menu_item.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("gift").ToString)
                    If d.Tables(0).Rows(i).Item("f2").ToString = "نعم" Then
                        li_sell_menu_item.Items(i).BackColor = Color.LightPink
                    ElseIf _i(d.Tables(0).Rows(i).Item("item_price").ToString) > discount_price Then
                        li_sell_menu_item.Items(i).BackColor = Color.LightGreen
                    End If

                    If d.Tables(0).Rows(i).Item("gift").ToString = "هدية" Then
                        li_sell_menu_item.Items(i).BackColor = Color.Yellow
                    End If

                    If _i(d.Tables(0).Rows(i).Item("item_price").ToString) > 0 Then
                        count = count + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                        'Else
                        '    count = count - Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)

                    End If
                    total_price = total_price + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_price").ToString) * Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                    tb_menu_id.Text = d.Tables(0).Rows(i).Item("sell_menu_id").ToString
                    customer_id = Convert.ToInt32(d.Tables(0).Rows(i).Item("cu_id").ToString)
                    If _i(d.Tables(0).Rows(i).Item("item_price").ToString) >= discount_price Then

                        count2 = count2 + Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)
                        'ElseIf _i(d.Tables(0).Rows(i).Item("item_price").ToString) <= -1 * discount_price Then
                        '    count2 = count2 - Convert.ToInt32(d.Tables(0).Rows(i).Item("item_count").ToString)

                    End If
                    discount = Convert.ToInt32(d.Tables(0).Rows(i).Item("discount").ToString)
                    tb_status.Text = d.Tables(0).Rows(i).Item("status").ToString


                Next

                tb_count2.Text = count2.ToString

                tb_count.Text = count.ToString
                tb_total_price.EditValue = total_price

                If tb_status.Text.Trim = "0" Then
                    discount = get_discount(count2)
                    tb_discount.EditValue = discount
                Else
                    tb_discount.EditValue = discount
                End If
                sett_button_text()

                final_price = total_price - discount
                tb_final_price.EditValue = final_price
                send_tosecreen(tb_final_price.Text)

                tb_customer_id.Text = customer_id.ToString
                get_customer_info(customer_id)

                'Dim sell_menu_id As Integer = __(li_sell_menu_item.Items(0).SubItems(1).Text)
              
                'menu_search(sell_menu_id)

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub




    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
        If e.KeyCode = Keys.Enter Then
            search()

        End If
    End Sub

    Private Sub clear_values()
        tb_menu_id.EditValue = 0
        ch_user_pull.Checked = False
        tb_user_pull_id.Text = "0"

        tb_count.Text = "0"
        tb_count2.Text = "0"
        tb_total_price.Text = "0"
        tb_discount.Text = "0"
        tb_final_price.Text = "0"
        tb_status.Text = ""
        tb_customer_id.Text = ""
        tb_customer_name.Text = ""
        tb_customer_note.Text = ""
        tb_customer_type.Text = ""
        li_sell_menu_item.Items.Clear()
        li_sell_menu.Items.Clear()

    End Sub

    Public Function get_discount(count As Integer) As Integer
        If count = 1 Then
            Return 0
        ElseIf count = 2 Then

            Return 5000
        ElseIf count = 3 Then
            Return 10000
        ElseIf count = 4 Then
            Return 10000
        ElseIf count = 5 Then
            Return 15000
        ElseIf count = 6 Then
            Return 20000
        ElseIf count = 7 Then
            Return 20000
        ElseIf count = 8 Then
            Return 25000
        ElseIf count = 9 Then
            Return 30000
        ElseIf count = 10 Then
            Return 30000
        ElseIf count = 11 Then
            Return 35000
        ElseIf count = 14 Then
            Return 60000
        ElseIf count = 15 Then
            Return 65000
        ElseIf count = 16 Then
            Return 60000
        ElseIf count = 17 Then
            Return 70000
        ElseIf count = 18 Then
            Return 75000
        Else
            Return 0

        End If
    End Function

    Private Sub tb_discount_EditValueChanged(sender As Object, e As EventArgs) Handles tb_discount.EditValueChanged
    
    End Sub

    Private Sub tb_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_discount.KeyUp

        cal_dicount()

    End Sub
    Public Sub put_message(message As String, name As String)
        'Dim d As New DateTimePicker


        'Try

        '    l_meesage.Text = d.Value.ToShortTimeString + "  " + message + " ( " + name + " ) " + vbNewLine + l_meesage.Text

        'Catch ex As Exception
        '    l_meesage.Text = d.Value.ToShortTimeString + "  " + message + " ( " + name + " ) "
        'End Try

    End Sub
    Private Sub finish(sell_menu_id As Integer)


1:
        Try

            Dim sell_menu As New sell_menu
            sell_menu.id = sell_menu_id
            If sell_menu.id = 0 Then
                Exit Sub
            End If

            Dim item As New Item
            item.count_decrease(li_sell_menu_item)
            sell_menu.user_finshed_id = user.id
            sell_menu.datevalue = Date.Now.ToShortDateString
            sell_menu.timevalue = Date.Now.ToLongTimeString
            sell_menu.status = 1
            sell_menu.f2 = tb_customer_name.Text
             If ch_user_pull.Checked = True Then
                sell_menu.f1 = not_chash
                sell_menu.f3 = user_pull_it
                sell_menu.f4 = tb_user_pull_id.Text
            ElseIf ch_daen_zabon.Checked = True Then
                sell_menu.f1 = not_chash
                sell_menu.f3 = s_dean_zabon
                sell_menu.f4 = tb_user_pull_id.Text



            ElseIf ch_tawsel.Checked = True Then
                sell_menu.f1 = not_chash
                sell_menu.f3 = s_tawsel
                sell_menu.f4 = tb_user_pull_id.Text



            Else

                sell_menu.f1 = tb_f1.Text

            End If
            sell_menu.discount = Convert.ToInt32(tb_discount.EditValue.ToString)
            sell_menu.save()
            put_message(" بيع قائمة " & menu_state, tb_menu_id.EditValue.ToString)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try




    End Sub
    Private Sub update_discount(sell_menu_id As Integer)


1:
        Try

            Dim sell_menu As New sell_menu
            sell_menu.id = sell_menu_id
            If sell_menu.id = 0 Then
                Exit Sub
            End If


            sell_menu.user_finshed_id = user.id
            sell_menu.datevalue = Date.Now.ToShortDateString
            sell_menu.timevalue = Date.Now.ToLongTimeString
            sell_menu.status = 1
            sell_menu.f1 = tb_f1.Text
            sell_menu.discount = Convert.ToInt32(tb_discount.EditValue.ToString)
            sell_menu.save()
            put_message(" اعادة طباعة قائمة ", tb_menu_id.EditValue.ToString)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try




    End Sub
    Private Sub fill_li_menu(d As DataSet)
        sett_button_text()

        Dim dt As New DateTimePicker
        Dim dt2 As New DateTimePicker

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


                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("status").ToString)



                    tb_customer_id.Text = d.Tables(0).Rows(i).Item("customer_id").ToString
                    If d.Tables(0).Rows(i).Item("f1").ToString = "بيع" Or d.Tables(0).Rows(i).Item("f1").ToString = "قائمة بيع" Then
                        li_sell_menu.Items(i).BackColor = Color.LightGreen
                    ElseIf d.Tables(0).Rows(i).Item("f1").ToString = "استرجاع" Then
                        li_sell_menu.Items(i).BackColor = Color.LightPink
                    ElseIf d.Tables(0).Rows(i).Item("f1").ToString = "تم دمجها" Then
                        li_sell_menu.Items(i).BackColor = Color.Blue
                    Else
                        li_sell_menu.Items(i).BackColor = Color.White
                    End If
                    If d.Tables(0).Rows(i).Item("f1").ToString = not_chash Then

                        li_sell_menu.Items(i).BackColor = Color.Yellow

                    End If

                    If d.Tables(0).Rows(i).Item("status").ToString = "0" Then
                        li_sell_menu.Items(i).BackColor = Color.White
                    End If
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    Try
                        li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("name").ToString)
                    Catch ex As Exception
                        li_sell_menu.Items(i).SubItems.Add("زبون")

                    End Try

                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)

                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    li_sell_menu.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_finshed_id").ToString)

                Next
                If li_sell_menu.Items.Count > 0 Then
                    tb_menu_id.Text = li_sell_menu.Items(0).Text
                    tb_status.Text = li_sell_menu.Items(0).SubItems(3).Text
                    sett_button_text()
                Else
                    tb_menu_id.Text = ""
                    tb_status.Text = "0"
                    sett_button_text()
                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub li_sell_menu_DoubleClick(sender As Object, e As EventArgs) Handles li_sell_menu.DoubleClick

    End Sub


    Private Sub li_sell_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_sell_menu.SelectedIndexChanged
        clear_radio_checked()

        r_sell_menu_id.Checked = True

        get_selected_menu()

      
    End Sub

    Private Sub get_customer_info(customer_id As Integer)
1:
        Try
            Dim customer As New Customer(customer_id)
            tb_customer_id.Text = customer.id.ToString
            tb_customer_name.Text = customer.name
            tb_customer_note.Text = customer.note
            tb_customer_type.Text = customer.type.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub put_last_menu()
        If (li_sell_menu.Items.Count > 0) Then
            Dim id As Integer
            id = Convert.ToInt32(li_sell_menu.Items(0).SubItems(0).Text)


            Dim d As New DataSet

            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = id
            If r_customer_id.Checked Then
                d = sell_menu_item.get_menu_items_card(__(tb_search.Text))
            Else
                d = sell_menu_item.get_menu_items()
            End If

            fill_li_menu_item(d)
           ' menu_search(id)
        End If
    End Sub

    Private Sub print_menu(id As Integer)

        Try

        Catch ex As Exception

        End Try
1:
        Try
            Dim fm = New fm_print_menu
            Dim sell_menu As New sell_menu_item

            sell_menu.sell_menu_id = id
            fm.total_price = _i(tb_total_price.Text.Trim)
            fm.final_price = _i(tb_final_price.Text.Trim)
            fm.menu_id = _i(tb_menu_id.Text.Trim)
            fm.menu_type = menu_state
            fm.count = _i(tb_count.Text.Trim)
            fm.ds = sell_menu.get_for_print()
            If (tb_status.Text = "0") Then
                fm.casher_name = "الكاشير :" & user.name

            Else
                fm.casher_name = "اعادة طباعة الكاشير :" & user.name
            End If
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub tb_status_EditValueChanged(sender As Object, e As EventArgs) Handles tb_status.EditValueChanged

    End Sub

    Public Sub sett_button_text()
        If tb_status.Text.Trim = "0" Then
            btn_finish.Text = "أتمام وطباعة"
            tb_discount.ReadOnly = False
            btn_delete.Text = s_btn_delete
         
        Else
            btn_finish.Text = "طباعة"
            tb_discount.ReadOnly = True
            btn_delete.Text = s_btn_back

        End If
        If tb_f1.Text = not_chash Then
            btn_recive_not_chash.Show()

        Else
            btn_recive_not_chash.Hide()

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_add_new.Click
        Dim fm_add_item As New fm_add_item
        fm_add_item.tb_sell_menu_id.Text = tb_menu_id.Text
     

        fm_add_item.Show()
        tb_status.Text = "0"
        tb_discount.ReadOnly = False

    End Sub

    Public Sub add_new_item(sell_menu_item As sell_menu_item)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If group_users.Visible = True Then
            group_users.Visible = False
        Else
            group_users.Visible = True


        End If
        'If tb_customer_id.Text.Trim <> "" Then
        '    Dim fm_customer_info As New fm_customer_info

        '    fm_customer_info.tb_customer_id.Text = tb_customer_id.Text
        '    fm_customer_info.tb_customer_name.Text = tb_customer_name.Text
        '    fm_customer_info.Show()

        'End If



    End Sub

    Private Sub GroupControl6_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl6.Paint

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        add_new_customer()
        tb_f1.Text = "بيع"
    End Sub

    Private Sub add_new_customer()
        Dim customer As New Customer
        customer.save_new()
        If customer.id = 0 Then
            MsgBox("حدث خطأ")
            Exit Sub
        End If
        add_new_menu(customer.id)



    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            Dim sell_menu As New sell_menu
            Dim d As New DataSet
            d = sell_menu.get_last_menus(num_limit.Value)
            fill_li_menu(d)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupControl4_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl4.Paint

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        PrintVisitorCard()
        group_users.Visible = False
    End Sub

    Private Sub PrintVisitorCard()
        Try
            Dim fm = New fm_visitor_card
            Dim customer As New Customer
            customer.id = _i(tb_customer_id.Text)
            fm.ds = customer.get_for_print()

            fm.Show()

        Catch ex As Exception

        End Try
    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If tb_customer_id.Text.Trim <> "" And tb_customer_id.Text.Trim <> "0" Then
            add_new_menu(_i(tb_customer_id.Text))

        End If

    End Sub

    Public Sub add_new_menu(id As Integer)
        'add new menu to customer_id

        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        sell_menu.customer_id = id
        sell_menu.discount = 0
        sell_menu.f1 = s_sell
        tb_f1.Text = s_sell
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 0
        sell_menu.user_finshed_id = 0
        sell_menu.save()
        menu_state = "قائمة بيع "
        tb_search.Text = id.ToString
        r_customer_id.Checked = True
        search()
        fm_add_item.tb_sell_menu_id.Text = li_sell_menu.Items(0).Text
        fm_add_item.Show()
        tb_status.Text = "0"
        sett_button_text()

    End Sub


    Private Sub r_customer_id_CheckedChanged(sender As Object, e As EventArgs) Handles r_customer_id.CheckedChanged
        tb_search.Focus()

        If r_customer_id.Checked = True Then
            btn_customer_select.BackColor = Color.LightGreen
            btn_menu_selcet.BackColor = Color.White
        Else
            r_sell_menu_id.Checked = True
            btn_customer_select.BackColor = Color.White
            btn_menu_selcet.BackColor = Color.LightGreen
            tb_search.Focus()
        End If
    End Sub

    Private Sub r_sell_menu_id_CheckedChanged(sender As Object, e As EventArgs) Handles r_sell_menu_id.CheckedChanged
        tb_search.Focus()

        If r_customer_id.Checked = True Then
            btn_customer_select.BackColor = Color.LightGreen
            btn_menu_selcet.BackColor = Color.White
        Else
            r_sell_menu_id.Checked = True
            btn_customer_select.BackColor = Color.White
            btn_menu_selcet.BackColor = Color.LightGreen
            tb_search.Focus()
        End If
    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        If li_sell_menu_item.Items.Count <= 0 Then
            MessageBox.Show("لا يمكن اتمام قائمة فارغه")
            Exit Sub
        End If

        Dim sell_menu_id As Integer = Convert.ToInt32(tb_menu_id.EditValue.ToString)

        If from_card() Then
            unin_menus(sell_menu_id)
        End If
        If (tb_status.Text = "0") Then
            If ch_user_pull.Checked = True Then
                menu_state = user_pull_it

            ElseIf ch_daen_zabon.Checked = True Then
                menu_state = s_dean_zabon

            ElseIf ch_tawsel.Checked = True Then
                menu_state = s_tawsel
            Else
                menu_state = ""

            End If
            finish(sell_menu_id)


            print_menu(sell_menu_id)

        Else
            menu_state = "اعادة طباعة"
            update_discount(sell_menu_id)
            print_menu(sell_menu_id)
        End If

        'If ch_user_pull.Checked = True Then
        '    fm_pull_money.f2 = sell_menu_id.ToString
        '    fm_pull_money.tb_note.Text = "شراء قائمة"
        '    fm_pull_money.tb_amount.Text = tb_final_price.Text
        '    fm_pull_money.tb_note.ReadOnly = True
        '    fm_pull_money.tb_amount.ReadOnly = True

        '    fm_pull_money.Show()

        'End If


        clear_radio_checked()
        clear_values()
        tb_search.Focus()
    End Sub

    Private Sub btn_add_new_GotFocus(sender As Object, e As EventArgs) Handles btn_add_new.GotFocus


    End Sub

    Private Sub send_tosecreen(price As String)
        Try
            Dim Sp As New SerialPort

            Sp = New SerialPort
            Sp.PortName = "COM5"
            Sp.BaudRate = 9600
            Sp.Parity = Parity.None
            Sp.DataBits = 8
            Sp.StopBits = StopBits.One
            Sp.Open()
            Sp.WriteLine("                                             ")
            Sp.WriteLine(price)
            Sp.Close()
            Sp.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub r_sell_menu_id_Click(sender As Object, e As EventArgs) Handles r_sell_menu_id.Click
        tb_search.Focus()

    End Sub

    Private Sub r_customer_id_Click(sender As Object, e As EventArgs) Handles r_customer_id.Click

        tb_search.Focus()
      
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Me.Hide()

        fm_user_rest.Show()
        group_users.Visible = False
    End Sub

    Private Sub tb_customer_id_EditValueChanged(sender As Object, e As EventArgs) Handles tb_customer_id.EditValueChanged

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
  
    End Sub

    Private Function from_card() As Boolean
        If li_sell_menu_item.Items.Count <= 0 Then
            Return False
        End If
        Dim menu_id = li_sell_menu_item.Items(0).SubItems(1).Text
        For i = 0 To li_sell_menu_item.Items.Count - 1
            If menu_id <> li_sell_menu_item.Items(i).SubItems(1).Text Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub unin_menus(sell_menu_id As Integer)
        If li_sell_menu_item.Items.Count <= 0 Then
            Exit Sub
        End If

        For i = 0 To li_sell_menu_item.Items.Count - 1
            Dim menu_item As New sell_menu_item(__(li_sell_menu_item.Items(i).Text))
            menu_item.sell_menu_id = sell_menu_id
            menu_item.save()
            Dim menu As New sell_menu(__(li_sell_menu_item.Items(i).SubItems(1).Text))
            If menu.id <> sell_menu_id Then
                menu.delete()
            End If


        Next

    End Sub

    Private Sub get_selected_menu()
        If li_sell_menu.SelectedItems.Count > 0 Then
            tb_menu_id.EditValue = 0

            tb_count.Text = "0"
            tb_count2.Text = "0"
            tb_total_price.Text = "0"
            tb_discount.Text = "0"
            tb_final_price.Text = "0"
            tb_status.Text = ""
            tb_customer_name.Text = ""
            tb_customer_note.Text = ""
            tb_customer_type.Text = ""

            tb_menu_id.Text = li_sell_menu.SelectedItems.Item(0).SubItems(0).Text
            tb_f1.Text = li_sell_menu.SelectedItems.Item(0).SubItems(4).Text
            Dim d As New DataSet
            Dim id As Integer
            id = Convert.ToInt32(li_sell_menu.SelectedItems.Item(0).SubItems(0).Text)
            tb_status.EditValue = Convert.ToInt32(li_sell_menu.SelectedItems.Item(0).SubItems(3).Text)

            Dim sell_menu_item As New sell_menu_item
            sell_menu_item.sell_menu_id = id
            If r_customer_id.Checked Then
                d = sell_menu_item.get_menu_items_card(__(tb_customer_id.Text))
            Else
                d = sell_menu_item.get_menu_items()
            End If

            tb_customer_id.Text = "0"

            fill_li_menu_item(d)
           
        End If
    End Sub

    Private Sub r_view_only_menu_CheckedChanged(sender As Object, e As EventArgs)
        '  get_last_menu()

    End Sub

    Private Sub r_view_all_menus_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)
        fm_pull_money.Show()

    End Sub

    Private Sub r_view_all_menus_Click(sender As Object, e As EventArgs)
        tb_search.Focus()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        Dim customer As New Customer
        customer.id = _i(tb_customer_id.Text)
        customer.name = tb_customer_name.Text
        customer.note = tb_customer_note.Text
        customer.update()
        tb_customer_name.ForeColor = Color.Green

    End Sub

    Private Sub tb_customer_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_customer_name.EditValueChanged
        tb_customer_name.ForeColor = Color.Black


    End Sub

    Private Sub li_sell_menu_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_sell_menu_item.SelectedIndexChanged
        If li_sell_menu_item.SelectedItems.Count > 0 Then
            li_sell_menu_item.Items.Item(li_sell_menu_item.SelectedIndices(0)).BackColor = Color.Black
            li_sell_menu_item.Items.Item(li_sell_menu_item.SelectedIndices(0)).ForeColor = Color.White
        End If
    End Sub

    Private Sub ch_user_pull_CheckedChanged(sender As Object, e As EventArgs) Handles ch_user_pull.CheckedChanged

        If ch_user_pull.Checked = True Then
            ch_tawsel.Checked = False
            ch_daen_zabon.Checked = False

            li_user.Show()
            btn_finish.Text = "سحب عامل"
            SimpleButton10.Hide()
            l_customer_name.Hide()
            LabelControl2.Hide()

        Else
            li_user.Hide()
            btn_finish.Text = "أتمام وطباعة"
            SimpleButton10.Show()
            l_customer_name.Show()
            LabelControl2.Show()


        End If
       
    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged

        If (li_user.SelectedItems.Count > 0) Then

            If tb_customer_id.Text.Trim = "" Then
                add_new_customer()
                ch_user_pull.Checked = True

                li_user.Hide()
                tb_f1.Text = not_chash

                tb_customer_name.Text = "العامل : " + li_user.SelectedItems.Item(0).SubItems(1).Text

                Dim customer As New Customer
                customer.id = _i(tb_customer_id.Text)
                customer.name = tb_customer_name.Text
                customer.update()
                tb_customer_name.ForeColor = Color.Green
                tb_user_pull_id.Text = li_user.SelectedItems.Item(0).Text
            Else
                ch_user_pull.Checked = True

                li_user.Hide()
                tb_f1.Text = not_chash

                tb_customer_name.Text = "العامل : " + li_user.SelectedItems.Item(0).SubItems(1).Text

                Dim customer As New Customer
                customer.id = _i(tb_customer_id.Text)
                customer.name = tb_customer_name.Text
                customer.update()
                tb_customer_name.ForeColor = Color.Green
                tb_user_pull_id.Text = li_user.SelectedItems.Item(0).Text
            End If


        End If

    End Sub

  

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        fm_customer_search.Show()

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If tb_f1.Text.Trim = s_back Then
            MessageBox.Show("لا يمكن استرجاع القائمة المسترجعة")
            Exit Sub

        End If
        If tb_f1.Text.Trim = not_chash Then
            MessageBox.Show("لا يمكن استرجاع القائمة الغير مسددة")
            Exit Sub

        End If
        If (tb_status.Text = "0") Then
            If tb_menu_id.Text.Trim <> "" And tb_menu_id.Text <> "0" Then
                If MessageBox.Show("هل انت متأكد من الحذف ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    Dim m As New sell_menu(__(tb_menu_id.Text))
                    m.delete()
                    r_customer_id.Checked = True
                    tb_search.Text = tb_customer_id.Text
                    search()

                End If
            End If
        Else
            If MessageBox.Show("استرجاع جميع مواد هذه القائمة ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                reback()

            End If


        End If

    End Sub
    Private Sub reback()
        Dim basic_menu_id = tb_menu_id.Text

        'add new menu to customer_id
        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        Dim li_sell_menu_item2 As New ListView
        li_sell_menu_item2.View = View.Details

        li_sell_menu_item2.Columns.Add("ت", 0)
        li_sell_menu_item2.Columns.Add("رقم القائمة", 75)
        li_sell_menu_item2.Columns.Add("اسم المادة", 200)
        li_sell_menu_item2.Columns.Add("السعر", 80)
        li_sell_menu_item2.Columns.Add("العدد", 50)
        li_sell_menu_item2.Columns.Add("البائع", 160)
        li_sell_menu_item2.Columns.Add("التاريخ", 200)
        li_sell_menu_item2.Columns.Add("الحالة", 200)
        li_sell_menu_item2.Columns.Add("استرجع", 200)
        li_sell_menu_item2.Columns.Add("قائمة الاسترجاع", 200)
        li_sell_menu_item2.Columns.Add("قياس و لون", 200)
        li_sell_menu_item2.Columns.Add("رقم المادة", 200)
        li_sell_menu_item2.Columns.Add("التكلفة", 5)
        li_sell_menu_item2.Columns.Add("f5", 5)
        li_sell_menu_item2.Columns.Add("f6", 5)
        li_sell_menu_item2.Columns.Add("f7", 5)
        li_sell_menu_item2.Columns.Add("f8", 5)
        li_sell_menu_item2.Columns.Add("gift", 100)

        For i = 0 To li_sell_menu_item.Items.Count - 1
            li_sell_menu_item2.Items().Add(li_sell_menu_item.Items(i).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(1).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(2).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(3).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(4).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(5).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(6).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(7).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(8).Text)
            If li_sell_menu_item.Items(i).SubItems(8).Text = "نعم" Then
                MessageBox.Show("لايمكن استرجاع القائمة التي تحتوي على مسترجع")
                Exit Sub
            End If
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(9).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(10).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(11).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(12).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(13).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(14).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(15).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(16).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(17).Text)


        Next i
        'If (li_sell_menu_item.SelectedItems.Count > 0) Then
        '    For Each item2c As ListViewItem In li_sell_menu_item2.SelectedItems
        '        'li_sell_menu_item2.Items.Add(item2c.Clone)
        '    Next
        'End If




        sell_menu.customer_id = _i(tb_customer_id.Text.Trim)
        'If (fm_back_option.get_discount_number()) Then
        '    sell_menu.discount = -1 * discount_amount
        'Else
        '    sell_menu.discount = 0
        'End If
        sell_menu.discount = __(tb_discount.Text) * -1

        sell_menu.f1 = "استرجاع"
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 1
        sell_menu.user_finshed_id = user.id
        sell_menu.save()
        tb_search.Text = tb_customer_id.Text.Trim
        r_customer_id.Checked = True
        search()
        tb_menu_id.Text = tb_menu_id.Text
        menu_state = "قائمة استرجاع - اعادة طباعة"
        sett_button_text()

        Dim tb_id, tb_item_id, tb_size_color, tb_cost, tb_item_count, tb_item_price, tb_item_name As String
1:
        Try
            For i = 0 To li_sell_menu_item2.Items.Count - 1
                Dim itemback As New Item
                tb_id = li_sell_menu_item2.Items(i).Text
                tb_size_color = li_sell_menu_item2.Items(i).SubItems(10).Text
                tb_cost = li_sell_menu_item2.Items(i).SubItems(12).Text
                tb_item_count = li_sell_menu_item2.Items(i).SubItems(4).Text
                tb_item_id = li_sell_menu_item2.Items(i).SubItems(11).Text
                tb_item_name = li_sell_menu_item2.Items(i).SubItems(2).Text
                tb_item_price = li_sell_menu_item2.Items(i).SubItems(3).Text

                itemback.count_increase(_i(tb_item_id), tb_size_color)

                Dim item As New sell_menu_item
                item.item_cost = _i(tb_cost) * -1
                item.item_count = _i(tb_item_count)
                item.item_id = _i(tb_item_id)
                item.item_name = tb_item_name
                item.item_price = _i(tb_item_price) * -1
                item.sell_menu_id = _i(li_sell_menu.Items(0).Text)
                item.datetime = Date.Now.ToString
                item.f1 = "استرجاع"
                item.f2 = "نعم"
                item.f3 = basic_menu_id
                item.f4 = "مسترجعة"
                item.user_sell_it_id = user.id
                item.save()

                Dim old_item As New sell_menu_item(_i(tb_id))
                old_item.f2 = "نعم"
                old_item.f3 = tb_menu_id.Text
                old_item.save()

                put_message(" استرجاع قائمة ", tb_item_name)
                menu_search(_i(li_sell_menu.Items(0).Text))

            Next


            btn_finish.Focus()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub استرجاعالمحددToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استرجاعالمحددToolStripMenuItem.Click
        MessageBox.Show("جار العمل على الخدمة ")
        Exit Sub






        If tb_f1.Text.Trim = s_back Then
            MessageBox.Show("لا يمكن استرجاع القائمة المسترجعة")
            Exit Sub

        End If
        If tb_f1.Text.Trim = not_chash Then
            MessageBox.Show("لا يمكن استرجاع القائمة الغير مسددة")
            Exit Sub

        End If
    
            If MessageBox.Show("استرجاع جميع مواد هذه القائمة ؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                reback_selected()

            End If

    End Sub
    Private Sub reback_selected()
        Dim basic_menu_id = tb_menu_id.Text

        'add new menu to customer_id
        Dim d As New DateTimePicker
        Dim sell_menu As New sell_menu
        Dim li_sell_menu_item2 As New ListView
        li_sell_menu_item2.View = View.Details

        li_sell_menu_item2.Columns.Add("ت", 0)
        li_sell_menu_item2.Columns.Add("رقم القائمة", 75)
        li_sell_menu_item2.Columns.Add("اسم المادة", 200)
        li_sell_menu_item2.Columns.Add("السعر", 80)
        li_sell_menu_item2.Columns.Add("العدد", 50)
        li_sell_menu_item2.Columns.Add("البائع", 160)
        li_sell_menu_item2.Columns.Add("التاريخ", 200)
        li_sell_menu_item2.Columns.Add("الحالة", 200)
        li_sell_menu_item2.Columns.Add("استرجع", 200)
        li_sell_menu_item2.Columns.Add("قائمة الاسترجاع", 200)
        li_sell_menu_item2.Columns.Add("قياس و لون", 200)
        li_sell_menu_item2.Columns.Add("رقم المادة", 200)
        li_sell_menu_item2.Columns.Add("التكلفة", 5)
        li_sell_menu_item2.Columns.Add("f5", 5)
        li_sell_menu_item2.Columns.Add("f6", 5)
        li_sell_menu_item2.Columns.Add("f7", 5)
        li_sell_menu_item2.Columns.Add("f8", 5)
        li_sell_menu_item2.Columns.Add("gift", 100)

        For i = 0 To li_sell_menu_item.SelectedItems.Count - 1
            li_sell_menu_item2.Items().Add(li_sell_menu_item.Items(i).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(1).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(2).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(3).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(4).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(5).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(6).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(7).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(8).Text)
            If li_sell_menu_item.Items(i).SubItems(8).Text = "نعم" Then
                MessageBox.Show("لايمكن استرجاع القائمة التي تحتوي على مسترجع")
                Exit Sub
            End If
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(9).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(10).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(11).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(12).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(13).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(14).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(15).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(16).Text)
            li_sell_menu_item2.Items(i).SubItems.Add(li_sell_menu_item.Items(i).SubItems(17).Text)


        Next i
    




        sell_menu.customer_id = _i(tb_customer_id.Text.Trim)
        'If (fm_back_option.get_discount_number()) Then
        '    sell_menu.discount = -1 * discount_amount
        'Else
        '    sell_menu.discount = 0
        'End If
        sell_menu.discount = __(tb_discount.Text) * -1

        sell_menu.f1 = "استرجاع"
        sell_menu.datevalue = d.Value.ToShortDateString
        sell_menu.timevalue = d.Value.ToLongTimeString
        sell_menu.status = 1
        sell_menu.user_finshed_id = user.id
        sell_menu.save()
        tb_search.Text = tb_customer_id.Text.Trim
        r_customer_id.Checked = True
        search()
        tb_menu_id.Text = tb_menu_id.Text
        menu_state = "قائمة استرجاع - اعادة طباعة"
        sett_button_text()

        Dim tb_id, tb_item_id, tb_size_color, tb_cost, tb_item_count, tb_item_price, tb_item_name As String
1:
        Try
            For i = 0 To li_sell_menu_item2.Items.Count - 1
                Dim itemback As New Item
                tb_id = li_sell_menu_item2.Items(i).Text
                tb_size_color = li_sell_menu_item2.Items(i).SubItems(10).Text
                tb_cost = li_sell_menu_item2.Items(i).SubItems(12).Text
                tb_item_count = li_sell_menu_item2.Items(i).SubItems(4).Text
                tb_item_id = li_sell_menu_item2.Items(i).SubItems(11).Text
                tb_item_name = li_sell_menu_item2.Items(i).SubItems(2).Text
                tb_item_price = li_sell_menu_item2.Items(i).SubItems(3).Text

                itemback.count_increase(_i(tb_item_id), tb_size_color)

                Dim item As New sell_menu_item
                item.item_cost = _i(tb_cost) * -1
                item.item_count = _i(tb_item_count)
                item.item_id = _i(tb_item_id)
                item.item_name = tb_item_name
                item.item_price = _i(tb_item_price) * -1
                item.sell_menu_id = _i(li_sell_menu.Items(0).Text)
                item.datetime = Date.Now.ToString
                item.f1 = "استرجاع"
                item.f2 = "نعم"
                item.f3 = basic_menu_id
                item.f4 = "مسترجعة"
                item.user_sell_it_id = user.id
                item.save()

                Dim old_item As New sell_menu_item(_i(tb_id))
                old_item.f2 = "نعم"
                old_item.f3 = tb_menu_id.Text
                old_item.save()

                put_message(" استرجاع قائمة ", tb_item_name)
                menu_search(_i(li_sell_menu.Items(0).Text))

            Next


            btn_finish.Focus()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub


    
    Private Sub btn_customer_select_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_menu_selcet_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_customer_select.Click
        r_customer_id.Checked = True
        btn_customer_select.BackColor = Color.LightGreen
        btn_menu_selcet.BackColor = Color.White
        tb_search.Focus()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_menu_selcet.Click
        r_sell_menu_id.Checked = True
        btn_customer_select.BackColor = Color.White
        btn_menu_selcet.BackColor = Color.LightGreen
        tb_search.Focus()

    End Sub

    Private Sub tb_search_Layout(sender As Object, e As LayoutEventArgs) Handles tb_search.Layout

    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        If (tb_discount.ReadOnly) Then
            MessageBox.Show("الخصم مقفل")
        Else
            tb_discount.Text = "0"
            cal_dicount()
        End If

    End Sub

    Private Sub group_users_Paint(sender As Object, e As PaintEventArgs) Handles group_users.Paint

    End Sub
    Private Sub by_secret_word()
1:

        Try


            user.secret_word = tb_secret_word.Text.Trim
            If user.isExsit() Then
             
                Login()
            Else
                MessageBox.Show("الرمز خطأ")
                tb_secret_word.BackColor = Color.LightPink
            End If
        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            Else
              
            End If
        End Try






    End Sub
    Private Sub Login()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        '  fm_sell.Show()
        Dim permission As New Permission
        permission.getAll()


        group_users.Visible = False
        SimpleButton4.Text = user.name
        fm_main.tb_user.Caption = user.name
        tb_secret_word.Text = ""


    End Sub
    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        by_secret_word()
    End Sub

    Private Sub tb_secret_word_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_secret_word.KeyUp
        If e.KeyCode = Keys.Enter Then
            by_secret_word()
        End If
    End Sub

    Private Sub tb_secret_word_TextChanged(sender As Object, e As EventArgs) Handles tb_secret_word.TextChanged
        tb_secret_word.BackColor = Color.White

    End Sub

    Private Sub cal_dicount()

1:
        Try
            'If Convert.ToInt32(tb_discount.EditValue) >= Convert.ToInt32(tb_total_price.EditValue) Then
            '    Beep()
            '    tb_discount.EditValue = 0
            '    tb_final_price.EditValue = tb_total_price.EditValue
            'Else
            '    tb_final_price.Text = (Convert.ToInt32(tb_total_price.EditValue) - Convert.ToInt32(tb_discount.EditValue)).ToString
            'End If
            tb_final_price.Text = (Convert.ToInt32(tb_total_price.EditValue) - Convert.ToInt32(tb_discount.EditValue)).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry    ", " ", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
        send_tosecreen(tb_final_price.Text)

    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs) Handles SimpleButton14.Click
        tb_search.Text = tb_customer_id.Text
        r_customer_id.Checked = True
        btn_customer_select.BackColor = Color.LightGreen
        btn_menu_selcet.BackColor = Color.White
        tb_search.Focus()
        search()

    End Sub

    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
        If tb_customer_id.Text.Trim <> "" Then
            PrintFriendCard()
        End If

    End Sub
    Private Sub PrintFriendCard()
        Try
            Dim fm = New fm_print_customer
            Dim customer As New Customer()
            customer.id = __(tb_customer_id.Text.Trim)
            fm.ds = customer.get_for_print()
            fm.Show()
          
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs) Handles SimpleButton16.Click
        PrintFriendCard()
        group_users.Visible = False
    End Sub

    Private Sub SimpleButton17_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        If hasPermission(per_pulls_show) Then
            Try
                fm_pull_money.Close()
            Catch ex As Exception

            End Try
            fm_pull_money.Show()
        Else
            MessageBox.Show("لاتمتلك صلاحية السحوبات")
        End If
        group_users.Visible = False
    End Sub

    Private Sub ch_tawsel_CheckedChanged(sender As Object, e As EventArgs) Handles ch_tawsel.CheckedChanged
        If ch_tawsel.Checked = True Then
            ch_user_pull.Checked = False
            ch_daen_zabon.Checked = False


            btn_finish.Text = "بيع توصيل"
            SimpleButton10.Show()
            l_customer_name.Show()
            LabelControl2.Show()


        Else
            li_user.Hide()
            btn_finish.Text = "أتمام وطباعة"
            SimpleButton10.Show()
            l_customer_name.Show()
            LabelControl2.Show()


        End If

    End Sub

    Private Sub ch_daen_zabon_CheckedChanged(sender As Object, e As EventArgs) Handles ch_daen_zabon.CheckedChanged
        If ch_daen_zabon.Checked = True Then
            ch_user_pull.Checked = False
            ch_tawsel.Checked = False


            btn_finish.Text = "بيع زبون اجل"
            SimpleButton10.Show()
            l_customer_name.Show()
            LabelControl2.Show()


        Else
            li_user.Hide()
            btn_finish.Text = "أتمام وطباعة"
            SimpleButton10.Show()
            l_customer_name.Show()
            LabelControl2.Show()


        End If
    End Sub

    Private Sub clear_radio_checked()
        ch_daen_zabon.Checked = False
        ch_user_pull.Checked = False
        ch_tawsel.Checked = False
    End Sub

    Private Sub SimpleButton18_Click(sender As Object, e As EventArgs) Handles SimpleButton18.Click

    End Sub
End Class