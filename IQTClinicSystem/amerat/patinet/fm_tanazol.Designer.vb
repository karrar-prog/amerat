<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_tanazol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_tanazol))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.p_patient = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.tb_f7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_gender = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_patient_id = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.طباعةالتنازلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةصورةالتنازلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.p_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_gender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_patient_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.p_patient)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.tb_f7)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.tb_gender)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.tb_patient_id)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(679, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(514, 702)
        Me.GroupControl1.TabIndex = 0
        '
        'p_patient
        '
        Me.p_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_patient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p_patient.Location = New System.Drawing.Point(8, 26)
        Me.p_patient.Name = "p_patient"
        Me.p_patient.Size = New System.Drawing.Size(267, 236)
        Me.p_patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_patient.TabIndex = 291
        Me.p_patient.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "اسم الزبون المتنازل"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(281, 208)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit2.Size = New System.Drawing.Size(221, 26)
        Me.TextEdit2.TabIndex = 281
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 268)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 38)
        Me.SimpleButton1.TabIndex = 280
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "ألدار"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(281, 159)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Mask.EditMask = "d"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.NullValuePrompt = "رقم العقد"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(221, 26)
        Me.TextEdit1.TabIndex = 278
        '
        'tb_f7
        '
        Me.tb_f7.AcceptsReturn = True
        Me.tb_f7.AcceptsTab = True
        Me.tb_f7.AllowDrop = True
        Me.tb_f7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f7.Location = New System.Drawing.Point(6, 310)
        Me.tb_f7.Multiline = True
        Me.tb_f7.Name = "tb_f7"
        Me.tb_f7.Size = New System.Drawing.Size(496, 332)
        Me.tb_f7.TabIndex = 277
        Me.tb_f7.TabStop = False
        Me.tb_f7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tb_f7.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 26)
        Me.Label2.TabIndex = 276
        Me.Label2.Text = "التنازل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "اسم الزبون الجديد"
        '
        'tb_gender
        '
        Me.tb_gender.Location = New System.Drawing.Point(121, 272)
        Me.tb_gender.Name = "tb_gender"
        Me.tb_gender.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_gender.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_gender.Properties.Appearance.Options.UseFont = True
        Me.tb_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_gender.Size = New System.Drawing.Size(256, 30)
        Me.tb_gender.TabIndex = 273
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(152, 652)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(190, 38)
        Me.SimpleButton4.TabIndex = 272
        Me.SimpleButton4.Text = "تنازل الان"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 259
        Me.Label5.Text = "رقم العقد"
        '
        'tb_patient_id
        '
        Me.tb_patient_id.Location = New System.Drawing.Point(281, 110)
        Me.tb_patient_id.Name = "tb_patient_id"
        Me.tb_patient_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_patient_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_id.Properties.Appearance.Options.UseFont = True
        Me.tb_patient_id.Properties.Mask.EditMask = "d"
        Me.tb_patient_id.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_patient_id.Properties.NullValuePrompt = "رقم العقد"
        Me.tb_patient_id.Properties.ReadOnly = True
        Me.tb_patient_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_patient_id.Size = New System.Drawing.Size(221, 26)
        Me.tb_patient_id.TabIndex = 258
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lv_queue)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(679, 702)
        Me.GroupControl2.TabIndex = 1
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(2, 20)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(675, 680)
        Me.lv_queue.TabIndex = 2
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.طباعةالتنازلToolStripMenuItem, Me.اضافةصورةالتنازلToolStripMenuItem, Me.عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 70)
        '
        'طباعةالتنازلToolStripMenuItem
        '
        Me.طباعةالتنازلToolStripMenuItem.Name = "طباعةالتنازلToolStripMenuItem"
        Me.طباعةالتنازلToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.طباعةالتنازلToolStripMenuItem.Text = "طباعة التنازل"
        '
        'عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem
        '
        Me.عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem.Name = "عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem"
        Me.عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem.Text = "حذف"
        '
        'اضافةصورةالتنازلToolStripMenuItem
        '
        Me.اضافةصورةالتنازلToolStripMenuItem.Name = "اضافةصورةالتنازلToolStripMenuItem"
        Me.اضافةصورةالتنازلToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.اضافةصورةالتنازلToolStripMenuItem.Text = "صورة ارشيف التنازل"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(296, 26)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(190, 38)
        Me.SimpleButton2.TabIndex = 292
        Me.SimpleButton2.Text = "ارشيف الصور"
        '
        'fm_tanazol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 702)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_tanazol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تنازلات"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.p_patient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_gender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_patient_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_patient_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents طباعةالتنازلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents عرضتفاصيلالاقساطعندالتنازلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_gender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_f7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents p_patient As System.Windows.Forms.PictureBox
    Friend WithEvents اضافةصورةالتنازلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
