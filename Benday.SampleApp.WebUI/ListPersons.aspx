<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPersons.aspx.cs" Inherits="Benday.SampleApp.WebUI.ListPersons" %>

<%@ Register Src="MainMenuControl.ascx" TagName="MainMenuControl" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Person List</title>
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MainMenuControl ID="MainMenuControl1" runat="server" />
            &nbsp;<br />
            <h3>Person List</h3>           
            <asp:GridView ID="m_grid" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" EmptyDataText="No person records found." DataSourceID="m_dataSource">
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditPerson.aspx?Id={0}"
                        Text="(edit)" />
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="Phone" />
                    <asp:BoundField DataField="EmailAddress" HeaderText="Email" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                </Columns>
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="Gainsboro" />
            </asp:GridView>
            <p>
                Row Count: 
            <asp:Label ID="m_labelRowCount" runat="server" Text=""></asp:Label>
                <asp:ObjectDataSource ID="m_dataSource" runat="server"
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllPersons"
                    TypeName="Benday.SampleApp.Core.DatasetUtility"></asp:ObjectDataSource>
            </p>
        </div>
    </form>
</body>
</html>
