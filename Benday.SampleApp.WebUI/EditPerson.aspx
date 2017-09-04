<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPerson.aspx.cs" Inherits="Benday.SampleApp.WebUI.EditPerson" %>

<%@ Register Src="MainMenuControl.ascx" TagName="MainMenuControl" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MainMenuControl ID="MainMenuControl1" runat="server" />
            <h3>Person Editor</h3>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <table>
                <tr>
                    <td>Id:</td>
                    <td>
                        <asp:Label ID="m_labelId" runat="server" Style="font-family: 'Segoe UI'" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td>
                        <asp:TextBox ID="m_textFirstName" runat="server" Style="font-family: 'Segoe UI'"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <asp:TextBox ID="m_textLastName" runat="server" Style="font-family: 'Segoe UI'"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phone Number:</td>
                    <td>
                        <asp:TextBox ID="m_textPhone" runat="server" Style="font-family: 'Segoe UI'"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email Address:</td>
                    <td>
                        <asp:TextBox ID="m_textEmailAddress" runat="server" Style="font-family: 'Segoe UI'"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Is Active:</td>
                    <td>
                        <asp:CheckBox ID="m_chkIsActive" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="m_btnSave" runat="server" Style="font-family: 'Segoe UI'" Text="Save"
                            OnClick="m_btnSave_Click" Width="120px" />
                    </td>
                    <td align="right">
                        <asp:Button ID="m_btnCancel" runat="server" Style="font-family: 'Segoe UI'" Text="Cancel" Width="120px" OnClick="m_btnCancel_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        <asp:Button ID="m_btnDelete" runat="server" Style="font-family: 'Segoe UI'" Text="Delete" Width="120px" OnClick="m_btnDelete_Click" /></td>                    
                </tr> 
            </table>

        </div>
    </form>
</body>
</html>
