
Imports MySql.Data.MySqlClient
Imports System.Collections
Imports System.Drawing.Text


Module DB



    Public e_amber As String = "تعديل التسعيرهف"

    Public e_add As String = "اضافة"
    Public e_edit As String = "تعديل"
    Public e_delete As String = "حذف"
    Public e_tasded As String = "تسديد"
    Public e_sell As String = "بيع"
    Public e_back As String = "استرجاع"
    Public e_other As String = "اخرى"


    Public s_dean_zabon As String = "زبون اجل"
    Public s_tawsel As String = "بيع توصيل"
    'Public s_dean_user As String = "بيع للعامل"



    Public not_chash As String = "غير مسددة"
    Public not_complete As String = "لم تكتمل"
    Public user_pull_it As String = "سحب عامل"


    Public s_btn_delete As String = "حذف هذه القائمة"
    Public s_btn_back As String = "استرجاع هذا القائمة"
    Public s_back As String = "استرجاع"


    Public per_saller As String = "بائع"
    Public per_user As String = "مستخدم"
    Public per_manage_item As String = "مدير المواد"
    Public per_add_item As String = "ادخال ألمواد"
    Public per_rests As String = "واجهة الاستراحات"
    Public per_worker As String = "واجهة العمال"
    Public per_edite_dicount As String = "تعديل الخصم"
    Public per_money As String = "جرد الدخل"
    Public per_add_user As String = "اضافة مستخدم"


    Public per_pulls_show As String = "عرض السحوبات"

    Public s_other_pull As String = "مصاريف"

    Public s_things_pull As String = "اثاث"

    Public s_back_money_pull As String = "استرجاع"

    Public s_user_pull As String = "سحب"
    Public s_recive_money As String = "تسديد سحب"
    Public s_menu_recive As String = "تسديد قائمة"
    Public s_back_money As String = "ارجاع مبلغ الى الدخل"



    Public pc_type As String = ""
    Public main_email As String = "domkarar@gmail.com"

    Public sender_email As String = "iraq.it.prog@gmail.com"
    Public sender_password As String = "331423@@331423@@"


    Public blocked_user As String = "محظور"

    Public wait_state As String = "انتظار"
    Public ready_state As String = "استعداد"
    Public cancel_state As String = "تم الغاء الحجز"
    Public entered_state As String = "1"


    Public patient_image_path As String = ""




    Public main_url As String = "http://localhost:8000/"
    Public server As String = "192.168.0.115"

    Public user As New Login
    Public s_temp As String = "اختر احد الدفعات المقترحة"
    Public s_doctor As String = "طبيب"
    Public s_emplyoee As String = "سكرتير"

    Public s_login As String = "تسجيل دخول"
    Public user_admin As Integer = 1
    Public discount_price As Integer = 12000
    Public discount_amount As Integer = 5000

    Public s_sell As String = "قائمة بيع"
    Public s_delete As String = "حذف"
    Public s_add As String = "اضافة"
    Public s_update As String = "تعديل"
    Public s_convert As String = "تحويل"
    Public s_cancel As String = "الغاء"
    Public s_arbic As String = "ar"
    Public s_engilsh As String = "en"

    Public s_type1 As String = "syrup"
    Public s_type2 As String = "vial"
    Public s_type3 As String = "amp"
    Public s_type4 As String = "cap"
    Public s_type5 As String = "tab"
    Public s_type6 As String = "cream"
    Public s_type7 As String = "oint"
    Public s_type8 As String = "gel"
    Public s_type9 As String = "drop"
    Public s_type10 As String = "Nasal Sprays"
    Public s_type11 As String = "Oral Sprays"
    Public s_type12 As String = "Nasal Wash"



    Public s_tid As String = "tid"
    Public s_bid As String = "bid"
    Public s_qid As String = "qid"
    Public s_once As String = "once"
    Public doctor_id_in_visit As Integer = 1

    Public to_lab As String = "الى المختبر"

    Public from_main As String = "0"
    Public from_doctor As String = "1"
    Public from_queue As String = "2"
    Public permissionList As New ArrayList

    Public images_path As String = patient_image_path

    '   Public serverInfo As String = "server=192.168.0.125;userid=karrar;password=123456;database=doctor_db;SslMode=none;CHARSET=utf8"


    'remote server
    Public serverInfo As String = ""

    'local
    '  Public serverInfo As String = "server=127.0.0.1;userid=user1;password=;database=doctor_db;SslMode=none;CHARSET=utf8"

    Public conn As MySqlConnection
    Public Sub open_text(my_text As String)
        Dim proc As New System.Diagnostics.Process()
        Try
            proc = Process.Start(Application.StartupPath & "/server/" & my_text & ".txt", "تشغيل السيرفر")
          
        Catch ex As Exception

        End Try
    End Sub

    Public Function permistion_titles(ByRef li As ListView) As Integer
        li.Items.Clear()
        li.Items.Add("حذف")
        li.Items(0).SubItems.Add("حذف الاستحقاقات والديون")
        li.Items.Add("الدخل")
        li.Items(1).SubItems.Add("عرض الدخل والمراقبه")
        li.Items.Add("السحوبات")
        li.Items(2).SubItems.Add("عرض واجهه اليحوبات")
        li.Items.Add("ادارة")
        li.Items(3).SubItems.Add("اضافة وتعديل معلومات المشتركين")
        li.Items.Add("تسديد")
        li.Items(4).SubItems.Add("تسديد الديون والجباية")



    End Function
    Public Function get_text(m As Decimal) As String
        If m = 1 Then
            Return "الاولى"
        ElseIf m = 2 Then
            Return "الثانية"
        ElseIf m = 3 Then
            Return "الثالثة"
        ElseIf m = 4 Then
            Return "الرابعة"
        ElseIf m = 5 Then
            Return "الخامسة"
        ElseIf m = 6 Then
            Return "السادسة"
        ElseIf m = 7 Then
            Return "السابعة"
        ElseIf m = 8 Then
            Return "الثامنة"
        ElseIf m = 9 Then
            Return "التاسعة"
        ElseIf m = 10 Then
            Return "العاشرة"

        ElseIf m = 11 Then
            Return "الحادية عشر"
        ElseIf m = 12 Then
            Return "الثانية عشر"
        ElseIf m = 13 Then
            Return "الثالثة عشر"
        ElseIf m = 14 Then
            Return "الرابعة عشر"
        ElseIf m = 15 Then
            Return "الخامسة عشر"
        ElseIf m = 16 Then
            Return "السادسة عشر"
        ElseIf m = 17 Then
            Return "السابعة عشر"
        ElseIf m = 18 Then
            Return "الثامنة عشر"
        ElseIf m = 19 Then
            Return "التاسعة عشر"
        ElseIf m = 20 Then
            Return "العشرون"
        ElseIf m = 21 Then
            Return "الحادية والعشرون"
        ElseIf m = 22 Then
            Return "الثانية والعشرون"
        ElseIf m = 23 Then
            Return "الثالثة والعشرون"
        ElseIf m = 24 Then
            Return "الرابعة والعشرون"
        Else
            Return "الدفعة"

        End If
    End Function

    Public Function ToArabicLetter(ByVal givenNumber As Double) As String
        Dim FinalOutput, Number, NumberCurrency, Fractions, FractionsCurrency As String
        Dim Tafkeet = " فقط لا غير"

        Dim WholeNumber() As String = Split(givenNumber, ".")

        NumberCurrency = NumberAsCurrency(WholeNumber(0))
        FinalOutput = NumberCurrency

        If WholeNumber.Length >= 2 Then
            If WholeNumber(1).Length.Equals(1) Then
                WholeNumber(1) = WholeNumber(1) + "0"
            ElseIf WholeNumber(1).Length > 2 Then
                WholeNumber(1) = WholeNumber(1).Substring(0, 2)
            End If

            FractionsCurrency = FractionAsCurrency(WholeNumber(1))
            FinalOutput = FinalOutput + " و" + FractionsCurrency
        End If

        If FinalOutput <> Nothing And FinalOutput <> "" Then
            FinalOutput = FinalOutput + Tafkeet
        End If

        ToArabicLetter = FinalOutput
    End Function

    Public Function SFormatNumber(ByVal X As Double) As String

        Dim Letter1, Letter2, Letter3, Letter4, Letter5, Letter6 As String
        Dim c As String = Format(Math.Floor(X), "000000000000")
        Dim C1 As Double = Val(Mid(c, 12, 1))
        Select Case C1
            Case Is = 1 : Letter1 = "واحد"
            Case Is = 2 : Letter1 = "اثنان"
            Case Is = 3 : Letter1 = "ثلاثة"
            Case Is = 4 : Letter1 = "اربعة"
            Case Is = 5 : Letter1 = "خمسة"
            Case Is = 6 : Letter1 = "ستة"
            Case Is = 7 : Letter1 = "سبعة"
            Case Is = 8 : Letter1 = "ثمانية"
            Case Is = 9 : Letter1 = "تسعة"
        End Select


        Dim C2 As Double = Val(Mid(c, 11, 1))
        Select Case C2
            Case Is = 1 : Letter2 = "عشر"
            Case Is = 2 : Letter2 = "عشرون"
            Case Is = 3 : Letter2 = "ثلاثون"
            Case Is = 4 : Letter2 = "اربعون"
            Case Is = 5 : Letter2 = "خمسون"
            Case Is = 6 : Letter2 = "ستون"
            Case Is = 7 : Letter2 = "سبعون"
            Case Is = 8 : Letter2 = "ثمانون"
            Case Is = 9 : Letter2 = "تسعون"
        End Select


        If Letter1 <> "" And C2 > 1 Then Letter2 = Letter1 + " و" + Letter2
        If Letter2 = "" Or Letter2 Is Nothing Then
            Letter2 = Letter1
        End If
        If C1 = 0 And C2 = 1 Then Letter2 = Letter2 + "ة"
        If C1 = 1 And C2 = 1 Then Letter2 = "احدى عشر"
        If C1 = 2 And C2 = 1 Then Letter2 = "اثنى عشر"
        If C1 > 2 And C2 = 1 Then Letter2 = Letter1 + " " + Letter2
        Dim C3 As Double = Val(Mid(c, 10, 1))
        Select Case C3
            Case Is = 1 : Letter3 = "مائة"
            Case Is = 2 : Letter3 = "مائتان"
            Case Is > 2 : Letter3 = Microsoft.VisualBasic.Left(SFormatNumber(C3), Len(SFormatNumber(C3)) - 1) + "مائة"
        End Select
        If Letter3 <> "" And Letter2 <> "" Then Letter3 = Letter3 + " و" + Letter2
        If Letter3 = "" Then Letter3 = Letter2


        Dim C4 As Double = Val(Mid(c, 7, 3))
        Select Case C4
            Case Is = 1 : Letter4 = "الف"
            Case Is = 2 : Letter4 = "الفان"
            Case 3 To 10 : Letter4 = SFormatNumber(C4) + " آلاف"
            Case Is > 10 : Letter4 = SFormatNumber(C4) + " الف"
        End Select
        If Letter4 <> "" And Letter3 <> "" Then Letter4 = Letter4 + " و" + Letter3
        If Letter4 = "" Then Letter4 = Letter3
        Dim C5 As Double = Val(Mid(c, 4, 3))
        Select Case C5
            Case Is = 1 : Letter5 = "مليون"
            Case Is = 2 : Letter5 = "مليونان"
            Case 3 To 10 : Letter5 = SFormatNumber(C5) + " ملايين"
            Case Is > 10 : Letter5 = SFormatNumber(C5) + " مليون"
        End Select
        If Letter5 <> "" And Letter4 <> "" Then Letter5 = Letter5 + " و" + Letter4
        If Letter5 = "" Then Letter5 = Letter4


        Dim C6 As Double = Val(Mid(c, 1, 3))
        Select Case C6
            Case Is = 1 : Letter6 = "مليار"
            Case Is = 2 : Letter6 = "ملياران"
            Case Is > 2 : Letter6 = SFormatNumber(C6) + " مليار"
        End Select
        If Letter6 <> "" And Letter5 <> "" Then Letter6 = Letter6 + " و" + Letter5
        If Letter6 = "" Then Letter6 = Letter5

        SFormatNumber = Letter6

    End Function

    Public Function NumberAsCurrency(ByVal givenNumber As Double) As String
        Dim Number, Currency As String

        Number = SFormatNumber(givenNumber)

        If Number <> "" And Number <> Nothing And givenNumber <= 2 Then
            If Number.StartsWith("واحد") Then
                Number = Number.Substring(4)
            ElseIf Number.StartsWith("اثنان") Then
                Number = Number.Substring(5)
            End If
        End If

        Select Case CDbl(givenNumber)
            Case Is = Nothing : Currency = ""
            Case Is = 2 : Currency = " ديناران عراقي"
            Case 3 To 10 : Currency = " دنانير عراقي"
            Case Else : Currency = " دينار عراقي"
        End Select

        NumberAsCurrency = Number + " " + Currency

    End Function

    Public Function FractionAsCurrency(ByVal givenNumber As Double) As String
        Dim Fractions, Currency As String

        Fractions = SFormatNumber(givenNumber)

        If Fractions <> "" And Fractions <> Nothing And givenNumber <= 2 Then
            If Fractions.StartsWith("واحد") Then
                Fractions = Fractions.Substring(4)
            ElseIf Fractions.StartsWith("اثنان") Then
                Fractions = Fractions.Substring(5)
            End If
        End If

        Select Case CDbl(givenNumber)
            Case Is = Nothing : Currency = ""
            Case Is = 2 : Currency = " فلسان"
            Case 3 To 10 : Currency = " فلوس"
            Case Else : Currency = " فلساً"
        End Select

        FractionAsCurrency = Fractions + " " + Currency

    End Function
    Public Function _i(p1 As String) As Integer
        Try
            Return Convert.ToInt32(p1)

        Catch ex As Exception

        End Try

    End Function
    Public Function __(p1 As String) As Integer
        Try
            Return Convert.ToInt32(p1)

        Catch ex As Exception

        End Try

    End Function
    Public Function ___(p1 As String) As Decimal
        Try
            Return Convert.ToDecimal(p1)

        Catch ex As Exception

        End Try

    End Function
    'Public Sub ff(ByRef label As Label)
    '    Dim pfc As New PrivateFontCollection()
    '    pfc.AddFontFile(Application.StartupPath & "/my_font2.ttf")

    '    label.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)


    'End Sub
    'Public Sub xff(labelControl As DevExpress.XtraEditors.LabelControl)
    '    Dim pfc As New PrivateFontCollection()
    '    pfc.AddFontFile(Application.StartupPath & "/my_font2.ttf")
    '    labelControl.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)

    'End Sub
    Public Function hasPermission(permission As String) As Boolean

        Dim perTitle As String
        For Each perTitle In permissionList
            If perTitle = permission Then
                Return True
            End If
        Next
        If user.type = 1 Then
            Return True
        End If
        Return False
    End Function

    Public Sub Combo_format(ByVal cb_category As ComboBox)
        Dim plan = New DataSet

        plan = getdatat1("select * from treatment_category")
        If plan.Tables(0).Rows.Count > 0 Then
            cb_category.Items.Add("%")
            For i = 0 To plan.Tables(0).Rows.Count - 1
                cb_category.Items.Add(plan.Tables(0).Rows(i).Item("name").ToString)
            Next
        End If
        cb_category.SelectedItem = cb_category.Items(0)

    End Sub

    Public Function generate_image_id() As String


        Dim image_id As String

        image_id = Convert.ToString(Date.Now.Year) & "-" & Convert.ToString(Date.Now.Month) & "-" & Convert.ToString(Date.Now.Day) & " time " & Convert.ToString(Date.Now.Hour) & "-" & Convert.ToString(Date.Now.Minute)
        Return image_id



    End Function
    Public Sub formatlist_lv_treatment(ByVal lv_treatment As ListView)

        lv_treatment.View = View.Details

        lv_treatment.Columns.Add("ت", 1)
        lv_treatment.Columns.Add("اسم الدواء", 530)
        lv_treatment.Columns.Add("الصنف", 200)
        lv_treatment.Columns.Add("اطفال", 100)
        lv_treatment.Columns.Add("اطفال مع كلى", 200)
        lv_treatment.Columns.Add("كبار", 100)
        lv_treatment.Columns.Add("كبار مع كلى", 200)
        lv_treatment.Columns.Add("اولوية", 20)
        lv_treatment.Columns.Add("1", 88)
        lv_treatment.Columns.Add("2", 88)
        lv_treatment.Columns.Add("3", 88)



    End Sub

    Public Function is_doctor() As Boolean

        If user.type = s_doctor Then
            Return True
        Else
            Return False

        End If



    End Function

    Public Function getdatat1(ByVal sql As String) As DataSet
        Dim ds As New DataSet()
        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        conn.Open()

        Try
            Dim query As String = sql
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(ds)

            Return ds
        Catch ex As Exception

            MsgBox("excute failed " + ex.Message)
            Return ds
        End Try
        conn.Close()
        Return ds


    End Function

    Public Function excute2(ByVal sql As String, ByVal conn As MySqlConnection) As Boolean

        Dim query As String = sql
        Try
            Dim COMMAND As New MySqlCommand(query, conn)
            COMMAND.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("excute in Database Failed " + ex.Message)
            Return False
        End Try


        Return True



    End Function

    Public Function excute1(ByVal sql As String) As Boolean



        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo
        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Connection to the Database Failed " + myerror.Message)
            Return False
        End Try
        Dim query As String = sql
        Try
            Dim COMMAND As New MySqlCommand(query, conn)
            COMMAND.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("excute in Database Failed" + ex.Message)
            Return False
        End Try

        conn.Close()
        Return True



    End Function

    Public Sub add_event(ByRef conn As MySqlConnection, title As String, content As String)

        Dim query As String = "insert into event_record(title,content,person,`date`) values('" & title & "' , '" & content & "','" & user.name & "','" & Date.Now & "')"

        Try
            Dim COMMAND As New MySqlCommand(query, conn)
            COMMAND.ExecuteNonQuery()
        Catch ex As Exception

        End Try




    End Sub
    Public Sub new_event(title As String, content As String)

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
            Dim event_record As New EventRecord
            event_record.title = title
            event_record.content = content
            event_record.person = user.id
            event_record.d_date = Date.Now.ToString

            event_record.save(conn)
        Catch myerror As MySqlException

        End Try


    End Sub
    Public Sub new_event2(title As String, content As String, amount As Integer)

        conn = New MySqlConnection()
        conn.ConnectionString = serverInfo

        Try
            conn.Open()
            Dim event_record As New EventRecord
            event_record.title = title
            event_record.content = content
            event_record.person = user.id
            event_record.amount = amount
            event_record.d_date = Date.Now.ToString

            event_record.save(conn)
        Catch myerror As MySqlException

        End Try


    End Sub
    Public Sub new_event_opened(title As String, content As String)

        Dim event_record As New EventRecord
        event_record.title = title
        event_record.content = content
        event_record.person = user.id
        event_record.d_date = Date.Now.ToString

        event_record.save()
    End Sub
    Public Sub add_cb(ByVal cb As ComboBox)
        cb.Items().Add(s_once)
        cb.Items().Add(s_bid)
        cb.Items().Add(s_tid)
        cb.Items().Add(s_qid)

    End Sub
End Module
