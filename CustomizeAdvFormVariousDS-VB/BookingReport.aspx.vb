Imports Telerik.Reporting


Partial Class BookingReport
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
        instanceReportSource.ReportDocument = New My.Reports.BookingReport(Request.QueryString("BookingID"))

        Me.ReportViewer1.ReportSource = instanceReportSource

    End Sub




End Class
