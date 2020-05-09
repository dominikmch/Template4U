<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AStaff.aspx.cs" Inherits="Template4UFrontEnd.AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff ID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnFind" runat="server" Text="Find" />
            <br />
            Staff Role
            <asp:TextBox ID="txtStaffRole" runat="server"></asp:TextBox>
            <br />
            Starting Date
            <asp:TextBox ID="txtStartingDate" runat="server"></asp:TextBox>
            <br />
            Salary&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="cbisEmployed" runat="server" Text="Employed" />
            <br />
            <br />
            [lblError]<br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="70px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
