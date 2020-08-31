Imports DevExpress.XtraReports.UI

Public Class fm_x_report_h_enter
    Public query As String
    Public ds As New DataSet
    Public filePath As String
    Dim report As New XtraReport
    Private Sub fm_x_report_h_enter_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        report = XtraReport.FromFile(filePath, True)
        ds.DataSetName = "ds_hospital"
        ds.Tables(0).TableName = "hospital_enter"
        report.DataSource = ds
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        report.Print()

    End Sub
End Class