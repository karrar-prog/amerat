Imports AForge.Video.DirectShow
Imports AForge.Video
Imports System.Speech.Synthesis

Public Class fm_monitoring
    Dim w As Int32 = 0


    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub fm_monitoring_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


    End Sub
    Private Sub fm_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cam_sitting()
    End Sub


    Private Sub BarStaticItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem1.ItemClick

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'If w = 0 Then
        '    Me.WindowState = FormWindowState.Maximized
        '    w = 1
        'Else
        '    Me.WindowState = FormWindowState.Normal
        '    w = 0
        'End If

        Me.Hide()




    End Sub

    Private Sub RibbonStatusBar1_Click(sender As Object, e As EventArgs) Handles RibbonStatusBar1.Click

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        change_size()

    End Sub
    Private Sub cam_sitting()
        Try
            AddHandler fm_doctor_main.CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub change_size()
        fm_doctor_main.cameras = New VideoCaptureDeviceForm

        If fm_doctor_main.cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CAMERA = fm_doctor_main.cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            fm_doctor_main.CAMERA.Start()
            cam_sitting()
        End If
    End Sub

    Private Sub BarHeaderItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick

        save_images()

    End Sub
    Private Sub sound(ByVal Str As String)
        Dim Synth As New SpeechSynthesizer()
     
        Synth.SpeakAsyncCancelAll()

        Synth.SpeakAsync(Str)

    End Sub
    Private Sub save_images()

        Try

            Dim new_path = patient_image_path & "\monitoring"
            If (Not System.IO.Directory.Exists(new_path)) Then
                System.IO.Directory.CreateDirectory(new_path)
            End If

            PictureBox1.Image.Save(new_path & "\monitoring" & generate_image_id() & ".png", Imaging.ImageFormat.Png)
            sound("done")
        Catch

            MessageBox.Show("خطأ في الحفظ ")

        End Try
    End Sub

    Private Sub BarHeaderItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem2.ItemClick
        Process.Start("explorer.exe", patient_image_path & "\monitoring")
    End Sub
End Class