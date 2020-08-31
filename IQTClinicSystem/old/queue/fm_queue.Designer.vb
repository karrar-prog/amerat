Partial Public Class fm_queue
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_queue))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.p_fingerPrint = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.ApplicationMenu2 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.ApplicationMenu3 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.تعديلالحجزToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الغائالحجزToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلالاسمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عرضملفالمراجعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_queue = New System.Windows.Forms.DateTimePicker()
        Me.DefaultLookAndFeel2 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.tb_user = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem5 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem6 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_main = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem7 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.br_count = New DevExpress.XtraBars.BarButtonItem()
        Me.br_count1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.l_entered = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.p_fingerPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Controls.Add(Me.p_fingerPrint)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Location = New System.Drawing.Point(17, 251)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(102, 103)
        Me.GroupControl3.TabIndex = 259
        '
        'p_fingerPrint
        '
        Me.p_fingerPrint.Image = CType(resources.GetObject("p_fingerPrint.Image"), System.Drawing.Image)
        Me.p_fingerPrint.Location = New System.Drawing.Point(19, 31)
        Me.p_fingerPrint.Name = "p_fingerPrint"
        Me.p_fingerPrint.Size = New System.Drawing.Size(63, 63)
        Me.p_fingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_fingerPrint.TabIndex = 253
        Me.p_fingerPrint.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 257
        Me.Label3.Text = "معلومات المراجعين"
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Controls.Add(Me.PictureBox3)
        Me.GroupControl5.Controls.Add(Me.Label1)
        Me.GroupControl5.Location = New System.Drawing.Point(18, 383)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(102, 103)
        Me.GroupControl5.TabIndex = 261
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 254
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "مراجع جديد"
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        '
        'ApplicationMenu2
        '
        Me.ApplicationMenu2.Name = "ApplicationMenu2"
        '
        'ApplicationMenu3
        '
        Me.ApplicationMenu3.Name = "ApplicationMenu3"
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(142, 104)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(1055, 637)
        Me.lv_queue.TabIndex = 263
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تعديلالحجزToolStripMenuItem, Me.الغائالحجزToolStripMenuItem, Me.تعديلالاسمToolStripMenuItem, Me.عرضملفالمراجعToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 92)
        '
        'تعديلالحجزToolStripMenuItem
        '
        Me.تعديلالحجزToolStripMenuItem.Name = "تعديلالحجزToolStripMenuItem"
        Me.تعديلالحجزToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.تعديلالحجزToolStripMenuItem.Text = "تعديل الحجز"
        '
        'الغائالحجزToolStripMenuItem
        '
        Me.الغائالحجزToolStripMenuItem.Name = "الغائالحجزToolStripMenuItem"
        Me.الغائالحجزToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.الغائالحجزToolStripMenuItem.Text = "الغاء الحجز"
        '
        'تعديلالاسمToolStripMenuItem
        '
        Me.تعديلالاسمToolStripMenuItem.Name = "تعديلالاسمToolStripMenuItem"
        Me.تعديلالاسمToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.تعديلالاسمToolStripMenuItem.Text = "تعديل الاسم"
        '
        'عرضملفالمراجعToolStripMenuItem
        '
        Me.عرضملفالمراجعToolStripMenuItem.Name = "عرضملفالمراجعToolStripMenuItem"
        Me.عرضملفالمراجعToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.عرضملفالمراجعToolStripMenuItem.Text = "عرض ملف المراجع"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(626, 75)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 271
        Me.SimpleButton2.Text = "غدا"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(863, 75)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 270
        Me.SimpleButton1.Text = "اليوم"
        '
        'dt_queue
        '
        Me.dt_queue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_queue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_queue.Location = New System.Drawing.Point(719, 72)
        Me.dt_queue.Name = "dt_queue"
        Me.dt_queue.RightToLeftLayout = True
        Me.dt_queue.Size = New System.Drawing.Size(127, 29)
        Me.dt_queue.TabIndex = 269
        '
        'tb_user
        '
        Me.tb_user.Id = 1
        Me.tb_user.ImageOptions.LargeImage = CType(resources.GetObject("tb_user.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.tb_user.Name = "tb_user"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem1"
        Me.BarButtonItem6.Id = 2
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarHeaderItem5
        '
        Me.BarHeaderItem5.Caption = "تحديث"
        Me.BarHeaderItem5.Id = 3
        Me.BarHeaderItem5.ImageOptions.Image = CType(resources.GetObject("BarHeaderItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarHeaderItem5.Name = "BarHeaderItem5"
        '
        'BarHeaderItem6
        '
        Me.BarHeaderItem6.Id = 4
        Me.BarHeaderItem6.ImageOptions.Image = CType(resources.GetObject("BarHeaderItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarHeaderItem6.ImageOptions.LargeImage = CType(resources.GetObject("BarHeaderItem6.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarHeaderItem6.Name = "BarHeaderItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "الرئيسية"
        Me.BarButtonItem7.Id = 5
        Me.BarButtonItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 6
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btn_main
        '
        Me.btn_main.Caption = "الرئيسية"
        Me.btn_main.Id = 8
        Me.btn_main.ImageOptions.LargeImage = CType(resources.GetObject("btn_main.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_main.Name = "btn_main"
        '
        'BarHeaderItem7
        '
        Me.BarHeaderItem7.Caption = "BarHeaderItem3"
        Me.BarHeaderItem7.Id = 9
        Me.BarHeaderItem7.Name = "BarHeaderItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "المراجعين"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem8.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "الحجوزات"
        Me.BarButtonItem9.Id = 11
        Me.BarButtonItem9.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem9.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "اضافة"
        Me.BarButtonItem10.Id = 12
        Me.BarButtonItem10.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem10.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "الزيارات"
        Me.BarButtonItem11.Id = 13
        Me.BarButtonItem11.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem11.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "الوصفات"
        Me.BarButtonItem12.Id = 14
        Me.BarButtonItem12.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem12.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "دخول مشفى"
        Me.BarButtonItem13.Id = 15
        Me.BarButtonItem13.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem13.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "تقرير طبي"
        Me.BarButtonItem14.Id = 16
        Me.BarButtonItem14.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem14.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "عمليات"
        Me.BarButtonItem15.Id = 17
        Me.BarButtonItem15.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem15.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'br_count
        '
        Me.br_count.Caption = "0 "
        Me.br_count.Id = 18
        Me.br_count.ImageOptions.Image = CType(resources.GetObject("br_count.ImageOptions.Image"), System.Drawing.Image)
        Me.br_count.Name = "br_count"
        '
        'br_count1
        '
        Me.br_count1.Caption = "br_count"
        Me.br_count1.Id = 19
        Me.br_count1.ImageOptions.Image = CType(resources.GetObject("br_count1.ImageOptions.Image"), System.Drawing.Image)
        Me.br_count1.Name = "br_count1"
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.tb_user, Me.BarButtonItem6, Me.BarHeaderItem5, Me.BarHeaderItem6, Me.BarButtonItem7, Me.SkinRibbonGalleryBarItem1, Me.btn_main, Me.BarHeaderItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.br_count, Me.br_count1})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 21
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.PageHeaderItemLinks.Add(Me.br_count1)
        Me.RibbonControl2.QuickToolbarItemLinks.Add(Me.tb_user)
        Me.RibbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1220, 49)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 88)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 22)
        Me.LabelControl1.TabIndex = 273
        Me.LabelControl1.Text = "عدد الداخلين"
        '
        'l_entered
        '
        Me.l_entered.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_entered.Appearance.Options.UseFont = True
        Me.l_entered.Location = New System.Drawing.Point(23, 121)
        Me.l_entered.Name = "l_entered"
        Me.l_entered.Size = New System.Drawing.Size(77, 22)
        Me.l_entered.TabIndex = 274
        Me.l_entered.Text = "عدد الداخلين"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(519, 59)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 42)
        Me.SimpleButton3.TabIndex = 276
        '
        'fm_queue
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(1220, 764)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.l_entered)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.dt_queue)
        Me.Controls.Add(Me.lv_queue)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.RibbonControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_queue"
        Me.Ribbon = Me.RibbonControl2
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.p_fingerPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents p_fingerPrint As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents ApplicationMenu2 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents ApplicationMenu3 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_queue As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents تعديلالحجزToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultLookAndFeel2 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents tb_user As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem5 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem6 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btn_main As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem7 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents br_count As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents br_count1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents l_entered As DevExpress.XtraEditors.LabelControl
    Friend WithEvents تعديلالاسمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents الغائالحجزToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents عرضملفالمراجعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

#End Region

End Class
