Imports MySql.Data.MySqlClient
Imports System.Data
Public Class deleteinventory
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub deleteinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub combodeleteinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodeleteinventory.SelectedIndexChanged

    End Sub

    Private Sub combodeleteinventory_GotFocus(sender As Object, e As EventArgs) Handles combodeleteinventory.GotFocus
        Dim adapter As New MySqlDataAdapter("SELECT `inventory_name` FROM `inventory`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            combodeleteinventory.DataSource = table

            ''comusername.ValueMember = "user_id"
            combodeleteinventory.DisplayMember = "inventory_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btndeletecustomer_Click(sender As Object, e As EventArgs) Handles btndeletecustomer.Click
        Dim command As New MySqlCommand("DELETE FROM `inventory` WHERE `inventory_name`=@name", connection)
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = combodeleteinventory.Text
        Try
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete inventory successfully.")
                ''Me.Close()
                connection.Close()
                ''login.Show()
                ''login.txtusername.Text = ""
                ''login.txtpassword.Text = ""
                combodeleteinventory.Text = ""
            Else
                MsgBox("Error to delete customer, try again!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class