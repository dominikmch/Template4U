<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Template4UFrontEnd.OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" Height="550px" Width="600px"></asp:ListBox>
            <br />
            <asp:Button ID="viewOrder" runat="server" Text="View Order" OnClick="ButtonView_Click" />
        </div>
        <br />

        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
         Tick the checkbox below to filter orders.&nbsp;&nbsp;
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Is order completed</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:CheckBox ID="OrderCompleted" runat="server" />
            </div>
        </div>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply " />
&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
        </p>
    </form>
</body>
</html>
