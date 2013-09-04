<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb"
    Inherits="RadSchedulerAdvancedForm" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="scheduler" TagName="AdvancedForm" Src="AdvancedForm.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/tr/xhtml11/dtd/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="Style/StyleSheet.css" rel="stylesheet" />
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
    <style type="text/css">
       
         
        .lblError
        {
                      background: #DDDDDD;
    border: 1px solid #ccc;
    padding: 0px 15px;
    -moz-border-radius: 2em 0;
    -webkit-border-radius: 10px;
    margin-top:10px;
    margin-left:20px;
     width: 333px;
    border-left-width: 0px; 
    font-family:Arial;
    border-top-width: 0px;
    color: #e00000;   
        }


        .lblTitle
        {
            float:left;
            clear:both;
            font-family:Arial;
            font-size:26px;
        }
    </style>
    <title></title>
</head>
<body class="BODY">
    <form id="Form1" method="post" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/CustomDbProvider/AdvancedForm.js" />
            <%--Needed for JavaScript IntelliSense in VS2010--%>
            <%--For VS2008 replace RadScriptManager with ScriptManager--%>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
        </Scripts>
    </telerik:RadScriptManager>

        <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
        </telerik:RadWindowManager>



    <script type="text/javascript">
        //<![CDATA[

        // Dictionary containing the advanced template client object
        // for a given RadScheduler instance (the control ID is used as key).
        var schedulerTemplates = {};

        function schedulerFormCreated(scheduler, eventArgs) {
            // Create a client-side object only for the advanced templates
            var mode = eventArgs.get_mode();
            if (mode == Telerik.Web.UI.SchedulerFormMode.AdvancedInsert ||
					mode == Telerik.Web.UI.SchedulerFormMode.AdvancedEdit) {
                // Initialize the client-side object for the advanced form
                var formElement = eventArgs.get_formElement();
                var templateKey = scheduler.get_id() + "_" + mode;
                var advancedTemplate = schedulerTemplates[templateKey];
                if (!advancedTemplate) {
                    // Initialize the template for this RadScheduler instance
                    // and cache it in the schedulerTemplates dictionary
                    var schedulerElement = scheduler.get_element();
                    var isModal = scheduler.get_advancedFormSettings().modal;
                    advancedTemplate = new window.SchedulerAdvancedTemplate(schedulerElement, formElement, isModal);
                    advancedTemplate.initialize();

                    schedulerTemplates[templateKey] = advancedTemplate;

                    // Remove the template object from the dictionary on dispose.
                    scheduler.add_disposing(function () {
                        schedulerTemplates[templateKey] = null;
                    });
                }

                // Are we using Web Service data binding?
                if (!scheduler.get_webServiceSettings().get_isEmpty()) {
                    // Populate the form with the appointment data
                    var apt = eventArgs.get_appointment();
                    var isInsert = mode == Telerik.Web.UI.SchedulerFormMode.AdvancedInsert;
                    advancedTemplate.populate(apt, isInsert);
                }
            }
        }

        //]]>
    </script>




        <div>

             <telerik:RadToolBar runat="server" ID="RadToolBar1" OnButtonClick="RadToolBar1_ButtonClick"
                EnableRoundedCorners="True" EnableShadows="True" Skin="Office2010Blue">
                <Items>
                    <telerik:RadToolBarButton runat="Server" Text="Shaftsbury Sq" Font-Size="Large">
                    </telerik:RadToolBarButton>
                    <telerik:RadToolBarButton runat="Server" Text="Ormeau Road" Font-Size="Large">
                    </telerik:RadToolBarButton>
                 



                    <telerik:RadToolBarDropDown ImageUrl="~/Images/printer1.png">
                <Buttons>
                            <telerik:RadToolBarButton runat="server" Text="Shaftsbury Sq Report">
                            </telerik:RadToolBarButton>
                            <telerik:RadToolBarButton runat="server" Text="Ormeau Road Report">
                            </telerik:RadToolBarButton>
                </Buttons>
            </telerik:RadToolBarDropDown>


   
                 
                </Items>
            </telerik:RadToolBar>

             <asp:Label ID="Label1" runat="server" CssClass="lblError" Text=""></asp:Label>
        </div>
   


        
