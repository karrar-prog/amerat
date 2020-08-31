Imports MySql.Data.MySqlClient

Public Class fm_customer_search

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub tb_search_EditValueChanged(sender As Object, e As EventArgs) Handles tb_search.EditValueChanged

    End Sub

    Private Sub tb_search_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_search.KeyUp
        search()

    End Sub

    Private Sub search()
        Dim customers As New Customer
        Dim d As New DataSet
        d = customers.name_search(tb_search.Text.Trim)
        fill_li(d)
    End Sub

    Private Sub fm_customer_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'list
        li_customer.View = View.Details
        li_customer.Columns.Add("ت", 80)
        li_customer.Columns.Add("الاسم", 190)
        li_customer.Columns.Add("تأريخ القائمة", 120)
        li_customer.Columns.Add("رقم القائمة", 100)
        li_customer.Columns.Add("حالة القائمة", 130)



    End Sub

    Private Sub fill_li(d As DataSet)
        Dim my_date As New DateTimePicker

1:
        Try
            li_customer.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_customer.Items().Add(d.Tables(0).Rows(i).Item("cu_id").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("name").ToString)
                   Try
                        my_date.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("d_date").ToString)
                        li_customer.Items(i).SubItems.Add(my_date.Value.ToShortDateString)

                    Catch ex As Exception
                        li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("d_date").ToString)

                    End Try
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("s_id").ToString)
                    li_customer.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("status").ToString)

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

        fm_sell.tb_menu_id.Text = li_customer.SelectedItems.Item(0).SubItems(3).Text
        fm_sell.tb_f1.Text = li_customer.SelectedItems.Item(0).SubItems(4).Text
        Dim d As New DataSet
        Dim id As Integer
        id = Convert.ToInt32(li_customer.SelectedItems.Item(0).SubItems(3).Text)
        fm_sell.tb_status.EditValue = Convert.ToInt32(li_customer.SelectedItems.Item(0).SubItems(4).Text)

        Dim sell_menu_item As New sell_menu_item
        sell_menu_item.sell_menu_id = id
        
            d = sell_menu_item.get_menu_items()
      
        fm_sell.fill_li_menu_item(d)

    End Sub

End Class