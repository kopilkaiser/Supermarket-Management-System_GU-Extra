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
    public partial class ConfirmDelete : Form
    {
        private int mInventoryId = 0;
        public int InventoryID
        {
            set
            {
                mInventoryId = value;
            }
        }


        public ConfirmDelete()
        {
            InitializeComponent();
        }



        private void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteInventory();
            //redirect to the main form
            InventoryManageForm InvManageForm = new InventoryManageForm();
            this.Show();
            InvManageForm.Show();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            InventoryManageForm InvManageForm = new InventoryManageForm();
            this.Show();
            InvManageForm.Show();
            this.Close();
        }

        void DeleteInventory()
        {
            //function to delete the selected record

            //create an instance of the Inventory List
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //find the record to delete
            AllInventories.ThisInventory.Find(mInventoryId);
            //delete the record
            AllInventories.Delete();
        }


    }
}