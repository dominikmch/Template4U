<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Template4UFrontEnd.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of available products</title>
</head>
<body style="background-color: lightsteelblue">
    <div style="text-align: center;">
        <h1 style="color: blue; text-align: center;">All available products</h1>
        <br />
        Please select the product and chose an option below
                    <br />
        <br />

        <form id="form1" runat="server">

            <div>
                <asp:ListBox ID="ListProducts" runat="server" Height="482px" Width="502px"></asp:ListBox>
                <br /><br />
                <asp:Button ID="viewproduct" runat="server" Text="View Product" OnClick="Button1_Click" />

            </div>

            <br />

            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />

            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Edit" />

            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />

            <br />

            <br />

            Enter a Product Id&nbsp;&nbsp;

        <asp:TextBox ID="txtFilter" runat="server" Height="20px">0</asp:TextBox>

            <br />

            <br />

            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply " />

            &nbsp;

        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />

            <p>

                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

            </p>
    </div>
</form>
</html>
