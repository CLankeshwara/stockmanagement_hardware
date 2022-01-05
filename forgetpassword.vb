Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class forgetpassword
    Dim connection As MySqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Dim randomcode As String
    Public Shared Touser As String
    Private Sub forgetpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT `email` FROM `user` WHERE `email`=@email ", connection)
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = login.txtusername.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count = 1 Then

            Lbltest.Text = table(0)(0)
        End If

        Lbltest.Hide()
        SetWatermark(txtemail, " ABC@GMAIL.com ")
        SetWatermark(txtverify, "123456789")
        txtemail.Focus()

    End Sub

    Private Sub Btnmsubmit_Click(sender As Object, e As EventArgs) Handles Btnmsubmit.Click
        'to check whether the email address is a valid one
        Dim command As New MySqlCommand("SELECT `email` FROM `user` WHERE `email`=@email", connection)
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            MessageBox.Show("Email adddress you entered is not in the system. Please enter a valid address")
        Else


            Dim from, pass, messagebody As String
            Dim rand As Random = New Random()
            randomcode = (rand.Next(999999)).ToString()
            Dim message As MailMessage = New MailMessage()
            Touser = txtemail.Text
            from = "chanaka.2016lanka@gmail.com"
            pass = "chanaka1234"
            messagebody = "Your verification code is" + " " + randomcode
            message.To.Add(Touser)
            message.From = New MailAddress(from)
            message.Body = messagebody
            message.Subject = "Verification code to reset password of Rosewood"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = -smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)
            smtp.TargetName = "STARTTLS/smtp.gmail.com"
            Try
                smtp.Send(message)
                MessageBox.Show(" verification code sent your email, Please check your email ")
                txtverify.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Private Sub Btnfinal_Click(sender As Object, e As EventArgs) Handles Btnfinal.Click
        If (txtverify.Text.Equals(randomcode)) Then
            changeuser.Show()
            Me.Close()
            changeuser.Txtexistpass.Hide()
        Else
            MessageBox.Show("Check the verification code again")
            txtverify.Text = ""
            txtverify.Focus()
        End If

    End Sub
End Class