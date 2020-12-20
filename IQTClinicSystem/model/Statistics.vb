Imports MySql.Data.MySqlClient
Imports System.Collections

Public Class Statistics


    Sub New()

    End Sub



    Public Function all_dor() As String
        Dim query As String = "select * from patient"
        Dim ds As New DataSet()
        Try
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then

                Return ds.Tables(0).Rows.Count.ToString


            Else
                Return "-"


                Exit Function
            End If
        Catch ex As Exception
            Return "-"

            Exit Function
        End Try

    End Function

    Public Function all_dor_not_booking() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT * FROM patient WHERE is_token = @is_token
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = "غير محجوز"

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return ds.Tables(0).Rows.Count.ToString

        Catch ex As Exception
            Return "-"

        End Try



    End Function

    Public Function all_dor_booking() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT * FROM patient WHERE is_token = @is_token
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = "حجز"

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return ds.Tables(0).Rows.Count.ToString

        Catch ex As Exception
            Return "-"

        End Try



    End Function

    Public Function all_dor_booking_with_fesha() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT * FROM patient WHERE is_token = @is_token and id in(select patient_id from queue) 
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = "حجز"

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return ds.Tables(0).Rows.Count.ToString

        Catch ex As Exception
            Return "-"

        End Try



    End Function

    Public Function all_dor_booking_with_recived_fesha() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT * FROM patient WHERE first_push_amount_arrived > 0
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
   
            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return ds.Tables(0).Rows.Count.ToString

        Catch ex As Exception
            Return "-"

        End Try



    End Function

    Function all_money() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT Sum(house_price) as p1 FROM patient
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try

    End Function

    Function all_money_first() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT Sum(first_part) as p1 FROM patient
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function

    Function all_money_last() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT Sum(last_part) as p1 FROM patient
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function

    Function all_money_receved() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT Sum(first_push_amount_arrived) as p1 FROM patient
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function

    Function all_money_fesha_wating() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT Sum(first_push_amount) as p1 FROM patient  WHERE first_push_amount > 0 and first_push_amount_arrived	= 0 and is_token != 'غير محجوز'
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function

    Function all_dor_contracts() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT COUNT(id) as p1 FROM patient  WHERE is_token = 'تعاقد'
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function
    Function all_dor_recived() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT  COUNT(id) FROM patient  WHERE is_token = 'تسليم'
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return FormatNumber(CDbl(ds.Tables(0).Rows(0).Item("p1").ToString), 0)

        Catch ex As Exception
            Return "-"

        End Try
    End Function

    Function all_dor_booking_without_fesha() As String
        Dim ds As New DataSet()

        Try

            Dim sql = <sql>
           SELECT * FROM patient WHERE is_token = @is_token and id not in(select patient_id from queue) 
         </sql>

            Dim SQLCommand As New MySqlCommand(sql.Value, conn)
            SQLCommand.Parameters.Add("@is_token", MySqlDbType.String).Value = "حجز"

            Dim da As New MySqlDataAdapter(SQLCommand)

            da.Fill(ds)

            Return ds.Tables(0).Rows.Count.ToString

        Catch ex As Exception
            Return "-"

        End Try
    End Function








End Class
