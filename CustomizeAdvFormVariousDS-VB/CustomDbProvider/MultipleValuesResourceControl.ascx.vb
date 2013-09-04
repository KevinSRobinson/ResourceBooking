Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Telerik.Web.UI

Partial Class RadSchedulerAdvancedFormMultipleValuesResourceControl
    Inherits System.Web.UI.UserControl
    Implements IValidator

    Private _type As String

    ''' <summary>
    ''' A modified CheckBoxList that renders an unordered list, instead of a table.
    ''' </summary>
    Protected Class SemanticCheckBoxList
        Inherits CheckBoxList
        Protected Overloads Overrides Sub Render(ByVal writer As HtmlTextWriter)
            writer.WriteBeginTag("ul")

            writer.WriteAttribute("class", "rsCheckBoxList")

            writer.Write(HtmlTextWriter.TagRightChar)

            For i As Integer = 0 To RepeatedItemCount - 1
                writer.RenderBeginTag(HtmlTextWriterTag.Li)
                RenderItem(ListItemType.Item, i, Nothing, writer)
                writer.RenderEndTag()
            Next

            writer.WriteEndTag("ul")
        End Sub
    End Class

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

    Protected ReadOnly Property ResourceValue() As SemanticCheckBoxList
        Get
            Return DirectCast(FindControl("ResourceValue"), SemanticCheckBoxList)
        End Get
    End Property

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)> _
    Public Property Value() As Object
        Get
            Return ExtractResourceValues()
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
    Public Property Type() As String
        Get
            Return _type
        End Get

        Set(ByVal value As String)
            _type = value
        End Set
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim resourceValue As New SemanticCheckBoxList()
        resourceValue.ID = "ResourceValue"
        ResourceValuesPlaceHolder.Controls.Add(resourceValue)

        If resourceValue.Items.Count = 0 Then
            PopulateResources()
            MarkSelectedResources()
        End If
    End Sub

    ''' <summary>
    ''' Populates the resource options.
    ''' </summary>
    Private Sub PopulateResources()
        For Each res As Resource In GetResources(Type)
            ResourceValue.Items.Add(New ListItem(res.Text, SerializeResourceKey(res.Key)))
        Next
    End Sub

    ''' <summary>
    ''' Marks (selects) the resources currently associated with the appointment.
    ''' </summary>
    Private Sub MarkSelectedResources()
        For Each res As Resource In Appointment.Resources.GetResourcesByType(Type)
            ResourceValue.Items.FindByValue(SerializeResourceKey(res.Key)).Selected = True
        Next
    End Sub

    ''' <summary>
    ''' Gets a list of the resources of the specified type.
    ''' </summary>
    ''' <param name="resType">Type of the resources to search for.</param>
    ''' <returns>A list of the resources of the specified type.</returns>
    Private Function GetResources(ByVal resType As String) As IEnumerable(Of Resource)
        Dim availableResources As New List(Of Resource)()
        Dim resources As IEnumerable(Of Resource) = Owner.Resources.GetResourcesByType(resType)

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
    ''' Extracts the resource values from the CheckBoxList.
    ''' </summary>
    ''' <returns>
    ''' Depending the number of selected resources it returns either
    ''' a single key or an array of resource keys.
    ''' </returns>
    Private Function ExtractResourceValues() As Object
        Dim resourceKeys As New ArrayList()
        For Each li As ListItem In ResourceValue.Items
            If li.Selected AndAlso li.Value <> "NULL" Then
                resourceKeys.Add(DeserializeResourceKey(li.Value))
            End If
        Next

        Select Case resourceKeys.Count
            Case 0
                Return String.Empty

            Case 1
                Return resourceKeys(0)
            Case Else

                Return resourceKeys.ToArray()
        End Select
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



    Public Property LocationId As Integer
     
#Region "Validation"

#End Region
    Public Property ErrorMessage As String Implements System.Web.UI.IValidator.ErrorMessage
        Get
            Return "Please Select a Resource"
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property IsValid As Boolean Implements System.Web.UI.IValidator.IsValid
        Get
            Dim o As String = Me.ExtractResourceValues.ToString
            If o.Length = 0 Then
                Return False
            Else
                Return True
            End If
        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Sub Validate() Implements System.Web.UI.IValidator.Validate

        Dim CheckedListBox As Object
        CheckedListBox = Me.ResourceValuesPlaceHolder.Controls(0)

    End Sub


End Class
