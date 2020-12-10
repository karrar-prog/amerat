Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.Net.Mail
Imports System.Net
Imports System.Drawing.Text
Imports DevExpress.LookAndFeel

Public Class fm_login

    Private Sub fm_login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_SplashScreen.Close()

    End Sub

    Private Sub fm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
        Dim prog As String = "لا يمكن تشغيل البرنامج على هذا الجهاز -- اتصل ب الرقم 07711433222"

        If Not My.Computer.FileSystem.FileExists("C:\Windows\root32.dll") Then
            MessageBox.Show(prog, "IRAQI-IT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()

        End If
        If Not My.Computer.FileSystem.FileExists("C:\Windows\system32win.dll") Then
            MessageBox.Show(prog, "IRAQI-IT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        Try
            Dim reader As New StreamReader(Application.StartupPath & "/server/image_path.txt", Encoding.Default)
            patient_image_path = reader.ReadLine
            images_path = patient_image_path
            reader.Close()

        Catch ex As Exception

        End Try

        'جلب معلومات السيرفر من التيكس
        Try
            Dim reader2 As New StreamReader(Application.StartupPath & "/server/serverInfo.txt", Encoding.Default)
            serverInfo = reader2.ReadLine
            reader2.Close()

        Catch ex As Exception

        End Try

        'جلب معلومات الايميل المرسل التيكس
        Try
            Dim reader2 As New StreamReader(Application.StartupPath & "/server/pc_type.txt", Encoding.Default)
            pc_type = reader2.ReadLine
            reader2.Close()

        Catch ex As Exception

        End Try

        'جلب معلومات الايميل من التيكس
        Try
            Dim reader3 As New StreamReader(Application.StartupPath & "/server/email.txt", Encoding.Default)
            main_email = reader3.ReadLine
            reader3.Close()

        Catch ex As Exception

        End Try

        Me.CenterToScreen()

        'ProgressPanel1.Hide()
        'tb_secret_word.PasswordChar = Convert.ToChar("*")
        tb_secret_word.Focus()



        fm_SplashScreen.Hide()
        If pc_type = "main" Then
            run_server()
        End If

        '-----------------------------

        '-----------------

        UserLookAndFeel.Default.SkinName = SkinStyle.McSkin

    End Sub

    Private Sub run_server()
        Dim proc As New System.Diagnostics.Process()
        Try
            proc = Process.Start("C:\wamp64\wampmanager.exe", "تشغيل السيرفر")
        Catch ex As Exception

        End Try
        Dim proc2 As New System.Diagnostics.Process()

        Try
            proc2 = Process.Start(Application.StartupPath & "/server/bat.bat", "تشغيل السيرفر")
        Catch ex As Exception

        End Try

        'proc = New System.Diagnostics.Process()
        'Try
        '    Dim PSI As New ProcessStartInfo(Application.StartupPath & "\serv.bat")
        '    PSI.WindowStyle = ProcessWindowStyle.Minimized 'or ProcessWindowStyle.Normal
        '    Process.Start(PSI)



        'Catch ex As Exception
        '    MessageBox.Show("يجب تشغل السيرفر")
        '    Me.Close()
        '    fm_SplashScreen.Close()

        'End Try
    End Sub


    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            by_secret_word()


        End If
    End Sub

    Private Sub tb_secret_word_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub by_secret_word()
1:
        My.Settings.Skin = UserLookAndFeel.Default.SkinName
        My.Settings.Save()
        Try
         
            'ProgressPanel1.Show()
            tb_secret_word.Hide()
            user.secret_word = tb_secret_word.Text.Trim
            If user.isExsit() Then
                'get_info()
                If user.f1.Trim = "فعال" Then

                    Login()
                    Dim content = " تم تسجيل دخول من قبل : " & user.name
                    new_event2("تسجيل دخول", content, 0)

                Else
                   
                    MessageBox.Show("تم تعطيل هذا الحساب مؤقتاً")
                    Me.Close()

                End If

            Else
                Dim content = " تم محاولة الدخول برمز خاطئ : الرمز : " & tb_secret_word.Text
                new_event2("تسجيل دخول برمز خاطئ", content, 0)

                tb_secret_word.Show()
                'ProgressPanel1.Hide()
                tb_secret_word.BackColor = Color.LightPink
            End If
        Catch ex As MySqlException
            If MessageBox.Show("Retry اعد الاتصال واضغط " & ex.Message, "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            Else
                tb_secret_word.Show()
                'ProgressPanel1.Hide()
            End If
        End Try






    End Sub

    Private Sub Login()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        '  fm_sell.Show()
        Dim permission As New Permission
        permission.getAll()


        fm_main.Show()




        Me.Hide()
    End Sub

    Private Sub ProgressPanel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupControl6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tb_secret_word_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            by_secret_word()
            tb_secret_word.Focus()

        End If
    End Sub

    Private Sub tb_secret_word_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)


        by_secret_word()



    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub get_info()
1:
        Try
            Dim store As New store
            Dim ds As New DataSet
            ds = store.all()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                store_title.Add(ds.Tables(0).Rows(i).Item("name").ToString)
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
2:

        Try
            Dim type As New type
            Dim ds2 As New DataSet
            ds2 = type.all()
            For i = 0 To ds2.Tables(0).Rows.Count - 1
                type_title.Add(ds2.Tables(0).Rows(i).Item("name").ToString)
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 2

            End If
        End Try

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)

        by_secret_word()
        tb_secret_word.Focus()
    End Sub

    Private Sub tb_secret_word_KeyUp1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            by_secret_word()
            tb_secret_word.Focus()

        End If
    End Sub


    Private Sub tb_secret_word_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        by_secret_word()
        tb_secret_word.Focus()
    End Sub

    Private Sub tb_id_EditValueChanged(sender As Object, e As EventArgs) Handles tb_secret_word.EditValueChanged

    End Sub


    Private Sub tb_secret_word_KeyUp2(sender As Object, e As KeyEventArgs) Handles tb_secret_word.KeyUp
        If e.KeyCode = Keys.Enter Then

            by_secret_word()
            tb_secret_word.Focus()

        End If
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub

    Private Sub fm_login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'by_secret_word()
        'Me.Hide()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        fm_stecker.Show()

    End Sub
End Class