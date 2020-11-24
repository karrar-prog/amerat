Imports DevExpress.XtraReports.UI

Public Class fm_report_viewr
    Dim p1 As String = "ReportStudent.repx"
    Dim p2 As String = "ssdsd "
    Dim p3 As String = "ssdsd "
    Dim p4 As String = "ssdsd "
    Public small As String = "no"
    Public query As String
    Public ds As New DataSet
    Public rep_name As String = "fesha"

    Dim report As New XtraReport

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub

    Private Sub fm_report_viewr_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim filePath As String
        'Dim i1 As New DevExpress.XtraReports.Parameters.Parameter
        'Dim i2 As New DevExpress.XtraReports.Parameters.Parameter
        'Dim i3 As New DevExpress.XtraReports.Parameters.Parameter
        'Dim i4 As New DevExpress.XtraReports.Parameters.Parameter


        'p1 = "/ReportStudent.repx"
        'p2 = "ssdsd "
        'p3 = "ssdsd "
        'p4 = "ssdsd "

        'i1.Name = "i1"
        'i2.Name = "i2"
        'i3.Name = "i3"
        'i4.Name = "i4"


       
        'If small = "yes" Then
        '    filePath = Application.StartupPath & "/small_barcode.repx"
        'Else
        '    filePath = Application.StartupPath & "/barcode.repx"
        'End If
        'i1.Value = p1
        'i2.Value = p2
        'i3.Value = p3
        'i4.Value = p4


        filePath = Application.StartupPath & "/reports/" & rep_name & ".repx"

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


  

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        report.Print()
        report.Print()
        report.Print()

        Me.Close()

    End Sub
End Class