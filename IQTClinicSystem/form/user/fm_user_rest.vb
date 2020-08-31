Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class fm_user_rest

    Private Sub fm_user_rest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub

    Private Sub fm_user_rest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formating()
        get_all()
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





        li_rest.View = View.Details
        li_rest.Columns.Add("ت", 0)
        li_rest.Columns.Add("رقم المستخدم", 0)
        li_rest.Columns.Add("اسم المستخدم", 200)
        li_rest.Columns.Add("نوع", 100)
        li_rest.Columns.Add("وقت الخروج", 120)
        li_rest.Columns.Add("الدقائق", 80)
        li_rest.Columns.Add("وقت العودة", 0)
        li_rest.Columns.Add("تمت العودة", 120)
        li_rest.Columns.Add("معطي الاستراحة", 200)
        li_rest.Columns.Add("حقل2", 100)
        li_rest.Columns.Add("حقل3", 100)
        li_rest.Columns.Add("حقل4", 100)


        'list
        li_rest_type.View = View.Details
        li_rest_type.Columns.Add("نوع الاستراحة", 160)
        li_rest_type.Columns.Add("عدد الدقائق", 120)








        'جلب معلومات الايميل من التيكس
        Try
            Dim reader As New StreamReader(Application.StartupPath & "/server/rest_type.txt", Encoding.Default)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(0).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(1).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(2).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(3).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(4).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(5).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(6).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(7).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(8).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(9).SubItems().Add(reader.ReadLine)
            li_rest_type.Items.Add(reader.ReadLine)
            li_rest_type.Items(10).SubItems().Add(reader.ReadLine)

        Catch ex As Exception

        End Try


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

    Private Sub li_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_user.SelectedIndexChanged
        If li_user.SelectedItems.Count > 0 Then

            tb_user_id.Text = li_user.SelectedItems.Item(0).Text
            tb_username.Text = li_user.SelectedItems.Item(0).SubItems(1).Text
            get_rests()

        End If
        hide_or_show_login()

       

    End Sub

    Private Sub li_rest_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_rest_type.SelectedIndexChanged
        If li_rest_type.SelectedItems.Count > 0 Then

            tb_minute.Text = li_rest_type.SelectedItems.Item(0).SubItems(1).Text
            tb_type.Text = li_rest_type.SelectedItems.Item(0).Text


        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        add_rest()
        get_rests()

        print_menu()
    End Sub
    Private Sub print_menu()
        If li_rest.Items.Count <= 0 Then
            Exit Sub
        End If



1:
        Try
            Dim fm = New fm_print_rest
            fm.id = __(li_rest.Items.Item(li_rest.Items.Count - 1).Text)
            fm.admin_name = user.name
            fm.user_name = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(2).Text
            fm.type = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(3).Text
            fm.d_left = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(4).Text
            fm.minutes = __(li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(5).Text)
            fm.d_should = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(6).Text
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub
    Private Sub print_login()
        If li_rest.Items.Count <= 0 Then
            Exit Sub
        End If



