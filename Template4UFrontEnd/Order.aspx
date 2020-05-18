<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Template4UFrontEnd.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 260px; width: 286px">
               OrderId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextOrderId" runat="server" ></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" />
            <br />
            OrderlineId&nbsp;
            <asp:TextBox ID="TextOrderlineId" runat="server" ></asp:TextBox>
            <br />
            Promo Code&nbsp;
            <asp:TextBox ID="TextPromoCode" runat="server" ></asp:TextBox>
            <br />
            Date Placed&nbsp;&nbsp;
            <asp:TextBox ID="TextDatePlaced" runat="server" ></asp:TextBox>
            <br />
            Is order completed:&nbsp;
            <asp:CheckBox ID="chkIsCompleted" runat="server"/>
            <br />
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonOk" runat="server" style="margin-top: 0px" OnClick="ButtonOK_Click" Text="OK" Width="56px" />
            <asp:Button ID="ButtonCancel" runat="server" OnClick="ButtonCancel_Click" Text="Cancel" />


        </div>
    </form>
</body>
</html>
