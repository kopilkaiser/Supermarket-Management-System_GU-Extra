<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartItemDetails.aspx.cs" Inherits="InventoryDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="StyleSheet.css" rel="stylesheet"/>

 


 
    <style type="text/css">
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            font-size: medium;
            margin-left: 68px;
        }
    </style>

 


 
</head>
<body>
    <article>
        <form runat="server" style="text-align:center;">
                           <strong>
                           <br />
                           <asp:Label ID="Label1" runat="server" Text="Name" CssClass="auto-style2"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" ReadOnly="True" CssClass="auto-style2"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label3" runat="server" Text="Price" CssClass="auto-style2"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" CssClass="auto-style2"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label2" runat="server" Text="Quantity" CssClass="auto-style2"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtQuantity" runat="server" CssClass="auto-style2">1</asp:TextBox>
                           <br />
                           <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Add to Cart" CssClass="auto-style3" Height="45px" Width="120px" />
   

        </form>
           </article>
    

</body>
</html>
