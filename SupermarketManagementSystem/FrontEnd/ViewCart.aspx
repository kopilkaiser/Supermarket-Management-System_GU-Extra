<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet"/>
</head>
<body style="border-style:grove; border-color: inherit; border-width: medium; position:relative; left: 498px; top: 192px; height: 384px; width: 959px;">

    <form id="form1" runat="server">
       
        <p>
            <asp:HyperLink ID="hyptempInventory" runat="server" NavigateUrl="~/tempInventory.aspx">Continue Shopping</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hypCheckOut" runat="server" ForeColor="#CC3300" NavigateUrl="~/ViewCart.aspx">*checkout*</asp:HyperLink>
        </p>
       
    </form>
 
</body>
</html>
