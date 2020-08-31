<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_money_calculator
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
        Me.components = New System.ComponentModel.Container()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.MaxItemId = 0
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.Text = "Tools"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1008, 27)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 729)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 27)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 702)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 27)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 702)
        '
        'fm_money_calculator
        '
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "fm_money_calculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حساب الكاشير"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend barManager1 As DevExpress.XtraBars.BarManager
    Friend bar1 As DevExpress.XtraBars.Bar
    Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
