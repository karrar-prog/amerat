Imports MySql.Data.MySqlClient

Public Class fm_pull_money
    Public f2 As String = ""
    Public f3 As String = ""
    Public f4 As String = ""
    Public back As String = "sell"


    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If hasPermission("السحوبات") Then

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If

        If wrong() Then
            Exit Sub
        End If
        If r_recive.Checked And tb_note.Text.Trim = "" Then
            MessageBox.Show("اكتب ملاحظة حول التسديد")
            tb_note.Focus()

            Exit Sub
        End If

        save_pull()


    End Sub

    Private Function wrong() As Boolean
        If tb_amount.Text.Trim = "" Or __(tb_amount.Text) = 0 Then
            tb_amount.BackColor = Color.Red
            Return True

        End If
        If tb_id.Text.Trim = "" Or tb_name.Text.Trim = "" Then
            tb_name.BackColor = Color.Red
            Return True

        End If
        Return False

    End Function

    Private Sub save_pull()

        Dim pull As New UserMoneyList
        pull.user_id = __(tb_id.Text)
        pull.user_did_id = user.id
        pull.amount = __(tb_amount.Text)
        pull.time = Date.Now.ToLongTimeString

        pull.date1 = Date.Now.ToShortDateString
        pull.type = get_type_text()
        pull.f1 = tb_note.Text
        pull.f2 = f2
        pull.f3 = f3
        pull.f4 = f4
        pull.save()
        Dim content = "  سحب من الدخل " & "  " & pull.user_id
        If (pull.type = s_other_pull Or pull.type = s_user_pull Or pull.type = s_things_pull) Then
            new_event2(pull.type, content, (-1 * __(tb_amount.Text)))

        Else
            new_event2(pull.type, content, __(tb_amount.Text))

        End If

            print()

            tb_amount.Text = ""
            tb_id.Text = ""
            tb_name.Text = ""
            tb_note.Text = ""





    End Sub
    Private Sub print()

        Try

        Catch ex As Exception

        End Try
1:
        Try
            Dim fm = New fm_print_money


            fm.type = get_type_text()
            fm.user_name = tb_name.Text
            fm.time = Date.Now.ToShortTimeString
            fm.date1 = Date.Now.ToShortDateString
            fm.amount = __(tb_amount.Text)
            fm.user_did_it = user.name


            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub formating()

        'list
        li_user.View = View.Details
        li_user.Columns.Add("ت", 0)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 200)
        li_user.Columns.Add("نوع الحساب", 120)
        li_user.Columns.Add("حالة المستخدم", 200)
        li_user.Columns.Add("حقل2", 200)
        li_user.Columns.Add("حقل3", 200)
        li_user.Columns.Add("حقل4", 200)



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
    Private Function get_type_text() As String
        If r_buy.Checked Then
            Return s_other_pull
        ElseIf r_pull.Checked Then
            Return s_user_pull
        ElseIf r_things.Checked Then

            Return s_things_pull
        ElseIf r_recive.Checked Then
            Return s_recive_money
        ElseIf r_back_monwy.Checked Then
            Return s_back_money

        Else
            Return " "

        End If

    End Function

    Private Sub TabFormControl1_Click(sender As Object, e As EventArgs) Handles TabFormControl1.Click
      
    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_id.Text = li_user.SelectedItems.Item(0).Text
            tb_name.Text = li_user.SelectedItems.Item(0).SubItems(1).Text
            tb_amount.Focus()

        End If
        tb_amount.Focus()

    End Sub

    Private Sub fm_pull_money_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()


    End Sub

    Private Sub fm_pull_money_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formating()
        get_all()

    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        tb_name.BackColor = Color.White
    End Sub

    Private Sub tb_amount_EditValueChanged(sender As Object, e As EventArgs) Handles tb_amount.EditValueChanged
        tb_amount.BackColor = Color.White
    End Sub

    Private Sub TabPane1_Click(sender As Object, e As EventArgs) Handles TabPane1.Click

    End Sub
End Class