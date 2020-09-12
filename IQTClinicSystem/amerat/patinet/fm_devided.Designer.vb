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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_months_period = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.nu_first_money_present = New System.Windows.Forms.NumericUpDown()
        CType(Me.nu_first_part, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_count_devided, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_first_money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_months_period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nu_first_money_present, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nu_first_part
        '
        Me.nu_first_part.Enabled = False
        Me.nu_first_part.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_first_part.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nu_first_part.Location = New System.Drawing.Point(180, 64)
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
        Me.tb_count_devided.Location = New System.Drawing.Point(180, 102)
        Me.tb_count_devided.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_count_devided.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tb_count_devided.Name = "tb_count_devided"
        Me.tb_count_devided.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_count_devided.Size = New System.Drawing.Size(201, 32)
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
        Me.tb_first_money.Location = New System.Drawing.Point(180, 168)
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
        Me.Label3.Location = New System.Drawing.Point(387, 69)
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
        Me.Label1.Location = New System.Drawing.Point(387, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "تقسم الدفعات على"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 21)
        Me.Label2.TabIndex = 411
        Me.Label2.Text = "أشهر"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "الدفعة الاولى"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 211)
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
        Me.Label6.Location = New System.Drawing.Point(387, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 414
        Me.Label6.Text = "الدفعات البقية كل"
        '
        'tb_months_period
        '
        Me.tb_months_period.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_months_period.Location = New System.Drawing.Point(180, 206)
        Me.tb_months_period.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_months_period.Name = "tb_months_period"
        Me.tb_months_period.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_months_period.Size = New System.Drawing.Size(201, 32)
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
        Me.Label7.Location = New System.Drawing.Point(91, 173)
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
        Me.Label8.Location = New System.Drawing.Point(91, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 417
        Me.Label8.Text = "دينار عراقي"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(180, 281)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(201, 36)
        Me.SimpleButton6.TabIndex = 418
        Me.SimpleButton6.Text = "تم"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
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
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(385, 173)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl16.TabIndex = 421
        Me.LabelControl16.Text = "%"
        '
        'nu_first_money_present
        '
        Me.nu_first_money_present.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nu_first_money_present.Location = New System.Drawing.Point(406, 169)
        Me.nu_first_money_present.Name = "nu_first_money_present"
        Me.nu_first_money_present.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nu_first_money_present.Size = New System.Drawing.Size(57, 29)
        Me.nu_first_money_present.TabIndex = 420
        Me.nu_first_money_present.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nu_first_money_present.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'fm_devided
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 363)
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
        Me.Controls.Add(Me.Label2)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nu_first_part As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_count_devided As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_first_money As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
End Class
