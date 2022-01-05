<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deletesupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deletesupplier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comsupcontactnumber = New System.Windows.Forms.ComboBox()
        Me.btndeletesupplier = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(41, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Supplier Name"
        '
        'comsupcontactnumber
        '
        Me.comsupcontactnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comsupcontactnumber.FormattingEnabled = True
        Me.comsupcontactnumber.Location = New System.Drawing.Point(280, 101)
        Me.comsupcontactnumber.Name = "comsupcontactnumber"
        Me.comsupcontactnumber.Size = New System.Drawing.Size(244, 26)
        Me.comsupcontactnumber.TabIndex = 1
        '
        'btndeletesupplier
        '
        Me.btndeletesupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndeletesupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndeletesupplier.Location = New System.Drawing.Point(280, 141)
        Me.btndeletesupplier.Name = "btndeletesupplier"
        Me.btndeletesupplier.Size = New System.Drawing.Size(106, 37)
        Me.btndeletesupplier.TabIndex = 2
        Me.btndeletesupplier.Text = "Delete"
        Me.btndeletesupplier.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(61, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 36)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(12, 27)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 36)
        Me.btnback.TabIndex = 20
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Delete Supplier"
        '
        'deletesupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(536, 196)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndeletesupplier)
        Me.Controls.Add(Me.comsupcontactnumber)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "deletesupplier"
        Me.Text = "Delete Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents comsupcontactnumber As ComboBox
    Friend WithEvents btndeletesupplier As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Label2 As Label
End Class
