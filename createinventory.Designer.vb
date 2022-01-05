<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createinventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createinventory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtopenning = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.txtsellingprice = New System.Windows.Forms.TextBox()
        Me.txtinventoryname = New System.Windows.Forms.TextBox()
        Me.txtinventoryid = New System.Windows.Forms.TextBox()
        Me.cominventorytype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.com_sup_contact = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Create inventory"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtopenning)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtdes)
        Me.GroupBox1.Controls.Add(Me.txtsellingprice)
        Me.GroupBox1.Controls.Add(Me.txtinventoryname)
        Me.GroupBox1.Controls.Add(Me.txtinventoryid)
        Me.GroupBox1.Controls.Add(Me.cominventorytype)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 275)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory information"
        '
        'txtopenning
        '
        Me.txtopenning.Location = New System.Drawing.Point(194, 224)
        Me.txtopenning.Name = "txtopenning"
        Me.txtopenning.Size = New System.Drawing.Size(112, 20)
        Me.txtopenning.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Openning Balance"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(195, 198)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(296, 20)
        Me.txtdes.TabIndex = 32
        '
        'txtsellingprice
        '
        Me.txtsellingprice.Location = New System.Drawing.Point(195, 121)
        Me.txtsellingprice.Name = "txtsellingprice"
        Me.txtsellingprice.Size = New System.Drawing.Size(112, 20)
        Me.txtsellingprice.TabIndex = 29
        '
        'txtinventoryname
        '
        Me.txtinventoryname.Location = New System.Drawing.Point(195, 94)
        Me.txtinventoryname.Name = "txtinventoryname"
        Me.txtinventoryname.Size = New System.Drawing.Size(296, 20)
        Me.txtinventoryname.TabIndex = 25
        '
        'txtinventoryid
        '
        Me.txtinventoryid.Location = New System.Drawing.Point(195, 68)
        Me.txtinventoryid.Name = "txtinventoryid"
        Me.txtinventoryid.Size = New System.Drawing.Size(131, 20)
        Me.txtinventoryid.TabIndex = 24
        '
        'cominventorytype
        '
        Me.cominventorytype.FormattingEnabled = True
        Me.cominventorytype.Location = New System.Drawing.Point(195, 40)
        Me.cominventorytype.Name = "cominventorytype"
        Me.cominventorytype.Size = New System.Drawing.Size(222, 21)
        Me.cominventorytype.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Inventory type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inventory Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Inventory ID"
        '
        'txtcustomername
        '
        Me.txtcustomername.Location = New System.Drawing.Point(255, 173)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(296, 20)
        Me.txtcustomername.TabIndex = 27
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(255, 148)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(131, 20)
        Me.txtcustomerid.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(87, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Supplier Contact Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(86, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Supplier Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Supplier ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(255, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 37)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Create Inventory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(86, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 36)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(37, 22)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 36)
        Me.btnback.TabIndex = 18
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(255, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 35)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Chek"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'com_sup_contact
        '
        Me.com_sup_contact.FormattingEnabled = True
        Me.com_sup_contact.Location = New System.Drawing.Point(255, 81)
        Me.com_sup_contact.Name = "com_sup_contact"
        Me.com_sup_contact.Size = New System.Drawing.Size(121, 21)
        Me.com_sup_contact.TabIndex = 30
        '
        'createinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(677, 545)
        Me.Controls.Add(Me.com_sup_contact)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcustomername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Name = "createinventory"
        Me.Text = "createinventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdes As TextBox
    Friend WithEvents txtsellingprice As TextBox
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents txtcustomerid As TextBox
    Friend WithEvents txtinventoryname As TextBox
    Friend WithEvents txtinventoryid As TextBox
    Friend WithEvents cominventorytype As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtopenning As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents com_sup_contact As ComboBox
End Class
