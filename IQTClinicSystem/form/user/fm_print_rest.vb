Imports DevExpress.XtraReports.UI

Public Class fm_print_rest
    Public query As String
    Public id As Int32


    Public user_name As String
    Public path As String = "/reports/rest.repx"
    Public admin_name As String
    Public d_left As String
    Public minutes As Int32
    Public d_should As String
    Public type As String

    Dim report As New XtraReport

 
    Private Sub fm_print_rest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String
        filePath = Application.StartupPath & path
        report = XtraReport.FromFile(filePath, True)
        report.Parameters("i1").Value = id
        report.Parameters("i2").Value = user_name
        report.Parameters("i3").Value = d_left
        report.Parameters("i4").Value = minutes
        report.Parameters("i5").Value = d_should
        report.Parameters("i6").Value = admin_name
        report.Parameters("i7").Value = type
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()
        Me.Close()

    End Sub

    Private Sub fm_print_rest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        report.Print()
        Me.Close()

    End Sub
End Class