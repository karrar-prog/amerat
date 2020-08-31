<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_delete_option
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_delete_option))
        Me.tb_item_id = New DevExpress.XtraEditors.TextEdit()
        Me.tb_item_price = New DevExpress.XtraEditors.TextEdit()
        Me.tb_item_name = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_sell_menu_id = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tb_item_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_item_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_item_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_sell_menu_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_item_id
        '
        Me.tb_item_id.EditValue = ""
        Me.tb_item_id.Location = New System.Drawing.Point(319, 93)
        Me.tb_item_id.Name = "tb_item_id"
        Me.tb_item_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_item_id.Properties.Appearance.Options.UseFont = True
        Me.tb_item_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_item_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_item_id.Properties.ReadOnly = True
        Me.tb_item_id.Size = New System.Drawing.Size(113, 30)
        Me.tb_item_id.TabIndex = 97
        '
        'tb_item_price
        '
        Me.tb_item_price.EditValue = ""
        Me.tb_item_price.Location = New System.Drawing.Point(319, 133)
        Me.tb_item_price.Name = "tb_item_price"
        Me.tb_item_price.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_item_price.Properties.Appearance.Options.UseFont = True
        Me.tb_item_price.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_item_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_item_price.Properties.ReadOnly = True
        Me.tb_item_price.Size = New System.Drawing.Size(113, 30)
        Me.tb_item_price.TabIndex = 93
        '
        'tb_item_name
        '
        Me.tb_item_name.EditValue = ""
        Me.tb_item_name.Location = New System.Drawing.Point(203, 173)
        Me.tb_item_name.Name = "tb_item_name"
        Me.tb_item_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_item_name.Properties.Appearance.Options.UseFont = True
        Me.tb_item_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_item_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_item_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tb_item_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_item_name.Size = New System.Drawing.Size(344, 30)
        Me.tb_item_name.TabIndex = 94
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(428, 279)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(217, 95)
        Me.SimpleButton1.TabIndex = 96
        Me.SimpleButton1.Text = "حذف المادة من القائمة"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(3, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(134, 47)
        Me.SimpleButton2.TabIndex = 113
        Me.SimpleButton2.Text = "الغاء العملية"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(122, 279)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(217, 95)
        Me.SimpleButton4.TabIndex = 119
        Me.SimpleButton4.Text = "اجعلها هدية"
        '
        'tb_sell_menu_id
        '
        Me.tb_sell_menu_id.Location = New System.Drawing.Point(203, 209)
        Me.tb_sell_menu_id.Name = "tb_sell_menu_id"
        Me.tb_sell_menu_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sell_menu_id.Properties.Appearance.Options.UseFont = True
        Me.tb_sell_menu_id.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_sell_menu_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_sell_menu_id.Properties.Mask.BeepOnError = True
        Me.tb_sell_menu_id.Properties.Mask.EditMask = "n0"
        Me.tb_sell_menu_id.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_sell_menu_id.Properties.ReadOnly = True
        Me.tb_sell_menu_id.Size = New System.Drawing.Size(344, 28)
        Me.tb_sell_menu_id.TabIndex = 120
        Me.tb_sell_menu_id.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(276, 209)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(207, 28)
        Me.SimpleButton3.TabIndex = 121
        Me.SimpleButton3.Text = "حفظ تعديلات الاسم"
        '
        'fm_delete_option
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 512)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.tb_sell_menu_id)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.tb_item_id)
        Me.Controls.Add(Me.tb_item_price)
        Me.Controls.Add(Me.tb_item_name)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "fm_delete_option"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مسح المادة"
        Me.TopMost = True
        CType(Me.tb_item_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_item_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_item_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_sell_menu_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_item_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_item_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_item_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_sell_menu_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
