<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_devided
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_devided))
        Me.nu_first_part = New System.Windows.Forms.NumericUpDown()
        Me.tb_count_devided = New System.Windows.Forms.NumericUpDown()
        Me.tb_first_money = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_months_period = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.nu_first_money_present = New System.Windows.Forms.NumericUpDown()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.nu_midel = New System.Windows.Forms.NumericUpDown()
        Me.nu_last = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nu_total = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_midel_amount = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_last_amount = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_total_amount = New System.Windows.Forms.NumericUpDown()
        CType(Me.nu_first_part, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_count_devided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_first_money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_months_period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_first_money_present, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_midel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_last, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_midel_amount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_last_amount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_total_amount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nu_first_part
        '
        Me.nu_first_part.Enabled = False
        Me.nu_first_part.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_first_part.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nu_first_part.Location = New System.Drawing.Point(385, 12)
        Me.nu_first_part.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.nu_first_part.Name = "nu_first_part"
        Me.nu_first_part.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_first_part.Size = New System.Drawing.Size(201, 32)
        Me.nu_first_part.TabIndex = 406
        Me.nu_first_part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_first_part.ThousandsSeparator = True
        Me.nu_first_part.Value = New Decimal(New Integer() {45000000, 0, 0, 0})
        '
        'tb_count_devided
        '
        Me.tb_count_devided.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_count_devided.Location = New System.Drawing.Point(496, 50)
        Me.tb_count_devided.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_count_devided.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_count_devided.Name = "tb_count_devided"
        Me.tb_count_devided.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_count_devided.Size = New System.Drawing.Size(90, 32)
        Me.tb_count_devided.TabIndex = 407
        Me.tb_count_devided.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_count_devided.ThousandsSeparator = True
        Me.tb_count_devided.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'tb_first_money
        '
        Me.tb_first_money.Enabled = False
        Me.tb_first_money.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_first_money.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.tb_first_money.Location = New System.Drawing.Point(230, 177)
        Me.tb_first_money.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.tb_first_money.Name = "tb_first_money"
        Me.tb_first_money.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_first_money.Size = New System.Drawing.Size(201, 32)
        Me.tb_first_money.TabIndex = 408
        Me.tb_first_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_first_money.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(592, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 409
        Me.Label3.Text = "القسم الاول للمبلغ "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "تقسم الدفعات على"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "دينار عراقي"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 415
        Me.Label5.Text = "أشهر"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 414
        Me.Label6.Text = "الدفعات الوسطية"
        '
        'tb_months_period
        '
        Me.tb_months_period.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_months_period.Location = New System.Drawing.Point(496, 88)
        Me.tb_months_period.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_months_period.Name = "tb_months_period"
        Me.tb_months_period.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_months_period.Size = New System.Drawing.Size(90, 32)
        Me.tb_months_period.TabIndex = 413
        Me.tb_months_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_months_period.ThousandsSeparator = True
        Me.tb_months_period.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 416
        Me.Label7.Text = "دينار عراقي"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 417
        Me.Label8.Text = "دينار عراقي"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(435, 182)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl16.TabIndex = 421
        Me.LabelControl16.Text = "%"
        '
        'nu_first_money_present
        '
        Me.nu_first_money_present.DecimalPlaces = 1
        Me.nu_first_money_present.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_first_money_present.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nu_first_money_present.Location = New System.Drawing.Point(456, 178)
        Me.nu_first_money_present.Name = "nu_first_money_present"
        Me.nu_first_money_present.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_first_money_present.Size = New System.Drawing.Size(72, 29)
        Me.nu_first_money_present.TabIndex = 420
        Me.nu_first_money_present.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_first_money_present.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(98, 36)
        Me.SimpleButton8.TabIndex = 419
        Me.SimpleButton8.Text = "اغلاق"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(252, 380)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(201, 36)
        Me.SimpleButton6.TabIndex = 418
        Me.SimpleButton6.Text = "تم"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(435, 232)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl1.TabIndex = 423
        Me.LabelControl1.Text = "%"
        '
        'nu_midel
        '
        Me.nu_midel.DecimalPlaces = 1
        Me.nu_midel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_midel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nu_midel.Location = New System.Drawing.Point(456, 228)
        Me.nu_midel.Name = "nu_midel"
        Me.nu_midel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_midel.Size = New System.Drawing.Size(72, 29)
        Me.nu_midel.TabIndex = 422
        Me.nu_midel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_midel.Value = New Decimal(New Integer() {50, 0, 0, 65536})
        '
        'nu_last
        '
        Me.nu_last.DecimalPlaces = 1
        Me.nu_last.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_last.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nu_last.Location = New System.Drawing.Point(456, 275)
        Me.nu_last.Name = "nu_last"
        Me.nu_last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_last.Size = New System.Drawing.Size(72, 29)
        Me.nu_last.TabIndex = 424
        Me.nu_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_last.Value = New Decimal(New Integer() {50, 0, 0, 65536})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(531, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 425
        Me.Label9.Text = "الدفعة الاخيره"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(434, 280)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl2.TabIndex = 426
        Me.LabelControl2.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(592, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 21)
        Me.Label10.TabIndex = 427
        Me.Label10.Text = "المدة بين كل دفعة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 428
        Me.Label2.Text = "دفعات"
        '
        'nu_total
        '
        Me.nu_total.DecimalPlaces = 1
        Me.nu_total.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_total.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nu_total.Location = New System.Drawing.Point(456, 324)
        Me.nu_total.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nu_total.Name = "nu_total"
        Me.nu_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_total.Size = New System.Drawing.Size(72, 29)
        Me.nu_total.TabIndex = 429
        Me.nu_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(531, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 21)
        Me.Label11.TabIndex = 430
        Me.Label11.Text = "النسبة الكلية"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(437, 326)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl3.TabIndex = 431
        Me.LabelControl3.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(141, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 21)
        Me.Label12.TabIndex = 433
        Me.Label12.Text = "دينار عراقي"
        '
        'tb_midel_amount
        '
        Me.tb_midel_amount.Enabled = False
        Me.tb_midel_amount.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_midel_amount.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.tb_midel_amount.Location = New System.Drawing.Point(230, 228)
        Me.tb_midel_amount.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.tb_midel_amount.Name = "tb_midel_amount"
        Me.tb_midel_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_midel_amount.Size = New System.Drawing.Size(201, 32)
        Me.tb_midel_amount.TabIndex = 432
        Me.tb_midel_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_midel_amount.ThousandsSeparator = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(141, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 435
        Me.Label13.Text = "دينار عراقي"
        '
        'tb_last_amount
        '
        Me.tb_last_amount.Enabled = False
        Me.tb_last_amount.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_last_amount.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.tb_last_amount.Location = New System.Drawing.Point(230, 275)
        Me.tb_last_amount.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.tb_last_amount.Name = "tb_last_amount"
        Me.tb_last_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_last_amount.Size = New System.Drawing.Size(201, 32)
        Me.tb_last_amount.TabIndex = 434
        Me.tb_last_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_last_amount.ThousandsSeparator = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(539, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 21)
        Me.Label14.TabIndex = 437
        Me.Label14.Text = "الدفعة الاولى"
        '
        'tb_total_amount
        '
        Me.tb_total_amount.Enabled = False
        Me.tb_total_amount.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_amount.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.tb_total_amount.Location = New System.Drawing.Point(230, 321)
        Me.tb_total_amount.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.tb_total_amount.Name = "tb_total_amount"
        Me.tb_total_amount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_total_amount.Size = New System.Drawing.Size(201, 32)
        Me.tb_total_amount.TabIndex = 436
        Me.tb_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_total_amount.ThousandsSeparator = True
        '
        'fm_devided
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 427)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tb_total_amount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_last_amount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_midel_amount)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nu_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nu_last)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.nu_midel)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.nu_first_money_present)
        Me.Controls.Add(Me.SimpleButton8)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_months_period)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_first_money)
        Me.Controls.Add(Me.tb_count_devided)
        Me.Controls.Add(Me.nu_first_part)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "fm_devided"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ث~بئ"
        Me.TopMost = True
        CType(Me.nu_first_part, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_count_devided, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_first_money, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_months_period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nu_first_money_present, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nu_midel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nu_last, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nu_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_midel_amount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_last_amount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_total_amount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nu_first_part As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_count_devided As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_first_money As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_months_period As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nu_first_money_present As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nu_midel As System.Windows.Forms.NumericUpDown
    Friend WithEvents nu_last As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nu_total As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_midel_amount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_last_amount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_total_amount As System.Windows.Forms.NumericUpDown
End Class
