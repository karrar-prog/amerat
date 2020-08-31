<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_customer_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_customer_search))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_search = New DevExpress.XtraEditors.TextEdit()
        Me.li_customer = New System.Windows.Forms.ListView()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(7, 7)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(115, 34)
        Me.SimpleButton2.TabIndex = 114
        Me.SimpleButton2.Text = "غلق الواجهه"
        '
        'tb_search
        '
        Me.tb_search.EditValue = ""
        Me.tb_search.Location = New System.Drawing.Point(126, 55)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Properties.Appearance.Options.UseFont = True
        Me.tb_search.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_search.Properties.Mask.EditMask = "d"
        Me.tb_search.Size = New System.Drawing.Size(254, 30)
        Me.tb_search.TabIndex = 115
        '
        'li_customer
        '
        Me.li_customer.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.li_customer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li_customer.FullRowSelect = True
        Me.li_customer.GridLines = True
        Me.li_customer.HotTracking = True
        Me.li_customer.HoverSelection = True
        Me.li_customer.Location = New System.Drawing.Point(12, 91)
        Me.li_customer.MultiSelect = False
        Me.li_customer.Name = "li_customer"
        Me.li_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.li_customer.RightToLeftLayout = True
        Me.li_customer.Size = New System.Drawing.Size(491, 552)
        Me.li_customer.TabIndex = 116
        Me.li_customer.UseCompatibleStateImageBehavior = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(386, 61)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl15.TabIndex = 118
        Me.LabelControl15.Text = "بواسطة الاسم"
        '
        'fm_customer_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 655)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.li_customer)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fm_customer_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "بحث عن زبون"
        Me.TopMost = True
        CType(Me.tb_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents li_customer As System.Windows.Forms.ListView
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
End Class
