Imports MySql.Data.MySqlClient
Imports System.Data
Public Class mainmenu
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnnewsupplier_Click(sender As Object, e As EventArgs) Handles btnnewsupplier.Click
        newsupplier.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierControlToolStripMenuItem.Click
        supplier_control.Show()

    End Sub

    Private Sub DeleteInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteInventoryToolStripMenuItem.Click
        deleteinventory.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        aboutus.Show()
        Me.Hide()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        help.Show()
        Me.Hide()
    End Sub

    Private Sub btnsupplierlist_Click(sender As Object, e As EventArgs) Handles btnsupplierlist.Click
        supplier_control.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerControlToolStripMenuItem.Click
        customercontrol.Show()

    End Sub

    Private Sub btncustomerlist_Click(sender As Object, e As EventArgs) Handles btncustomerlist.Click
        customercontrol.Show()
        Me.Hide()
    End Sub

    Private Sub btnnewcustomer_Click(sender As Object, e As EventArgs) Handles btnnewcustomer.Click
        newcustomer.Show()
        Me.Hide()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        newuser.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserToolStripMenuItem.Click
        changeuser.Show()
        Me.Hide()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        deleteuser.Show()
        Me.Hide()
    End Sub

    Private Sub AddInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddInventoryToolStripMenuItem.Click
        new_createinventory.Show()
        Me.Hide()
    End Sub

    Private Sub btninventorylist_Click(sender As Object, e As EventArgs) Handles btninventorylist.Click
        zfinalreport.Show()
        Me.Hide()

    End Sub

    Private Sub SellingBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellingBillToolStripMenuItem.Click
        orderforselling.Show()
        Me.Hide()
    End Sub

    Private Sub GoodReceivedNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoodReceivedNoteToolStripMenuItem.Click
        grn.Show()
        Me.Close()
    End Sub

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub SIgnOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIgnOutToolStripMenuItem.Click
        login.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString()
    End Sub

    Private Sub btnorderlist_Click(sender As Object, e As EventArgs) Handles btnorderlist.Click
        inventorycontrol.Show()
        Me.Close()
    End Sub

    Private Sub btnnewinventory_Click(sender As Object, e As EventArgs) Handles btnnewinventory.Click
        new_createinventory.Show()
        Me.Hide()
    End Sub
End Class