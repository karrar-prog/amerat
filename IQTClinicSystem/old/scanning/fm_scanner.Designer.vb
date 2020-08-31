<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_scanner
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
        Me.DsViewer1 = New Dynamsoft.Forms.DSViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DsViewer1
        '
        Me.DsViewer1.Location = New System.Drawing.Point(12, 12)
        Me.DsViewer1.Name = "DsViewer1"
        Me.DsViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DsViewer1.SelectionRectAspectRatio = 0.0R
        Me.DsViewer1.Size = New System.Drawing.Size(488, 600)
        Me.DsViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(737, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fm_scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 624)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DsViewer1)
        Me.Name = "fm_scanner"
        Me.Text = "fm_scanner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsViewer1 As Dynamsoft.Forms.DSViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
