<%@ Control Language="VB" AutoEventWireup="true" CodeFile="AdvancedForm.ascx.vb"
    Inherits="RadSchedulerAdvancedFormAdvancedForm" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=7.0.13.426, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="scheduler" TagName="ResourceControl" Src="~/CustomDbProvider/ResourceControl.ascx" %>
<%@ Register TagPrefix="scheduler" TagName="MultipleValuesResourceControl" Src="~/CustomDbProvider/MultipleValuesResourceControl.ascx" %>
<div class="rsAdvancedEdit rsAdvancedModal" style="position: relative">
    <div class="rsModalBgTopLeft">
    </div>
    <div class="rsModalBgTopRight">
    </div>
    <div class="rsModalBgBottomLeft">
    </div>
    <div class="rsModalBgBottomRight">
    </div>
    <%-- Title bar. --%>
    
     
    <div class="rsAdvTitle">
        <%-- The rsAdvInnerTitle element is used as a drag handle when the form is modal. --%>
        <h1 class="rsAdvInnerTitle">
            <%= If((Me.Mode.ToString() = "Edit"), Owner.Localization.AdvancedEditAppointment, Owner.Localization.AdvancedNewAppointment)
            %></h1>
        <asp:LinkButton runat="server" ID="AdvancedEditCloseButton" CssClass="rsAdvEditClose" 
            CommandName="Cancel" CausesValidation="false" ToolTip='<%# Owner.Localization.AdvancedClose %>'>
			<%= Owner.Localization.AdvancedClose %>

        </asp:LinkButton>
    </div>

    <Style>
        .PrintButton{
            float:right;
            height:30px;
            width:30px;
        }

    </Style>
    <div class="rsAdvContentWrapper">
        <%-- Scroll container - when the form height exceeds MaximumHeight scrollbars will appear on this element--%>
        <div class="rsAdvOptionsScroll">
            <asp:Panel runat="server" ID="AdvancedEditOptionsPanel" CssClass="rsAdvOptions">
                <asp:Panel runat="server" ID="BasicControlsPanel" CssClass="rsAdvBasicControls" OnDataBinding="BasicControlsPanel_DataBinding">
                      <telerik:RadButton ID="hlPrint" runat="server"   Height="40px" Width="40px" OnClick="hlPrint_Click" CssClass="PrintButton" 
             Image-ImageUrl="~/Images/printer1.png" Skin="Web20"></telerik:RadButton>
                    <div style="margin-left:50px; width:100%">
                        
                              <telerik:RadTextBox runat="server" ID="lblCourseID" Rows="3" Width="65px" Label="ID" 
                                 Text='<%# Eval("ID") %>'  Skin="Forest" ReadOnly="true" BackColor="LightGray"/>
                    </div>


                    <telerik:RadTextBox runat="server" ID="SubjectText" Width="100%" 
                    Label='<%# Owner.Localization.AdvancedSubject + ":" %>'
                        EnableSingleInputRendering="false" Skin="Forest" />
                    <asp:RequiredFieldValidator runat="server" ID="SubjectValidator" ControlToValidate="SubjectText"
                        EnableClientScript="true" Display="None" CssClass="rsValidatorMsg" />
                          
                       

                        <div style="visibility: collapse">
                            <asp:textbox runat="server" ID="UserNameTextBox" 
                            Text="User Name"   />
                        </div>

                           <telerik:RadTextBox runat="server" ID="DescriptionText" TextMode="MultiLine" Columns="50"
                    Rows="3" Width="100%" Label='<%# Owner.Localization.AdvancedDescription + ":" %>'
                    Text='<%# Eval("Description") %>' EnableSingleInputRendering="false" Skin="Forest" />
                   
                      <telerik:RadComboBox runat="server" Visible="false" ID="TimeZonesDropDown" Width="0"
                                Height="0"
                                Label="<%# Owner.Localization.AdvancedTimeZone%>" Skin='<%# Owner.Skin %>'>
                            </telerik:RadComboBox>
                  
                        
                            <asp:CheckBox Font-Bold="true" runat="server" ID="AllDayEvent" CssClass="rsAdvChkWrap" Checked="false" />
                    
                  <div style="width:110px;white-space: nowrap;clear:both"> 
                           <label style="font-weight:bold" runat="server">Start Date</label>
                      
                           <telerik:RadDatePicker runat="server" ID="StartDate" CssClass="rsAdvDatePicker"
                                    Width="100px" SharedCalendarID="SharedCalendar" Skin='<%# Owner.Skin %>' Culture='<%# Owner.Culture %>'
                                    MinDate="1900-01-01">
                                    <DatePopupButton Visible="true" />
                                    <DateInput ID="DateInput2" runat="server" DateFormat='<%# Owner.AdvancedForm.DateFormat %>'
                                        EmptyMessageStyle-CssClass="riError" EmptyMessage=" " EnableSingleInputRendering="false" />
                                </telerik:RadDatePicker>


                           <telerik:RadTimePicker runat="server" ID="StartTime" CssClass="rsAdvTimePicker"  
                                Width="100" Skin='<%# Owner.Skin %>' Culture='<%# Owner.Culture %>' Font-Bold="True">
                                <DateInput ID="DateInput3" runat="server" EmptyMessageStyle-CssClass="riError" EmptyMessage=" " 
                                    EnableSingleInputRendering="true" />
                                <TimePopupButton Visible="true" />
                                <TimeView ID="TimeView1" runat="server" Width="90px"  Columns="2" ShowHeader="false" StartTime="08:00"
                                    EndTime="18:00" Interval="00:30" />
                            </telerik:RadTimePicker>
                  </div> 
                        
                          
                      <div style="width:110px;white-space: nowrap;"> 
                         <label style="font-weight:bold" id="Label1" runat="server">End Date</label>
                      
                     <telerik:RadDatePicker  runat="server" ID="EndDate" CssClass="rsAdvDatePicker"
                                    Width="100px" SharedCalendarID="SharedCalendar" Skin='<%# Owner.Skin %>' Culture='<%# Owner.Culture %>'
                                    MinDate="1900-01-01">
                                    <DatePopupButton Visible="True" />
                                    <DateInput ID="DateInput4" runat="server" Font-Bold="true" DateFormat='<%# Owner.AdvancedForm.DateFormat %>'
                                        EmptyMessageStyle-CssClass="riError" EmptyMessage=" " EnableSingleInputRendering="false" />
                                </telerik:RadDatePicker>
                           
                      <telerik:RadTimePicker Font-Bold="true" runat="server" ID="EndTime" CssClass="rsAdvTimePicker"
                                Width="100px" Skin='<%# Owner.Skin %>' Culture='<%# Owner.Culture %>'>
                                <DateInput ID="DateInput5" Font-Bold="true" runat="server" EmptyMessageStyle-CssClass="riError" EmptyMessage=" "
                                    EnableSingleInputRendering="false" />
                                <TimePopupButton Visible="True" />
                                <TimeView ID="TimeView2" runat="server" Columns="2" ShowHeader="false" StartTime="08:00"
                                    EndTime="18:00" Interval="00:30" />
                     </telerik:RadTimePicker>
                       
                  </div>
              


                    <div style="visibility: hidden">
                        <telerik:RadComboBox runat="server" ID="ReminderDropDown" Width="120px" Skin='<%# Owner.Skin %>'
                            Label="<%# Owner.Localization.Reminder%>">
                            <Items>
                                <telerik:RadComboBoxItem Text='<%# Owner.Localization.ReminderNone %>' Value="" />
                                <telerik:RadComboBoxItem Text='<%# "0 " + Owner.Localization.ReminderMinutes %>'
                                    Value="0" />
                                <telerik:RadComboBoxItem Text='<%# "5 " + Owner.Localization.ReminderMinutes %>'
                                    Value="5" />
                                <telerik:RadComboBoxItem Text='<%# "10 " + Owner.Localization.ReminderMinutes %>'
                                    Value="10" />
                                <telerik:RadComboBoxItem Text='<%# "15 " + Owner.Localization.ReminderMinutes %>'
                                    Value="15" />
                                <telerik:RadComboBoxItem Text='<%# "30 " + Owner.Localization.ReminderMinutes %>'
                                    Value="30" />
                                <telerik:RadComboBoxItem Text='<%# "1 " + Owner.Localization.ReminderHour %>' Value="60" />
                                <telerik:RadComboBoxItem Text='<%# "2 " + Owner.Localization.ReminderHours %>' Value="120" />
                                <telerik:RadComboBoxItem Text='<%# "3 " + Owner.Localization.ReminderHours %>' Value="180" />
                                <telerik:RadComboBoxItem Text='<%# "4 " + Owner.Localization.ReminderHours %>' Value="240" />
                                <telerik:RadComboBoxItem Text='<%# "5 " + Owner.Localization.ReminderHours %>' Value="300" />
                                <telerik:RadComboBoxItem Text='<%# "6 " + Owner.Localization.ReminderHours %>' Value="360" />
                                <telerik:RadComboBoxItem Text='<%# "7 " + Owner.Localization.ReminderHours %>' Value="420" />
                                <telerik:RadComboBoxItem Text='<%# "8 " + Owner.Localization.ReminderHours %>' Value="480" />
                                <telerik:RadComboBoxItem Text='<%# "9 " + Owner.Localization.ReminderHours %>' Value="540" />
                                <telerik:RadComboBoxItem Text='<%# "10 " + Owner.Localization.ReminderHours %>' Value="600" />
                                <telerik:RadComboBoxItem Text='<%# "11 " + Owner.Localization.ReminderHours %>' Value="660" />
                                <telerik:RadComboBoxItem Text='<%# "12 " + Owner.Localization.ReminderHours %>' Value="720" />
                                <telerik:RadComboBoxItem Text='<%# "18 " + Owner.Localization.ReminderHours %>' Value="1080" />
                                <telerik:RadComboBoxItem Text='<%# "1 " + Owner.Localization.ReminderDays %>' Value="1440" />
                                <telerik:RadComboBoxItem Text='<%# "2 " + Owner.Localization.ReminderDays %>' Value="2880" />
                                <telerik:RadComboBoxItem Text='<%# "3 " + Owner.Localization.ReminderDays %>' Value="4320" />
                                <telerik:RadComboBoxItem Text='<%# "4 " + Owner.Localization.ReminderDays %>' Value="5760" />
                                <telerik:RadComboBoxItem Text='<%# "1 " + Owner.Localization.ReminderWeek %>' Value="10080" />
                                <telerik:RadComboBoxItem Text='<%# "2 " + Owner.Localization.ReminderWeeks %>' Value="20160" />
                            </Items>
                        </telerik:RadComboBox>
                    </div>
                    <asp:RequiredFieldValidator runat="server" ID="StartDateValidator" ControlToValidate="StartDate"
                        EnableClientScript="true" Display="None" CssClass="rsValidatorMsg" />
                    <asp:RequiredFieldValidator runat="server" ID="StartTimeValidator" ControlToValidate="StartTime"
                        EnableClientScript="true" Display="None" CssClass="rsValidatorMsg" />
                    <asp:RequiredFieldValidator runat="server" ID="EndDateValidator" ControlToValidate="EndDate"
                        EnableClientScript="true" Display="None" CssClass="rsValidatorMsg" />
                    <asp:RequiredFieldValidator runat="server" ID="EndTimeValidator" ControlToValidate="EndTime"
                        EnableClientScript="true" Display="None" CssClass="rsValidatorMsg" />
                    <asp:CustomValidator runat="server" ID="DurationValidator" ControlToValidate="StartDate"
                        EnableClientScript="false" Display="Dynamic" CssClass="rsValidatorMsg rsInvalid"
                        OnServerValidate="DurationValidator_OnServerValidate" />
                </asp:Panel>











