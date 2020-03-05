<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementStaff.aspx.cs" Inherits="OrderManagementStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" Height="155px" Width="688px"></asp:ListBox>
        </div>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            Please Enter a OrderId&nbsp; <asp:TextBox ID="txtboxOrderId" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
&nbsp;
            <asp:Button ID="btnDisplayall" runat="server" Text="Display All" OnClick="btnDisplayall_Click" />
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
&nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="height: 26px" />
&nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
    </form>
</body>
</html>
