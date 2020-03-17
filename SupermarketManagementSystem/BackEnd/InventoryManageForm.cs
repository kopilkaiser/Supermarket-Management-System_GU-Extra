using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ClassLibrary;
using ListBox = System.Windows.Forms.ListBox;

namespace BackEnd
{
    public partial class InventoryManageForm : Form
    {
        
        
        Int32 InventoryId ;
        clsDataConnection dBConnection;
        public InventoryManageForm()
        {
            InitializeComponent();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            
            //update the list box with Inventory database list
            lblError.Text = DisplayInventories("") + " records in the database";

            // Clear all selections in the ListBox.
            lstInventories.ClearSelected();
        }

        Int32 DisplayInventories(string CategoryFilter)
        {
              //create an instance of the Inventory collection
             clsInventoryCollection AllInventories = new clsInventoryCollection();
            AllInventories.ReportByCategory(CategoryFilter);
            //set the data source to the list of inventories in the collection
            lstInventories.DataSource = AllInventories.InventoryList;
              //set the name of the primary Key
              lstInventories.ValueMember = "InventoryId";
              //set the data field to display

              lstInventories.DisplayMember = "AllDetails";


              //bind the data to the list
              //lstInventories.DataBind();
             

            /////this function accepts one parameter - the post code to filter the list on
            /////it populates the list box with data from the middle layer class
            /////it returns a single value, the number of records found

            ////create a new instance of the clsAddress
            //clsInventoryCollection AllInventories = new clsInventoryCollection();
            ////var to store the count of records
            //Int32 RecordCount;
            ////var to store the house no
            //string Name;
            ////var to store the street name
            //string Price;
            ////var to store the post code
            //string Quantity;
            ////var to store the primary key value
            //string Category;
            //string InventoryId;
            ////var to store the index
            //Int32 Index = 0;
            ////clear the list of any existing items
            //lstInventories.Items.Clear();
            ////call the filter by post code method
            AllInventories.ReportByCategory(CategoryFilter);
            ////get the count of records found
            //RecordCount = AllInventories.Count;
            ////loop through each record found using the index to point to each record in the data table
            //while (Index < RecordCount)
            //{
            //    //get the house no from the query results
            //    Name = Convert.ToString(AllInventories.InventoryList[Index].Name);
            //    //get the street from the query results
            //    Price = Convert.ToString(AllInventories.InventoryList[Index].Price);
            //    //get the post code from the query results
            //    Quantity = Convert.ToString(AllInventories.InventoryList[Index].Quantity);
            //    //get the address no from the query results
            //    Category = Convert.ToString(AllInventories.InventoryList[Index].Category);

            //    InventoryId = Convert.ToString(AllInventories.InventoryList[Index].InventoryId);
            //    //set up a new object of class list item 
            //    // ListItem NewItem = new ListItem(Name + " " + Price + " " + Quantity + " " + " " + Category, InventoryId);
            //    //add the new item to the list
            //    ListItem NewItem = new ListItem("Name:" + Name + "_" + "Price:" + Price + "_" + "Quantity:" + Quantity + "_" + "Category:" + Category, InventoryId);
            //    NewItem.Text = "fred";
            //    NewItem.Value = "10";
            //    lstInventories.Items.Add(NewItem);
            //    //increment the index
            //    Index++;
            //}
            //return the number of records found
            return AllInventories.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsInventory AnInventory = new clsInventory();
            AnInventory.InventoryId = -1;
            AddInventoryForm ZX = new AddInventoryForm();
            this.Hide();
            ZX.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 InventoryId;
            //if a record has been selected from the list
            if (lstInventories.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                InventoryId = Convert.ToInt32(lstInventories.SelectedValue);
                //store the data in the session object
                UpdateInventoryForm.tempInv = InventoryId;
               
                //redirect to the delete page
                UpdateInventoryForm UpdateInv = new UpdateInventoryForm();
                UpdateInv.InventoryID = InventoryId;
                this.Hide();
                UpdateInv.Show();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 InventoryId;
            //if a record has been selected from the list
            if (lstInventories.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                InventoryId = Convert.ToInt32(lstInventories.SelectedValue);
                //store the data in the session object
                UpdateInventoryForm.tempInv = InventoryId;

                //redirect to the delete page
                ConfirmDeleteInventoryForm ConfirmDelete = new ConfirmDeleteInventoryForm();
                ConfirmDelete.InventoryID = InventoryId;
                this.Hide();
                ConfirmDelete.Show();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayInventories(txtCategory.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayInventories("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Category filter text box
            txtCategory.Text = "";

            lstInventories.ClearSelected();
        }

        //private void lstInventories_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lblError.Text = lstInventories.SelectedValue.ToString();
        //}
    }
}
