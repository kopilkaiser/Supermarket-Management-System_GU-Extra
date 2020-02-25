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

namespace BackEnd
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed

            //update the list box
            lblError.Text = DisplayInventories("") + " records in the database";
            //DisplayInventories();
        }

        Int32 DisplayInventories(string CategoryFilter)
        {
              //create an instance of the Inventory collection
             /* clsInventoryCollection Inventories = new clsInventoryCollection();
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
                ListItem NewItem = new ListItem(Name + " " + Price + " " + Quantity + " " + " " + Category, InventoryId);
                //add the new item to the list
                lstInventories.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            //return the number of records found
            return RecordCount;
        }
    }
}
