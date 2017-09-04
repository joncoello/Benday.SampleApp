<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxCalculator.aspx.cs" Inherits="Benday.SampleApp.WebUI.AjaxCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Text="Value 1"></asp:Label>
            &nbsp;<asp:TextBox ID="m_textValue1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Value 2"></asp:Label>
            &nbsp;<asp:TextBox ID="m_textValue2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="m_btnCalculateSum" runat="server" Text="Calculate Sum" 
                onclick="m_btnCalculateSum_Click" />
            <p>
                Sum:
            <asp:Label ID="m_labelSum" runat="server" Text="0"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    &nbsp;<asp:UpdateProgress ID="UpdateProgress1" runat="server" 
        AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <br />
            Dude, those are big numbers.&nbsp; This may take a moment.<br />
        </ProgressTemplate>
    </asp:UpdateProgress>
    </form>
</body>
</html>
