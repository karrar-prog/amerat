<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_collection_fesha
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_amount_text = New DevExpress.XtraEditors.TextEdit()
        Me.tb_dept_title = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_fesha_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_number = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_note = New System.Windows.Forms.TextBox()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.dt_queue = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_patient_name = New System.Windows.Forms.TextBox()
        Me.tb_patient_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_munite = New System.Windows.Forms.TextBox()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.tb_amount = New System.Windows.Forms.TextBox()
        Me.cb_plan = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.حفظوطباعةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_dept_title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(755, 415)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 21)
        Me.Label12.TabIndex = 452
        '
        'tb_amount_text
        '
        Me.tb_amount_text.EnterMoveNextControl = True
        Me.tb_amount_text.Location = New System.Drawing.Point(12, 592)
        Me.tb_amount_text.Name = "tb_amount_text"
        Me.tb_amount_text.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_amount_text.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount_text.Properties.Appearance.Options.UseFont = True
        Me.tb_amount_text.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount_text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount_text.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_amount_text.Properties.Mask.BeepOnError = True
        Me.tb_amount_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_amount_text.Size = New System.Drawing.Size(1014, 28)
        Me.tb_amount_text.TabIndex = 451
        '
        'tb_dept_title
        '
        Me.tb_dept_title.EditValue = "متعددة"
        Me.tb_dept_title.EnterMoveNextControl = True
        Me.tb_dept_title.Location = New System.Drawing.Point(578, 190)
        Me.tb_dept_title.Name = "tb_dept_title"
        Me.tb_dept_title.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_dept_title.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dept_title.Properties.Appearance.Options.UseFont = True
        Me.tb_dept_title.Properties.Mask.BeepOnError = True
        Me.tb_dept_title.Properties.Mask.EditMask = "n0"
        Me.tb_dept_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_dept_title.Size = New System.Drawing.Size(299, 30)
        Me.tb_dept_title.TabIndex = 448
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 31)
        Me.Label3.TabIndex = 447
        Me.Label3.Text = "مبلغ مجموع الفيشات"
        '
        'tb_fesha_amount
        '
        Me.tb_fesha_amount.EnterMoveNextControl = True
        Me.tb_fesha_amount.Location = New System.Drawing.Point(117, 550)
        Me.tb_fesha_amount.Name = "tb_fesha_amount"
        Me.tb_fesha_amount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_fesha_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fesha_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_fesha_amount.Properties.Mask.BeepOnError = True
        Me.tb_fesha_amount.Properties.Mask.EditMask = "n0"
        Me.tb_fesha_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_fesha_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_fesha_amount.Size = New System.Drawing.Size(273, 36)
        Me.tb_fesha_amount.TabIndex = 446
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(959, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 22)
        Me.Label9.TabIndex = 443
        Me.Label9.Text = "الدفعة"
        '
        'tb_number
        '
        Me.tb_number.BackColor = System.Drawing.Color.White
        Me.tb_number.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_number.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_number.Location = New System.Drawing.Point(879, 192)
        Me.tb_number.Name = "tb_number"
        Me.tb_number.Size = New System.Drawing.Size(77, 25)
        Me.tb_number.TabIndex = 442
        Me.tb_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(959, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 441
        Me.Label8.Text = "ملاحظة"
        '
        'tb_note
        '
        Me.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_note.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Location = New System.Drawing.Point(580, 350)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.Size = New System.Drawing.Size(377, 25)
        Me.tb_note.TabIndex = 440
        Me.tb_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_id
        '
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(954, 99)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.ReadOnly = True
        Me.tb_id.Size = New System.Drawing.Size(72, 25)
        Me.tb_id.TabIndex = 438
        Me.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_queue
        '
        Me.dt_queue.Enabled = False
        Me.dt_queue.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_queue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_queue.Location = New System.Drawing.Point(723, 397)
        Me.dt_queue.Name = "dt_queue"
        Me.dt_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dt_queue.RightToLeftLayout = True
        Me.dt_queue.Size = New System.Drawing.Size(180, 39)
        Me.dt_queue.TabIndex = 436
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(959, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 434
        Me.Label5.Text = "رقم الحساب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(959, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 433
        Me.Label4.Text = "اسم الحساب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(959, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 432
        Me.Label2.Text = "المصرف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(784, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 431
        Me.Label1.Text = "اسم الزبون"
        '
        'tb_patient_name
        '
        Me.tb_patient_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_name.Location = New System.Drawing.Point(654, 36)
        Me.tb_patient_name.Name = "tb_patient_name"
        Me.tb_patient_name.ReadOnly = True
        Me.tb_patient_name.Size = New System.Drawing.Size(310, 25)
        Me.tb_patient_name.TabIndex = 430
        Me.tb_patient_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_patient_id
        '
        Me.tb_patient_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_id.Location = New System.Drawing.Point(970, 36)
        Me.tb_patient_id.Name = "tb_patient_id"
        Me.tb_patient_id.ReadOnly = True
        Me.tb_patient_id.Size = New System.Drawing.Size(57, 25)
        Me.tb_patient_id.TabIndex = 429
        Me.tb_patient_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(960, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 439
        Me.Label7.Text = "رقم العقد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(909, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 31)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "تأريخ الطباعة"
        '
        'tb_munite
        '
        Me.tb_munite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_munite.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_munite.Location = New System.Drawing.Point(580, 313)
        Me.tb_munite.Name = "tb_munite"
        Me.tb_munite.ReadOnly = True
        Me.tb_munite.Size = New System.Drawing.Size(377, 25)
        Me.tb_munite.TabIndex = 428
        Me.tb_munite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'tb_amount
        '
        Me.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_amount.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Location = New System.Drawing.Point(580, 276)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.ReadOnly = True
        Me.tb_amount.Size = New System.Drawing.Size(377, 25)
        Me.tb_amount.TabIndex = 427
        Me.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_plan
        '
        Me.cb_plan.BackColor = System.Drawing.Color.White
        Me.cb_plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_plan.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cb_plan.FormattingEnabled = True
        Me.cb_plan.Location = New System.Drawing.Point(580, 232)
        Me.cb_plan.Name = "cb_plan"
        Me.cb_plan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_plan.Size = New System.Drawing.Size(377, 32)
        Me.cb_plan.TabIndex = 426
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(462, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 36)
        Me.Label13.TabIndex = 454
        Me.Label13.Text = "فيشة متعددة"
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(12, 48)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(562, 465)
        Me.lv_queue.TabIndex = 455
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حفظوطباعةToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'حفظوطباعةToolStripMenuItem
        '
        Me.حفظوطباعةToolStripMenuItem.Name = "حفظوطباعةToolStripMenuItem"
        Me.حفظوطباعةToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.حفظوطباعةToolStripMenuItem.Text = "حفظ و طباعة"
        '
        'fm_add_collection_fesha
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 632)
        Me.Controls.Add(Me.lv_queue)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_amount_text)
        Me.Controls.Add(Me.tb_dept_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_fesha_amount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_number)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_note)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.dt_queue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_patient_name)
        Me.Controls.Add(Me.tb_patient_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_munite)
        Me.Controls.Add(Me.tb_amount)
        Me.Controls.Add(Me.cb_plan)
        Me.Name = "fm_add_collection_fesha"
        Me.Text = "فيشة متعددة"
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_dept_title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_amount_text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_dept_title As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_fesha_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_number As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_note As System.Windows.Forms.TextBox
    Friend WithEvents tb_id As System.Windows.Forms.TextBox
    Friend WithEvents dt_queue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_patient_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_patient_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_munite As System.Windows.Forms.TextBox
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tb_amount As System.Windows.Forms.TextBox
    Friend WithEvents cb_plan As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents حفظوطباعةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
