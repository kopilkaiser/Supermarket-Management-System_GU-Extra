<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 339px;
        }
        .auto-style4 {
            width: 339px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
        <strong>New USER Sign UP</strong></p>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">EMail Address</td>
            <td>
                <asp:TextBox ID="txtEMail" runat="server" width="318px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Password</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" width="318px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Confirm Password</td>
            <td>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" width="318px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign-up" />
    <asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" Text="Done" />
    <asp:Button ID="btnReSend" runat="server" OnClick="btnReSend_Click" Text="Re-set Password" />
    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />
</asp:Content>

