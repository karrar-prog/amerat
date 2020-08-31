Imports MySql.Data.MySqlClient

Public Class fm_select_size

    Private Sub fm_select_size_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        li_size.View = View.Details
        li_size.Columns.Add("القياس", 280)

    End Sub

    Private Sub li_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_size.SelectedIndexChanged

        tb_select_size.Text = li_size.SelectedItems.Item(0).Text.Trim




    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

        If tb_select_size.Text <> "" Then

1:
            Try
                Dim item As New sell_menu_item
                item.item_cost = _i(fm_add_item.tb_cost.Text)
                item.item_count = _i(fm_add_item.tb_count.Text)
                item.item_name = fm_add_item.tb_name.Text
                item.item_id = _i(fm_add_item.tb_id.Text)
                item.item_price = _i(fm_add_item.tb_price.Text)
                item.f1 = "بيع"
                item.f4 = tb_select_size.Text

                item.sell_menu_id = _i(fm_add_item.tb_sell_menu_id.Text)
                item.datetime = Date.Now.ToString
                item.user_sell_it_id = user.id
                item.save()
                fm_sell.put_message(" اضافة مادة للقائمة", fm_add_item.tb_name.Text)
                fm_sell.menu_search(_i(fm_add_item.tb_sell_menu_id.Text))
                fm_sell.btn_add_new.Focus()
                fm_add_item.Close()

                Me.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo 1
                End If
            End Try


        End If
    End Sub
End Class