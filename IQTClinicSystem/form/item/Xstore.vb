Imports MySql.Data.MySqlClient

Partial Public Class Xstore
    Dim data_result As New DataSet

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub navBarControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs)

        search()

    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles employeesBarButtonItem.ItemClick, customersBarButtonItem.ItemClick

    End Sub

    Private Sub officeNavigationBar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

        search()

    End Sub
    Public Sub search()
1:
        Try
            Dim item As New Item
            Dim d As New DataSet
            d = item.all()
            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub name_search()


1:
        Try
            Dim item As New Item
            If cb_search_store.Text = "%" Then
                item.store_id = -1
            Else
                item.store_id = cb_search_store.SelectedIndex
            End If


            If cb_search_type.Text = "%" Then
                item.type = -1
            Else
                item.type = cb_search_type.SelectedIndex
            End If



            Dim d As New DataSet
            d = item.name_search(tb_search.Text.Trim, item, num_limit.Value)


            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub id_search()


1:
        Try
            Dim item As New Item
           



            Dim d As New DataSet
            d = item.id_search(tb_search.Text.Trim, item)


            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub get_price_search()



1:
        Try
            Dim item As New Item
            Dim d As New DataSet
            d = item.price_search(tb_search.Text.Trim, item)
            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub
    Public Sub all_search()
1:
        Try

            Dim item As New Item


            Dim d As New DataSet
            d = item.all_search()


            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub barcode_search()
1:
        Try
            Dim item As New Item

            Dim d As New DataSet
            item.barcode = tb_search.Text.Trim
            d = item.barcode_check
            fill_data(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click
      
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs)


        MessageBox.Show(" ")
    End Sub

    Private Sub Xstore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            fm_item_option.Close()

        Catch ex As Exception

        End Try
        fm_main.Show()

    End Sub

    Private Sub Xstore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formating()
        name_search()
        cost_view()
    
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        MessageBox.Show(e.ToString)
    End Sub

    Private Sub formating()
        'list
        li_item.View = View.Details
        li_item.Columns.Add("ت", 130)
        li_item.Columns.Add("باركود", 5)
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
        '   li_item.Columns.Add("الكلفة", 0)

        'combo
        Dim i = 0

        For i = 0 To store_title.Count - 1
            cb_store.Items.Add(store_title.Item(i))
        Next
        cb_store.SelectedItem = cb_store.Items(0)

        For i = 0 To type_title.Count - 1
            cb_type.Items.Add(type_title.Item(i))
        Next
        cb_type.SelectedItem = cb_type.Items(0)

        dt_last_update.EditValue = Date.Now

        'combo search
       
        For i = 0 To store_title.Count - 1
            cb_search_store.Items.Add(store_title.Item(i))
        Next
        cb_search_store.Items.Add("%")
        cb_search_store.SelectedItem = cb_search_store.Items(i)



        For i = 0 To type_title.Count - 1
            cb_search_type.Items.Add(type_title.Item(i))
         
        Next
        cb_search_type.Items.Add("%")
        cb_search_type.SelectedItem = cb_search_type.Items(i)

     
    End Sub

    Private Sub fill_data(d As DataSet)

1:
        Try
            tb_item_count.Text = "0"
            tb_picese_count.Text = "0"
            Dim dt As New DateTimePicker
            Dim c As Integer

            li_item.Items.Clear()

            t_count.Caption = d.Tables(0).Rows.Count.ToString

            If user.type = user_admin Then
                GridControl1.DataSource = d.Tables(0)

            End If

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

                    If __(d.Tables(0).Rows(i).Item("count").ToString) > 0 Then
                        tb_picese_count.Text = (__(tb_picese_count.Text) + __(d.Tables(0).Rows(i).Item("count").ToString)).ToString

                    End If

                    '   dt.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("birthdate").ToString)
                    If __(d.Tables(0).Rows(i).Item("count").ToString) <= __(tb_red.Text) Then
                        li_item.Items(i).BackColor = Color.Red

                    End If
                Next

                tb_item_count.Text = d.Tables(0).Rows.Count.ToString


            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub li_item_DoubleClick(sender As Object, e As EventArgs) Handles li_item.DoubleClick
        Try
            fm_item_option.Close()

        Catch ex As Exception

        End Try
        fm_item_option.Show()

    End Sub

    Private Sub li_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item.SelectedIndexChanged

    End Sub

    Private Sub GridControl1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub officeNavigationBar_SelectedItemChanged(sender As Object, e As DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs)




    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs)
