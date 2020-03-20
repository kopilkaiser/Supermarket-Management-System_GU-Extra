<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="BrowseProducts1.aspx.cs" Inherits="BrowseProducts1" %>
<%@ Import Namespace="ClassLibrary"%>

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
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style9 {
        font-size: medium;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>

        Browse Products here. You have
        <br />
        <asp:Label ID="lblCartCount" runat="server" ForeColor="Red"></asp:Label>
        &nbsp;items<br />
            <asp:HyperLink ID="hypViewCart" runat="server" NavigateUrl="~/ViewCart1.aspx">View Cart</asp:HyperLink>
            
        &nbsp;</div>
    
    <div> _____<%
                      clsInventoryCollection MyInventories = new clsInventoryCollection();
                      MyInventories.ReportByCategory("");
                      Int32 Index = 0;
                      Int32 RecordCount = MyInventories.Count;


                  %>____<table border="1" class="auto-style8">
                      <%
                   %> <tr><% 

                    %><td style="font-weight:bold" class="auto-style9"><%
                                         Response.Write("");
                    %></td><%

                    %><td style="font-weight:bold; text-align:center" class="auto-style4"><%
                     Response.Write("Name");
                     %></td><%

                     %><td style="font-weight:bold; text-align:center" class="auto-style4"><%
                     Response.Write("Price Per Item");
                     %></td><%

                   %></tr><%
                        
                  while(Index<RecordCount)
                  {
                    %><tr><%
                    %><td class="auto-style9">
                        <a href="CartItemDetails1.aspx?InventoryId=<% Response.Write(MyInventories.InventoryList[Index].InventoryId);%>&Price=<%Response.Write(MyInventories.InventoryList[Index].Price);%>&Name=<% Response.Write(MyInventories.InventoryList[Index].Name); %>">
                            <%   
                     Response.Write("Select Quantity");
                    %></a></td><%
                    %><td class="auto-style4"><%
                     Response.Write(MyInventories.InventoryList[Index].Name);
                     %></td><%    

                                %><td class="auto-style4"><%
                     Response.Write(MyInventories.InventoryList[Index].Price);
                     %></td><%  
                     %> </tr><%
                      Index++;
                    }
                    %></table><%
                  %>
        </div>
</asp:Content>

