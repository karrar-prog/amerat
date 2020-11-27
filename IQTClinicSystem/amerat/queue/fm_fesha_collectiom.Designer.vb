<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_fesha_collectiom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_fesha_collectiom))
        Me.tb_bank_name = New System.Windows.Forms.TextBox()
        Me.tb_acount_name = New System.Windows.Forms.TextBox()
        Me.tb_acount_number = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tb_patient_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_note = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_fesha_amount = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_amount_text = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_queue = New System.Windows.Forms.DateTimePicker()
        Me.tb_fesha_id = New System.Windows.Forms.TextBox()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_bank_name
        '
        Me.tb_bank_name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_bank_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_bank_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bank_name.Location = New System.Drawing.Point(17, 142)
        Me.tb_bank_name.Name = "tb_bank_name"
        Me.tb_bank_name.ReadOnly = True
        Me.tb_bank_name.Size = New System.Drawing.Size(330, 25)
        Me.tb_bank_name.TabIndex = 317
        Me.tb_bank_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_acount_name
        '
        Me.tb_acount_name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_acount_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_acount_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_acount_name.Location = New System.Drawing.Point(17, 204)
        Me.tb_acount_name.Name = "tb_acount_name"
        Me.tb_acount_name.ReadOnly = True
        Me.tb_acount_name.Size = New System.Drawing.Size(330, 25)
        Me.tb_acount_name.TabIndex = 291
        Me.tb_acount_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_acount_number
        '
        Me.tb_acount_number.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_acount_number.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_acount_number.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_acount_number.Location = New System.Drawing.Point(17, 266)
        Me.tb_acount_number.Name = "tb_acount_number"
        Me.tb_acount_number.ReadOnly = True
        Me.tb_acount_number.Size = New System.Drawing.Size(330, 25)
        Me.tb_acount_number.TabIndex = 292
        Me.tb_acount_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 295
        Me.Label1.Text = "اسم الزبون"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.tb_bank_name)
        Me.GroupControl1.Controls.Add(Me.tb_acount_name)
        Me.GroupControl1.Controls.Add(Me.tb_acount_number)
        Me.GroupControl1.Controls.Add(Me.tb_patient_name)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.tb_note)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Location = New System.Drawing.Point(683, 56)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(457, 441)
        Me.GroupControl1.TabIndex = 334
        Me.GroupControl1.Text = "معلومات الفيشة"
        '
        'tb_patient_name
        '
        Me.tb_patient_name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_patient_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_name.Location = New System.Drawing.Point(17, 80)
        Me.tb_patient_name.Name = "tb_patient_name"
        Me.tb_patient_name.ReadOnly = True
        Me.tb_patient_name.Size = New System.Drawing.Size(330, 25)
        Me.tb_patient_name.TabIndex = 294
        Me.tb_patient_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(358, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 296
        Me.Label2.Text = "المصرف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 297
        Me.Label4.Text = "اسم الحساب"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 298
        Me.Label5.Text = "رقم الحساب"
        '
        'tb_note
        '
        Me.tb_note.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_note.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Location = New System.Drawing.Point(17, 328)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.ReadOnly = True
        Me.tb_note.Size = New System.Drawing.Size(330, 25)
        Me.tb_note.TabIndex = 303
        Me.tb_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(358, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 304
        Me.Label8.Text = "ملاحظة"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(316, 659)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(520, 44)
        Me.SimpleButton1.TabIndex = 336
        Me.SimpleButton1.Text = "استلام مبلغ الفيشة المتعددة"
        '
        'tb_fesha_amount
        '
        Me.tb_fesha_amount.EnterMoveNextControl = True
        Me.tb_fesha_amount.Location = New System.Drawing.Point(374, 514)
        Me.tb_fesha_amount.Name = "tb_fesha_amount"
        Me.tb_fesha_amount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_fesha_amount.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_fesha_amount.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fesha_amount.Properties.Appearance.Options.UseBackColor = True
        Me.tb_fesha_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_fesha_amount.Properties.Mask.BeepOnError = True
        Me.tb_fesha_amount.Properties.Mask.EditMask = "n0"
        Me.tb_fesha_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_fesha_amount.Properties.ReadOnly = True
        Me.tb_fesha_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_fesha_amount.Size = New System.Drawing.Size(340, 28)
        Me.tb_fesha_amount.TabIndex = 327
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(934, 549)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 22)
        Me.Label12.TabIndex = 333
        Me.Label12.Text = "المبلغ كتابة"
        '
        'tb_amount_text
        '
        Me.tb_amount_text.EnterMoveNextControl = True
        Me.tb_amount_text.Location = New System.Drawing.Point(169, 546)
        Me.tb_amount_text.Name = "tb_amount_text"
        Me.tb_amount_text.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_amount_text.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_amount_text.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount_text.Properties.Appearance.Options.UseBackColor = True
        Me.tb_amount_text.Properties.Appearance.Options.UseFont = True
        Me.tb_amount_text.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount_text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount_text.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_amount_text.Properties.Mask.BeepOnError = True
        Me.tb_amount_text.Properties.ReadOnly = True
        Me.tb_amount_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_amount_text.Size = New System.Drawing.Size(759, 28)
        Me.tb_amount_text.TabIndex = 332
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(711, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 328
        Me.Label3.Text = "ألمبلغ الكلي للفيش"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(545, 577)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 22)
        Me.Label6.TabIndex = 324
        Me.Label6.Text = "تأريخ الاستلام"
        '
        'dt_queue
        '
        Me.dt_queue.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_queue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_queue.Location = New System.Drawing.Point(502, 603)
        Me.dt_queue.Name = "dt_queue"
        Me.dt_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dt_queue.RightToLeftLayout = True
        Me.dt_queue.Size = New System.Drawing.Size(180, 39)
        Me.dt_queue.TabIndex = 323
        '
        'tb_fesha_id
        '
        Me.tb_fesha_id.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fesha_id.Location = New System.Drawing.Point(932, 423)
        Me.tb_fesha_id.Name = "tb_fesha_id"
        Me.tb_fesha_id.ReadOnly = True
        Me.tb_fesha_id.Size = New System.Drawing.Size(100, 29)
        Me.tb_fesha_id.TabIndex = 322
        Me.tb_fesha_id.Visible = False
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1152, 0)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.RibbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lv_queue)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 56)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(665, 443)
        Me.GroupControl2.TabIndex = 335
        Me.GroupControl2.Text = "الفيشات"
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(2, 20)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(661, 421)
        Me.lv_queue.TabIndex = 456
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(502, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 26)
        Me.Label7.TabIndex = 457
        Me.Label7.Text = "استلام فيشة متعددة"
        '
        'fm_fesha_collectiom
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 711)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.tb_fesha_amount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_amount_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_queue)
        Me.Controls.Add(Me.tb_fesha_id)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "fm_fesha_collectiom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فيشة متعددة"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_bank_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_acount_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_acount_number As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_patient_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_note As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_fesha_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_amount_text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_queue As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_fesha_id As System.Windows.Forms.TextBox
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
