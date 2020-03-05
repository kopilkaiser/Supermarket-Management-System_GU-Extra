<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        WELCOME TO THE BEST MARKET GU-EXTRA</p>
    <p>
        WE WILL FulFill your needs &amp; desire!</p>
    <p>
        &nbsp;</p>
    <p>
                <asp:ListBox ID="lstInventories" runat="server" Height="312px" Width="823px" DataTextField="InventoryId" DataValueField="InventoryId"></asp:ListBox>
                <br __designer:mapid="1" />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br __designer:mapid="3" />
                <br __designer:mapid="4" />
                Please Enter a Category<br __designer:mapid="5" />
                <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                <br __designer:mapid="7" />
                <br __designer:mapid="8" />
                <asp:Button ID="btnApply" runat="server" Text="Apply" Width="126px" OnClick="btnApply_Click" />
                <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="108px" OnClick="btnDisplayAll_Click" />
                <br __designer:mapid="b" />
                <br __designer:mapid="c" />
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="74px" />
                &nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" Width="68px" OnClick="btnEdit_Click" />
                &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="78px" />
            </p>
</asp:Content>

