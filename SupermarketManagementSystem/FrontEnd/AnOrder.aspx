<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="OrderId"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        </div>
        <p>
&nbsp;<asp:Label ID="Label2" runat="server" Text="InventoryId"></asp:Label>
&nbsp;<asp:TextBox ID="txtInventoryId" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="PurchasedDate"></asp:Label>
&nbsp;<asp:TextBox ID="txtPurchasedDate" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="ChkboxActive" runat="server" Text="Active" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK1" runat="server" OnClick="btnOK1_Click" Text="OK" style="height: 26px" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
