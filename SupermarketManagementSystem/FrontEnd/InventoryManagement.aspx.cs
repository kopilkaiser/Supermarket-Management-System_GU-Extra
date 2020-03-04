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
           lblError.Text = DisplayInventories("") + " records in the database";
        }
    }

    Int32 DisplayInventories(string CategoryFilter)
    {
        /*  //create an instance of the Inventory collection
          clsInventoryCollection Inventories = new clsInventoryCollection();
          //set the data source to the list of inventories in the collection
          lstInventories.DataSource = Inventories.InventoryList;
          //set the name of the primary Key
          lstInventories.DataValueField = "InventoryId";
          //set the data field to display

          lstInventories.DataTextField = "Category";


          //bind the data to the list
          lstInventories.DataBind();
         */

        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsInventoryCollection AllInventories = new clsInventoryCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the house no
        string Name;
        //var to store the street name
        string Price;
        //var to store the post code
        string Quantity;
        //var to store the primary key value
        string Category;
        string InventoryId;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstInventories.Items.Clear();
        //call the filter by post code method
        AllInventories.ReportByCategory(CategoryFilter);
        //get the count of records found
        RecordCount = AllInventories.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the house no from the query results
            Name = Convert.ToString(AllInventories.InventoryList[Index].Name);
            //get the street from the query results
            Price = Convert.ToString(AllInventories.InventoryList[Index].Price);
            //get the post code from the query results
            Quantity = Convert.ToString(AllInventories.InventoryList[Index].Quantity);
            //get the address no from the query results
            Category = Convert.ToString(AllInventories.InventoryList[Index].Category);

            InventoryId = Convert.ToString(AllInventories.InventoryList[Index].InventoryId);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(Name + " "+ Price + " " + Quantity + " "+ " " + Category, InventoryId);
            //add the new item to the list
            lstInventories.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
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
            Response.Redirect("InventoryConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 InventoryId;
        //if a record has been selected from the list
        if (lstInventories.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            InventoryId = Convert.ToInt32(lstInventories.SelectedValue);
            //store the data in the session object
            Session["InventoryId"] = InventoryId;
            //redirect to the delete page
            Response.Redirect("AnInventory.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayInventories(txtCategory.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayInventories("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the Category filter text box
        txtCategory.Text = "";

        lstInventories.ClearSelection();
    }
}
