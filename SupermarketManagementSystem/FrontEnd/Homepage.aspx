<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            font-size: large;
            color: #663300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style10">
        Press &quot;Browse Products&quot; button to open the Product list and start adding items to Cart.</p>
    <p>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/supermarket1.jpg" />
    </p>
</asp:Content>

