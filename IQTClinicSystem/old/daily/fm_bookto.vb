Public Class fm_bookto 

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        savenew()

    End Sub

    Private Sub savenew()
        Try
            Dim s As New Serjury
            s.id = Convert.ToInt32(tb_id.Text)
            s.f20 = tb20.Text
            s.f21 = tb21.Text
            s.update2()

            print_report3()
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub print_report3()

        If tb_id.Text.Trim = "" Then
            Exit Sub

        End If
1:
        Dim id As Integer
        id = Convert.ToInt32(tb_id.Text)
        Try
            Dim query = "select * from serjury where  serjury.id = " & id & ""

            'Dim query As String = "select queue.id as id , queue.test_type as test_type , queue.test_amount as test_amount  , queue.booking_number as booking_number ,  patient.name as patient_name from queue , patient where  queue.id = " & id & " and patient.id = queue.patient_id"
            Dim fm = New fm_ser_report
            fm.filePath = Application.StartupPath & "/serjury3.repx"
            fm.ds = getdatat1(query)

            fm.Show()

        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try

    End Sub

    Private Sub fm_bookto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class