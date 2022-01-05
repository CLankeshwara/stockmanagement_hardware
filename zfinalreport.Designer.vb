<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class zfinalreport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zfinalreport))
        Me.inventory_rBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.zdatasetreport = New WindowsApplication1.zdatasetreport()
        Me.ReportViewer12 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.inventory_rBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zdatasetreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inventory_rBindingSource
        '
        Me.inventory_rBindingSource.DataMember = "inventory_r"
        Me.inventory_rBindingSource.DataSource = Me.zdatasetreport
        '
        'zdatasetreport
        '
        Me.zdatasetreport.DataSetName = "zdatasetreport"
        Me.zdatasetreport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer12
        '
        Me.ReportViewer12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.inventory_rBindingSource
        Me.ReportViewer12.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer12.LocalReport.ReportEmbeddedResource = "WindowsApplication1.zreportinv.rdlc"
        Me.ReportViewer12.Location = New System.Drawing.Point(19, 65)
        Me.ReportViewer12.Name = "ReportViewer12"
        Me.ReportViewer12.Size = New System.Drawing.Size(1113, 503)
        Me.ReportViewer12.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(536, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 35)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'zfinalreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1144, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer12)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "zfinalreport"
        Me.Text = "Inventory Balance"
        CType(Me.inventory_rBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zdatasetreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer12 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inventory_rBindingSource As BindingSource
    Friend WithEvents zdatasetreport As zdatasetreport
    Friend WithEvents Button1 As Button
End Class
