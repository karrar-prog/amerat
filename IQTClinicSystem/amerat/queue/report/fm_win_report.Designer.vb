<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_win_report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DsqueueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_queue = New IQTClinicSystem.ds_queue()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TqueueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DsqueueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_queue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TqueueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsqueueBindingSource
        '
        Me.DsqueueBindingSource.DataSource = Me.Ds_queue
        Me.DsqueueBindingSource.Position = 0
        '
        'Ds_queue
        '
        Me.Ds_queue.DataSetName = "ds_queue"
        Me.Ds_queue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TqueueBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IQTClinicSystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(567, 334)
        Me.ReportViewer1.TabIndex = 0
        '
        'TqueueBindingSource
        '
        Me.TqueueBindingSource.DataMember = "t_queue"
        Me.TqueueBindingSource.DataSource = Me.DsqueueBindingSource
        '
        'fm_win_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 347)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "fm_win_report"
        Me.Text = "fm_win_report"
        CType(Me.DsqueueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_queue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TqueueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Ds_queue As IQTClinicSystem.ds_queue
    Friend WithEvents DsqueueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TqueueBindingSource As System.Windows.Forms.BindingSource
End Class
