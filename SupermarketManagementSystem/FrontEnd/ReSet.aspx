<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="ReSet.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>Re-Set Password<br />
        </h1>
        <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
        &nbsp;<asp:TextBox ID="txtEMail" runat="server" Width="283px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        &nbsp;</div>
    &nbsp;<asp:Button ID="btnReSet" runat="server" OnClick="btnReSet_Click" Text="Re-set Password" />
    &nbsp;<asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" Text="Done" />
    &nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />
</asp:Content>

