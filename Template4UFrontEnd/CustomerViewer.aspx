<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerViewer.aspx.cs" Inherits="Template4UFrontEnd.CustomerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Title">
            <h1 style="color:blue; text-align: center;">Customer Viewer</h1>
            <asp:Label ID="customerId" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="customerEmail" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="customerPassword" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="customerName" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="customerRegistrationDate" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="customerIsBusiness" runat="server" Text="Label"></asp:Label><br /><br />
        </div>
        <br />
    </form>
</body>
</html>
