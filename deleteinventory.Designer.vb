<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteinventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteinventory))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndeletecustomer = New System.Windows.Forms.Button()
        Me.combodeleteinventory = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(104, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Select Inventory Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 32)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Delete Inventory"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(73, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 36)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(24, 34)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 36)
        Me.btnback.TabIndex = 24
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndeletecustomer
        '
        Me.btndeletecustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndeletecustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletecustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndeletecustomer.Location = New System.Drawing.Point(365, 138)
        Me.btndeletecustomer.Name = "btndeletecustomer"
        Me.btndeletecustomer.Size = New System.Drawing.Size(117, 39)
        Me.btndeletecustomer.TabIndex = 23
        Me.btndeletecustomer.Text = "Delete"
        Me.btndeletecustomer.UseVisualStyleBackColor = False
        '
        'combodeleteinventory
        '
        Me.combodeleteinventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combodeleteinventory.FormattingEnabled = True
        Me.combodeleteinventory.Location = New System.Drawing.Point(346, 100)
        Me.combodeleteinventory.Name = "combodeleteinventory"
        Me.combodeleteinventory.Size = New System.Drawing.Size(257, 28)
        Me.combodeleteinventory.TabIndex = 22
        '
        'deleteinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(646, 214)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndeletecustomer)
        Me.Controls.Add(Me.combodeleteinventory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "deleteinventory"
        Me.Text = "Delete Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btndeletecustomer As Button
    Friend WithEvents combodeleteinventory As ComboBox
End Class
