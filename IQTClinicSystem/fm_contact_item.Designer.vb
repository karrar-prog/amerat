<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_contact_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_contact_item))
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        Me.item4 = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_id
        '
        Me.tb_id.EnterMoveNextControl = True
        Me.tb_id.Location = New System.Drawing.Point(459, 3)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.NullValuePrompt = "الاسم"
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(70, 28)
        Me.tb_id.TabIndex = 398
        Me.tb_id.Visible = False
        '
        'item4
        '
        Me.item4.BackColor = System.Drawing.Color.White
        Me.item4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.item4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item4.Location = New System.Drawing.Point(0, 0)
        Me.item4.Multiline = True
        Me.item4.Name = "item4"
        Me.item4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.item4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.item4.Size = New System.Drawing.Size(1001, 705)
        Me.item4.TabIndex = 399
        Me.item4.Text = "فقرات العقد"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(459, 656)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(88, 44)
        Me.SimpleButton2.TabIndex = 400
        Me.SimpleButton2.Text = "حــفــظ"
        '
        'fm_contact_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 705)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.item4)
        Me.Name = "fm_contact_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عناصر العقد"
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents item4 As System.Windows.Forms.TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
