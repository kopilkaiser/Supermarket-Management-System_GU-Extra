<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="CartItemDetails1.aspx.cs" Inherits="CartItemDetails1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            color: #CC3300;
            font-size: x-large;
        }
        .auto-style11 {
            font-size: xx-large;
            margin-left: 360px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article class="auto-style7">
         <div class="auto-style11">
        
                           <strong>
                           <br />
                           <asp:Label ID="Label1" runat="server" Text="Name" CssClass="auto-style10"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtName" runat="server" ReadOnly="True" CssClass="auto-style12" BackColor="#333333" ForeColor="White"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label3" runat="server" Text="Price" CssClass="auto-style10"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" CssClass="auto-style13" BackColor="#333333" ForeColor="White"></asp:TextBox>
                           <br />
                           <strong>
        <asp:Label ID="Label2" runat="server" Text="Quantity" CssClass="auto-style10"></asp:Label>
                           </strong>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtQuantity" runat="server" CssClass="auto-style14">1</asp:TextBox>
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

