Imports DevExpress.LookAndFeel
Imports System.IO

Public Class fm_setting

    Private Sub RibbonStatusBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim proc As New System.Diagnostics.Process()
        Try
            proc = Process.Start(Application.StartupPath & "/server/email.txt", "تشغيل السيرفر")
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub fm_setting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        My.Settings.Skin = UserLookAndFeel.Default.SkinName
        My.Settings.Save()
        fm_main.Show()
    End Sub

    Private Sub fm_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_values()
        tb_amount1.BackColor = Color.LightGreen
        tb_amount2.BackColor = Color.LightGreen
        UserLookAndFeel.Default.SkinName = My.Settings.Skin
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub

    Private Sub get_values()
        Try
            Dim plan1 = New Plan(1)
            Dim plan2 = New Plan(2)
            tb_title1.Text = plan1.title.ToString
            tb_amount1.Text = plan1.amount.ToString
            TextEdit1.Text = plan1.time.ToString

            tb_title2.Text = plan2.title.ToString
            tb_amount2.Text = plan2.amount.ToString
            TextEdit2.Text = plan2.time.ToString


        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Dim plan1 = New Plan(1)
            Dim plan2 = New Plan(2)
            plan1.title = tb_title1.Text
            plan1.amount = tb_amount1.EditValue.ToString
            plan1.time = TextEdit1.Text

            plan2.title = tb_title2.Text
            plan2.amount = tb_amount2.EditValue.ToString
            plan2.time = TextEdit2.Text

            plan1.save()
            plan2.save()
            tb_amount1.BackColor = Color.LightGreen
            tb_amount2.BackColor = Color.LightGreen



        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_amount1_EditValueChanged(sender As Object, e As EventArgs) Handles tb_amount1.EditValueChanged
        tb_amount1.BackColor = Color.White


    End Sub

    Private Sub tb_amount2_EditValueChanged(sender As Object, e As EventArgs) Handles tb_amount2.EditValueChanged
        tb_amount2.BackColor = Color.White

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim OpenFileDialog1 As New OpenFileDialog






        OpenFileDialog1.Title = "Please select a image"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All files|*.*|png|*.png|jpg|*.jpg"
        Dim path As String



        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            path = OpenFileDialog1.FileName

            If path.Trim <> "" Then
                Dim new_path = images_path & "\maps"
                If (Not System.IO.Directory.Exists(new_path)) Then
                    System.IO.Directory.CreateDirectory(new_path)
                End If

                Dim new_file_path = new_path & "\" & "map" & generate_image_id() & ".png "

                If Not System.IO.File.Exists(new_file_path) = True Then
                    File.Copy(path, new_file_path, True)
                End If

            Else
                MessageBox.Show("لم تقم باختيار صورة")
            End If

        End If



    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try
            Dim new_path = images_path & "\maps"
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            Process.Start("explorer.exe", new_path)


        Catch ex As Exception

        End Try
    End Sub
End Class