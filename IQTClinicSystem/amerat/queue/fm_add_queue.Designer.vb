<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_queue
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
        Me.tb_munite = New System.Windows.Forms.TextBox()
        Me.tb_amount = New System.Windows.Forms.TextBox()
        Me.cb_plan = New System.Windows.Forms.ComboBox()
        Me.tb_patient_id = New System.Windows.Forms.TextBox()
        Me.tb_patient_name = New System.Windows.Forms.TextBox()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dt_queue = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_note = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_number = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_fesha_amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_dept_title = New DevExpress.XtraEditors.TextEdit()
        Me.tb_dept_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_amount_text = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.nu_first_money_present = New System.Windows.Forms.NumericUpDown()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_dept_title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_first_money_present, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_munite
        '
        Me.tb_munite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_munite.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_munite.Location = New System.Drawing.Point(228, 252)
        Me.tb_munite.Name = "tb_munite"
        Me.tb_munite.ReadOnly = True
        Me.tb_munite.Size = New System.Drawing.Size(455, 32)
        Me.tb_munite.TabIndex = 255
        Me.tb_munite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_amount
        '
        Me.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_amount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Location = New System.Drawing.Point(228, 215)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.ReadOnly = True
        Me.tb_amount.Size = New System.Drawing.Size(455, 32)
        Me.tb_amount.TabIndex = 254
        Me.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_plan
        '
        Me.cb_plan.BackColor = System.Drawing.Color.White
        Me.cb_plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_plan.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cb_plan.FormattingEnabled = True
        Me.cb_plan.Location = New System.Drawing.Point(228, 171)
        Me.cb_plan.Name = "cb_plan"
        Me.cb_plan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_plan.Size = New System.Drawing.Size(455, 39)
        Me.cb_plan.TabIndex = 253
        '
        'tb_patient_id
        '
        Me.tb_patient_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_id.Location = New System.Drawing.Point(273, 12)
        Me.tb_patient_id.Name = "tb_patient_id"
        Me.tb_patient_id.ReadOnly = True
        Me.tb_patient_id.Size = New System.Drawing.Size(310, 25)
        Me.tb_patient_id.TabIndex = 256
        Me.tb_patient_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_patient_name
        '
        Me.tb_patient_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_patient_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_name.Location = New System.Drawing.Point(273, 49)
        Me.tb_patient_name.Name = "tb_patient_name"
        Me.tb_patient_name.ReadOnly = True
        Me.tb_patient_name.Size = New System.Drawing.Size(310, 25)
        Me.tb_patient_name.TabIndex = 257
        Me.tb_patient_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(588, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "اسم الزبون"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(686, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 31)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "المصرف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(685, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 31)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "اسم الحساب"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(684, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 31)
        Me.Label5.TabIndex = 265
        Me.Label5.Text = "رقم الحساب"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IQTClinicSystem.My.Resources.Resources.Downloads_icon
        Me.PictureBox1.Location = New System.Drawing.Point(422, 486)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 268
        Me.PictureBox1.TabStop = False
        '
        'dt_queue
        '
        Me.dt_queue.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_queue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_queue.Location = New System.Drawing.Point(32, 579)
        Me.dt_queue.Name = "dt_queue"
        Me.dt_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dt_queue.RightToLeftLayout = True
        Me.dt_queue.Size = New System.Drawing.Size(180, 39)
        Me.dt_queue.TabIndex = 270
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 31)
        Me.Label6.TabIndex = 271
        Me.Label6.Text = "تأريخ الطباعة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(589, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 273
        Me.Label7.Text = "رقم العقد"
        '
        'tb_id
        '
        Me.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Location = New System.Drawing.Point(820, 12)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.ReadOnly = True
        Me.tb_id.Size = New System.Drawing.Size(72, 25)
        Me.tb_id.TabIndex = 272
        Me.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(686, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 31)
        Me.Label8.TabIndex = 275
        Me.Label8.Text = "ملاحظة"
        '
        'tb_note
        '
        Me.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_note.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Location = New System.Drawing.Point(228, 289)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.Size = New System.Drawing.Size(455, 32)
        Me.tb_note.TabIndex = 274
        Me.tb_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(691, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 23)
        Me.Label9.TabIndex = 279
        Me.Label9.Text = "الدفعة"
        '
        'tb_number
        '
        Me.tb_number.BackColor = System.Drawing.Color.White
        Me.tb_number.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_number.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_number.Location = New System.Drawing.Point(609, 129)
        Me.tb_number.Name = "tb_number"
        Me.tb_number.Size = New System.Drawing.Size(77, 32)
        Me.tb_number.TabIndex = 278
        Me.tb_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.IQTClinicSystem.My.Resources.Resources.sharp_close_white_18dp1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 280
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(398, 564)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 31)
        Me.Label10.TabIndex = 282
        Me.Label10.Text = "حفظ وطباعة"
        '
        'tb_fesha_amount
        '
        Me.tb_fesha_amount.EnterMoveNextControl = True
        Me.tb_fesha_amount.Location = New System.Drawing.Point(310, 412)
        Me.tb_fesha_amount.Name = "tb_fesha_amount"
        Me.tb_fesha_amount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_fesha_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fesha_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_fesha_amount.Properties.Mask.BeepOnError = True
        Me.tb_fesha_amount.Properties.Mask.EditMask = "n0"
        Me.tb_fesha_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_fesha_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_fesha_amount.Size = New System.Drawing.Size(273, 36)
        Me.tb_fesha_amount.TabIndex = 283
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 31)
        Me.Label3.TabIndex = 284
        Me.Label3.Text = "مبلغ الفيشة"
        '
        'tb_dept_title
        '
        Me.tb_dept_title.EnterMoveNextControl = True
        Me.tb_dept_title.Location = New System.Drawing.Point(226, 129)
        Me.tb_dept_title.Name = "tb_dept_title"
        Me.tb_dept_title.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_dept_title.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dept_title.Properties.Appearance.Options.UseFont = True
        Me.tb_dept_title.Properties.Mask.BeepOnError = True
        Me.tb_dept_title.Properties.Mask.EditMask = "n0"
        Me.tb_dept_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_dept_title.Size = New System.Drawing.Size(377, 34)
        Me.tb_dept_title.TabIndex = 285
        '
        'tb_dept_id
        '
        Me.tb_dept_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_dept_id.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dept_id.Location = New System.Drawing.Point(606, 96)
        Me.tb_dept_id.Name = "tb_dept_id"
        Me.tb_dept_id.ReadOnly = True
        Me.tb_dept_id.Size = New System.Drawing.Size(79, 25)
        Me.tb_dept_id.TabIndex = 286
        Me.tb_dept_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_dept_id.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(688, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 23)
        Me.Label11.TabIndex = 287
        Me.Label11.Text = "تسلسل الدفعة"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(691, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 21)
        Me.Label12.TabIndex = 289
        '
        'tb_amount_text
        '
        Me.tb_amount_text.EnterMoveNextControl = True
        Me.tb_amount_text.Location = New System.Drawing.Point(19, 454)
        Me.tb_amount_text.Name = "tb_amount_text"
        Me.tb_amount_text.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_amount_text.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount_text.Properties.Appearance.Options.UseFont = True
        Me.tb_amount_text.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount_text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount_text.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_amount_text.Properties.Mask.BeepOnError = True
        Me.tb_amount_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_amount_text.Size = New System.Drawing.Size(880, 28)
        Me.tb_amount_text.TabIndex = 288
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(15, 36)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl16.TabIndex = 424
        Me.LabelControl16.Text = "%"
        '
        'nu_first_money_present
        '
        Me.nu_first_money_present.DecimalPlaces = 1
        Me.nu_first_money_present.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_first_money_present.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nu_first_money_present.Location = New System.Drawing.Point(37, 34)
        Me.nu_first_money_present.Name = "nu_first_money_present"
        Me.nu_first_money_present.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_first_money_present.Size = New System.Drawing.Size(72, 29)
        Me.nu_first_money_present.TabIndex = 423
        Me.nu_first_money_present.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_first_money_present.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nu_first_money_present)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Location = New System.Drawing.Point(389, 327)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(132, 79)
        Me.GroupControl1.TabIndex = 425
        Me.GroupControl1.Text = "نسبة الدفعة الاولى"
        '
        'fm_add_queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 629)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_amount_text)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tb_dept_id)
        Me.Controls.Add(Me.tb_dept_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_fesha_amount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_number)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_note)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_queue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_patient_name)
        Me.Controls.Add(Me.tb_patient_id)
        Me.Controls.Add(Me.tb_munite)
        Me.Controls.Add(Me.tb_amount)
        Me.Controls.Add(Me.cb_plan)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_add_queue"
        Me.Text = "اضافة حجز"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_fesha_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_dept_title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_amount_text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nu_first_money_present, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_munite As System.Windows.Forms.TextBox
    Friend WithEvents tb_amount As System.Windows.Forms.TextBox
    Friend WithEvents cb_plan As System.Windows.Forms.ComboBox
    Friend WithEvents tb_patient_id As System.Windows.Forms.TextBox
    Friend WithEvents tb_patient_name As System.Windows.Forms.TextBox
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dt_queue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_id As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_note As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_number As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_fesha_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_dept_title As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_dept_id As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_amount_text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nu_first_money_present As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
