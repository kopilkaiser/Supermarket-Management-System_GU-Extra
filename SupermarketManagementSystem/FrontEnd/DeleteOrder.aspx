﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete the Order<br />
        </div>
    &nbsp;<asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click1" />
&nbsp;<asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
