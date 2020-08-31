Imports MySql.Data.MySqlClient

Public Class fm_customer

    Private Sub num_limit_ValueChanged(sender As Object, e As EventArgs) Handles num_limit.ValueChanged

    End Sub
    Private Sub LabelControl6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim d As New DataSet
        Dim customer As New Customer
        customer.name = tb_name.Text
        d = customer.create_customers(__(num_limit.Value.ToString))
        print(d)
    End Sub
    Public Sub print(d As DataSet)

1:
        Try
            Dim fm = New fm_print_customer
            fm.ds = d
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub fm_customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub


    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
        search()

    End Sub

    Private Sub search()
        Dim customers As New Customer
        Dim d As New DataSet
        d = customers.name_search2(tb_search.Text.Trim)
        fill_li(d)
    End Sub

    Private Sub fm_customer_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'list
        li_customer.View = View.Details
        li_customer.Columns.Add("رقم الكارت", 180)
        li_customer.Columns.Add("اسم الزبون", 190)
        li_customer.Columns.Add("ملاحظة", 190)
        li_customer.Columns.Add("ملاحظة", 190)
        li_customer.Columns.Add("ملاحظة", 190)
        li_customer.Columns.Add("ملاحظة", 190)
        li_customer.Columns.Add("ملاحظة", 190)



    End Sub

    Private Sub fill_li(d As DataSet)
        Dim my_date As New DateTimePicker

1:
        Try
            li_customer.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_customer.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("name").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("note").ToString)
               
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)

                Next
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
    End Sub

    Private Sub li_customer_DoubleClick(sender As Object, e As EventArgs) Handles li_customer.DoubleClick

    End Sub

    Private Sub li_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_customer.SelectedIndexChanged
        If li_customer.SelectedItems.Count > 0 Then
            fm_sell.tb_search.Text = li_customer.SelectedItems.Item(0).Text
            fm_sell.r_customer_id.Checked = True
            fm_sell.search()
            put_menu()

        End If

    End Sub

    Private Sub put_menu()
        fm_sell.tb_menu_id.EditValue = 0

        fm_sell.tb_count.Text = "0"
        fm_sell.tb_count2.Text = "0"
        fm_sell.tb_total_price.Text = "0"
        fm_sell.tb_discount.Text = "0"
        fm_sell.tb_final_price.Text = "0"
        fm_sell.tb_status.Text = ""
        fm_sell.tb_customer_name.Text = ""
        fm_sell.tb_customer_note.Text = ""
        fm_sell.tb_customer_type.Text = ""
        fm_sell.Show()
        fm_sell.tb_search.Text = li_customer.SelectedItems.Item(0).Text
        fm_sell.r_customer_id.Checked = True
        fm_sell.search()
        fm_sell.back_path = "cu"
        Me.Hide()

        'Dim d As New DataSet
        'Dim id As Integer
        'id = Convert.ToInt32(li_customer.SelectedItems.Item(0).SubItems(3).Text)
        'fm_sell.tb_status.EditValue = Convert.ToInt32(li_customer.SelectedItems.Item(0).SubItems(4).Text)

        'Dim sell_menu_item As New sell_menu_item
        'sell_menu_item.sell_menu_id = id

        'd = sell_menu_item.get_menu_items()

        'fm_sell.fill_li_menu_item(d)

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

    End Sub

    Private Sub tb_search_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search.EditValueChanged

    End Sub
End Class