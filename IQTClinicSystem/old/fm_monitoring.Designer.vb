<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_monitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_monitoring))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarStaticItem1, Me.BarHeaderItem1, Me.BarHeaderItem2})
        resources.ApplyResources(Me.RibbonControl1, "RibbonControl1")
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.BarHeaderItem1)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.BarHeaderItem2)
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'BarStaticItem1
        '
        resources.ApplyResources(Me.BarStaticItem1, "BarStaticItem1")
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.ImageOptions.Image = CType(resources.GetObject("BarStaticItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Appearance.BackColor = CType(resources.GetObject("BarHeaderItem1.Appearance.BackColor"), System.Drawing.Color)
        Me.BarHeaderItem1.Appearance.Font = CType(resources.GetObject("BarHeaderItem1.Appearance.Font"), System.Drawing.Font)
        Me.BarHeaderItem1.Appearance.Options.UseBackColor = True
        Me.BarHeaderItem1.Appearance.Options.UseFont = True
        resources.ApplyResources(Me.BarHeaderItem1, "BarHeaderItem1")
        Me.BarHeaderItem1.Id = 3
        Me.BarHeaderItem1.ImageOptions.Image = CType(resources.GetObject("BarHeaderItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarHeaderItem1.MergeOrder = 2
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarHeaderItem2
        '
        resources.ApplyResources(Me.BarHeaderItem2, "BarHeaderItem2")
        Me.BarHeaderItem2.Id = 4
        Me.BarHeaderItem2.ImageOptions.Image = CType(resources.GetObject("BarHeaderItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'RibbonStatusBar1
        '
        resources.ApplyResources(Me.RibbonStatusBar1, "RibbonStatusBar1")
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        resources.ApplyResources(Me.RibbonPage2, "RibbonPage2")
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'fm_monitoring
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "fm_monitoring"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
End Class
