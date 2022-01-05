<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class grn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grn))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comsup_contact_number = New System.Windows.Forms.ComboBox()
        Me.txtsupplierid = New System.Windows.Forms.TextBox()
        Me.btnchek = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgrnnumber = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtamount1 = New System.Windows.Forms.TextBox()
        Me.txtquantity1 = New System.Windows.Forms.TextBox()
        Me.txtcostprice1 = New System.Windows.Forms.TextBox()
        Me.txtinventorycode1 = New System.Windows.Forms.TextBox()
        Me.Cominvname1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grndate = New System.Windows.Forms.DateTimePicker()
        Me.txtinventoryopeningbalance = New System.Windows.Forms.TextBox()
        Me.txtinventoryupdateamount = New System.Windows.Forms.TextBox()
        Me.txtinventoryclosingamount = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtinventorycode2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comsup_contact_number)
        Me.GroupBox1.Controls.Add(Me.txtsupplierid)
        Me.GroupBox1.Controls.Add(Me.btnchek)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(53, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Information"
        '
        'comsup_contact_number
        '
        Me.comsup_contact_number.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comsup_contact_number.FormattingEnabled = True
        Me.comsup_contact_number.Location = New System.Drawing.Point(232, 28)
        Me.comsup_contact_number.Name = "comsup_contact_number"
        Me.comsup_contact_number.Size = New System.Drawing.Size(219, 29)
        Me.comsup_contact_number.TabIndex = 7
        '
        'txtsupplierid
        '
        Me.txtsupplierid.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupplierid.Location = New System.Drawing.Point(232, 107)
        Me.txtsupplierid.Name = "txtsupplierid"
        Me.txtsupplierid.ReadOnly = True
        Me.txtsupplierid.Size = New System.Drawing.Size(219, 28)
        Me.txtsupplierid.TabIndex = 6
        Me.txtsupplierid.WordWrap = False
        '
        'btnchek
        '
        Me.btnchek.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchek.Location = New System.Drawing.Point(232, 63)
        Me.btnchek.Name = "btnchek"
        Me.btnchek.Size = New System.Drawing.Size(121, 38)
        Me.btnchek.TabIndex = 3
        Me.btnchek.Text = "Chek"
        Me.btnchek.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(52, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(52, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(18, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "GR No;"
        '
        'txtgrnnumber
        '
        Me.txtgrnnumber.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrnnumber.Location = New System.Drawing.Point(90, 99)
        Me.txtgrnnumber.Name = "txtgrnnumber"
        Me.txtgrnnumber.Size = New System.Drawing.Size(168, 28)
        Me.txtgrnnumber.TabIndex = 4
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(213, 565)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(475, 45)
        Me.btnsubmit.TabIndex = 134
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtamount1
        '
        Me.txtamount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount1.Location = New System.Drawing.Point(188, 185)
        Me.txtamount1.Name = "txtamount1"
        Me.txtamount1.ReadOnly = True
        Me.txtamount1.Size = New System.Drawing.Size(217, 22)
        Me.txtamount1.TabIndex = 90
        '
        'txtquantity1
        '
        Me.txtquantity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity1.Location = New System.Drawing.Point(189, 149)
        Me.txtquantity1.Name = "txtquantity1"
        Me.txtquantity1.Size = New System.Drawing.Size(216, 22)
        Me.txtquantity1.TabIndex = 89
        '
        'txtcostprice1
        '
        Me.txtcostprice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcostprice1.Location = New System.Drawing.Point(189, 107)
        Me.txtcostprice1.Name = "txtcostprice1"
        Me.txtcostprice1.Size = New System.Drawing.Size(216, 22)
        Me.txtcostprice1.TabIndex = 88
        '
        'txtinventorycode1
        '
        Me.txtinventorycode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventorycode1.Location = New System.Drawing.Point(189, 69)
        Me.txtinventorycode1.Name = "txtinventorycode1"
        Me.txtinventorycode1.ReadOnly = True
        Me.txtinventorycode1.Size = New System.Drawing.Size(216, 22)
        Me.txtinventorycode1.TabIndex = 87
        '
        'Cominvname1
        '
        Me.Cominvname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cominvname1.FormattingEnabled = True
        Me.Cominvname1.Location = New System.Drawing.Point(188, 29)
        Me.Cominvname1.Name = "Cominvname1"
        Me.Cominvname1.Size = New System.Drawing.Size(217, 24)
        Me.Cominvname1.TabIndex = 86
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(35, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Per Price"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(545, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Date"
        '
        'grndate
        '
        Me.grndate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grndate.Location = New System.Drawing.Point(626, 99)
        Me.grndate.Name = "grndate"
        Me.grndate.Size = New System.Drawing.Size(266, 28)
        Me.grndate.TabIndex = 136
        '
        'txtinventoryopeningbalance
        '
        Me.txtinventoryopeningbalance.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventoryopeningbalance.Location = New System.Drawing.Point(255, 50)
        Me.txtinventoryopeningbalance.Name = "txtinventoryopeningbalance"
        Me.txtinventoryopeningbalance.ReadOnly = True
        Me.txtinventoryopeningbalance.Size = New System.Drawing.Size(134, 28)
        Me.txtinventoryopeningbalance.TabIndex = 137
        '
        'txtinventoryupdateamount
        '
        Me.txtinventoryupdateamount.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventoryupdateamount.Location = New System.Drawing.Point(255, 90)
        Me.txtinventoryupdateamount.Name = "txtinventoryupdateamount"
        Me.txtinventoryupdateamount.ReadOnly = True
        Me.txtinventoryupdateamount.Size = New System.Drawing.Size(134, 28)
        Me.txtinventoryupdateamount.TabIndex = 138
        '
        'txtinventoryclosingamount
        '
        Me.txtinventoryclosingamount.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinventoryclosingamount.Location = New System.Drawing.Point(255, 126)
        Me.txtinventoryclosingamount.Name = "txtinventoryclosingamount"
        Me.txtinventoryclosingamount.ReadOnly = True
        Me.txtinventoryclosingamount.Size = New System.Drawing.Size(134, 28)
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
        Me.GroupBox2.Location = New System.Drawing.Point(53, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 232)
        Me.GroupBox2.TabIndex = 140
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insert Inventory "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtinventoryopeningbalance)
        Me.GroupBox3.Controls.Add(Me.txtinventoryupdateamount)
        Me.GroupBox3.Controls.Add(Me.txtinventoryclosingamount)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(503, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 192)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Update Inventory Balance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
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
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(17, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 20)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Update amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(17, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Inventory Opening Balance"
        '
        'txtinventorycode2
        '
        Me.txtinventorycode2.Location = New System.Drawing.Point(1193, 151)
        Me.txtinventorycode2.Name = "txtinventorycode2"
        Me.txtinventorycode2.Size = New System.Drawing.Size(100, 20)
        Me.txtinventorycode2.TabIndex = 143
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(626, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 123)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "New Suplier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(22, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 36)
        Me.Button2.TabIndex = 146
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(369, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(248, 32)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "Good Receive Note"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'grn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(962, 624)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtinventorycode2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grndate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtgrnnumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "grn"
        Me.Text = "Good Receivied Note"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtsupplierid As TextBox
    Friend WithEvents btnchek As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgrnnumber As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtamount1 As TextBox
    Friend WithEvents txtquantity1 As TextBox
    Friend WithEvents txtcostprice1 As TextBox
    Friend WithEvents txtinventorycode1 As TextBox
    Friend WithEvents Cominvname1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grndate As DateTimePicker
    Friend WithEvents comsup_contact_number As ComboBox
    Friend WithEvents txtinventoryopeningbalance As TextBox
    Friend WithEvents txtinventoryupdateamount As TextBox
    Friend WithEvents txtinventoryclosingamount As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtinventorycode2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
