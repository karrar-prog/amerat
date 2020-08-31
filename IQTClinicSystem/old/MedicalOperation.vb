Imports MySql.Data.MySqlClient

Public Class MedicalOperation
    Public id As Integer
    Public patient_id As Integer
    Public visit_id As Integer
    Public title As String
    Public d_date As Date
    Public time As Date
    Public note As String
    Public content As String
    Public other As String
    Public treatment As String
    Sub New()
        Me.id = 0
        Me.treatment = "لا"
    End Sub

    Sub New(id As Integer)

        Dim query As String = "select * from medical_operation where id = " & id
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
                Me.content = ds.Tables(0).Rows(0).Item("content").ToString
                Me.title = ds.Tables(0).Rows(0).Item("title").ToString
                Me.other = ds.Tables(0).Rows(0).Item("other").ToString
                Me.treatment = ds.Tables(0).Rows(0).Item("treatment").ToString


            Else
                conn.Close()
                MessageBox.Show("there is no medical_operation")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get medical_operation" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Public Function get_all() As DataSet ' most set patient_id

        Dim query As String = "select * from medical_operation where patient_id = " & Me.patient_id & " order by id desc"
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
            MsgBox("failed to get treat" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function


    '////////////////////////////////////////

    Public Function save() As Boolean
        If id = 0 Then
            Return save_new()
        Else
            Return update()
        End If
    End Function



    Public Function save_new() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo


     
     
       


        conn.Open()

        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO medical_operation(patient_id , `note` , `content` , `other` , treatment ,`date` , `time` , title , visit_id) " +
                                                " VALUES(@patient_id ,@note , @content , @other , @treatment , @date ,@time ,@title , @visit_id)"
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.String).Value = Me.patient_id
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.String).Value = 0
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@other", MySqlDbType.String).Value = Me.other
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String).Value = Me.treatment




            SQLCommand.ExecuteNonQuery()


          
            'اضافة حدث
            Dim conent As String = "تمت اضافة حجز عملية    : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            ' add_event(conn, s_add, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try

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
            SQLCommand.CommandText = "update medical_operation set patient_id =@patient_id  , `note` = @note , `content` = @content , `other` = @other, treatment = @treatment ,`date`= @date  , `time` = @time , title = @title , visit_id = @visit_id   where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.String).Value = Me.patient_id
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.String).Value = 0
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@other", MySqlDbType.String).Value = Me.other
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String).Value = Me.treatment

            SQLCommand.ExecuteNonQuery()




            Dim conent As String = "تم تعديل معلومات العملية  للمراجع رقم : " & Me.patient_id & ""
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
        conn.Open()

        Try
            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "delete from medical_operation where id = @id"
            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.ExecuteNonQuery()
            'اضافة حدث
            Dim conent As String = "تمت حذف  العملية    : " & Me.d_date.ToShortDateString & "  للمريض رقم :" & Me.patient_id & ""
            ' add_event(conn, s_delete, conent)
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function







    '////////////////////


End Class
