<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnCustomer.aspx.cs" Inherits="Template4UFrontEnd.AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server" style="width: 500px; height: 500px">
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>CustomerID:</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:TextBox ID="TextCustomerID" runat="server" placeholder="Customer ID number" TextMode="Number"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Email: </label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:TextBox ID="TextCustomerEmail" runat="server" Enabled="False" placeholder="Customer email address" TextMode="Email"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Name:</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:TextBox ID="TextCustomerName" runat="server" Enabled="False" placeholder="Customer name" ></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Password:</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:TextBox ID="TextCustomerPassword" runat="server" Enabled="False" placeholder="Customer password" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Customer registration date</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:TextBox ID="CustomerDateTime" runat="server" Enabled="False" placeholder="Customer Registration Date" TextMode="DateTime"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label>Business client</label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:CheckBox ID="CustomerBusiness" runat="server" Enabled="False"/>
            </div>
        </div>
        <div class="form-row">
            <div class="col" style="margin: 10px">
                <label><b>Admin mode: </b></label>
            </div>
            <div class="col" style="margin: 10px">
                <asp:CheckBox ID="Editable" runat="server" Enabled="True" AutoPostBack="True" OnCheckedChanged="Editable_OnCheckedChanged"/>
            </div>
        </div>
        <div class="form-row" align="right">
            <div class="col" style="margin: 10px">
                <asp:Button runat="server" class="btn btn-primary" OnClick="ButtonOk_Click" Text="Submit"/>
            </div>
        </div>
        <div class="form-row" align="center" >
            <div class="col" style="margin: 10px">
                <br/>
                    <div class="alert alert-danger" role="alert" >
                        <asp:Label runat="server" ID="warningID"/>
                    </div>
            </div>
        </div>
    </form>

<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