<%-- ShaftsBurySqSpecific--%>
<asp:Panel runat="server" ID="ShaftsBurySqSpecific" Width="100%"  BorderColor="Black"  BorderStyle="Solid">


    <style>
         .sTable
        {
            width:100%;
        }
        .col1
        {
            width:50% !important;
            float:left;
        }
        .col2
        {
            width:50% !important;
            float:left;
        }
        .fieldLabel
        {
            margin-top:5px;
            font-family:'Segoe UI';
            font-weight:bold;
            font-size:14px;
            width:50%;
            float: left;
        }
        .field
        {
             margin-top:5px;
            font-family:'Segoe UI';
            font-weight:bold;
            font-size:14px;
            width:50%;
            float: left;
        }
        .parent
        {
             width:70%;
             float: left;
        }
        .tab
        {
            margin-left:80px;
        }
        .header
        {
            background-color:#353775;
            color: white;
            font-family: Arial;
            font-size: 14px;        
        }
        .spacer
        {
           height:10px;

        }
        .alignleft
        {
            text-align:left;
        }
    </style>



<div class="sTable" >
   <div class="header">
       Shaftsbursy Sq
   </div>
<div class="col1">
    
    <div class="parent">
       <div class="fieldLabel">
            Room Style
       </div>
       <div class="field">
            <telerik:RadComboBox ID="RoomStyleComboBox" runat="server" 
            Visible="True"  Skin="WebBlue">
                <Items>
                <telerik:RadComboBoxItem Text="BoardRoom Style" Value="BoardRoom Style" />
                <telerik:RadComboBoxItem Text="Theatre Style" Value="Theatre Style" />
                </Items>
            </telerik:RadComboBox>
        </div>
    </div>

         
    <div class="parent">
          <div class="fieldLabel">
              Booking Charge
          </div>
          <div class="field">
            <telerik:RadComboBox ID="cmbBookingLength" runat="server" Skin="WebBlue" Visible="True">
                <Items>
                <telerik:RadComboBoxItem Text="Half Day" Value="Half Day" />
                <telerik:RadComboBoxItem Text="Full Day" Value="Full Day" />
                </Items>
            </telerik:RadComboBox>
         </div>
    </div>
        
   <div class="parent">
      <div class="fieldLabel">
            Evening Booking
          </div>

       <div class="field">
            <asp:CheckBox ID="chkEveningBooking" runat="server" CssClass="alignleft" Text=" " />
       </div>
    </div>
