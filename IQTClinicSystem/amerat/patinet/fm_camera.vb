Imports AForge.Video.DirectShow
Imports AForge.Video
Imports System.IO
Imports DevExpress.LookAndFeel


Public Class fm_camera
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Public patient_id As Integer
    Public id As Integer = 0
    Public re As String = from_main

    Private Sub fm_camera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            CAMERA.Stop()
        Catch ex As Exception

        End Try
        If re = "search" Then
            fm_show_patients.Show()

        ElseIf re = "add_new" Then
            fm_add_patient.Show()
        End If

    End Sub

    Private Sub fm_camera_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            PictureBox2.Image = PictureBox1.Image
            save_images()

        End If
    End Sub
    Private Sub fm_camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLookAndFeel.Default.SkinName = My.Settings.Skin

        Me.CenterToScreen()

        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)


            CAMERA.Start()

        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If tb_type.Text.Trim = "" Then

            tb_type.BackColor = Color.LightPink
        Else
            tb_type.BackColor = Color.White
            PictureBox2.Image = PictureBox1.Image

            If re = "tanasol" Then
                save_tanasol()
            Else

                save_images()
            End If


        End If


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '  PictureBox2.Image = PictureBox1.Image
        PictureBox5.Image = PictureBox1.Image

        save_image()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Image = PictureBox1.Image

    End Sub

    Private Sub save_image()
1:

        Dim path As String = patient_image_path & "\im"
        Try
            PictureBox5.Image.Save(path & patient_id & ".png", Imaging.ImageFormat.Png)
        Catch
            Try

                File.Delete(path & patient_id & ".png")

                PictureBox5.Image.Save(path & patient_id & ".png", Imaging.ImageFormat.Png)
            Catch ex As Exception
                MessageBox.Show("الصورة مستخدمة حاليا - لايمكن الاستبدال" & ex.Message)

            End Try


        End Try


    End Sub

    Private Sub save_images()
1:

        Dim path As String = patient_image_path
        Try

            Dim new_path = path & "\p" & patient_id
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            PictureBox2.Image.Save(new_path & "\" & tb_type.Text & " " & generate_image_id() & ".png", Imaging.ImageFormat.Png)
        Catch

            MessageBox.Show("خطأ في الحفظ ")

        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick
        cam_sitting()

    End Sub

    Private Sub cam_sitting()
        Try
            CAMERA.Stop()

        Catch ex As Exception

        End Try




        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = PictureBox1.Image

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub save_tanasol()
1:

        Dim path As String = patient_image_path
        Try

            Dim new_path = images_path & "\p" & patient_id & "\tanazolat"
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            PictureBox2.Image.Save(new_path & "\تنازل-" & id & tb_type.Text & ".png", Imaging.ImageFormat.Png)
        Catch

            MessageBox.Show("خطأ في الحفظ ")

        End Try
    End Sub

End Class