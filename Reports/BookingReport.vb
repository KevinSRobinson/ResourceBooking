Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class BookingReport
    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()


    End Sub


    Public Sub New(BookingID As Integer)
        InitializeComponent()

        Me.ReportParameters("ClassID").Value = BookingID


    End Sub
End Class