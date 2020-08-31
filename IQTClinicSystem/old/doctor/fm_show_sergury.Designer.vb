<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_show_sergury
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_show_sergury))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.tb_count = New DevExpress.XtraBars.BarHeaderItem()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_date = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lv_sergury = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عرضملفالمريضToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupControl12 = New DevExpress.XtraEditors.GroupControl()
        Me.r_no = New System.Windows.Forms.RadioButton()
        Me.r_yes = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl12.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.tb_count})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.tb_count)
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1093, 32)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'tb_count
        '
        Me.tb_count.Caption = "0"
        Me.tb_count.Id = 1
        Me.tb_count.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.lungs_icon
        Me.tb_count.Name = "tb_count"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 652)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1093, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(83, 260)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 22)
        Me.LabelControl2.TabIndex = 297
        Me.LabelControl2.Text = "الفتره"
        '
        'tb_date
        '
        Me.tb_date.CalendarFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_date.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.tb_date.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_date.Location = New System.Drawing.Point(25, 288)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_date.RightToLeftLayout = True
        Me.tb_date.Size = New System.Drawing.Size(153, 35)
        Me.tb_date.TabIndex = 296
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(25, 341)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 35)
        Me.DateTimePicker1.TabIndex = 298
        '
        'lv_sergury
        '
        Me.lv_sergury.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_sergury.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_sergury.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_sergury.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_sergury.FullRowSelect = True
        Me.lv_sergury.GridLines = True
        Me.lv_sergury.Location = New System.Drawing.Point(2, 21)
        Me.lv_sergury.Name = "lv_sergury"
        Me.lv_sergury.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_sergury.RightToLeftLayout = True
        Me.lv_sergury.ShowItemToolTips = True
        Me.lv_sergury.Size = New System.Drawing.Size(882, 597)
        Me.lv_sergury.TabIndex = 299
        Me.lv_sergury.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حذفToolStripMenuItem, Me.عرضملفالمريضToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 48)
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'عرضملفالمريضToolStripMenuItem
        '
        Me.عرضملفالمريضToolStripMenuItem.Name = "عرضملفالمريضToolStripMenuItem"
        Me.عرضملفالمريضToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.عرضملفالمريضToolStripMenuItem.Text = " عرض ملف المريض"
        '
        'GroupControl12
        '
        Me.GroupControl12.Controls.Add(Me.r_no)
        Me.GroupControl12.Controls.Add(Me.r_yes)
        Me.GroupControl12.Location = New System.Drawing.Point(11, 394)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.Size = New System.Drawing.Size(181, 62)
        Me.GroupControl12.TabIndex = 355
        Me.GroupControl12.Text = "هل تم اجراء العملية"
        '
        'r_no
        '
        Me.r_no.AutoSize = True
        Me.r_no.Checked = True
        Me.r_no.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_no.Location = New System.Drawing.Point(114, 23)
        Me.r_no.Name = "r_no"
        Me.r_no.Size = New System.Drawing.Size(42, 30)
        Me.r_no.TabIndex = 1
        Me.r_no.TabStop = True
        Me.r_no.Text = "لا"
        Me.r_no.UseVisualStyleBackColor = True
        '
        'r_yes
        '
        Me.r_yes.AutoSize = True
        Me.r_yes.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_yes.Location = New System.Drawing.Point(23, 23)
        Me.r_yes.Name = "r_yes"
        Me.r_yes.Size = New System.Drawing.Size(55, 30)
        Me.r_yes.TabIndex = 0
        Me.r_yes.Text = "نعم"
        Me.r_yes.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IQTClinicSystem.My.Resources.Resources.search_disease_icon
        Me.PictureBox2.Location = New System.Drawing.Point(70, 474)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 357
        Me.PictureBox2.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.DateTimePicker1)
        Me.GroupControl1.Controls.Add(Me.PictureBox2)
        Me.GroupControl1.Controls.Add(Me.tb_date)
        Me.GroupControl1.Controls.Add(Me.GroupControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 32)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(207, 620)
        Me.GroupControl1.TabIndex = 358
        Me.GroupControl1.Text = "البحث"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton4.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton4.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Appearance.Options.UseBorderColor = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(50, 195)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(108, 35)
        Me.SimpleButton4.TabIndex = 361
        Me.SimpleButton4.Text = "الشهر القادم"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(50, 142)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(108, 35)
        Me.SimpleButton3.TabIndex = 360
        Me.SimpleButton3.Text = "الاسبوع القادم"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(50, 89)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(108, 35)
        Me.SimpleButton2.TabIndex = 359
        Me.SimpleButton2.Text = "غدا"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(50, 36)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(108, 35)
        Me.SimpleButton1.TabIndex = 358
        Me.SimpleButton1.Text = "اليوم"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lv_sergury)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(207, 32)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(886, 620)
        Me.GroupControl2.TabIndex = 359
        Me.GroupControl2.Text = "العماليات"
        '
        'fm_show_sergury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 675)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_show_sergury"
        Me.Ribbon = Me.RibbonControl1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "عرض العمليات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl12.ResumeLayout(False)
        Me.GroupControl12.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lv_sergury As System.Windows.Forms.ListView
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents r_no As System.Windows.Forms.RadioButton
    Friend WithEvents r_yes As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_count As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents حذفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents عرضملفالمريضToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
