Public Class fm_item_option 

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If user.type <> user_admin Then
            MessageBox.Show("لايمكن المسح")
            Exit Sub
        End If
        If Xstore.li_item.SelectedItems.Count < 1 Then
            Me.Close()

        End If


        Dim item As New Item
        item.id = Convert.ToInt32(Xstore.li_item.SelectedItems.Item(0).Text)
        item.name = Xstore.li_item.SelectedItems.Item(0).SubItems(2).Text
1:
        Try


            If MessageBox.Show(" سوف تقوم بحذف المادة  " + item.name, "اضغط نعم للاستمرار", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                item.delete()
                Xstore.search()
                Me.Close()

            End If

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Xstore.li_item.SelectedItems.Count < 1 Then
            Me.Close()

        End If


        Dim item As New Item
        item.barcode = Xstore.li_item.SelectedItems.Item(0).SubItems(1).Text


1:
        Try

            Xstore.get_info_from_barcode(item)
            Xstore.TabPane1.SelectedPageIndex = 1
            Xstore.tb_count.ReadOnly = False
            Xstore.SimpleButton4.Visible = False
            Xstore.tb_barcode.Visible = False

            Me.Close()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
        Xstore.btn_save.Text = "حفظ التعديلات"
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Xstore.li_item.SelectedItems.Count < 1 Then

            Me.Close()


        End If


        Dim item As New Item
        item.id = Convert.ToInt32(Xstore.li_item.SelectedItems.Item(0).Text)
        item.barcode = Xstore.li_item.SelectedItems.Item(0).SubItems(1).Text
        Xstore.barcode_print(item.barcode)
        Me.Close()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()

    End Sub

    Private Sub fm_item_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If Xstore.li_item.SelectedItems.Count < 1 Then

            Me.Close()


        End If


        Dim item As New Item
        item.id = Convert.ToInt32(Xstore.li_item.SelectedItems.Item(0).Text)
        item.barcode = Xstore.li_item.SelectedItems.Item(0).SubItems(1).Text
        Xstore.small_arcode_print(item.barcode)
        Me.Close()
    End Sub
End Class