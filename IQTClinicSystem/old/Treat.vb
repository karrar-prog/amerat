Imports MySql.Data.MySqlClient

Public Class Treat

    Public id As Integer
    Public patient_id As Integer
    Public visit_id As Integer
    Public other As String
    Public d_date As Date
    Public time As Date
    Public note As String
    Public content As String
    Private _id As Integer




    Sub New()
        Me.id = 0
    End Sub

    Sub New(patient_id As Integer, visit_id As Integer)

        Dim query As String = "select * from treat where patient_id = " & patient_id & " and visit_id = " & visit_id & ""
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
                Me.d_date = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("d_date").ToString)
                Me.time = Convert.ToDateTime(ds.Tables(0).Rows(0).Item("time").ToString)
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.content = ds.Tables(0).Rows(0).Item("content").ToString


            Else
                conn.Close()
                MessageBox.Show("there is no treat")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get treat" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Sub New(id As Integer)

        Me.id = id


    End Sub
    Public Sub fill_treat_info()

        Dim query As String = "select * from treat where id = " & Me.id & ""
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


                fm_doctor_main.tb_treat_id.Text = Me.id.ToString
                fm_doctor_main.tb_treat_content.Text = Me.content.ToString
                fm_doctor_main.tb_treat_note.Text = Me.note.ToString
                fm_doctor_main.tb_treat_other.Text = Me.other.ToString
                fm_doctor_main.tb_treat_time.Text = Convert.ToDateTime(Me.time.ToString).ToLongTimeString

                fm_doctor_main.tb_treat_date.Text = Convert.ToDateTime(Me.d_date.ToString).ToShortDateString




                Dim treat_table_query As String = "select id , treatment , dose , take_number , take_number , note from treat_table where treat_id = " & id & ""
                Dim ds_treat_table As New DataSet()
                Dim datreat_table As New MySqlDataAdapter(treat_table_query, conn)
                datreat_table.Fill(ds_treat_table)
                fm_doctor_main.lv_treat_table.Items.Clear()

                If ds_treat_table.Tables(0).Rows.Count > 0 Then
                    For i = 0 To ds_treat_table.Tables(0).Rows.Count - 1

                        fm_doctor_main.lv_treat_table.Items.Add(ds_treat_table.Tables(0).Rows(i).Item("id").ToString)
                        fm_doctor_main.lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("treatment").ToString)
                        fm_doctor_main.lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("dose").ToString)
                        fm_doctor_main.lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("take_number").ToString)
                        fm_doctor_main.lv_treat_table.Items(i).SubItems.Add(ds_treat_table.Tables(0).Rows(i).Item("note").ToString)




                    Next

                End If

            Else
                conn.Close()
                MessageBox.Show("there is no treat")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get treat" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub
    Public Function get_all() As DataSet ' most set patient_id

        Dim query As String = "select * from treat where patient_id = " & Me.patient_id & " order by id desc"
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





















    Public Function save() As Boolean



        If Me.id = 0 Then
            Return save_new_treat()
        Else
            Return update_treat()
        End If






    End Function
    Public Function delete() As Boolean

        excute1("delete from treat where id = " & Me.id & "")

        Return True





    End Function
    Private Function update_treat() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try


            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "UPDATE treat SET patient_id = @patient_id , visit_id = @visit_id , other = @other , note = @note , content = @content WHERE id = @id"


            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Int32).Value = Me.patient_id
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.Int32).Value = Me.visit_id
            SQLCommand.Parameters.Add("@other", MySqlDbType.String).Value = Me.other
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content
            SQLCommand.ExecuteNonQuery()
           
            '/مسح الدواء السابق
            SQLCommand = New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "DELETE FROM treat_table WHERE treat_id = @treat_id"
            SQLCommand.Parameters.Add("@treat_id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.ExecuteNonQuery()

            '--------------------------------

            'add to treat_table

            SQLCommand = New MySqlCommand()
            SQLCommand.Parameters.Add("@treat_id", MySqlDbType.Int32)
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String)
            SQLCommand.Parameters.Add("@dose", MySqlDbType.String)
            SQLCommand.Parameters.Add("@take_number", MySqlDbType.String)
            SQLCommand.Parameters.Add("@note", MySqlDbType.String)

            For i = 0 To fm_doctor_main.lv_treat_table.Items.Count - 1
                Dim id As String = fm_doctor_main.lv_treat_table.Items(i).Text
                Dim treatment As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(1).Text
                Dim dose As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(2).Text
                Dim take_number As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(3).Text
                Dim note As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(4).Text
                SQLCommand.Connection = conn
                SQLCommand.CommandText = "INSERT INTO treat_table(treat_id ,treatment, dose, take_number , note) " +
                                                    " VALUES(@treat_id, @treatment , @dose ,@take_number, @note)"
                SQLCommand.Parameters("@treat_id").Value = Me.id
                SQLCommand.Parameters("@treatment").Value = treatment
                SQLCommand.Parameters("@dose").Value = dose
                SQLCommand.Parameters("@take_number").Value = take_number
                SQLCommand.Parameters("@note").Value = note

                SQLCommand.ExecuteNonQuery()

            Next



            '---------------------------
            'Dim conent As String = "تم تعديل  وصفة الدواء للزيارة رقم  : " & Me.visit_id & "  المراجع رقم   : " & Me.patient_id & ""
            'add_event(conn, s_update, conent)



            conn.Close()
            fm_doctor_main.l_message.Show()
            fm_doctor_main.l_message.Text = " تم التعديل نجاح   " & Date.Now.ToLongTimeString

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Sub save_in_templete(title As String)
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")


        End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn


            Dim query As String = "select * from template where title like '" & title & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                conn.Close()
                MessageBox.Show("  موجود")
                Exit Sub

            End If





            'add to tempale

            SQLCommand = New MySqlCommand()

            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO template(title) VALUES(@title)"
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = title
            SQLCommand.ExecuteNonQuery()


            'add to template treatment

            SQLCommand = New MySqlCommand()
            SQLCommand.Connection = conn
            'SQLCommand.Parameters.Add("@template", MySqlDbType.String)
            'SQLCommand.Parameters.Add("@treatment", MySqlDbType.String)
            'SQLCommand.Parameters.Add("@dose", MySqlDbType.String)
            'SQLCommand.Parameters.Add("@take_number", MySqlDbType.String)
            'SQLCommand.Parameters.Add("@note", MySqlDbType.String)

            For i = 0 To fm_add_other_required.lv_treat_table.Items.Count - 1

                Dim treatment As String = fm_add_other_required.lv_treat_table.Items(i).SubItems(1).Text
                Dim dose As String = fm_add_other_required.lv_treat_table.Items(i).SubItems(2).Text
                Dim take_number As String = fm_add_other_required.lv_treat_table.Items(i).SubItems(3).Text
                Dim note As String = fm_add_other_required.lv_treat_table.Items(i).SubItems(4).Text
                Dim months As Integer = __(fm_add_other_required.lv_treat_table.Items(i).SubItems(5).Text)


                SQLCommand.CommandText = "INSERT INTO template_treatment( template , treatment , dose , take_number , note,months ) VALUES( '" & title & "' , '" & treatment & "' , '" & dose & "' , '" & take_number & "' , '" & note & "', " & months & " )"
                'SQLCommand.Parameters("@template").Value = title
                'SQLCommand.Parameters("@treatment").Value = treatment
                'SQLCommand.Parameters("@dose").Value = dose
                'SQLCommand.Parameters("@take_number").Value = take_number
                'SQLCommand.Parameters("@note").Value = note

                SQLCommand.ExecuteNonQuery()

            Next





            Dim conent As String = "تمت اضافة مستحقات جديده جديدة بأسم   : " & title & ""
            add_event(conn, s_add, conent)


            conn.Close()
         
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub delete_templete(title As String)
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")


        End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn


            'Dim query As String = "select * from template where title like '" & title & "'"
            'Dim da As New MySqlDataAdapter(query, conn)
            'Dim ds As New DataSet()
            'da.Fill(ds)

            'If ds.Tables(0).Rows.Count > 0 Then
            '    conn.Close()
            '    MessageBox.Show("اسم الوصفة موجود")
            '    Exit Sub

            'End If





            'DELETE FROM tempale

            SQLCommand = New MySqlCommand()

            SQLCommand.Connection = conn
            SQLCommand.CommandText = "DELETE FROM template WHERE title = @title"
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = title
            SQLCommand.ExecuteNonQuery()


            'delete from template treatment

            SQLCommand = New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "DELETE FROM template_treatment WHERE template LIKE '" & title & "'"
            SQLCommand.ExecuteNonQuery()







            'Dim conent As String = "تمت حذف وصفة  بأسم   : " & title & ""
            'add_event(conn, s_add, conent)


            conn.Close()
            fm_doctor_main.l_message.Show()
            fm_doctor_main.l_message.Text = "   تمحذف الوصفة الجاهزة  بنجاح  " & Date.Now.ToLongTimeString

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Function save_new_treat() As Boolean
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try

            Dim SQLCommand As New MySqlCommand()
            SQLCommand.Connection = conn
            SQLCommand.CommandText = "INSERT INTO treat(patient_id ,visit_id, other, date , time , note , content) " +
                                                " VALUES(@patient_id, @visit_id , @other ,@date, @time ,@note , @content)"



            SQLCommand.Parameters.Add("@patient_id", MySqlDbType.Int32).Value = Me.patient_id
            SQLCommand.Parameters.Add("@visit_id", MySqlDbType.Int32).Value = Me.visit_id
            SQLCommand.Parameters.Add("@other", MySqlDbType.String).Value = Me.other
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.d_date.ToShortDateString
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time.ToLongTimeString
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@content", MySqlDbType.String).Value = Me.content



            SQLCommand.ExecuteNonQuery()

            Dim query As String = "select * from treat where time = '" & Me.time & "' and patient_id = " & Me.patient_id & ""
            Dim da As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            da.Fill(ds)
            Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item(id).ToString)

            fm_doctor_main.tb_treat_id.Text = Me.id.ToString
            fm_doctor_main.tb_treat_id.BackColor = Color.LightGreen

            'add to treat_table

            SQLCommand = New MySqlCommand()
            SQLCommand.Parameters.Add("@treat_id", MySqlDbType.Int32)
            SQLCommand.Parameters.Add("@treatment", MySqlDbType.String)
            SQLCommand.Parameters.Add("@dose", MySqlDbType.String)
            SQLCommand.Parameters.Add("@take_number", MySqlDbType.String)
            SQLCommand.Parameters.Add("@note", MySqlDbType.String)

            For i = 0 To fm_doctor_main.lv_treat_table.Items.Count - 1


                Dim id As String = fm_doctor_main.lv_treat_table.Items(0).Text
                Dim treatment As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(1).Text
                Dim dose As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(2).Text
                Dim take_number As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(3).Text
                Dim note As String = fm_doctor_main.lv_treat_table.Items(i).SubItems(4).Text




                SQLCommand.Connection = conn
                SQLCommand.CommandText = "INSERT INTO treat_table(treat_id ,treatment, dose, take_number , note) " +
                                                    " VALUES(@treat_id, @treatment , @dose ,@take_number, @note)"
                SQLCommand.Parameters("@treat_id").Value = Me.id
                SQLCommand.Parameters("@treatment").Value = treatment
                SQLCommand.Parameters("@dose").Value = dose
                SQLCommand.Parameters("@take_number").Value = take_number
                SQLCommand.Parameters("@note").Value = note
                SQLCommand.ExecuteNonQuery()

            Next





            Dim conent As String = "تمت اضافة وصفة دواء للمراجع رقم  : " & Me.visit_id & ""
            add_event(conn, s_add, conent)


            conn.Close()
            fm_doctor_main.l_message.Show()
            fm_doctor_main.l_message.Text = "تم الحفظ نجاح"
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

End Class
