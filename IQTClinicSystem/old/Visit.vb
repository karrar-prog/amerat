Imports MySql.Data.MySqlClient

Public Class Visit


    Public id As Integer
    Public patient_id As Integer
    Public doctor_id As Integer
    Public weight As Double
    Public age As Double


    Public note As String
    Public d_date As Date
    Public time As Date
    Public test_type As String
    Public test_amount As Integer

    Sub New()
        Me.id = 0
    End Sub
    Sub New(patient_id As Integer, ByVal d_date As DateTimePicker)

        Dim query As String = "select * from visit where patient_id = " & patient_id & " and `date`= '" & d_date.Value.ToShortDateString & "'"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Exit Sub
        'End Try
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then



                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.patient_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("patient_id").ToString)
                Me.doctor_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("doctor_id").ToString)
                Me.weight = Convert.ToDecimal(ds.Tables(0).Rows(0).Item("weight").ToString)
                Me.age = Convert.ToDecimal(ds.Tables(0).Rows(0).Item("age").ToString)
                Me.doctor_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("doctor_id").ToString)
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.d_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)
                Me.time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Me.test_type = ds.Tables(0).Rows(0).Item("test_type").ToString
                Me.test_amount = Convert.ToInt32(ds.Tables(0).Rows(0).Item("test_amount").ToString)

            Else
                conn.Close()

                Dim query2 As String = "select * from visit where patient_id = " & patient_id & ""
                Dim ds2 As New DataSet()
                conn = New MySqlConnection()
                conn.ConnectionString = serverInfo
                'Try
                conn.Open()
                'Catch myerror As MySqlException
                '    MsgBox("Connection to the Database Failed")
                '    Exit Sub
                'End Try
                Try
                    Dim da2 As New MySqlDataAdapter(query, conn)
                    da2.Fill(ds2)
                    If ds2.Tables(0).Rows.Count > 0 Then

                        Dim c = ds2.Tables(0).Rows.Count - 1
                        Me.id = Convert.ToInt32(ds.Tables(0).Rows(c).Item("id").ToString)
                        Me.patient_id = Convert.ToInt32(ds.Tables(0).Rows(c).Item("patient_id").ToString)
                        Me.doctor_id = Convert.ToInt32(ds.Tables(0).Rows(c).Item("doctor_id").ToString)
                        Me.weight = Convert.ToDouble(ds.Tables(0).Rows(c).Item("weight").ToString)
                        Me.age = Convert.ToDecimal(ds.Tables(0).Rows(c).Item("age").ToString)
                        Me.doctor_id = Convert.ToInt32(ds.Tables(0).Rows(c).Item("doctor_id").ToString)
                        Me.note = ds.Tables(0).Rows(c).Item("note").ToString
                        Me.d_date = Convert.ToDateTime(ds.Tables(0).Rows(c).Item("date").ToString)
                        Me.time = Convert.ToDateTime(ds.Tables(0).Rows(c).Item("time").ToString)
                        Me.test_type = ds.Tables(0).Rows(c).Item("test_type").ToString
                        Me.test_amount = Convert.ToInt32(ds.Tables(0).Rows(c).Item("test_amount").ToString)
                        MessageBox.Show("سوف يتم عرض اخر زيارة")
                    Else
                        '  MessageBox.Show("المراجع جديد لايوجد لديه ملف - يرجى اضافة زيارة لة")

                    End If



                Catch ex As Exception


                End Try

                conn.Close()







                Exit Sub
            End If
        Catch ex As Exception
                    conn.Close()
                    MsgBox("failed to get visit" + ex.Message)
                    Exit Sub
                End Try
                conn.Close()
    End Sub

    Public Function get_all() As DataSet ' most set patient_id

        Dim query As String = "select * from visit where patient_id = " & Me.patient_id & " order by id desc"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return ds
        'End Try
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()
            Return ds

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get visit" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function

    Public Function update() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return False
        'End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "UPDATE visit SET note = @note , age = @age , weight = @weight where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@note", MySqlDbType.Text).Value = Me.note
            SQLCommand.Parameters.Add("@age", MySqlDbType.Decimal).Value = Me.age
            SQLCommand.Parameters.Add("@weight", MySqlDbType.Decimal).Value = Me.weight
            SQLCommand.ExecuteNonQuery()

            Dim conent As String = "تم تعديل الزيارة للمراجع رقم : " & Me.patient_id & ""
            ' add_event(conn, s_update, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Public Function delete() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return False
        'End Try
        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "DELETE FROM visit where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.ExecuteNonQuery()
            Dim conent As String = "تم حذف الزيارة للمراجع رقم : " & Me.patient_id & ""
            ' add_event(conn, s_update, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function



End Class
