Imports MySql.Data.MySqlClient

Public Class Treatment
    Public id As Integer
    Public name As String
    Public children As String
    Public children_kidney As String
    Public adult As String
    Public adult_kidney As String
    Public category As String
    Public priority As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Sub New()
        Me.id = 0
    End Sub
    Sub New(id As Integer)
        Me.id = id
        Dim query As String = "select * from treatment where id = " & id & ""
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

                Me.name = ds.Tables(0).Rows(0).Item("name").ToString
                Me.children = ds.Tables(0).Rows(0).Item("children").ToString
                Me.children_kidney = ds.Tables(0).Rows(0).Item("children_kidney").ToString
                Me.adult = ds.Tables(0).Rows(0).Item("adult").ToString
                Me.adult_kidney = ds.Tables(0).Rows(0).Item("adult_kidney").ToString
                Me.category = ds.Tables(0).Rows(0).Item("category").ToString
                Me.priority = ds.Tables(0).Rows(0).Item("priority").ToString
                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString

            Else
                conn.Close()
                MessageBox.Show("there is no treatment in this id")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get treatment" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Public Function save() As Boolean



        If Me.id = 0 Then
            Return save_new_treatment()
        Else
            Return update_treatment()
        End If






    End Function
    Public Function delete() As Boolean

        excute1("delete from treatment where id = " & Me.id & "")



        Return True
      




    End Function
    Private Function update_treatment() As Boolean

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
            SQLCommand.CommandText = "UPDATE treatment SET name = @name , children = @children , children_kidney = @children_kidney , adult = @adult , adult_kidney = @adult_kidney , category = @category , priority = @priority , f1 = @f1 , f2 = @f2 , f3 = @f3 WHERE id = @id"

            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@children", MySqlDbType.String).Value = Me.children
            SQLCommand.Parameters.Add("@children_kidney", MySqlDbType.String).Value = Me.children_kidney
            SQLCommand.Parameters.Add("@adult", MySqlDbType.String).Value = Me.adult
            SQLCommand.Parameters.Add("@adult_kidney", MySqlDbType.String).Value = Me.adult_kidney
            SQLCommand.Parameters.Add("@category", MySqlDbType.String).Value = Me.category
            SQLCommand.Parameters.Add("@priority", MySqlDbType.String).Value = Me.priority
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3


            SQLCommand.ExecuteNonQuery()

            Dim conent As String = "تم تعديل  معلومات الدواء : " & Me.name & ""
            ' add_event(conn, s_update, conent)



            conn.Close()
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Private Function save_new_treatment() As Boolean
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
            SQLCommand.CommandText = "INSERT INTO treatment(name ,children, children_kidney, adult , adult_kidney , category , priority ,f1 ,f2 ,f3 ) " +
                                                " VALUES(@name, @children , @children_kidney ,@adult, @adult_kidney ,@category , @priority,@f1,@f2,@f3)"




            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@children", MySqlDbType.String).Value = Me.children
            SQLCommand.Parameters.Add("@children_kidney", MySqlDbType.String).Value = Me.children_kidney
            SQLCommand.Parameters.Add("@adult", MySqlDbType.String).Value = Me.adult
            SQLCommand.Parameters.Add("@adult_kidney", MySqlDbType.String).Value = Me.adult_kidney
            SQLCommand.Parameters.Add("@category", MySqlDbType.String).Value = Me.category
            SQLCommand.Parameters.Add("@priority", MySqlDbType.String).Value = Me.priority
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3

            SQLCommand.ExecuteNonQuery()




            Dim conent As String = "تمت اضافة الدواء : " & Me.name & ""
            ' add_event(conn, s_add, conent)


            conn.Close()
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function



    Public Function get_all_category() As DataSet

        Dim query As String = "select * from treatment_category"
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
            MsgBox("failed to get treatment_categoty" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function


    Public Function get_all_by_category() As DataSet

        Dim query As String = "select * from treatment where name like '%" & Me.name & "%' and category like '%" & Me.category & "%' order by priority desc "
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
            MsgBox("failed to get treatment" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds

    End Function





End Class
