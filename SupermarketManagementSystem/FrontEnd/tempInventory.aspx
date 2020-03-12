﻿<%@ Page Language="C#" %>
<%@ Import Namespace="ClassLibrary"%>
<!DOCTYPE html>

<script runat="server">

    clsCart MyCart = new clsCart();

     protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
        //if the cart is null then we need to initialise it
        if (MyCart == null)
        {
            MyCart = new clsCart();
        }
        //then you can display how many items are in your cart
        lblCartCount.Text = MyCart.Products.Count.ToString();
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"]= MyCart;
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>

    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            
                  <%
                      clsInventoryCollection MyInventories = new clsInventoryCollection();
                      MyInventories.ReportByCategory("");
                      Int32 Index = 0;
                      Int32 RecordCount = MyInventories.Count;


                  %><table border="1">
                      <%
                   %> <tr><% 
                               %><td style="font-weight:bold"><%
                                         Response.Write("InventoryId");

                    %></td><%
                    %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Name");
                     %></td><%
                   %></tr><%
                        
                  while(Index<RecordCount)
                  {
                    %><tr><%
                    %><td>
                        <a href="InventoryDetails.aspx?InventoryId=<% Response.Write(MyInventories.InventoryList[Index].InventoryId);  %>&?x=y">
                            <%   
                     Response.Write("ADD TO CART");
                    %></a></td><%
                    %><td><%
                     Response.Write(MyInventories.InventoryList[Index].Name);
                     %></td><%    

                                %><td><%
                     Response.Write(MyInventories.InventoryList[Index].Price);
                     %></td><%  
                     %> </tr><%
                      Index++;
                    }
                    %></table><%
                  %>
        </div>
            Your cart has
        <asp:Label ID="lblCartCount" runat="server"></asp:Label>
    &nbsp;items.</form>
</body>
</html>
