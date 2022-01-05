<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellingBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoodReceivedNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIgnOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnorderlist = New System.Windows.Forms.Button()
        Me.btncustomerlist = New System.Windows.Forms.Button()
        Me.btnsupplierlist = New System.Windows.Forms.Button()
        Me.btninventorylist = New System.Windows.Forms.Button()
        Me.btnnewcustomer = New System.Windows.Forms.Button()
        Me.btnnewinventory = New System.Windows.Forms.Button()
        Me.btnnewsupplier = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UserToolStripMenuItem, Me.ItemToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SIgnOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierControlToolStripMenuItem, Me.CustomerControlToolStripMenuItem, Me.SellingBillToolStripMenuItem, Me.GoodReceivedNoteToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SupplierControlToolStripMenuItem
        '
        Me.SupplierControlToolStripMenuItem.Name = "SupplierControlToolStripMenuItem"
        Me.SupplierControlToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.SupplierControlToolStripMenuItem.Text = "Supplier Control"
        '
        'CustomerControlToolStripMenuItem
        '
        Me.CustomerControlToolStripMenuItem.Name = "CustomerControlToolStripMenuItem"
        Me.CustomerControlToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.CustomerControlToolStripMenuItem.Text = "Customer Control"
        '
        'SellingBillToolStripMenuItem
        '
        Me.SellingBillToolStripMenuItem.Name = "SellingBillToolStripMenuItem"
        Me.SellingBillToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.SellingBillToolStripMenuItem.Text = "Selling Bill"
        '
        'GoodReceivedNoteToolStripMenuItem
        '
        Me.GoodReceivedNoteToolStripMenuItem.Name = "GoodReceivedNoteToolStripMenuItem"
        Me.GoodReceivedNoteToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.GoodReceivedNoteToolStripMenuItem.Text = "Good Received Note"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(70, 25)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.UpdateUserToolStripMenuItem.Text = "Change User password"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddInventoryToolStripMenuItem, Me.DeleteInventoryToolStripMenuItem})
        Me.ItemToolStripMenuItem.Image = CType(resources.GetObject("ItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(104, 25)
        Me.ItemToolStripMenuItem.Text = "Inventory"
        '
        'AddInventoryToolStripMenuItem
        '
        Me.AddInventoryToolStripMenuItem.Name = "AddInventoryToolStripMenuItem"
        Me.AddInventoryToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.AddInventoryToolStripMenuItem.Text = "Add Inventory"
        '
        'DeleteInventoryToolStripMenuItem
        '
        Me.DeleteInventoryToolStripMenuItem.Name = "DeleteInventoryToolStripMenuItem"
        Me.DeleteInventoryToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.DeleteInventoryToolStripMenuItem.Text = "Delete Inventory"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(70, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(144, 26)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'SIgnOutToolStripMenuItem
        '
        Me.SIgnOutToolStripMenuItem.Image = CType(resources.GetObject("SIgnOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SIgnOutToolStripMenuItem.Name = "SIgnOutToolStripMenuItem"
        Me.SIgnOutToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.SIgnOutToolStripMenuItem.Text = "SIgn Out"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(841, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnorderlist
        '
        Me.btnorderlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnorderlist.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderlist.Location = New System.Drawing.Point(12, 352)
        Me.btnorderlist.Name = "btnorderlist"
        Me.btnorderlist.Size = New System.Drawing.Size(263, 130)
        Me.btnorderlist.TabIndex = 2
        Me.btnorderlist.Text = "Order List"
        Me.btnorderlist.UseVisualStyleBackColor = False
        '
        'btncustomerlist
        '
        Me.btncustomerlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncustomerlist.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomerlist.Location = New System.Drawing.Point(12, 202)
        Me.btncustomerlist.Name = "btncustomerlist"
        Me.btncustomerlist.Size = New System.Drawing.Size(263, 130)
        Me.btncustomerlist.TabIndex = 3
        Me.btncustomerlist.Text = "Customer Control"
        Me.btncustomerlist.UseVisualStyleBackColor = False
        '
        'btnsupplierlist
        '
        Me.btnsupplierlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsupplierlist.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupplierlist.Location = New System.Drawing.Point(12, 50)
        Me.btnsupplierlist.Name = "btnsupplierlist"
        Me.btnsupplierlist.Size = New System.Drawing.Size(263, 130)
        Me.btnsupplierlist.TabIndex = 4
        Me.btnsupplierlist.Text = "Supplier Control"
        Me.btnsupplierlist.UseVisualStyleBackColor = False
        '
        'btninventorylist
        '
        Me.btninventorylist.BackColor = System.Drawing.Color.Gray
        Me.btninventorylist.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventorylist.ForeColor = System.Drawing.Color.Transparent
        Me.btninventorylist.Location = New System.Drawing.Point(328, 274)
        Me.btninventorylist.Name = "btninventorylist"
        Me.btninventorylist.Size = New System.Drawing.Size(557, 127)
        Me.btninventorylist.TabIndex = 5
        Me.btninventorylist.Text = "Inventory list"
        Me.btninventorylist.UseVisualStyleBackColor = False
        '
        'btnnewcustomer
        '
        Me.btnnewcustomer.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewcustomer.Location = New System.Drawing.Point(209, 19)
        Me.btnnewcustomer.Name = "btnnewcustomer"
        Me.btnnewcustomer.Size = New System.Drawing.Size(184, 107)
        Me.btnnewcustomer.TabIndex = 6
        Me.btnnewcustomer.Text = "New Customer"
        Me.btnnewcustomer.UseVisualStyleBackColor = True
        '
        'btnnewinventory
        '
        Me.btnnewinventory.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewinventory.Location = New System.Drawing.Point(410, 19)
        Me.btnnewinventory.Name = "btnnewinventory"
        Me.btnnewinventory.Size = New System.Drawing.Size(186, 107)
        Me.btnnewinventory.TabIndex = 7
        Me.btnnewinventory.Text = "New Inventory"
        Me.btnnewinventory.UseVisualStyleBackColor = True
        '
        'btnnewsupplier
        '
        Me.btnnewsupplier.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewsupplier.Location = New System.Drawing.Point(6, 22)
        Me.btnnewsupplier.Name = "btnnewsupplier"
        Me.btnnewsupplier.Size = New System.Drawing.Size(183, 104)
        Me.btnnewsupplier.TabIndex = 8
        Me.btnnewsupplier.Text = "New Supplier"
        Me.btnnewsupplier.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnorderlist)
        Me.GroupBox1.Controls.Add(Me.btncustomerlist)
        Me.GroupBox1.Controls.Add(Me.btnsupplierlist)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnnewcustomer)
        Me.GroupBox2.Controls.Add(Me.btnnewinventory)
        Me.GroupBox2.Controls.Add(Me.btnnewsupplier)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(305, 422)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 132)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(328, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(557, 165)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "   "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(564, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 563)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btninventorylist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainmenu"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents btnorderlist As Button
    Friend WithEvents btncustomerlist As Button
    Friend WithEvents btnsupplierlist As Button
    Friend WithEvents btninventorylist As Button
    Friend WithEvents btnnewcustomer As Button
    Friend WithEvents btnnewinventory As Button
    Friend WithEvents btnnewsupplier As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SupplierControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIgnOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellingBillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoodReceivedNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
