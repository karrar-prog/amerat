<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_call
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_call))
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.IsMetric = True
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(726, 526)
        Me.DocumentViewer1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 36)
        Me.SimpleButton1.TabIndex = 2
        '
        'fm_call
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 526)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fm_call"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fm_call"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
