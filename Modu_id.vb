Imports MySql.Data.MySqlClient
Imports System.Data
Module Modu_id
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Public Function genCusID() As String
        Dim command As New MySqlCommand("Select Max(`cus_id`) from `customer`", connection)
        Dim dr1 As MySqlDataReader
        connection.Open()
        dr1 = command.ExecuteReader()

        Dim cusId As String = String.Format("CUS-{0}-0001", DateTime.Now.Day)

        If dr1.HasRows Then

            Dim prefix As String = String.Format("CUS-{0}", DateTime.Now.Day)

            While dr1.Read()
                Dim maxId As String = dr1(0).ToString()

                If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                    Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                    cusId = String.Format("CUS-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                End If
            End While
        End If
        dr1.Close()
        connection.Close()
        Return cusId

    End Function

    Public Function gensupid() As String
        Dim command As New MySqlCommand("Select Max(`sup_id`) from `supplier`", connection)
        Dim dr2 As MySqlDataReader
        connection.Open()
        dr2 = command.ExecuteReader()

        Dim supId As String = String.Format("SUP-{0}-0001", DateTime.Now.Day)

        If dr2.HasRows Then

            Dim prefix As String = String.Format("SUP-{0}", DateTime.Now.Day)

            While dr2.Read()
                Dim maxId As String = dr2(0).ToString()

                If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                    Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                    supId = String.Format("SUP-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                End If
            End While
        End If
        dr2.Close()
        connection.Close()
        Return supId

    End Function

    Public Function geninventoryid() As String
        Dim command As New MySqlCommand("Select Max(`inventory_id`) from `inventory`", connection)
        Dim dr2 As MySqlDataReader
        connection.Open()
        dr2 = command.ExecuteReader()

        Dim inventory_id As String = String.Format("INV-{0}-0001", DateTime.Now.Day)

        If dr2.HasRows Then

            Dim prefix As String = String.Format("INV-{0}", DateTime.Now.Day)

            While dr2.Read()
                Dim maxId As String = dr2(0).ToString()

                If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                    Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                    inventory_id = String.Format("INV-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                End If
            End While
        End If
        dr2.Close()
        connection.Close()
        Return inventory_id

    End Function
    Public Function gengrnnumber() As String
        Dim command As New MySqlCommand("Select Max(`grn_number`) from `good_received_note`", connection)
        Dim dr1 As MySqlDataReader
        connection.Open()
        dr1 = command.ExecuteReader()

        Dim grn As String = String.Format("GRN-{0}-0001", DateTime.Now.Day)

        If dr1.HasRows Then

            Dim prefix As String = String.Format("GRN-{0}", DateTime.Now.Day)

            While dr1.Read()
                Dim maxId As String = dr1(0).ToString()

                If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                    Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                    grn = String.Format("GRN-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                End If
            End While
        End If
        dr1.Close()
        connection.Close()
        Return grn
    End Function

    Public Function geninvoicenumber() As String
        Dim command As New MySqlCommand("Select Max(`bill_no`) from `invoice`", connection)
        Dim dr1 As MySqlDataReader
        connection.Open()
        dr1 = command.ExecuteReader()

        Dim bill As String = String.Format("INVOICE-{0}-0001", DateTime.Now.Day)

        If dr1.HasRows Then

            Dim prefix As String = String.Format("INVOICE-{0}", DateTime.Now.Day)

            While dr1.Read()
                Dim maxId As String = dr1(0).ToString()

                If Not String.IsNullOrWhiteSpace(maxId) AndAlso maxId.StartsWith(prefix) Then
                    Dim count As Integer = Convert.ToInt32(maxId.Split("-"c)(2))
                    bill = String.Format("INVOICE-{0}-{1:0000}", DateTime.Now.Day, count + 1)
                End If
            End While
        End If
        dr1.Close()
        connection.Close()
        Return bill
    End Function


End Module
