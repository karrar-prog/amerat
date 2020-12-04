Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Drawing
Imports System.Speech.Synthesis
Imports System.Windows.Forms
Imports AxZKFPEngXControl
Imports DevExpress.XtraEditors

Partial Public Class fm_new_finger
    'Inherits XtraForm

    Public ZkFprint As AxZKFPEngX = New AxZKFPEngX()
    Public Shared Synth As SpeechSynthesizer = New SpeechSynthesizer()
    Public Check As Boolean

    'Public Sub New()
    '    InitializeComponent()
    '    Controls.Add(ZkFprint)
    '    InitialAxZkfp()
    'End Sub

    'Private Sub InitialAxZkfp()

    'End Sub

    Private Shared Sub play_voice(ByVal str As String)
        Synth.SpeakAsyncCancelAll()
        Synth.SpeakAsync(str)
    End Sub

    Private Sub ShowHintInfo(ByVal s As String)
        If s <> "" Then
            txtMemoHint.AppendText(s & Environment.NewLine)
        End If
    End Sub

    Private Sub ShowHintImage(ByVal iType As Integer)
        If iType = 0 Then
            imgNO.Visible = False
            imgOK.Visible = False
        ElseIf iType = 1 Then
            imgNO.Visible = False
            imgOK.Visible = True
        ElseIf iType = 2 Then
            imgNO.Visible = True
            imgOK.Visible = False
        End If
    End Sub

  

    Private Sub zkFprint_OnImageReceived(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnImageReceivedEvent)
        Dim g As Graphics = picEdite1.CreateGraphics()
        Dim bmp As Bitmap = New Bitmap(picEdite1.Width, picEdite1.Height)
        g = Graphics.FromImage(bmp)
        Dim dc As Integer = g.GetHdc().ToInt32()
        ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
        g.Dispose()
        picEdite1.Image = bmp
    End Sub

    Private Sub zkFprint_OnFeatureInfo(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnFeatureInfoEvent)
        Dim strTemp As String = String.Empty

        If ZkFprint.EnrollIndex <> 1 Then

            If ZkFprint.IsRegister Then

                If ZkFprint.EnrollIndex - 1 > 0 Then
                    strTemp = "ضع اصبعك مجدداً ({ZkFprint.EnrollIndex - 1}) مرة..."
                End If
            End If
        End If

        ShowHintInfo(strTemp)
    End Sub

    Private Sub zkFprint_OnEnroll(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnEnrollEvent)
        If e.actionResult Then
            Dim dt = SqliteDbAccess.ReturnDataTable("SELECT * FROM Users", Nothing)
            Dim dt2 = dt.Clone()

            For Each dr As DataRow In dt.Rows
                Dim regTmp As String = ZkFprint.EncodeTemplate1(e.aTemplate)

                If ZkFprint.VerFingerFromStr(regTmp, dr("FingerPrintTemplate").ToString(), False, Check) Then
                    XtraMessageBox.Show("البصمة موجوده مسبقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    ShowHintInfo("البصمة موجوده مسبقا")
                    ShowHintImage(1)
                    Dim id As Integer = Convert.ToInt32(dr("Id"))
                    dt2.Rows.Add(dr.ItemArray)
                    gvc.DataSource = dt2
                    Return
                End If
            Next

            Dim prm As SQLiteParameter() = New SQLiteParameter(2) {}
            prm(0) = New SQLiteParameter("@Name", txtName.Text)
            prm(1) = New SQLiteParameter("@Age", txtAge.Text)
            prm(2) = New SQLiteParameter("@FingerPrintTemplate", ZkFprint.EncodeTemplate1(e.aTemplate))
            SqliteDbAccess.ExcuteData("INSERT INTO Users(Name,Age,FingerPrintTemplate) VALUES (@Name,@Age,@FingerPrintTemplate)", prm)
            XtraMessageBox.Show("تمت عملية التسجيل بنجاح ", "تسجيل ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ShowHintInfo("فشل عملية التسجيل")
            XtraMessageBox.Show("فشل عملية التسجيل ", "تسجيل ", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub zkFprint_OnCapture(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnCaptureEvent)
        Dim dt As DataTable
        Dim dt2 As DataTable
        dt = SqliteDbAccess.ReturnDataTable("SELECT * FROM Users", Nothing)
        dt2 = dt.Clone()

        For Each dr As DataRow In dt.Rows
            Dim regTmp As String = ZkFprint.EncodeTemplate1(e.aTemplate)

            If ZkFprint.VerFingerFromStr(regTmp, dr("FingerPrintTemplate").ToString(), False, Check) Then
                ShowHintInfo("نجاح عمليةالتحقق")
                ShowHintImage(1)
                dt2.Rows.Add(dr.ItemArray)
                gvc.DataSource = dt2
                Return
            End If

            ShowHintImage(2)
            gvc.DataSource = Nothing
        Next
    End Sub

    Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnVerify_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

   

    Private Sub imgNO_EditValueChanged(sender As Object, e As EventArgs) Handles imgNO.EditValueChanged

    End Sub

    Private Sub fm_new_finger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ZkFprint = New AxZKFPEngX()
        Synth = New SpeechSynthesizer()

        btnEndReg.Enabled = False
        ShowHintImage(0)
        'ZkFprint.OnImageReceived += New EventHandler(Of )(zkFprint_OnImageReceived)
        'ZkFprint.OnFeatureInfo += AddressOf zkFprint_OnFeatureInfo
        'ZkFprint.OnEnroll += AddressOf zkFprint_OnEnroll
    End Sub

    Private Sub btnInitial_Click(sender As Object, e As EventArgs) Handles btnInitial.Click
        If ZkFprint.InitEngine() = 0 Then
            ZkFprint.FPEngineVersion = "9"
            ZkFprint.EnrollCount = 3
            play_voice(" sensor⁯ initialization succeeds")
            txtSerial.Text = ZkFprint.SensorSN
            txtCount.Text = ZkFprint.SensorCount.ToString()
            txtIndex.Text = ZkFprint.SensorIndex.ToString()
            btnInitial.Enabled = False
            btnEndReg.Enabled = True
            btnRegister.Enabled = True
            btnVerify.Enabled = True
            txtName.Enabled = True
            txtAge.Enabled = True
            ShowHintInfo("تم ربط الجهاز بنجاح ...")
        Else
            ShowHintInfo("فشل ربط الجهاز تاكد من توصيل الجهاز")
        End If
    End Sub
End Class
