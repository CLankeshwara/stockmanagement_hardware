Imports MySql.Data.MySqlClient
Imports System.Data
Public Class new_createinventory
    Dim datast3 As New DataSet
    Dim bindingsrc As New BindingSource
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Private Sub new_createinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to display supplier name list
        Dim command As New MySqlCommand("SELECT sup_name, sup_contact_number FROM `supplier`", connection)
        Dim adapter2 As New MySqlDataAdapter(command)

        datast3 = New DataSet()
        adapter2.Fill(datast3, "supplier")
        datast3.Tables(0).DefaultView.Sort = "sup_name"
        bindingsrc = New BindingSource()

        With DataGridView1
            .DataSource = datast3.Tables("supplier")
        End With
        'generate inventory_id function
        txtinventoryid.Text = geninventoryid()


    End Sub

    Private Sub btncustomerchek_Click(sender As Object, e As EventArgs) Handles btncustomerchek.Click

        Dim Fill2 As New MySqlCommand("SELECT `sup_id`, `sup_name` FROM `supplier` WHERE `sup_name` =@name", connection)

        Fill2.Parameters.Add("@name", MySqlDbType.VarChar).Value = com_sup_contact.Text
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            reader = Fill2.ExecuteReader()

            If reader.Read() Then
                txtcustomerid.Text = reader(0)
                com_sup_contact.Text = reader(1)


            Else
                MsgBox("search customer first")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()

    End Sub
    Private Sub com_sup_contact_GotFocus(sender As Object, e As EventArgs) Handles com_sup_contact.GotFocus

        'combo contacy number suggestion
        Dim adapter As New MySqlDataAdapter("SELECT `sup_name` FROM `supplier`  ", connection)
        connection.Open()
        Dim table As New DataTable()
        Try
            adapter.Fill(table)

            com_sup_contact.DataSource = table

            ''comusername.ValueMember = "user_id"
            com_sup_contact.DisplayMember = "sup_name"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        connection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' if all the textboxes are filled insert the customer details to the database
        Dim Insertinventory As New MySqlCommand("INSERT INTO `inventory`(`sup_id`, `inventory_type`, `inventory_id`, `inventory_name`, `location`) VALUES (@sup_id, @inventory_type, @inventory_id, @inventory_name, @location)", connection)
        ''INSERT INTO `inventory`(`sup_id`, `inventory_type`, `inventory_id`, `inventory_name`, `location`)

        Insertinventory.Parameters.Add("@inventory_type", MySqlDbType.VarChar).Value = cominventorytype.Text
        Insertinventory.Parameters.Add("@inventory_id", MySqlDbType.VarChar).Value = txtinventoryid.Text
        Insertinventory.Parameters.Add("@inventory_name", MySqlDbType.VarChar).Value = txtinventoryname.Text
        Insertinventory.Parameters.Add("@location", MySqlDbType.VarChar).Value = txtlocation.Text


        Insertinventory.Parameters.Add("@sup_id", MySqlDbType.VarChar).Value = txtcustomerid.Text


        connection.Open()
        If Insertinventory.ExecuteNonQuery() = 1 Then

            MessageBox.Show("data inserted")

            'if the data entering is successful clear the textboxes

            txtinventoryname.Text = ""
            cominventorytype.Text = ""
            txtlocation.Text = ""

            'to refill the customerId


            Dim command As New MySqlCommand("Select Max(`inventory_id`) from `inventory`", connection)
            Dim dr2 As MySqlDataReader
            dr2 = command.ExecuteReader()

            Dim newId As String = String.Format("INV-{0}-0001", DateTime.Now.Day)

            If dr2.HasRows Then

                Dim prefix As String = String.Format("INV-{0}", DateTime.Now.Day)

                While dr2.Read()
                    Dim maxId As String = dr2(0).ToString()

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

    Private Sub com_sup_contact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_sup_contact.SelectedIndexChanged
        filterdata(com_sup_contact.Text)
    End Sub
    Public Sub filterdata(valueToSearch As String)
        ''SELECT * FROM `supplier` WHERE 1
        Dim searchquery As String = "SELECT * FROM supplier WHERE (sup_name) like '%" & valueToSearch & "%' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table




    End Sub
End Class