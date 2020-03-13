<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="CartItemDetails.aspx.cs" Inherits="CartItemDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            color: #000099;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <article>
         <div style="position:fixed; top: 153px; left: 503px; height: 283px; width: 472px; right: 864px;">
        
                           <strong>
                           <br />
                           <asp:Label ID="Label1" runat="server" Text="Name" CssClass="auto-style6"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" ReadOnly="True" CssClass="auto-style6" BackColor="Gray"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label3" runat="server" Text="Price" CssClass="auto-style6"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" CssClass="auto-style6" BackColor="Gray"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label2" runat="server" Text="Quantity" CssClass="auto-style6"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtQuantity" runat="server" CssClass="auto-style6">1</asp:TextBox>
                           <br />
                           <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Add to Cart" CssClass="auto-style3" Height="31px" Width="101px" />
   

       
             </div>
           </article>
</asp:Content>

