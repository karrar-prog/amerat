Imports DevExpress.XtraReports.UI

Public Class fm_print_customer
    Dim p1 As String = "ReportStudent.repx"
    Dim p2 As String = "ssdsd "
    Dim p3 As String = "ssdsd "
    Dim p4 As String = "ssdsd "
    Public query As String
    Public ds As New DataSet

    Dim report As New XtraReport

    Private Sub fm_print_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String
        filePath = Application.StartupPath & "/reports/customer.repx"
      

        report = XtraReport.FromFile(filePath, True)
    
        ds.DataSetName = "d_customer"
        ds.Tables(0).TableName = "customer"


        report.DataSource = ds

        DocumentViewer1.DocumentSource = report

        report.CreateDocument()

    End Sub




 

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()

        Me.Close()

    End Sub
End Class