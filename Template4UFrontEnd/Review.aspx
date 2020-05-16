<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="Template4UFrontEnd.Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Template4u Review</title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
</head>
<body style="background-color:burlywood">
    <form id="form1" runat="server">
        <h1 style="color: blue; text-align:center;">Add or search for review here!</h1>
        <div style="text-align:center ;">
        <div style="height: 260px; width: 402px; position: center; display:inline-block">
            ReviewId&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextReviewId" runat="server" OnTextChanged="TextReviewId_TextChanged"></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" style="margin-left:5px;"/>
            <br />
            <br />
            Add a review below.<br />
            <br />
            Grade&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="TextGrade" runat="server" OnTextChanged="TextGrade_TextChanged" style="margin-left: 14px" Width="111px"></asp:TextBox>

            <br />
            Description<br />

            <asp:TextBox ID="TextReviewComment" runat="server" OnTextChanged="TextReviewComment_TextChanged" Height="126px" Width="185px"></asp:TextBox>
            <br />
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
            <br />
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
