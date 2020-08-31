<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_other_required
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_add_other_required))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.cb_templet_treat = New System.Windows.Forms.ComboBox()
        Me.ContextMenu_delete_temp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.حذفهذهالوصفةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lv_treat_table = New System.Windows.Forms.ListView()
        Me.Context_treatTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.اضافةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حذفالعلاجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_amount = New DevExpress.XtraEditors.TextEdit()
        Me.lv_dept = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.تسديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تسديدجزءToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_net_dept = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_arrive = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_all_dept = New DevExpress.XtraEditors.TextEdit()
        Me.ContextMenuMonths = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.تسديدToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.طباعةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_search = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu_delete_temp.SuspendLayout()
        Me.Context_treatTable.SuspendLayout()
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_net_dept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_arrive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_all_dept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuMonths.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Right
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1292, 49)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'cb_templet_treat
        '
        Me.cb_templet_treat.BackColor = System.Drawing.Color.Snow
        Me.cb_templet_treat.ContextMenuStrip = Me.ContextMenu_delete_temp
        Me.cb_templet_treat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_templet_treat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_templet_treat.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_templet_treat.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.cb_templet_treat.FormattingEnabled = True
        Me.cb_templet_treat.Location = New System.Drawing.Point(50, 53)
        Me.cb_templet_treat.Name = "cb_templet_treat"
        Me.cb_templet_treat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_templet_treat.Size = New System.Drawing.Size(428, 31)
        Me.cb_templet_treat.TabIndex = 321
        '
        'ContextMenu_delete_temp
        '
        Me.ContextMenu_delete_temp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حذفهذهالوصفةToolStripMenuItem})
        Me.ContextMenu_delete_temp.Name = "ContextMenu_delete_temp"
        Me.ContextMenu_delete_temp.Size = New System.Drawing.Size(100, 26)
        '
        'حذفهذهالوصفةToolStripMenuItem
        '
        Me.حذفهذهالوصفةToolStripMenuItem.Name = "حذفهذهالوصفةToolStripMenuItem"
        Me.حذفهذهالوصفةToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.حذفهذهالوصفةToolStripMenuItem.Text = "حذف"
        '
        'lv_treat_table
        '
        Me.lv_treat_table.BackColor = System.Drawing.Color.MintCream
        Me.lv_treat_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_treat_table.ContextMenuStrip = Me.Context_treatTable
        Me.lv_treat_table.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_treat_table.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lv_treat_table.FullRowSelect = True
        Me.lv_treat_table.GridLines = True
        Me.lv_treat_table.Location = New System.Drawing.Point(50, 86)
        Me.lv_treat_table.MultiSelect = False
        Me.lv_treat_table.Name = "lv_treat_table"
        Me.lv_treat_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_treat_table.RightToLeftLayout = True
        Me.lv_treat_table.ShowItemToolTips = True
        Me.lv_treat_table.Size = New System.Drawing.Size(428, 510)
        Me.lv_treat_table.TabIndex = 320
        Me.lv_treat_table.UseCompatibleStateImageBehavior = False
        '
        'Context_treatTable
        '
        Me.Context_treatTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةToolStripMenuItem, Me.حذفالعلاجToolStripMenuItem, Me.تعديلToolStripMenuItem})
        Me.Context_treatTable.Name = "Context_treatTable"
        Me.Context_treatTable.Size = New System.Drawing.Size(170, 70)
        '
        'اضافةToolStripMenuItem
        '
        Me.اضافةToolStripMenuItem.Name = "اضافةToolStripMenuItem"
        Me.اضافةToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.اضافةToolStripMenuItem.Text = "اضافة الى المشترك"
        '
        'حذفالعلاجToolStripMenuItem
        '
        Me.حذفالعلاجToolStripMenuItem.Name = "حذفالعلاجToolStripMenuItem"
        Me.حذفالعلاجToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.حذفالعلاجToolStripMenuItem.Text = "ازالة"
        '
        'تعديلToolStripMenuItem
        '
        Me.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem"
        Me.تعديلToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.تعديلToolStripMenuItem.Text = "تعديل"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(302, 602)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(176, 36)
        Me.SimpleButton3.TabIndex = 322
        Me.SimpleButton3.Text = "حفظ كجديدة للنظام"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(445, 645)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 21)
        Me.LabelControl2.TabIndex = 338
        Me.LabelControl2.Text = "المبلغ"
        '
        'tb_amount
        '
        Me.tb_amount.EditValue = "0"
        Me.tb_amount.EnterMoveNextControl = True
        Me.tb_amount.Location = New System.Drawing.Point(50, 642)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_amount.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_amount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_amount.Properties.Mask.BeepOnError = True
        Me.tb_amount.Properties.Mask.EditMask = "n0"
        Me.tb_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_amount.Properties.NullValuePrompt = " "
        Me.tb_amount.Properties.ReadOnly = True
        Me.tb_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_amount.Size = New System.Drawing.Size(389, 30)
        Me.tb_amount.TabIndex = 337
        '
        'lv_dept
        '
        Me.lv_dept.BackColor = System.Drawing.Color.Honeydew
        Me.lv_dept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_dept.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_dept.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_dept.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lv_dept.FullRowSelect = True
        Me.lv_dept.GridLines = True
        Me.lv_dept.Location = New System.Drawing.Point(5, 106)
        Me.lv_dept.Name = "lv_dept"
        Me.lv_dept.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_dept.RightToLeftLayout = True
        Me.lv_dept.ShowItemToolTips = True
        Me.lv_dept.Size = New System.Drawing.Size(770, 513)
        Me.lv_dept.TabIndex = 342
        Me.lv_dept.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تسديدToolStripMenuItem, Me.حذفToolStripMenuItem, Me.تسديدجزءToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 70)
        '
        'تسديدToolStripMenuItem
        '
        Me.تسديدToolStripMenuItem.Name = "تسديدToolStripMenuItem"
        Me.تسديدToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.تسديدToolStripMenuItem.Text = "تسديد هذه الديون"
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'تسديدجزءToolStripMenuItem
        '
        Me.تسديدجزءToolStripMenuItem.Name = "تسديدجزءToolStripMenuItem"
        Me.تسديدجزءToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.تسديدجزءToolStripMenuItem.Text = "تسديد جزء"
        '
        'tb_id
        '
        Me.tb_id.EnterMoveNextControl = True
        Me.tb_id.Location = New System.Drawing.Point(550, 72)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.NullValuePrompt = "الاسم"
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(75, 32)
        Me.tb_id.TabIndex = 347
        '
        'tb_name
        '
        Me.tb_name.EnterMoveNextControl = True
        Me.tb_name.Location = New System.Drawing.Point(5, 72)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.NullValuePrompt = "الاسم"
        Me.tb_name.Properties.ReadOnly = True
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_name.Size = New System.Drawing.Size(545, 32)
        Me.tb_name.TabIndex = 345
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(681, 670)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 21)
        Me.LabelControl3.TabIndex = 350
        Me.LabelControl3.Text = "صافي الدين"
        '
        'tb_net_dept
        '
        Me.tb_net_dept.EditValue = "0"
        Me.tb_net_dept.EnterMoveNextControl = True
        Me.tb_net_dept.Location = New System.Drawing.Point(429, 665)
        Me.tb_net_dept.Name = "tb_net_dept"
        Me.tb_net_dept.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_net_dept.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_net_dept.Properties.Appearance.Options.UseFont = True
        Me.tb_net_dept.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_net_dept.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_net_dept.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_net_dept.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_net_dept.Properties.Mask.BeepOnError = True
        Me.tb_net_dept.Properties.Mask.EditMask = "n0"
        Me.tb_net_dept.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_net_dept.Properties.NullValuePrompt = " "
        Me.tb_net_dept.Properties.ReadOnly = True
        Me.tb_net_dept.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_net_dept.Size = New System.Drawing.Size(246, 30)
        Me.tb_net_dept.TabIndex = 349
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(681, 625)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(94, 36)
        Me.SimpleButton2.TabIndex = 351
        Me.SimpleButton2.Text = "طباعة"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 330)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 35)
        Me.SimpleButton1.TabIndex = 354
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(353, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(132, 21)
        Me.LabelControl4.TabIndex = 357
        Me.LabelControl4.Text = "الديون الاخرى للزبون"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(429, 625)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(246, 36)
        Me.SimpleButton4.TabIndex = 359
        Me.SimpleButton4.Text = "تسديد كل الديوم"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(50, 602)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(176, 36)
        Me.SimpleButton6.TabIndex = 362
        Me.SimpleButton6.Text = "حفظ التعديلات في النظام"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(244, 602)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(40, 36)
        Me.SimpleButton7.TabIndex = 363
        Me.SimpleButton7.Text = "اضافة"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(629, 602)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 21)
        Me.LabelControl1.TabIndex = 365
        Me.LabelControl1.Text = "التسديد الجزئي"
        Me.LabelControl1.Visible = False
        '
        'tb_arrive
        '
        Me.tb_arrive.EditValue = "0"
        Me.tb_arrive.EnterMoveNextControl = True
        Me.tb_arrive.Location = New System.Drawing.Point(385, 596)
        Me.tb_arrive.Name = "tb_arrive"
        Me.tb_arrive.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_arrive.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arrive.Properties.Appearance.Options.UseFont = True
        Me.tb_arrive.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_arrive.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_arrive.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_arrive.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_arrive.Properties.Mask.BeepOnError = True
        Me.tb_arrive.Properties.Mask.EditMask = "n0"
        Me.tb_arrive.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_arrive.Properties.NullValuePrompt = " "
        Me.tb_arrive.Properties.ReadOnly = True
        Me.tb_arrive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_arrive.Size = New System.Drawing.Size(238, 30)
        Me.tb_arrive.TabIndex = 364
        Me.tb_arrive.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(629, 567)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl6.TabIndex = 367
        Me.LabelControl6.Text = "مبلغ الدين الكلي"
        Me.LabelControl6.Visible = False
        '
        'tb_all_dept
        '
        Me.tb_all_dept.EditValue = "0"
        Me.tb_all_dept.EnterMoveNextControl = True
        Me.tb_all_dept.Location = New System.Drawing.Point(385, 564)
        Me.tb_all_dept.Name = "tb_all_dept"
        Me.tb_all_dept.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_all_dept.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_all_dept.Properties.Appearance.Options.UseFont = True
        Me.tb_all_dept.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_all_dept.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_all_dept.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_all_dept.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_all_dept.Properties.Mask.BeepOnError = True
        Me.tb_all_dept.Properties.Mask.EditMask = "n0"
        Me.tb_all_dept.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_all_dept.Properties.NullValuePrompt = " "
        Me.tb_all_dept.Properties.ReadOnly = True
        Me.tb_all_dept.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_all_dept.Size = New System.Drawing.Size(238, 30)
        Me.tb_all_dept.TabIndex = 366
        Me.tb_all_dept.Visible = False
        '
        'ContextMenuMonths
        '
        Me.ContextMenuMonths.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تسديدToolStripMenuItem1, Me.طباعةToolStripMenuItem})
        Me.ContextMenuMonths.Name = "ContextMenuMonths"
        Me.ContextMenuMonths.Size = New System.Drawing.Size(105, 48)
        '
        'تسديدToolStripMenuItem1
        '
        Me.تسديدToolStripMenuItem1.Name = "تسديدToolStripMenuItem1"
        Me.تسديدToolStripMenuItem1.Size = New System.Drawing.Size(104, 22)
        Me.تسديدToolStripMenuItem1.Text = "تسديد"
        '
        'طباعةToolStripMenuItem
        '
        Me.طباعةToolStripMenuItem.Name = "طباعةToolStripMenuItem"
        Me.طباعةToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.طباعةToolStripMenuItem.Text = "طباعة"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(996, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(83, 25)
        Me.CheckBox1.TabIndex = 383
        Me.CheckBox1.Text = "مقترحات"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cb_templet_treat)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.tb_amount)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.SimpleButton7)
        Me.GroupControl1.Controls.Add(Me.lv_treat_table)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(781, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(509, 685)
        Me.GroupControl1.TabIndex = 384
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton5)
        Me.GroupControl2.Controls.Add(Me.SimpleButton9)
        Me.GroupControl2.Controls.Add(Me.tb_search)
        Me.GroupControl2.Controls.Add(Me.tb_name)
        Me.GroupControl2.Controls.Add(Me.tb_id)
        Me.GroupControl2.Controls.Add(Me.CheckBox1)
        Me.GroupControl2.Controls.Add(Me.lv_dept)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.SimpleButton2)
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Controls.Add(Me.tb_net_dept)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(0, 49)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1292, 707)
        Me.GroupControl2.TabIndex = 386
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.ImageOptions.Image = CType(resources.GetObject("SimpleButton9.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(628, 71)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(146, 32)
        Me.SimpleButton9.TabIndex = 384
        Me.SimpleButton9.Text = "باركود الزبون"
        '
        'tb_search
        '
        Me.tb_search.EditValue = ""
        Me.tb_search.Location = New System.Drawing.Point(177, 34)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Properties.Appearance.Options.UseFont = True
        Me.tb_search.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_search.Properties.Mask.EditMask = "d"
        Me.tb_search.Size = New System.Drawing.Size(136, 30)
        Me.tb_search.TabIndex = 383
        Me.tb_search.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(5, 625)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(163, 36)
        Me.SimpleButton5.TabIndex = 385
        Me.SimpleButton5.Text = "قفل التعديلات"
        '
        'fm_add_other_required
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseTextOptions = True
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 756)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.tb_arrive)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_all_dept)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_add_other_required"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استحقاقات اخرى للزبون"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu_delete_temp.ResumeLayout(False)
        Me.Context_treatTable.ResumeLayout(False)
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_net_dept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_arrive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_all_dept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuMonths.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents cb_templet_treat As System.Windows.Forms.ComboBox
    Friend WithEvents lv_treat_table As System.Windows.Forms.ListView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenu_delete_temp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents حذفهذهالوصفةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Context_treatTable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents حذفالعلاجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lv_dept As System.Windows.Forms.ListView
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_net_dept As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents تسديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_arrive As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_all_dept As DevExpress.XtraEditors.TextEdit
    Friend WithEvents حذفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents تسديدجزءToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuMonths As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents تسديدToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents طباعةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
