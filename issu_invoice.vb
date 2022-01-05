Imports MySql.Data.MySqlClient
Imports System.Data
Public Class orderforselling
    Dim datast As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")

    Private Sub orderforselling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtbillnumber.Text = geninvoicenumber()


    End Sub

    Private Sub txtinvid1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtinvid1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim chek As New MySqlCommand("SELECT `cus_id`, `cus_name` FROM `customer` WHERE `cus_name` =@mobile", connection)

        chek.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = comcus_contact_number.Text
        Dim reader As MySqlDataReader
        connection.Open()

        Try
            reader = chek.ExecuteReader()

            If reader.Read() Then
                txtcusid.Text = reader(0)
                comcus_contact_number.Text = reader(1)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()


    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcusid_TextChanged(sender As Object, e As EventArgs) Handles txtcusid.TextChanged

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click


        Dim Insertsupplier As New MySqlCommand("INSERT INTO `invoice`(`bill_no`, `date`, `cus_id`, `inventory_name`, `inventory_id`, `cost_price`, `Quantity`) VALUES (@billno, @date, @cus_id, @inventoryname, @inventoryid, @costprice ,@quantity)", connection)
        ''`invoice`(`bill_no`, `date`, `cus_id`, `inventory_name`, `inventory_id`, `cost_price`, `Quantity`)
        ''(@billno, @date, @cus_id, @inventoryname, @inventoryid, @costprice ,@quantity)

        Insertsupplier.Parameters.Add("@billno", MySqlDbType.VarChar).Value = txtbillnumber.Text
        Insertsupplier.Parameters.Add("@date", MySqlDbType.Date).Value = billdate.Value
        Insertsupplier.Parameters.Add("@cus_id", MySqlDbType.VarChar).Value = txtcusid.Text
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
            txtinventoryopeningbalance.Text = ""
            txtinventoryupdateamount.Text = ""
            txtinventoryclosingamount.Text = ""


            connection.Close()

        Else
            MsgBox("Entering data Is Not successful", MsgBoxStyle.Exclamation, Title:="Error")

        End If


        'Update the incentory amount in inventory table



        'to update inventory balance and received amount
        Dim update As New MySqlCommand("UPDATE `inventory` SET  `issu`=@issu ,`closing`=@closing WHERE `inventory_id`=@int_id", connection)


            update.Parameters.Add("@int_id", MySqlDbType.VarChar).Value = txtinventorycode2.Text
            update.Parameters.Add("@issu", MySqlDbType.Int32).Value = txtinventoryupdateamount.Text
            update.Parameters.Add("@closing", MySqlDbType.Int32).Value = txtinventoryclosingamount.Text

            connection.Open()
            Try
                If update.ExecuteNonQuery() = 1 Then
                    MsgBox("Data updated")
                Else
                    MsgBox("Error,Try again")
                End If
                connection.Close()

            Catch ex As Exception

            End Try



    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Cominvname1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cominvname1.SelectedIndexChanged

    End Sub

    Private Sub Cominvname1_GotFocus(sender As Object, e As EventArgs) Handles Cominvname1.GotFocus

        'combo inventory name suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `inventory_name` FROM `inventory`  ", connection)
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

    Private Sub comcus_contact_number_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comcus_contact_number.SelectedIndexChanged

    End Sub

    Private Sub comcus_contact_number_GotFocus(sender As Object, e As EventArgs) Handles comcus_contact_number.GotFocus

        'combo contacy number suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `cus_name` FROM `customer` ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            comcus_contact_number.DataSource = table

            ''comusername.ValueMember = "user_id"
            comcus_contact_number.DisplayMember = "cus_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()

    End Sub

    Private Sub Cominvname1_MouseClick(sender As Object, e As MouseEventArgs) Handles Cominvname1.MouseClick

        Dim Fill2 As New MySqlCommand("SELECT `inventory_id`, `inventory_name`  FROM `inventory` WHERE `inventory_name` =@name", connection)

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

    Private Sub txtquantity1_TextChanged(sender As Object, e As EventArgs) Handles txtquantity1.TextChanged

    End Sub

    Private Sub txtquantity1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtquantity1.KeyDown




        ''calculatre the amount of recived item
        txtamount1.Text = Val(txtcostprice1.Text) + Val(txtquantity1.Text)


        ''suggest current item amount
        txtinventoryupdateamount.Text = txtquantity1.Text

        ''calculate the closing amount
        txtinventoryclosingamount.Text = Val(txtinventoryopeningbalance.Text) - Val(txtinventoryupdateamount.Text)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub txtcostprice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcostprice1.KeyPress
        ''opening balance suggestion

        Dim Fill2 As New MySqlCommand("SELECT `inventory_id`, `closing` FROM `inventory` WHERE `inventory_id` =@inv_id", connection)

        Fill2.Parameters.Add("@inv_id", MySqlDbType.VarChar).Value = txtinventorycode1.Text
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtinventorycode1.Text = reader(0)
                txtinventoryopeningbalance.Text = reader(1)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception


        End Try
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newcustomer.Show()
    End Sub
End Class