Imports MySql.Data.MySqlClient

Public Class fm_view_pulls
    Public back As String = "main"

    Private Sub fm_view_pulls_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If back = "main" Then
            fm_main.Show()

        ElseIf back = "user" Then
            fm_user.Show()

        End If
    End Sub

    Private Sub fm_view_pulls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formating()
        get_all()
    End Sub
    Private Sub formating()
   
        'list
        li_user.View = View.Details
        li_user.Columns.Add("ت", 40)
        li_user.Columns.Add("الاسم", 200)
        li_user.Columns.Add("الهاتف", 200)
        li_user.Columns.Add("نوع الحساب", 120)
        li_user.Columns.Add("حالة المستخدم", 200)
        li_user.Columns.Add("حقل2", 200)
        li_user.Columns.Add("حقل3", 200)
        li_user.Columns.Add("حقل4", 200)

        'list
        li_pull.View = View.Details
        li_pull.Columns.Add("ت", 40)
        li_pull.Columns.Add("المستلم", 160)
        li_pull.Columns.Add("المبلغ", 120)
        li_pull.Columns.Add("النوع", 120)
        li_pull.Columns.Add("معطي المبلغ", 100)
        li_pull.Columns.Add("التاريخ", 140)
        li_pull.Columns.Add("الوقت", 120)
        li_pull.Columns.Add("ملاحطة", 200)
        li_pull.Columns.Add(" ", 0)
        li_pull.Columns.Add(" ", 0)
        li_pull.Columns.Add(" ", 0)



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
    Public Sub fill_li_user_pull(d As DataSet)

        tb_other_pull.Text = "0"
        tb_things_pull.Text = "0"
        tb_user_pull.Text = "0"
        tb_recive_mony.Text = "0"
        tb_back.Text = "0"
        tb_all.Text = "0"
        tb_menu_recive.Text = "0"

        tb_f_pulls.Text = "0"
        tb_f_recive.Text = "0"
        tb_f_total.Text = "0"
        tb_back_money.Text = "0"

