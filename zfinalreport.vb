Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class zfinalreport

    Dim cn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hardware")
    Dim cm As MySqlCommand

    Private Sub zfinalreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.Open()
        loadzreport()

    End Sub

    Sub loadzreport()

        Dim rptdb As ReportDataSource
        Me.ReportViewer12.RefreshReport()
        Try
            With ReportViewer12.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\zreportinv.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New zdatasetreport
            Dim da As New MySqlDataAdapter

            ''cn.Open()
            da.SelectCommand = New MySqlCommand("SELECT inventory_id, inventory_name , location, receive, issu, closing from inventory", cn)
            ''da.SelectCommand = New MySqlCommand("SELECT * from inventory", cn)
            da.Fill(ds.Tables("inventory_r"))
            cn.Close()

            rptdb = New ReportDataSource("DataSet1", ds.Tables("inventory_r"))
            ReportViewer12.LocalReport.DataSources.Add(rptdb)
            ReportViewer12.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer12.ZoomMode = ZoomMode.Percent
            ReportViewer12.ZoomPercent = 100
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class