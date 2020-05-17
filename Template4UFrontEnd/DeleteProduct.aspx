<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="Template4UFrontEnd.DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightsteelblue">
    <form id="form1" runat="server">
        <h1 style="color: blue; text-align:center;">Delete product:</h1>
        <div style="text-align:center ;">
        <div style="height: 150px; width: 402px; position: center; display:inline-block; ">
            Are you sure you want to delete this product?
        <br /><br />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
