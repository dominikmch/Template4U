<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Template4UFrontEnd.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Template4u ProductList</title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
</head>
<body style="background-color:lightsteelblue">
    <form id="form1" runat="server">
        <h1 style="color: blue; text-align:center;">Search product:</h1>
        <div style="text-align:center ;">
        <div style="height: 150px; width: 402px; position: center; display:inline-block; ">
            Enter an ID of the product:<br /><br />
            <asp:TextBox ID="TextProductId" runat="server" ></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" style="margin-left:5px;"/>
            <div style="margin-left: 25px;">
        <h1 style="color: blue; text-align:center;">Add or edit product:</h1>
            <br />
            Product Name (Max. 50 chars):
            <br /><br />
            <asp:TextBox ID="TextProductName" runat="server"></asp:TextBox>            <br />
            <br />
            Product Description (Max. 500 words):
            <br /><br />
            <asp:TextBox ID="TextProductDescription" runat="server"  Height="126px" Width="185px" TextMode="MultiLine"></asp:TextBox>       
            <br /><br />
            Price (Max. 500):
            <asp:TextBox ID="TextPrice" runat="server" Height="22px" Width="128px" ></asp:TextBox>
            <br /><br />
            Date Added (DD/MM/YYYY):
            <asp:TextBox ID="TextDateAdded" runat="server" Height="22px" Width="128px" ></asp:TextBox>
            <br /><br />
            Availability (True or False):
            <asp:TextBox ID="TextisAvailable" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="OkButton" runat="server" OnClick="ButtonOK_Click" style="margin-top: 0px" Text="OK" Width="56px" />
            <asp:Button ID="Button1" runat="server" Text="Cancel" />
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
        </div>
            </div>
    </form>
</body>
</html>
