Imports MySql.Data.MySqlClient

Public Class sell_menu
    Public id As Integer
    Public customer_id As Integer
    Public user_finshed_id As Integer
    Public status As Integer
    Public discount As Integer

    Public datevalue As String
    Public timevalue As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String
    Public f6 As String
    Public f7 As String
    Public f8 As String
    Public f9 As String




    Sub New(id As Integer)

        Dim query As String = "select * from sell_menu where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.customer_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("customer_id").ToString)
                Me.user_finshed_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("user_finshed_id").ToString)
                Me.discount = Convert.ToInt32(ds.Tables(0).Rows(0).Item("discount").ToString)
                Me.status = Convert.ToInt32(ds.Tables(0).Rows(0).Item("status").ToString)
                Me.datevalue = (ds.Tables(0).Rows(0).Item("date").ToString)
                Me.timevalue = (ds.Tables(0).Rows(0).Item("time").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)
                Me.f5 = (ds.Tables(0).Rows(0).Item("f5").ToString)
                Me.f6 = (ds.Tables(0).Rows(0).Item("f6").ToString)
                Me.f7 = (ds.Tables(0).Rows(0).Item("f7").ToString)
                Me.f8 = (ds.Tables(0).Rows(0).Item("f8").ToString)
                Me.f9 = (ds.Tables(0).Rows(0).Item("f9").ToString)



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
    Public Function get_cusomer_menus_date(id As Integer, date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "SELECT *  FROM sell_menu   WHERE  customer_id = " & id & " and AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "' ORDER BY sell_menu.id DESC"
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
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function get_chasher_menus_date(id As Integer, date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "SELECT *  FROM sell_menu   WHERE   user_finshed_id = " & id & " AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "' ORDER BY sell_menu.id DESC"
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
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function get_all_menus_date(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "SELECT *  FROM sell_menu   WHERE   user_finshed_id > 0 AND  CAST(date AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(date AS DATE) <= '" & date2.Value.ToShortDateString & "' ORDER BY sell_menu.id DESC"
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
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function


    Public Function get_customer_menus() As DataSet

        Dim query As String = "SELECT * , sell_menu.id as id , customer.id as cu_id  FROM sell_menu , customer WHERE  sell_menu.customer_id =  customer.id and  customer_id = " & Me.customer_id.ToString & "  ORDER BY sell_menu.id DESC"
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
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function get_last_menus(count As Decimal) As DataSet

        Dim query As String = "SELECT * , sell_menu.id as id , customer.id as cu_id  FROM sell_menu , customer WHERE  sell_menu.customer_id =  customer.id   AND EXISTS (SELECT 1  FROM sell_menu_item  WHERE  sell_menu.id = sell_menu_item.sell_menu_id)  ORDER BY sell_menu.id DESC LIMIT " & count & " "
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
            MsgBox("failed to get" + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function user_finshed_menus() As DataSet

        Dim query As String = "select * from sell_menu where name = " & Me.user_finshed_id & ""
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
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function


    Sub New()
        Me.id = 0

    End Sub

    Public Function search_menu_id(menu_id As Integer) As DataSet

        Dim query As String = "select * from sell_menu where id  = " & menu_id & "  order by id desc"

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
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function search_customer_id(customer_id As Integer) As DataSet

        Dim query As String = "select * from sell_menu where customer_id  = " & customer_id & "    order by id desc"

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
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function


    Public Function all() As DataSet

        Dim query As String = "select * from sell_menu order by id desc"
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
            MsgBox("failed to get " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds
    End Function
    Public Function save() As Boolean

        If Me.id = 0 Then
            Return save_new()
        Else
            Return update()
        End If


    End Function
    Public Function delete() As Boolean

        excute1("delete from sell_menu where id = " & Me.id & "")

        Return True





    End Function
    Private Function update() As Boolean

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
              UPDATE sell_menu SET
               
                    status=@status,
                    date=@date,
                    user_finshed_id=@user_finshed_id,
                    time=@time,
                    discount=@discount,
                  
                    f1 =@f1 ,
                    f2 =@f2 ,
                    f3 =@f3 ,
                    f4 =@f4 ,
      f5 =@f5 ,
      f6 =@f6 ,
      f7 =@f7 ,
      f8 =@f8 ,
      f9 =@f9 
    
              WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            'SQLCommand.Parameters.Add("@customer_id", MySqlDbType.Int32).Value = Me.customer_id
            SQLCommand.Parameters.Add("@user_finshed_id", MySqlDbType.Int32).Value = Me.user_finshed_id
            SQLCommand.Parameters.Add("@status", MySqlDbType.Int32).Value = Me.status
            SQLCommand.Parameters.Add("@discount", MySqlDbType.Int32).Value = Me.discount
            SQLCommand.Parameters.Add("@customer_id", MySqlDbType.Int32).Value = Me.customer_id
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.datevalue
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.timevalue
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9



            SQLCommand.ExecuteNonQuery()







            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function

    Private Function save_new() As Boolean
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
              INSERT INTO sell_menu
              (
                    customer_id,
                    user_finshed_id,
                    status,
                    date,
                    time,
                 discount,
              
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 ,
                    f5 ,
                    f6 ,
                    f7 ,
                    f8 ,
                    f9 
                 
              )
              VALUES
              (
                    @customer_id,
                    @user_finshed_id,
                    @status,
                    @date,
                    @time,
                    @discount,
                  
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 ,
                    @f5 ,
                    @f6 ,
                    @f7 ,
                    @f8 ,
                    @f9 
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@customer_id", MySqlDbType.Int32).Value = Me.customer_id
            SQLCommand.Parameters.Add("@user_finshed_id", MySqlDbType.Int32).Value = Me.user_finshed_id
            SQLCommand.Parameters.Add("@status", MySqlDbType.Int32).Value = Me.status
            SQLCommand.Parameters.Add("@date", MySqlDbType.String).Value = Me.datevalue
            SQLCommand.Parameters.Add("@time", MySqlDbType.String).Value = Me.timevalue
            SQLCommand.Parameters.Add("@discount", MySqlDbType.Int32).Value = Me.discount

            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9



            SQLCommand.ExecuteNonQuery()



            conn.Close()

            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

  
End Class