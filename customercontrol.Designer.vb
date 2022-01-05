<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customercontrol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customercontrol))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.btndeletecustomer = New System.Windows.Forms.Button()
        Me.btnupdatecustomer = New System.Windows.Forms.Button()
        Me.btnnewcustomer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(736, 317)
        Me.DataGridView1.TabIndex = 11
        '
        'txtboxsearch
        '
        Me.txtboxsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxsearch.Location = New System.Drawing.Point(279, 30)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(488, 35)
        Me.txtboxsearch.TabIndex = 9
        '
        'btndeletecustomer
        '
        Me.btndeletecustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndeletecustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletecustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndeletecustomer.Image = CType(resources.GetObject("btndeletecustomer.Image"), System.Drawing.Image)
        Me.btndeletecustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeletecustomer.Location = New System.Drawing.Point(547, 418)
        Me.btndeletecustomer.Name = "btndeletecustomer"
        Me.btndeletecustomer.Size = New System.Drawing.Size(220, 83)
        Me.btndeletecustomer.TabIndex = 8
        Me.btndeletecustomer.Text = "Delete Customer"
        Me.btndeletecustomer.UseVisualStyleBackColor = False
        '
        'btnupdatecustomer
        '
        Me.btnupdatecustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdatecustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatecustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdatecustomer.Image = CType(resources.GetObject("btnupdatecustomer.Image"), System.Drawing.Image)
        Me.btnupdatecustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdatecustomer.Location = New System.Drawing.Point(288, 418)
        Me.btnupdatecustomer.Name = "btnupdatecustomer"
        Me.btnupdatecustomer.Size = New System.Drawing.Size(220, 83)
        Me.btnupdatecustomer.TabIndex = 7
        Me.btnupdatecustomer.Text = "Update Customer"
        Me.btnupdatecustomer.UseVisualStyleBackColor = False
        '
        'btnnewcustomer
        '
        Me.btnnewcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnnewcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewcustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnewcustomer.Image = CType(resources.GetObject("btnnewcustomer.Image"), System.Drawing.Image)
        Me.btnnewcustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewcustomer.Location = New System.Drawing.Point(31, 418)
        Me.btnnewcustomer.Name = "btnnewcustomer"
        Me.btnnewcustomer.Size = New System.Drawing.Size(220, 83)
        Me.btnnewcustomer.TabIndex = 6
        Me.btnnewcustomer.Text = "New Customer"
        Me.btnnewcustomer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(31, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'customercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.btndeletecustomer)
        Me.Controls.Add(Me.btnupdatecustomer)
        Me.Controls.Add(Me.btnnewcustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customercontrol"
        Me.Text = "Customer control"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents btndeletecustomer As Button
    Friend WithEvents btnupdatecustomer As Button
    Friend WithEvents btnnewcustomer As Button
    Friend WithEvents Button1 As Button
End Class
