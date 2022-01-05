<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supplier_control))
        Me.btnnewsupplier = New System.Windows.Forms.Button()
        Me.btnupdatesupplier = New System.Windows.Forms.Button()
        Me.btndeletesupplier = New System.Windows.Forms.Button()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnewsupplier
        '
        Me.btnnewsupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnnewsupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewsupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnewsupplier.Image = CType(resources.GetObject("btnnewsupplier.Image"), System.Drawing.Image)
        Me.btnnewsupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewsupplier.Location = New System.Drawing.Point(10, 363)
        Me.btnnewsupplier.Name = "btnnewsupplier"
        Me.btnnewsupplier.Size = New System.Drawing.Size(220, 84)
        Me.btnnewsupplier.TabIndex = 0
        Me.btnnewsupplier.Text = "New Supplier"
        Me.btnnewsupplier.UseVisualStyleBackColor = False
        '
        'btnupdatesupplier
        '
        Me.btnupdatesupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdatesupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatesupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdatesupplier.Image = CType(resources.GetObject("btnupdatesupplier.Image"), System.Drawing.Image)
        Me.btnupdatesupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdatesupplier.Location = New System.Drawing.Point(256, 364)
        Me.btnupdatesupplier.Name = "btnupdatesupplier"
        Me.btnupdatesupplier.Size = New System.Drawing.Size(220, 84)
        Me.btnupdatesupplier.TabIndex = 1
        Me.btnupdatesupplier.Text = "Update Supplier"
        Me.btnupdatesupplier.UseVisualStyleBackColor = False
        '
        'btndeletesupplier
        '
        Me.btndeletesupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndeletesupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletesupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndeletesupplier.Image = CType(resources.GetObject("btndeletesupplier.Image"), System.Drawing.Image)
        Me.btndeletesupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeletesupplier.Location = New System.Drawing.Point(512, 364)
        Me.btndeletesupplier.Name = "btndeletesupplier"
        Me.btndeletesupplier.Size = New System.Drawing.Size(220, 84)
        Me.btndeletesupplier.TabIndex = 2
        Me.btndeletesupplier.Text = "Delete Supplier"
        Me.btndeletesupplier.UseVisualStyleBackColor = False
        '
        'txtboxsearch
        '
        Me.txtboxsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxsearch.Location = New System.Drawing.Point(271, 30)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(461, 35)
        Me.txtboxsearch.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(720, 259)
        Me.DataGridView1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 36)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'supplier_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(744, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.btndeletesupplier)
        Me.Controls.Add(Me.btnupdatesupplier)
        Me.Controls.Add(Me.btnnewsupplier)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "supplier_control"
        Me.Text = "Supplier Control"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnewsupplier As Button
    Friend WithEvents btnupdatesupplier As Button
    Friend WithEvents btndeletesupplier As Button
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
