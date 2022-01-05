Imports MySql.Data.MySqlClient
Imports System.Data
Public Class deleteuser
    Dim datast As New DataSet
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub deleteuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim command As New MySqlCommand("SELECT `id` FROM `user` WHERE `id`=@username", connection)
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = comusername.Text

            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(datast, "user")
            comusername.DataSource = datast.Tables(0)
            comusername.ValueMember = "id"
            comusername.DisplayMember = "id"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub comusername_Gotfocus(sender As Object, e As EventArgs) Handles comusername.GotFocus

        Dim adapter As New MySqlDataAdapter("SELECT `id` FROM `user`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            comusername.DataSource = table

            ''comusername.ValueMember = "user_id"
            comusername.DisplayMember = "id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btndeleteuser_Click(sender As Object, e As EventArgs) Handles btndeleteuser.Click


        Dim command As New MySqlCommand("DELETE FROM `user` WHERE `id`=@username", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = comusername.Text
        Try
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete user successfully.")
                Me.Close()
                connection.Close()
                login.Show()
                login.txtusername.Text = ""
                login.txtpassword.Text = ""
            Else
                MsgBox("Error to delete users, try again!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()


    End Sub
End Class