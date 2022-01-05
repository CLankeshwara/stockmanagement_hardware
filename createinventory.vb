Imports MySql.Data.MySqlClient
Imports System.Data
Public Class createinventory
    Dim connection As New MySqlConnection("datasource=localhost;port=3308;username=root;password=;database=hardware")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Fill2 As New MySqlCommand("SELECT `sup_id`, `sup_name`, `sup_contact_number` FROM `supplier` WHERE `sup_contact_number` =@mobile", connection)

        Fill2.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = com_sup_contact.Text
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtcustomerid.Text = reader(0)
                txtcustomername.Text = reader(1)
                com_sup_contact.Text = reader(2)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        ' if all the textboxes are filled insert the customer details to the database
        Dim Insertinventory As New MySqlCommand("INSERT INTO `inventory`(`inv_type`, `inv_id`, `inv_name`, `selling_price`, `cost_price`, `quantity`, `des`, `inv_balance`, `cus_id`, `cus_name`, `contact_number`) VALUES (@inv_type, @inv_id, @inv_name, @selling_price, @cost_price, @quantity, @des, @inv_balance, @cus_id, @cus_name, @contact_number)", connection)
        ''INSERT INTO `inventory`(`inv_type`, `inv_id`, `inv_name`, `selling_price`, `cost_price`, `quantity`, `des`, `inv_balance`, `cus_id`, `cus_name`, `contact_number`)

        Insertinventory.Parameters.Add("@inv_type", MySqlDbType.VarChar).Value = cominventorytype.Text
        Insertinventory.Parameters.Add("@inv_id", MySqlDbType.VarChar).Value = txtinventoryid.Text
        Insertinventory.Parameters.Add("@inv_name", MySqlDbType.VarChar).Value = txtinventoryname.Text
        Insertinventory.Parameters.Add("@selling_price", MySqlDbType.Int32).Value = txtsellingprice.Text
        'Insertinventory.Parameters.Add("@cost_price", MySqlDbType.Int32).Value = txtcostprice.Text
        'Insertinventory.Parameters.Add("@quantity", MySqlDbType.Int32).Value = txtquantity.Text
        Insertinventory.Parameters.Add("@des", MySqlDbType.VarChar).Value = txtdes.Text
        Insertinventory.Parameters.Add("@inv_balance", MySqlDbType.Int32).Value = txtopenning.Text

        Insertinventory.Parameters.Add("@cus_id", MySqlDbType.VarChar).Value = txtcustomerid.Text
        Insertinventory.Parameters.Add("@cus_name", MySqlDbType.VarChar).Value = txtcustomername.Text
        Insertinventory.Parameters.Add("@contact_number", MySqlDbType.VarChar).Value = com_sup_contact.Text

        connection.Open()
        If Insertinventory.ExecuteNonQuery() = 1 Then

            MessageBox.Show("data inserted")

            'if the data entering is successful clear the textboxes

            txtinventoryname.Text = ""
            txtsellingprice.Text = ""
            'txtcostprice.Text = ""
            'txtquantity.Text = ""
            txtdes.Text = ""
            txtopenning.Text = ""

            'to refill the customerId


            Dim command As New MySqlCommand("Select Max(`inv_id`) from `inventory`", connection)
            Dim dr As MySqlDataReader
            dr = command.ExecuteReader()

            Dim newId As String = String.Format("INV-{0}-0001", DateTime.Now.Day)

            If dr.HasRows Then

                Dim prefix As String = String.Format("INV-{0}", DateTime.Now.Day)

                While dr.Read()
                    Dim maxId As String = dr(0).ToString()

                    If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                        Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                        newId = String.Format("INV-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                    End If
                End While
            End If

            txtinventoryid.Text = newId
            txtinventoryid.Enabled = False
            connection.Close()

        Else
            MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

            End If



    End Sub

    Private Sub createinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'generate inventory_id function
        txtinventoryid.Text = geninventoryid()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub com_sup_contact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_sup_contact.SelectedIndexChanged

    End Sub

    Private Sub com_sup_contact_GotFocus(sender As Object, e As EventArgs) Handles com_sup_contact.GotFocus

        'combo contacy number suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `sup_contact_number` FROM `supplier`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            com_sup_contact.DataSource = table

            ''comusername.ValueMember = "user_id"
            com_sup_contact.DisplayMember = "sup_contact_number"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()

    End Sub

    Private Sub cominventorytype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cominventorytype.SelectedIndexChanged

    End Sub

    Private Sub cominventorytype_GotFocus(sender As Object, e As EventArgs) Handles cominventorytype.GotFocus

        'combo inventory type suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `inventory_type` FROM `inventory`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            com_sup_contact.DataSource = table

            ''comusername.ValueMember = "user_id"
            com_sup_contact.DisplayMember = "inventory_type"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()

    End Sub
End Class