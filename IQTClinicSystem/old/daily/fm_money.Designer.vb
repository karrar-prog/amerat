<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_money
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
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.tb_total_total = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb22 = New DevExpress.XtraEditors.TextEdit()
        Me.tb55 = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_d_money = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        CType(Me.tb_total_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb55.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_d_money.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 509)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(850, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'tb_total_total
        '
        Me.tb_total_total.Location = New System.Drawing.Point(267, 269)
        Me.tb_total_total.Name = "tb_total_total"
        Me.tb_total_total.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_total_total.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_total.Properties.Appearance.Options.UseFont = True
        Me.tb_total_total.Properties.Mask.EditMask = "d"
        Me.tb_total_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_total_total.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.tb_total_total.Properties.ReadOnly = True
        Me.tb_total_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_total_total.Size = New System.Drawing.Size(248, 30)
        Me.tb_total_total.TabIndex = 370
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(521, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 24)
        Me.Label12.TabIndex = 369
        Me.Label12.Text = "مجموع دخل العيادة"
        '
        'tb22
        '
        Me.tb22.Location = New System.Drawing.Point(267, 330)
        Me.tb22.Name = "tb22"
        Me.tb22.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb22.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb22.Properties.Appearance.Options.UseFont = True
        Me.tb22.Properties.Mask.EditMask = "d"
        Me.tb22.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb22.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.tb22.Properties.ReadOnly = True
        Me.tb22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb22.Size = New System.Drawing.Size(248, 30)
        Me.tb22.TabIndex = 368
        '
        'tb55
        '
        Me.tb55.Location = New System.Drawing.Point(267, 300)
        Me.tb55.Name = "tb55"
        Me.tb55.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb55.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb55.Properties.Appearance.Options.UseFont = True
        Me.tb55.Properties.Mask.EditMask = "d"
        Me.tb55.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb55.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.tb55.Properties.ReadOnly = True
        Me.tb55.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb55.Size = New System.Drawing.Size(248, 30)
        Me.tb55.TabIndex = 365
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(521, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 24)
        Me.Label11.TabIndex = 367
        Me.Label11.Text = "مجموع مبالغ الاطباء"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(521, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 24)
        Me.Label9.TabIndex = 366
        Me.Label9.Text = "مجموع مبالغ المستلزمات"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(391, 94)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Mask.EditMask = "d"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(124, 30)
        Me.TextEdit1.TabIndex = 373
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(267, 94)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Mask.EditMask = "d"
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit2.Size = New System.Drawing.Size(118, 30)
        Me.TextEdit2.TabIndex = 372
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(267, 133)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Mask.EditMask = "d"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit3.Size = New System.Drawing.Size(248, 30)
        Me.TextEdit3.TabIndex = 371
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 374
        Me.Label1.Text = "بين التأريخين"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(527, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 375
        Me.Label2.Text = "اسم الطبيب"
        '
        'tb_d_money
        '
        Me.tb_d_money.Location = New System.Drawing.Point(267, 212)
        Me.tb_d_money.Name = "tb_d_money"
        Me.tb_d_money.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_d_money.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d_money.Properties.Appearance.Options.UseFont = True
        Me.tb_d_money.Properties.Mask.EditMask = "d"
        Me.tb_d_money.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_d_money.Properties.NullValuePrompt = "الرقم , Barcode"
        Me.tb_d_money.Properties.ReadOnly = True
        Me.tb_d_money.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_d_money.Size = New System.Drawing.Size(248, 30)
        Me.tb_d_money.TabIndex = 379
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(521, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "مجموع دخل الاطباء"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(850, 32)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'fm_money
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 532)
        Me.Controls.Add(Me.tb_d_money)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.tb_total_total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb22)
        Me.Controls.Add(Me.tb55)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_money"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "احصائيات"
        CType(Me.tb_total_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb55.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_d_money.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tb_total_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb55 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_d_money As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
End Class
