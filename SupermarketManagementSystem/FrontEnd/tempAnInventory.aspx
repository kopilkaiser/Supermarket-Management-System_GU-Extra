<%@ Page Language="C#" %>
<%@Import Namespace="ClassLibrary" %>
<!DOCTYPE html>

<script runat="server">
    Int32 InventoryId;
    clsInventory AnInventory = new clsInventory();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            InventoryId = Convert.ToInt32(Request.QueryString["InventoryId"]);
            AnInventory.Find(InventoryId);
        }
        catch
        {

        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 370px;
        }
        .auto-style2 {
            width: 336px;
        }
        .auto-style3 {
            width: 330px;
        }
        .auto-style4 {
            height: 33px;
        }
        .auto-style5 {
            width: 27%;
            height: 173px;
        }
        .auto-style6 {
            width: 114px;
        }
        .auto-style7 {
            width: 341px;
        }
        .auto-style8 {
            width: 346px;
        }
        .auto-style9 {
            width: 114px;
            height: 35px;
        }
        .auto-style10 {
            width: 341px;
            height: 35px;
        }
        .auto-style11 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border ="1">
                    <tr>
                        <td>InventoryId</td><td><input type="text" name="txtDVDNo" value="<% Response.Write(AnInventory.InventoryId); %>" class="auto-style1"/></td>
                    </tr>
                    <tr>
                        <td>Name</td><td><input type="text" name="txtTitle" value="<% Response.Write(AnInventory.Name); %>" class="auto-style2"/></td>
                    </tr>
                    <tr>
                         <td class="auto-style4">Price</td><td class="auto-style4"><input type="text" name="txtDVDNo" value="<% Response.Write(AnInventory.Price); %>" class="auto-style3"/></td>
                    </tr>
                
                    <tr>
                        <td></td><td></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"></td><td class="auto-style11"></td>
                    </tr>
                </table>
            <br />
&nbsp;<table class="auto-style5">
                <tr>
                    <td class="auto-style9">InventoryId</td>
                    <td class="auto-style10">
                        <input id="Text1" aria-readonly="True" class="auto-style8" name="txtInventoryId" type="text" value="<%Response.Write(AnInventory.InventoryId);%>" /></td>
                </tr>
                <tr>
                    <td class="auto-style6">Name</td>
                    <td class="auto-style7">
                        <input id="Text2" aria-readonly="True" class="auto-style8" name="txtName" type="text" value="<%Response.Write(AnInventory.Name);%>" /></td>
                </tr>
                <tr>
                    <td class="auto-style6">Price</td>
                    <td class="auto-style7">
                        <input id="Text3" aria-readonly="True" class="auto-style8" name="txtPrice" type="text" value="<%Response.Write(AnInventory.Price);%>" /></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
