<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagement.aspx.cs" Inherits="OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" DataValueField="OrderId" Height="177px" Width="329px"></asp:ListBox>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Please Enter a Order ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnDisplay" runat="server" Text="Display All" />
&nbsp;<p>
            <asp:Button ID="BtnAdd" runat="server" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEdit" runat="server" Height="26px" Text="Edit" Width="56px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnDelete" runat="server" Height="31px" Text="Delete" />
        </p>
    </form>
</body>
</html>