1:

        Try
            If check_values() Then
                add()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try


    End Sub

    Private Sub add()
        Dim item As New Item
        item.id = Convert.ToInt32(tb_id.Text.Trim)
        item.name = tb_name.Text.Trim
        item.barcode = tb_barcode.Text.Trim
        item.detail = tb_detail.Text.Trim
        item.store_id = cb_store.SelectedIndex
        item.price = Convert.ToInt32(tb_price.Text.Trim)
        If (user.type = 1) Then
            item.cost = Convert.ToInt32(tb_cost.Text.Trim)
        End If
        item.place = tb_place.Text.Trim
        item.count = Convert.ToInt32(tb_count.Text.Trim)
        item.type = cb_type.SelectedIndex
        item.last_update = Date.Now.ToString
        item.f1 = tb_f1.Text.Trim
        item.f2 = tb_f2.Text.Trim
        item.f3 = tb_f3.EditValue.ToString
        item.f4 = user.name



        'فحص  اسم مسجل مسبقا - ثم تحديث بياناتها والعدد
        Dim ds_name As New DataSet
        ds_name = item.name_check()

        'فحص  باركود مسجل مسبقا - ثم تحديث بياناتها والعدد
        Dim ds_barcode As New DataSet
        ds_barcode = item.barcode_check()

        If ds_barcode.Tables(0).Rows.Count > 0 Then
            If tb_count.Text = "0" Then
                item.id = Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("id").ToString())
                item.count = item.count + Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("count").ToString())
                'item.barcode = ds_barcode.Tables(0).Rows(0).Item("barcode").ToString()
                'item.name = ds_barcode.Tables(0).Rows(0).Item("name").ToString()

                Beep()
            Else
                If MessageBox.Show(" هل تريد تحديث المعلومات واضافة الكمية  الحالية على الكمية السابقه", " هذه المادة موجوده - بواسطة الباركود", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    item.id = Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("id").ToString())
                    item.count = item.count + Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("count").ToString())
                    'item.barcode = ds_barcode.Tables(0).Rows(0).Item("barcode").ToString()
                    'item.name = ds_barcode.Tables(0).Rows(0).Item("name").ToString()

                    Beep()


                Else
                    put_message("تم الغاء الحدث", " يرجى تغيير الباركود")
                    Return

                End If
            End If

        ElseIf ds_name.Tables(0).Rows.Count > 0 Then
            If MessageBox.Show(" هل تريد تحديث المعلومات واضافة الكمية  الحالية على الكمية السابقه", " هذه المادة موجوده - بواسطة الاسم", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                item.id = Convert.ToInt32(ds_name.Tables(0).Rows(0).Item("id").ToString())
                item.count = item.count + Convert.ToInt32(ds_name.Tables(0).Rows(0).Item("count").ToString())

                Beep()

            Else
                put_message("تم الغاء الحدث", " يرجى تغيير الاسم")
                Return
            End If
        End If

        item.save()

        If item.id = 0 Then
            put_message("تمت اضافة المادة", tb_name.Text)
        Else
            put_message("تمت تعديل المادة", tb_name.Text)
        End If
        If r_save_print.Checked Then

            barcode_print(item.barcode)
        ElseIf r_save_print_small.Checked Then
            small_arcode_print(item.barcode)
        End If

        clear_value()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        tb_barcode.Text = ""
        tb_barcode.Focus()

        tb_barcode.ReadOnly = False
        clear_value()

    End Sub

    Private Function check_values() As Boolean


        defult_back(tb_barcode)
        defult_back(tb_name)
        defult_back(tb_price)
        defult_back2(cb_type)
        defult_back2(cb_store)

        If tb_barcode.Text.Trim = "" Then
            red_back(tb_barcode)

            Return False
        ElseIf tb_name.Text.Trim = "" Then
            red_back(tb_name)

            Return False
        ElseIf cb_type.Text.Trim = "" Then
            red_back2(cb_type)

            Return False
        ElseIf cb_store.Text.Trim = "" Then
            red_back2(cb_store)

            Return False
    

        ElseIf tb_price.Text.Trim = "" Or tb_price.Text.Trim = "0" Then
            red_back(tb_price)

            Return False


        Else
            Return True

        End If
    End Function

    Private Sub red_back(textEdit As DevExpress.XtraEditors.TextEdit)
        textEdit.BackColor = Color.Red
    End Sub
    Private Sub red_back2(comboBox As ComboBox)
        comboBox.BackColor = Color.Red
    End Sub

    Private Sub defult_back(textEdit As DevExpress.XtraEditors.TextEdit)
        textEdit.BackColor = Color.White

    End Sub
    Private Sub defult_back2(comboBox As ComboBox)
        comboBox.BackColor = Color.White

    End Sub

    Private Sub dt_last_update_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_barcode_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_barcode_KeyUp(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            tb_name.Focus()
            'فحص  باركود مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.barcode = tb_barcode.Text.Trim
            get_info_from_barcode(item)


        End If
    End Sub

    Private Sub put_message(message As String, name As String)
        Dim d As New DateTimePicker


        Try

            l_meesage.Text = d.Value.ToShortTimeString + "  " + message + " ( " + name + " ) " + vbNewLine + l_meesage.Text

        Catch ex As Exception
            l_meesage.Text = d.Value.ToShortTimeString + "  " + message + " ( " + name + " ) "
        End Try

    End Sub

    Private Sub clear_value()
        tb_id.Text = "0"
        tb_barcode.Text = ""
        tb_cost.Text = "0"
        tb_count.Text = "0"
        tb_detail.Text = ""
        tb_f1.Text = ""
        tb_f2.Text = ""
        tb_f3.Text = ""
        tb_f4.Text = ""

        tb_name.Text = ""
        tb_place.Text = ""
        tb_price.Text = "0"
        tb_id.BackColor = Color.WhiteSmoke

        l_old_item.Text = " "
        l_add_count.Text = "0"
        tb_barcode.Focus()
        tb_count.ReadOnly = False
        SimpleButton4.Visible = True
        tb_barcode.Visible = True

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        clear_value()
    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            tb_count.Focus()
            'فحص  الاسم مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.name = tb_name.Text.Trim

            Dim ds As New DataSet
            ds = item.name_check()
            If ds.Tables(0).Rows.Count > 0 Then
                tb_id.Text = (ds.Tables(0).Rows(0).Item("id").ToString())
                tb_name.Text = (ds.Tables(0).Rows(0).Item("name").ToString())
                tb_barcode.Text = (ds.Tables(0).Rows(0).Item("barcode").ToString())
                tb_price.Text = (ds.Tables(0).Rows(0).Item("price").ToString())
                tb_cost.Text = (ds.Tables(0).Rows(0).Item("cost").ToString())
                tb_detail.Text = (ds.Tables(0).Rows(0).Item("detail").ToString())
                tb_f1.Text = (ds.Tables(0).Rows(0).Item("f1").ToString())
                tb_f2.Text = (ds.Tables(0).Rows(0).Item("f2").ToString())
                tb_f3.Text = (ds.Tables(0).Rows(0).Item("f3").ToString())
                tb_f4.Text = (ds.Tables(0).Rows(0).Item("f4").ToString())
                cb_store.Text = store_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("store_id").ToString()))
                cb_type.Text = type_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("type").ToString()))
                tb_id.BackColor = Color.Green
                l_old_item.Text = " المادة موجودة بهذا الاسم  " + (ds.Tables(0).Rows(0).Item("name").ToString())
                l_add_count.Text = ds.Tables(0).Rows(0).Item("count").ToString()
                Beep()

            End If

        End If

    End Sub

    Private Sub tb_count_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_count_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            tb_price.Focus()

        End If
    End Sub

    Private Sub tb_price_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_price_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            tb_cost.Focus()

        End If
    End Sub

    Private Sub tb_cost_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_cost_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_save.Focus()

        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        tb_barcode.Text = ""
        barcode_generate()
        tb_name.Focus()



    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub barcode_generate()
