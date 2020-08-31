Imports MySql.Data.MySqlClient

Public Class sell_menu_item
    Public id As Integer
    Public sell_menu_id As Decimal
    Public user_sell_it_id As Integer
    Public item_price As Integer
    Public item_id As Integer
    Public item_cost As Integer

    Public item_count As Integer
    Public item_name As String
    Public datetime As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String
    Public f6 As String
    Public f7 As String
    Public f8 As String
    Public gift As String




    Sub New(id As Integer)

        Dim query As String = "select * from sell_menu_item where id = " & id & " "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then


                Me.id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.sell_menu_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("sell_menu_id").ToString)
                Me.user_sell_it_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("user_sell_it_id").ToString)
                Me.item_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("item_id").ToString)
                Me.item_price = Convert.ToInt32(ds.Tables(0).Rows(0).Item("item_price").ToString)
                Me.item_cost = Convert.ToInt32(ds.Tables(0).Rows(0).Item("item_cost").ToString)
                Me.item_count = Convert.ToInt32(ds.Tables(0).Rows(0).Item("item_count").ToString)
                Me.item_name = (ds.Tables(0).Rows(0).Item("item_name").ToString)
                Me.datetime = (ds.Tables(0).Rows(0).Item("datetime").ToString)
                Me.f1 = (ds.Tables(0).Rows(0).Item("f1").ToString)
                Me.f2 = (ds.Tables(0).Rows(0).Item("f2").ToString)
                Me.f3 = (ds.Tables(0).Rows(0).Item("f3").ToString)
                Me.f4 = (ds.Tables(0).Rows(0).Item("f4").ToString)
                Me.f5 = (ds.Tables(0).Rows(0).Item("f5").ToString)
                Me.f6 = (ds.Tables(0).Rows(0).Item("f6").ToString)
                Me.f7 = (ds.Tables(0).Rows(0).Item("f7").ToString)
                Me.f8 = (ds.Tables(0).Rows(0).Item("f8").ToString)
                Me.gift = (ds.Tables(0).Rows(0).Item("gift").ToString)



            Else
                conn.Close()
                MessageBox.Show("there is no count")
                Exit Sub
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get item" + ex.Message)
            Exit Sub
        End Try
        conn.Close()
    End Sub
    Public Function get_menu_items_for_casher(id As Integer, date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from sell_menu_item  , sell_menu where sell_menu.user_finshed_id = " & id & " AND  CAST(datetime AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(datetime AS DATE) <= '" & date2.Value.ToShortDateString & "'   AND sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.item_name  "
        Dim ds As New DataSet()
        '
        ' AND sell_menu.user_finshed_id > 0
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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
    Public Function get_menu_total_price(id As Integer) As DataSet

        Dim query As String = "select * from sell_menu_item  where 	sell_menu_id = " & id & ""
        Dim ds As New DataSet()
        '
        ' AND sell_menu.user_finshed_id > 0
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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
    Public Function get_menu_items_all(date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from sell_menu_item  , sell_menu where CAST(datetime AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(datetime AS DATE) <= '" & date2.Value.ToShortDateString & "'   AND sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.item_name  "
        Dim ds As New DataSet()
        '
        ' AND sell_menu.user_finshed_id > 0
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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
    Public Function get_menu_items_for_user(id As Integer, date1 As DateTimePicker, date2 As DateTimePicker) As DataSet

        Dim query As String = "select * from sell_menu_item  , sell_menu where sell_menu_item.user_sell_it_id = " & id & " AND  CAST(datetime AS DATE)   >= '" & date1.Value.ToShortDateString & "' AND CAST(datetime AS DATE) <= '" & date2.Value.ToShortDateString & "'   AND sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.item_name  "
        Dim ds As New DataSet()
        '
        ' AND sell_menu.user_finshed_id > 0
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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


    Public Function get_menu_items() As DataSet

        Dim query As String = "select * , user.name as username , user.id as userid ,sell_menu.customer_id as cu_id from sell_menu_item , user , sell_menu where sell_menu_id = " & Me.sell_menu_id & " and user.id = sell_menu_item.user_sell_it_id  and sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.item_name "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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
    Public Function get_menu_items_card(c_id As Integer) As DataSet

        Dim query As String = "select * , user.name as username , user.id as userid ,sell_menu.customer_id as cu_id from sell_menu_item , user , sell_menu where sell_menu.status = 0 AND sell_menu.customer_id = " & c_id & " AND  user.id = sell_menu_item.user_sell_it_id  and sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.item_name"
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

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

    Public Function user_sell_menu_items(datetime1 As DateTimePicker, datetime2 As DateTimePicker) As DataSet

        Dim query As String = "select * from sell_menu_item where sell_menu_id = " & Me.sell_menu_id & " and datetime between '" & datetime1.Value & "' and '" & datetime2.Value & "'"
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
        ' TODO: Complete member initialization 
    End Sub

  
    Public Function delete() As Boolean

        excute1("delete from sell_menu_item where id = " & Me.id & "")
        Dim content = "تم حذف مادة من قائمة بيع" & Me.id.ToString
        new_event(e_delete, content)
        Return True





    End Function
  
    Public Function save() As Boolean

        If Me.id = 0 Then
            Return save_new()
        Else
            Return update()
        End If


    End Function

    Private Function update() As Boolean

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try





            Dim sql = <sql>
              UPDATE sell_menu_item SET
                    sell_menu_id=@sell_menu_id,
                    user_sell_it_id=@user_sell_it_id,
                    item_price=@item_price,
                    item_cost=@item_cost,
                    item_count=@item_count,
    
                    item_name =@item_name ,
                    datetime =@datetime ,
                    f1 =@f1 ,
                    f2 =@f2 ,
                    f3 =@f3 ,
                    f4 =@f4 ,
      f5 =@f5 ,
      f6 =@f6 ,
      f7 =@f7 ,
      f8 =@f8 ,
      gift =@gift 
    
              WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@sell_menu_id", MySqlDbType.Int32).Value = Me.sell_menu_id
            SQLCommand.Parameters.Add("@user_sell_it_id", MySqlDbType.Int32).Value = Me.user_sell_it_id
            SQLCommand.Parameters.Add("@item_price", MySqlDbType.Int32).Value = Me.item_price
            SQLCommand.Parameters.Add("@item_cost", MySqlDbType.Int32).Value = Me.item_cost
            SQLCommand.Parameters.Add("@item_count", MySqlDbType.Int32).Value = Me.item_count

            SQLCommand.Parameters.Add("@item_name", MySqlDbType.String).Value = Me.item_name
            SQLCommand.Parameters.Add("@datetime", MySqlDbType.String).Value = Me.datetime
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@gift", MySqlDbType.String).Value = Me.gift



            SQLCommand.ExecuteNonQuery()

        
            Dim content = "تم تعديل مادة من قائمة بيع" & "  " & Me.item_name
            new_event_opened(e_edit, content)





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

1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try

        Try



            Dim sql = <sql>
              INSERT INTO sell_menu_item
              (
                    sell_menu_id,
                    user_sell_it_id,
                    item_price,
                    item_cost,
                    item_id,
                    item_count,
                    item_name,
                    datetime,
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 ,
                   f5 ,
                   f6 ,
                   f7 ,
                   f8 ,
                   gift
                 
                 
              )
              VALUES
              (
                    @sell_menu_id,
                    @user_sell_it_id,
                    @item_price,
                    @item_cost,
                    @item_id,
                    @item_count,
                    @item_name,
                    @datetime,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 ,
                   @f5 ,
                   @f6 ,
                   @f7 ,
                   @f8 ,
                   @gift
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@sell_menu_id", MySqlDbType.Int32).Value = Me.sell_menu_id
            SQLCommand.Parameters.Add("@user_sell_it_id", MySqlDbType.Int32).Value = Me.user_sell_it_id
            SQLCommand.Parameters.Add("@item_price", MySqlDbType.Int32).Value = Me.item_price
            SQLCommand.Parameters.Add("@item_cost", MySqlDbType.Int32).Value = Me.item_cost
            SQLCommand.Parameters.Add("@item_id", MySqlDbType.Int32).Value = Me.item_id
            SQLCommand.Parameters.Add("@item_count", MySqlDbType.Int32).Value = Me.item_count
            SQLCommand.Parameters.Add("@item_name", MySqlDbType.String).Value = Me.item_name
            SQLCommand.Parameters.Add("@datetime", MySqlDbType.String).Value = Me.datetime
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@gift", MySqlDbType.String).Value = Me.gift




            SQLCommand.ExecuteNonQuery()
            Dim content = "تم اضافة مادة في قائمة بيع" & "  " & Me.item_name & "سعر" & Me.item_price & " رقم العامل " & Me.user_sell_it_id
            new_event_opened(e_add, content)



            conn.Close()

            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

    Function get_for_print() As DataSet
        Dim query As String = "select * , customer.id as customer_id , customer.name as customer_name from sell_menu_item , customer , sell_menu where sell_menu_id = " & Me.sell_menu_id & " and sell_menu.customer_id = customer.id  and sell_menu.id = sell_menu_item.sell_menu_id ORDER BY sell_menu_item.id  "
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
1:
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1

            End If
        End Try
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



End Class