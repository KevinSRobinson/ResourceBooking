Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Telerik.Web.UI

Partial Class RadSchedulerAdvancedFormResourceControl
    Inherits System.Web.UI.UserControl


    Private _type As String


    Protected ReadOnly Property Appointment() As Appointment
        Get
            Dim container As SchedulerFormContainer = DirectCast(BindingContainer, SchedulerFormContainer)
            Return container.Appointment
        End Get
    End Property

    Protected ReadOnly Property Owner() As RadScheduler
        Get
            Return Appointment.Owner
        End Get
    End Property


    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)> _
    Public Property Value() As Object
        Get
            If ResourceValue.SelectedValue <> "NULL" Then
                Return DeserializeResourceKey(ResourceValue.SelectedValue)
            End If

            Return ""
        End Get


        Set(ByVal value As Object)
        End Set
    End Property

    <Bindable(BindableSupport.Yes, BindingDirection.OneWay)> _
    Public Property Label() As String
        Get
            Return ResourceLabel.Text
        End Get

        Set(ByVal value As String)
            ResourceLabel.Text = value
        End Set
    End Property

    <Bindable(BindableSupport.Yes, BindingDirection.OneWay)> _
    Public Property Skin() As String
        Get
            Return ResourceValue.Skin
        End Get

        Set(ByVal value As String)
            ResourceValue.Skin = value
        End Set
    End Property

    <Bindable(BindableSupport.Yes, BindingDirection.OneWay)> _
    Public Property Type() As String
        Get
            Return _type
        End Get

        Set(ByVal value As String)
            _type = value
        End Set
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If ResourceValue.Items.Count = 0 Then
            PopulateResources()
            MarkSelectedResource()
        End If
    End Sub

    ''' <summary>
    ''' Populates the resource options.
    ''' </summary>
    Private Sub PopulateResources()
        For Each res As Resource In GetResources(Type)
            ResourceValue.Items.Add(New RadComboBoxItem(res.Text, SerializeResourceKey(res.Key)))
        Next
    End Sub

    ''' <summary>
    ''' Marks (selects) the resource currently associated with the appointment.
    ''' </summary>
    Private Sub MarkSelectedResource()
        ResourceValue.Items.Insert(0, New RadComboBoxItem("-", "NULL"))

        Dim res As Resource = Appointment.Resources.GetResourceByType(Type)
        If res IsNot Nothing Then
            ResourceValue.SelectedValue = SerializeResourceKey(res.Key)
        End If
    End Sub

    ''' <summary>
    ''' Gets a list of the resources of the specified type.
    ''' </summary>
    ''' <param name="resType">Type of the resources to search for.</param>
    ''' <returns>A list of the resources of the specified type.</returns>
    Private Function GetResources(ByVal resType As String) As IEnumerable(Of Resource)
        Dim availableResources As New List(Of Resource)()
        Dim resources As IEnumerable(Of Resource) = Owner.Provider.GetResourcesByType(Owner, resType)

        For Each res As Resource In resources
            If IncludeResource(res) Then
                availableResources.Add(res)
            End If
        Next

        Return availableResources
    End Function

    ''' <summary>
    ''' Returns a boolean value, indicating if a resource should be included in the list.
    ''' You can use this method to define your custom filtering logic.
    ''' </summary>
    ''' <param name="res">The resource to filter.</param>
    ''' <returns>A boolean value, indicating if a resource should be included in the list.</returns>
    Private Function IncludeResource(ByVal res As Resource) As Boolean
        Return res.Available OrElse ResourceIsInUse(res)
    End Function

    ''' <summary>
    ''' Returns a boolean value, indicating if a resource is already assigned to the appointment.
    ''' </summary>
    ''' <param name="res">The resource to check.</param>
    ''' <returns>A boolean value, indicating if a resource is already assigned to the appointment.</returns>
    Private Function ResourceIsInUse(ByVal res As Resource) As Boolean
        For Each appRes As Resource In Appointment.Resources
            If res = appRes Then
                Return True
            End If
        Next

        Return False
    End Function

    ''' <summary>
    ''' Serializes a resource key using LosFormatter.
    ''' </summary>
    ''' <remarks>
    '''	The resource keys need to be serialized as they can be arbitrary objects.
    ''' </remarks>
    ''' <param name="key">The key to serialize.</param>
    ''' <returns>The serialized key.</returns>
    Private Function SerializeResourceKey(ByVal key As Object) As String
        Dim output As New LosFormatter()
        Dim writer As New StringWriter()
        output.Serialize(writer, key)
        Return writer.ToString()
    End Function

    ''' <summary>
    ''' Deserializes a resource key using LosFormatter.
    ''' </summary>
    ''' <remarks>
    '''	The resource keys need to be serialized as they can be arbitrary objects.
    ''' </remarks>
    ''' <param name="key">The key to deserialize.</param>
    ''' <returns>The deserialized key.</returns>
    Private Function DeserializeResourceKey(ByVal key As String) As Object
        Dim input As New LosFormatter()
        Return input.Deserialize(key)
    End Function


End Class
