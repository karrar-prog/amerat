Imports DevExpress.XtraReports.UI

Public Class fm_print_customer
    Dim p1 As String = "ReportStudent.repx"
    Public p2 As String = ""
    Public p3 As String = "ssdsd "
    Dim p4 As String = "ssdsd "
    Public query As String
    Public ds As New DataSet

    Dim report As New XtraReport

    Private Sub fm_print_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String
        filePath = Application.StartupPath & "/reports/stecker.repx"
      

        report = XtraReport.FromFile(filePath, True)
    
        report.Parameters("i2").Value = p2
        report.Parameters("i3").Value = p3

        report.PrinterName = "stecker_printer"
        DocumentViewer1.DocumentSource = report

        report.CreateDocument()
        Dim pt As New ReportPrintTool(report)
        If pt.PrintDialog() Then
            report.Print()

            Me.Close()

        End If

    End Sub




 

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()

        Me.Close()

    End Sub

    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick

    End Sub
End Class