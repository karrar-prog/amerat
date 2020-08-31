Imports MySql.Data.MySqlClient

Public Class Customer
    Public id As Integer
    Public name As String
    Public type As Integer

    Public note As String
  
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Friend count As Integer



    Sub New(id As Integer)

        Dim query As String = "select * from customer where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()

        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.name = (ds.Tables(0).Rows(0).Item("name").ToString)
                Me.note = (ds.Tables(0).Rows(0).Item("note").ToString)
                Me.type = Convert.ToInt32((ds.Tables(0).Rows(0).Item("type").ToString))

                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)



            Else
                Me.id = 0
                Me.type = Convert.ToInt32((ds.Tables(0).Rows(0).Item("type").ToString))

                conn.Close()
                MessageBox.Show("لايوجد زبون بهذا الرقم")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("لاتوجد  معلومات لهذا الزبون  " + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub
    Public Function name_search(name As String) As DataSet

        Dim query As String = "select * , CAST(date AS DATE) as d_date, customer.id as cu_id ,sell_menu.id as s_id from customer , sell_menu where name like '%" & name & "%'  and customer.id = sell_menu.customer_id order by date desc limit 200 "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()

        Dim da As New MySqlDataAdapter(query, conn)
        da.Fill(ds)

        conn.Close()

        Return ds


    End Function
    Public Function name_search2(name As String) As DataSet

        Dim query As String = "select *  from customer  where name like '%" & name & "%'   limit 200 "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()

        Dim da As New MySqlDataAdapter(query, conn)
        da.Fill(ds)

        conn.Close()

        Return ds


    End Function

    Sub New()
        Me.id = 0

    End Sub

    Public Function save_new() As Boolean



        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo


        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False


        End Try

        Try



            Dim sql = <sql>
              INSERT INTO customer
              (
                    name,
                    type,   
                    note,      
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
               
              )
              VALUES
              (
                    @name,
                    @type,
                    @note,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 
        
            
              )

          </sql>
            Dim d As New DateTimePicker
            Dim code As String = d.Value.Year.ToString & d.Value.Month.ToString & d.Value.Day.ToString & d.Value.Hour.ToString & d.Value.Minute.ToString & d.Value.Second.ToString & d.Value.Millisecond.ToString


            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = "زبون"
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = 0
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = ""
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = code
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = ""
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = ""
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = ""
            SQLCommand.ExecuteNonQuery()
            conn.Close()




            Dim query As String = "SELECT * FROM customer WHERE f1 LIKE '" & code & "' ORDER BY id DESC"
            Dim ds As New DataSet()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)


            If ds.Tables(0).Rows().Count > 0 Then
                Me.id = _i(ds.Tables(0).Rows(0).Item("id").ToString())
                Me.name = ds.Tables(0).Rows(0).Item("name").ToString()
                Me.type = _i(ds.Tables(0).Rows(0).Item("type").ToString())
            End If

            Return True


        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False


        End Try
    End Function
    Public Function create_customers(count As Integer) As DataSet

        Dim ds As New DataSet()

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo


        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return ds


        End Try

        Try

            For i = 1 To count
                Dim sql = <sql>
              INSERT INTO customer
              (
                    name,
                    type,   
                    note,      
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 
               
              )
              VALUES
              (
                    @name,
                    @type,
                    @note,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 
        
            
              )

          </sql>
                Dim d As New DateTimePicker
                Dim code As String = d.Value.Year.ToString & d.Value.Month.ToString & d.Value.Day.ToString & d.Value.Hour.ToString & d.Value.Minute.ToString & d.Value.Second.ToString & d.Value.Millisecond.ToString


                Dim SQLCommand As New MySqlCommand(sql.Value, conn)
                SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
                SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = 1
                SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = ""
                SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = "انشاء متعدد"
                SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = ""
                SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = ""
                SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = ""
                SQLCommand.ExecuteNonQuery()
            Next


            conn.Close()




            Dim query As String = "SELECT * FROM customer ORDER BY id DESC limit " & count

            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)



            Return ds


        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return ds


        End Try
    End Function

    Function get_for_print() As DataSet

        Dim query As String = "select * from customer where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Return ds
        End Try
        conn.Close()
    End Function

  
    Public Function update() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed")
            Return False

        End Try

        Try





            Dim sql = <sql>
              UPDATE customer SET
              
                    name=@name,
                    note=@note,
                    type=@type
                  
                  WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = 1
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.ExecuteNonQuery()







            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Function get_one(p1 As Integer) As DataSet
        Throw New NotImplementedException
    End Function

End Class
