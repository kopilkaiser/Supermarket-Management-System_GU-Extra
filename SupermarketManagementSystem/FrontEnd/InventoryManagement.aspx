<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InventoryManagement.aspx.cs" Inherits="InventoryManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BackColor="Aqua" Height="575px">
                <asp:ListBox ID="lstInventories" runat="server" Height="312px" Width="759px"></asp:ListBox>
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
                <br />
                Please Enter a Category<br />
                <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnApply" runat="server" Text="Apply" Width="126px" />
                <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="108px" />
                <br />
                <br />
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="74px" />
                &nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" Width="68px" OnClick="btnEdit_Click" />
                &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="78px" />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
