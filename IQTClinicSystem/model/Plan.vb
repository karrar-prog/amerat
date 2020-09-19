Imports MySql.Data.MySqlClient

Public Class Plan


    Public id As Integer
    Public title As String

    Public amount As String
    Public time As String



    Sub New()
        Me.id = 0
    End Sub

    Sub New(id As Integer)

        Dim query As String = "select * from amount_plan where id = " & id & " "
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
                Me.title = (ds.Tables(0).Rows(0).Item("title").ToString)
                Me.amount = ds.Tables(0).Rows(0).Item("amount").ToString
                Me.time = ds.Tables(0).Rows(0).Item("time").ToString



            Else
                conn.Close()
                MessageBox.Show("there is no ")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub


    Public Function save() As Boolean

        Return update_plan()


    End Function
    Public Function delete() As Boolean

        excute1("delete from amount_plan where id = " & Me.id & "")

        Return True





    End Function
    Private Function update_plan() As Boolean

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
            SQLCommand.CommandText = "UPDATE amount_plan SET title = @title , amount = @amount , time = @time WHERE id = @id"


            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@title", MySqlDbType.String).Value = Me.title
            SQLCommand.Parameters.Add("@amount", MySqlDbType.String).Value = Me.amount
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.time

            SQLCommand.ExecuteNonQuery()



            Dim content = " تم تعديل سعر الامبير " & "  " & Me.title

            new_event_opened(e_amber, content)




            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function





End Class
