Imports DevExpress.XtraReports.UI

Public Class fm_x_viewer_treat
    Public query As String
    Public ds As New DataSet
    Dim report As New XtraReport
    Public user_name As String
    Public user_block As String
    Public user_dar As String
    Public final_price As String
    Public arrive As String


    Public dar_area As String
    Public contract_date As String
    Public user_block_number As String
    Public user_id_number As String
   
    Public remaind As String
    Public admin_name As String
    Public path As String = "contract"



    Private Sub fm_x_viewer_treat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim filePath As String
       
        filePath = Application.StartupPath & "/reports/" & path & ".repx"
      


     
        report = XtraReport.FromFile(filePath, True)
      


        ds.DataSetName = "trat_dataset"
        ds.Tables(0).TableName = "dept"

        report.Parameters("user_name").Value = user_name
        report.Parameters("final_price").Value = final_price
        report.Parameters("arrive").Value = arrive.Trim
        report.Parameters("remaind").Value = remaind.Trim
        report.Parameters("admin_name").Value = admin_name
        report.Parameters("user_block").Value = user_block
        report.Parameters("user_dar").Value = user_dar


        report.Parameters("dar_area").Value = user_dar
        report.Parameters("contract_date").Value = contract_date
        report.Parameters("user_block_number").Value = user_block_number
        report.Parameters("user_id_number").Value = user_id_number


       

        report.DataSource = ds

        DocumentViewer1.DocumentSource = report

        report.CreateDocument()
  
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        report.Print()
        Me.Close()

    End Sub

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        report.Print()
        Me.Close()

    End Sub

   
End Class