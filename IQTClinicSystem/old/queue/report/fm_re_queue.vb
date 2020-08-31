Public Class fm_re_queue 
    Public x As New DataSet
    Private Sub fm_re_queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim dataset As New ds_queue






        Dim cr As New re_queue


        Dim s As New DateTimePicker

        For i As Integer = 0 To x.Tables(0).Rows.Count - 1

            dataset.Tables(0).Rows.Add(x.Tables(0).Rows(0).Item("patient_name"), x.Tables(0).Rows(0).Item("booking_number"), x.Tables(0).Rows(0).Item("test_type"), x.Tables(0).Rows(0).Item("test_amount"))
        Next



        cr.SetDataSource(dataset)
        CrystalReportViewer1.ReportSource = cr



    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
End Class