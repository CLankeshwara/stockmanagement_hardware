Imports MySql.Data.MySqlClient
Imports System.Data
Public Class updatecustomer
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub btncreatesupplier_Click(sender As Object, e As EventArgs) Handles btncreatesupplier.Click

        If txtname.Text = "" OrElse txtscustomerid.Text = "" OrElse txtcontact.Text = "" OrElse txtaddress.Text = "" Then
            MsgBox("First search the customer data")
        Else
            'to update customer information
            Dim update As New MySqlCommand("UPDATE `customer` SET `cus_id`=@Customer_id ,`cus_contact_number`=@mobile ,`cus_addres`=@addres ,`cus_nic`=@nic ,`cus_email`=@e_mail WHERE `cus_name`=@Customer_name", connection)
            ''SELECT `cus_id`, `cus_name`, `cus_contact_number`, `cus_addres`, `cus_nic`, `cus_email` FROM `customer` WHERE 1


            update.Parameters.Add("@Customer_id", MySqlDbType.VarChar).Value = txtscustomerid.Text
            update.Parameters.Add("@Customer_name", MySqlDbType.VarChar).Value = txtname.Text
            update.Parameters.Add("@addres", MySqlDbType.VarChar).Value = txtaddress.Text

            update.Parameters.Add("@nic", MySqlDbType.VarChar).Value = txtnic.Text
            update.Parameters.Add("@e_mail", MySqlDbType.VarChar).Value = txtemail.Text
            update.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtcontact.Text


            connection.Open()

            Try
                If update.ExecuteNonQuery() = 1 Then
                    MsgBox("Data updated")


                    txtscustomerid.Clear()
                    txtname.Clear()
                    txtcontact.Clear()
                    txtnic.Clear()
                    txtaddress.Clear()
                    txtemail.Clear()
                    comchek.Text = ""




                Else
                    MsgBox("Error,Try again")
                End If
                connection.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Fill2 As New MySqlCommand("SELECT `cus_id`, `cus_name`, `cus_contact_number`, `cus_addres`, `cus_nic`, `cus_email`  FROM `customer` WHERE `cus_name` =@mobile", connection)

        Fill2.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = comchek.Text
        Dim reader As MySqlDataReader
        connection.Open()

        Try
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtscustomerid.Text = reader(0)
                txtname.Text = reader(1)
                txtcontact.Text = reader(2)
                txtaddress.Text = reader(3)
                txtnic.Text = reader(4)
                txtemail.Text = reader(5)

            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        customercontrol.Show()
        Me.Hide()
    End Sub

    Private Sub updatecustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub comchek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comchek.SelectedIndexChanged

    End Sub

    Private Sub comchek_GotFocus(sender As Object, e As EventArgs) Handles comchek.GotFocus
        Dim adapter As New MySqlDataAdapter("SELECT `cus_name` FROM `customer`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            comchek.DataSource = table

            ''comusername.ValueMember = "user_id"
            comchek.DisplayMember = "cus_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        Dim CH As Char = e.KeyChar

        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider1.SetError(txtcontact, "Numbers Only")

        Else
            ErrorProvider1.SetError(txtcontact, "")

        End If
    End Sub

    Private Sub txtnic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnic.KeyPress
        Dim CH As Char = e.KeyChar


        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider2.SetError(txtnic, "Please Enter Valid NIC NO")

        Else
            ErrorProvider2.SetError(txtnic, "")

        End If
    End Sub
End Class