<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_show_details
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
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_patient_id = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.طباعةفيشةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.num_limit = New System.Windows.Forms.NumericUpDown()
        Me.cb_plan = New System.Windows.Forms.ComboBox()
        Me.tb_f1 = New System.Windows.Forms.ComboBox()
        Me.tb_f2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lv = New System.Windows.Forms.ListView()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_f2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 756)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1204, 31)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1204, 49)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(212, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 23)
        Me.Label7.TabIndex = 275
        Me.Label7.Text = "باركود عقد"
        '
        'tb_patient_id
        '
        Me.tb_patient_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_id.Location = New System.Drawing.Point(6, 41)
        Me.tb_patient_id.Name = "tb_patient_id"
        Me.tb_patient_id.Size = New System.Drawing.Size(205, 25)
        Me.tb_patient_id.TabIndex = 274
        Me.tb_patient_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.lv_queue)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.num_limit)
        Me.GroupControl1.Controls.Add(Me.cb_plan)
        Me.GroupControl1.Controls.Add(Me.tb_f1)
        Me.GroupControl1.Controls.Add(Me.tb_f2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.tb_name)
        Me.GroupControl1.Controls.Add(Me.tb_patient_id)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(899, 49)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(305, 707)
        Me.GroupControl1.TabIndex = 276
        Me.GroupControl1.Text = "معلومات العقد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 23)
        Me.Label3.TabIndex = 300
        Me.Label3.Text = "الحالة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "رقم الدار"
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.BackColor = System.Drawing.Color.White
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(0, 200)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(305, 505)
        Me.lv_queue.TabIndex = 278
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.طباعةفيشةToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'طباعةفيشةToolStripMenuItem
        '
        Me.طباعةفيشةToolStripMenuItem.Name = "طباعةفيشةToolStripMenuItem"
        Me.طباعةفيشةToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.طباعةفيشةToolStripMenuItem.Text = "طباعة فيشة"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(176, 218)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl1.TabIndex = 298
        Me.LabelControl1.Text = "الحد الاعلى لنتائج البحث"
        '
        'num_limit
        '
        Me.num_limit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_limit.Location = New System.Drawing.Point(112, 211)
        Me.num_limit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_limit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_limit.Name = "num_limit"
        Me.num_limit.Size = New System.Drawing.Size(58, 21)
        Me.num_limit.TabIndex = 297
        Me.num_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_limit.Value = New Decimal(New Integer() {50, 0, 0, 0})
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
        Me.cb_plan.Location = New System.Drawing.Point(6, 165)
        Me.cb_plan.Name = "cb_plan"
        Me.cb_plan.Size = New System.Drawing.Size(205, 29)
        Me.cb_plan.TabIndex = 296
        '
        'tb_f1
        '
        Me.tb_f1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tb_f1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f1.FormattingEnabled = True
        Me.tb_f1.Items.AddRange(New Object() {"A", "B", "C", "A VIP", "A VVIP"})
        Me.tb_f1.Location = New System.Drawing.Point(6, 133)
        Me.tb_f1.Name = "tb_f1"
        Me.tb_f1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_f1.Size = New System.Drawing.Size(121, 27)
        Me.tb_f1.TabIndex = 295
        '
        'tb_f2
        '
        Me.tb_f2.EnterMoveNextControl = True
        Me.tb_f2.Location = New System.Drawing.Point(127, 133)
        Me.tb_f2.Name = "tb_f2"
        Me.tb_f2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_f2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f2.Properties.Appearance.Options.UseFont = True
        Me.tb_f2.Properties.Mask.EditMask = "n0"
        Me.tb_f2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_f2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_f2.Size = New System.Drawing.Size(84, 28)
        Me.tb_f2.TabIndex = 294
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "اسم الزبون"
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(6, 102)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.NullValuePrompt = "الاسم"
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_name.Size = New System.Drawing.Size(205, 26)
        Me.tb_name.TabIndex = 276
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lv)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 49)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(899, 707)
        Me.GroupControl2.TabIndex = 277
        Me.GroupControl2.Text = "التفاصيل"
        '
        'lv
        '
        Me.lv.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(2, 20)
        Me.lv.Name = "lv"
        Me.lv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv.RightToLeftLayout = True
        Me.lv.Size = New System.Drawing.Size(895, 685)
        Me.lv.TabIndex = 2
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'fm_show_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 787)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_show_details"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "عرض التقاصيل"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.num_limit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_f2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_patient_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents طباعةفيشةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents cb_plan As System.Windows.Forms.ComboBox
    Friend WithEvents tb_f1 As System.Windows.Forms.ComboBox
    Friend WithEvents tb_f2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents num_limit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
