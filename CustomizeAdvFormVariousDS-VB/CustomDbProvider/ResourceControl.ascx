<%@ Control Language="VB" AutoEventWireup="true" CodeFile="ResourceControl.ascx.vb" Inherits="RadSchedulerAdvancedFormResourceControl" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>



<asp:Label runat="server" ID="ResourceLabel" AssociatedControlID="ResourceValue" 
Text='<%# Label %>' CssClass="rsAdvResourceLabel" /><!--
--><telerik:RadComboBox runat="server" ID="ResourceValue" CssClass="rsAdvResourceValue" 
Skin='<%# Skin %>' />
