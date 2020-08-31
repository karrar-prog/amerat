Public Class fm_web_browser 
    Public sub_url As String = "treatment"
    Public form_title As String = "الرئيسية"
   

    Private Sub fm_web_browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        open_page()


    End Sub

    Private Sub open_page()
        ProgressPanel1.Show()
        AddHandler WebBrowser1.DocumentCompleted, AddressOf WebBrowser_DocumentCompleted


        WebBrowser1.Navigate(main_url + sub_url)
        Me.Text = form_title
        tb_user.Caption = user.name


    End Sub

    Private Sub WebBrowser_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        ProgressPanel1.Hide()
        If (WebBrowser1.Document.Body.InnerHtml.Contains("Navigation")) Then



            If MessageBox.Show("يرجى تشغيل السيرفر والضغط على ok") = System.Windows.Forms.DialogResult.OK Then
                open_page()


            End If

        End If

    End Sub

    Private Sub BarHeaderItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarHeaderItem1.ItemClick
        open_page()

    End Sub

 
    Private Sub btn_main_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_main.ItemClick

        fm_main.Show()
        Me.Close()

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        fm_show_patients.Show()
        Me.Close()

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub
End Class