Imports DevExpress.XtraReports.UI

Public Class fm_x_m_report_viewer
    Public query As String
    Public ds As New DataSet
    Public filePath As String
    Dim report As New XtraReport
    Private Sub fm_x_m_report_viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        report = XtraReport.FromFile(filePath, True)
        ds.DataSetName = "ar_m_report"
        ds.Tables(0).TableName = "m_r_table"
        report.DataSource = ds
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
      
    End Sub

    Private Sub DocumentViewer2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Report.Print()
        Me.Close()

    End Sub
End Class