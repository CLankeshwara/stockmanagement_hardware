Imports MySql.Data.MySqlClient
Imports System.Data
Public Class deletesupplier
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub deletesupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comsupcontactnumber.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles comsupcontactnumber.GotFocus

        Dim adapter As New MySqlDataAdapter("SELECT `sup_name` FROM `supplier`", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            comsupcontactnumber.DataSource = table

            ''comusername.ValueMember = "user_id"
            comsupcontactnumber.DisplayMember = "sup_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btndeletesupplier_Click(sender As Object, e As EventArgs) Handles btndeletesupplier.Click

        Dim command As New MySqlCommand("DELETE FROM `supplier` WHERE `sup_name`=@number", connection)
        command.Parameters.Add("@number", MySqlDbType.VarChar).Value = comsupcontactnumber.Text
        Try
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete customer successfully.")
                Me.Close()
                connection.Close()
                ''login.Show()
                ''login.txtusername.Text = ""
                ''login.txtpassword.Text = ""
                supplier_control.Show()
            Else
                MsgBox("Error to Delete customer, try again!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()


    End Sub
End Class