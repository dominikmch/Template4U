<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Template4UFrontEnd.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListCustomers" runat="server" Height="482px" Width="502px"/>
            <br />
            <asp:Button ID="ViewCustomer" runat="server" Text="Customer" OnClick="ViewCustomer_OnClick"/>
        </div>
        <br />
        <asp:Button ID="btnAdd" runat="server"  Text="Add" />
        <asp:Button ID="btnUpdate" runat="server" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_OnClick
            "  Text="Delete" />
        <br />
        <br />
        Enter a Product Id&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server" Height="20px">0</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply " />
        &nbsp;
        <asp:Button ID="btnClear" runat="server"  Text="Clear" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
        </p>
    </form>
</body>
</html>
