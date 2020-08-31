<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_ser_report
    Inherits DevExpress.XtraBars.TabForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_ser_report))
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.IsMetric = True
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 102)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(1095, 505)
        Me.DocumentViewer1.TabIndex = 19
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 61)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 42)
        Me.SimpleButton1.TabIndex = 20
        Me.SimpleButton1.Text = "طباعة"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 607)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1095, 28)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.Size = New System.Drawing.Size(1095, 55)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 24
        Me.TabFormControl1.TabStop = False
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 55)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RibbonControl1.Size = New System.Drawing.Size(1095, 47)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'fm_ser_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 635)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Name = "fm_ser_report"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.TabFormControl = Me.TabFormControl1
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
End Class
