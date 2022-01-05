Imports MySql.Data.MySqlClient
Imports System.Data
Public Class newsupplier
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        supplier_control.Show()
        Me.Hide()
    End Sub

    Private Sub btncreatesupplier_Click(sender As Object, e As EventArgs) Handles btncreatesupplier.Click

        'display a error message if any of the text boxes are empty
        If txtsupplierid.Text = "" Then
            MsgBox("please enter the customer id")
        ElseIf txtname.Text = "" Then
            MsgBox("please enter the customer name")
        ElseIf txtaddress.Text = "" Then
            MsgBox("please enter the customer address")
        ElseIf txtcontact.Text = "" Then
            MsgBox("please enter the customer's contact number")
        ElseIf txtemail.Text = "" Then
            MsgBox("please enter the customer email")
        ElseIf txtemail.Text = "" Then
            MsgBox("please enter the supplier NIC")
        Else

            ' if all the textboxes are filled insert the customer details to the database
            Dim Insertsupplier As New MySqlCommand("INSERT INTO `supplier`(`sup_id`, `sup_name`, `sup_contact_number`, `sup_address`, `sup_email`, `sup_nic`) VALUES (@supId, @CusName, @Mobile, @Address,@Email, @nic)", connection)
            ''INSERT INTO `supplier`(`sup_id`, `sup_name`, `sup_contact_number`, `sup_address`, `sup_email`, `sup_nic`)

            Insertsupplier.Parameters.Add("@supId", MySqlDbType.VarChar).Value = txtsupplierid.Text
            Insertsupplier.Parameters.Add("@CusName", MySqlDbType.VarChar).Value = txtname.Text
            Insertsupplier.Parameters.Add("@Mobile", MySqlDbType.VarChar).Value = txtcontact.Text
            Insertsupplier.Parameters.Add("@Address", MySqlDbType.VarChar).Value = txtaddress.Text
            Insertsupplier.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txtemail.Text
            Insertsupplier.Parameters.Add("@nic", MySqlDbType.VarChar).Value = txtnic.Text

            connection.Open()
            If Insertsupplier.ExecuteNonQuery() = 1 Then

                MessageBox.Show("data inserted")

                'if the data entering is successful clear the textboxes

                txtaddress.Text = ""
                txtcontact.Text = ""
                txtname.Text = ""
                txtemail.Text = ""
                txtnic.Text = ""


                'to refill the SupplierId

                Try

                    Dim command As New MySqlCommand("Select Max(`sup_id`) from `supplier`", connection)
                    Dim dr As MySqlDataReader
                    dr = command.ExecuteReader()

                    Dim newId As String = String.Format("SUP-{0}-0001", DateTime.Now.Day)

                    If dr.HasRows Then

                        Dim prefix As String = String.Format("SUP-{0}", DateTime.Now.Day)

                        While dr.Read()
                            Dim maxId As String = dr(0).ToString()

                            If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                                Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                                newId = String.Format("SUP-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                            End If
                        End While
                    End If

                    txtsupplierid.Text = newId
                    txtsupplierid.Enabled = False
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

            End If
        End If
    End Sub

    Private Sub newsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsupplierid.Text = gensupid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtnic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnic.KeyPress

        Dim CH As Char = e.KeyChar

        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True



        End If

    End Sub
End Class