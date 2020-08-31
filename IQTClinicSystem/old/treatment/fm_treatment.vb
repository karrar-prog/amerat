Public Class fm_treatment

    Private Sub fm_treatment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub fm_treatment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fm_main.Show()

    End Sub

    Private Sub fm_treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        formatlist_lv_treatment(lv_treatment)
        Combo_format(cb_category)
        Combo_format(tb_catogery)
        cb_type_format()
        add_cb(cb1)
        add_cb(cb2)
        add_cb(cb3)
        add_cb(cb4)
        search()





    End Sub



    Public Sub search()

1:
        Try
            Dim s As String = "select * from treatment WHERE name like '%" & tb_name.Text & "%' and category like '%" & cb_category.Text & "%'"

            Dim DataSet2 = getdatat1(s)
            Dim dt As New DateTimePicker
            Dim c As Integer

            lv_treatment.Items.Clear()
            tb_nember.Caption = DataSet2.Tables(0).Rows.Count.ToString

            If DataSet2.Tables(0).Rows.Count > 0 Then
                If DataSet2.Tables(0).Rows.Count - 1 > 30 Then
                    c = 28
                Else

                    c = DataSet2.Tables(0).Rows.Count - 1
                End If

                For i As Integer = 0 To c
                    lv_treatment.Items().Add(DataSet2.Tables(0).Rows(i).Item("id").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("name").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("category").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("children").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("children_kidney").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("adult").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("adult_kidney").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("priority").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("f1").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("f2").ToString)
                    lv_treatment.Items(i).SubItems.Add(DataSet2.Tables(0).Rows(i).Item("f3").ToString)
                    If DataSet2.Tables(0).Rows(i).Item("category").ToString <> "%" And DataSet2.Tables(0).Rows(i).Item("category").ToString <> "" Then
                        lv_treatment.Items(i).BackColor = Color.LightGreen


                    Else

                    End If
                Next
            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        search()

    End Sub

    Private Sub tb_name_EditValueChanged(sender As Object, e As EventArgs) Handles tb_name.EditValueChanged
        search()

    End Sub

    Private Sub tb_name_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_name.KeyUp
        If e.KeyCode = Keys.Enter Then
            search()

        End If
    End Sub

    Private Sub cb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_category.SelectedIndexChanged

        search()


    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub lv_treatment_DoubleClick(sender As Object, e As EventArgs) Handles lv_treatment.DoubleClick

    End Sub

    Private Sub lv_treatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_treatment.SelectedIndexChanged
        If lv_treatment.SelectedItems.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(lv_treatment.SelectedItems.Item(0).Text)
            Dim t As New Treatment(id)
            TabPane1.Pages(1).Caption = "تعديل"
            tb_id.Text = t.id.ToString
            tb_t_name.Text = get_with_out(t.name.ToString)
            tb_catogery.Text = t.category.ToString
            tb_adult.Text = t.adult.ToString
            tb_adult_kedny.Text = t.adult_kidney.ToString
            tb_children.Text = t.children
            tb_childern_kedny.Text = t.children_kidney.ToString
            tb_priority.Text = "9"
            f1.Text = t.f1.ToString
            If t.f2.Trim.ToString <> "" Then
                Try
                    f2.Value = Convert.ToDecimal(t.f2.ToString)
                Catch ex As Exception
                    f2.Value = Convert.ToInt64(t.f2.ToString)
                End Try
            Else
                f2.Value = 0
            End If
            f3.Text = t.f3.ToString
            TabPane1.SelectNextPage()
            If tb_t_name.Text.Contains(" " + s_type1) Then
                f1.Text = s_type1
            ElseIf tb_t_name.Text.Contains(" " + s_type2) Then
                f1.Text = s_type2
            ElseIf tb_t_name.Text.Contains(" " + s_type3) Then
                f1.Text = s_type3
            ElseIf tb_t_name.Text.Contains(" " + s_type4) Then
                f1.Text = s_type4
            ElseIf tb_t_name.Text.Contains(" " + s_type5) Then
                f1.Text = s_type5
            ElseIf tb_t_name.Text.Contains(" " + s_type6) Then
                f1.Text = s_type6
            ElseIf tb_t_name.Text.Contains(" " + s_type7) Then
                f1.Text = s_type7
            ElseIf tb_t_name.Text.Contains(" " + s_type8) Then
                f1.Text = s_type8
            ElseIf tb_t_name.Text.Contains(" " + s_type9) Then
                f1.Text = s_type9
            ElseIf tb_t_name.Text.Contains(" " + s_type10) Then
                f1.Text = s_type10
            ElseIf tb_t_name.Text.Contains(" " + s_type11) Then
                f1.Text = s_type11
            Else
                f1.Text = ""

            End If
        End If
    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        If lv_treatment.SelectedItems.Count > 0 Then
            If MessageBox.Show("سوف تقوم بحذف الدواء", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = System.Windows.Forms.DialogResult.Yes Then
                Dim id As Integer = Convert.ToInt32(lv_treatment.SelectedItems.Item(0).Text)
                Dim t As New Treatment
                t.id = id
                t.delete()
                search()
            End If


        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim t As New Treatment
        If tb_id.Text.Trim = "" Then

            t.id = 0
        Else
            t.id = Convert.ToInt32(tb_id.Text)
        End If
        If Not check_value() Then
            Exit Sub
        End If
        t.name = tb_t_name.Text.Trim
        t.category = tb_catogery.Text.Trim
        t.priority = tb_priority.Text.Trim
        t.children = tb_children.Text.Trim
        t.children_kidney = tb_childern_kedny.Text.Trim
        t.adult = tb_adult.Text.Trim
        t.adult_kidney = tb_adult_kedny.Text.Trim
        t.f1 = f1.Text.Trim
        t.f2 = f2.Text.Trim
        t.f3 = f3.Text.Trim
1:

        Try
            If t.save() Then
                '  MessageBox.Show("تمت العملية")
                search()
                clear_value()
                TabPane1.SelectPrevPage()


            End If
        Catch ex As Exception
            If MessageBox.Show("Retry اعد الاتصال واضغط ", "لايوجد اتصال", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                GoTo 1
            End If
        End Try


    End Sub



    Private Sub clear_value()
        TabPane1.Pages(1).Caption = "اضافة"

        tb_id.Text = ""
        tb_t_name.Text = ""
        tb_catogery.SelectedItem = tb_catogery.Items(0)
        tb_adult.Text = ""
        tb_adult_kedny.Text = ""
        tb_children.Text = ""
        tb_childern_kedny.Text = ""
        tb_priority.Text = ""
        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        clear_value()

    End Sub

    Private Sub TabNavigationPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage1.Paint

    End Sub



    Private Sub TabNavigationPage2_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage2.Paint

    End Sub

    Private Sub cb_type_format()
        f1.Items.Add(s_type1)
        f1.Items.Add(s_type2)
        f1.Items.Add(s_type3)
        f1.Items.Add(s_type4)
        f1.Items.Add(s_type5)
        f1.Items.Add(s_type6)
        f1.Items.Add(s_type7)
        f1.Items.Add(s_type8)
        f1.Items.Add(s_type9)
        f1.Items.Add(s_type10)
        f1.Items.Add(s_type11)
        f1.Items.Add(s_type12)
        f1.SelectedItem = f1.Items(0)

    End Sub


    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        marige_text1(cb1, t1)

    End Sub

    Private Sub marige_text1(comboBox As ComboBox, textEdit As NumericUpDown)
        tb_children.Text = comboBox.Text & "||" & textEdit.Text.Trim

    End Sub
    Private Sub marige_text2(comboBox As ComboBox, textEdit As NumericUpDown)
        tb_childern_kedny.Text = comboBox.Text & "||" & textEdit.Text.Trim

    End Sub
    Private Sub marige_text3(comboBox As ComboBox, textEdit As NumericUpDown)
        tb_adult.Text = comboBox.Text & "||" & textEdit.Text.Trim

    End Sub
    Private Sub marige_text4(comboBox As ComboBox, textEdit As NumericUpDown)
        tb_adult_kedny.Text = comboBox.Text & "||" & textEdit.Text.Trim

    End Sub



    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb2.SelectedIndexChanged
        marige_text2(cb2, t2)

    End Sub

    Private Sub cb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb3.SelectedIndexChanged
        marige_text3(cb3, t3)

    End Sub

    Private Sub cb4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb4.SelectedIndexChanged
        marige_text4(cb4, t4)
    End Sub





    Private Sub f2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Function check_value() As Boolean
        If f1.Text.Trim = "" Or tb_t_name.Text.Trim = "" Or tb_catogery.Text.Trim = "" Then
            MessageBox.Show("املئ جميع الحقول")
            Return False
        Else
            Return True

        End If

    End Function

    Private Sub t4_EditValueChanged(sender As Object, e As EventArgs)
        marige_text4(cb4, t4)
    End Sub

    Private Sub t3_EditValueChanged(sender As Object, e As EventArgs)
        marige_text3(cb3, t3)

    End Sub

    Private Sub t2_EditValueChanged(sender As Object, e As EventArgs)
        marige_text2(cb2, t2)

    End Sub

    Private Sub t1_EditValueChanged(sender As Object, e As EventArgs)
        marige_text1(cb1, t1)

    End Sub

    Private Function get_with_out(p1 As String) As String
        Dim new_p As String = ""

        For i = 0 To p1.Length - 1
            If p1(i) = "ذ" Or p1(i) = "ش" Or p1(i) = "س" Or p1(i) = "ي" Or p1(i) = "ب" Or p1(i) = "ل" Or p1(i) = "ت" Or p1(i) = "ن" Or p1(i) = "م" Or p1(i) = "ك" Or p1(i) = "ط" Or p1(i) = "ظ" Or p1(i) = "ز" Or p1(i) = "و" Or p1(i) = "ة" Or p1(i) = "ى" Or p1(i) = "لا" Or p1(i) = "ر" Or p1(i) = "ؤ" Or p1(i) = "ء" Or p1(i) = "ئ" Or p1(i) = "لإ" Or p1(i) = "ا" Or p1(i) = "د" Or p1(i) = "ج" Or p1(i) = "ح" Or p1(i) = "خ" Or p1(i) = "ه" Or p1(i) = "ع" Or p1(i) = "غ" Or p1(i) = "ف" Or p1(i) = "ق" Or p1(i) = "ث" Or p1(i) = "ص" Or p1(i) = "ض" Then
                new_p = new_p + ""
            Else
                new_p = new_p + p1(i)
            End If
        Next
        Return new_p

    End Function

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        tb_name.Text = ""

    End Sub

    Private Sub GroupControl6_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl6.Paint

    End Sub

    Private Sub t2_GotFocus(sender As Object, e As EventArgs) Handles t2.GotFocus
        t2.Text = ""
    End Sub


    Private Sub t2_ValueChanged(sender As Object, e As EventArgs) Handles t2.ValueChanged
        marige_text2(cb2, t2)

    End Sub

    Private Sub t1_GotFocus(sender As Object, e As EventArgs) Handles t1.GotFocus
        t1.Text = ""
    End Sub

    Private Sub t1_ValueChanged(sender As Object, e As EventArgs) Handles t1.ValueChanged
        marige_text1(cb1, t1)

    End Sub

    Private Sub t3_GotFocus(sender As Object, e As EventArgs) Handles t3.GotFocus
        t3.Text = ""
    End Sub

    Private Sub t3_ValueChanged(sender As Object, e As EventArgs) Handles t3.ValueChanged
        marige_text3(cb3, t3)

    End Sub

    Private Sub t4_GotFocus(sender As Object, e As EventArgs) Handles t4.GotFocus
        t4.Text = ""
    End Sub

    Private Sub t4_ValueChanged(sender As Object, e As EventArgs) Handles t4.ValueChanged
        marige_text4(cb4, t4)
    End Sub

    Private Sub f2_GotFocus(sender As Object, e As EventArgs) Handles f2.GotFocus
        f2.Text = ""
    End Sub

    Private Sub f2_ValueChanged(sender As Object, e As EventArgs) Handles f2.ValueChanged

    End Sub
End Class