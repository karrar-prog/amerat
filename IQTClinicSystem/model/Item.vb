Imports MySql.Data.MySqlClient

Public Class Item
    Public id As Integer
    Public name As String
    Public type As Integer

    Public barcode As String
    Public cost As Integer = 0
    Public price As Integer
    Public store_id As Integer
    Public place As String
    Public detail As String
    Public last_update As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As String
    Public f5 As String
    Public f6 As String
    Public f7 As String
    Public f8 As String
    Public f9 As String

    Friend count As Integer



    Sub New(id As Integer)

        Dim query As String = "select * from item where id = " & id & " "
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
                Me.barcode = (ds.Tables(0).Rows(0).Item("barcode").ToString)
                Me.detail = (ds.Tables(0).Rows(0).Item("detail").ToString)
                Me.place = (ds.Tables(0).Rows(0).Item("place").ToString)
                Me.last_update = (ds.Tables(0).Rows(0).Item("last_update").ToString)
                Me.store_id = Convert.ToInt32(ds.Tables(0).Rows(0).Item("store_id").ToString)
                Me.type = Convert.ToInt32(ds.Tables(0).Rows(0).Item("type").ToString)
                Me.price = Convert.ToInt32(ds.Tables(0).Rows(0).Item("price").ToString)
                Me.cost = Convert.ToInt32(ds.Tables(0).Rows(0).Item("cost").ToString)
                Me.count = Convert.ToInt32(ds.Tables(0).Rows(0).Item("count").ToString)

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

  
    Public Function barcode_check() As DataSet

     
        Dim sql = <sql>
              select * from item where barcode like @barcode
          </sql>

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try
            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@barcode", MySqlDbType.String).Value = Me.barcode
            Dim da As New MySqlDataAdapter(SQLCommand)
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
    Public Function name_check() As DataSet

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        conn.Open()
        Try

            Dim sql = <sql>
              select * from item where name like @name
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            Dim da As New MySqlDataAdapter(SQLCommand)

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

    Public Function all_search() As DataSet

        Dim query As String = "select * from item order by id desc "


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
    Public Function name_search(searshed_word As String, item As Item, limit As Decimal) As DataSet
        If searshed_word.Trim = "" Then
            searshed_word = "%"
        End If
        Dim query As String = "select * from item where name  like '%" & searshed_word & "%' order by id desc limit " & limit

        If item.type <> -1 And item.store_id = -1 Then
            query = "select * from item where name  like '%" & searshed_word & "%' and type = " & item.type & " order by id desc limit " & limit
        ElseIf item.type = -1 And item.store_id <> -1 Then
            query = "select * from item where name  like '%" & searshed_word & "%' and store_id = " & item.store_id & " order by id desc limit " & limit
        ElseIf item.type <> -1 And item.store_id <> -1 Then
            query = "select * from item where name  like '%" & searshed_word & "%' and store_id = " & item.store_id & " and type = " & item.type & " order by id desc limit " & limit

        End If

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
    Public Function id_search(searshed_word As String, item As Item) As DataSet
        If searshed_word.Trim = "" Then
            searshed_word = "%"
        End If

        Dim query = "select * from item where id  = " & searshed_word

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
    Public Function price_search(searshed_word As String, item As Item) As DataSet
        If searshed_word.Trim = "" Then
            searshed_word = "%"
        End If

        Dim query = "select * from item where price  = " & searshed_word

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

        Dim query As String = "select * from item order by id desc LIMIT 100"
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

        excute1("delete from item where id = " & Me.id & "")

        Dim content = " تم حذف مادة من المخزن" & "  " & Me.name

        new_event_opened(e_delete, content)

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
              UPDATE item SET
                    name=@name,
                    barcode=@barcode,
                    type=@type,
                    cost=@cost,
                    price=@price,
                    count=@count,
                    detail= @detail,
                    f1 =@f1 ,
                    f2 =@f2 ,
                    f3 =@f3 ,
                    f4 =@f4 ,
                     f5 =@f5 ,
                     f6 =@f6 ,
                     f7 =@f7 ,
                     f8 =@f8 ,
                     f9 =@f9 ,
                    last_update =@last_update ,
                    store_id =@store_id ,
                    place=@place
    
              WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Me.id
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@barcode", MySqlDbType.String).Value = Me.barcode
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = Me.type
            SQLCommand.Parameters.Add("@cost", MySqlDbType.Int32).Value = Me.cost
            SQLCommand.Parameters.Add("@price", MySqlDbType.Int32).Value = Me.price
            SQLCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = Me.count
            SQLCommand.Parameters.Add("@detail", MySqlDbType.String).Value = Me.detail
            SQLCommand.Parameters.Add("@place", MySqlDbType.String).Value = Me.place
            SQLCommand.Parameters.Add("@store_id", MySqlDbType.Int32).Value = Me.store_id
            SQLCommand.Parameters.Add("@last_update", MySqlDbType.String).Value = Me.last_update
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9

            Dim content = "  تم تعديل مادة " & "  " & Me.name
            new_event_opened(e_edit, content)



            SQLCommand.ExecuteNonQuery()






            conn.Close()

            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
    Public Function count_decrease(li As ListView) As Boolean



        Dim new_detail As String = ""
        Dim old_detail As String = ""
        Dim size_color As String = ""
        Dim item As Item
        Try
         
            For i = 0 To li.Items.Count - 1
                size_color = li.Items(i).SubItems(10).Text
                item = New Item(_i(li.Items(i).SubItems(11).Text))
                item.count = item.count - 1
                If item.detail.Trim <> "" And item.price > 0 Then
                    old_detail = item.detail.Trim
                    If old_detail <> "" Then
                        Dim s As String = old_detail.Trim
                        ' Split the string on the backslash character.
                        Dim parts As String() = s.Split(New Char() {"\"c})
                        ' Loop through result strings with For Each.
                        Dim part As String
                        new_detail = ""
                        For Each part In parts
                            If part.Trim = size_color Then
                                size_color = "345678909876544567890"
                            Else
                                If part.Trim <> "" Then
                                    new_detail = new_detail & part.Trim & " \ "
                                End If

                            End If
                        Next
                        item.detail = new_detail
                    End If
                End If

                item.save()
                Dim content = "  تمت  بيع المادة " & "  " & item.name
                new_event(e_sell, content)


            Next
            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try




    End Function
  







    Public Function count_increase(ID As Integer, size_color As String) As Boolean

        Dim new_detail As String = ""
        Dim old_detail As String = ""
        Dim item = New Item(ID)
        Try
            item.count = item.count + 1
            If size_color.Trim <> "" Then
                item.detail = item.detail.Trim & size_color.Trim & " \ "
            End If

            item.save()

            Dim content = "تمت  ارجاع العدد واللون للمادة " & "  " & Me.name
            new_event(e_other, content)

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        End Try
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
              UPDATE item SET    
                    count = count + @count
                 WHERE id = @id
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = ID
            SQLCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = count
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
              INSERT INTO item
              (
                    name,
                    barcode,
                    type,
                    cost,
                    price,
                    count,
                    detail,
                    f1 ,
                    f2 ,
                    f3 ,
                    f4 ,
                    last_update ,
                    store_id ,
                    place
              )
              VALUES
              (
                    @name,
                    @barcode,
                    @type,
                    @cost,
                    @price,
                    @count,
                    @detail,
                    @f1 ,
                    @f2 ,
                    @f3 ,
                    @f4 ,
                    @last_update ,
                    @store_id ,
                    @place
            
              )
          </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@barcode", MySqlDbType.String).Value = Me.barcode
            SQLCommand.Parameters.Add("@type", MySqlDbType.Int32).Value = Me.type
            SQLCommand.Parameters.Add("@cost", MySqlDbType.Int32).Value = Me.cost
            SQLCommand.Parameters.Add("@price", MySqlDbType.Int32).Value = Me.price
            SQLCommand.Parameters.Add("@count", MySqlDbType.Int32).Value = Me.count
            SQLCommand.Parameters.Add("@detail", MySqlDbType.String).Value = Me.detail
            SQLCommand.Parameters.Add("@place", MySqlDbType.String).Value = Me.place
            SQLCommand.Parameters.Add("@store_id", MySqlDbType.Int32).Value = Me.store_id
            SQLCommand.Parameters.Add("@last_update", MySqlDbType.String).Value = Me.last_update
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.String).Value = Me.f4

            SQLCommand.ExecuteNonQuery()

            Dim content = " تم اضافة مادة    " & "  " & Me.name
            new_event_opened(e_add, content)


            conn.Close()

            Return True

        Catch ex As MySqlException
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try
    End Function

   



End Class
