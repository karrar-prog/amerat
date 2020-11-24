Imports DevExpress.XtraBars.Docking2010
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Speech.Synthesis
Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Net.Mail
Imports System.Text
Imports System.Drawing.Text
Imports DevExpress.LookAndFeel



Public Class fm_main



    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        fm_queue.Show()
        Me.Hide()

    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)


        fm_add_patient.Show()
        Me.Hide()

    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        fm_show_patients.Show()
        Me.Hide()

    End Sub

    Private Sub fm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If pc_type = "main" Then
            store_backup()
            send_to_drive("C:\wamp64\bin\mysql\mysql5.7.19\bin\mol_db_backup.sql")
            fm_login.Close()

        Else
            fm_login.Close()


        End If



    End Sub





    Private Sub fm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
        ' sound("7")

        Me.CenterToScreen()
        tb_user.Caption = user.name
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
        'apply a vector skin and choose a palette
        'UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, SkinSvgPalette.Bezier.CherryInk)
        'disable skinning, apply the "Flat" style
        'note that some DevExpress controls (for example, the Ribbon) cannot be displayed without a skin
        'UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Flat, False, True)
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        If is_doctor() Then
            fm_treatment.Show()

            Me.Hide()

        Else
            MessageBox.Show("ليس لديك الصلاحية")
        End If


    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)
        Me.CenterToScreen()

    End Sub

    Private Sub TileItem16_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)



    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)


        If is_doctor() Then
            fm_doctor_main.Show()
            Me.Hide()
        Else
            MessageBox.Show("ليس لديك الصلاحية")
        End If


    End Sub

    Private Sub TileItem12_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
      

    End Sub

    Private Sub TileItem13_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub TileItem10_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem10.ItemClick
        If is_doctor() Then
            'Dim conn As MySqlConnection = New MySqlConnection(constr)
            'Dim cmd As MySqlCommand = New MySqlCommand
            'cmd.Connection = conn
            'conn.Open()
            'Dim mb As MySqlBackup = New MySqlBackup(cmd)
            'mb.ExportToFile("C:\backup.sql")
            'conn.Close()
        Else

        End If
    End Sub

    Private Sub TileItem9_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        copy_db()


    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        If check_perission(user_admin) Then
            fm_report_desiger.Show()
        Else
            MessageBox.Show("ليس لديك الصلاحية")
        End If


    End Sub

    Private Sub TileItem11_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub run_server()
        Dim proc As New System.Diagnostics.Process()
        Try
            proc = Process.Start("C:\wamp64\wampmanager.exe", "تشغيل السيرفر")
        Catch ex As Exception
            MessageBox.Show("يجب تشغل السيرفر")

            fm_SplashScreen.Close()
        End Try




        proc = New System.Diagnostics.Process()
        Try
            Dim PSI As New ProcessStartInfo(Application.StartupPath & "\serv.bat")
            PSI.WindowStyle = ProcessWindowStyle.Minimized 'or ProcessWindowStyle.Normal
            Process.Start(PSI)



        Catch ex As Exception
            MessageBox.Show("يجب تشغل السيرفر")
            Me.Close()
            fm_SplashScreen.Close()

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.1
        If Me.Opacity > 0.98 Then
            Me.Opacity = 1
            Timer1.Stop()

        End If
    End Sub

    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs) Handles RibbonControl2.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        fm_x_designer_treat.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TileControl1_Click(sender As Object, e As EventArgs) Handles TileControl1.Click

    End Sub

    Private Sub TileItem6_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        fmdaily.Show()

    End Sub




    Private Sub TileItem1_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick

        If hasPermission(i_cusomer) Then
            fm_show_patients.Show()
            Me.Hide()
        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If




     

        'If hasPermission(per_saller) Then
        '    fm_show_patients.Show()
        '    Me.Hide()
        'Else
        '    MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيايت")
        'End If

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick
        If check_perission(user_admin) Then
            fm_report_desiger.Show()
        Else
            MessageBox.Show("ليس لديك الصلاحية")
        End If

    End Sub

    Private Sub copy_db()
        If check_perission(user_admin) Then

            Dim new_path = "D:\backup"

            'جلب معلومات الايميل من التيكس
            Try
                Dim reader As New StreamReader(Application.StartupPath & "/server/backup_path.txt", Encoding.Default)
                new_path = reader.ReadLine
            Catch ex As Exception

            End Try
            Dim DBfile As String

            Try
                conn = New MySqlConnection()
                conn.ConnectionString = serverInfo
                'Try
                conn.Open()
                Dim backupProcess As New Process
                backupProcess.StartInfo.FileName = "cmd.exe"
                backupProcess.StartInfo.UseShellExecute = False
                backupProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.19\bin"
                backupProcess.StartInfo.RedirectStandardInput = True
                backupProcess.StartInfo.RedirectStandardOutput = True
                backupProcess.Start()

                Dim backupStream As StreamWriter = backupProcess.StandardInput
                Dim myStramreader As StreamReader = backupProcess.StandardOutput

                backupStream.WriteLine("mysqldump -u root amerat_db > amerat_db_backup.sql")
                backupStream.Close()
                backupProcess.WaitForExit()
                backupProcess.Close()
                conn.Close()

                Try
                    If (Not System.IO.Directory.Exists(new_path)) Then
                        System.IO.Directory.CreateDirectory(new_path)
                    End If
                    FileCopy("C:\wamp64\bin\mysql\mysql5.7.19\bin\amerat_db_backup.sql", new_path & "\amerat_db_backup" & Date.Now.ToShortDateString & ".sql")
                Catch
                End Try

                SaveFileDialog1.FileName = "amerat_db_backup in date " & Date.Now.ToShortDateString & ".sql"
                DBfile = SaveFileDialog1.FileName
                SaveFileDialog1.Filter = "SQL file (*.sql)[sql *.sql|ALL files *.*]"
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    FileCopy("C:\wamp64\bin\mysql\mysql5.7.19\bin\amerat_db_backup.sql", SaveFileDialog1.FileName)
                End If

            Catch ex As Exception
                MessageBox.Show("يرجى تشغيل السيرفر والدخول من الحاسبة الرئيسية")

            End Try

        Else

        End If
    End Sub
    Private Sub store_backup()

        Dim new_path = "D:\backup"

        'جلب معلومات الايميل من التيكس
        Try
            Dim reader As New StreamReader(Application.StartupPath & "/server/backup_path.txt", Encoding.Default)
            new_path = reader.ReadLine
        Catch ex As Exception

        End Try

        If check_perission(user_admin) Then
            Try
                conn = New MySqlConnection()
                conn.ConnectionString = serverInfo
                'Try
                conn.Open()
                Dim backupProcess As New Process
                backupProcess.StartInfo.FileName = "cmd.exe"
                backupProcess.StartInfo.UseShellExecute = False
                backupProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.19\bin"
                backupProcess.StartInfo.RedirectStandardInput = True
                backupProcess.StartInfo.RedirectStandardOutput = True
                backupProcess.Start()

                Dim backupStream As StreamWriter = backupProcess.StandardInput
                Dim myStramreader As StreamReader = backupProcess.StandardOutput

                backupStream.WriteLine("mysqldump -u root amerat_db > amerat_db_backup.sql")
                backupStream.Close()
                backupProcess.WaitForExit()
                backupProcess.Close()
                conn.Close()
                If (Not System.IO.Directory.Exists(new_path)) Then
                    System.IO.Directory.CreateDirectory(new_path)
                End If
                FileCopy("C:\wamp64\bin\mysql\mysql5.7.19\bin\amerat_db_backup.sql", new_path & "\amerat_db " & Date.Now.ToShortDateString & ".sql")
            Catch ex As Exception

            End Try

        Else

        End If
    End Sub

    Private Sub BarHeaderItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem5.ItemClick
        If pc_type = "main" Then
            copy_db()
        Else
            MessageBox.Show("يجب عمل النسخة الاحتياطية من الحاسبة الرئيسية")
        End If

    End Sub

    Private Sub BarHeaderItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem6.ItemClick
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        Try
            conn.Open()
            conn.Close()
            MessageBox.Show("السيرفر يعمل")
        Catch myerror As MySqlException

            If MessageBox.Show("لايمكن تشغل السيرفر", "", MessageBoxButtons.RetryCancel) = System.Windows.Forms.DialogResult.Retry Then
                run_server()

            End If
        End Try
    End Sub

    Private Sub TileItem2_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick

        If user.type = user_admin Then
            fm_user.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub send_to_drive(file As String)

        If MessageBox.Show(main_email & " سوف ترسل الى ", "هل تريد رفع النسخة الاحتياطية ؟  ", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

            fm_SplashScreen.Show()
            fm_SplashScreen.Timer1.Stop()

            Me.Hide()

            Try


                conn = New MySqlConnection()
                conn.ConnectionString = serverInfo
                conn.Open()
                Dim backupProcess As New Process
                backupProcess.StartInfo.FileName = "cmd.exe"
                backupProcess.StartInfo.UseShellExecute = False
                backupProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.19\bin"
                backupProcess.StartInfo.RedirectStandardInput = True
                backupProcess.StartInfo.RedirectStandardOutput = True
                backupProcess.Start()
                Dim backupStream As StreamWriter = backupProcess.StandardInput
                Dim myStramreader As StreamReader = backupProcess.StandardOutput
                backupStream.WriteLine("mysqldump -u root amerat_db > amerat_db_backup.sql")
                backupStream.Close()
                backupProcess.WaitForExit()
                backupProcess.Close()
                conn.Close()


                'sending to email
                Dim strBody As String
                Dim mail As New MailMessage()
                mail.To.Add(New MailAddress((main_email)))
                mail.From = New MailAddress(sender_email)
                Dim oAttch As Attachment = New Attachment(file)
                mail.Attachments.Add(oAttch)
                mail.Subject = " مرسله من الفريق العراقي للبرمجه " & Date.Now



                strBody = vbCrLf & "   عزيزي   " & user.name & " " & vbCrLf & "      تم رفع نسخه احتياطيه لنظام ادارة مول 2 كنك   " & vbCrLf

                strBody += vbCrLf & vbNewLine

                strBody += "   " & vbCrLf

                strBody += "   شكرا لك   " & vbCrLf & vbNewLine
                strBody += "  تأريخ الرفع   " & vbCrLf & vbNewLine

                strBody += Date.Now.ToShortDateString
                mail.Body = strBody
                mail.IsBodyHtml = True
                Dim client As SmtpClient = New SmtpClient("smtp.gmail.com")
                client.Port = 587
                client.EnableSsl = True
                client.Credentials = New System.Net.NetworkCredential(sender_email, sender_password)
                client.Timeout = 10000000
                client.Send(mail)
                MessageBox.Show("تم ارسال  نسختك الاحتياطية الى " & vbCrLf & vbNewLine & main_email)
                fm_login.Close()

            Catch ex As Exception
                MessageBox.Show(" فشل في الارسال  . تأكد من الاتصال بالشبكه او معلومات الايميل ..  ثم اعد المحاوله " & ex.Message)
                fm_login.Close()

            End Try

            Me.Cursor = Cursors.Arrow

        Else
            fm_login.Close()

        End If
    End Sub

    Private Sub BarStaticItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem1.ItemClick
        If user.type = user_admin Then
            fm_setting.Show()

        End If
    End Sub

    Private Sub TileItem3_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick

        If hasPermission(i_enter) Then
            MessageBox.Show("غير متوفر")
            Exit Sub


        End If

      
    End Sub

    Private Sub TileItem4_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick

        If hasPermission(i_money) Then
            fm_monitoring_event.Show()

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
            Exit Sub
        End If
    End Sub

    Private Sub TileItem5_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        fm_customer.Show()
        Me.Hide()

    End Sub

    Private Sub TileItem7_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick

        If hasPermission(i_pull) Then
            fm_view_pulls.Show()
            Me.Hide()
        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If
    End Sub

    Private Sub TileItem13_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem13.ItemClick
        If hasPermission(i_delete_pull) Then
            Try
                fm_pull_money.Close()
            Catch ex As Exception

            End Try
            fm_pull_money.Show()
            Me.Hide()

        Else
            MessageBox.Show("لاتمتلك صلاحية السحوبات")
        End If
    End Sub

    Private Sub TileItem6_ItemClick_2(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick


        If hasPermission(i_add_new_house) Then
            fm_add_patient.Show()
            fm_add_patient.CheckEdit1.Checked = True
            fm_add_patient.nu_blok_num.Enabled = True
            fm_add_patient.num_home_num.Enabled = True
            fm_add_patient.tb_blok_title.Enabled = True
            fm_add_patient.GroupControl8.Hide()
            fm_add_patient.GroupControl5.Show()
            fm_add_patient.CheckEdit1.Enabled = False

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If



    End Sub

    Private Sub TileItem5_ItemClick_2(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub TileItem5_ItemClick_3(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        fm_months.Show()
        Me.Hide()

    End Sub

    Private Sub TileItem11_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem11.ItemClick


        If hasPermission(i_fesha) Then

            Try
                fm_show_details.Close()

            Catch ex As Exception

            End Try
            fm_show_details.Show()

        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If

    
    End Sub

    Private Sub TileItem12_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem12.ItemClick
        If hasPermission(i_fesha) Then

            Try
                fm_queue.Close()

            Catch ex As Exception

            End Try
            fm_queue.Show()
        Else
            MessageBox.Show("ليس لديك الصلاحية", "مركز الصلاحيات")
        End If




      

    End Sub

    Private Sub tb_user_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tb_user.ItemClick
        fm_change_user.Show()

    End Sub
End Class