<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerViewer.aspx.cs" Inherits="Template4UFrontEnd.CustomerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Profile Details</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
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
<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
