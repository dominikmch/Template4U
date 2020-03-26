<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewList.aspx.cs" Inherits="Template4UFrontEnd.ReviewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListReviews" runat="server" Height="482px" Width="502px"></asp:ListBox>
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
