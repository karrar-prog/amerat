Module doctor_controller




    Public Sub formatlist_enterd(ByVal lv As ListView)

        lv.View = View.Details

        lv.Columns.Add("ت", 1)
        lv.Columns.Add("اسم المراجع", 220)
        lv.Columns.Add("رقم المراجع", 110)


    End Sub
    Public Sub formatlists(ByVal lv As ListView)

        lv.View = View.Details

        lv.Columns.Add("ت", 1)
        lv.Columns.Add("تأريخ", 200)
        lv.Columns.Add("", 70)




    End Sub
    Public Sub formatlist_suggest(ByVal lv As ListView)

        lv.View = View.Details

        lv.Columns.Add("ت", 0)
        lv.Columns.Add("عنوان", 250)
        lv.Columns.Add("", 0)




    End Sub
    Public Sub formatlist_category(ByVal lv As ListView)

        lv.View = View.Details


        lv.Columns.Add("التصنيف", 389)

    End Sub
    Public Sub formatlist_treatment(ByVal lv As ListView)

        lv.View = View.Details


        lv.Columns.Add("اسم الدواء", 450)
        lv.Columns.Add("اطفال", 1)
        lv.Columns.Add("اطفال كلى", 1)
        lv.Columns.Add("كبار", 1)
        lv.Columns.Add("كبار كلى", 1)
        lv.Columns.Add("1", 1)
        lv.Columns.Add("2", 1)
        lv.Columns.Add("3", 1)

    End Sub
    Public Sub formatlist_treat_table(ByVal lv As ListView)

        lv.View = View.Details

        lv.Columns.Add("ت", 1)
        lv.Columns.Add("العنوان", 220)
        lv.Columns.Add("المبلغ", 170)
        lv.Columns.Add("ملاحظة", 150)

        lv.Columns.Add("ملاحظة", 0)


    End Sub

    Public Sub formatlist_dept_table(ByVal lv As ListView)

        lv.View = View.Details

        lv.Columns.Add("ت", 1)
        lv.Columns.Add("العنوان", 140)
        lv.Columns.Add("المبلغ", 100)
        lv.Columns.Add("الواصل", 100)

        lv.Columns.Add("ملاحظة", 150)
        lv.Columns.Add("النوع", 100)
        lv.Columns.Add("الحاله", 0)
        lv.Columns.Add("تأريخ الانشاء", 120)
        lv.Columns.Add("تأريخ التسديد", 100)
        lv.Columns.Add("رقم المستخدم", 100)
        lv.Columns.Add("", 0)
        lv.Columns.Add("", 0)
        lv.Columns.Add("", 0)
        lv.Columns.Add("", 0)
        lv.Columns.Add("", 0)
        lv.Columns.Add("رقم المشترك", 0)

    End Sub

    Public Sub fill_visits(ByVal lv As ListView, ByVal visit As Visit)

        Dim dt As New DateTimePicker

        Dim ds As New DataSet
        ds = visit.get_all()
        lv.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv.Items(0).ForeColor = Color.Green


        Next


    End Sub

    Public Sub fill_treatment(ByVal lv As ListView, ByVal visit As Visit)

        Dim dt As New DateTimePicker

        Dim ds As New DataSet
        ds = visit.get_all()
        lv.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv.Items(0).ForeColor = Color.Green


        Next


    End Sub

    Public Sub fill_treats(ByVal lv As ListView, ByVal treat As Treat)

        Dim dt As New DateTimePicker

        Dim ds As New DataSet
        ds = treat.get_all()
        lv.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
          
            lv.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv.Items(0).ForeColor = Color.Green
            If ds.Tables(0).Rows(i).Item("other").ToString = to_lab Then
                lv.Items(i).ForeColor = Color.Blue

                lv.Items(i).SubItems.Add("تحليل")
            Else
                lv.Items(i).SubItems.Add("وصفة")
            End If

        Next


    End Sub

    Public Sub fill_hospital_enter(ByVal lv As ListView, ByVal hospital_enter As HospitalEnter)

        Dim dt As New DateTimePicker

        Dim ds As New DataSet
        ds = hospital_enter.get_all()
        lv.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv.Items(0).ForeColor = Color.Green


        Next


    End Sub

    Public Sub fill_medical_operation(ByVal lv As ListView, ByVal medical_operation As MedicalOperation)

        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        ds = medical_operation.get_all()
        lv.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv.Items(0).ForeColor = Color.Green
        Next

    End Sub
    Public Sub format_templet_treat(ByVal cb As ComboBox)

        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        ds = getdatat1("select * from template ")
        cb.Items.Clear()
        cb.Items().Add(s_temp)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            cb.Items().Add(ds.Tables(0).Rows(i).Item("title").ToString)
        Next
        cb.SelectedItem = cb.Items(0)

    End Sub
    Public Sub fill_category(ByVal lv As ListView)
        Dim obj As New Treatment
1:
        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        Try
            ds = obj.get_all_category
            lv.Items.Clear()
            lv.Items().Add("%")
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lv.Items().Add(ds.Tables(0).Rows(i).Item("name").ToString)
                    lv.Items().Add(" ")

                Next
            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            Else
                Exit Sub
            End If

        End Try


    End Sub






    Public Sub fill_reports(ByVal lv_ar As ListView, ByVal lv_en As ListView, ByVal report As Report)

        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        ds = report.get_all_ar()
        lv_ar.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv_ar.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv_ar.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv_ar.Items(0).ForeColor = Color.Green
        Next

        dt = New DateTimePicker
        ds = New DataSet
        ds = report.get_all_en()
        lv_en.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            lv_en.Items().Add(ds.Tables(0).Rows(i).Item("id").ToString)
            dt.Value = Convert.ToDateTime(ds.Tables(0).Rows(i).Item("date").ToString)
            lv_en.Items(i).SubItems.Add(dt.Value.ToShortDateString)
            lv_en.Items(0).ForeColor = Color.Green
        Next

    End Sub
    Public Sub fill_treatment_lv(ByVal lv_ar As ListView, ByVal obl As Treatment)

        Dim dt As New DateTimePicker
        Dim ds As New DataSet
        ds = obl.get_all_by_category()


        lv_ar.Items.Clear()

        Dim c As Integer
        If ds.Tables(0).Rows.Count - 1 > 29 Then
            c = 27
        Else
            c = ds.Tables(0).Rows.Count - 1

        End If


        For i = 0 To c


            lv_ar.Items().Add(ds.Tables(0).Rows(i).Item("name").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("children").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("children_kidney").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("adult").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("adult_kidney").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("f1").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("f2").ToString)
            lv_ar.Items(i).SubItems.Add(ds.Tables(0).Rows(i).Item("f3").ToString)

        Next



    End Sub


End Module
