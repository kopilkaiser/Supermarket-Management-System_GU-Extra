<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 166px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Sign In</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">EMail Address</td>
            <td>
                <asp:TextBox ID="txtEMail" runat="server" Width="202px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign-in" />
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
    <asp:Button ID="btnReSend" runat="server" OnClick="btnReSend_Click" Text="Re-set Password" />
    </asp:Content>

