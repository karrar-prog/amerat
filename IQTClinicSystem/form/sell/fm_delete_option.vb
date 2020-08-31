Public Class fm_delete_option 
    Public sell_menu_id As Integer = 0

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
1:
        Try
            Dim item As New sell_menu_item
            item.id = _i(tb_item_id.Text.Trim)
            item.delete()
            fm_sell.menu_search(sell_menu_id)
            fm_sell.put_message("تم حذف المادة من القائمة", tb_item_name.Text)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry  وضغط ", " حدث خطأ", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

   
    Private Sub fm_delete_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Dim old_item As New sell_menu_item(_i(tb_item_id.Text))

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

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        fm_sell.li_sell_menu_item.SelectedItems.Item(0).SubItems(2).Text = tb_item_name.Text
        Dim item As New sell_menu_item(_i(tb_item_id.Text.Trim))

        item.item_name = tb_item_name.Text
        item.save()

    End Sub
End Class