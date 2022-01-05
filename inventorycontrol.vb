Imports MySql.Data.MySqlClient
Imports System.Data
Public Class inventorycontrol
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub inventorycontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to display the default table in datagrid
        Dim command As New MySqlCommand("SELECT * FROM `inventory`", connection)
        Dim adapter As New MySqlDataAdapter(command)

        datast = New DataSet()
        adapter.Fill(datast, "inventory")
        datast.Tables(0).DefaultView.Sort = "inventory_id"
        bindingsrc = New BindingSource()

        With DataGridView1
            .DataSource = datast.Tables("inventory")
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grn.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        orderforselling.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class