1:
        Dim barcode As String
        Dim d As New DateTimePicker
        barcode = GetRandom(1, Convert.ToInt32(num_barcode_count.Value)).ToString + d.Value.Second.ToString

        tb_barcode.Text = barcode

        Try

            Dim fm = New fm_report_viewr
            Dim item As New Item
            item.barcode = barcode
            Dim ds As New DataSet
            ds = item.barcode_check()
            If ds.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("Retry  اضغط ", "هذا الباركود مستخدم", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End If

            tb_barcode.ReadOnly = True


        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Public Sub barcode_print(barcode As String)

1:
        Try
            Dim fm = New fm_report_viewr
            Dim item As New Item
            item.barcode = barcode
            fm.ds = item.barcode_check()
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub
    Public Sub small_arcode_print(barcode As String)

1:
        Try
            Dim fm = New fm_report_viewr
            Dim item As New Item
            item.barcode = barcode
            fm.small = "yes"
            fm.ds = item.barcode_check()
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub مسحToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub تعديلToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If li_item.SelectedItems.Count < 1 Then
            Exit Sub
        End If


        Dim item As New Item
        item.barcode = li_item.SelectedItems.Item(0).SubItems(1).Text


1:
        Try

            get_info_from_barcode(item)
            TabPane1.SelectedPageIndex = 1

            Me.Close()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
        Me.Close()

    End Sub

    Public Sub get_info_from_barcode(item As Item)

        Dim ds_barcode As New DataSet
        ds_barcode = item.barcode_check()
        If ds_barcode.Tables(0).Rows.Count > 0 Then
            tb_id.Text = (ds_barcode.Tables(0).Rows(0).Item("id").ToString())
            tb_name.Text = (ds_barcode.Tables(0).Rows(0).Item("name").ToString())
            tb_barcode.Text = (ds_barcode.Tables(0).Rows(0).Item("barcode").ToString())
            tb_price.Text = (ds_barcode.Tables(0).Rows(0).Item("price").ToString())
            tb_cost.Text = (ds_barcode.Tables(0).Rows(0).Item("cost").ToString())
            tb_detail.Text = (ds_barcode.Tables(0).Rows(0).Item("detail").ToString())

            tb_f1.Text = (ds_barcode.Tables(0).Rows(0).Item("f1").ToString())
            tb_f2.Text = (ds_barcode.Tables(0).Rows(0).Item("f2").ToString())
            If (ds_barcode.Tables(0).Rows(0).Item("f3").ToString()).Trim = "" Then
                tb_f3.EditValue = 0
            Else
                Try
                    tb_f3.EditValue = __((ds_barcode.Tables(0).Rows(0).Item("f3").ToString()))
                Catch ex As Exception
                    tb_f3.EditValue = 0
                End Try

            End If

            tb_f4.Text = (ds_barcode.Tables(0).Rows(0).Item("f4").ToString())
            cb_store.Text = store_title.Item(Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("store_id").ToString()))
            cb_type.Text = type_title.Item(Convert.ToInt32(ds_barcode.Tables(0).Rows(0).Item("type").ToString()))
            tb_id.BackColor = Color.Green
            l_old_item.Text = "  المادة موجودة بهذا الباركود  " + (ds_barcode.Tables(0).Rows(0).Item("name").ToString())
            l_add_count.Text = ds_barcode.Tables(0).Rows(0).Item("count").ToString()
            Beep()

        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search.EditValueChanged
        If r_name.Checked Then
            name_search()
        End If

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
        r_barcode.Checked = True
        tb_search.Focus()

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub طباعةباركودToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If li_item.SelectedItems.Count < 1 Then
            Exit Sub

        End If


        Dim item As New Item
        item.id = Convert.ToInt32(li_item.SelectedItems.Item(0).Text)
        item.barcode = li_item.SelectedItems.Item(0).SubItems(1).Text
        barcode_print(item.barcode)
        Me.Close()


    End Sub

    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
        If e.KeyCode = Keys.Enter Then
            new_search()
        End If
    End Sub

    Private Sub cb_search_store_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_search_store.SelectedIndexChanged
        name_search()

    End Sub

    Private Sub cb_search_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_search_type.SelectedIndexChanged
        name_search()

    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub cost_view()

        If user.type = 1 Then
            tb_cost.Visible = True
            l_cost.Visible = True
            l_cost2.Visible = True

        Else
            tb_cost.Visible = False
            l_cost.Visible = False
            l_cost2.Visible = False

        End If

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        all_search()
        tb_search.Focus()

    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_barcode.Text = ""
        barcode_generate()
        tb_name.Focus()

    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        tb_barcode.Text = ""
        tb_barcode.Focus()
        btn_save.Text = "حفظ جديد"
        tb_barcode.ReadOnly = False
        clear_value()
    End Sub

    Private Sub tb_barcode_EditValueChanged_1(sender As Object, e As EventArgs) Handles tb_barcode.EditValueChanged

    End Sub

    Private Sub tb_barcode_KeyUp1(sender As Object, e As KeyEventArgs) Handles tb_barcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            tb_name.Focus()
            'فحص  باركود مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.barcode = tb_barcode.Text.Trim
            get_info_from_barcode(item)


        End If
    End Sub

    Private Sub tb_name_EditValueChanged_1(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged

    End Sub

    Private Sub tb_name_KeyUp1(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If e.KeyCode = Keys.Enter Then
            tb_count.Focus()
            'فحص  الاسم مسجل مسبقا - ثم تحديث بياناتها والعدد
            Dim item As New Item
            item.name = tb_name.Text.Trim

            Dim ds As New DataSet
            ds = item.name_check()
            If ds.Tables(0).Rows.Count > 0 Then
                tb_id.Text = (ds.Tables(0).Rows(0).Item("id").ToString())
                tb_name.Text = (ds.Tables(0).Rows(0).Item("name").ToString())
                tb_barcode.Text = (ds.Tables(0).Rows(0).Item("barcode").ToString())
                tb_price.Text = (ds.Tables(0).Rows(0).Item("price").ToString())
                tb_cost.Text = (ds.Tables(0).Rows(0).Item("cost").ToString())
                tb_detail.Text = (ds.Tables(0).Rows(0).Item("detail").ToString())
                tb_f1.Text = (ds.Tables(0).Rows(0).Item("f1").ToString())
                tb_f2.Text = (ds.Tables(0).Rows(0).Item("f2").ToString())
                tb_f3.Text = (ds.Tables(0).Rows(0).Item("f3").ToString())
                tb_f4.Text = (ds.Tables(0).Rows(0).Item("f4").ToString())
                cb_store.Text = store_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("store_id").ToString()))
                cb_type.Text = type_title.Item(Convert.ToInt32(ds.Tables(0).Rows(0).Item("type").ToString()))
                tb_id.BackColor = Color.Green
                l_old_item.Text = " المادة موجودة بهذا الاسم  " + (ds.Tables(0).Rows(0).Item("name").ToString())
                l_add_count.Text = ds.Tables(0).Rows(0).Item("count").ToString()
                Beep()

            End If

        End If
    End Sub

  
    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

        fm_size.tb_count.Text = (_i(tb_count.Text) + _i(l_add_count.Text)).ToString
        tb_count.ReadOnly = True

        If tb_detail.Text.Trim <> "" Then
            Dim s As String = tb_detail.Text
            ' Split the string on the backslash character.
            Dim parts As String() = s.Split(New Char() {"\"c})
            ' Loop through result strings with For Each.
            Dim part As String
            For Each part In parts
                If part.Trim <> "" Then
                    fm_size.li_size.Items.Add(part)

                End If

            Next
        End If


        fm_size.Show()

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)

        tb_search.Focus()

    End Sub

    Private Sub new_search()
        If tb_search.Text.Trim = "" Then
            all_search()
            Exit Sub

        End If
        If r_barcode.Checked Then
            search_barcode()
        ElseIf r_name.Checked Then
            name_search()
        ElseIf r_id.Checked Then

            id_search()
        ElseIf r_price.Checked Then
            get_price_search()
        End If

    End Sub

    Private Sub search_barcode()
        barcode_search()
        tb_search.Text = ""
        tb_barcode.Focus()
    End Sub

 
    Private Sub r_barcode_CheckedChanged(sender As Object, e As EventArgs) Handles r_barcode.CheckedChanged
        tb_search.Focus()

    End Sub

    Private Sub r_name_CheckedChanged(sender As Object, e As EventArgs) Handles r_name.CheckedChanged
        tb_search.Focus()

    End Sub

    Private Sub r_id_CheckedChanged(sender As Object, e As EventArgs) Handles r_id.CheckedChanged
        tb_search.Focus()

    End Sub

    Private Sub SimpleButton3_Click_2(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        tb_detail.Text = ""

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
1:

        Try
            If check_values() Then
                add()
                tb_count.ReadOnly = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try


    End Sub

    Private Sub r_price_CheckedChanged(sender As Object, e As EventArgs) Handles r_price.CheckedChanged
        tb_search.Focus()

    End Sub

  
End Class
