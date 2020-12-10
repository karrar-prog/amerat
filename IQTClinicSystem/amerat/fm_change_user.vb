Imports MySql.Data.MySqlClient

Public Class fm_change_user

    Private Sub fm_change_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimpleButton13.Text = "المستخدم الحالي : " & user.name
    End Sub
    Private Sub by_secret_word()
1:

        Try
            Dim s = user.name
          
            user.secret_word = tb_secret_word.Text.Trim
            If user.isExsit() Then
                If user.f1.Trim = "فعال" Then

                    Login()
                    Dim content = " تم خروج المستخدم : " & s & " ودخول المستخدم : " & user.name
                    new_event2("تبديل الدخول", content, 0)

                Else


                    MessageBox.Show("تم تعطيل هذا الحساب مؤقتاً")
                    fm_login.Close()

                End If

           

            Else
                MessageBox.Show("الرمز خطأ")

                tb_secret_word.BackColor = Color.LightPink
            End If
        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            Else

            End If
        End Try






    End Sub
    Private Sub Login()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        '  fm_sell.Show()
        Dim permission As New Permission
        permission.getAll()

        SimpleButton13.Text = "المستخدم الحالي : " & user.name
        fm_main.tb_user.Caption = user.name
        tb_secret_word.Text = ""


    End Sub

    Private Sub tb_secret_word_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_secret_word.KeyUp
        If e.KeyCode = Keys.Enter Then
            by_secret_word()
        End If
    End Sub

    Private Sub tb_secret_word_TextChanged(sender As Object, e As EventArgs) Handles tb_secret_word.TextChanged

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        by_secret_word()
    End Sub
End Class