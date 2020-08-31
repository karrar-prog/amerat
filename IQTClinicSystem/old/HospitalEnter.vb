Imports MySql.Data.MySqlClient

Public Class HospitalEnter

    Public id As Integer
    Public patient_id As Integer
    Public patient_name As String
    Public visit_id As Integer
    Public hospital As String
    Public d_date As Date
    Public time As Date
    Public note As String
    Public department As String
    Public disease As String
    Public treatment As String
    Sub New()
        Me.id = 0
    End Sub
    Sub New(id As Integer)

        Dim query As String = "select * from hospital_enter where id = " & id & ""
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
                Me.visit_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("visit_id").ToString)
                Me.hospital = ds.Tables(0).Rows(0).Item("hospital").ToString
                Me.d_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)
                Me.time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.department = ds.Tables(0).Rows(0).Item("department").ToString
                Me.disease = ds.Tables(0).Rows(0).Item("disease").ToString
                Me.treatment = ds.Tables(0).Rows(0).Item("treatment").ToString
                Me.patient_name = ds.Tables(0).Rows(0).Item("patient_name").ToString


            Else
                conn.Close()
                MessageBox.Show("there is no hospital_enter ")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get hospital_enter" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Public Function get_all() As DataSet ' most set patient_id

        Dim query As String = "select * from hospital_enter where patient_id = " & Me.patient_id & " order by id desc"
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
            MsgBox("failed to get hospital_enter" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function

    Public Function save_new() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        conn.Open()

        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO hospital_enter(patient_id , patient_name ,visit_id,`date` , `time`, hospital , note ,department ,treatment ,disease) " +
                                                " VALUES(@patient_id,@patient_name,@visit_id, @date ,@time ,@hospital,@note ,@department,@treatment,@disease)"
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.String).Value = Me.patient_id
            Try
                SQLCommand.Parameters.Add("@patient_name", MySqlDbType.String).Value = Me.patient_name

            Catch ex As Exception

            End Try
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.String).Value = Me.visit_id
            SQLCommand.Parameters.Add("@hospital", MySqlDbType.String).Value = Me.hospital
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String).Value = Me.treatment
            SQLCommand.Parameters.Add("@department", MySqlDbType.String).Value = Me.department
            SQLCommand.Parameters.Add("@disease", MySqlDbType.String).Value = Me.disease

            SQLCommand.ExecuteNonQuery()
            Dim query = "select * from hospital_enter where time = '" & Me.time & "' and patient_id = " & Me.patient_id & ""
            Dim da = New MySqlDataAdapter(query, conn)
            Dim ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                fm_doctor_main.tb_enter_id.Text = ds.Tables(0).Rows(0).Item("id").ToString
                fm_doctor_main.tb_enter_date.Text = ds.Tables(0).Rows(0).Item("date").ToString
            End If
            'اضافة حدث
            Dim conent As String = "تمت اضافة دخول مشفى    : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            ' add_event(conn, s_add, conent)
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
        conn.Open()

        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "delete from hospital_enter where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.ExecuteNonQuery()
            'اضافة حدث
            Dim conent As String = "تمت حذف  دخول مشفى    : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            ' add_event(conn, s_delete, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function


End Class
