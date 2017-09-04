<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenuControl.ascx.cs" Inherits="Benday.SampleApp.WebUI.MainMenuControl" %>
<asp:HyperLink ID="HyperLink1" NavigateUrl="~/ListPersons.aspx" runat="server">Person Manager</asp:HyperLink>
|
<asp:HyperLink ID="m_linkNewPerson" runat="server" NavigateUrl="~/EditPerson.aspx?Id=-1">Create New Person</asp:HyperLink>
|
<asp:HyperLink
    ID="HyperLink2" NavigateUrl="~/AjaxCalculator.aspx" runat="server">Ajax Calculator</asp:HyperLink>