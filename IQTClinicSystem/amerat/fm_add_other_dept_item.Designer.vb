<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_other_dept_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_add_other_dept_item))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_dose_to_patient = New DevExpress.XtraEditors.TextEdit()
        Me.tb_note = New DevExpress.XtraEditors.TextEdit()
        Me.tb_treatment_name = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tb_dose_to_patient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_treatment_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 35)
        Me.SimpleButton1.TabIndex = 356
        Me.SimpleButton1.Text = "الغاء العملية"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(201, 282)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(94, 36)
        Me.SimpleButton2.TabIndex = 355
        Me.SimpleButton2.Text = "تم"
        '
        'tb_dose_to_patient
        '
        Me.tb_dose_to_patient.EditValue = "0"
        Me.tb_dose_to_patient.Location = New System.Drawing.Point(122, 161)
        Me.tb_dose_to_patient.Name = "tb_dose_to_patient"
        Me.tb_dose_to_patient.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_dose_to_patient.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dose_to_patient.Properties.Appearance.Options.UseBackColor = True
        Me.tb_dose_to_patient.Properties.Appearance.Options.UseFont = True
        Me.tb_dose_to_patient.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_dose_to_patient.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_dose_to_patient.Properties.Mask.EditMask = "n0"
        Me.tb_dose_to_patient.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_dose_to_patient.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_dose_to_patient.Size = New System.Drawing.Size(277, 28)
        Me.tb_dose_to_patient.TabIndex = 357
        '
        'tb_note
        '
        Me.tb_note.EditValue = ""
        Me.tb_note.Location = New System.Drawing.Point(122, 214)
        Me.tb_note.Name = "tb_note"
        Me.tb_note.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tb_note.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_note.Properties.Appearance.Options.UseBackColor = True
        Me.tb_note.Properties.Appearance.Options.UseFont = True
        Me.tb_note.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_note.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_note.Properties.NullText = "ملاحظات"
        Me.tb_note.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_note.Size = New System.Drawing.Size(277, 28)
        Me.tb_note.TabIndex = 358
        '
        'tb_treatment_name
        '
        Me.tb_treatment_name.EditValue = ""
        Me.tb_treatment_name.Location = New System.Drawing.Point(122, 113)
        Me.tb_treatment_name.Name = "tb_treatment_name"
        Me.tb_treatment_name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tb_treatment_name.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_treatment_name.Properties.Appearance.Options.UseBackColor = True
        Me.tb_treatment_name.Properties.Appearance.Options.UseFont = True
        Me.tb_treatment_name.Properties.Appearance.Options.UseTextOptions = True
        Me.tb_treatment_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tb_treatment_name.Properties.NullText = "ألعنوان"
        Me.tb_treatment_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_treatment_name.Size = New System.Drawing.Size(277, 28)
        Me.tb_treatment_name.TabIndex = 359
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(74, 211)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(42, 30)
        Me.SimpleButton3.TabIndex = 361
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(74, 158)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(42, 30)
        Me.SimpleButton4.TabIndex = 360
        '
        'fm_add_other_dept_item
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 351)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.tb_treatment_name)
        Me.Controls.Add(Me.tb_note)
        Me.Controls.Add(Me.tb_dose_to_patient)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fm_add_other_dept_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضاقة استحقاق جديد"
        Me.TopMost = True
        CType(Me.tb_dose_to_patient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_treatment_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_dose_to_patient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tb_treatment_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
