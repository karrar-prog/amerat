<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_message
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
        Me.components = New System.ComponentModel.Container()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.TabFormContentContainer1 = New DevExpress.XtraBars.TabFormContentContainer()
        Me.TabFormPage1 = New DevExpress.XtraBars.TabFormPage()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(63, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 32)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "تمت العملية"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IQTClinicSystem.My.Resources.Resources.Downloads_icon1
        Me.PictureBox2.Location = New System.Drawing.Point(206, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 314
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.Pages.Add(Me.TabFormPage1)
        Me.TabFormControl1.SelectedPage = Me.TabFormPage1
        Me.TabFormControl1.Size = New System.Drawing.Size(328, 24)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 315
        Me.TabFormControl1.TabStop = False
        '
        'TabFormContentContainer1
        '
        Me.TabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFormContentContainer1.Location = New System.Drawing.Point(0, 24)
        Me.TabFormContentContainer1.Name = "TabFormContentContainer1"
        Me.TabFormContentContainer1.Size = New System.Drawing.Size(328, 130)
        Me.TabFormContentContainer1.TabIndex = 316
        '
        'TabFormPage1
        '
        Me.TabFormPage1.ContentContainer = Me.TabFormContentContainer1
        Me.TabFormPage1.Name = "TabFormPage1"
        Me.TabFormPage1.Text = "Page 0"
        '
        'fm_message
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(328, 154)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TabFormContentContainer1)
        Me.Controls.Add(Me.TabFormControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fm_message"
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "fm_message"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
    Friend WithEvents TabFormPage1 As DevExpress.XtraBars.TabFormPage
    Friend WithEvents TabFormContentContainer1 As DevExpress.XtraBars.TabFormContentContainer
End Class
