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

            AllInventories.ReportByCategory(CategoryFilter);
      
            return AllInventories.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsInventory AnInventory = new clsInventory();
            AnInventory.InventoryId = -1;
            AddInventoryForm ZX = new AddInventoryForm();
            this.Hide();
            ZX.ShowDialog();
            
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
                UpdateInv.ShowDialog();
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
                ConfirmDelete ConfirmDelete = new ConfirmDelete();
                ConfirmDelete.InventoryID = InventoryId;
                this.Hide();
                ConfirmDelete.ShowDialog();
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mdiBackEndMenuForm mdiMF = new mdiBackEndMenuForm();

            this.Hide();
            mdiMF.ShowDialog();
            this.Close();
        }


    }
}
