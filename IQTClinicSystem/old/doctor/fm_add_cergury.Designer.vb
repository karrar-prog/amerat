<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_cergury
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
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_patient_number = New DevExpress.XtraEditors.TextEdit()
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.tb_date = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_note = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_time = New System.Windows.Forms.DateTimePicker()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_title = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_content = New System.Windows.Forms.TextBox()
        Me.tb_diagonosis = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tb_patient_number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_title.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_diagonosis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(859, 116)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(73, 22)
        Me.LabelControl13.TabIndex = 287
        Me.LabelControl13.Text = "رقم المراجع"
        '
        'tb_patient_number
        '
        Me.tb_patient_number.EnterMoveNextControl = True
        Me.tb_patient_number.Location = New System.Drawing.Point(720, 112)
        Me.tb_patient_number.Name = "tb_patient_number"
        Me.tb_patient_number.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_patient_number.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_patient_number.Properties.Appearance.Options.UseFont = True
        Me.tb_patient_number.Properties.NullValuePrompt = "الاسم"
        Me.tb_patient_number.Properties.ReadOnly = True
        Me.tb_patient_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_patient_number.Size = New System.Drawing.Size(131, 28)
        Me.tb_patient_number.TabIndex = 286
        '
        'tb_name
        '
        Me.tb_name.EnterMoveNextControl = True
        Me.tb_name.Location = New System.Drawing.Point(475, 70)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.tb_name.Properties.Appearance.Options.UseBackColor = True
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.Properties.Appearance.Options.UseForeColor = True
        Me.tb_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_name.Properties.NullValuePrompt = "الاسم"
        Me.tb_name.Properties.ReadOnly = True
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_name.Size = New System.Drawing.Size(376, 28)
        Me.tb_name.TabIndex = 292
        '
        'tb_date
        '
        Me.tb_date.CalendarFont = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_date.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.tb_date.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tb_date.Location = New System.Drawing.Point(147, 160)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_date.RightToLeftLayout = True
        Me.tb_date.Size = New System.Drawing.Size(186, 29)
        Me.tb_date.TabIndex = 293
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(339, 164)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 22)
        Me.LabelControl2.TabIndex = 295
        Me.LabelControl2.Text = "تأريخ العملية"
        '
        'tb_note
        '
        Me.tb_note.BackColor = System.Drawing.Color.Linen
        Me.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_note.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tb_note.Location = New System.Drawing.Point(20, 384)
        Me.tb_note.Multiline = True
        Me.tb_note.Name = "tb_note"
        Me.tb_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_note.Size = New System.Drawing.Size(831, 116)
        Me.tb_note.TabIndex = 296
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(859, 384)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 22)
        Me.LabelControl3.TabIndex = 297
        Me.LabelControl3.Text = "ملاحظات"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IQTClinicSystem.My.Resources.Resources.Downloads_icon
        Me.PictureBox1.Location = New System.Drawing.Point(420, 515)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 298
        Me.PictureBox1.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(339, 209)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 22)
        Me.LabelControl4.TabIndex = 300
        Me.LabelControl4.Text = "وقت العملية"
        '
        'tb_time
        '
        Me.tb_time.CalendarFont = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_time.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.tb_time.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tb_time.Location = New System.Drawing.Point(147, 204)
        Me.tb_time.Name = "tb_time"
        Me.tb_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_time.RightToLeftLayout = True
        Me.tb_time.Size = New System.Drawing.Size(186, 29)
        Me.tb_time.TabIndex = 299
        Me.tb_time.Value = New Date(2018, 9, 15, 17, 19, 0, 0)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(988, 27)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 606)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(988, 31)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(859, 73)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 22)
        Me.LabelControl5.TabIndex = 303
        Me.LabelControl5.Text = "اسم المراجع"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(859, 168)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 22)
        Me.LabelControl6.TabIndex = 307
        Me.LabelControl6.Text = "عنوان العملية"
        '
        'tb_title
        '
        Me.tb_title.EnterMoveNextControl = True
        Me.tb_title.Location = New System.Drawing.Point(475, 162)
        Me.tb_title.Name = "tb_title"
        Me.tb_title.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_title.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tb_title.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_title.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.tb_title.Properties.Appearance.Options.UseBackColor = True
        Me.tb_title.Properties.Appearance.Options.UseFont = True
        Me.tb_title.Properties.Appearance.Options.UseForeColor = True
        Me.tb_title.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_title.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_title.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_title.Properties.NullValuePrompt = "الاسم"
        Me.tb_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_title.Size = New System.Drawing.Size(376, 28)
        Me.tb_title.TabIndex = 306
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(859, 257)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(44, 22)
        Me.LabelControl7.TabIndex = 309
        Me.LabelControl7.Text = "تفاصيل"
        '
        'tb_content
        '
        Me.tb_content.BackColor = System.Drawing.Color.White
        Me.tb_content.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_content.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_content.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tb_content.Location = New System.Drawing.Point(20, 257)
        Me.tb_content.Multiline = True
        Me.tb_content.Name = "tb_content"
        Me.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_content.Size = New System.Drawing.Size(831, 116)
        Me.tb_content.TabIndex = 308
        '
        'tb_diagonosis
        '
        Me.tb_diagonosis.EnterMoveNextControl = True
        Me.tb_diagonosis.Location = New System.Drawing.Point(474, 204)
        Me.tb_diagonosis.Name = "tb_diagonosis"
        Me.tb_diagonosis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_diagonosis.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_diagonosis.Properties.Appearance.Options.UseFont = True
        Me.tb_diagonosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_diagonosis.Size = New System.Drawing.Size(377, 28)
        Me.tb_diagonosis.TabIndex = 310
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(859, 211)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 22)
        Me.LabelControl9.TabIndex = 311
        Me.LabelControl9.Text = "التشخيص"
        '
        'fm_add_cergury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 637)
        Me.Controls.Add(Me.tb_diagonosis)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.tb_content)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.tb_title)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tb_time)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tb_note)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.tb_patient_number)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_add_cergury"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "اضافة موعد عملية"
        CType(Me.tb_patient_number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_title.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_diagonosis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_patient_number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_note As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_title As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_content As System.Windows.Forms.TextBox
    Friend WithEvents tb_diagonosis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
