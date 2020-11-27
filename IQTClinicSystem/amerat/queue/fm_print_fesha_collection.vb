Imports DevExpress.XtraReports.UI

Public Class fm_print_fesha_collection
    Public p1 As String = " "
    Public p2 As String = " "
    Public p3 As String = " "
    Public p4 As String = " "
    Public p5 As String = " "
    Public p6 As String = " "
    Public p7 As Decimal
    Public p8 As String = " "
    Public p9 As String = " "
    Public p10 As String = " "

    Public small As String = "no"
    Public query As String
    Public ds As New DataSet
    Public rep_name As String = "fesha_collection"

    Dim report As New XtraReport
   
    Private Sub fm_print_fesha_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String

        filePath = Application.StartupPath & "/reports/" & rep_name & ".repx"

        report = XtraReport.FromFile(filePath, True)
        report.Parameters("i1").Value = p1
        report.Parameters("i2").Value = p2
        report.Parameters("i3").Value = p3
        report.Parameters("i4").Value = p4
        report.Parameters("i5").Value = p5
        report.Parameters("i6").Value = p6
        report.Parameters("i7").Value = p7
        report.Parameters("i8").Value = p8
        report.Parameters("i9").Value = p9
        report.Parameters("i10").Value = p10
        ds.DataSetName = "d_item"
        ds.Tables(0).TableName = "item"
        report.DataSource = ds
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()

    End Sub
End Class