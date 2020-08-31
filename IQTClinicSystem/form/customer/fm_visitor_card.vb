Imports DevExpress.XtraReports.UI

Public Class fm_visitor_card
    Public query As String
    Public total_price As Int32
    Public final_price As Int32
    Public count As Int32

    Public ds As New DataSet
    Dim report As New XtraReport

    Private Sub fm_visitor_card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String

        filePath = Application.StartupPath & "/visitor_card.repx"
        report = XtraReport.FromFile(filePath, True)
        ds.DataSetName = "d_customer"
        ds.Tables(0).TableName = "customer"
        report.DataSource = ds
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
End Class