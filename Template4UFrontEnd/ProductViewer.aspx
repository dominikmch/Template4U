<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductViewer.aspx.cs" Inherits="Template4UFrontEnd.ProductViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ProductList Viewer</title>
</head>

<body style="background-color:lightsteelblue">

    <form id="form1" runat="server">

        <div class="Title">

        <h1 style="color:blue; text-align: center;">Product List Viewer</h1>

            <asp:Label ID="ProductName" runat="server" Text="ProductName"></asp:Label><br /><br />

            <asp:Label ID="ProductDescription" runat="server" Text="ProductDescription"></asp:Label><br /><br />

            <asp:Label ID="Price" runat="server" Text="Price"></asp:Label><br /><br />

            <asp:Label ID="DateAdded" runat="server" Text="DateAdded"></asp:Label><br /><br />

            <asp:Label ID="isAvailable" runat="server" Text="isAvailable"></asp:Label><br /><br />

            </div>

            <br />
    </form>
</body>
</html>
