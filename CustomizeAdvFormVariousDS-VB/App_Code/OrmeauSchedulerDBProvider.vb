
Imports System
Imports System.Collections.Generic
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports Microsoft.VisualBasic
Imports System.Data

Public Class OrmeauSchedulerDBProvider
    Inherits DbSchedulerProviderBase

    Private _Locations As IDictionary(Of Integer, Resource)
    Private _Resources As IDictionary(Of Integer, Resource)


    Public Property LocationID As Integer


    Private ReadOnly Property Locations() As IDictionary(Of Integer, Resource)
        Get
            If _Locations Is Nothing Then
                _Locations = New Dictionary(Of Integer, Resource)()
                For Each Location As Resource In LoadLocations()
                    _Locations.Add(DirectCast(Location.Key, Integer), Location)
                Next
            End If

            Return _Locations
        End Get
    End Property

    Private ReadOnly Property Resources() As IDictionary(Of Integer, Resource)
        Get
            _Resources = New Dictionary(Of Integer, Resource)()
            For Each Resource As Resource In LoadResources()
                _Resources.Add(DirectCast(Resource.Key, Integer), Resource)
            Next

            Return _Resources
        End Get
    End Property

    Public Overloads Overrides Function GetAppointments(shedulerInfo As ISchedulerInfo) As IEnumerable(Of Appointment)


        Dim appointments As New List(Of Appointment)()

        Using conn As DbConnection = OpenConnection()
            Dim cmd As DbCommand = DbFactory.CreateCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM [ResourceBookings] WHERE LocationID =" + Me._LocationID.ToString

            Using reader As DbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim apt As New Appointment()
                    apt.ID = reader("ClassID")
                    apt.Subject = Convert.ToString(reader("Subject"))
                    apt.Description = Convert.ToString(reader("Description"))
                    apt.Attributes("AppointmentColor") = Convert.ToString(reader("AppointmentColor"))
                    apt.Attributes("TeaCoffee") = Convert.ToBoolean(reader("TeaCoffee"))
                    apt.Attributes("TeaCoffeeTime") = Convert.ToString(reader("TeaCoffeeTime"))
                    apt.Attributes("BookingLength") = Convert.ToString(reader("BookingLength"))

                    apt.Attributes("RoomStyle") = Convert.ToString(reader("RoomStyle"))

                    If Not IsDBNull(reader("EveningBooking")) Then
                        apt.Attributes("EveningBooking") = Convert.ToBoolean(reader("EveningBooking"))
                    Else
                        apt.Attributes("EveningBooking") = False
                    End If

                    apt.Attributes("NoPeople") = Convert.ToString(reader("NoPeople"))


                    apt.Start = DateTime.SpecifyKind(Convert.ToDateTime(reader("Start")), DateTimeKind.Utc)
                    apt.[End] = DateTime.SpecifyKind(Convert.ToDateTime(reader("End")), DateTimeKind.Utc)
                    apt.RecurrenceRule = Convert.ToString(reader("RecurrenceRule"))
                    apt.TimeZoneID = "Dateline Standard Time"
                    apt.RecurrenceParentID = If(reader("RecurrenceParentId") Is DBNull.Value, Nothing, reader("RecurrenceParentId"))

                    If Not reader("Reminder") Is DBNull.Value Then
                        Dim reminders As IList(Of Reminder) = Reminder.TryParse(Convert.ToString(reader("Reminder")))
                        If Not reminders Is Nothing Then
                            apt.Reminders.AddRange(reminders)
                        End If
                    End If

                    If apt.RecurrenceParentID <> Nothing Then
                        apt.RecurrenceState = RecurrenceState.Exception
                    ElseIf apt.RecurrenceRule <> String.Empty Then
                        apt.RecurrenceState = RecurrenceState.Master
                    End If

                    LoadResources(apt)
                    appointments.Add(apt)

                End While
            End Using
        End Using
        Return appointments
    End Function

    Public Overloads Overrides Sub Insert(shedulerInfo As ISchedulerInfo, appointmentToInsert As Appointment)
        If Not PersistChanges Then
            Return
        End If

        Using conn As DbConnection = OpenConnection()
            Using tran As DbTransaction = conn.BeginTransaction()
                Dim cmd As DbCommand = DbFactory.CreateCommand()
                cmd.Connection = conn
                cmd.Transaction = tran

                PopulateAppointmentParameters(cmd, appointmentToInsert)

                cmd.CommandText = "	INSERT	INTO [ResourceBookings] ([Subject], [Start], [End], [LocationId], [RecurrenceRule], [RecurrenceParentID], [Reminder], [Description], [AppointmentColor], [TimeZoneID], [TeaCoffee], [TeaCoffeeTime], [BookingLength], [EveningBooking], [NoPeople], [RoomStyle]) VALUES	" + _
                                                                "   (@Subject, @Start, @End, @LocationId, @RecurrenceRule, @RecurrenceParentID, @Reminder, @Description, @AppointmentColor, @TimeZoneID, @TeaCoffee, @TeaCoffeeTime, @BookingLength, @EveningBooking, @NoPeople, @RoomStyle)"
                If TypeOf DbFactory Is SqlClientFactory Then
                    cmd.CommandText += Environment.NewLine + "SELECT SCOPE_IDENTITY()"
                Else
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "SELECT @IDENTITY"
                End If
                Dim identity As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                FillClassResources(appointmentToInsert, cmd, identity)

                tran.Commit()
            End Using
        End Using
    End Sub

    Public Overloads Overrides Sub Update(shedulerInfo As ISchedulerInfo, appointmentToUpdate As Appointment)
        If Not PersistChanges Then
            Return
        End If

        Using conn As DbConnection = OpenConnection()
            Using tran As DbTransaction = conn.BeginTransaction()
                Dim cmd As DbCommand = DbFactory.CreateCommand()
                cmd.Connection = conn
                cmd.Transaction = tran

                PopulateAppointmentParameters(cmd, appointmentToUpdate)

                cmd.Parameters.Add(CreateParameter("@ClassID", appointmentToUpdate.ID))
                cmd.CommandText = "UPDATE [ResourceBookings] SET [Subject] = @Subject, [Description] = @Description,  [Reminder] = @Reminder, [AppointmentColor] = @AppointmentColor, [Start] = @Start, [End] = @End, [LocationId] = " + Me._LocationID.ToString + ", [RecurrenceRule] = @RecurrenceRule, [RecurrenceParentID] = @RecurrenceParentID, [TimeZoneID] = @TimeZoneID, TeaCoffee = @TeaCoffee, TeaCoffeeTime = @TeaCoffeeTime, BookingLength = @BookingLength, EveningBooking = @EveningBooking, NoPeople =@NoPeople, RoomStyle =@RoomStyle WHERE [ClassID] = @ClassID"
                cmd.ExecuteNonQuery()

                ClearClassResources(appointmentToUpdate.ID, cmd)

                FillClassResources(appointmentToUpdate, cmd, appointmentToUpdate.ID)

                tran.Commit()
            End Using
        End Using
    End Sub

    Public Overloads Overrides Sub Delete(shedulerInfo As ISchedulerInfo, appointmentToDelete As Appointment)
        If Not PersistChanges Then
            Return
        End If

        Using conn As DbConnection = OpenConnection()
            Dim cmd As DbCommand = DbFactory.CreateCommand()
            cmd.Connection = conn

            Using tran As DbTransaction = conn.BeginTransaction()
                cmd.Transaction = tran

                ClearClassResources(appointmentToDelete.ID, cmd)

                cmd.Parameters.Clear()
                cmd.Parameters.Add(CreateParameter("@ClassID", appointmentToDelete.ID))
                cmd.CommandText = "DELETE FROM [ResourceBookings] WHERE [ClassID] = @ClassID"
                cmd.ExecuteNonQuery()

                tran.Commit()
            End Using
        End Using
    End Sub

    Public Overloads Overrides Function GetResources(schedulerInfo As ISchedulerInfo) As IDictionary(Of ResourceType, IEnumerable(Of Resource))
        Dim resCollection As New Dictionary(Of ResourceType, IEnumerable(Of Resource))()

        'resCollection.Add(New ResourceType("Location", False), Locations.Values)
        resCollection.Add(New ResourceType("Resource", True), Resources.Values)

        Return resCollection
    End Function

    Public Overloads Overrides Function GetResourceTypes(owner As RadScheduler) As IEnumerable(Of ResourceType)
        Dim resourceTypes As ResourceType() = New ResourceType(2) {}
        resourceTypes(0) = New ResourceType("Location", False)
        resourceTypes(1) = New ResourceType("Resource", True)

        Return resourceTypes
    End Function

    Public Overloads Overrides Function GetResourcesByType(owner As RadScheduler, resourceType As String) As IEnumerable(Of Resource)
        Select Case resourceType
            Case "Location"
                Return Locations.Values

            Case "Resource"
                Return Resources.Values
            Case Else

                Throw New InvalidOperationException("Unknown resource type: " + resourceType)
        End Select
    End Function

    Private Sub LoadResources(apt As Appointment)
        Using conn As DbConnection = OpenConnection()
            Dim cmd As DbCommand = DbFactory.CreateCommand()
            cmd.Connection = conn

            cmd.Parameters.Add(CreateParameter("@ClassID", apt.ID))
            cmd.CommandText = "SELECT [LocationId] FROM [ResourceBookings] WHERE [ClassID] = @ClassID"
            Using reader As DbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim Location As Resource = Locations(Convert.ToInt32(reader("LocationId")))
                    apt.Resources.Add(Location)
                End If
            End Using

            cmd.Parameters.Clear()
            cmd.Parameters.Add(CreateParameter("@ClassID", apt.ID))
            cmd.CommandText = "SELECT * FROM [ClassResources] WHERE [ClassID] = @ClassID"

            Try
                Dim reader As DbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    If reader.HasRows Then
                        Dim int As Integer = Convert.ToInt32(reader("ResourceID"))
                        Dim Resource As Resource = Resources.Item(int)
                        apt.Resources.Add(Resource)
                    End If
                End While
            Catch ex As Exception
                ' Throw New Exception("Propble Loading ClassResources", ex)
            End Try

        End Using
    End Sub

    Private Function LoadLocations() As IEnumerable(Of Resource)
        Dim resources As New List(Of Resource)()

        Using conn As DbConnection = OpenConnection()
            Dim cmd As DbCommand = DbFactory.CreateCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT [LocationId], [Name], [Phone] FROM [Locations]"

            Using reader As DbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim res As New Resource()
                    res.Type = "Location"
                    res.Key = reader("LocationId")
                    res.Text = Convert.ToString(reader("Name"))
                    res.Attributes("Phone") = Convert.ToString(reader("Phone"))
                    resources.Add(res)
                End While
            End Using
        End Using

        Return resources
    End Function

    Private Function LoadResources() As IEnumerable(Of Resource)
        Dim resources As New List(Of Resource)()

        Using conn As DbConnection = OpenConnection()
            Dim cmd As DbCommand = DbFactory.CreateCommand()
            cmd.Connection = conn
            cmd.CommandText = "SELECT [ResourceID], [Name] FROM [Resources] WHERE [LocationID] =" + Me._LocationID.ToString

            Using reader As DbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim res As New Resource()
                    res.Type = "Resource"
                    res.Key = reader("ResourceID")
                    res.Text = Convert.ToString(reader("Name"))
                    resources.Add(res)
                End While
            End Using
        End Using

        Return resources
    End Function

    Private Sub FillClassResources(appointment As Appointment, cmd As DbCommand, classId As Object)

        For Each Resource As Resource In appointment.Resources.GetResourcesByType("Resource")
            cmd.Parameters.Clear()
            cmd.Parameters.Add(CreateParameter("@ClassID", classId))
            cmd.Parameters.Add(CreateParameter("@ResourceID", Resource.Key))

            cmd.CommandText = "INSERT INTO [ClassResources] ([ClassID], [ResourceID]) VALUES (@ClassID, @ResourceID)"
            cmd.ExecuteNonQuery()
        Next
    End Sub

    Private Sub ClearClassResources(classId As Object, cmd As DbCommand)
        cmd.Parameters.Clear()
        cmd.Parameters.Add(CreateParameter("@ClassID", classId))
        cmd.CommandText = "DELETE FROM [ClassResources] WHERE [ClassID] = @ClassID"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub PopulateAppointmentParameters(cmd As DbCommand, apt As Appointment)
        cmd.Parameters.Add(CreateParameter("@Subject", apt.Subject))
        cmd.Parameters.Add(CreateParameter("@Start", apt.Start))
        cmd.Parameters.Add(CreateParameter("@End", apt.[End]))
        cmd.Parameters.Add(CreateParameter("@Description", apt.Description))
        cmd.Parameters.Add(CreateParameter("@AppointmentColor", apt.Attributes("AppointmentColor")))
        cmd.Parameters.Add(CreateParameter("@TeaCoffee", apt.Attributes("TeaCoffee")))
        cmd.Parameters.Add(CreateParameter("@TeaCoffeeTime", apt.Attributes("TeaCoffeeTime")))
        cmd.Parameters.Add(CreateParameter("@RoomStyle", apt.Attributes("RoomStyle")))


        cmd.Parameters.Add(CreateParameter("@LocationId", Me._LocationID))

        Dim rrule As String = Nothing
        If apt.RecurrenceRule <> String.Empty Then
            rrule = apt.RecurrenceRule
        End If
        cmd.Parameters.Add(CreateParameter("@RecurrenceRule", rrule))

        Dim parentId As Object = Nothing
        If apt.RecurrenceParentID <> Nothing Then
            parentId = apt.RecurrenceParentID
        End If
        cmd.Parameters.Add(CreateParameter("@RecurrenceParentId", parentId))
        cmd.Parameters.Add(CreateParameter("@TimeZoneID", apt.TimeZoneID))
        cmd.Parameters.Add(CreateParameter("@Reminder", apt.Reminders.ToString()))


        cmd.Parameters.Add(CreateParameter("@BookingLength", apt.Attributes("BookingLength")))
        cmd.Parameters.Add(CreateParameter("@EveningBooking", apt.Attributes("EveningBooking")))
        cmd.Parameters.Add(CreateParameter("@NoPeople", apt.Attributes("NoPeople")))
    End Sub

End Class
