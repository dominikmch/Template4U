﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteReview.aspx.cs" Inherits="Template4UFrontEnd.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="yes" />
&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="no" />
    </form>
</body>
</html>
