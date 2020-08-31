Public Class fm_customer_info 

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If tb_customer_name.Text.Trim = "" Then
            MessageBox.Show("ادخل اسم الصديق")
            Exit Sub
        End If

        PrintFriendCard()
    End Sub
    Private Sub PrintFriendCard()
        Try
            Dim fm = New fm_friend_card
            Dim customer As New Customer
            customer.id = _i(tb_customer_id.Text)
            customer.name = tb_customer_name.Text
            customer.note = tb_customer_note.Text
            customer.update()
            fm.ds = customer.get_for_print()
            fm.Show()
            Me.Close()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub fm_customer_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class