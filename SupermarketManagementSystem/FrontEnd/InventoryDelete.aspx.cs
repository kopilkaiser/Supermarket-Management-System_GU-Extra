using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class InventoryDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 InventoryId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Inventory to be delete from the session object
      InventoryId = Convert.ToInt32(Session["InventoryId"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryManagement.aspx");
    }

    void DeleteInventory()
    {
        //function to delete the selected record

        //create a instance of the Inventory List
        clsInventoryCollection AllInventories = new clsInventoryCollection();
        //find the record to delete
        AllInventories.ThisInventory.Find(InventoryId);
        //delete the record
        AllInventories.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteInventory();
        //redirect back to the main page
        Response.Redirect("InventoryManagement.aspx");
    }
}