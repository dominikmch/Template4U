<%@ Page Language="C#" AutoEventWireup="true" Inherits="Template4UFrontEnd.customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>It works</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 260px; width: 231px">
        Grade&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 14px" Width="111px"></asp:TextBox>
        &nbsp;&nbsp;
        <br />
        Description
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 9px" Width="115px"></asp:TextBox>
        <br />
        Date Added
        <asp:TextBox ID="TextBox3" runat="server" Height="22px" Width="128px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="Edited" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="OkButton" runat="server" OnClick="Button1_Click" style="margin-top: 0px" Text="OK" Width="56px" />
        <asp:Button ID="Button1" runat="server" Text="Cancel" />
    </div>
</form>
</body>
</html>
