<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="Template4UFrontEnd.DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Do you want to proceed and remove this item?
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_OnClick" Text="yes" />
        &nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_OnClick" Text="no" />
    </form>
</body>
</html>
