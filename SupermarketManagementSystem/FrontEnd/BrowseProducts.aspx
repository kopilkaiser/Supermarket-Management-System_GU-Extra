﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="BrowseProducts.aspx.cs" Inherits="BrowseProducts
    " %>
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
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: center;
        }

        .auto-style2{
            position:fixed;
        }
        .auto-style8 {
            position: fixed;
            color: #000099;
            left: 494px;
            top: 128px;
        }
        .auto-style9 {
            position: fixed;
            top: 651px;
            left: 438px;
            height: 85px;
            width: 391px;
        }
        .auto-style10 {
            position: fixed;
            left: 83px;
            top: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <div class="auto-style7">
            &nbsp;<div class="auto-style6">
                &nbsp;
              
            </div>
        </div>

        <div style="text-align:center; " class="auto-style10">
            <h3>Browse our products from the Product List!</h3>
              Your cart has
        <asp:Label ID="lblCartCount" runat="server"></asp:Label>
    &nbsp;items.
            <asp:HyperLink ID="hypViewCart" runat="server" NavigateUrl="~/ViewCart.aspx">View Cart</asp:HyperLink>
            
        </div>

        <div style="text-align:center; " class="auto-style9">
            
            
            
                  <%
                      clsInventoryCollection MyInventories = new clsInventoryCollection();
                      MyInventories.ReportByCategory("");
                      Int32 Index = 0;
                      Int32 RecordCount = MyInventories.Count;


                  %><table border="1" class="auto-style8">
                      <%
                   %> <tr><% 

                    %><td style="font-weight:bold"><%
                                         Response.Write("");
                    %></td><%

                    %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Name");
                     %></td><%

                     %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Price Per Item");
                     %></td><%

                   %></tr><%
                        
                  while(Index<RecordCount)
                  {
                    %><tr><%
                    %><td>
                        <a href="CartItemDetails.aspx?InventoryId=<% Response.Write(MyInventories.InventoryList[Index].InventoryId);%>&Price=<%Response.Write(MyInventories.InventoryList[Index].Price);%>&Name=<% Response.Write(MyInventories.InventoryList[Index].Name); %>">
                            <%   
                     Response.Write("Select Quantity");
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
        </div>
&nbsp;&nbsp;
                    
    <br />
    <br />
</asp:Content>

