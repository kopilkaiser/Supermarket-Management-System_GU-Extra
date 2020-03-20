using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace BackEnd
{
    
    public partial class UpdateInventoryForm : Form
    {
        private int mInventoryId = 0;
        public int InventoryID
        {
            set
            {
                mInventoryId = value;
            }
        }


        public static int tempInv { get; set; }

        public UpdateInventoryForm()
        {
            InitializeComponent();
        }

        private void UpdateInventoryForm_Load(object sender, EventArgs e)
        {
            //textBox1.Text = tempInv.ToString();
            //textBox1.Text = InventoryManageForm.quantity.ToString();
            //InventoryId = Convert.ToInt32(InventoryManageForm.quantity);

            //display the current data for the record
            DisplayInventory();
            txtDateAdded.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Update();
        }

        public void Update()
        {
            
            //create an instance of the Inventory Collenction
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //validate the data on the web form
            string Error = AllInventories.ThisInventory.Valid(txtName.Text, txtPrice.Text, txtQuantity.Text, Convert.ToString(comboBoxCategory.SelectedItem), txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                
                //find the record to update
                AllInventories.ThisInventory.Find(mInventoryId);
                //get the data entered by the user
                AllInventories.ThisInventory.Name = txtName.Text;
                AllInventories.ThisInventory.Price = Convert.ToDecimal(txtPrice.Text);
                AllInventories.ThisInventory.Quantity = Convert.ToInt32(txtQuantity.Text);
                AllInventories.ThisInventory.Category = Convert.ToString(comboBoxCategory.SelectedItem);
                AllInventories.ThisInventory.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                AllInventories.ThisInventory.Active = chkActive.Checked;
                //add the record
                AllInventories.Update();
                //all done so redirect back to the main page
                InventoryManageForm IM = new InventoryManageForm();
                this.Hide();
                IM.Show();
                this.Close();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered : " + Error;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InventoryManageForm IM = new InventoryManageForm();

            this.Hide();
            IM.Show();
            this.Close();
        }

        public void DisplayInventory()
        {
            //create an instance of the inventory collection
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //find the record to update
            AllInventories.ThisInventory.Find(mInventoryId);
            //display the data for this record
            txtName.Text = AllInventories.ThisInventory.Name;
            txtPrice.Text = AllInventories.ThisInventory.Price.ToString();
            txtQuantity.Text = AllInventories.ThisInventory.Quantity.ToString();
            txtDateAdded.Text = AllInventories.ThisInventory.DateAdded.ToString();   
            chkActive.Checked = AllInventories.ThisInventory.Active;
            comboBoxCategory.SelectedItem = AllInventories.ThisInventory.Category;
        }
    }
}
