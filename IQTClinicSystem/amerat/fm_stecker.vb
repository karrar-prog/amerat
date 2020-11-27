Public Class fm_stecker 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PrintStecker(ComboBox1.Text & vbNewLine & tb_1.Text, TextBox1.Text)
    End Sub
    Public Sub PrintStecker(s As String, s2 As String)
        Try
            Dim fm = New fm_print_customer
            fm.p2 = s
            fm.p3 = s2

            fm.Show()
            Me.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub fm_stecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class