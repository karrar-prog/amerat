Imports DevExpress.XtraReports.UI

Public Class fm_print_menu
    Public query As String
    Public total_price As Int32
    Public final_price As Int32
    Public count As Int32

    Public ds As New DataSet
    Dim report As New XtraReport

    Public menu_type As String
    Public casher_name As String

    Public menu_id As Integer


    Private Sub fm_print_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String

        filePath = Application.StartupPath & "/final_menu.repx"
        report = XtraReport.FromFile(filePath, True)
        ds.DataSetName = "d_sell_menu"
        ds.Tables(0).TableName = "sell_menu"
        report.Parameters("i1").Value = total_price
        report.Parameters("i2").Value = final_price
        report.Parameters("i3").Value = count
        report.Parameters("i4").Value = menu_type
        report.Parameters("i5").Value = menu_id
        report.Parameters("i6").Value = casher_name


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

    Private Sub fm_print_menu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        report.Print()
        Me.Close()

    End Sub
End Class