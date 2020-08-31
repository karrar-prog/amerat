<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_tasded_part
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_tasded_part))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_amount = New DevExpress.XtraEditors.TextEdit()
        Me.tb_arrive = New DevExpress.XtraEditors.TextEdit()
        Me.tb_remand = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_arrived = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_f1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_user_id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_arrive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_remand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_arrived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_f1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'tb_id
        '
        Me.tb_id.EditValue = "0"
        Me.tb_id.EnterMoveNextControl = True
        Me.tb_id.Location = New System.Drawing.Point(100, 80)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_id.Properties.Mask.BeepOnError = True
        Me.tb_id.Properties.Mask.EditMask = "n0"
        Me.tb_id.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_id.Properties.NullValuePrompt = " "
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(246, 30)
        Me.tb_id.TabIndex = 7
        Me.tb_id.Visible = False
        '
        'tb_amount
        '
        Me.tb_amount.EditValue = "0"
        Me.tb_amount.EnterMoveNextControl = True
        Me.tb_amount.Location = New System.Drawing.Point(100, 126)
        Me.tb_amount.Name = "tb_amount"
        Me.tb_amount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_amount.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_amount.Properties.Appearance.Options.UseFont = True
        Me.tb_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_amount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_amount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_amount.Properties.Mask.BeepOnError = True
        Me.tb_amount.Properties.Mask.EditMask = "n0"
        Me.tb_amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_amount.Properties.NullValuePrompt = " "
        Me.tb_amount.Properties.ReadOnly = True
        Me.tb_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_amount.Size = New System.Drawing.Size(246, 30)
        Me.tb_amount.TabIndex = 6
        '
        'tb_arrive
        '
        Me.tb_arrive.EditValue = ""
        Me.tb_arrive.EnterMoveNextControl = True
        Me.tb_arrive.Location = New System.Drawing.Point(100, 218)
        Me.tb_arrive.Name = "tb_arrive"
        Me.tb_arrive.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_arrive.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arrive.Properties.Appearance.Options.UseFont = True
        Me.tb_arrive.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_arrive.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_arrive.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_arrive.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_arrive.Properties.Mask.BeepOnError = True
        Me.tb_arrive.Properties.Mask.EditMask = "n0"
        Me.tb_arrive.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_arrive.Properties.NullValuePrompt = " "
        Me.tb_arrive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_arrive.Size = New System.Drawing.Size(246, 30)
        Me.tb_arrive.TabIndex = 0
        '
        'tb_remand
        '
        Me.tb_remand.EditValue = "0"
        Me.tb_remand.EnterMoveNextControl = True
        Me.tb_remand.Location = New System.Drawing.Point(100, 264)
        Me.tb_remand.Name = "tb_remand"
        Me.tb_remand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_remand.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_remand.Properties.Appearance.Options.UseFont = True
        Me.tb_remand.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_remand.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_remand.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_remand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_remand.Properties.Mask.BeepOnError = True
        Me.tb_remand.Properties.Mask.EditMask = "n0"
        Me.tb_remand.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_remand.Properties.NullValuePrompt = " "
        Me.tb_remand.Properties.ReadOnly = True
        Me.tb_remand.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_remand.Size = New System.Drawing.Size(246, 30)
        Me.tb_remand.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(366, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(14, 21)
        Me.LabelControl4.TabIndex = 358
        Me.LabelControl4.Text = "ت"
        Me.LabelControl4.Visible = False
        '
        'tb_arrived
        '
        Me.tb_arrived.EditValue = "0"
        Me.tb_arrived.EnterMoveNextControl = True
        Me.tb_arrived.Location = New System.Drawing.Point(100, 172)
        Me.tb_arrived.Name = "tb_arrived"
        Me.tb_arrived.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_arrived.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_arrived.Properties.Appearance.Options.UseFont = True
        Me.tb_arrived.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_arrived.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_arrived.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_arrived.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_arrived.Properties.Mask.BeepOnError = True
        Me.tb_arrived.Properties.Mask.EditMask = "n0"
        Me.tb_arrived.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_arrived.Properties.NullValuePrompt = " "
        Me.tb_arrived.Properties.ReadOnly = True
        Me.tb_arrived.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_arrived.Size = New System.Drawing.Size(246, 30)
        Me.tb_arrived.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(358, 132)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 21)
        Me.LabelControl1.TabIndex = 360
        Me.LabelControl1.Text = "المبلغ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(358, 178)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 21)
        Me.LabelControl2.TabIndex = 361
        Me.LabelControl2.Text = "واصل سابق"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(358, 224)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 21)
        Me.LabelControl3.TabIndex = 362
        Me.LabelControl3.Text = "واصل الان"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(180, 370)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(94, 41)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "تم"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(358, 270)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(25, 21)
        Me.LabelControl5.TabIndex = 364
        Me.LabelControl5.Text = "باقي"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(149, 36)
        Me.SimpleButton1.TabIndex = 365
        Me.SimpleButton1.Text = "الغاء العملية"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(358, 319)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 21)
        Me.LabelControl6.TabIndex = 367
        Me.LabelControl6.Text = "ملاحظه"
        '
        'tb_f1
        '
        Me.tb_f1.EditValue = ""
        Me.tb_f1.EnterMoveNextControl = True
        Me.tb_f1.Location = New System.Drawing.Point(100, 313)
        Me.tb_f1.Name = "tb_f1"
        Me.tb_f1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_f1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_f1.Properties.Appearance.Options.UseFont = True
        Me.tb_f1.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_f1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_f1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_f1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_f1.Properties.Mask.BeepOnError = True
        Me.tb_f1.Properties.NullValuePrompt = " "
        Me.tb_f1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_f1.Size = New System.Drawing.Size(246, 30)
        Me.tb_f1.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(366, 21)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(58, 21)
        Me.LabelControl7.TabIndex = 368
        Me.LabelControl7.Text = "تسديد دين"
        Me.LabelControl7.Visible = False
        '
        'tb_user_id
        '
        Me.tb_user_id.EditValue = "0"
        Me.tb_user_id.EnterMoveNextControl = True
        Me.tb_user_id.Location = New System.Drawing.Point(167, 44)
        Me.tb_user_id.Name = "tb_user_id"
        Me.tb_user_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_user_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user_id.Properties.Appearance.Options.UseFont = True
        Me.tb_user_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_user_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_user_id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_user_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tb_user_id.Properties.Mask.BeepOnError = True
        Me.tb_user_id.Properties.Mask.EditMask = "n0"
        Me.tb_user_id.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_user_id.Properties.NullValuePrompt = " "
        Me.tb_user_id.Properties.ReadOnly = True
        Me.tb_user_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_user_id.Size = New System.Drawing.Size(246, 30)
        Me.tb_user_id.TabIndex = 386
        Me.tb_user_id.Visible = False
        '
        'fm_tasded_part
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 448)
        Me.Controls.Add(Me.tb_user_id)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.tb_f1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_arrived)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tb_remand)
        Me.Controls.Add(Me.tb_arrive)
        Me.Controls.Add(Me.tb_amount)
        Me.Controls.Add(Me.tb_id)
        Me.Name = "fm_tasded_part"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fm_tasded_part"
        Me.TopMost = True
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_arrive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_remand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_arrived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_f1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_user_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_arrive As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_remand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_arrived As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_f1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_user_id As DevExpress.XtraEditors.TextEdit
End Class
