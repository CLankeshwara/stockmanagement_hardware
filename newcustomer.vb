Imports MySql.Data.MySqlClient
Imports System.Data
Public Class newcustomer
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub btncreatesupplier_Click(sender As Object, e As EventArgs) Handles btncreatesupplier.Click

        'display a error message if any of the text boxes are empty
        If txtscustomerid.Text = "" Then
            MsgBox("please enter the customer id")
        ElseIf txtname.Text = "" Then
            MsgBox("please enter the customer name")
        ElseIf txtaddress.Text = "" Then
            MsgBox("please enter the customer address")
        ElseIf txtcontact.Text = "" Then
            MsgBox("please enter the customer's contact number")
        ElseIf txtnic.Text = "" Then
            MsgBox("please enter the customer nic")
        ElseIf txtemail.Text = "" Then
            MsgBox("please enter the customer E_Mail addres")
        Else

            ' if all the textboxes are filled insert the customer details to the database
            Dim Insertcustomer As New MySqlCommand("INSERT INTO `customer`(`cus_id`, `cus_name`, `cus_contact_number`, `cus_addres`, `cus_nic`, `cus_email`) VALUES (@supId, @CusName, @Mobile, @Address,@nic, @email)", connection)
            ''INSERT INTO `customer`(`cus_id`, `cus_name`, `cus_contact_number`, `cus_addres`, `cus_nic`, `cus_email`)

            Insertcustomer.Parameters.Add("@supId", MySqlDbType.VarChar).Value = txtscustomerid.Text
            Insertcustomer.Parameters.Add("@CusName", MySqlDbType.VarChar).Value = txtname.Text
            Insertcustomer.Parameters.Add("@Mobile", MySqlDbType.VarChar).Value = txtcontact.Text
            Insertcustomer.Parameters.Add("@Address", MySqlDbType.VarChar).Value = txtaddress.Text
            Insertcustomer.Parameters.Add("@nic", MySqlDbType.VarChar).Value = txtnic.Text
            Insertcustomer.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtemail.Text

            connection.Open()
            If Insertcustomer.ExecuteNonQuery() = 1 Then

                MessageBox.Show("data inserted")

                'if the data entering is successful clear the textboxes

                txtaddress.Text = ""
                txtcontact.Text = ""
                txtname.Text = ""
                txtnic.Text = ""
                txtemail.Text = ""

                'to refill the customerId

                Try

                    Dim command As New MySqlCommand("Select Max(`cus_id`) from `customer`", connection)
                    Dim dr As MySqlDataReader
                    dr = command.ExecuteReader()

                    Dim newId As String = String.Format("CUS-{0}-0001", DateTime.Now.Day)

                    If dr.HasRows Then

                        Dim prefix As String = String.Format("CUS-{0}", DateTime.Now.Day)

                        While dr.Read()
                            Dim maxId As String = dr(0).ToString()

                            If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                                Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                                newId = String.Format("CUS-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                            End If
                        End While
                    End If

                    txtscustomerid.Text = newId
                    txtscustomerid.Enabled = False
                    connection.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

            End If
        End If

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        customercontrol.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub newcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtscustomerid.Text = genCusID()
    End Sub

    Private Sub txtnic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnic.KeyPress
        Dim CH As Char = e.KeyChar


        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider1.SetError(txtnic, "Please Enter Valid NIC NO")

        Else
            ErrorProvider1.SetError(txtnic, "")

        End If
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        Dim CH As Char = e.KeyChar

        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider2.SetError(txtcontact, "Numbers Only")

        Else
            ErrorProvider2.SetError(txtcontact, "")

        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress

    End Sub
End Class