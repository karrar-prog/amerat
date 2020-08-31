<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_wait
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
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ProgressPanel2 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.tb_number_ready = New System.Windows.Forms.TextBox()
        Me.tb_name_ready = New System.Windows.Forms.TextBox()
        Me.tb_number_enterd = New System.Windows.Forms.TextBox()
        Me.tb_name_entered = New System.Windows.Forms.TextBox()
        Me.lv_queue = New System.Windows.Forms.ListView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.Appearance.Options.UseFont = True
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Caption = "يرجى حضور "
        Me.ProgressPanel1.Description = ""
        Me.ProgressPanel1.Location = New System.Drawing.Point(144, 23)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressPanel1.Size = New System.Drawing.Size(198, 78)
        Me.ProgressPanel1.TabIndex = 0
        Me.ProgressPanel1.Text = "يرجى "
        Me.ProgressPanel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم الحجز"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.tb_number_enterd)
        Me.GroupControl1.Controls.Add(Me.ProgressPanel1)
        Me.GroupControl1.Controls.Add(Me.tb_name_entered)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(613, 30)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(716, 631)
        Me.GroupControl1.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ProgressPanel2)
        Me.GroupControl2.Controls.Add(Me.tb_number_ready)
        Me.GroupControl2.Controls.Add(Me.tb_name_ready)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 22)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl2.Size = New System.Drawing.Size(712, 607)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "التالي"
        '
        'ProgressPanel2
        '
        Me.ProgressPanel2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel2.Appearance.Font = New System.Drawing.Font("Times New Roman", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel2.Appearance.Options.UseBackColor = True
        Me.ProgressPanel2.Appearance.Options.UseFont = True
        Me.ProgressPanel2.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel2.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel2.BarAnimationElementThickness = 2
        Me.ProgressPanel2.Caption = "التالي"
        Me.ProgressPanel2.Description = ""
        Me.ProgressPanel2.Location = New System.Drawing.Point(367, 48)
        Me.ProgressPanel2.Name = "ProgressPanel2"
        Me.ProgressPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressPanel2.Size = New System.Drawing.Size(318, 128)
        Me.ProgressPanel2.TabIndex = 5
        Me.ProgressPanel2.Text = "يرجى "
        '
        'tb_number_ready
        '
        Me.tb_number_ready.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_number_ready.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_number_ready.Location = New System.Drawing.Point(47, 378)
        Me.tb_number_ready.Name = "tb_number_ready"
        Me.tb_number_ready.ReadOnly = True
        Me.tb_number_ready.Size = New System.Drawing.Size(640, 111)
        Me.tb_number_ready.TabIndex = 4
        Me.tb_number_ready.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_name_ready
        '
        Me.tb_name_ready.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_name_ready.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name_ready.Location = New System.Drawing.Point(45, 206)
        Me.tb_name_ready.Name = "tb_name_ready"
        Me.tb_name_ready.ReadOnly = True
        Me.tb_name_ready.Size = New System.Drawing.Size(640, 111)
        Me.tb_name_ready.TabIndex = 3
        Me.tb_name_ready.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_number_enterd
        '
        Me.tb_number_enterd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_number_enterd.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_number_enterd.Location = New System.Drawing.Point(33, 189)
        Me.tb_number_enterd.Name = "tb_number_enterd"
        Me.tb_number_enterd.ReadOnly = True
        Me.tb_number_enterd.Size = New System.Drawing.Size(386, 56)
        Me.tb_number_enterd.TabIndex = 2
        Me.tb_number_enterd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_number_enterd.Visible = False
        '
        'tb_name_entered
        '
        Me.tb_name_entered.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_name_entered.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name_entered.Location = New System.Drawing.Point(33, 106)
        Me.tb_name_entered.Name = "tb_name_entered"
        Me.tb_name_entered.ReadOnly = True
        Me.tb_name_entered.Size = New System.Drawing.Size(386, 56)
        Me.tb_name_entered.TabIndex = 1
        Me.tb_name_entered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_name_entered.Visible = False
        '
        'lv_queue
        '
        Me.lv_queue.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_queue.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_queue.FullRowSelect = True
        Me.lv_queue.GridLines = True
        Me.lv_queue.Location = New System.Drawing.Point(0, 30)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lv_queue.RightToLeftLayout = True
        Me.lv_queue.Size = New System.Drawing.Size(613, 608)
        Me.lv_queue.TabIndex = 5
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem4})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 3
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1329, 30)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "الشاشة الاولى"
        Me.BarButtonItem4.Id = 2
        Me.BarButtonItem4.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.system_settings_icon2
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 638)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(613, 23)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "الى الشاشة الثانية"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.system_settings_icon1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "الى الشاشة الثانية"
        Me.BarButtonItem3.Id = 1
        Me.BarButtonItem3.ImageOptions.Image = Global.IQTClinicSystem.My.Resources.Resources.system_settings_icon1
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'fm_wait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 661)
        Me.Controls.Add(Me.lv_queue)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "fm_wait"
        Me.Ribbon = Me.RibbonControl1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "غرفة الانتظار"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_number_enterd As System.Windows.Forms.TextBox
    Friend WithEvents tb_name_entered As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tb_number_ready As System.Windows.Forms.TextBox
    Friend WithEvents tb_name_ready As System.Windows.Forms.TextBox
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressPanel2 As DevExpress.XtraWaitForm.ProgressPanel
End Class
