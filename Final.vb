Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class final
    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand

    Private Sub final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cn
            .ConnectionString = "server=localhost;user id=root;password=;database=hardware"
        End With

        loadreport()

    End Sub

    Sub loadreport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer2.RefreshReport()
        Try
            With ReportViewer2.LocalReport()
                .ReportPath = Application.StartupPath & "\Reports\Report1.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()
            da.SelectCommand = New MySqlCommand("select sup_id, inventory_id, inventory_name, location, receive, issu, closing from inventory", cn)
            'da.Fill(ds) 'Tables("inventorybalance")
            cn.Close()

            rptDS = New ReportDataSource("inventorybalance", ds.Tables("inventorybalance"))
            ReportViewer2.LocalReport.DataSources.Add(rptDS)
            ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer2.ZoomMode = ZoomMode.Percent
            ReportViewer2.ZoomPercent = 30

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub



End Class