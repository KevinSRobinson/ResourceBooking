Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class CalendarReport
    Inherits Telerik.Reporting.Report

    Public Sub New(LocationId As Integer)
        InitializeComponent()

        Me.ReportParameters("LocationId").Value = LocationId

    End Sub
End Class