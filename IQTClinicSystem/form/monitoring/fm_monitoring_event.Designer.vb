﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_monitoring_event
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_monitoring_event))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.li_event = New System.Windows.Forms.ListView()
        Me.li_user = New System.Windows.Forms.ListView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_user_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_username = New DevExpress.XtraEditors.TextEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_come = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_net = New DevExpress.XtraEditors.TextEdit()
        Me.tb_out = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_come.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_net.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_out.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1024, 27)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 736)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1024, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.li_event)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 27)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(1024, 331)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "العمليات"
        '
        'li_event
        '
        Me.li_event.Dock = System.Windows.Forms.DockStyle.Fill
        Me.li_event.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_event.FullRowSelect = True
        Me.li_event.GridLines = True
        Me.li_event.Location = New System.Drawing.Point(2, 20)
        Me.li_event.MultiSelect = False
        Me.li_event.Name = "li_event"
        Me.li_event.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_event.RightToLeftLayout = True
        Me.li_event.Size = New System.Drawing.Size(1020, 309)
        Me.li_event.TabIndex = 119
        Me.li_event.UseCompatibleStateImageBehavior = False
        '
        'li_user
        '
        Me.li_user.Dock = System.Windows.Forms.DockStyle.Right
        Me.li_user.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_user.FullRowSelect = True
        Me.li_user.GridLines = True
        Me.li_user.Location = New System.Drawing.Point(837, 358)
        Me.li_user.MultiSelect = False
        Me.li_user.Name = "li_user"
        Me.li_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_user.RightToLeftLayout = True
        Me.li_user.Size = New System.Drawing.Size(187, 378)
        Me.li_user.TabIndex = 148
        Me.li_user.UseCompatibleStateImageBehavior = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.tb_user_id)
        Me.GroupControl2.Controls.Add(Me.tb_username)
        Me.GroupControl2.Controls.Add(Me.DateTimePicker1)
        Me.GroupControl2.Controls.Add(Me.DateTimePicker2)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.SimpleButton6)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(554, 358)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(283, 378)
        Me.GroupControl2.TabIndex = 149
        Me.GroupControl2.Text = "بحث"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(16, 198)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 46)
        Me.SimpleButton1.TabIndex = 145
        Me.SimpleButton1.Text = "كل المستخدمين"
        '
        'tb_user_id
        '
        Me.tb_user_id.EditValue = ""
        Me.tb_user_id.Location = New System.Drawing.Point(32, 267)
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
        Me.tb_username.Location = New System.Drawing.Point(32, 55)
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(70, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 32)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(70, 151)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(135, 32)
        Me.DateTimePicker2.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(214, 109)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 22)
        Me.LabelControl8.TabIndex = 82
        Me.LabelControl8.Text = "من"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(214, 159)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 22)
        Me.LabelControl9.TabIndex = 83
        Me.LabelControl9.Text = "الى"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(145, 198)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton6.Size = New System.Drawing.Size(122, 46)
        Me.SimpleButton6.TabIndex = 113
        Me.SimpleButton6.Text = "المستخدم الحالي"
        '
        'tb_come
        '
        Me.tb_come.EditValue = "0"
        Me.tb_come.Location = New System.Drawing.Point(141, 486)
        Me.tb_come.Name = "tb_come"
        Me.tb_come.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_come.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_come.Properties.Appearance.Options.UseBackColor = True
        Me.tb_come.Properties.Appearance.Options.UseFont = True
        Me.tb_come.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_come.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_come.Properties.ReadOnly = True
        Me.tb_come.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_come.Size = New System.Drawing.Size(265, 28)
        Me.tb_come.TabIndex = 152
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Location = New System.Drawing.Point(415, 539)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(98, 22)
        Me.LabelControl32.TabIndex = 161
        Me.LabelControl32.Text = "سحب وصرفيات"
        '
        'tb_net
        '
        Me.tb_net.EditValue = "0"
        Me.tb_net.Location = New System.Drawing.Point(141, 586)
        Me.tb_net.Name = "tb_net"
        Me.tb_net.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_net.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_net.Properties.Appearance.Options.UseBackColor = True
        Me.tb_net.Properties.Appearance.Options.UseFont = True
        Me.tb_net.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_net.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_net.Properties.ReadOnly = True
        Me.tb_net.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_net.Size = New System.Drawing.Size(265, 28)
        Me.tb_net.TabIndex = 154
        '
        'tb_out
        '
        Me.tb_out.EditValue = "0"
        Me.tb_out.Location = New System.Drawing.Point(141, 536)
        Me.tb_out.Name = "tb_out"
        Me.tb_out.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_out.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_out.Properties.Appearance.Options.UseBackColor = True
        Me.tb_out.Properties.Appearance.Options.UseFont = True
        Me.tb_out.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_out.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_out.Properties.ReadOnly = True
        Me.tb_out.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_out.Size = New System.Drawing.Size(265, 28)
        Me.tb_out.TabIndex = 155
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(412, 489)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(70, 22)
        Me.LabelControl10.TabIndex = 156
        Me.LabelControl10.Text = "مبالغ واردة"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(415, 589)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 22)
        Me.LabelControl1.TabIndex = 163
        Me.LabelControl1.Text = "صافي الدخل"
        '
        'fm_monitoring_event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 767)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_come)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.tb_net)
        Me.Controls.Add(Me.tb_out)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.li_user)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_monitoring_event"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "مراقبة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_come.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_net.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_out.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents li_event As System.Windows.Forms.ListView
    Friend WithEvents li_user As System.Windows.Forms.ListView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_user_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_come As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_net As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_out As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
