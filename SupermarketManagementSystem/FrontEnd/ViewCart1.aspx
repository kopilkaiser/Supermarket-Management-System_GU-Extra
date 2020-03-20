<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="ViewCart1.aspx.cs" Inherits="ViewCart1" %>
<%@ Import Namespace="ClassLibrary"%>
<script runat="server">

    clsCart MyCart = new clsCart();

    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
        //display the cart contents

    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            font-size: large;
        }
        .auto-style10 {
            font-size: large;
            color: #000000;
        }
        .auto-style12 {
            font-size: large;
            color: #3333FF;
        }
        .auto-style13 {
            font-size: large;
            color: #000000;
            height: 31px;
        }
        .auto-style14 {
            font-size: large;
            color: #FF0000;
        }
        .auto-style15 {
            font-size: large;
            color: #FF0000;
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="auto-style8">

        <%
                      Int32 Index = 0;
                      Int32 Count = MyCart.Products.Count;


                  %><table border="1" class="auto-style2">
                      <%
                   %> <tr><% 

                    %><td style="font-weight:bold" class="auto-style13"><%
                                         Response.Write("Product Id");
                    %></td><%

                    %><td style="font-weight:bold; text-align:center" class="auto-style13"><%
                     Response.Write("Product Name");
                     %></td><%

                     %><td style="font-weight:bold; text-align:center" class="auto-style13"><%
                     Response.Write("Quantity");
                     %></td><%

                                 %><td style="font-weight:bold; text-align:center" class="auto-style13"><%
                     Response.Write("Unit Price");
                     %></td><%
                                 %><td style="font-weight:bold; text-align:center" class="auto-style13"><%
                     Response.Write("Total Price");
                     %></td><%

                                 %><td style="font-weight:bold; text-align:center" class="auto-style15"><%
                     Response.Write("");
                     %></td><%

                   %></tr><%
                        
                  while(Index<Count)
                  {
                    %><tr><%
                                %><td class="auto-style10"><%
                     Response.Write(MyCart.Products[Index].InventoryId);
                     %></td><% 

                    %><td class="auto-style10"><%
                     Response.Write(MyCart.Products[Index].Name);
                     %></td><%    

                                %><td class="auto-style10"><%
                     Response.Write(MyCart.Products[Index].QTY);
                     %></td><%  

                                           %><td class="auto-style10"><%
                     Response.Write(MyCart.Products[Index].Price);
                     %></td><%  

                                           %><td class="auto-style10"><%
                     Response.Write(MyCart.Products[Index].TotalPrice);
                     %></td><%  

                        %><td class="auto-style14">
                        <a href="RemoveCartItem.aspx?Index=<% Response.Write(Index);%>">
                              <span class="auto-style7">
                            <%   
                     Response.Write("Remove Item");
                    %></span></a></td><%

                     %> </tr><%
                      Index++;
                    }
                    %></table><%

                  %>
            <asp:HyperLink ID="hypBrowseProducts" runat="server" NavigateUrl="~/BrowseProducts1.aspx" CssClass="auto-style12">Continue Shopping</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hypCheckOut" runat="server" NavigateUrl="~/CustomerPayment1.aspx" CssClass="auto-style12">CheckOut</asp:HyperLink>
       
    </div>
</asp:Content>

