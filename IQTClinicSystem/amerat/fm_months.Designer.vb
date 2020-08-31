<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_months
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_months))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lv_dept = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.الديونToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تسديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلمعلوماتالمشتركToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tb_months = New System.Windows.Forms.ComboBox()
        Me.dt_years = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.اضافةالىالمستحقينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.l_count1 = New DevExpress.XtraEditors.LabelControl()
        Me.l_count2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_f1 = New System.Windows.Forms.ComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_f9 = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1121, 27)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 736)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1121, 31)
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 87)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(119, 31)
        Me.SimpleButton2.TabIndex = 370
        Me.SimpleButton2.Text = "طباعة الكل"
        '
        'lv_dept
        '
        Me.lv_dept.BackColor = System.Drawing.Color.MintCream
        Me.lv_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_dept.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lv_dept.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_dept.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lv_dept.FullRowSelect = True
        Me.lv_dept.GridLines = True
        Me.lv_dept.Location = New System.Drawing.Point(12, 124)
        Me.lv_dept.Name = "lv_dept"
        Me.lv_dept.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_dept.RightToLeftLayout = True
        Me.lv_dept.ShowItemToolTips = True
        Me.lv_dept.Size = New System.Drawing.Size(479, 550)
        Me.lv_dept.TabIndex = 367
        Me.lv_dept.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.الديونToolStripMenuItem, Me.حذفToolStripMenuItem, Me.تسديدToolStripMenuItem, Me.تعديلمعلوماتالمشتركToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(197, 114)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem1.Text = "طباعة وصل"
        '
        'الديونToolStripMenuItem
        '
        Me.الديونToolStripMenuItem.Name = "الديونToolStripMenuItem"
        Me.الديونToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.الديونToolStripMenuItem.Text = "الديون"
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'تسديدToolStripMenuItem
        '
        Me.تسديدToolStripMenuItem.Name = "تسديدToolStripMenuItem"
        Me.تسديدToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.تسديدToolStripMenuItem.Text = "تسديد"
        '
        'تعديلمعلوماتالمشتركToolStripMenuItem
        '
        Me.تعديلمعلوماتالمشتركToolStripMenuItem.Name = "تعديلمعلوماتالمشتركToolStripMenuItem"
        Me.تعديلمعلوماتالمشتركToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.تعديلمعلوماتالمشتركToolStripMenuItem.Text = "تعديل معلومات المشترك"
        '
        'tb_months
        '
        Me.tb_months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_months.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tb_months.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_months.FormattingEnabled = True
        Me.tb_months.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.tb_months.Location = New System.Drawing.Point(939, 92)
        Me.tb_months.Name = "tb_months"
        Me.tb_months.Size = New System.Drawing.Size(95, 32)
        Me.tb_months.TabIndex = 371
        '
        'dt_years
        '
        Me.dt_years.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_years.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_years.Location = New System.Drawing.Point(1037, 92)
        Me.dt_years.Name = "dt_years"
        Me.dt_years.Size = New System.Drawing.Size(65, 32)
        Me.dt_years.TabIndex = 372
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(616, 91)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 32)
        Me.SimpleButton1.TabIndex = 373
        Me.SimpleButton1.Text = "بحث"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(1057, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 19)
        Me.LabelControl5.TabIndex = 374
        Me.LabelControl5.Text = "سنة"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(957, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 19)
        Me.LabelControl2.TabIndex = 378
        Me.LabelControl2.Text = "شهر"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(141, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(239, 26)
        Me.LabelControl3.TabIndex = 379
        Me.LabelControl3.Text = "تم تسجيل استحقاق لهذا الشهر"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(495, 390)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(118, 35)
        Me.SimpleButton3.TabIndex = 380
        Me.SimpleButton3.Text = "اضافة"
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(616, 125)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(487, 550)
        Me.lv_queue.TabIndex = 383
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةالىالمستحقينToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 26)
        '
        'اضافةالىالمستحقينToolStripMenuItem
        '
        Me.اضافةالىالمستحقينToolStripMenuItem.Name = "اضافةالىالمستحقينToolStripMenuItem"
        Me.اضافةالىالمستحقينToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.اضافةالىالمستحقينToolStripMenuItem.Text = "اضافة الى المستحقين"
        '
        'l_count1
        '
        Me.l_count1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_count1.Appearance.Options.UseFont = True
        Me.l_count1.Location = New System.Drawing.Point(846, 681)
        Me.l_count1.Name = "l_count1"
        Me.l_count1.Size = New System.Drawing.Size(9, 21)
        Me.l_count1.TabIndex = 386
        Me.l_count1.Text = "0"
        '
        'l_count2
        '
        Me.l_count2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_count2.Appearance.Options.UseFont = True
        Me.l_count2.Location = New System.Drawing.Point(257, 681)
        Me.l_count2.Name = "l_count2"
        Me.l_count2.Size = New System.Drawing.Size(9, 21)
        Me.l_count2.TabIndex = 387
        Me.l_count2.Text = "0"
        '
        'tb_f1
        '
        Me.tb_f1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_f1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tb_f1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f1.FormattingEnabled = True
        Me.tb_f1.Items.AddRange(New Object() {"الكل", "A", "B", "C"})
        Me.tb_f1.Location = New System.Drawing.Point(846, 92)
        Me.tb_f1.Name = "tb_f1"
        Me.tb_f1.Size = New System.Drawing.Size(90, 32)
        Me.tb_f1.TabIndex = 390
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(866, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(14, 19)
        Me.LabelControl1.TabIndex = 391
        Me.LabelControl1.Text = "فئة"
        '
        'tb_f9
        '
        Me.tb_f9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_f9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tb_f9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f9.FormattingEnabled = True
        Me.tb_f9.Items.AddRange(New Object() {"الكل", "المستوى الاول", "المستوى الثاني", "المستوى الثالث"})
        Me.tb_f9.Location = New System.Drawing.Point(708, 92)
        Me.tb_f9.Name = "tb_f9"
        Me.tb_f9.Size = New System.Drawing.Size(135, 32)
        Me.tb_f9.TabIndex = 394
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(750, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl4.TabIndex = 398
        Me.LabelControl4.Text = "مستوى"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(750, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(172, 26)
        Me.LabelControl6.TabIndex = 402
        Me.LabelControl6.Text = "المشتركين المستحقين"
        '
        'fm_months
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 767)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tb_f9)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_f1)
        Me.Controls.Add(Me.l_count2)
        Me.Controls.Add(Me.l_count1)
        Me.Controls.Add(Me.lv_queue)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.dt_years)
        Me.Controls.Add(Me.tb_months)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.lv_dept)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "fm_months"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "استحقاقات الاشهر"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lv_dept As System.Windows.Forms.ListView
    Friend WithEvents tb_months As System.Windows.Forms.ComboBox
    Friend WithEvents dt_years As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents l_count1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents l_count2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_f1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_f9 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents اضافةالىالمستحقينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حذفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الديونToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تسديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلمعلوماتالمشتركToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
