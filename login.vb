Imports MySql.Data.MySqlClient
Imports System.Data
Public Class login
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        connection.Close()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Dim command As New MySqlCommand("SELECT `id`, `password` FROM `user` WHERE `id` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtusername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtpassword.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then


            MsgBox("Invalid your Username or Password", "Error", MsgBoxStyle.Critical)
            'MsgBox("False")

        Else

            ''MessageBox.Show("Logged in Succesfully")
            Dim newform As New mainmenu()
            mainmenu.Show()
            Me.Hide()
            txtusername.Clear()
            txtpassword.Clear()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtpassword.UseSystemPasswordChar = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        btnlogin.Focus()
    End Sub
End Class
