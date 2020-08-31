<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_user_rest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_user_rest))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_type = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_minute = New DevExpress.XtraEditors.TextEdit()
        Me.li_rest_type = New System.Windows.Forms.ListView()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.tb_user_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_username = New DevExpress.XtraEditors.TextEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.li_rest = New System.Windows.Forms.ListView()
        Me.li_user = New System.Windows.Forms.ListView()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.tb_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_minute.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1016, 27)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 736)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1016, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabNavigationPage2.Appearance.Options.UseBackColor = True
        Me.TabNavigationPage2.Caption = "           ديون          "
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(994, 674)
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabNavigationPage1.Appearance.BorderColor = System.Drawing.Color.White
        Me.TabNavigationPage1.Appearance.Options.UseBackColor = True
        Me.TabNavigationPage1.Appearance.Options.UseBorderColor = True
        Me.TabNavigationPage1.Caption = "        استراحات           "
        Me.TabNavigationPage1.Controls.Add(Me.GroupControl3)
        Me.TabNavigationPage1.Controls.Add(Me.GroupControl2)
        Me.TabNavigationPage1.Controls.Add(Me.li_rest)
        Me.TabNavigationPage1.Controls.Add(Me.li_user)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabNavigationPage1.Size = New System.Drawing.Size(998, 664)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Controls.Add(Me.tb_type)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.tb_minute)
        Me.GroupControl3.Controls.Add(Me.li_rest_type)
        Me.GroupControl3.Controls.Add(Me.SimpleButton4)
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 289)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupControl3.Size = New System.Drawing.Size(578, 375)
        Me.GroupControl3.TabIndex = 147
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(25, 291)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton1.Size = New System.Drawing.Size(211, 55)
        Me.SimpleButton1.TabIndex = 149
        Me.SimpleButton1.Text = "تسجيل حظور"
        '
        'tb_type
        '
        Me.tb_type.EditValue = ""
        Me.tb_type.Location = New System.Drawing.Point(146, 52)
        Me.tb_type.Name = "tb_type"
        Me.tb_type.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_type.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_type.Properties.Appearance.Options.UseBackColor = True
        Me.tb_type.Properties.Appearance.Options.UseFont = True
        Me.tb_type.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_type.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_type.Properties.ReadOnly = True
        Me.tb_type.Size = New System.Drawing.Size(119, 28)
        Me.tb_type.TabIndex = 145
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(129, 95)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 22)
        Me.LabelControl4.TabIndex = 145
        Me.LabelControl4.Text = "دقيقة"
        '
        'tb_minute
        '
        Me.tb_minute.EditValue = "0"
        Me.tb_minute.Location = New System.Drawing.Point(165, 86)
        Me.tb_minute.Name = "tb_minute"
        Me.tb_minute.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_minute.Properties.Appearance.Options.UseFont = True
        Me.tb_minute.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_minute.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_minute.Size = New System.Drawing.Size(83, 38)
        Me.tb_minute.TabIndex = 148
        '
        'li_rest_type
        '
        Me.li_rest_type.Dock = System.Windows.Forms.DockStyle.Right
        Me.li_rest_type.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_rest_type.FullRowSelect = True
        Me.li_rest_type.GridLines = True
        Me.li_rest_type.Location = New System.Drawing.Point(275, 20)
        Me.li_rest_type.MultiSelect = False
        Me.li_rest_type.Name = "li_rest_type"
        Me.li_rest_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_rest_type.RightToLeftLayout = True
        Me.li_rest_type.Size = New System.Drawing.Size(301, 353)
        Me.li_rest_type.TabIndex = 147
        Me.li_rest_type.UseCompatibleStateImageBehavior = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(25, 110)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 55)
        Me.SimpleButton4.TabIndex = 146
        Me.SimpleButton4.Text = "عودة"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(25, 37)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 55)
        Me.SimpleButton3.TabIndex = 145
        Me.SimpleButton3.Text = "ذهاب"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.tb_user_id)
        Me.GroupControl2.Controls.Add(Me.tb_username)
        Me.GroupControl2.Controls.Add(Me.DateTimePicker1)
        Me.GroupControl2.Controls.Add(Me.DateTimePicker2)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.SimpleButton6)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(578, 289)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(233, 375)
        Me.GroupControl2.TabIndex = 146
        Me.GroupControl2.Text = "بحث"
        '
        'tb_user_id
        '
        Me.tb_user_id.EditValue = ""
        Me.tb_user_id.Location = New System.Drawing.Point(5, 318)
        Me.tb_user_id.Name = "tb_user_id"
        Me.tb_user_id.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_user_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user_id.Properties.Appearance.Options.UseBackColor = True
        Me.tb_user_id.Properties.Appearance.Options.UseFont = True
        Me.tb_user_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_user_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_user_id.Properties.ReadOnly = True
        Me.tb_user_id.Size = New System.Drawing.Size(221, 28)
        Me.tb_user_id.TabIndex = 144
        Me.tb_user_id.Visible = False
        '
        'tb_username
        '
        Me.tb_username.EditValue = ""
        Me.tb_username.Location = New System.Drawing.Point(6, 64)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.Properties.Appearance.Options.UseBackColor = True
        Me.tb_username.Properties.Appearance.Options.UseFont = True
        Me.tb_username.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_username.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_username.Properties.ReadOnly = True
        Me.tb_username.Size = New System.Drawing.Size(221, 28)
        Me.tb_username.TabIndex = 143
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(45, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 32)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(45, 156)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(135, 32)
        Me.DateTimePicker2.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(189, 110)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 22)
        Me.LabelControl8.TabIndex = 82
        Me.LabelControl8.Text = "من"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(189, 160)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 22)
        Me.LabelControl9.TabIndex = 83
        Me.LabelControl9.Text = "الى"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(45, 205)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton6.Size = New System.Drawing.Size(135, 62)
        Me.SimpleButton6.TabIndex = 113
        Me.SimpleButton6.Text = "بحث"
        '
        'li_rest
        '
        Me.li_rest.Dock = System.Windows.Forms.DockStyle.Top
        Me.li_rest.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_rest.FullRowSelect = True
        Me.li_rest.GridLines = True
        Me.li_rest.Location = New System.Drawing.Point(0, 0)
        Me.li_rest.MultiSelect = False
        Me.li_rest.Name = "li_rest"
        Me.li_rest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_rest.RightToLeftLayout = True
        Me.li_rest.Size = New System.Drawing.Size(811, 289)
        Me.li_rest.TabIndex = 3
        Me.li_rest.UseCompatibleStateImageBehavior = False
        '
        'li_user
        '
        Me.li_user.Dock = System.Windows.Forms.DockStyle.Right
        Me.li_user.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_user.FullRowSelect = True
        Me.li_user.GridLines = True
        Me.li_user.Location = New System.Drawing.Point(811, 0)
        Me.li_user.MultiSelect = False
        Me.li_user.Name = "li_user"
        Me.li_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_user.RightToLeftLayout = True
        Me.li_user.Size = New System.Drawing.Size(187, 664)
        Me.li_user.TabIndex = 1
        Me.li_user.UseCompatibleStateImageBehavior = False
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
        Me.TabPane1.Location = New System.Drawing.Point(0, 27)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1016, 709)
        Me.TabPane1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1016, 709)
        Me.TabPane1.TabIndex = 10
        Me.TabPane1.Text = "TabPane1"
        '
        'fm_user_rest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 767)
        Me.Controls.Add(Me.TabPane1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_user_rest"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "استراحات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.tb_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_minute.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_minute As DevExpress.XtraEditors.TextEdit
    Friend WithEvents li_rest_type As System.Windows.Forms.ListView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_user_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents li_rest As System.Windows.Forms.ListView
    Friend WithEvents li_user As System.Windows.Forms.ListView
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tb_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
