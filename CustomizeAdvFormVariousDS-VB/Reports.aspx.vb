Imports Telerik.Reporting


Partial Class Reports
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load



        Dim LocationId As Integer
        If Request.QueryString("LocationId").ToString <> "" Then
            LocationId = Request.QueryString("LocationId")
        Else
            LocationId = 1
        End If


        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
        Select Case LocationId
            Case 1
                instanceReportSource.ReportDocument = New My.Reports.CalendarReport(LocationId)
            Case 2
                instanceReportSource.ReportDocument = New My.Reports.ShSqReport()
        End Select

        Me.ReportViewer1.ReportSource = instanceReportSource

    End Sub



#Region "Menu"
    Protected Sub RadToolBar1_ButtonClick(sender As Object, e As Telerik.Web.UI.RadToolBarEventArgs) Handles RadToolBar1.ButtonClick
        Select Case e.Item.Text
            Case "Shaftsbury Sq"
                Response.Redirect("Default.aspx?LocationId=2&Title=Shaftuty Sq Resources")
            Case "Ormeau Road"
                Response.Redirect("Default.aspx?LocationId=1&Title=Ormeau Road Resources")
            Case "Print Reports"
                Dim LocationID As String = Me.Request.QueryString("LocationID")
                Response.Redirect("Reports.aspx?LocationId=" + LocationID)
        End Select
    End Sub
#End Region

End Class
