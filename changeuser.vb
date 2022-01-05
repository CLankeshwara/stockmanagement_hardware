Imports MySql.Data.MySqlClient
Imports System.Data
Public Class changeuser
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''slect user
        Dim command As New MySqlCommand("SELECT `id`, `password` FROM `user` WHERE `id` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtusername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Txtexistpass.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MsgBox("invalid Username or password", MsgBoxStyle.Critical, "Login Error")
            Txtexistpass.Focus()

        Else
            MessageBox.Show("You can change your password")
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtnewpassword.PasswordChar = ControlChars.NullChar
            Txtexistpass.PasswordChar = ControlChars.NullChar

        Else
            txtnewpassword.PasswordChar = "*"c
            Txtexistpass.PasswordChar = "*"c

        End If
    End Sub

    Private Sub changeuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''set watermark
        SetWatermark(txtusername, "Enter Username")
        SetWatermark(Txtexistpass, "Enter your Existing password")
        SetWatermark(txtnewpassword, "Enter your new password")
        SetWatermark(txtconformpassword, "Re-enter your new password")
        SetWatermark(txttelephone, "Enter your telephone number")
        SetWatermark(txtemail, "Enter your E-mail addres")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click


        ''change system user details
        If txtusername.Text = "" OrElse txtnewpassword.Text = "" OrElse txtconformpassword.Text = "" Then
            MsgBox("Please enter some data first.")

        ElseIf (txtnewpassword.Text.Length <= 8) Then
            MsgBox("Password must be greater than 8 character")
            txtnewpassword.Text = ""

        ElseIf Txtexistpass.Text = login.Txtpassword.Text Then
            MsgBox("password you entered is not correct")
            txtnewpassword.Text = ""
            txtnewpassword.Focus()

        ElseIf txtnewpassword.Text <> txtconformpassword.Text Then
            MsgBox("Your new password and confirm password do not match")
            txtnewpassword.Text = ""
            txtconformpassword.Text = ""
            txtnewpassword.Focus()

        Else

            Try

                Dim commandupdateuser As New MySqlCommand("UPDATE `user` SET `password`= @password,`telephone`= @telephone,`email`= @email WHERE `id`=@username", connection)
                ''UPDATE `user` SET `password`= @password,`telephone`= @telephone,`email`= @email WHERE

                commandupdateuser.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtnewpassword.Text
                commandupdateuser.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text
                commandupdateuser.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txttelephone.Text
                commandupdateuser.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtusername.Text

                connection.Open()
                If commandupdateuser.ExecuteNonQuery() = 1 Then

                    MessageBox.Show("Your profile update is successful")
                    Me.Close()
                    connection.Close()
                    login.Show()
                    login.txtusername.Text = ""
                    login.txtpassword.Text = ""

                Else

                    MessageBox.Show(" Error occured, Try again ")

                    txtusername.Text = ""
                    txtnewpassword.Text = ""
                    txtnewpassword.Text = ""

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        mainmenu.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class