<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Reports.aspx.vb" Inherits="Reports" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=7.0.13.426, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

        <style type="text/css">
       
         
        .report
        {
            float:left;
            clear:both;
            font-family:Arial;
            font-size:26px;
            width:100% !important;
        }
        .menu
        {
            float:left;
            clear:both;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>


           

             <telerik:RadToolBar runat="server" ID="RadToolBar1" OnButtonClick="RadToolBar1_ButtonClick" CssClass="menu"
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

        
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="849px" CssClass="report"
            BorderColor="#0099FF" BorderStyle="Solid"></telerik:ReportViewer>
       
  

    </form>
</body>
</html>
