﻿Imports DevExpress.XtraReports.UI

Public Class fm_ser_report
    Public query As String
    Public ds As New DataSet
    Public filePath As String
    Dim report As New XtraReport
    Private Sub fm_ser_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        report = XtraReport.FromFile(filePath, True)
        ds.DataSetName = "dt_ser_enter"
        ds.Tables(0).TableName = "serjury"
        report.DataSource = ds
        DocumentViewer1.DocumentSource = report
        report.CreateDocument()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        report.Print()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        report.Print()

    End Sub

    Private Sub TabFormControl1_Click(sender As Object, e As EventArgs) Handles TabFormControl1.Click

    End Sub
End Class