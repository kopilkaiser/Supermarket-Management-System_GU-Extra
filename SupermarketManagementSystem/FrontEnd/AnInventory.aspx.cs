using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        

    }

    void Add()
    {
        //create an instance of the Inventory Collenction
        clsInventoryCollection AllInventories = new clsInventoryCollection();
        //validate the data on the web form
        string Error = AllInventories.ThisInventory.Valid(txtName.Text, txtPrice.Text, txtQuantity.Text, txtCategory.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if(Error == "")
        {
            //get the data entered by the user
            AllInventories.ThisInventory.Name = txtName.Text;
            AllInventories.ThisInventory.Price = Convert.ToDecimal(txtPrice.Text);
            AllInventories.ThisInventory.Quantity = Convert.ToInt32(txtQuantity.Text);
            AllInventories.ThisInventory.Category = txtCategory.Text;
            AllInventories.ThisInventory.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            AllInventories.ThisInventory.Active = chkActive.Checked;
            //add the record
            AllInventories.Add();
            //all done so redirect back to the main page
            Response.Redirect("InventoryManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered : " + Error;
        }
    }
}