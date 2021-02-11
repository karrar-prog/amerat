<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_taajeel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_taajeel))
        Me.tb_name = New DevExpress.XtraEditors.TextEdit()
        Me.tb_phone = New DevExpress.XtraEditors.TextEdit()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_payment_date = New DevExpress.XtraEditors.TextEdit()
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_phone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_payment_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_name
        '
        Me.tb_name.EnterMoveNextControl = True
        Me.tb_name.Location = New System.Drawing.Point(153, 148)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_name.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Properties.Appearance.Options.UseBackColor = True
        Me.tb_name.Properties.Appearance.Options.UseFont = True
        Me.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_name.Size = New System.Drawing.Size(315, 30)
        Me.tb_name.TabIndex = 252
        '
        'tb_phone
        '
        Me.tb_phone.EnterMoveNextControl = True
        Me.tb_phone.Location = New System.Drawing.Point(153, 101)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_phone.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_phone.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_phone.Properties.Appearance.Options.UseBackColor = True
        Me.tb_phone.Properties.Appearance.Options.UseFont = True
        Me.tb_phone.Properties.Mask.BeepOnError = True
        Me.tb_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_phone.Size = New System.Drawing.Size(315, 30)
        Me.tb_phone.TabIndex = 253
        '
        'tb_id
        '
        Me.tb_id.EnterMoveNextControl = True
        Me.tb_id.Location = New System.Drawing.Point(254, 29)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.NullValuePrompt = "الاسم"
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(109, 30)
        Me.tb_id.TabIndex = 256
        Me.tb_id.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(277, 202)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(66, 21)
        Me.LabelControl9.TabIndex = 259
        Me.LabelControl9.Text = "ايام التأجيل"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(475, 151)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 21)
        Me.LabelControl1.TabIndex = 255
        Me.LabelControl1.Text = "الاسم"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(475, 106)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 21)
        Me.LabelControl7.TabIndex = 258
        Me.LabelControl7.Text = "الدفعة"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(286, 6)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 21)
        Me.LabelControl6.TabIndex = 257
        Me.LabelControl6.Text = "تسلسل"
        Me.LabelControl6.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(254, 229)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 35)
        Me.NumericUpDown1.TabIndex = 260
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(254, 305)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 48)
        Me.SimpleButton3.TabIndex = 276
        Me.SimpleButton3.Text = "تأجيل"
        '
        'tb_payment_date
        '
        Me.tb_payment_date.EnterMoveNextControl = True
        Me.tb_payment_date.Location = New System.Drawing.Point(181, 65)
        Me.tb_payment_date.Name = "tb_payment_date"
        Me.tb_payment_date.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_payment_date.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_payment_date.Properties.Appearance.Options.UseFont = True
        Me.tb_payment_date.Properties.NullValuePrompt = "الاسم"
        Me.tb_payment_date.Properties.ReadOnly = True
        Me.tb_payment_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_payment_date.Size = New System.Drawing.Size(249, 30)
        Me.tb_payment_date.TabIndex = 277
        Me.tb_payment_date.Visible = False
        '
        'fm_taajeel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 386)
        Me.Controls.Add(Me.tb_payment_date)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.tb_phone)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_taajeel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تأجيل موعد"
        Me.TopMost = True
        CType(Me.tb_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_phone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_payment_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_phone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_payment_date As DevExpress.XtraEditors.TextEdit
End Class
