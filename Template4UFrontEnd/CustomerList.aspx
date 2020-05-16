<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Template4UFrontEnd.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server" style="padding: 20px; height: 700px; width: 600px">
        <div>
            <asp:ListBox ID="ListCustomers" runat="server" Height="482px" Width="502px" >
            </asp:ListBox>
            <br />
            <div class="row">
                <div class="col">
                    <asp:Button ID="ViewCustomer" runat="server" Text="Customer Profile" class="btn btn-info" OnClick="ViewCustomer_OnClick"/>
                </div>
                <div class="col">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_OnClick" class="btn btn-secondary" Text="Add" />
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_OnClick" class="btn btn-secondary" Text="Edit" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_OnClick" class="btn btn-warning"  Text="Delete" />
                </div>
            </div>
            
        </div>
        <br />

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
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_OnClick" class="btn btn-primary" Text="Apply " />
        &nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_OnClick" class="btn btn-secondary" Text="Clear" />
        <p>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </p>
    </form>
<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
