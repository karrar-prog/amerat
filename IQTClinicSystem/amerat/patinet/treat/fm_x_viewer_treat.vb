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

    Public item1 As String
    Public item2 As String
    Public item3 As String
    Public item4 As String
    Public item5 As String
    Public item6 As String
    Public item7 As String
    Public item8 As String
    Public item9 As String
    Public item10 As String


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


        report.Parameters("dar_area").Value = dar_area
        report.Parameters("contract_date").Value = contract_date
        report.Parameters("user_block_number").Value = user_block_number
        report.Parameters("user_id_number").Value = user_id_number
        report.Parameters("item1").Value = item1
        report.Parameters("item2").Value = item2
        report.Parameters("item3").Value = item3
        report.Parameters("item4").Value = item4
        report.Parameters("item6").Value = item6
        report.Parameters("item9").Value = item9
        report.Parameters("item10").Value = item10


       

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

    Private Sub DocumentViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        report.Print()
        Me.Close()

    End Sub

   
    Private Sub barDockControlLeft_Click(sender As Object, e As EventArgs) Handles barDockControlLeft.Click

    End Sub
    Private Sub barDockControlTop_Click(sender As Object, e As EventArgs) Handles barDockControlTop.Click

    End Sub
    Private Sub barDockControlBottom_Click(sender As Object, e As EventArgs) Handles barDockControlBottom.Click

    End Sub
    Private Sub barDockControlRight_Click(sender As Object, e As EventArgs) Handles barDockControlRight.Click

    End Sub
    Private Sub DocumentViewer1_Load_1(sender As Object, e As EventArgs) Handles DocumentViewer1.Load

    End Sub
End Class