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
using ListBox = System.Windows.Forms.ListBox;


namespace BackEnd
{
    public partial class OrderManageForm : Form
    {
        Int32 OrderId;
        clsDataConnection dBConnecttion;
        public OrderManageForm()
        {
            InitializeComponent();
        }

        private void OrderManageForm_Load(object sender, EventArgs e)
        {
            //update the list box with Order database list
            lblError.Text = DisplayOrders("") + " records in the database";

            // Clear all selections in the ListBox.
            listboxOrder.ClearSelected();


        }

        Int32 DisplayOrders(string EmailFilter)
        {
            //create an instance of the Order collection
            clsOrderCollection AllOrders = new clsOrderCollection();
            AllOrders.FilterByEmail(EmailFilter);
            //set the data source to the list of Orders in the collection
            listboxOrder.DataSource = AllOrders.OrderList;
            //set the name of the primary Key
            listboxOrder.ValueMember = "OrderId";
            //set the data field to display

            listboxOrder.DisplayMember = "AllDetails";

            AllOrders.FilterByEmail(EmailFilter);

            return AllOrders.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsOrder AnOrder = new clsOrder();
            AnOrder.OrderId = -1;
            OrderAddForm ZX = new OrderAddForm();
            this.Hide();
            ZX.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 OrderId;
            //if a record has been selected from the list
            if (listboxOrder.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderId = Convert.ToInt32(listboxOrder.SelectedValue);
                //store the data in the session object
                OrderUpdateForm.tempOrder = OrderId;

                //redirect to the delete page
                OrderUpdateForm UpdateOrder = new OrderUpdateForm();
                UpdateOrder.OrderID = OrderId;
                this.Hide();
                UpdateOrder.ShowDialog();
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
            Int32 OrderId;
            //if a record has been selected from the list
            if (listboxOrder.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderId = Convert.ToInt32(listboxOrder.SelectedValue);
                //store the data in the session object
                OrderUpdateForm.tempOrder = OrderId;

                //redirect to the delete page
                OrderDeleteForm ConfirmDelete = new OrderDeleteForm();
                ConfirmDelete.OrderID = OrderId;
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
            // declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayOrder function to the record count var
            RecordCount = DisplayOrders(txtEmail.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayOrder function to the record count var
            RecordCount = DisplayOrders("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Email filter text box
            txtEmail.Text = "";

            listboxOrder.ClearSelected();

        }
        
        // button for go back to main menu
        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            mdiBackEndMenuForm PK = new mdiBackEndMenuForm();

            this.Hide();
            PK.ShowDialog();
            this.Close();
        }
    }
}