<div>


    <div class="exampleContainer">
    
           

    <h1><asp:Label Name="lblTitle"  ID="lblTitle" runat="server" CssClass="lblTitle"></asp:Label></h1>
    <asp:Label Name="lblMessage"  ID="lblMessage" CssClass="lblError" runat="server"></asp:Label>
        <br /><br />



 <div>
    <div class="module" style="Width:18%;float:left; border-style:solid">
        <h3 style="margin:0px; font-size:12px; font-family:Arial">Select Resources To Display</h3>
        <div class="bd">
          <telerik:RadListBox ID="lstResources" runat="server"
                            DataValueField="ResourceID" DataTextField="Name"
                            DataSourceID="Resources"  CheckBoxes="True"  Skin="Web20" 
                                style="left: 0px" >
                       </telerik:RadListBox>
            <telerik:RadButton ID="Filter" runat="server" Text="OK" Skin="Web20" ></telerik:RadButton> 
          <telerik:RadButton ID="btnSelectAll" runat="server" Text="Check All" Skin="Web20"  OnClick="CheckAll"/>
          <telerik:RadButton ID="btnUnSelectAll" runat="server" Text="Uncheck All" Skin="Web20"   OnClick="UnCheckAll"/>
        </div>
   </div>
            


        <telerik:RadScheduler runat="server" ID="RadScheduler1"  AllowEdit="true"
            Style="Width:70%;"
            AppointmentStyleMode="Default" Skin="WebBlue" ShowAllDayRow="False" 
            EnableCustomAttributeEditing="true" 
            OnAppointmentDataBound="RadScheduler1_AppointmentDataBound" OnClientFormCreated="schedulerFormCreated"
            CustomAttributeNames="AppointmentColor,TeaCoffee,TeaCoffeeTime, NoPeople,EveningBooking,BookingLength, RoomStyle" EnableDescriptionField="True"
            OnAppointmentInsert="RadScheduler1_AppointmentInsert"
            OnAppointmentUpdate="RadScheduler1_AppointmentUpdate"
            OnRecurrenceExceptionCreated="RadScheduler1_RecurrenceExceptionCreated"
             StartInsertingInAdvancedForm="True" AllowDelete="True">
            <AdvancedForm Modal="true" EnableTimeZonesEditing="true"/>
            <Reminders Enabled="true" />
            <AdvancedEditTemplate>
                <scheduler:AdvancedForm runat="server" ID="AdvancedEditForm1" Mode="EditNewAppointment" Subject='<%# Bind("Subject") %>'
                    Description='<%# Bind("Description") %>' Start='<%# Bind("Start") %>' End='<%# Bind("End") %>'
                    RecurrenceRuleText='<%# Bind("RecurrenceRule") %>' Reminder='<%# Bind("Reminder") %>'
                    AppointmentColor='<%# Bind("AppointmentColor") %>'  TeaCoffee='<%# Bind("TeaCoffee") %>' 
                  RoomStyle='<%# Bind("RoomStyle") %>' 
                    TeaCoffeeTime='<%# Bind("TeaCoffeeTime") %>' NoPeople='<%# Bind("NoPeople") %>'  
                     BookingLength='<%# Bind("BookingLength")%>' EveningBooking='<%# Bind("EveningBooking") %>'
                    ResourceID='<%# Bind("Resource") %>' TimeZoneID='<%# Bind("TimeZoneID") %>'/> 
            </AdvancedEditTemplate>
            <AdvancedInsertTemplate>
                <scheduler:AdvancedForm runat="server" ID="AdvancedInsertForm1" Mode="Insert" Subject='<%# Bind("Subject") %>'
                    Start='<%# Bind("Start") %>' End='<%# Bind("End") %>' Description='<%# Bind("Description") %>'
                    RecurrenceRuleText='<%# Bind("RecurrenceRule") %>' Reminder='<%# Bind("Reminder") %>'
                    AppointmentColor='<%# Bind("AppointmentColor") %>' TeaCoffee='<%# Bind("TeaCoffee") %>' 
                    TeaCoffeeTime='<%# Bind("TeaCoffeeTime") %>'  NoPeople='<%# Bind("NoPeople") %>'  
                     BookingLength='<%# Bind("BookingLength")%>' EveningBooking='<%# Bind("EveningBooking") %>'
                     RoomStyle='<%# Bind("RoomStyle") %>' 
                    ResourceID='<%# Bind("Resource")%>' TimeZoneID='<%# Bind("TimeZoneID") %>'/>
            </AdvancedInsertTemplate>
            <TimeSlotContextMenuSettings EnableDefault="true" />
            <AppointmentContextMenuSettings EnableDefault="true" />
			<Localization AdvancedTimeZone="Time zone:" Reminder="Reminder:" />
        </telerik:RadScheduler>
</div>





        <asp:SqlDataSource ID="Resources" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ResourceBookingCalendarConnectionString %>" 
            SelectCommand="SELECT ResourceID, Name, LocationID FROM Resources WHERE (LocationID = @LocationID)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="LocationID"  QueryStringField="LocationID" />
            </SelectParameters>
        </asp:SqlDataSource>

    </form>
</body>
</html>
