<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_customer
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_customer))
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.li_customer = New System.Windows.Forms.ListView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_search = New DevExpress.XtraEditors.TextEdit()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.num_limit = New System.Windows.Forms.NumericUpDown()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 706)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1008, 23)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1008, 0)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Visible = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'TabPane1
        '
        Me.TabPane1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPane1.Appearance.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.Appearance.Options.UseBackColor = True
        Me.TabPane1.Appearance.Options.UseFont = True
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1008, 706)
        Me.TabPane1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1008, 706)
        Me.TabPane1.TabIndex = 11
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabNavigationPage1.Appearance.BorderColor = System.Drawing.Color.White
        Me.TabNavigationPage1.Appearance.Options.UseBackColor = True
        Me.TabNavigationPage1.Appearance.Options.UseBorderColor = True
        Me.TabNavigationPage1.Caption = "        معلومات الزبائن           "
        Me.TabNavigationPage1.Controls.Add(Me.GroupControl2)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabNavigationPage1.Size = New System.Drawing.Size(986, 666)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(986, 666)
        Me.GroupControl2.TabIndex = 146
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.li_customer)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 22)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl3.Size = New System.Drawing.Size(700, 642)
        Me.GroupControl3.TabIndex = 148
        Me.GroupControl3.Text = "نتائج البحث"
        '
        'li_customer
        '
        Me.li_customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.li_customer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_customer.FullRowSelect = True
        Me.li_customer.GridLines = True
        Me.li_customer.Location = New System.Drawing.Point(2, 22)
        Me.li_customer.MultiSelect = False
        Me.li_customer.Name = "li_customer"
        Me.li_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_customer.RightToLeftLayout = True
        Me.li_customer.Size = New System.Drawing.Size(696, 618)
        Me.li_customer.TabIndex = 1
        Me.li_customer.UseCompatibleStateImageBehavior = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.tb_search)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(702, 22)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(282, 642)
        Me.GroupControl1.TabIndex = 147
        Me.GroupControl1.Text = "بحث"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(76, 77)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton6.Size = New System.Drawing.Size(135, 44)
        Me.SimpleButton6.TabIndex = 113
        Me.SimpleButton6.Text = "بحث"
        '
        'tb_search
        '
        Me.tb_search.EditValue = ""
        Me.tb_search.Location = New System.Drawing.Point(35, 41)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Properties.Appearance.Options.UseFont = True
        Me.tb_search.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_search.Properties.Mask.EditMask = "d"
        Me.tb_search.Size = New System.Drawing.Size(220, 30)
        Me.tb_search.TabIndex = 119
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabNavigationPage2.Appearance.Options.UseBackColor = True
        Me.TabNavigationPage2.Caption = "           اضافة          "
        Me.TabNavigationPage2.Controls.Add(Me.LabelControl3)
        Me.TabNavigationPage2.Controls.Add(Me.LabelControl1)
        Me.TabNavigationPage2.Controls.Add(Me.num_limit)
        Me.TabNavigationPage2.Controls.Add(Me.tb_name)
        Me.TabNavigationPage2.Controls.Add(Me.LabelControl2)
        Me.TabNavigationPage2.Controls.Add(Me.SimpleButton1)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(986, 666)
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(344, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(367, 21)
        Me.LabelControl3.TabIndex = 113
        Me.LabelControl3.Text = "انشاء مجموعة زبائن لغرض طباعة باركود على بطاقة الزبون"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(478, 175)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 22)
        Me.LabelControl1.TabIndex = 112
        Me.LabelControl1.Text = "عدد الزبائن"
        '
        'num_limit
        '
        Me.num_limit.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_limit.Location = New System.Drawing.Point(441, 203)
        Me.num_limit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_limit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_limit.Name = "num_limit"
        Me.num_limit.Size = New System.Drawing.Size(132, 36)
        Me.num_limit.TabIndex = 110
        Me.num_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_limit.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'tb_name
        '
        Me.tb_name.EditValue = ""
        Me.tb_name.Location = New System.Drawing.Point(400, 126)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_name.Size = New System.Drawing.Size(224, 28)
        Me.tb_name.TabIndex = 62
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(478, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 22)
        Me.LabelControl2.TabIndex = 70
        Me.LabelControl2.Text = "اسم الزبون"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(417, 296)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(191, 38)
        Me.SimpleButton1.TabIndex = 72
        Me.SimpleButton1.Text = "حفظ وطباعة"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'fm_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabPane1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الزبائن"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        Me.TabNavigationPage2.PerformLayout()
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num_limit As System.Windows.Forms.NumericUpDown
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents li_customer As System.Windows.Forms.ListView
    Friend WithEvents tb_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
