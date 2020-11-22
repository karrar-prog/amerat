<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_save_and
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_save_and))
        Me.ch_contract = New DevExpress.XtraEditors.CheckEdit()
        Me.ch_list = New DevExpress.XtraEditors.CheckEdit()
        Me.ch_map = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ch_contract.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ch_list.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ch_map.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ch_contract
        '
        Me.ch_contract.EditValue = True
        Me.ch_contract.Location = New System.Drawing.Point(279, 94)
        Me.ch_contract.Name = "ch_contract"
        Me.ch_contract.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_contract.Properties.Appearance.Options.UseFont = True
        Me.ch_contract.Properties.Caption = "العقد"
        Me.ch_contract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ch_contract.Size = New System.Drawing.Size(149, 30)
        Me.ch_contract.TabIndex = 0
        '
        'ch_list
        '
        Me.ch_list.EditValue = True
        Me.ch_list.Location = New System.Drawing.Point(279, 140)
        Me.ch_list.Name = "ch_list"
        Me.ch_list.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_list.Properties.Appearance.Options.UseFont = True
        Me.ch_list.Properties.Caption = "قائمة التسديدات"
        Me.ch_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ch_list.Size = New System.Drawing.Size(149, 30)
        Me.ch_list.TabIndex = 1
        '
        'ch_map
        '
        Me.ch_map.EditValue = True
        Me.ch_map.Location = New System.Drawing.Point(279, 192)
        Me.ch_map.Name = "ch_map"
        Me.ch_map.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_map.Properties.Appearance.Options.UseFont = True
        Me.ch_map.Properties.Caption = "الخارطة"
        Me.ch_map.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ch_map.Size = New System.Drawing.Size(149, 30)
        Me.ch_map.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(96, 103)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(155, 106)
        Me.SimpleButton2.TabIndex = 352
        Me.SimpleButton2.Text = "حفظ و طباعة"
        '
        'fm_save_and
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 353)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.ch_map)
        Me.Controls.Add(Me.ch_list)
        Me.Controls.Add(Me.ch_contract)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "fm_save_and"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "خيارات الحفظ"
        Me.TopMost = True
        CType(Me.ch_contract.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ch_list.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ch_map.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ch_contract As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ch_list As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ch_map As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
