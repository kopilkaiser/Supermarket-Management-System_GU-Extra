<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="CustomerPayment1.aspx.cs" Inherits="CustomerPayment1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div >
        <asp:Label ID="Label1" runat="server" Text="Card Number"></asp:Label>
    &nbsp;<asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="PayeeName"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPayeeName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Method"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DDListMethod" runat="server">
        <asp:ListItem>Visa Debit</asp:ListItem>
        <asp:ListItem>MasterCard</asp:ListItem>
        <asp:ListItem>Credit Card</asp:ListItem>
</asp:DropDownList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Amount"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="PaymentDate"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtPaymentDate" runat="server"></asp:TextBox>
         <asp:TextBox ID="txtMyPrice" runat="server"> </asp:TextBox>
        <br />

        <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>

    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnCheckOut" runat="server" OnClick="btnCheckOut_Click" Text="Check Out" />
    </div>
</asp:Content>