1:
        Try
            li_pull.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1

                    li_pull.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_name").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("amount").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("type").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_did_id").ToString)
                    Try
                        Dim dt As New DateTimePicker
                        Dim t As New DateTimePicker

                        dt.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("date").ToString)
                        t.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("time").ToString)
                        li_pull.Items(i).SubItems.Add(dt.Value.ToShortDateString)
                        li_pull.Items(i).SubItems.Add(t.Value.ToShortTimeString)

                    Catch ex As Exception
                        li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("date").ToString)
                        li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("time").ToString)

                    End Try
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_pull.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    If d.Tables(0).Rows(i).Item("f1").ToString = blocked_user Then
                        li_pull.Items(i).BackColor = Color.Red
                        li_pull.Items(i).ForeColor = Color.White

                    End If
                    If d.Tables(0).Rows(i).Item("type").ToString = s_other_pull Then
                        tb_other_pull.Text = (__(tb_other_pull.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString


                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_user_pull Then
                        tb_user_pull.Text = (__(tb_user_pull.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString


                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_things_pull Then
                        tb_things_pull.Text = (__(tb_things_pull.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString


                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_back_money_pull Then
                        tb_back.Text = (__(tb_back.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString


                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_back_money Then
                        tb_back_money.Text = (__(tb_back_money.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString



                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_menu_recive Then
                        tb_menu_recive.Text = (__(tb_menu_recive.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString



                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_recive_money Then
                        tb_recive_mony.Text = (__(tb_recive_mony.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString

                    Else


                    End If
                Next

                tb_all.Text = (__(tb_user_pull.Text) - __(tb_recive_mony.Text)).ToString
                'tb_all_others.Text = (__(tb_back.Text) + __(tb_things_pull.Text) + __(tb_other_pull.Text) - __(tb_menu_recive.Text)).ToString
                tb_all_others.Text = (__(tb_things_pull.Text) + __(tb_other_pull.Text) - __(tb_back_money.Text)).ToString
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub
    Public Sub fill_li_user_pull3(d As DataSet)

        tb_f_pulls.Text = "0"
        tb_f_recive.Text = "0"
        tb_f_total.Text = "0"


1:
        Try

            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1

                 
                   If d.Tables(0).Rows(i).Item("type").ToString = s_user_pull Then
                        tb_f_pulls.Text = (__(tb_f_pulls.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString




                    ElseIf d.Tables(0).Rows(i).Item("type").ToString = s_recive_money Then
                        tb_f_recive.Text = (__(tb_f_recive.Text) + __(d.Tables(0).Rows(i).Item("amount").ToString)).ToString



                    End If
                Next

                tb_f_total.Text = (__(tb_f_pulls.Text) - __(tb_f_recive.Text)).ToString
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_user_id.Text = li_user.SelectedItems.Item(0).Text
            tb_username.Text = li_user.SelectedItems.Item(0).SubItems(1).Text

        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        get_user_pulls()
    End Sub

    Public Sub get_user_pulls()
        If tb_user_id.Text.Trim <> "" Then
            l_type.Text = "العامل : " & tb_username.Text

            Dim UserMoneyList As New UserMoneyList
            UserMoneyList.user_id = __(tb_user_id.Text)
            Dim d As New DataSet
            d = UserMoneyList.get_all_user_money2(DateTimePicker1, DateTimePicker2)
            fill_li_user_pull(d)
            Dim d2 As New DataSet
            d2 = UserMoneyList.get_all_user_money3()
            fill_li_user_pull3(d2)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        get_all_pulls()

    End Sub

    Private Sub get_all_pulls()
        l_type.Text = "جميع العمال"

        Dim UserMoneyList As New UserMoneyList
        UserMoneyList.user_id = __(tb_user_id.Text)
        Dim d As New DataSet
        d = UserMoneyList.get_all_money2(DateTimePicker1, DateTimePicker2)
        fill_li_user_pull(d)

        Dim d3 As New DataSet
        d3 = UserMoneyList.get_all_money3()
        fill_li_user_pull3(d3)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
      
        If hasPermission(per_pulls_show) Then
            Try
                fm_pull_money.Close()
            Catch ex As Exception

            End Try
            fm_pull_money.r_pull.Checked = True

            fm_pull_money.r_buy.Visible = False
            fm_pull_money.r_recive.Visible = False
            fm_pull_money.r_things.Visible = False
            fm_pull_money.r_back_monwy.Visible = False
            fm_pull_money.Show()
        Else
            MessageBox.Show("لاتمتلك صلاحية السحوبات")
        End If
        back = "pull"

        fm_pull_money.tb_amount.Focus()
    End Sub

    Private Sub btn_tb_user_pull_Click(sender As Object, e As EventArgs) Handles btn_tb_user_pull.Click

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs)
        If GroupControl1.Visible = False Then
            GroupControl1.Visible = True
        Else
            GroupControl1.Visible = False
        End If
    End Sub

    Private Sub SimpleButton7_Click_1(sender As Object, e As EventArgs) Handles SimpleButton7.Click
       
     
        If hasPermission(per_pulls_show) Then
            Try
                fm_pull_money.Close()
            Catch ex As Exception

            End Try
            fm_pull_money.r_recive.Checked = True

            fm_pull_money.r_buy.Visible = False
            fm_pull_money.r_pull.Visible = False
            fm_pull_money.r_things.Visible = False
            fm_pull_money.r_back_monwy.Visible = False
            fm_pull_money.Show()
        Else
            MessageBox.Show("لاتمتلك صلاحية السحوبات")
        End If

        back = "pull"
        fm_pull_money.tb_amount.Focus()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If GroupControl4.Visible = True Then
            GroupControl4.Visible = False
        Else
            GroupControl4.Visible = True
        End If
    End Sub
End Class