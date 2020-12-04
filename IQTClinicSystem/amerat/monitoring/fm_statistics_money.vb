Imports MySql.Data.MySqlClient

Public Class fm_statistics_money
    Dim s As New Statistics
    Dim c As String

    Private Sub LabelControl7_Click(sender As Object, e As EventArgs) Handles LabelControl7.Click

    End Sub

    Private Sub fm_statistics_money_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        li_formation()
        Try
            conn = New MySqlConnection()
            conn.ConnectionString = serverInfo
            conn.Open()
            get_dor_numbers()
            get_money_numbers()
            conn.Close()

        Catch ex As Exception

            conn.Close()

      

        End Try

        put_lists_in_dataset()
     
    End Sub

    Private Sub li_formation()
        'list
        li_dor.View = View.Details
        li_dor.Columns.Add(" ", 350)
        li_dor.Columns.Add(" ", 200)
        'list
        li_money.View = View.Details
        li_money.Columns.Add(" ", 390)
        li_money.Columns.Add(" ", 200)
    End Sub

    Private Sub get_dor_numbers()
        put_in_li_dor("حالة الدور", "")

        c = s.all_dor_not_booking

        put_in_li_dor("عدد الدور غير المحجوزة", c)

        c = s.all_dor_booking
        put_in_li_dor("عدد الدور المحجوزه", c)

        c = s.all_dor_contracts
        put_in_li_dor("عدد الدور المتعاقد عليها", c)

        c = s.all_dor_recived
        put_in_li_dor("عدد الدور المسلمة لاصحابها", c)

        c = s.all_dor
        put_in_li_dor("عدد الدور الكلي", c)


        put_in_li_dor("", "")

        put_in_li_dor("حجز الدور", "")


        c = s.all_dor_booking_without_fesha
        put_in_li_dor("عدد الدور المحجوزه بدون بفيشة", c)

        c = s.all_dor_booking_with_fesha
        put_in_li_dor("عدد الدور المحجوزه بفيشة", c)
        c = s.all_dor_booking
        put_in_li_dor("عدد الحجوزات الكلي", c)


        put_in_li_dor("", "")

        put_in_li_dor("الفييش", "")

        c = s.all_dor_booking_with_recived_fesha
        put_in_li_dor("فيشة اولى مستملة", c)
       
    End Sub

    Private Sub get_money_numbers()

        c = s.all_money
        put_in_li_money("المجموع", c)

        c = s.all_money_first
        put_in_li_money("القسم الاول", c)

        c = s.all_money_last
        put_in_li_money("القسم الثاني- المصرف", c)

        c = s.all_money_receved
        put_in_li_money("ألدفعات الاولى المستلمة", c)

        c = s.all_money_fesha_wating
        put_in_li_money("الفييش المنتظره للدفعة الاولى", c)


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub put_in_li_dor(title As String, c As String)
        li_dor.Items.Add(title)
        li_dor.Items(li_dor.Items.Count - 1).SubItems().Add(c)
    End Sub
    Private Sub put_in_li_money(title As String, c As String)
        li_money.Items.Add(title)
        li_money.Items(li_money.Items.Count - 1).SubItems().Add(c)
    End Sub

    Private Sub put_lists_in_dataset()
  
    End Sub

End Class