﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_login))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.جديد = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.t_count = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.customersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.employeesBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barSubItemNavigation = New DevExpress.XtraBars.BarSubItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.DefaultLookAndFeel2 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tb_secret_word = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_secret_word.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'جديد
        '
        Me.جديد.Id = 52
        Me.جديد.Name = "جديد"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 51
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 50
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Caption = "BarHeaderItem2"
        Me.BarHeaderItem2.Id = 49
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 48
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        't_count
        '
        Me.t_count.Caption = "0"
        Me.t_count.Id = 47
        Me.t_count.ImageOptions.Image = CType(resources.GetObject("t_count.ImageOptions.Image"), System.Drawing.Image)
        Me.t_count.Name = "t_count"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 46
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'customersBarButtonItem
        '
        Me.customersBarButtonItem.Caption = "Customers"
        Me.customersBarButtonItem.Id = 45
        Me.customersBarButtonItem.Name = "customersBarButtonItem"
        '
        'employeesBarButtonItem
        '
        Me.employeesBarButtonItem.Caption = "Employees"
        Me.employeesBarButtonItem.Id = 44
        Me.employeesBarButtonItem.Name = "employeesBarButtonItem"
        '
        'barSubItemNavigation
        '
        Me.barSubItemNavigation.Caption = "المظهر"
        Me.barSubItemNavigation.Id = 15
        Me.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar"
        Me.barSubItemNavigation.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.employeesBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.customersBarButtonItem)})
        Me.barSubItemNavigation.Name = "barSubItemNavigation"
        '
        'ribbonControl
        '
        Me.ribbonControl.BackColor = System.Drawing.Color.Green
        Me.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.ForeColor = System.Drawing.Color.Red
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem, Me.barSubItemNavigation, Me.employeesBarButtonItem, Me.customersBarButtonItem, Me.BarButtonItem1, Me.t_count, Me.BarHeaderItem1, Me.BarHeaderItem2, Me.BarStaticItem1, Me.BarButtonItem2, Me.جديد})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ribbonControl.MaxItemId = 53
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.ShowQatLocationSelector = False
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(544, 27)
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Visible = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage2"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.IQTClinicSystem.My.Resources.Resources.amerat_icon
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.PictureBox4.Image = Global.IQTClinicSystem.My.Resources.Resources.amerat_icon
        Me.PictureBox4.Location = New System.Drawing.Point(343, 165)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 272
        Me.PictureBox4.TabStop = False
        '
        'tb_secret_word
        '
        Me.tb_secret_word.Location = New System.Drawing.Point(174, 168)
        Me.tb_secret_word.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tb_secret_word.Name = "tb_secret_word"
        Me.tb_secret_word.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tb_secret_word.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_secret_word.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_secret_word.Properties.Appearance.Options.UseBackColor = True
        Me.tb_secret_word.Properties.Appearance.Options.UseFont = True
        Me.tb_secret_word.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tb_secret_word.Properties.Mask.EditMask = "d"
        Me.tb_secret_word.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tb_secret_word.Properties.NullValuePrompt = "ادخل كلمة المرور"
        Me.tb_secret_word.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_secret_word.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_secret_word.Size = New System.Drawing.Size(183, 36)
        Me.tb_secret_word.TabIndex = 273
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(461, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "Version 5.1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(6, 28)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 36)
        Me.SimpleButton1.TabIndex = 278
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(574, 32)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 38)
        Me.SimpleButton2.TabIndex = 280
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(228, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(90, 14)
        Me.Label1.TabIndex = 286
        Me.Label1.Text = "Copy Right  2021"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(200, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(147, 14)
        Me.Label3.TabIndex = 287
        Me.Label3.Text = "Prog.Karrar , Eng.Mohammed"
        '
        'fm_login
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center
        Me.BackgroundImageStore = Global.IQTClinicSystem.My.Resources.Resources.BACK2
        Me.ClientSize = New System.Drawing.Size(544, 367)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_secret_word)
        Me.Controls.Add(Me.ribbonControl)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "fm_login"
        Me.Ribbon = Me.ribbonControl
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "اهلا بك في مجمع الاميرات"
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_secret_word.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents جديد As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents t_count As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents customersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents employeesBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barSubItemNavigation As DevExpress.XtraBars.BarSubItem
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents DefaultLookAndFeel2 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_secret_word As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
