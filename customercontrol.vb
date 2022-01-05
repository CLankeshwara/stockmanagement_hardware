Imports MySql.Data.MySqlClient
Imports System.Data
Public Class customercontrol
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub btnnewcustomer_Click(sender As Object, e As EventArgs) Handles btnnewcustomer.Click
        newcustomer.Show()
        Me.Hide()
    End Sub

    Private Sub customercontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'to display the default table in datagrid
        Dim command As New MySqlCommand("SELECT * FROM `customer`", connection)
        Dim adapter As New MySqlDataAdapter(command)

        datast = New DataSet()
        adapter.Fill(datast, "customer")
        datast.Tables(0).DefaultView.Sort = "cus_id"
        bindingsrc = New BindingSource()

        With DataGridView1
            .DataSource = datast.Tables("customer")
        End With


    End Sub

    Private Sub btnupdatecustomer_Click(sender As Object, e As EventArgs) Handles btnupdatecustomer.Click
        updatecustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btndeletecustomer_Click(sender As Object, e As EventArgs) Handles btndeletecustomer.Click
        deletecustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()
    End Sub

    Private Sub txtboxsearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearch.TextChanged
        filterdatacus(txtboxsearch.Text)
    End Sub

    Public Sub filterdatacus(valueToSearch As String)

        Dim searchquery As String = "SELECT * FROM customer WHERE (cus_name) like '%" & valueToSearch & "%' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table




    End Sub
End Class