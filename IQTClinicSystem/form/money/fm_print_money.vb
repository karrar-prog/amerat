Imports DevExpress.XtraReports.UI

Public Class fm_print_money

    Public amount As Int32

    Public ds As New DataSet
    Dim report As New XtraReport

    Public type As String
    Public time As String

    Public date1 As String

    Public user_name As String

    Public user_did_it As String



    Private Sub fm_print_money_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String

        filePath = Application.StartupPath & "/reports/money.repx"
        report = XtraReport.FromFile(filePath, True)
      
        report.Parameters("i1").Value = type
        report.Parameters("i2").Value = user_name
        report.Parameters("i3").Value = time
        report.Parameters("i4").Value = user_did_it

        report.Parameters("i5").Value = amount
        report.Parameters("i6").Value = ""
        report.Parameters("i7").Value = date1

        DocumentViewer1.DocumentSource = report
        report.CreateDocument()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub fm_print_menu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        report.Print()
        Me.Close()

    End Sub
End Class