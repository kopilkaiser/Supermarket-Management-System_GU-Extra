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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border ="1">
                    <tr>
                        <td>InventoryId</td><td><input type="text" name="txtDVDNo" value="<% Response.Write(AnInventory.InventoryId); %>"/></td>
                    </tr>
                    <tr>
                        <td>Name</td><td><input type="text" name="txtTitle" value="<% Response.Write(AnInventory.Name); %>"/></td>
                    </tr>
                    <tr>
                         <td>Price</td><td><input type="text" name="txtDVDNo" value="<% Response.Write(AnInventory.Price); %>"/></td>
                    </tr>
                
                    <tr>
                        <td></td><td></td>
                    </tr>
                    <tr>
                        <td></td><td></td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
