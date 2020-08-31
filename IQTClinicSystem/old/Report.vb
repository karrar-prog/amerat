Imports MySql.Data.MySqlClient

Public Class Report

    Public id As Integer
    Public patient_id As Integer
    Public visit_id As Integer
    Public other As String
    Public d_date As Date
    Public time As Date
    Public note As String
    Public lang As String
    Public disease As String
    Public disease_type As String
    Public diagnosis_date As Date
    Public treatment As String
    Public patient_name As String



    Sub New()
        Me.id = 0
    End Sub

    Sub New(id As Integer, lang As String)


        Dim query As String = "select * from medical_report where id = " & id & " and lang like '" & lang & "'"
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
                Me.other = ds.Tables(0).Rows(0).Item("other").ToString
                Me.d_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("date").ToString)
                Me.time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.lang = ds.Tables(0).Rows(0).Item("lang").ToString
                Me.disease = ds.Tables(0).Rows(0).Item("disease").ToString
                Me.disease_type = ds.Tables(0).Rows(0).Item("disease_type").ToString
                Me.diagnosis_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("diagnosis_date").ToString)
                Me.patient_name = ds.Tables(0).Rows(0).Item("patient_name").ToString
                Me.treatment = ds.Tables(0).Rows(0).Item("treatment").ToString




            Else
                conn.Close()
                MessageBox.Show("there is no medical_report")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get medical_report" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Public Function get_all_ar() As DataSet ' most set patient_id

        Dim query As String = "select * from medical_report where patient_id = " & Me.patient_id & " and lang like '" & s_arbic & "' order by id desc"
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
            MsgBox("failed to get medical_report" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function

    Public Function get_all_en() As DataSet ' most set patient_id

        Dim query As String = "select * from medical_report where patient_id = " & Me.patient_id & " and lang like '" & s_engilsh & "' order by id desc"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        conn.Open()
      
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            conn.Close()
            Return ds

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get medical_report" + ex.Message)
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
            SQLCommand.CommandText = "INSERT INTO 	medical_report(patient_id ,patient_name ,visit_id,`date` , `time`,other , note ,lang ,treatment ,disease ,disease_type,diagnosis_date) " +
                                                " VALUES(@patient_id,@patient_name,@visit_id, @date ,@time ,@other,@note ,@lang,@treatment,@disease,@disease_type,@diagnosis_date)"
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.String).Value = Me.patient_id
            SQLCommand.Parameters.Add("@patient_name", MySqlDbType.String).Value = Me.patient_name
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.String).Value = Me.visit_id
            SQLCommand.Parameters.Add("@lang", MySqlDbType.String).Value = Me.lang
            SQLCommand.Parameters.Add("@other", MySqlDbType.String).Value = Me.other
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String).Value = Me.treatment
            SQLCommand.Parameters.Add("@disease", MySqlDbType.String).Value = Me.disease
            SQLCommand.Parameters.Add("@diagnosis_date", MySqlDbType.String).Value = Me.diagnosis_date
            SQLCommand.Parameters.Add("@disease_type", MySqlDbType.String).Value = Me.disease_type
            SQLCommand.ExecuteNonQuery()
            Dim query = "select * from medical_report where time = '" & Me.time & "' and patient_id = " & Me.patient_id & ""
            Dim da = New MySqlDataAdapter(query, conn)
            Dim ds = New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                fm_doctor_main.tb_ar_r_id.Text = ds.Tables(0).Rows(0).Item("id").ToString
            End If
            'اضافة حدث
            Dim conent As String = "تمت اضافة تقرير   : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            '  add_event(conn, s_add, conent)
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
            SQLCommand.CommandText = "delete from medical_report where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id    
            SQLCommand.ExecuteNonQuery()
            'اضافة حدث
            Dim conent As String = "تمت حذف  تقرير   : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            '   add_event(conn, s_add, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function

End Class
