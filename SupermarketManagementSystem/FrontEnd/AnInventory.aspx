<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnInventory.aspx.cs" Inherits="AnInventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 173px;
        }
        .auto-style3 {
            width: 263px;
        }
        .auto-style4 {
            width: 173px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Name
            </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Price</td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Quantity
            </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Category
            </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">DateAdded
            </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="99px" />
                    </td>
                    <td class="auto-style3">
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Width="99px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
