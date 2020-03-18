<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="CartItemDetails.aspx.cs" Inherits="CartItemDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            color: #000099;
            font-size: large;
        }
        .auto-style7 {
            left: 26%;
            top: 29%;
            width: 30%;
            height: 52%;
        }
        .auto-style8 {
            position: fixed;
            top: 236px;
            left: 451px;
            height: 97px;
            width: 292px;
            right: 1075px;
        }
  
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <article class="auto-style7">
         <div class="auto-style8">
        
                           <strong>
                           <br />
                           <asp:Label ID="Label1" runat="server" Text="Name" CssClass="auto-style9"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" ReadOnly="True" CssClass="auto-style12" BackColor="Gray"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label3" runat="server" Text="Price" CssClass="auto-style11"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" CssClass="auto-style13" BackColor="Gray"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label2" runat="server" Text="Quantity" CssClass="auto-style10"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtQuantity" runat="server" CssClass="auto-style14">1</asp:TextBox>
                           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Add to Cart" CssClass="auto-style3" Height="40px" Width="151px" />
   

       
                           <br />
                           <br />
                           <br />
&nbsp;&nbsp;&nbsp;&nbsp;
           

       
             </div>
   

       
           </article>
</asp:Content>

