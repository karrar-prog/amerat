Imports MySql.Data.MySqlClient

Public Class fm_monitoring_event

    Private Sub fm_monitoring_event_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        li_format()
        get_all()
        all_user()
    End Sub
    Public Sub all_user()
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

    Private Sub li_format()
        'list
        li_event.View = View.Details
        li_event.Columns.Add("ت", 80)
        li_event.Columns.Add("عنوان", 100)
        li_event.Columns.Add("تفاصيل الحدث", 550)
        li_event.Columns.Add("التأريخ والوقت", 220)
        li_event.Columns.Add("المستخدم", 200)
        li_event.Columns.Add("المبلغ", 200)

        'list
        li_user.View = View.Details
        li_user.Columns.Add("ت", 40)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 100)
        li_user.Columns.Add("نوع الحساب", 100)
        li_user.Columns.Add("حالة المستخدم", 100)
        li_user.Columns.Add("حقل2", 100)
        li_user.Columns.Add("حقل3", 100)
        li_user.Columns.Add("حقل4", 100)
    End Sub
    Public Sub get_all()
1:
        Try
            Dim e As New EventRecord

            Dim d As New DataSet
            d = e.event_between(DateTimePicker1, DateTimePicker2)
            fill_li_event(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub get_user_event()
        If (tb_user_id.Text.Trim = "") Then
            Exit Sub
        End If
1:
        Try
            Dim e As New EventRecord

            Dim d As New DataSet
            d = e.user_event(__(tb_user_id.Text), DateTimePicker1, DateTimePicker2)
            fill_li_event(d)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub fill_li_event(d As DataSet)

        GridControl1.DataSource = d.Tables(0)



        tb_come.Text = "0"
        tb_out.Text = "0"

        tb_net.Text = "0"



1:
        Try
            li_event.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_event.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_event.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("title").ToString)
                    li_event.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("content").ToString)
                    li_event.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("date").ToString)
                    li_event.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_name").ToString)
                    li_event.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("amount").ToString)
                    If (__(d.Tables(0).Rows(i).Item("amount").ToString) > 0) Then

                        tb_come.Text = (__(tb_come.Text) + (__(d.Tables(0).Rows(i).Item("amount").ToString))).ToString

                    End If
                    If (__(d.Tables(0).Rows(i).Item("amount").ToString) < 0) Then
                        tb_out.Text = (__(tb_out.Text) + (__(d.Tables(0).Rows(i).Item("amount").ToString))).ToString


                    End If
                    tb_net.Text = (__(tb_net.Text) + (__(d.Tables(0).Rows(i).Item("amount").ToString))).ToString

                Next

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        get_user_event()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        get_all()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_user_id.Text = li_user.SelectedItems.Item(0).Text
            tb_username.Text = li_user.SelectedItems.Item(0).SubItems(1).Text
            get_user_event()


        End If
    End Sub

    Private Sub li_event_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_event.SelectedIndexChanged

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub
End Class