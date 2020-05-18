<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderViewer.aspx.cs" Inherits="Template4UFrontEnd.OrderViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:blue; text-align: center;">Order Viewer</h1>
            <asp:Label ID="lblOrderId" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="OrderlineId" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="PromoCode" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="DatePlaced" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="IsCompleted" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go Back" />
        </div>
    </form>
</body>
</html>
