<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_select_size
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_select_size))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.li_size = New System.Windows.Forms.ListView()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_select_size = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_select_size.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1018, 30)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 744)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1018, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'li_size
        '
        Me.li_size.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_size.FullRowSelect = True
        Me.li_size.GridLines = True
        Me.li_size.Location = New System.Drawing.Point(593, 36)
        Me.li_size.MultiSelect = False
        Me.li_size.Name = "li_size"
        Me.li_size.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_size.RightToLeftLayout = True
        Me.li_size.Size = New System.Drawing.Size(356, 703)
        Me.li_size.TabIndex = 4
        Me.li_size.UseCompatibleStateImageBehavior = False
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(85, 323)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(108, 54)
        Me.SimpleButton6.TabIndex = 63
        Me.SimpleButton6.Text = "تم"
        '
        'tb_select_size
        '
        Me.tb_select_size.EditValue = ""
        Me.tb_select_size.Location = New System.Drawing.Point(218, 326)
        Me.tb_select_size.Name = "tb_select_size"
        Me.tb_select_size.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_select_size.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.tb_select_size.Properties.Appearance.Options.UseFont = True
        Me.tb_select_size.Properties.Appearance.Options.UseForeColor = True
        Me.tb_select_size.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_select_size.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_select_size.Properties.ReadOnly = True
        Me.tb_select_size.Size = New System.Drawing.Size(332, 46)
        Me.tb_select_size.TabIndex = 107
        '
        'fm_select_size
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 767)
        Me.Controls.Add(Me.tb_select_size)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.li_size)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_select_size"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "اختر القياس"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_select_size.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents li_size As System.Windows.Forms.ListView
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_select_size As DevExpress.XtraEditors.TextEdit
End Class
