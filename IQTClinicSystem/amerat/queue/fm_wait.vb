Public Class fm_wait

    Private Sub fm_wait_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub

    Private Sub fm_wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
        Me.CenterToScreen()
      

        formatlist()
        search()

    End Sub

    Public Sub search()


1:
        Try
            Dim s As String = "select queue.id as queueID , queue.booking_number as booking_number  , queue.test_type as test_type , queue.booking_number as booking_number  , queue.test_min as test_min , patient.name as name  ,queue.date as date ,queue.time as time , queue.state as state ,queue.id as id  ,patient.id as patient_id from queue , patient WHERE  queue.`date` = '" & fm_queue.dt_queue.Value.ToShortDateString & "' and queue.state <>'" & entered_state & "' and patient.id = queue.patient_id order by queue.id"
            Dim DataSet = getdatat1(s)

            Dim time As New DateTimePicker
            If DataSet.Tables(0).Rows.Count > 0 Then

                lv_queue.Items.Clear()
                For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                    lv_queue.Items.Add(DataSet.Tables(0).Rows(i).Item("booking_number").ToString)
                    lv_queue.Items(i).SubItems.Add(DataSet.Tables(0).Rows(i).Item("name").ToString)
                    Dim orginal_time As New DateTimePicker
                    If i = 0 Then
                        If DataSet.Tables(0).Rows(i).Item("time").ToString <> "" Then
                            orginal_time.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("time").ToString)
                        Else
                        End If
                        lv_queue.Items(i).SubItems.Add(orginal_time.Value.ToShortTimeString)
                    Else
                        If (DataSet.Tables(0).Rows(i).Item("time").ToString = "") Then
                            time.Value = Convert.ToDateTime(lv_queue.Items(i - 1).SubItems(2).Text)
                            lv_queue.Items(i).SubItems.Add(Convert.ToString(time.Value.AddMinutes(Convert.ToDecimal(DataSet.Tables(0).Rows(i).Item("test_min").ToString)).ToShortTimeString))
                        Else
                            orginal_time.Value = Convert.ToDateTime(DataSet.Tables(0).Rows(i).Item("time").ToString)
                            lv_queue.Items(i).SubItems.Add(orginal_time.Value.ToShortTimeString)
                        End If
                    End If
                    If DataSet.Tables(0).Rows(i).Item("state").ToString = ready_state Then
                        lv_queue.Items(i).ForeColor = Color.Blue
                    End If
                Next

            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

    End Sub


    Private Sub formatlist()
        lv_queue.View = View.Details

        lv_queue.Columns.Add("الرقم", 122)

        lv_queue.Columns.Add("الاسم", 500)

        lv_queue.Columns.Add("وقت الدخول التقريبي", 500)


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_name_entered.TextChanged

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint


    End Sub
End Class