<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_pull_money
    Inherits DevExpress.XtraBars.TabForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_pull_money))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.TabFormContentContainer1 = New DevExpress.XtraBars.TabFormContentContainer()
        Me.TabFormPage1 = New DevExpress.XtraBars.TabFormPage()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.r_back_monwy = New System.Windows.Forms.RadioButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.r_recive = New System.Windows.Forms.RadioButton()
        Me.r_buy = New System.Windows.Forms.RadioButton()
        Me.r_things = New System.Windows.Forms.RadioButton()
        Me.r_pull = New System.Windows.Forms.RadioButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_note = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_amount = New DevExpress.XtraEditors.TextEdit()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.li_user = New System.Windows.Forms.ListView()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.Size = New System.Drawing.Size(821, 50)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 2
        Me.TabFormControl1.TabStop = False
        '
        'TabFormContentContainer1
        '
        Me.TabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFormContentContainer1.Location = New System.Drawing.Point(0, 48)
        Me.TabFormContentContainer1.Name = "TabFormContentContainer1"
        Me.TabFormContentContainer1.Size = New System.Drawing.Size(334, 213)
        Me.TabFormContentContainer1.TabIndex = 3
        '
        'TabFormPage1
        '
        Me.TabFormPage1.ContentContainer = Me.TabFormContentContainer1
        Me.TabFormPage1.Name = "TabFormPage1"
        Me.TabFormPage1.Text = "Page 0"
        '
        'TabPane1
        '
        Me.TabPane1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPane1.Appearance.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.Appearance.Options.UseBackColor = True
        Me.TabPane1.Appearance.Options.UseFont = True
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.Location = New System.Drawing.Point(0, 50)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(821, 618)
        Me.TabPane1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(821, 618)
        Me.TabPane1.TabIndex = 10
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabNavigationPage1.Appearance.BorderColor = System.Drawing.Color.White
        Me.TabNavigationPage1.Appearance.Options.UseBackColor = True
        Me.TabNavigationPage1.Appearance.Options.UseBorderColor = True
        Me.TabNavigationPage1.Caption = "        المستخدمين           "
        Me.TabNavigationPage1.Controls.Add(Me.GroupControl3)
        Me.TabNavigationPage1.Controls.Add(Me.li_user)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabNavigationPage1.Size = New System.Drawing.Size(803, 573)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.GroupControl1)
        Me.GroupControl3.Controls.Add(Me.tb_id)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.tb_note)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Controls.Add(Me.tb_amount)
        Me.GroupControl3.Controls.Add(Me.tb_name)
        Me.GroupControl3.Controls.Add(Me.SimpleButton6)
        Me.GroupControl3.Controls.Add(Me.LabelControl28)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupControl3.Size = New System.Drawing.Size(546, 573)
        Me.GroupControl3.TabIndex = 145
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(408, 452)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(124, 22)
        Me.LabelControl6.TabIndex = 163
        Me.LabelControl6.Text = "ملاحظة حول العملية"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(408, 416)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 22)
        Me.LabelControl5.TabIndex = 162
        Me.LabelControl5.Text = "المبلغ"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.r_back_monwy)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.r_recive)
        Me.GroupControl1.Controls.Add(Me.r_buy)
        Me.GroupControl1.Controls.Add(Me.r_things)
        Me.GroupControl1.Controls.Add(Me.r_pull)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(30, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(372, 332)
        Me.GroupControl1.TabIndex = 161
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(190, 156)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(174, 22)
        Me.LabelControl4.TabIndex = 161
        Me.LabelControl4.Text = "سحوبات اخرى غير شخصيه"
        '
        'r_back_monwy
        '
        Me.r_back_monwy.AutoSize = True
        Me.r_back_monwy.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_back_monwy.ForeColor = System.Drawing.Color.Green
        Me.r_back_monwy.Location = New System.Drawing.Point(32, 276)
        Me.r_back_monwy.Name = "r_back_monwy"
        Me.r_back_monwy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.r_back_monwy.Size = New System.Drawing.Size(255, 40)
        Me.r_back_monwy.TabIndex = 102
        Me.r_back_monwy.Text = "ارجاع مبلغ الى الدخل"
        Me.r_back_monwy.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(280, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 22)
        Me.LabelControl3.TabIndex = 160
        Me.LabelControl3.Text = "سحب شخصي"
        '
        'r_recive
        '
        Me.r_recive.AutoSize = True
        Me.r_recive.Enabled = False
        Me.r_recive.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_recive.ForeColor = System.Drawing.Color.Green
        Me.r_recive.Location = New System.Drawing.Point(42, 88)
        Me.r_recive.Name = "r_recive"
        Me.r_recive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.r_recive.Size = New System.Drawing.Size(217, 40)
        Me.r_recive.TabIndex = 101
        Me.r_recive.Text = "تسديد سحب عامل"
        Me.r_recive.UseVisualStyleBackColor = True
        '
        'r_buy
        '
        Me.r_buy.AutoSize = True
        Me.r_buy.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_buy.Location = New System.Drawing.Point(161, 230)
        Me.r_buy.Name = "r_buy"
        Me.r_buy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.r_buy.Size = New System.Drawing.Size(126, 40)
        Me.r_buy.TabIndex = 100
        Me.r_buy.Text = "مصاريف"
        Me.r_buy.UseVisualStyleBackColor = True
        '
        'r_things
        '
        Me.r_things.AutoSize = True
        Me.r_things.Checked = True
        Me.r_things.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_things.Location = New System.Drawing.Point(209, 184)
        Me.r_things.Name = "r_things"
        Me.r_things.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.r_things.Size = New System.Drawing.Size(78, 40)
        Me.r_things.TabIndex = 99
        Me.r_things.TabStop = True
        Me.r_things.Text = "اثاث"
        Me.r_things.UseVisualStyleBackColor = True
        '
        'r_pull
        '
        Me.r_pull.AutoSize = True
        Me.r_pull.Enabled = False
        Me.r_pull.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_pull.ForeColor = System.Drawing.Color.Maroon
        Me.r_pull.Location = New System.Drawing.Point(169, 42)
        Me.r_pull.Name = "r_pull"
        Me.r_pull.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.r_pull.Size = New System.Drawing.Size(90, 40)
        Me.r_pull.TabIndex = 98
        Me.r_pull.Text = "سحب"
        Me.r_pull.UseVisualStyleBackColor = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Location = New System.Drawing.Point(0, 134)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(372, 18)
        Me.GroupControl2.TabIndex = 162
        '
        'tb_id
        '
        Me.tb_id.EditValue = ""
        Me.tb_id.Location = New System.Drawing.Point(305, 25)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_id.Size = New System.Drawing.Size(95, 28)
        Me.tb_id.TabIndex = 158
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(257, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 22)
        Me.LabelControl2.TabIndex = 157
        Me.LabelControl2.Text = "الاسم"
        '
        'tb_note
        '
        Me.tb_note.EditValue = ""
        Me.tb_note.Location = New System.Drawing.Point(30, 449)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Properties.Appearance.Options.UseFont = True
        Me.tb_note.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_note.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_note.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_note.Size = New System.Drawing.Size(372, 28)
        Me.tb_note.TabIndex = 155
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(708, 565)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 22)
        Me.LabelControl1.TabIndex = 156
        Me.LabelControl1.Text = "ملاحظة"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(416, 28)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(91, 22)
        Me.LabelControl23.TabIndex = 149
        Me.LabelControl23.Text = "سحوبات الدخل"
        '
        'tb_amount
        '
        Me.tb_amount.EditValue = ""
        Me.tb_amount.Location = New System.Drawing.Point(30, 401)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_amount.Size = New System.Drawing.Size(372, 42)
        Me.tb_amount.TabIndex = 144
        '
        'tb_name
        '
        Me.tb_name.EditValue = ""
        Me.tb_name.Location = New System.Drawing.Point(30, 25)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_name.Properties.ReadOnly = True
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_name.Size = New System.Drawing.Size(211, 28)
        Me.tb_name.TabIndex = 140
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(135, 484)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton6.Size = New System.Drawing.Size(183, 62)
        Me.SimpleButton6.TabIndex = 113
        Me.SimpleButton6.Text = "حفظ وطباعة"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Location = New System.Drawing.Point(621, 502)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(69, 22)
        Me.LabelControl28.TabIndex = 154
        Me.LabelControl28.Text = "ادخل المبلغ"
        '
        'li_user
        '
        Me.li_user.Dock = System.Windows.Forms.DockStyle.Right
        Me.li_user.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_user.FullRowSelect = True
        Me.li_user.GridLines = True
        Me.li_user.Location = New System.Drawing.Point(546, 0)
        Me.li_user.MultiSelect = False
        Me.li_user.Name = "li_user"
        Me.li_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_user.RightToLeftLayout = True
        Me.li_user.Size = New System.Drawing.Size(257, 573)
        Me.li_user.TabIndex = 1
        Me.li_user.UseCompatibleStateImageBehavior = False
        '
        'fm_pull_money
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 668)
        Me.Controls.Add(Me.TabPane1)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Name = "fm_pull_money"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "سحب"
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
    Friend WithEvents TabFormContentContainer1 As DevExpress.XtraBars.TabFormContentContainer
    Friend WithEvents TabFormPage1 As DevExpress.XtraBars.TabFormPage
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents li_user As System.Windows.Forms.ListView
    Friend WithEvents tb_note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents r_buy As System.Windows.Forms.RadioButton
    Friend WithEvents r_things As System.Windows.Forms.RadioButton
    Friend WithEvents r_pull As System.Windows.Forms.RadioButton
    Friend WithEvents r_recive As System.Windows.Forms.RadioButton
    Friend WithEvents r_back_monwy As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
