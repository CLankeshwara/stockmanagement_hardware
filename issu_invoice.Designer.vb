<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderforselling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderforselling))
        Me.txtbillnumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comcus_contact_number = New System.Windows.Forms.ComboBox()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.billdate = New System.Windows.Forms.DateTimePicker()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinventoryopeningbalance = New System.Windows.Forms.TextBox()
        Me.txtinventoryupdateamount = New System.Windows.Forms.TextBox()
        Me.txtinventoryclosingamount = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cominvname1 = New System.Windows.Forms.ComboBox()
        Me.txtinventorycode1 = New System.Windows.Forms.TextBox()
        Me.txtamount1 = New System.Windows.Forms.TextBox()
        Me.txtcostprice1 = New System.Windows.Forms.TextBox()
        Me.txtquantity1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtinventorycode2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbillnumber
        '
        Me.txtbillnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillnumber.Location = New System.Drawing.Point(136, 77)
        Me.txtbillnumber.Name = "txtbillnumber"
        Me.txtbillnumber.ReadOnly = True
        Me.txtbillnumber.Size = New System.Drawing.Size(154, 26)
        Me.txtbillnumber.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(41, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Billing No;"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.comcus_contact_number)
        Me.GroupBox1.Controls.Add(Me.txtcusid)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(34, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 171)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'comcus_contact_number
        '
        Me.comcus_contact_number.FormattingEnabled = True
        Me.comcus_contact_number.Location = New System.Drawing.Point(269, 30)
        Me.comcus_contact_number.Name = "comcus_contact_number"
        Me.comcus_contact_number.Size = New System.Drawing.Size(187, 28)
        Me.comcus_contact_number.TabIndex = 145
        '
        'txtcusid
        '
        Me.txtcusid.Location = New System.Drawing.Point(269, 119)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.ReadOnly = True
        Me.txtcusid.Size = New System.Drawing.Size(187, 26)
        Me.txtcusid.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(269, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Chek"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(46, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(43, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'billdate
        '
        Me.billdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billdate.Location = New System.Drawing.Point(648, 80)
        Me.billdate.Name = "billdate"
        Me.billdate.Size = New System.Drawing.Size(267, 26)
        Me.billdate.TabIndex = 10
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(235, 572)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(484, 58)
        Me.btnsubmit.TabIndex = 72
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtinventoryopeningbalance)
        Me.GroupBox3.Controls.Add(Me.txtinventoryupdateamount)
        Me.GroupBox3.Controls.Add(Me.txtinventoryclosingamount)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(495, 365)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 192)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Update Inventory Balance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(17, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 20)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "Invntory Closing Balance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(17, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 20)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Update amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 20)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Inventory Opening Balance"
        '
        'txtinventoryopeningbalance
        '
        Me.txtinventoryopeningbalance.Location = New System.Drawing.Point(265, 49)
        Me.txtinventoryopeningbalance.Name = "txtinventoryopeningbalance"
        Me.txtinventoryopeningbalance.ReadOnly = True
        Me.txtinventoryopeningbalance.Size = New System.Drawing.Size(127, 26)
        Me.txtinventoryopeningbalance.TabIndex = 137
        '
        'txtinventoryupdateamount
        '
        Me.txtinventoryupdateamount.Location = New System.Drawing.Point(265, 89)
        Me.txtinventoryupdateamount.Name = "txtinventoryupdateamount"
        Me.txtinventoryupdateamount.ReadOnly = True
        Me.txtinventoryupdateamount.Size = New System.Drawing.Size(127, 26)
        Me.txtinventoryupdateamount.TabIndex = 138
        '
        'txtinventoryclosingamount
        '
        Me.txtinventoryclosingamount.Location = New System.Drawing.Point(265, 125)
        Me.txtinventoryclosingamount.Name = "txtinventoryclosingamount"
        Me.txtinventoryclosingamount.ReadOnly = True
        Me.txtinventoryclosingamount.Size = New System.Drawing.Size(127, 26)
        Me.txtinventoryclosingamount.TabIndex = 139
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Cominvname1)
        Me.GroupBox2.Controls.Add(Me.txtinventorycode1)
        Me.GroupBox2.Controls.Add(Me.txtamount1)
        Me.GroupBox2.Controls.Add(Me.txtcostprice1)
        Me.GroupBox2.Controls.Add(Me.txtquantity1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(45, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 232)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Issu Inventory "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.No
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(35, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Items Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(35, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Item Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(35, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Invoice Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(35, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(35, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Amount"
        '
        'Cominvname1
        '
        Me.Cominvname1.FormattingEnabled = True
        Me.Cominvname1.Location = New System.Drawing.Point(188, 29)
        Me.Cominvname1.Name = "Cominvname1"
        Me.Cominvname1.Size = New System.Drawing.Size(217, 28)
        Me.Cominvname1.TabIndex = 86
        '
        'txtinventorycode1
        '
        Me.txtinventorycode1.Location = New System.Drawing.Point(189, 69)
        Me.txtinventorycode1.Name = "txtinventorycode1"
        Me.txtinventorycode1.ReadOnly = True
        Me.txtinventorycode1.Size = New System.Drawing.Size(216, 26)
        Me.txtinventorycode1.TabIndex = 87
        '
        'txtamount1
        '
        Me.txtamount1.Location = New System.Drawing.Point(188, 185)
        Me.txtamount1.Name = "txtamount1"
        Me.txtamount1.Size = New System.Drawing.Size(217, 26)
        Me.txtamount1.TabIndex = 90
        '
        'txtcostprice1
        '
        Me.txtcostprice1.Location = New System.Drawing.Point(189, 107)
        Me.txtcostprice1.Name = "txtcostprice1"
        Me.txtcostprice1.Size = New System.Drawing.Size(216, 26)
        Me.txtcostprice1.TabIndex = 88
        '
        'txtquantity1
        '
        Me.txtquantity1.Location = New System.Drawing.Point(189, 149)
        Me.txtquantity1.Name = "txtquantity1"
        Me.txtquantity1.Size = New System.Drawing.Size(216, 26)
        Me.txtquantity1.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(570, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Date"
        '
        'txtinventorycode2
        '
        Me.txtinventorycode2.Location = New System.Drawing.Point(1120, 203)
        Me.txtinventorycode2.Name = "txtinventorycode2"
        Me.txtinventorycode2.Size = New System.Drawing.Size(100, 20)
        Me.txtinventorycode2.TabIndex = 145
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(647, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 123)
        Me.Button2.TabIndex = 146
        Me.Button2.Text = "New Customer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(439, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 32)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Invoice"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(34, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 36)
        Me.Button3.TabIndex = 149
        Me.Button3.UseVisualStyleBackColor = True
        '
        'orderforselling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(966, 645)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtinventorycode2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.billdate)
        Me.Controls.Add(Me.txtbillnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "orderforselling"
        Me.Text = "Order invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbillnumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcusid As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents billdate As DateTimePicker
    Friend WithEvents btnsubmit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtinventoryopeningbalance As TextBox
    Friend WithEvents txtinventoryupdateamount As TextBox
    Friend WithEvents txtinventoryclosingamount As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Cominvname1 As ComboBox
    Friend WithEvents txtinventorycode1 As TextBox
    Friend WithEvents txtamount1 As TextBox
    Friend WithEvents txtcostprice1 As TextBox
    Friend WithEvents txtquantity1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents comcus_contact_number As ComboBox
    Friend WithEvents txtinventorycode2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
End Class
