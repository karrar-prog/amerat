<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_customer_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_customer_info))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_customer_type = New DevExpress.XtraEditors.TextEdit()
        Me.tb_customer_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_customer_name = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tb_customer_note = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_customer_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_customer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_customer_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_customer_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Left
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
        Me.RibbonControl1.Size = New System.Drawing.Size(556, 30)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 426)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(556, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(230, 122)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 24)
        Me.LabelControl4.TabIndex = 115
        Me.LabelControl4.Text = "اسم الزبون"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(77, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl2.TabIndex = 114
        Me.LabelControl2.Text = "رقم الزبون"
        Me.LabelControl2.Visible = False
        '
        'tb_customer_type
        '
        Me.tb_customer_type.EditValue = ""
        Me.tb_customer_type.Location = New System.Drawing.Point(47, 45)
        Me.tb_customer_type.Name = "tb_customer_type"
        Me.tb_customer_type.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_type.Properties.Appearance.Options.UseFont = True
        Me.tb_customer_type.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_customer_type.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_customer_type.Properties.ReadOnly = True
        Me.tb_customer_type.Size = New System.Drawing.Size(30, 30)
        Me.tb_customer_type.TabIndex = 113
        Me.tb_customer_type.Visible = False
        '
        'tb_customer_id
        '
        Me.tb_customer_id.EditValue = ""
        Me.tb_customer_id.Location = New System.Drawing.Point(12, 105)
        Me.tb_customer_id.Name = "tb_customer_id"
        Me.tb_customer_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_id.Properties.Appearance.Options.UseFont = True
        Me.tb_customer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_customer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_customer_id.Properties.ReadOnly = True
        Me.tb_customer_id.Size = New System.Drawing.Size(172, 30)
        Me.tb_customer_id.TabIndex = 109
        Me.tb_customer_id.Visible = False
        '
        'tb_customer_name
        '
        Me.tb_customer_name.EditValue = ""
        Me.tb_customer_name.Location = New System.Drawing.Point(129, 152)
        Me.tb_customer_name.Name = "tb_customer_name"
        Me.tb_customer_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_name.Properties.Appearance.Options.UseFont = True
        Me.tb_customer_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_customer_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_customer_name.Size = New System.Drawing.Size(293, 30)
        Me.tb_customer_name.TabIndex = 110
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(202, 306)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(134, 48)
        Me.SimpleButton4.TabIndex = 112
        Me.SimpleButton4.Text = "طباعة البطاقة"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(187, 211)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(185, 24)
        Me.LabelControl1.TabIndex = 117
        Me.LabelControl1.Text = "ملاحظات تكتب على البطاقة"
        '
        'tb_customer_note
        '
        Me.tb_customer_note.EditValue = ""
        Me.tb_customer_note.Location = New System.Drawing.Point(129, 241)
        Me.tb_customer_note.Name = "tb_customer_note"
        Me.tb_customer_note.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_note.Properties.Appearance.Options.UseFont = True
        Me.tb_customer_note.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_customer_note.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_customer_note.Size = New System.Drawing.Size(293, 30)
        Me.tb_customer_note.TabIndex = 116
        '
        'fm_customer_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 449)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tb_customer_note)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tb_customer_type)
        Me.Controls.Add(Me.tb_customer_id)
        Me.Controls.Add(Me.tb_customer_name)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_customer_info"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "معلومات الصديق"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_customer_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_customer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_customer_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_customer_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_customer_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_customer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_customer_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tb_customer_note As DevExpress.XtraEditors.TextEdit
End Class
