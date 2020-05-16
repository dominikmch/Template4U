<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Template4UFrontEnd.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListCustomers" runat="server" Height="482px" Width="502px"></asp:ListBox>
            <br />
            <asp:Button ID="ViewCustomer" runat="server" Text="Customer" OnClick="ViewCustomer_OnClick"/>
        </div>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_OnClick"  Text="Add" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_OnClick" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_OnClick
            "  Text="Delete" />
        <br />
        <br />
        Chose the checkbox below to filter customers.&nbsp;&nbsp;
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Business client</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:CheckBox ID="CustomerBusiness" runat="server" />
            </div>
        </div>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_OnClick" Text="Apply " />
        &nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_OnClick"  Text="Clear" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
        </p>
    </form>
</body>
</html>
