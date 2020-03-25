<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="Template4UFrontEnd.Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 260px; width: 286px">
            ReviewId&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextReviewId" runat="server" OnTextChanged="TextReviewId_TextChanged"></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" />
            <br />
            Grade&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextGrade" runat="server" OnTextChanged="TextGrade_TextChanged" style="margin-left: 14px" Width="111px"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            Description
            <asp:TextBox ID="TextReviewComment" runat="server" OnTextChanged="TextReviewComment_TextChanged"></asp:TextBox>
            <br />
            Date Added
            <asp:TextBox ID="TextDateAdded" runat="server" Height="22px" Width="128px" OnTextChanged="TextDateAdded_TextChanged"></asp:TextBox>
            <br />
            UserId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextUserId" runat="server" Height="19px" Width="126px" OnTextChanged="TextUserId_TextChanged"></asp:TextBox>
            <br />
            ProductId&nbsp;&nbsp;
            <asp:TextBox ID="TextProductId" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="Edited" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" />
            <br />
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="ButtonOK_Click" style="margin-top: 0px" Text="OK" Width="56px" />
            <asp:Button ID="Button1" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
