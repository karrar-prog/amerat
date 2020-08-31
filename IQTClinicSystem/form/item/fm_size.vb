Public Class fm_size 

    Private Sub fm_size_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'list
        li_size.View = View.Details
        li_size.Columns.Add("القياس", 250)

        'list
        li_item.View = View.Details
        li_item.Columns.Add("القياس", 100)
        li_item.Alignment = ListViewAlignment.SnapToGrid

        'list
        li_item2.View = View.Details
        li_item2.Columns.Add("الاحجام", 100)

        'list
        li_item3.View = View.Details
        li_item3.Columns.Add("اللون", 100)



        'list
        li_item4.View = View.Details
        li_item4.Columns.Add("التدرج", 100)


        If Xstore.cb_type.Text = "ساعات" Then
            li_item.Items.Add("")
            li_item.Items.Add("سير")
            li_item.Items.Add("ماشة")
            li_item.Items.Add("اطار")







            li_item3.Items.Add("")
            li_item3.Items.Add("ابيض")
            li_item3.Items.Add("اسود")
            li_item3.Items(2).BackColor = Color.Black
            li_item3.Items(2).ForeColor = Color.White


            li_item3.Items.Add("رصاصي")
            li_item3.Items(3).BackColor = Color.Silver


            li_item3.Items.Add("رمادي")
            li_item3.Items(4).BackColor = Color.Gray

            li_item3.Items.Add("وردي")
            li_item3.Items(5).BackColor = Color.HotPink
            li_item3.Items.Add("وردي فاتح")
            li_item3.Items(6).BackColor = Color.LightPink

            li_item3.Items.Add("احمر")
            li_item3.Items(7).BackColor = Color.Red


            li_item3.Items.Add("برتقالي")
            li_item3.Items(8).BackColor = Color.Orange


            li_item3.Items.Add("ماروني")
            li_item3.Items(9).BackColor = Color.DarkRed
            li_item3.Items.Add("عسلي")
            li_item3.Items(10).BackColor = Color.Honeydew

            li_item3.Items.Add("ازرق")
            li_item3.Items(11).BackColor = Color.Blue

            li_item3.Items.Add("جوزي")
            li_item3.Items(12).BackColor = Color.Brown

            li_item3.Items.Add("ذهبي")
            li_item3.Items(13).BackColor = Color.Gold

            li_item3.Items.Add("بيجي")
            li_item3.Items(14).BackColor = Color.Beige

            li_item3.Items.Add("اصفر")
            li_item3.Items(15).BackColor = Color.Yellow

            li_item3.Items.Add("زيتوني")
            li_item3.Items(16).BackColor = Color.OliveDrab

            li_item3.Items.Add("أخضر")
            li_item3.Items(17).BackColor = Color.Green

            li_item3.Items.Add("سمائي")
            li_item3.Items(18).BackColor = Color.LightSkyBlue

            li_item3.Items.Add("بنفسجى")
            li_item3.Items(19).BackColor = Color.Purple

            li_item3.Items.Add("نيلي")
            li_item3.Items(20).BackColor = Color.DarkBlue

            li_item3.Items.Add("بيجي غامق")
            li_item3.Items(21).BackColor = Color.Beige

            li_item3.Items.Add("مائي")
            li_item3.Items(22).BackColor = Color.Aqua

            li_item3.Items.Add("فضي")
            li_item3.Items(23).BackColor = Color.Silver

            li_item3.Items.Add("برونزي")



            li_item4.Items.Add("")
            li_item4.Items.Add("فاتح")
            li_item4.Items.Add("وسط")
            li_item4.Items.Add("طوخ")
            li_item4.Items.Add("مقلم")
            li_item4.Items.Add("مقفل")

            li_item4.Items.Add("مشطب")

            li_item4.Items.Add("مخرم")

            li_item4.Items.Add("نقشة")

            li_item4.Items.Add("مشجر")
            li_item4.Items.Add("محفر")

            li_item4.Items.Add("دجتال")

            li_item4.Items.Add("مقلم ناعم")
            li_item4.Items.Add("مقلم عريض")
            li_item4.Items.Add("مقفل خيال")
            li_item4.Items.Add("مقفل خشن")
            li_item4.Items.Add("ليزري")
            li_item4.Items.Add("كومبيوتر")
            li_item4.Items.Add("مقفل ناعم")
            li_item4.Items.Add("مكعبات")

        Else


            li_item.Items.Add("")
            li_item.Items.Add("20")
            li_item.Items.Add("21")
            li_item.Items.Add("22")
            li_item.Items.Add("23")
            li_item.Items.Add("23")
            li_item.Items.Add("24")
            li_item.Items.Add("25")
            li_item.Items.Add("27")
            li_item.Items.Add("28")
            li_item.Items.Add("29")
            li_item.Items.Add("30")
            li_item.Items.Add("31")
            li_item.Items.Add("32")
            li_item.Items.Add("33")
            li_item.Items.Add("34")
            li_item.Items.Add("35")
            li_item.Items.Add("36")
            li_item.Items.Add("37")
            li_item.Items.Add("38")
            li_item.Items.Add("39")
            li_item.Items.Add("40")
            li_item.Items.Add("41")
            li_item.Items.Add("42")
            li_item.Items.Add("43")
            li_item.Items.Add("44")
            li_item.Items.Add("45")
            li_item.Items.Add("46")
            li_item.Items.Add("47")
            li_item.Items.Add("48")
            li_item.Items.Add("49")
            li_item.Items.Add("50")
            li_item.Items.Add("51")
            li_item.Items.Add("52")
            li_item.Items.Add("53")
            li_item.Items.Add("54")
            li_item.Items.Add("55")
            li_item.Items.Add("56")
            li_item.Items.Add("57")
            li_item.Items.Add("58")
            li_item.Items.Add("59")
            li_item.Items.Add("60")
            li_item.Items.Add("61")
            li_item.Items.Add("62")
            li_item.Items.Add("63")
            li_item.Items.Add("64")
            li_item.Items.Add("65")
            li_item.Items.Add("66")
            li_item.Items.Add("67")
            li_item.Items.Add("68")
            li_item.Items.Add("69")
            li_item.Items.Add("70")


            li_item2.Items.Add("")
            li_item2.Items.Add("XS")
            li_item2.Items.Add("S")
            li_item2.Items.Add("M")
            li_item2.Items.Add("L")
            li_item2.Items.Add("XL")
            li_item2.Items.Add("2XL")
            li_item2.Items.Add("3XL")
            li_item2.Items.Add("4XL")
            li_item2.Items.Add("5XL")
            li_item2.Items.Add("6XL")
            li_item2.Items.Add("7XL")
            li_item2.Items.Add("8XL")
            li_item2.Items.Add("9XL")
            li_item2.Items.Add("10XL")



            li_item3.Items.Add("")
            li_item3.Items.Add("ابيض")
            li_item3.Items.Add("اسود")
            li_item3.Items(2).BackColor = Color.Black
            li_item3.Items(2).ForeColor = Color.White


            li_item3.Items.Add("رصاصي")
            li_item3.Items(3).BackColor = Color.Silver


            li_item3.Items.Add("رمادي")
            li_item3.Items(4).BackColor = Color.Gray

            li_item3.Items.Add("وردي")
            li_item3.Items(5).BackColor = Color.HotPink
            li_item3.Items.Add("وردي فاتح")
            li_item3.Items(6).BackColor = Color.LightPink

            li_item3.Items.Add("احمر")
            li_item3.Items(7).BackColor = Color.Red


            li_item3.Items.Add("برتقالي")
            li_item3.Items(8).BackColor = Color.Orange


            li_item3.Items.Add("ماروني")
            li_item3.Items(9).BackColor = Color.DarkRed
            li_item3.Items.Add("عسلي")
            li_item3.Items(10).BackColor = Color.Honeydew

            li_item3.Items.Add("ازرق")
            li_item3.Items(11).BackColor = Color.Blue

            li_item3.Items.Add("جوزي")
            li_item3.Items(12).BackColor = Color.Brown

            li_item3.Items.Add("ذهبي")
            li_item3.Items(13).BackColor = Color.Gold

            li_item3.Items.Add("بيجي")
            li_item3.Items(14).BackColor = Color.Beige

            li_item3.Items.Add("اصفر")
            li_item3.Items(15).BackColor = Color.Yellow

            li_item3.Items.Add("زيتوني")
            li_item3.Items(16).BackColor = Color.OliveDrab

            li_item3.Items.Add("أخضر")
            li_item3.Items(17).BackColor = Color.Green

            li_item3.Items.Add("سمائي")
            li_item3.Items(18).BackColor = Color.LightSkyBlue

            li_item3.Items.Add("بنفسجى")
            li_item3.Items(19).BackColor = Color.Purple

            li_item3.Items.Add("نيلي")
            li_item3.Items(20).BackColor = Color.DarkBlue

            li_item3.Items.Add("بيجي غامق")
            li_item3.Items(21).BackColor = Color.Beige

            li_item3.Items.Add("مائي")
            li_item3.Items(22).BackColor = Color.Aqua

            li_item3.Items.Add("فضي")
            li_item3.Items(23).BackColor = Color.Silver

            li_item3.Items.Add("برونزي")



            li_item4.Items.Add("")
            li_item4.Items.Add("فاتح")
            li_item4.Items.Add("وسط")
            li_item4.Items.Add("طوخ")
            li_item4.Items.Add("مقلم")
            li_item4.Items.Add("مقفل")

            li_item4.Items.Add("مشطب")

            li_item4.Items.Add("مخرم")

            li_item4.Items.Add("نقشة")

            li_item4.Items.Add("مشجر")
            li_item4.Items.Add("محفر")

            li_item4.Items.Add("دجتال")

            li_item4.Items.Add("مقلم ناعم")
            li_item4.Items.Add("مقلم عريض")
            li_item4.Items.Add("ليزري")
            li_item4.Items.Add("كومبيوتر")
            li_item4.Items.Add("مقفل خيال")
            li_item4.Items.Add("مقفل خشن")
            li_item4.Items.Add("مقفل ناعم")
            li_item4.Items.Add("مكعبات")

        End If





        tb_count2.Text = (_i(tb_count.Text) - li_size.Items.Count).ToString



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If tb_search.Text.Trim <> "" Then

            add_size(tb_search.Text)
            tb_search.Text = ""

         
        End If


    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If (li_size.Items.Count <> _i(tb_count.Text)) Then
            MessageBox.Show("يجب ان تساوي القياسات العدد المدخل", "")
            Exit Sub
        End If
        Dim st As String = ""


        For i = 0 To li_size.Items.Count - 1
            st = st & li_size.Items(i).Text & "\"

        Next
        Xstore.tb_detail.Text = st
        Me.Close()

    End Sub

    Private Sub li_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item.SelectedIndexChanged
        If (li_item.SelectedItems.Count > 0) Then
            tb_1.Text = li_item.SelectedItems.Item(0).Text

            shose(li_item.SelectedItems.Item(0).Text)

        End If

    End Sub

    Private Sub add_size(size As String)
        For i = 1 To n_copy.Value
            If li_size.Items.Count < _i(tb_count.Text) Then
                If size.Trim <> "" Then

                    li_size.Items.Add(size.Trim)
                    tb_count2.Text = (_i(tb_count2.Text) - 1).ToString
                    tb_search.Text = ""
                    tb_search.Focus()


                End If


            End If
        Next

    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub li_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_size.SelectedIndexChanged
        If li_size.SelectedItems.Count > 0 Then
            li_size.Items.RemoveAt(li_size.SelectedIndices(0))
            tb_count2.Text = (_i(tb_count2.Text) + 1).ToString

        End If
    End Sub

 




    Private Sub put_size_color_gravity()

        Dim size_and_color = ""
        size_and_color = tb_1.Text & " " & tb_2.Text & " " & tb_3.Text & " " & tb_4.Text
        add_size(size_and_color)
        li_item.SelectedItems.Clear()
        li_item2.SelectedItems.Clear()
        li_item3.SelectedItems.Clear()
        li_item4.SelectedItems.Clear()


    End Sub

  
 

  
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        put_size_color_gravity()

    End Sub

    Private Sub li_item2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item2.SelectedIndexChanged
        If (li_item2.SelectedItems.Count > 0) Then
            tb_2.Text = li_item2.SelectedItems.Item(0).Text
            shose(li_item2.SelectedItems.Item(0).Text)

        End If

    End Sub

    Private Sub li_item4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item4.SelectedIndexChanged
        If (li_item4.SelectedItems.Count > 0) Then
            tb_4.Text = li_item4.SelectedItems.Item(0).Text
            shose(li_item4.SelectedItems.Item(0).Text)

        End If

    End Sub

    Private Sub li_item3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles li_item3.SelectedIndexChanged
        If (li_item3.SelectedItems.Count > 0) Then
            tb_3.Text = li_item3.SelectedItems.Item(0).Text
            shose(li_item3.SelectedItems.Item(0).Text)


        End If

    End Sub

    Private Sub tb_1_EditValueChanged(sender As Object, e As EventArgs) Handles tb_1.EditValueChanged

    End Sub

  
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        tb_1.Text = ""

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        tb_2.Text = ""

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        tb_3.Text = ""

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        tb_4.Text = ""

    End Sub

    Private Sub shose(s As String)
        If Xstore.cb_type.Text = "ساعات" Then
            tb_search.Text = tb_search.Text & " " & s
        End If
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        tb_search.Text = ""

    End Sub
End Class