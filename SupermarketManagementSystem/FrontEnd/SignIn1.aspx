<%@ Page Title="" Language="C#" MasterPageFile="~/SuperMarket.master" AutoEventWireup="true" CodeFile="SignIn1.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Sign In<table class="auto-style9">
        <tr>
            <td class="auto-style2">EMail Address</td>
            <td>
                <asp:TextBox ID="txtEMail" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" Width="207px" TabIndex="1" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
    <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
    <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign-in" TabIndex="2" />
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" TabIndex="3" />
    <asp:Button ID="btnReSend" runat="server" OnClick="btnReSend_Click" Text="Re-set Password" TabIndex="4" />
            </td>
        </tr>
    </table>
    </p>
    <br />
    <br />
    <br />
    <br /> 





</asp:Content>

