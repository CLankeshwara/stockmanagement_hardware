Imports MySql.Data.MySqlClient
Imports System.Data
Public Class supplier_control
    Dim datast As New DataSet

    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")

    Private Sub btnnewsupplier_Click(sender As Object, e As EventArgs) Handles btnnewsupplier.Click
        newsupplier.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdatesupplier_Click(sender As Object, e As EventArgs) Handles btnupdatesupplier.Click
        updatesupplier.Show()
        Me.Hide()
    End Sub

    Private Sub btndeletesupplier_Click(sender As Object, e As EventArgs) Handles btndeletesupplier.Click
        deletesupplier.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub supplier_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filterdata("")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtboxsearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearch.TextChanged
        filterdata(txtboxsearch.Text)

    End Sub

    Public Sub filterdata(valueToSearch As String)
        ''SELECT * FROM `supplier` WHERE 1
        Dim searchquery As String = "SELECT * FROM supplier WHERE (sup_name) like '%" & valueToSearch & "%' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table




    End Sub

End Class