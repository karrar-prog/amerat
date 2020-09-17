Imports DevExpress.XtraReports.UI

Public Class fm_call
    Dim p1 As String = "ReportStudent.repx"
    Dim p2 As String = "ssdsd "
    Dim p3 As String = "ssdsd "
    Dim p4 As String = "ssdsd "
    Public small As String = "no"
    Public query As String
    Public ds As New DataSet
    Public rep_name As String = "calling"

    Dim report As New XtraReport

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub

    Private Sub fm_call_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim filePath = Application.StartupPath & "/reports/" & rep_name & ".repx"

        report = XtraReport.FromFile(filePath, True)
        'report.Parameters.Add(i1)
        'report.Parameters.Add(i2)
        'report.Parameters.Add(i3)
        'report.Parameters.Add(i4)


        'ds = getdatat1(query)
        ds.DataSetName = "d_item"
        ds.Tables(0).TableName = "item"


        report.DataSource = ds

        DocumentViewer1.DocumentSource = report

        report.CreateDocument()
    End Sub
End Class