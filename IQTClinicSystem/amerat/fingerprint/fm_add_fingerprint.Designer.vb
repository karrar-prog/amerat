<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_add_fingerprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_add_fingerprint))
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtAge = New DevExpress.XtraEditors.TextEdit()
        Me.label5 = New System.Windows.Forms.Label()
        Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnVerify = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRegister = New DevExpress.XtraEditors.SimpleButton()
        Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gvc = New DevExpress.XtraGrid.GridControl()
        Me.imgNO = New DevExpress.XtraEditors.PictureEdit()
        Me.imgOK = New DevExpress.XtraEditors.PictureEdit()
        Me.txtMemoHint = New System.Windows.Forms.TextBox()
        Me.txtIndex = New DevExpress.XtraEditors.TextEdit()
        Me.label2 = New System.Windows.Forms.Label()
        Me.picEdite1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtSerial = New DevExpress.XtraEditors.TextEdit()
        Me.txtCount = New DevExpress.XtraEditors.TextEdit()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnEndReg = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInitial = New DevExpress.XtraEditors.SimpleButton()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl2.SuspendLayout()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIndex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEdite1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(35, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(244, 20)
        Me.txtName.TabIndex = 12
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(35, 54)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(244, 20)
        Me.txtAge.TabIndex = 13
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(285, 31)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(36, 13)
        Me.label5.TabIndex = 14
        Me.label5.Text = "الاسم"
        '
        'panelControl2
        '
        Me.panelControl2.Controls.Add(Me.txtName)
        Me.panelControl2.Controls.Add(Me.txtAge)
        Me.panelControl2.Controls.Add(Me.label4)
        Me.panelControl2.Controls.Add(Me.label5)
        Me.panelControl2.Controls.Add(Me.btnVerify)
        Me.panelControl2.Controls.Add(Me.btnRegister)
        Me.panelControl2.Location = New System.Drawing.Point(190, 199)
        Me.panelControl2.Name = "panelControl2"
        Me.panelControl2.Size = New System.Drawing.Size(404, 122)
        Me.panelControl2.TabIndex = 29
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(285, 57)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(31, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "العمر"
        '
        'btnVerify
        '
        Me.btnVerify.Enabled = False
        Me.btnVerify.ImageOptions.Image = CType(resources.GetObject("btnVerify.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVerify.Location = New System.Drawing.Point(87, 80)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(93, 23)
        Me.btnVerify.TabIndex = 11
        Me.btnVerify.Text = "تحقق"
        '
        'btnRegister
        '
        Me.btnRegister.Enabled = False
        Me.btnRegister.ImageOptions.Image = CType(resources.GetObject("btnRegister.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRegister.Location = New System.Drawing.Point(186, 80)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(93, 23)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.Text = "تسجيل"
        '
        'gridColumn2
        '
        Me.gridColumn2.Caption = "العمر"
        Me.gridColumn2.FieldName = "Age"
        Me.gridColumn2.Name = "gridColumn2"
        Me.gridColumn2.Visible = True
        Me.gridColumn2.VisibleIndex = 1
        '
        'gridColumn1
        '
        Me.gridColumn1.Caption = "الاسم"
        Me.gridColumn1.FieldName = "Name"
        Me.gridColumn1.Name = "gridColumn1"
        Me.gridColumn1.Visible = True
        Me.gridColumn1.VisibleIndex = 0
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2})
        Me.gridView1.GridControl = Me.gvc
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ShowGroupPanel = False
        '
        'gvc
        '
        Me.gvc.Location = New System.Drawing.Point(190, 327)
        Me.gvc.MainView = Me.gridView1
        Me.gvc.Name = "gvc"
        Me.gvc.Size = New System.Drawing.Size(404, 291)
        Me.gvc.TabIndex = 28
        Me.gvc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'imgNO
        '
        Me.imgNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgNO.Location = New System.Drawing.Point(767, 278)
        Me.imgNO.Name = "imgNO"
        Me.imgNO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.imgNO.Properties.InitialImageOptions.Image = CType(resources.GetObject("imgNO.Properties.InitialImageOptions.Image"), System.Drawing.Image)
        Me.imgNO.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgNO.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgNO.Size = New System.Drawing.Size(46, 44)
        Me.imgNO.TabIndex = 27
        '
        'imgOK
        '
        Me.imgOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgOK.Location = New System.Drawing.Point(767, 278)
        Me.imgOK.Name = "imgOK"
        Me.imgOK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.imgOK.Properties.InitialImageOptions.Image = CType(resources.GetObject("imgOK.Properties.InitialImageOptions.Image"), System.Drawing.Image)
        Me.imgOK.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgOK.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgOK.Size = New System.Drawing.Size(46, 44)
        Me.imgOK.TabIndex = 26
        '
        'txtMemoHint
        '
        Me.txtMemoHint.ForeColor = System.Drawing.Color.Black
        Me.txtMemoHint.Location = New System.Drawing.Point(600, 327)
        Me.txtMemoHint.Multiline = True
        Me.txtMemoHint.Name = "txtMemoHint"
        Me.txtMemoHint.ReadOnly = True
        Me.txtMemoHint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemoHint.Size = New System.Drawing.Size(213, 291)
        Me.txtMemoHint.TabIndex = 25
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(35, 71)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Properties.ReadOnly = True
        Me.txtIndex.Size = New System.Drawing.Size(244, 20)
        Me.txtIndex.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(285, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(30, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "العدد"
        '
        'picEdite1
        '
        Me.picEdite1.Cursor = System.Windows.Forms.Cursors.Default
        Me.picEdite1.Location = New System.Drawing.Point(600, 61)
        Me.picEdite1.Name = "picEdite1"
        Me.picEdite1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.picEdite1.Properties.InitialImageOptions.Image = CType(resources.GetObject("picEdite1.Properties.InitialImageOptions.Image"), System.Drawing.Image)
        Me.picEdite1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picEdite1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picEdite1.Size = New System.Drawing.Size(213, 260)
        Me.picEdite1.TabIndex = 23
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(35, 11)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Properties.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(244, 20)
        Me.txtSerial.TabIndex = 2
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(35, 37)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Properties.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(244, 20)
        Me.txtCount.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(286, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "الفهرس"
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.btnEndReg)
        Me.panelControl1.Controls.Add(Me.txtSerial)
        Me.panelControl1.Controls.Add(Me.txtCount)
        Me.panelControl1.Controls.Add(Me.btnInitial)
        Me.panelControl1.Controls.Add(Me.label3)
        Me.panelControl1.Controls.Add(Me.txtIndex)
        Me.panelControl1.Controls.Add(Me.label2)
        Me.panelControl1.Controls.Add(Me.label1)
        Me.panelControl1.Location = New System.Drawing.Point(190, 61)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(404, 132)
        Me.panelControl1.TabIndex = 24
        '
        'btnEndReg
        '
        Me.btnEndReg.ImageOptions.Image = CType(resources.GetObject("btnEndReg.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEndReg.Location = New System.Drawing.Point(87, 97)
        Me.btnEndReg.Name = "btnEndReg"
        Me.btnEndReg.Size = New System.Drawing.Size(93, 23)
        Me.btnEndReg.TabIndex = 12
        Me.btnEndReg.Text = "انهاء"
        '
        'btnInitial
        '
        Me.btnInitial.ImageOptions.Image = CType(resources.GetObject("btnInitial.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInitial.Location = New System.Drawing.Point(186, 97)
        Me.btnInitial.Name = "btnInitial"
        Me.btnInitial.Size = New System.Drawing.Size(93, 23)
        Me.btnInitial.TabIndex = 8
        Me.btnInitial.Text = "ربط الماسح"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(285, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "الرقم التسلسلي"
        '
        'fm_add_fingerprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 678)
        Me.Controls.Add(Me.panelControl2)
        Me.Controls.Add(Me.gvc)
        Me.Controls.Add(Me.imgNO)
        Me.Controls.Add(Me.imgOK)
        Me.Controls.Add(Me.txtMemoHint)
        Me.Controls.Add(Me.picEdite1)
        Me.Controls.Add(Me.panelControl1)
        Me.Name = "fm_add_fingerprint"
        Me.Text = "fm_add_fingerprint"
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl2.ResumeLayout(False)
        Me.panelControl2.PerformLayout()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIndex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEdite1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtAge As DevExpress.XtraEditors.TextEdit
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents panelControl2 As DevExpress.XtraEditors.PanelControl
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents btnVerify As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnRegister As DevExpress.XtraEditors.SimpleButton
    Private WithEvents gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gvc As DevExpress.XtraGrid.GridControl
    Private WithEvents imgNO As DevExpress.XtraEditors.PictureEdit
    Private WithEvents imgOK As DevExpress.XtraEditors.PictureEdit
    Private WithEvents txtMemoHint As System.Windows.Forms.TextBox
    Private WithEvents txtIndex As DevExpress.XtraEditors.TextEdit
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents picEdite1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents txtSerial As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtCount As DevExpress.XtraEditors.TextEdit
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents btnEndReg As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnInitial As DevExpress.XtraEditors.SimpleButton
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
