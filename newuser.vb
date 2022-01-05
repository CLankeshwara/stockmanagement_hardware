Imports MySql.Data.MySqlClient
Imports System.Data
Public Class newuser
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub Btnsave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles Chkshowpassword.CheckedChanged
        If Chkshowpassword.Checked Then
            Txtpassword.PasswordChar = ControlChars.NullChar
            Txtconfirmpassword.PasswordChar = ControlChars.NullChar
        Else
            Txtpassword.PasswordChar = "*"c
            Txtconfirmpassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub newuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT * FROM `user`", connection)
        Dim adapter As New MySqlDataAdapter(command)

        datast = New DataSet()
        adapter.Fill(datast, "user")
        datast.Tables(0).DefaultView.Sort = "id"
        bindingsrc = New BindingSource()

        With DataGridView1
            .DataSource = datast.Tables("user")
        End With


        SetWatermark(Txtusername, "Enter Username")
        SetWatermark(Txtpassword, "password for login")
        SetWatermark(txtemail, "E-mail")
        SetWatermark(txttelephone, "Mail-password")
        SetWatermark(Txtconfirmpassword, "Re-enter your password")


    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'Display an error message when all data have not been entered 
        If Txtusername.Text = "" OrElse
                Txtconfirmpassword.Text = "" Then
            ''Cmbrole.Text = "" Then
            MsgBox("Please fillout all data", MsgBoxStyle.Exclamation, Title:="Error")

            'Display error message if the password and confirm password textboxes are not similar
        ElseIf Txtpassword.Text <> Txtconfirmpassword.Text Then
            MsgBox("password & confirm password do not match, Try again", MsgBoxStyle.Exclamation, Title:="Error")
            Txtpassword.Text = ""
            Txtconfirmpassword.Text = ""

            ' display error message if the new password is not greater than 8 charachters
        ElseIf (Txtpassword.Text.Length <= 8) Then
            MsgBox("Password must be greater than 8 character", MsgBoxStyle.Exclamation, Title:="Error")
            Txtpassword.Text = ""
            Txtconfirmpassword.Text = ""


        Else

            'to check whether given username exist 
            Dim select1 As New MySqlCommand("select `id` from  `user` where `id`=@username", connection)
            select1.Parameters.Add("@username", MySqlDbType.VarChar).Value = Txtusername.Text

                Dim adapter1 As New MySqlDataAdapter(select1)
                Dim table As New DataTable()
                adapter1.Fill(table)

            Dim Insertuser As New MySqlCommand("INSERT INTO `user`(`id`, `password`, `telephone`, `email`) VALUES (@Id, @password, @telephone, @Email)", connection)
            ''INSERT INTO `user`(`id`, `password`, `telephone`, `email`)

            Insertuser.Parameters.Add("@Id", MySqlDbType.VarChar).Value = Txtusername.Text
            Insertuser.Parameters.Add("@password", MySqlDbType.VarChar).Value = Txtconfirmpassword.Text
            Insertuser.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = txttelephone.Text
            ''Insertuser.Parameters.Add("@Address", MySqlDbType.VarChar).Value = txtaddress.Text
            Insertuser.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txtemail.Text

            connection.Open()
            If Insertuser.ExecuteNonQuery() = 1 Then

                MessageBox.Show("data inserted")

                'if the data entering is successful clear the textboxes

                ''txtaddress.Text = ""
                txttelephone.Text = ""
                Txtusername.Text = ""
                txtemail.Text = ""
                Txtpassword.Text = ""
                Txtconfirmpassword.Text = ""
                DataGridView1.Refresh()
            Else
                MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        btnsubmit.Refresh()
    End Sub
End Class