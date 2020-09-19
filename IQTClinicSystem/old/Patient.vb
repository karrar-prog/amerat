Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Patient
    Public id As Integer
    Public name As String
    Public code As String

    Public finger_print As String
    Public register_date As String
    Public wieght As String
    Public gender As String
    Public phone As String
    Public note As String
    Public diagonosis As String
    Public ref_by As String
    Public f1 As String
    Public f2 As String
    Public f3 As String
    Public f4 As Integer
    Public house_price As Decimal
    Public first_part As Decimal
    Public last_part As Decimal
    Public first_present As Integer
    Public last_present As Integer
    Public water_price As Integer



    Public first_push_amount As Decimal
    Public first_push_present As Decimal
    Public first_push_amount_arrived As Decimal



    Public saller As String
    Public is_token As String
    Public token_date As String
    Public lower_name As String
    Public f5 As String
    Public f6 As String
    Public f7 As String
    Public f8 As String
    Public f9 As String
    Public f10 As String
    Public deleted As String

    Sub New(id As Integer)

        Me.id = id
        Dim query As String = "select * from patient where id = " & id & ""



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
                Me.name = ds.Tables(0).Rows(0).Item("name").ToString
                Me.code = ds.Tables(0).Rows(0).Item("code").ToString

                Me.finger_print = ds.Tables(0).Rows(0).Item("finger_print").ToString
                Me.wieght = ds.Tables(0).Rows(0).Item("wieght").ToString
                Try
                    Me.register_date = ds.Tables(0).Rows(0).Item("register_date").ToString
                Catch ex As Exception

                End Try
               
                Me.ref_by = ds.Tables(0).Rows(0).Item("ref_by").ToString
                Me.gender = ds.Tables(0).Rows(0).Item("gender").ToString
                Me.phone = ds.Tables(0).Rows(0).Item("phone").ToString
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.diagonosis = ds.Tables(0).Rows(0).Item("diagonosis").ToString

                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f4 = __(ds.Tables(0).Rows(0).Item("f4").ToString)


                Me.house_price = ___(ds.Tables(0).Rows(0).Item("house_price").ToString)
                Me.first_part = ___(ds.Tables(0).Rows(0).Item("first_part").ToString)
                Me.last_part = ___(ds.Tables(0).Rows(0).Item("last_part").ToString)
                Me.first_present = __(ds.Tables(0).Rows(0).Item("first_present").ToString)
                Me.last_present = __(ds.Tables(0).Rows(0).Item("last_present").ToString)
                Me.water_price = __(ds.Tables(0).Rows(0).Item("water_price").ToString)

                Me.saller = ds.Tables(0).Rows(0).Item("saller").ToString
                Me.is_token = ds.Tables(0).Rows(0).Item("is_token").ToString
                Try
                    Me.token_date = ds.Tables(0).Rows(0).Item("token_date").ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message & "FfFff")
                End Try

                Me.lower_name = ds.Tables(0).Rows(0).Item("lower_name").ToString

                Me.f5 = ds.Tables(0).Rows(0).Item("f5").ToString
                Me.f6 = ds.Tables(0).Rows(0).Item("f6").ToString
                Me.f7 = ds.Tables(0).Rows(0).Item("f7").ToString
                Me.f8 = ds.Tables(0).Rows(0).Item("f8").ToString
                Me.f9 = ds.Tables(0).Rows(0).Item("f9").ToString
                Me.f10 = ds.Tables(0).Rows(0).Item("f10").ToString
                Me.deleted = ds.Tables(0).Rows(0).Item("deleted").ToString

                Me.item2 = ds.Tables(0).Rows(0).Item("item2").ToString
                Me.item3 = ds.Tables(0).Rows(0).Item("item3").ToString
                Me.tb_2 = ds.Tables(0).Rows(0).Item("tb_2").ToString
                Me.tb_l_5 = ds.Tables(0).Rows(0).Item("tb_l_5").ToString
                Me.item4 = ds.Tables(0).Rows(0).Item("item4").ToString
                Me.admin_name = ds.Tables(0).Rows(0).Item("admin_name").ToString


                Me.first_push_amount = ___(ds.Tables(0).Rows(0).Item("first_push_amount").ToString)
                Me.first_push_present = ___(ds.Tables(0).Rows(0).Item("first_push_present").ToString)
                Me.first_push_amount_arrived = ___(ds.Tables(0).Rows(0).Item("first_push_amount_arrived").ToString)


            Else
                conn.Close()

                Exit Sub


            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get patient" + ex.Message)
            Exit Sub

        End Try


        conn.Close()

    End Sub
    Sub New(lataer As String, blok_num As Decimal, home_num As Decimal)

        Me.id = 0
        Dim query As String = "select * from patient where f1 like '" & lataer & "' and f2 like '" & blok_num & "' and f3 like '" & home_num & "'"



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
                Me.name = ds.Tables(0).Rows(0).Item("name").ToString
                Me.code = ds.Tables(0).Rows(0).Item("code").ToString

          
                Me.finger_print = ds.Tables(0).Rows(0).Item("finger_print").ToString
                Me.wieght = ds.Tables(0).Rows(0).Item("wieght").ToString
                Try
                    Me.register_date = ds.Tables(0).Rows(0).Item("register_date").ToString
                Catch ex As Exception

                End Try

                Me.id = __(ds.Tables(0).Rows(0).Item("id").ToString)
                Me.ref_by = ds.Tables(0).Rows(0).Item("ref_by").ToString
                Me.gender = ds.Tables(0).Rows(0).Item("gender").ToString
                Me.phone = ds.Tables(0).Rows(0).Item("phone").ToString
                Me.note = ds.Tables(0).Rows(0).Item("note").ToString
                Me.diagonosis = ds.Tables(0).Rows(0).Item("diagonosis").ToString

                Me.f1 = ds.Tables(0).Rows(0).Item("f1").ToString
                Me.f2 = ds.Tables(0).Rows(0).Item("f2").ToString
                Me.f3 = ds.Tables(0).Rows(0).Item("f3").ToString
                Me.f4 = __(ds.Tables(0).Rows(0).Item("f4").ToString)


                Me.house_price = ___(ds.Tables(0).Rows(0).Item("house_price").ToString)
                Me.first_part = ___(ds.Tables(0).Rows(0).Item("first_part").ToString)
                Me.last_part = ___(ds.Tables(0).Rows(0).Item("last_part").ToString)
                Me.first_present = __(ds.Tables(0).Rows(0).Item("first_present").ToString)
                Me.last_present = __(ds.Tables(0).Rows(0).Item("last_present").ToString)
                Me.last_present = __(ds.Tables(0).Rows(0).Item("water_price").ToString)

                Me.saller = ds.Tables(0).Rows(0).Item("saller").ToString
                Me.is_token = ds.Tables(0).Rows(0).Item("is_token").ToString
                Me.token_date = ds.Tables(0).Rows(0).Item("token_date").ToString
                Me.lower_name = ds.Tables(0).Rows(0).Item("lower_name").ToString

                Me.f5 = ds.Tables(0).Rows(0).Item("f5").ToString
                Me.f6 = ds.Tables(0).Rows(0).Item("f6").ToString
                Me.f7 = ds.Tables(0).Rows(0).Item("f7").ToString
                Me.f8 = ds.Tables(0).Rows(0).Item("f8").ToString
                Me.f9 = ds.Tables(0).Rows(0).Item("f9").ToString
                Me.f10 = ds.Tables(0).Rows(0).Item("f10").ToString
                Me.deleted = ds.Tables(0).Rows(0).Item("deleted").ToString
                Me.first_push_amount = ___(ds.Tables(0).Rows(0).Item("first_push_amount").ToString)
                Me.first_push_present = ___(ds.Tables(0).Rows(0).Item("first_push_present").ToString)
                Me.first_push_amount_arrived = ___(ds.Tables(0).Rows(0).Item("first_push_amount_arrived").ToString)


            Else
                conn.Close()

                Exit Sub


            End If

        Catch ex As Exception
            conn.Close()
            MsgBox("failed to get patient" + ex.Message)
            Exit Sub

        End Try


        conn.Close()

    End Sub


    Sub New()
        Me.id = 0
    End Sub

    Property item2 As String

    Property item3 As String

    Property tb_2 As String

    Property tb_l_5 As String

    Property item4 As String

    Property admin_name As String


    Public Function save() As Boolean



        If Me.id = 0 Then
            Return save_new_patient()
        Else
            Return update_patient()
        End If






    End Function

    Private Function save_new_patient() As Boolean


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
            SQLCommand.CommandText = "INSERT INTO patient(name ,`code` , finger_print , wieght , register_date , gender ,phone ,note ,diagonosis , ref_by , f1 , f2 , f3 , f4 , f5 , f6 , f7 , f8 , f9 , f10 ,deleted,saller,house_price,first_part,last_part,first_present,last_present,water_price,is_token , token_date,lower_name , first_push_present ,first_push_amount,first_push_amount_arrived ) " +
                                                " VALUES(@name, @code  ,  @finger_print , @wieght ,@register_date , @gender,@phone,@note,@diagonosis,@ref_by, @f1 ,@f2 ,@f3 ,@f4 ,@f5 ,@f6 ,@f7 , @f8 ,@f9 ,@f10,@deleted,@saller,@house_price,@first_part,@last_part,@first_present,@last_present,@water_price,@is_token ,@token_date,@lower_name , @first_push_present ,@first_push_amount,@first_push_amount_arrived )"

            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@code", MySqlDbType.String).Value = Me.code

            SQLCommand.Parameters.Add("@finger_print", MySqlDbType.String).Value = Me.finger_print
            SQLCommand.Parameters.Add("@wieght", MySqlDbType.String).Value = Me.wieght
            SQLCommand.Parameters.Add("@register_date", MySqlDbType.String).Value = Me.register_date
            SQLCommand.Parameters.Add("@gender", MySqlDbType.String).Value = Me.gender
            SQLCommand.Parameters.Add("@phone", MySqlDbType.String).Value = Me.phone
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@diagonosis", MySqlDbType.String).Value = Me.diagonosis
            SQLCommand.Parameters.Add("@ref_by", MySqlDbType.String).Value = Me.ref_by
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.Int32).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9
            SQLCommand.Parameters.Add("@f10", MySqlDbType.String).Value = Me.f10
            SQLCommand.Parameters.Add("@deleted", MySqlDbType.String).Value = "0"


            SQLCommand.Parameters.Add("@saller", MySqlDbType.String).Value = Me.saller
            SQLCommand.Parameters.Add("@lower_name", MySqlDbType.String).Value = Me.lower_name

            SQLCommand.Parameters.Add("@house_price", MySqlDbType.Decimal).Value = Me.house_price
            SQLCommand.Parameters.Add("@first_part", MySqlDbType.Decimal).Value = Me.first_part
            SQLCommand.Parameters.Add("@last_part", MySqlDbType.Decimal).Value = Me.last_part

            SQLCommand.Parameters.Add("@first_push_amount", MySqlDbType.Decimal).Value = Me.first_push_amount
            SQLCommand.Parameters.Add("@first_push_amount_arrived", MySqlDbType.Decimal).Value = Me.first_push_amount_arrived
            SQLCommand.Parameters.Add("@first_push_present", MySqlDbType.Decimal).Value = Me.first_push_present


            SQLCommand.Parameters.Add("@first_present", MySqlDbType.Int32).Value = Me.first_present
            SQLCommand.Parameters.Add("@last_present", MySqlDbType.Int32).Value = Me.last_present

            SQLCommand.Parameters.Add("@water_price", MySqlDbType.Int32).Value = Me.water_price

            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = Me.is_token
            SQLCommand.Parameters.Add("@token_date", MySqlDbType.String).Value = Me.token_date



            SQLCommand.ExecuteNonQuery()

       

            Dim content = " تم اضافة زبون جديد بأسم : " & Me.name & "وحجز الدار " & Me.f1 & Me.f2 & "." & Me.f3
            new_event2("حجز", content, 0)

            conn.Close()
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function
    Public Function delete() As Boolean

        If Me.id = 0 Then
            Return False

        Else
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
                SQLCommand.CommandText = "UPDATE  patient SET deleted = @deleted WHERE id = @id"
                SQLCommand.Parameters.Add("@deleted", MySqlDbType.String).Value = "1"
                SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id


                SQLCommand.ExecuteNonQuery()

           
                Dim content = " تمت الغاء تفعيل الحساب" & "  " & Me.name & " رقم الزبون " & Me.id

                new_event2("الغاء التفعيل", content, 0)

                conn.Close()
                Return True

            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End If
  

    End Function
    Public Function undelete() As Boolean

        If Me.id = 0 Then
            Return False

        Else
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
                SQLCommand.CommandText = "UPDATE  patient SET deleted = @deleted WHERE id = @id"
                SQLCommand.Parameters.Add("@deleted", MySqlDbType.String).Value = "0"
                SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id


                SQLCommand.ExecuteNonQuery()


                Dim content = " تمت تفعيل  حساب الزبون" & "  " & Me.name & " رقم الزبون " & Me.id
                new_event2("تفعيل", content, 0)

              

                conn.Close()
                Return True

            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End If


    End Function

    Private Function update_patient() As Boolean



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
            SQLCommand.CommandText = "UPDATE patient SET first_push_amount_arrived=@first_push_amount_arrived , name = @name , `code` = @code , finger_print = @finger_print , wieght = @wieght , gender = @gender , phone = @phone , note = @note , diagonosis = @diagonosis , ref_by = @ref_by " +
                " , f1 = @f1 , f2 = @f2 , f3 = @f3 , f4 = @f4 , f5 = @f5 , f6 = @f6 , f7 = @f7 , f8 = @f8 , f9 = @f9 , f10 = @f10 , deleted = @deleted,saller = @saller,house_price = @house_price,first_part= @first_part,last_part = @last_part,first_present = @first_present,last_present = @last_present,water_price =@water_price,is_token = @is_token ,lower_name=@lower_name WHERE id = @id"

            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@name", MySqlDbType.String).Value = Me.name
            SQLCommand.Parameters.Add("@code", MySqlDbType.String).Value = Me.code


            SQLCommand.Parameters.Add("@finger_print", MySqlDbType.String).Value = Me.finger_print
            SQLCommand.Parameters.Add("@wieght", MySqlDbType.String).Value = Me.wieght
              SQLCommand.Parameters.Add("@gender", MySqlDbType.String).Value = Me.gender
            SQLCommand.Parameters.Add("@phone", MySqlDbType.String).Value = Me.phone
            SQLCommand.Parameters.Add("@note", MySqlDbType.String).Value = Me.note
            SQLCommand.Parameters.Add("@diagonosis", MySqlDbType.String).Value = Me.diagonosis
            SQLCommand.Parameters.Add("@ref_by", MySqlDbType.String).Value = Me.ref_by
            SQLCommand.Parameters.Add("@f1", MySqlDbType.String).Value = Me.f1
            SQLCommand.Parameters.Add("@f2", MySqlDbType.String).Value = Me.f2
            SQLCommand.Parameters.Add("@f3", MySqlDbType.String).Value = Me.f3
            SQLCommand.Parameters.Add("@f4", MySqlDbType.Int32).Value = Me.f4
            SQLCommand.Parameters.Add("@f5", MySqlDbType.String).Value = Me.f5
            SQLCommand.Parameters.Add("@f6", MySqlDbType.String).Value = Me.f6
            SQLCommand.Parameters.Add("@f7", MySqlDbType.String).Value = Me.f7
            SQLCommand.Parameters.Add("@f8", MySqlDbType.String).Value = Me.f8
            SQLCommand.Parameters.Add("@f9", MySqlDbType.String).Value = Me.f9
            SQLCommand.Parameters.Add("@f10", MySqlDbType.String).Value = Me.f10
            SQLCommand.Parameters.Add("@deleted", MySqlDbType.String).Value = "0"

            SQLCommand.Parameters.Add("@saller", MySqlDbType.String).Value = Me.saller
            SQLCommand.Parameters.Add("@lower_name", MySqlDbType.String).Value = Me.lower_name

            SQLCommand.Parameters.Add("@house_price", MySqlDbType.Decimal).Value = Me.house_price
            SQLCommand.Parameters.Add("@first_part", MySqlDbType.Decimal).Value = Me.first_part
            SQLCommand.Parameters.Add("@last_part", MySqlDbType.Decimal).Value = Me.last_part
            SQLCommand.Parameters.Add("@first_push_amount_arrived", MySqlDbType.Decimal).Value = Me.first_push_amount_arrived


            SQLCommand.Parameters.Add("@first_present", MySqlDbType.Int32).Value = Me.first_present
            SQLCommand.Parameters.Add("@last_present", MySqlDbType.Int32).Value = Me.last_present

            SQLCommand.Parameters.Add("@water_price", MySqlDbType.Int32).Value = Me.water_price

            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = Me.is_token
         




            SQLCommand.ExecuteNonQuery()

           '  add_event(conn, s_update, conent)

        


            conn.Close()
            Return True

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
            Return False
        End Try







    End Function

    Private Function save_picture(ByVal PictureBox As PictureBox) As Boolean
        Try
            PictureBox.Image.Save(Application.StartupPath & patient_image_path & "img" & Me.id & ".png", Imaging.ImageFormat.Png)
            Return True
        Catch
            Try
                File.Delete(Application.StartupPath & patient_image_path & "img" & Me.id & ".png")
                PictureBox.Image.Save(Application.StartupPath & patient_image_path & "img" & Me.id & ".png", Imaging.ImageFormat.Png)
                Return True
            Catch
                Return False
            End Try
        End Try

    End Function
    Private Function delete_picture(ByVal PictureBox As PictureBox) As Boolean
      
            Try
                File.Delete(Application.StartupPath & patient_image_path & "img" & Me.id & ".png")
                   Return True
            Catch
                Return False
            End Try


    End Function


    Public Function generate_code() As String


        Dim patient_code As String
   
        patient_code = Convert.ToString(Date.Now.Millisecond) & Convert.ToString(Date.Now.Month) & Convert.ToString(Date.Now.Day) & Convert.ToString(Date.Now.Year) & Convert.ToString(Date.Now.Hour) & Convert.ToString(Date.Now.Minute) & Convert.ToString(Date.Now.Second)
   
        Return patient_code



    End Function

    Function findByName() As Boolean
        Me.id = id
        Dim query As String = "select * from patient where name like '" & Me.name & "'"



        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return True

        'End Try
        Try

            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                conn.Close()
                Return True

            Else
                conn.Close()
                Return False



            End If

        Catch ex As Exception
            conn.Close()
            Return True


        End Try


        conn.Close()
    End Function

    Function get_id() As String

        Dim query As String = "select * from patient where name like '" & Me.name & "'"

        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        'Try
        conn.Open()
        'Catch myerror As MySqlException
        '    MsgBox("Connection to the Database Failed")
        '    Return ""

        'End Try
        Try

            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                conn.Close()
                Return ds.Tables(0).Rows(0).Item("id").ToString


            Else
                conn.Close()
                Return ""



            End If

        Catch ex As Exception
            conn.Close()
            Return ""


        End Try


        conn.Close()
    End Function

    Sub set_contract()


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
            SQLCommand.CommandText = "UPDATE patient SET first_push_amount = @first_push_amount ,first_push_present = @first_push_present ,item2 = @item2 ,is_token = @is_token , item3 = @item3 , tb_2 = @tb_2 , tb_l_5 = @tb_l_5 , item4 = @item4 , admin_name = @admin_name WHERE id = @id"

            SQLCommand.Parameters.Add("@id", MySqlDbType.String).Value = Me.id
            SQLCommand.Parameters.Add("@item2", MySqlDbType.String).Value = Me.item2
            SQLCommand.Parameters.Add("@item3", MySqlDbType.String).Value = Me.item3
            SQLCommand.Parameters.Add("@tb_2", MySqlDbType.String).Value = Me.tb_2
            SQLCommand.Parameters.Add("@tb_l_5", MySqlDbType.String).Value = Me.tb_l_5
            SQLCommand.Parameters.Add("@item4", MySqlDbType.String).Value = Me.item4
            SQLCommand.Parameters.Add("@admin_name", MySqlDbType.String).Value = Me.admin_name
            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = Me.is_token
            SQLCommand.Parameters.Add("@first_push_amount", MySqlDbType.Decimal).Value = Me.first_push_amount
            SQLCommand.Parameters.Add("@first_push_present", MySqlDbType.Decimal).Value = Me.first_push_present



            SQLCommand.ExecuteNonQuery()

            '  add_event(conn, s_update, conent)

            Dim content = " تم التعاقد مع" & "  " & Me.name

            new_event_opened(s_update, content)


            conn.Close()
          
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)

        End Try
    End Sub



End Class
