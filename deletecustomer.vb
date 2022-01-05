Imports MySql.Data.MySqlClient
Imports System.Data
Public Class deletecustomer
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub deletecustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub combodeletecustomer_Gotfocus(sender As Object, e As EventArgs) Handles combodeletecustomer.GotFocus

        Dim adapter As New MySqlDataAdapter("SELECT `cus_name` FROM `customer`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            combodeletecustomer.DataSource = table

            ''comusername.ValueMember = "user_id"
            combodeletecustomer.DisplayMember = "cus_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btndeletecustomer_Click(sender As Object, e As EventArgs) Handles btndeletecustomer.Click

        Dim command As New MySqlCommand("DELETE FROM `customer` WHERE `cus_name`=@number", connection)
        command.Parameters.Add("@number", MySqlDbType.VarChar).Value = combodeletecustomer.Text
        Try
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete customer successfully.")
                ''Me.Close()
                connection.Close()
                ''login.Show()
                ''login.txtusername.Text = ""
                ''login.txtpassword.Text = ""
                combodeletecustomer.Text = ""
            Else
                MsgBox("Error to delete customer, try again!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()

    End Sub

    Private Sub combodeletecustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodeletecustomer.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        customercontrol.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
    End Sub
End Class