﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_show_patients
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
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.عرضاوتعديلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةحجزعمليةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ارشفةبياناتالمراجعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تفعيلالحسابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةملفاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_plan = New System.Windows.Forms.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.p_patient = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.num_limit = New System.Windows.Forms.NumericUpDown()
        Me.tb_f1 = New System.Windows.Forms.ComboBox()
        Me.tb_f2 = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.tb_user = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem2 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_main = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem3 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.tb_count = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarHeaderItem4 = New DevExpress.XtraBars.BarHeaderItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_f2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(2, 20)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(1018, 678)
        Me.lv_queue.TabIndex = 1
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.عرضاوتعديلToolStripMenuItem, Me.اضافةحجزعمليةToolStripMenuItem, Me.ارشفةبياناتالمراجعToolStripMenuItem, Me.تفعيلالحسابToolStripMenuItem, Me.اضافةملفاتToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 114)
        '
        'عرضاوتعديلToolStripMenuItem
        '
        Me.عرضاوتعديلToolStripMenuItem.Name = "عرضاوتعديلToolStripMenuItem"
        Me.عرضاوتعديلToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.عرضاوتعديلToolStripMenuItem.Text = "تحديث المعلومات"
        '
        'اضافةحجزعمليةToolStripMenuItem
        '
        Me.اضافةحجزعمليةToolStripMenuItem.Name = "اضافةحجزعمليةToolStripMenuItem"
        Me.اضافةحجزعمليةToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.اضافةحجزعمليةToolStripMenuItem.Text = "عرض العقد"
        '
        'ارشفةبياناتالمراجعToolStripMenuItem
        '
        Me.ارشفةبياناتالمراجعToolStripMenuItem.Name = "ارشفةبياناتالمراجعToolStripMenuItem"
        Me.ارشفةبياناتالمراجعToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ارشفةبياناتالمراجعToolStripMenuItem.Text = "تعطيل الحساب مؤقتا"
        '
        'تفعيلالحسابToolStripMenuItem
        '
        Me.تفعيلالحسابToolStripMenuItem.Name = "تفعيلالحسابToolStripMenuItem"
        Me.تفعيلالحسابToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.تفعيلالحسابToolStripMenuItem.Text = "تفعيل الحساب"
        '
        'اضافةملفاتToolStripMenuItem
        '
        Me.اضافةملفاتToolStripMenuItem.Name = "اضافةملفاتToolStripMenuItem"
        Me.اضافةملفاتToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.اضافةملفاتToolStripMenuItem.Text = "اضافة ملفات"
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(57, 61)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.NullValuePrompt = "الاسم"
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_name.Size = New System.Drawing.Size(163, 26)
        Me.tb_name.TabIndex = 213
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.Label3)
        Me.GroupControl6.Controls.Add(Me.cb_plan)
        Me.GroupControl6.Controls.Add(Me.GroupControl1)
        Me.GroupControl6.Controls.Add(Me.RadioButton2)
        Me.GroupControl6.Controls.Add(Me.RadioButton1)
        Me.GroupControl6.Controls.Add(Me.Label2)
        Me.GroupControl6.Controls.Add(Me.p_patient)
        Me.GroupControl6.Controls.Add(Me.PictureBox6)
        Me.GroupControl6.Controls.Add(Me.LabelControl1)
        Me.GroupControl6.Controls.Add(Me.num_limit)
        Me.GroupControl6.Controls.Add(Me.tb_f1)
        Me.GroupControl6.Controls.Add(Me.tb_f2)
        Me.GroupControl6.Controls.Add(Me.PictureBox3)
        Me.GroupControl6.Controls.Add(Me.PictureBox2)
        Me.GroupControl6.Controls.Add(Me.Label4)
        Me.GroupControl6.Controls.Add(Me.tb_name)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl6.Location = New System.Drawing.Point(1022, 49)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(348, 700)
        Me.GroupControl6.TabIndex = 261
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 294
        Me.Label3.Text = "ترتيب حسب"
        '
        'cb_plan
        '
        Me.cb_plan.BackColor = System.Drawing.Color.White
        Me.cb_plan.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.cb_plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cb_plan.FormattingEnabled = True
        Me.cb_plan.Items.AddRange(New Object() {"%", "حجز", "تعاقد", "تم الاستلام"})
        Me.cb_plan.Location = New System.Drawing.Point(57, 116)
        Me.cb_plan.Name = "cb_plan"
        Me.cb_plan.Size = New System.Drawing.Size(163, 29)
        Me.cb_plan.TabIndex = 293
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.tb_id)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 196)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(273, 120)
        Me.GroupControl1.TabIndex = 262
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IQTClinicSystem.My.Resources.Resources.certificate_icon
        Me.PictureBox1.Location = New System.Drawing.Point(193, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 253
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 257
        Me.Label1.Text = "بوساطة رقم الدار"
        '
        'tb_id
        '
        Me.tb_id.Location = New System.Drawing.Point(16, 50)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.Mask.EditMask = "d"
        Me.tb_id.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_id.Properties.NullValuePrompt = "رقم الدار"
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(171, 26)
        Me.tb_id.TabIndex = 213
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(10, 158)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(105, 26)
        Me.RadioButton2.TabIndex = 292
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "البلوك والدار"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(120, 158)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton1.Size = New System.Drawing.Size(70, 26)
        Me.RadioButton1.TabIndex = 291
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "الاحدث"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 500)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 288
        Me.Label2.Text = "عرض المجلد"
        '
        'p_patient
        '
        Me.p_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p_patient.Location = New System.Drawing.Point(10, 332)
        Me.p_patient.Name = "p_patient"
        Me.p_patient.Size = New System.Drawing.Size(257, 160)
        Me.p_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_patient.TabIndex = 290
        Me.p_patient.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.IQTClinicSystem.My.Resources.Resources.folder_icon
        Me.PictureBox6.Location = New System.Drawing.Point(112, 515)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(62, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 289
        Me.PictureBox6.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(164, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl1.TabIndex = 270
        Me.LabelControl1.Text = "الحد الاعلى لنتائج البحث"
        '
        'num_limit
        '
        Me.num_limit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_limit.Location = New System.Drawing.Point(100, 21)
        Me.num_limit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_limit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_limit.Name = "num_limit"
        Me.num_limit.Size = New System.Drawing.Size(58, 21)
        Me.num_limit.TabIndex = 269
        Me.num_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_limit.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'tb_f1
        '
        Me.tb_f1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_f1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f1.FormattingEnabled = True
        Me.tb_f1.Items.AddRange(New Object() {"A", "B", "C", "A+", "B+", "C+", "A VIP", "B VIP", "C VIP"})
        Me.tb_f1.Location = New System.Drawing.Point(130, 87)
        Me.tb_f1.Name = "tb_f1"
        Me.tb_f1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_f1.Size = New System.Drawing.Size(90, 27)
        Me.tb_f1.TabIndex = 268
        '
        'tb_f2
        '
        Me.tb_f2.EnterMoveNextControl = True
        Me.tb_f2.Location = New System.Drawing.Point(57, 87)
        Me.tb_f2.Name = "tb_f2"
        Me.tb_f2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_f2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f2.Properties.Appearance.Options.UseFont = True
        Me.tb_f2.Properties.Mask.EditMask = "n0"
        Me.tb_f2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_f2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_f2.Size = New System.Drawing.Size(73, 28)
        Me.tb_f2.TabIndex = 267
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.IQTClinicSystem.My.Resources.Resources.addition_icon
        Me.PictureBox3.Location = New System.Drawing.Point(4, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 263
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IQTClinicSystem.My.Resources.Resources.search_disease_icon
        Me.PictureBox2.Location = New System.Drawing.Point(226, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "بواسطة الاسم"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.tb_user, Me.BarButtonItem1, Me.BarHeaderItem1, Me.BarHeaderItem2, Me.BarButtonItem2, Me.SkinRibbonGalleryBarItem2, Me.btn_main, Me.BarHeaderItem3, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.tb_count, Me.BarCheckItem1, Me.BarHeaderItem4})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 21
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.PageHeaderItemLinks.Add(Me.tb_count)
        Me.RibbonControl2.PageHeaderItemLinks.Add(Me.BarHeaderItem4)
        Me.RibbonControl2.QuickToolbarItemLinks.Add(Me.tb_user)
        Me.RibbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1370, 49)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        '
        'tb_user
        '
        Me.tb_user.Id = 1
        Me.tb_user.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.person_icon
        Me.tb_user.Name = "tb_user"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "تحديث"
        Me.BarHeaderItem1.Id = 3
        Me.BarHeaderItem1.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.sharp_public_white_48dp
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Id = 4
        Me.BarHeaderItem2.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.sharp_home_white_48dp
        Me.BarHeaderItem2.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_home_white_48dp
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "الرئيسية"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_home_white_48dp
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SkinRibbonGalleryBarItem2
        '
        Me.SkinRibbonGalleryBarItem2.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem2.Id = 6
        Me.SkinRibbonGalleryBarItem2.Name = "SkinRibbonGalleryBarItem2"
        '
        'btn_main
        '
        Me.btn_main.Caption = "الرئيسية"
        Me.btn_main.Id = 8
        Me.btn_main.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_home_white_48dp
        Me.btn_main.Name = "btn_main"
        '
        'BarHeaderItem3
        '
        Me.BarHeaderItem3.Caption = "BarHeaderItem3"
        Me.BarHeaderItem3.Id = 9
        Me.BarHeaderItem3.Name = "BarHeaderItem3"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "المراجعين"
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_wc_white_48dp
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "الحجوزات"
        Me.BarButtonItem4.Id = 11
        Me.BarButtonItem4.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_chrome_reader_mode_white_48dp
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "اضافة"
        Me.BarButtonItem5.Id = 12
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_person_add_white_48dp
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "الزيارات"
        Me.BarButtonItem6.Id = 13
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_event_note_white_48dp
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "الوصفات"
        Me.BarButtonItem7.Id = 14
        Me.BarButtonItem7.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_description_white_48dp
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "دخول مشفى"
        Me.BarButtonItem8.Id = 15
        Me.BarButtonItem8.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_airline_seat_flat_white_48dp
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "تقرير طبي"
        Me.BarButtonItem9.Id = 16
        Me.BarButtonItem9.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_rate_review_white_48dp
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "عمليات"
        Me.BarButtonItem10.Id = 17
        Me.BarButtonItem10.ImageOptions.LargeImage = Global.IQTClinicSystem.My.Resources.Resources.sharp_airline_seat_individual_suite_white_48dp
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'tb_count
        '
        Me.tb_count.Caption = "tb_count"
        Me.tb_count.Id = 18
        Me.tb_count.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.contact_icon
        Me.tb_count.Name = "tb_count"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "BarCheckItem1"
        Me.BarCheckItem1.Id = 19
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarHeaderItem4
        '
        Me.BarHeaderItem4.Caption = "عدد الزبائن في نتائج البحث"
        Me.BarHeaderItem4.Id = 20
        Me.BarHeaderItem4.Name = "BarHeaderItem4"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lv_queue)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 49)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(1022, 700)
        Me.GroupControl2.TabIndex = 263
        Me.GroupControl2.Text = "نتائج البحث"
        '
        'fm_show_patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.RibbonControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_show_patients"
        Me.Ribbon = Me.RibbonControl2
        Me.ShowIcon = False
        Me.Text = "معلومات الزبائن"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_patient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_f2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents tb_user As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem2 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btn_main As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem3 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents عرضاوتعديلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ارشفةبياناتالمراجعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_count As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents اضافةحجزعمليةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_f1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_f2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents num_limit As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarHeaderItem4 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents p_patient As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents تفعيلالحسابToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents اضافةملفاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cb_plan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
