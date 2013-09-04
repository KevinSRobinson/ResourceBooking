Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports Telerik.Web.UI
Imports System.Data.Common

Partial Class RadSchedulerAdvancedForm
    Inherits System.Web.UI.Page


    Private OrmeauSchedulerDBProvider As OrmeauSchedulerDBProvider


    Protected Sub Page_Init(sender As Object, e As EventArgs)
        Me.lblTitle.Text = Request.QueryString("Title")

        Dim connString = ConfigurationManager.ConnectionStrings("TelerikVSXConnectionString").ConnectionString
        Dim factory = DbProviderFactories.GetFactory("System.Data.SqlClient")

        Dim LocationID As Integer = Request.QueryString("LocationID")
        If LocationID.ToString = "" Then
            LocationID = 1
        End If

        OrmeauSchedulerDBProvider = New OrmeauSchedulerDBProvider() With {.ConnectionString = connString, .DbFactory = factory, .PersistChanges = True, .LocationID = LocationID}
        RadScheduler1.Provider = OrmeauSchedulerDBProvider
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub


    Public Sub CheckAll(sender As Object, e As EventArgs)

        Dim RadListBox As RadListBox
        RadListBox = Me.lstResources

        For Each Item In RadListBox.Items
            Item.Checked = True
        Next
    End Sub

    Public Sub UnCheckAll(sender As Object, e As EventArgs)

        Dim RadListBox As RadListBox
        RadListBox = Me.lstResources

        For Each Item In RadListBox.Items
            Item.Checked = False
        Next
    End Sub

    Private Function ExceedsLimit(NewAppointment As Appointment) As Boolean

        Dim Returnvalue As Boolean = False
        Me.ErrorMessage = ""
        Me.lblMessage.Text = ""

        If NewAppointment.ID = Nothing Then
            Dim appointmentsCount As Integer = 0

            'Get a lsit of the selected Resporces
            Dim NewResouces As List(Of Resource) = NewAppointment.Resources.ToList


            For Each Resource As Resource In NewResouces
                If Resource.Type = "Resource" Then
                    Dim Avail As Boolean = Resource.Available
                    Dim Resourcename As String = Resource.Text
                    Dim Subject As String = Resource.Key
                    Dim Type As String = Resource.Type

                    If isAlreadyBooked(Resource, NewAppointment.Start, NewAppointment.End) Then
                        Returnvalue = True
                    End If
                End If

            Next

            If Returnvalue = True Then
                Dim charsToTrim() As Char = {","c}
                Me.ErrorMessage.Trim(charsToTrim)
                Me.ErrorMessage += " have been already booked for this period"
                Me.lblMessage.Text = Me.ErrorMessage
            Else
                Me.lblMessage.Text = ""
            End If
        Else
            Returnvalue = False
        End If


        Return Returnvalue

    End Function

    Private ErrorMessage As String = ""

    Private Function isAlreadyBooked(NewResource As Resource, StartDate As Date, EndDate As Date) As Boolean

        'Find appointments within the same date range
        Dim ExistingAppointments As New List(Of Appointment)
        ExistingAppointments = RadScheduler1.Appointments.GetAppointmentsInRange(StartDate, EndDate)

        Dim ReturnValue As Boolean = False

        'See if any of these appointment have the same equipment booked
        For Each Appointment As Appointment In ExistingAppointments
            For Each Resourece As Resource In Appointment.Resources
                If Resourece.Type.ToString <> "Location" Then
                    If Resourece.Key = NewResource.Key Then
                        Me.ErrorMessage += Resourece.Text + ","
                        ReturnValue = True
                    End If
                End If
            Next
        Next

        Return ReturnValue

    End Function


    Private Function AppointmentsOverlap(appointment As Appointment) As Boolean
        If ExceedsLimit(appointment) Then
            For Each a As Appointment In RadScheduler1.Appointments.GetAppointmentsInRange(appointment.Start, appointment.[End])
                If a.ID <> appointment.ID Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Sub RegisterScript()
        Label1.Text = Me.ErrorMessage
        ScriptManager.RegisterClientScriptBlock(Me, [GetType](), "LabelUpdated", "$telerik.$('.lblError').show().animate({ opacity: 0.9 }, 2000).fadeOut('slow');", True)
    End Sub


    Private Sub ClearError()
        Label1.Text = ""
        ScriptManager.RegisterClientScriptBlock(Me, [GetType](), "LabelUpdated", "$telerik.$('.lblError').show().animate({ opacity: 0.9 }, 2000).fadeOut('slow');", True)
    End Sub

    Protected Sub RadScheduler1_AppointmentInsert(sender As Object, e As SchedulerCancelEventArgs)
        If ExceedsLimit(e.Appointment) Then
            e.Cancel = True
            RegisterScript()
        Else
            ClearError()
            e.Cancel = False
        End If
    End Sub

    Protected Sub RadScheduler1_AppointmentUpdate(sender As Object, e As AppointmentUpdateEventArgs)
        If AppointmentsOverlap(e.ModifiedAppointment) Then
            e.Cancel = True
            RegisterScript()
        Else
            ClearError()
            e.Cancel = False
        End If
    End Sub

    Protected Sub RadScheduler1_RecurrenceExceptionCreated(sender As Object, e As RecurrenceExceptionCreatedEventArgs)
        If AppointmentsOverlap(e.ExceptionAppointment) Then
            e.Cancel = True
            RegisterScript()
        Else
            ClearError()
        End If
    End Sub

    Protected Sub RadScheduler1_AppointmentDataBound(sender As Object, e As SchedulerEventArgs)

        e.Appointment.Visible = False
        FilterAppointment(e.Appointment)

        Dim colorAttribute As String = e.Appointment.Attributes("AppointmentColor")
        If Not String.IsNullOrEmpty(colorAttribute) Then
            Dim colorValue As Integer
            If Integer.TryParse(colorAttribute, colorValue) Then
                Dim appointmentColor As Color = Color.FromArgb(colorValue)
                e.Appointment.BackColor = appointmentColor
                e.Appointment.BorderColor = Color.Black
                e.Appointment.BorderStyle = BorderStyle.Solid
                e.Appointment.BorderWidth = Unit.Pixel(1)
            End If
        End If

        e.Appointment.ToolTip = e.Appointment.Subject + ": " + e.Appointment.Description



    End Sub

    Protected Sub RadButton1_Click(sender As Object, e As System.EventArgs) Handles Filter.Click
        Me.RadScheduler1.Rebind()
    End Sub

    Private Sub FilterAppointment(ByVal appointment As Appointment)

        For Each Item As RadListBoxItem In Me.lstResources.Items
            Dim F As Resource
            F = appointment.Resources.GetResource("Resource", CType(Item.Value, Integer))

            If F IsNot Nothing Then
                If Item.Checked Then
                    appointment.Visible = True
                Else
                    appointment.Visible = False
                End If
            End If
        Next
    End Sub


 
