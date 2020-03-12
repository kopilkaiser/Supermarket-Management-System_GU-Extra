using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnInventory : System.Web.UI.Page
{
    Int32 InventoryId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        InventoryId = Convert.ToInt32(Session["InventoryId"]);
        if (IsPostBack == false)
        {
            //populate the list of inventories
           //DisplayInventories();
            //if this is not a new record
            if (InventoryId != -1)
            {
                //display the current data for the record
                DisplayInventory();
            }
            else
            {
                txtDateAdded.Text = DateTime.Today.Date.ToString("MM/dd/yyyy");
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryManagement.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (InventoryId == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
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

    void Update()
    {
        //create an instance of the Inventory Collenction
        clsInventoryCollection AllInventories = new clsInventoryCollection();
        //validate the data on the web form
        string Error = AllInventories.ThisInventory.Valid(txtName.Text, txtPrice.Text, txtQuantity.Text, txtCategory.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            AllInventories.ThisInventory.Find(InventoryId);
            //get the data entered by the user
            AllInventories.ThisInventory.Name = txtName.Text;
            AllInventories.ThisInventory.Price = Convert.ToDecimal(txtPrice.Text);
            AllInventories.ThisInventory.Quantity = Convert.ToInt32(txtQuantity.Text);
            AllInventories.ThisInventory.Category = txtCategory.Text;
            AllInventories.ThisInventory.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            AllInventories.ThisInventory.Active = chkActive.Checked;
            //add the record
            AllInventories.Update();
            //all done so redirect back to the main page
            Response.Redirect("InventoryManagement.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered : " + Error;
        }
    }

    void DisplayInventory()
    {
        //create an instance of the inventory collection
        clsInventoryCollection AllInventories = new clsInventoryCollection();
        //find the record to update
        AllInventories.ThisInventory.Find(InventoryId);
        //display the data for this record
        txtName.Text = AllInventories.ThisInventory.Name;
        txtPrice.Text = AllInventories.ThisInventory.Price.ToString();
        txtQuantity.Text = AllInventories.ThisInventory.Quantity.ToString();
        txtDateAdded.Text = AllInventories.ThisInventory.DateAdded.ToString();
        txtCategory.Text = AllInventories.ThisInventory.Category;
        chkActive.Checked = AllInventories.ThisInventory.Active;

    }

  
}