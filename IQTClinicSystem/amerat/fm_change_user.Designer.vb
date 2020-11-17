<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_change_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_change_user))
        Me.tb_secret_word = New System.Windows.Forms.TextBox()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'tb_secret_word
        '
        Me.tb_secret_word.BackColor = System.Drawing.Color.White
        Me.tb_secret_word.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_secret_word.Location = New System.Drawing.Point(171, 144)
        Me.tb_secret_word.Name = "tb_secret_word"
        Me.tb_secret_word.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_secret_word.Size = New System.Drawing.Size(207, 35)
        Me.tb_secret_word.TabIndex = 289
        Me.tb_secret_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(87, 142)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(81, 38)
        Me.SimpleButton5.TabIndex = 291
        Me.SimpleButton5.Text = "دخول"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton13.Appearance.Options.UseFont = True
        Me.SimpleButton13.ImageOptions.Image = CType(resources.GetObject("SimpleButton13.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(87, 100)
        Me.SimpleButton13.Margin = New System.Windows.Forms.Padding(9)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(288, 38)
        Me.SimpleButton13.TabIndex = 290
        Me.SimpleButton13.Text = "تغيير المستخدم الان"
        '
        'fm_change_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 280)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton13)
        Me.Controls.Add(Me.tb_secret_word)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_change_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغيير المستخدم"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_secret_word As System.Windows.Forms.TextBox
End Class
