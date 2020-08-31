<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_bookto
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.tb20 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb21 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tb_id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(651, 54)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 602)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(651, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'tb20
        '
        Me.tb20.Location = New System.Drawing.Point(98, 231)
        Me.tb20.Name = "tb20"
        Me.tb20.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb20.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb20.Properties.Appearance.Options.UseFont = True
        Me.tb20.Properties.NullValuePrompt = "الاسم"
        Me.tb20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb20.Size = New System.Drawing.Size(437, 34)
        Me.tb20.TabIndex = 214
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 27)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "/  الى "
        '
        'tb21
        '
        Me.tb21.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb21.FormattingEnabled = True
        Me.tb21.Location = New System.Drawing.Point(218, 308)
        Me.tb21.Name = "tb21"
        Me.tb21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb21.Size = New System.Drawing.Size(197, 35)
        Me.tb21.TabIndex = 216
        Me.tb21.Text = "العام"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "تحت التخدير"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(276, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 358
        Me.Label14.Text = "تقرير طبي"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.IQTClinicSystem.My.Resources.Resources.pdf_icon
        Me.PictureBox4.Location = New System.Drawing.Point(276, 407)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 357
        Me.PictureBox4.TabStop = False
        '
        'tb_id
        '
        Me.tb_id.Location = New System.Drawing.Point(225, 152)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_id.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.Properties.Appearance.Options.UseFont = True
        Me.tb_id.Properties.NullValuePrompt = "الاسم"
        Me.tb_id.Properties.ReadOnly = True
        Me.tb_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_id.Size = New System.Drawing.Size(182, 34)
        Me.tb_id.TabIndex = 359
        '
        'fm_bookto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 625)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb20)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "fm_bookto"
        Me.Ribbon = Me.RibbonControl1
        Me.ShowIcon = False
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "تقرير طبي الى"
        Me.TopMost = True
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tb20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb21 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_id As DevExpress.XtraEditors.TextEdit
End Class
