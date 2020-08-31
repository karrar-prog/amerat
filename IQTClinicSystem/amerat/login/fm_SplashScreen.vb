
Public Class fm_SplashScreen
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub fm_SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        'fm_scanner.Show()

        Timer1.Interval = 1500
        Timer1.Start()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        fm_login.Show()
        Me.Hide()
        Timer1.Stop()


    End Sub

    Private Sub pictureEdit2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

  

    End Sub
End Class