#Region "Resources"

    Protected Sub lstResources_DataBound(sender As Object, e As System.EventArgs) Handles lstResources.DataBound

        For Each Item In Me.lstResources.Items
            Item.Checked = True
        Next

    End Sub

    Protected Sub lstResources_ItemCheck(sender As Object, e As Telerik.Web.UI.RadListBoxItemEventArgs) Handles lstResources.ItemCheck
        Me.RadScheduler1.Rebind()
    End Sub

    Private Sub CheckAll()

    End Sub

#End Region

#Region "Menu"
    Protected Sub RadToolBar1_ButtonClick(sender As Object, e As Telerik.Web.UI.RadToolBarEventArgs) Handles RadToolBar1.ButtonClick
        Select Case e.Item.Text
            Case "Shaftsbury Sq"
                Response.Redirect("Default.aspx?LocationId=2&Title=Shaftuty Sq Resources")
            Case "Ormeau Road"
                Response.Redirect("Default.aspx?LocationId=1&Title=Ormeau Road Resources")
            Case "Shaftsbury Sq Report"
                Response.Redirect("Reports.aspx?LocationId=1&Ormeau Road")
            Case "Ormeau Road Report"
                Response.Redirect("Reports.aspx?LocationId=2&Title=Shaftuty Sq Resources")
        End Select
    End Sub
#End Region




    Protected Sub Print_Click(sender As Object, e As EventArgs)
        Dim LocationId As String = Request.QueryString("LocationId")

        Select Case LocationId
            Case "1"
                Response.Redirect("Reports.aspx?LocationId=1&Ormeau Road")
            Case "2"
                Response.Redirect("Reports.aspx?LocationId=2&Title=Shaftuty Sq Resources")
        End Select

    End Sub


End Class
