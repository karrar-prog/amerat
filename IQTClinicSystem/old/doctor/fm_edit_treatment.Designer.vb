<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_edit_treatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_edit_treatment))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_treatment_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_present = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_months_period = New System.Windows.Forms.NumericUpDown()
        Me.tb_selected_money = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_note = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_treatment_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_present, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_months_period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_selected_money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(680, 27)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 555)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(680, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(83, 153)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 30)
        Me.SimpleButton2.TabIndex = 329
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(269, 398)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 326
        Me.PictureBox3.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(83, 288)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(42, 30)
        Me.SimpleButton1.TabIndex = 330
        '
        'tb_treatment_name
        '
        Me.tb_treatment_name.EnterMoveNextControl = True
        Me.tb_treatment_name.Location = New System.Drawing.Point(131, 94)
        Me.tb_treatment_name.Name = "tb_treatment_name"
        Me.tb_treatment_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_treatment_name.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_treatment_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_treatment_name.Properties.Appearance.Options.UseBackColor = True
        Me.tb_treatment_name.Properties.Appearance.Options.UseFont = True
        Me.tb_treatment_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_treatment_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_treatment_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tb_treatment_name.Properties.Mask.BeepOnError = True
        Me.tb_treatment_name.Properties.Mask.EditMask = "d"
        Me.tb_treatment_name.Properties.NullValuePrompt = "ابحث عن اسم دواء هنا .."
        Me.tb_treatment_name.Size = New System.Drawing.Size(330, 30)
        Me.tb_treatment_name.TabIndex = 331
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(467, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 21)
        Me.LabelControl1.TabIndex = 335
        Me.LabelControl1.Text = "العنوان"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(467, 153)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 21)
        Me.LabelControl2.TabIndex = 336
        Me.LabelControl2.Text = "المبلغ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(383, 155)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 21)
        Me.LabelControl4.TabIndex = 429
        Me.LabelControl4.Text = "%"
        '
        'tb_present
        '
        Me.tb_present.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_present.Location = New System.Drawing.Point(404, 151)
        Me.tb_present.Name = "tb_present"
        Me.tb_present.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_present.Size = New System.Drawing.Size(57, 29)
        Me.tb_present.TabIndex = 428
        Me.tb_present.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_present.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(467, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 21)
        Me.Label6.TabIndex = 427
        Me.Label6.Text = "الدفعة الاحق بعد"
        '
        'tb_months_period
        '
        Me.tb_months_period.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_months_period.Location = New System.Drawing.Point(383, 241)
        Me.tb_months_period.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.tb_months_period.Name = "tb_months_period"
        Me.tb_months_period.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_months_period.Size = New System.Drawing.Size(78, 32)
        Me.tb_months_period.TabIndex = 426
        Me.tb_months_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_months_period.ThousandsSeparator = True
        Me.tb_months_period.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'tb_selected_money
        '
        Me.tb_selected_money.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_selected_money.Increment = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.tb_selected_money.Location = New System.Drawing.Point(131, 150)
        Me.tb_selected_money.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.tb_selected_money.Name = "tb_selected_money"
        Me.tb_selected_money.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_selected_money.Size = New System.Drawing.Size(248, 32)
        Me.tb_selected_money.TabIndex = 424
        Me.tb_selected_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_selected_money.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 430
        Me.Label1.Text = "أشهر"
        '
        'tb_note
        '
        Me.tb_note.EnterMoveNextControl = True
        Me.tb_note.Location = New System.Drawing.Point(131, 288)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_note.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Properties.Appearance.Options.UseFont = True
        Me.tb_note.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_note.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_note.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_note.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tb_note.Properties.Mask.BeepOnError = True
        Me.tb_note.Properties.NullValuePrompt = "اكتب ملاحظاتك هنا"
        Me.tb_note.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_note.Size = New System.Drawing.Size(330, 30)
        Me.tb_note.TabIndex = 309
        '
        'fm_edit_treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(680, 586)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tb_present)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_months_period)
        Me.Controls.Add(Me.tb_selected_money)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_treatment_name)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.tb_note)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_edit_treatment"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "تعديل الاستحقاق"
        Me.TopMost = True
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_treatment_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_present, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_months_period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_selected_money, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_treatment_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_present As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_months_period As System.Windows.Forms.NumericUpDown
    Friend WithEvents tb_selected_money As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_note As DevExpress.XtraEditors.TextEdit
End Class
