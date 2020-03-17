<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
    <div style="position:fixed; top: 246px; left: 517px; height: 274px; width: 561px;">

        <%
                      Int32 Index = 0;
                      Int32 Count = MyCart.Products.Count;


                  %><table border="1" class="auto-style2">
                      <%
                   %> <tr><% 

                    %><td style="font-weight:bold"><%
                                         Response.Write("Product Id");
                    %></td><%

                    %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Product Name");
                     %></td><%

                     %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Quantity");
                     %></td><%

                                 %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Unit Price");
                     %></td><%
                                 %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("Total Price");
                     %></td><%

                                 %><td style="font-weight:bold; text-align:center"><%
                     Response.Write("");
                     %></td><%

                   %></tr><%
                        
                  while(Index<Count)
                  {
                    %><tr><%
                                %><td><%
                     Response.Write(MyCart.Products[Index].InventoryId);
                     %></td><% 

                    %><td><%
                     Response.Write(MyCart.Products[Index].Name);
                     %></td><%    

                                %><td><%
                     Response.Write(MyCart.Products[Index].QTY);
                     %></td><%  

                                           %><td><%
                     Response.Write(MyCart.Products[Index].Price);
                     %></td><%  

                                           %><td><%
                     Response.Write(MyCart.Products[Index].TotalPrice);
                     %></td><%  

                        %><td>
                        <a href="RemoveCartItem.aspx?Index=<% Response.Write(Index);%>">
                            <%   
                     Response.Write("Remove Item");
                    %></a></td><%

                     %> </tr><%
                      Index++;
                    }
                    %></table><%

                  %>
            <asp:HyperLink ID="hypBrowseProducts" runat="server" NavigateUrl="~/BrowseProducts.aspx">Continue Shopping</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hypCheckOut" runat="server" ForeColor="#CC3300" NavigateUrl="~/Default3.aspx">*checkout*</asp:HyperLink>
       
    </div>



</asp:Content>

