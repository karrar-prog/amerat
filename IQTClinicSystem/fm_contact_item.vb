Imports MySql.Data.MySqlClient

Public Class fm_contact_item

    Private Sub fm_contact_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim reader As New StreamReader(Application.StartupPath & "/server/contract_items.txt", Encoding.Default)

            'item4.Text = reader.ReadToEnd

            'reader.Close()
            'item4.Text = item4.Text & " " & Date.Now.ToShortDateString

            Try
                Dim store As New store
                Dim ds As New DataSet
                ds = store.contract_item()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    'store_title.Add(ds.Tables(0).Rows(i).Item("name").ToString)
                    item4.Text = ds.Tables(0).Rows(i).Item("name").ToString
                    tb_id.Text = "1"
                Next
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
                If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then

                End If
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        If user.type <> user_admin Then
            MessageBox.Show("مركز الصلاحيات", "لايمكن الحفظ")
            Exit Sub
        End If
        If tb_id.Text.Trim = "" Then
            save_new()

        ElseIf tb_id.Text.Trim = "1" Then
            update_items()
        End If
        MessageBox.Show("تم الحفظ بنجاح")
        Me.Close()

    End Sub

    Private Sub save_new()
        Dim store As New store
        store.name = item4.Text
        store.save_new()

    End Sub

    Private Sub update_items()
        Dim store As New store
        store.id = __(tb_id.Text)
        store.name = item4.Text
        store.update_items()

    End Sub

End Class