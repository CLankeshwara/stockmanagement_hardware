<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class new_createinventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_createinventory))
        Me.com_sup_contact = New System.Windows.Forms.ComboBox()
        Me.btncustomerchek = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.txtinventoryname = New System.Windows.Forms.TextBox()
        Me.txtinventoryid = New System.Windows.Forms.TextBox()
        Me.cominventorytype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'com_sup_contact
        '
        Me.com_sup_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_sup_contact.FormattingEnabled = True
        Me.com_sup_contact.Location = New System.Drawing.Point(286, 94)
        Me.com_sup_contact.Name = "com_sup_contact"
        Me.com_sup_contact.Size = New System.Drawing.Size(238, 28)
        Me.com_sup_contact.TabIndex = 42
        '
        'btncustomerchek
        '
        Me.btncustomerchek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomerchek.Location = New System.Drawing.Point(286, 130)
        Me.btncustomerchek.Name = "btncustomerchek"
        Me.btncustomerchek.Size = New System.Drawing.Size(83, 32)
        Me.btncustomerchek.TabIndex = 41
        Me.btncustomerchek.Text = "Chek"
        Me.btncustomerchek.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(90, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 36)
        Me.Button2.TabIndex = 36
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(228, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 60)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Create Inventory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.txtinventoryname)
        Me.GroupBox1.Controls.Add(Me.txtinventoryid)
        Me.GroupBox1.Controls.Add(Me.cominventorytype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(90, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 168)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory information"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(240, 132)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(295, 26)
        Me.txtlocation.TabIndex = 29
        '
        'txtinventoryname
        '
        Me.txtinventoryname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventoryname.Location = New System.Drawing.Point(239, 100)
        Me.txtinventoryname.Name = "txtinventoryname"
        Me.txtinventoryname.Size = New System.Drawing.Size(296, 26)
        Me.txtinventoryname.TabIndex = 25
        '
        'txtinventoryid
        '
        Me.txtinventoryid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventoryid.Location = New System.Drawing.Point(239, 68)
        Me.txtinventoryid.Name = "txtinventoryid"
        Me.txtinventoryid.ReadOnly = True
        Me.txtinventoryid.Size = New System.Drawing.Size(296, 26)
        Me.txtinventoryid.TabIndex = 24
        '
        'cominventorytype
        '
        Me.cominventorytype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cominventorytype.FormattingEnabled = True
        Me.cominventorytype.Location = New System.Drawing.Point(239, 32)
        Me.cominventorytype.Name = "cominventorytype"
        Me.cominventorytype.Size = New System.Drawing.Size(296, 28)
        Me.cominventorytype.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(28, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Inventory type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inventory Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Inventory ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 33)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Create inventory"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(117, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Supplier ID"
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomerid.Location = New System.Drawing.Point(286, 168)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.ReadOnly = True
        Me.txtcustomerid.Size = New System.Drawing.Size(238, 26)
        Me.txtcustomerid.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(118, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 20)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Supplier Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(530, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(247, 145)
        Me.DataGridView1.TabIndex = 43
        '
        'new_createinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(778, 461)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.com_sup_contact)
        Me.Controls.Add(Me.btncustomerchek)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.Label11)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "new_createinventory"
        Me.Text = "Create Invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents com_sup_contact As ComboBox
    Friend WithEvents btncustomerchek As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents txtinventoryname As TextBox
    Friend WithEvents txtinventoryid As TextBox
    Friend WithEvents cominventorytype As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcustomerid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
