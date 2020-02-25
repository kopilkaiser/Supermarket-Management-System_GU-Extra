using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class InventoryManagement : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayInventories();
        }
    }
        void DisplayInventories()
        {
            //create an instance of the Inventory collection
            clsInventoryCollection Inventories = new clsInventoryCollection();
            //set the data source to the list of inventories in the collection
            lstInventories.DataSource = Inventories.InventoryList;
            //set the name of the primary Key
            lstInventories.DataValueField = "InventoryId";
            //set the data field to display
            lstInventories.DataTextField = "Category";
            //bind the data to the list
            lstInventories.DataBind();
        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indeciate this is a new record
        Session["InventoryId"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnInventory.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 InventoryId;
        //if a record has been selected from the list
        if(lstInventories.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            InventoryId = Convert.ToInt32(lstInventories.SelectedValue);
            //store the data in the session object
            Session["InventoryId"] = InventoryId;
            //redirect to the delete page
            Response.Redirect("InventoryDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
