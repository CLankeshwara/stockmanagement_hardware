Imports MySql.Data.MySqlClient
Imports System.Data
Public Class grn
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click

        ' if all the textboxes are filled insert the customer details to the database

        Dim Insertsupplier As New MySqlCommand("INSERT INTO `good_received_note`(`grn_number`, `date`, `sup_id`, `inventory_name`, `inventory_id`, `quantity`, `cost_price`) VALUES (@grnnumber, @date, @sup_id, @inventoryname,@inventoryid, @quantity, @costprice)", connection)
        ''INSERT INTO `good_received_note`(`grn_number`, `date`, `sup_id`, `inventory_name`, `inventory_id`, `quantity`, `cost_price`)
        ''(@grnnumber, @date, @sup_id, @inventoryname,@inventoryid, @quantity, @costprice)

        Insertsupplier.Parameters.Add("@grnnumber", MySqlDbType.VarChar).Value = txtgrnnumber.Text
        Insertsupplier.Parameters.Add("@date", MySqlDbType.Date).Value = grndate.Value
        Insertsupplier.Parameters.Add("@sup_id", MySqlDbType.VarChar).Value = txtsupplierid.Text
        Insertsupplier.Parameters.Add("@inventoryname", MySqlDbType.VarChar).Value = Cominvname1.Text
        Insertsupplier.Parameters.Add("@inventoryid", MySqlDbType.VarChar).Value = txtinventorycode1.Text
        Insertsupplier.Parameters.Add("@quantity", MySqlDbType.Int32).Value = txtquantity1.Text
        Insertsupplier.Parameters.Add("@costprice", MySqlDbType.Int32).Value = txtcostprice1.Text


        connection.Open()
        If Insertsupplier.ExecuteNonQuery() = 1 Then

            MessageBox.Show("data inserted")

            'if the data entering is successful clear the textboxes

            Cominvname1.Text = ""
            txtinventorycode1.Text = ""

            txtquantity1.Text = ""
            txtcostprice1.Text = ""
            txtamount1.Text = ""

            'to refill the SupplierId

            connection.Close()

        Else
            MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

        End If


        'Update the incentory amount in inventory table

        If txtinventoryupdateamount.Text = "" OrElse txtinventoryclosingamount.Text = "" Then
            MsgBox("Please fill this again, becourse you Erace some amount ")
        Else
            'to update inventory balance and received amount
            Dim update As New MySqlCommand("UPDATE `inventory` SET  `receive`=@receive ,`closing`=@closing WHERE `inventory_id`=@int_id", connection)
            'UPDATE `customer` SET `cus_name`=@Customer_name ,`contact_number`=@mobile ,`addres`=@addres ,`nic`=@nic ,`e_mail`=@e_mail WHERE

            update.Parameters.Add("@int_id", MySqlDbType.VarChar).Value = txtinventorycode2.Text
            update.Parameters.Add("@receive", MySqlDbType.Int32).Value = txtinventoryupdateamount.Text
            update.Parameters.Add("@closing", MySqlDbType.Int32).Value = txtinventoryclosingamount.Text

            connection.Open()
            Try
                If update.ExecuteNonQuery() = 1 Then
                    MsgBox("Data updated")

                    txtinventoryopeningbalance.Text = ""
                    txtinventoryupdateamount.Text = ""
                    txtinventoryclosingamount.Text = ""

                Else
                    MsgBox("Error,Try again")
                End If
                connection.Close()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnchek_Click(sender As Object, e As EventArgs) Handles btnchek.Click
        Dim Fill2 As New MySqlCommand("SELECT `sup_id`, `sup_name` FROM `supplier` WHERE `sup_name` =@mobile", connection)

        Fill2.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = comsup_contact_number.Text
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtsupplierid.Text = reader(0)
                comsup_contact_number.Text = reader(1)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()
    End Sub

    Private Sub grn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'generate grn_id function

        txtgrnnumber.Text = gengrnnumber()
    End Sub

    Private Sub comsup_contact_number_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comsup_contact_number.SelectedIndexChanged

    End Sub

    Private Sub comsup_contact_number_GotFocus(sender As Object, e As EventArgs) Handles comsup_contact_number.GotFocus
        'combo contacy number suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `sup_name` FROM `supplier`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            comsup_contact_number.DataSource = table

            ''comusername.ValueMember = "user_id"
            comsup_contact_number.DisplayMember = "sup_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cominvname1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cominvname1.SelectedIndexChanged

    End Sub

    Private Sub Cominvname1_GotFocus(sender As Object, e As EventArgs) Handles Cominvname1.GotFocus

        'combo inventory name suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `inventory_name` FROM `inventory`", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            Cominvname1.DataSource = table

            ''comusername.ValueMember = "user_id"
            Cominvname1.DisplayMember = "inventory_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()


    End Sub

    Private Sub Cominvname1_KeyDown(sender As Object, e As KeyEventArgs) Handles Cominvname1.KeyDown
        ''



    End Sub

    Private Sub txtquantity1_TextChanged(sender As Object, e As EventArgs) Handles txtquantity1.TextChanged

    End Sub

    Private Sub txtquantity1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtquantity1.KeyDown

        ''calculatre the amount of recived item
        txtamount1.Text = Val(txtcostprice1.Text) * Val(txtquantity1.Text)
        ''btnsubmit.Focus()

        ''suggest current item amount
        txtinventoryupdateamount.Text = Val(txtquantity1.Text)

        ''calculate the closing amount
        txtinventoryclosingamount.Text = Val(txtinventoryopeningbalance.Text) + Val(txtinventoryupdateamount.Text)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cominvname1_MouseClick(sender As Object, e As MouseEventArgs) Handles Cominvname1.MouseClick
        Dim Fill2 As New MySqlCommand("SELECT `inventory_id`, `inventory_name` FROM `inventory` WHERE `inventory_name` =@name", connection)

        Fill2.Parameters.Add("@name", MySqlDbType.VarChar).Value = Cominvname1.Text
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtinventorycode1.Text = reader(0)
                Cominvname1.Text = reader(1)
                txtinventorycode2.Text = reader(0)

            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        newsupplier.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub txtcostprice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcostprice1.KeyPress
        ''opening balance suggestion

        Dim Fill3 As New MySqlCommand("SELECT `inventory_id`, `closing` FROM `inventory` WHERE `inventory_id` =@inv_id", connection)

        Fill3.Parameters.Add("@inv_id", MySqlDbType.VarChar).Value = txtinventorycode1.Text
        Dim reader1 As MySqlDataReader


        Try
            connection.Open()
            reader1 = Fill3.ExecuteReader()

            If reader1.Read() Then
                txtinventorycode1.Text = reader1(0)
                txtinventoryopeningbalance.Text = reader1(1)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception


        End Try
        connection.Close()

        ''validation
        Dim CH As Char = e.KeyChar


        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider2.SetError(txtcostprice1, "Please Enter Valid NIC NO")

        Else
            ErrorProvider2.SetError(txtcostprice1, "")

        End If
    End Sub

    Private Sub txtquantity1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity1.KeyPress
        Dim CH As Char = e.KeyChar


        If Not Char.IsDigit(CH) AndAlso Asc(CH) <> 8 Then

            e.Handled = True

            ErrorProvider2.SetError(txtquantity1, "Please Enter Valid NIC NO")

        Else
            ErrorProvider2.SetError(txtquantity1, "")

        End If
    End Sub

    Private Sub Cominvname1_TextChanged(sender As Object, e As EventArgs) Handles Cominvname1.TextChanged

    End Sub

    Private Sub txtinventorycode1_TextChanged(sender As Object, e As EventArgs) Handles txtinventorycode1.TextChanged

    End Sub

    Private Sub txtinventorycode1_Move(sender As Object, e As EventArgs) Handles txtinventorycode1.Move

    End Sub

    Private Sub txtquantity1_Move(sender As Object, e As EventArgs) Handles txtquantity1.Move

    End Sub
End Class