1:
        Try
            Dim fm = New fm_print_rest
            fm.path = "/reports/login.repx"
            fm.id = __(li_rest.Items.Item(li_rest.Items.Count - 1).Text)
            fm.admin_name = user.name
            fm.user_name = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(2).Text
            fm.type = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(3).Text
            fm.d_left = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(4).Text
            fm.minutes = __(li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(5).Text)
            fm.d_should = li_rest.Items.Item(li_rest.Items.Count - 1).SubItems(6).Text
            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try
    End Sub

    Private Sub add_rest()
        If false_values() Then
            Exit Sub
        End If
        Dim d1 As New DateTimePicker
        Dim rest As New Rests
        rest.user_id = __(tb_user_id.Text)
        rest.user_name = tb_username.Text
        rest.type = tb_type.Text
        rest.d_left = d1.Value.ToString
        rest.minutes = __(tb_minute.Text)
        rest.d_should = d1.Value.AddMinutes(rest.minutes).ToString
        rest.f1 = user.name
        rest.f2 = ""
        rest.f3 = ""
        rest.f4 = ""
        rest.save()
    End Sub
    Private Function Notifier(checkouttime As String) As String
        Dim checktime As DateTime
        If DateTime.TryParse(checkouttime, checktime) Then
            Dim currenttime As Date = Date.Now
            Return (currenttime - checktime).ToString()
        End If
        Return "0"
    End Function
    Private Sub add_login()
        If tb_username.Text = "" Then
            Exit Sub
        End If
        Dim d1 As New DateTimePicker
      
        Dim rest As New Rests
        rest.user_id = __(tb_user_id.Text)
        rest.user_name = tb_username.Text
        rest.type = s_login
        rest.d_left = d1.Value.AddHours(15).ToString

        rest.d_should = d1.Value.ToString
        rest.f1 = user.name
        rest.f2 = ""
        rest.f3 = ""
        rest.f4 = ""
        rest.save()
    End Sub

    Private Function false_values() As Boolean
        If tb_username.Text = "" Or tb_type.Text.Trim = "" Then
            Return True
        Else
            Return False
        End If
    End Function
  

    Private Sub get_rests()
        If tb_user_id.Text.Trim = "" Then
            Exit Sub
        End If
        Dim d As New DataSet
        Dim rests As New Rests
        d = rests.user_rests(__(tb_user_id.Text), DateTimePicker1, DateTimePicker2)
        fill_li(d)
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        get_rests()
    End Sub

    Private Sub fill_li(d As DataSet)
1:
        Try
            Dim count As Integer = 0

            Dim dt As New DateTimePicker

            li_rest.Items.Clear()
            If d.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To d.Tables(0).Rows.Count - 1
                    li_rest.Items().Add(d.Tables(0).Rows(i).Item("id").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_id").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("user_name").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("type").ToString)
                    dt.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("d_left").ToString)
                    li_rest.Items(i).SubItems.Add(dt.Value.ToShortTimeString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("minutes").ToString)
                    dt.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("d_should").ToString)
                    li_rest.Items(i).SubItems.Add(dt.Value.ToShortTimeString)
                    Try
                        dt.Value = Convert.ToDateTime(d.Tables(0).Rows(i).Item("d_back").ToString)
                        li_rest.Items(i).SubItems.Add(dt.Value.ToShortTimeString)
                    Catch ex As Exception
                        li_rest.Items(i).SubItems.Add("")
                    End Try
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f1").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f2").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f3").ToString)
                    li_rest.Items(i).SubItems.Add(d.Tables(0).Rows(i).Item("f4").ToString)
                    If (d.Tables(0).Rows(i).Item("d_back").ToString).Trim = "" Then
                        li_rest.Items(i).BackColor = Color.LightPink
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

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim id As Integer
        id = __(InputBox("ادخل رقم وصل الاستراحة", "من قارء الباركود", ""))
        If id.ToString.Trim <> "" Then
            user_back(id)
            get_rests()
        End If

    End Sub

    Private Sub user_back(id As Integer)
        Dim rest As New Rests
        rest.id = id
        rest.d_back = Date.Now.ToString
        rest.save()


    End Sub

    Private Sub li_rest_DoubleClick(sender As Object, e As EventArgs) Handles li_rest.DoubleClick
        If li_rest.SelectedItems.Count > 0 Then
            If (li_rest.SelectedItems.Item(0).SubItems(7).Text) = "" Then
                user_back(__(li_rest.SelectedItems.Item(0).Text))
                li_rest.SelectedItems.Clear()
                get_rests()
            Else
                MessageBox.Show("تمت العودة مسبقا")
            End If


        End If
    End Sub

    Private Sub li_rest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_rest.SelectedIndexChanged

    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        For i = 0 To li_rest.Items.Count - 1
            If li_rest.Items(i).SubItems(3).Text = s_login Then
                MessageBox.Show("تم التسجيل مسبقا")

                Exit Sub

            End If
        Next
        add_login()
        get_rests()
        print_login()
    End Sub

    Private Sub hide_or_show_login()
        For i = 0 To li_rest.Items.Count - 1
            If li_rest.Items(i).SubItems(3).Text = s_login Then
                SimpleButton1.Hide()
                Exit Sub
            End If
        Next
        SimpleButton1.Show()
    End Sub

End Class