</div>
            

<div class="col2">
 
     <div class="parent">
        <div class="fieldLabel">
               Tea/Coffee
        </div>
        <div class="field">
             <asp:CheckBox runat="server" ID="TeaCoffeeCheckBox" Text=" "   CssClass="alignleft" Width="180px"/>
        </div>
      </div>
        
   
       <div class="parent">
        <div class="fieldLabel">
            No Of People
        </div>
        <div class="field">
             <telerik:RadNumericTextBox ID="txtNoPeople" runat="server" Width="80px" Skin="WebBlue" DataType="System.Integer"></telerik:RadNumericTextBox>
        </div>
    </div>


       <div class="parent">
            <div class="fieldLabel">
                 Tea Coffee Time
            </div>
            <div class="field">
                <telerik:RadTextbox ID="TeaCoffeeTextbox" runat="server" Width="80px" Skin="WebBlue"></telerik:RadTextbox>
            </div>
         </div>

  

</div>



</div>







            
           
            



   
</asp:Panel>
                


 <div style="float:right;margin-right:250px;margin-top:20px">Color                     
                    <telerik:RadColorPicker ID="AppointmentColorPicker" runat="server" CssClass="rsAdvResourceValue"
                        ShowIcon="true" PaletteModes="WebPalette" Height="22px">
                    </telerik:RadColorPicker></div>  

                <asp:Panel runat="server" ID="AdvancedControlsPanel" CssClass="rsAdvMoreControls" Width="710px">
                    
                   
                      <asp:Panel runat="server" ID="ResourceControls">
                        <%-- RESOURCE CONTROLS --%>
                        <ul class="rsResourceControls" style="margin:0px">
                            <li >
                                <!-- Resource controls should follow the convention Res[Resource Name] for ID -->
                                <div style="visibility: collapse;height:0;padding:0px;margin:0px">
                                  <scheduler:ResourceControl runat="server" 
                                      ID="ResLocation" Type="Location" Label="Location:" 
                                    Skin='<%# Owner.Skin %>' />
                                </div>
                              
                            </li>
                            <li>
                             
                            <asp:CustomValidator runat="server" id="ResourceValidator" Name="ResourceValidator"
                            ControlToValidate="ResourceTextbox" ValidateEmptyText="true" 
                            ErrorMessage="Please Select a Resource" Text=" " Font-Bold="True" /> 

                            <asp:textbox runat="server" ID="ResourceTextbox"  Visible="false" Text="TEST"/><br />
                            <scheduler:MultipleValuesResourceControl runat="server" ID="ResResource" 
                                 Type="Resource"
                                    Label="Resources:"     />
                            </li>
                            <!-- Optionally add more ResourceControl instances here -->
                        </ul>
                            </asp:Panel>
              </asp:Panel>

                <span class="rsAdvResetExceptions">
                    <asp:LinkButton runat="server" ID="ResetExceptions" OnClick="ResetExceptions_OnClick" />
                </span>
                <telerik:RadSchedulerRecurrenceEditor runat="server" ID="AppointmentRecurrenceEditor"                    Skin="Forest" />
                <asp:HiddenField runat="server" ID="OriginalRecurrenceRule" />



                <telerik:RadCalendar runat="server" ID="SharedCalendar" Skin='Forest' CultureInfo='<%# Owner.Culture %>'
                    ShowRowHeaders="false" RangeMinDate="1900-01-01">
                    <WeekendDayStyle CssClass="rcWeekend" />
                    <CalendarTableStyle CssClass="rcMainTable" />
                    <OtherMonthDayStyle CssClass="rcOtherMonth" />
                    <OutOfRangeDayStyle CssClass="rcOutOfRange" />
                    <DisabledDayStyle CssClass="rcDisabled" />
                    <SelectedDayStyle CssClass="rcSelected" />
                    <DayOverStyle CssClass="rcHover" />
                    <FastNavigationStyle CssClass="RadCalendarMonthView RadCalendarMonthView_Forest" />
                    <ViewSelectorStyle CssClass="rcViewSel" />
                </telerik:RadCalendar>
            </asp:Panel>

        </div>




        <asp:Panel runat="server" ID="ButtonsPanel" CssClass="rsAdvancedSubmitArea">
            <div class="rsAdvButtonWrapper">
                <asp:LinkButton runat="server" ID="UpdateButton" CssClass="rsAdvEditSave">
					<span><%= Owner.Localization.Save %></span>
                </asp:LinkButton>
                <asp:LinkButton runat="server" ID="CancelButton" CssClass="rsAdvEditCancel" CommandName="Cancel"
                    CausesValidation="false">
					<span><%= Owner.Localization.Cancel %></span>
                </asp:LinkButton>
            </div>

           
        </asp:Panel>

       
   
    </div>
</div>




