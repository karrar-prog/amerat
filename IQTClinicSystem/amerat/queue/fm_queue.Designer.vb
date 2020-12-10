Partial Public Class fm_queue
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.ApplicationMenu2 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.ApplicationMenu3 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.طباعةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلالاسمToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الغاءحجزهذاالزبونToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حذفهذهالفيشةفقطToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_queue = New System.Windows.Forms.DateTimePicker()
        Me.DefaultLookAndFeel2 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.br_count1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.tb_p_id = New System.Windows.Forms.TextBox()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.tb_fesha_id = New System.Windows.Forms.TextBox()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbooking_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpatient_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gridrecived_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Griddept_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gridnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Gridf1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.f3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lv_queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(0, 0)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(1248, 699)
        Me.lv_queue.TabIndex = 263
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.طباعةToolStripMenuItem, Me.تعديلالاسمToolStripMenuItem, Me.الغاءحجزهذاالزبونToolStripMenuItem, Me.حذفهذهالفيشةفقطToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(199, 92)
        '
        'طباعةToolStripMenuItem
        '
        Me.طباعةToolStripMenuItem.Name = "طباعةToolStripMenuItem"
        Me.طباعةToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.طباعةToolStripMenuItem.Text = "طباعة"
        '
        'تعديلالاسمToolStripMenuItem
        '
        Me.تعديلالاسمToolStripMenuItem.Name = "تعديلالاسمToolStripMenuItem"
        Me.تعديلالاسمToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.تعديلالاسمToolStripMenuItem.Text = "تعديل معلومات الزبون"
        '
        'الغاءحجزهذاالزبونToolStripMenuItem
        '
        Me.الغاءحجزهذاالزبونToolStripMenuItem.Name = "الغاءحجزهذاالزبونToolStripMenuItem"
        Me.الغاءحجزهذاالزبونToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.الغاءحجزهذاالزبونToolStripMenuItem.Text = "الغاء حجز هذا الزبون تماما"
        '
        'حذفهذهالفيشةفقطToolStripMenuItem
        '
        Me.حذفهذهالفيشةفقطToolStripMenuItem.Name = "حذفهذهالفيشةفقطToolStripMenuItem"
        Me.حذفهذهالفيشةفقطToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.حذفهذهالفيشةفقطToolStripMenuItem.Text = "حذف هذه الفيشة فقط"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(126, 50)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 29)
        Me.SimpleButton1.TabIndex = 270
        Me.SimpleButton1.Text = "اليوم"
        '
        'dt_queue
        '
        Me.dt_queue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_queue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_queue.Location = New System.Drawing.Point(760, 22)
        Me.dt_queue.Name = "dt_queue"
        Me.dt_queue.RightToLeftLayout = True
        Me.dt_queue.Size = New System.Drawing.Size(127, 29)
        Me.dt_queue.TabIndex = 269
        '
        'br_count1
        '
        Me.br_count1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.br_count1.Appearance.Options.UseFont = True
        Me.br_count1.Location = New System.Drawing.Point(308, 52)
        Me.br_count1.Name = "br_count1"
        Me.br_count1.Size = New System.Drawing.Size(6, 22)
        Me.br_count1.TabIndex = 274
        Me.br_count1.Text = "-"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(9, 50)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(93, 29)
        Me.SimpleButton3.TabIndex = 277
        Me.SimpleButton3.Text = "جميع الاوقات"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(602, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 29)
        Me.DateTimePicker1.TabIndex = 269
        '
        'GroupControl8
        '
        Me.GroupControl8.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl8.Appearance.Options.UseBackColor = True
        Me.GroupControl8.Location = New System.Drawing.Point(998, 3)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl8.Size = New System.Drawing.Size(69, 22)
        Me.GroupControl8.TabIndex = 276
        Me.GroupControl8.Text = "باركود عقد"
        '
        'tb_p_id
        '
        Me.tb_p_id.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_p_id.Location = New System.Drawing.Point(929, 22)
        Me.tb_p_id.Name = "tb_p_id"
        Me.tb_p_id.Size = New System.Drawing.Size(100, 29)
        Me.tb_p_id.TabIndex = 224
        '
        'GroupControl7
        '
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Location = New System.Drawing.Point(1118, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl7.Size = New System.Drawing.Size(78, 19)
        Me.GroupControl7.TabIndex = 275
        Me.GroupControl7.Text = "باركود فيشة"
        '
        'tb_fesha_id
        '
        Me.tb_fesha_id.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fesha_id.Location = New System.Drawing.Point(1082, 22)
        Me.tb_fesha_id.Name = "tb_fesha_id"
        Me.tb_fesha_id.Size = New System.Drawing.Size(100, 29)
        Me.tb_fesha_id.TabIndex = 224
        '
        'GroupControl6
        '
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl6.Size = New System.Drawing.Size(1258, 749)
        Me.GroupControl6.TabIndex = 279
        Me.GroupControl6.Text = "نتئج البحث"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 20)
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1254, 727)
        Me.XtraTabControl1.TabIndex = 122
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lv_queue)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.PageVisible = False
        Me.XtraTabPage1.Size = New System.Drawing.Size(1248, 699)
        Me.XtraTabPage1.Text = "عرض"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Label4)
        Me.XtraTabPage2.Controls.Add(Me.Label3)
        Me.XtraTabPage2.Controls.Add(Me.Label2)
        Me.XtraTabPage2.Controls.Add(Me.Label1)
        Me.XtraTabPage2.Controls.Add(Me.DateTimePicker1)
        Me.XtraTabPage2.Controls.Add(Me.dt_queue)
        Me.XtraTabPage2.Controls.Add(Me.br_count1)
        Me.XtraTabPage2.Controls.Add(Me.tb_p_id)
        Me.XtraTabPage2.Controls.Add(Me.tb_fesha_id)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton3)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton2)
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl8)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1248, 699)
        Me.XtraTabPage2.Text = "بحث"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1030, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 22)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "عقد"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1184, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 22)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "فيشة"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(494, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(72, 45)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "تصدير"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1248, 699)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(199, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItem1.Text = "طباعة"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItem2.Text = "تعديل معلومات الزبون"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItem3.Text = "الغاء حجز هذا الزبون تماما"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripMenuItem4.Text = "حذف هذه الفيشة فقط"
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbooking_number, Me.colpatient_id, Me.colname, Me.colamount, Me.coldate, Me.colstate, Me.colid, Me.Gridrecived_date, Me.Griddept_id, Me.Gridnote, Me.Gridf1, Me.time, Me.f3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colbooking_number
        '
        Me.colbooking_number.Caption = "رقم الفيشة"
        Me.colbooking_number.FieldName = "id"
        Me.colbooking_number.Name = "colbooking_number"
        Me.colbooking_number.Visible = True
        Me.colbooking_number.VisibleIndex = 0
        Me.colbooking_number.Width = 84
        '
        'colpatient_id
        '
        Me.colpatient_id.Caption = "رقم الحجز او العقد"
        Me.colpatient_id.FieldName = "patient_id"
        Me.colpatient_id.Name = "colpatient_id"
        Me.colpatient_id.Visible = True
        Me.colpatient_id.VisibleIndex = 1
        Me.colpatient_id.Width = 163
        '
        'colname
        '
        Me.colname.Caption = "اسم الزبون"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 2
        Me.colname.Width = 302
        '
        'colamount
        '
        Me.colamount.Caption = "المبلغ"
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 3
        Me.colamount.Width = 115
        '
        'coldate
        '
        Me.coldate.Caption = "التأريخ"
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 4
        Me.coldate.Width = 115
        '
        'colstate
        '
        Me.colstate.Caption = "الحالة"
        Me.colstate.FieldName = "state"
        Me.colstate.Name = "colstate"
        Me.colstate.Visible = True
        Me.colstate.VisibleIndex = 5
        Me.colstate.Width = 121
        '
        'colid
        '
        Me.colid.Caption = "رقم الفيشة"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 6
        Me.colid.Width = 64
        '
        'Gridrecived_date
        '
        Me.Gridrecived_date.Caption = "تأريخ الاستلام"
        Me.Gridrecived_date.FieldName = "recived_date"
        Me.Gridrecived_date.Name = "Gridrecived_date"
        Me.Gridrecived_date.Visible = True
        Me.Gridrecived_date.VisibleIndex = 7
        Me.Gridrecived_date.Width = 64
        '
        'Griddept_id
        '
        Me.Griddept_id.Caption = "رقم الدفعة"
        Me.Griddept_id.FieldName = "dept_id"
        Me.Griddept_id.Name = "Griddept_id"
        Me.Griddept_id.Visible = True
        Me.Griddept_id.VisibleIndex = 8
        Me.Griddept_id.Width = 64
        '
        'Gridnote
        '
        Me.Gridnote.Caption = "ملاحظة"
        Me.Gridnote.FieldName = "note"
        Me.Gridnote.Name = "Gridnote"
        Me.Gridnote.Visible = True
        Me.Gridnote.VisibleIndex = 9
        Me.Gridnote.Width = 64
        '
        'Gridf1
        '
        Me.Gridf1.Caption = "-"
        Me.Gridf1.FieldName = "f1"
        Me.Gridf1.Name = "Gridf1"
        Me.Gridf1.Visible = True
        Me.Gridf1.VisibleIndex = 10
        Me.Gridf1.Width = 74
        '
        'time
        '
        Me.time.Caption = "الوقت"
        Me.time.FieldName = "time"
        Me.time.Name = "time"
        Me.time.Visible = True
        Me.time.VisibleIndex = 11
        '
        'f3
        '
        Me.f3.Caption = "نوع الفيشة"
        Me.f3.FieldName = "f3"
        Me.f3.Name = "f3"
        Me.f3.Visible = True
        Me.f3.VisibleIndex = 12
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Location = New System.Drawing.Point(620, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(93, 22)
        Me.GroupControl2.TabIndex = 278
        Me.GroupControl2.Text = "قبل هذا التأريخ"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Location = New System.Drawing.Point(794, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(93, 22)
        Me.GroupControl1.TabIndex = 277
        Me.GroupControl1.Text = "في هذا التأريخ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "فييش هذا التأريخ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(624, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "فييش قبل هذا التأريخ"
        '
        'fm_queue
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Appearance.Options.UseBackColor = True
        Me.ClientSize = New System.Drawing.Size(1258, 749)
        Me.Controls.Add(Me.GroupControl6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_queue"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents ApplicationMenu2 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents ApplicationMenu3 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_queue As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DefaultLookAndFeel2 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents br_count1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents تعديلالاسمToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents طباعةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents الغاءحجزهذاالزبونToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حذفهذهالفيشةفقطToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_fesha_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_p_id As System.Windows.Forms.TextBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbooking_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpatient_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gridrecived_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Griddept_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gridnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gridf1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents f3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

#End Region

End Class
