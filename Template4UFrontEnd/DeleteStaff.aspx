<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStaff.aspx.cs" Inherits="Template4UFrontEnd.DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" Width="56px" />
            <asp:Button ID="btnNo" runat="server" Text="No" Width="51px" />
        </div>
    </form>
</body>
</html>
