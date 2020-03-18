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
    public partial class ManageOrderForm : Form
    {
        Int32 OrderId;
        clsDataConnection dBConnecttion;

        public ManageOrderForm()
        {
            InitializeComponent();
        }

        private void ManageOrderForm_Load(object sender, EventArgs e)
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
            AddOrderForm ZX = new AddOrderForm();
            this.Hide();
            ZX.Show();

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
                UpdateOrderForm.tempOrder = OrderId;

                //redirect to the delete page
                UpdateOrderForm UpdateOrders = new UpdateOrderForm();
                UpdateOrders.OrderID = OrderId;
                this.Hide();
                UpdateOrders.Show();
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
                UpdateOrderForm.tempOrder = OrderId;

                //redirect to the delete page
                DeleteOrderForm ConfirmDelete = new DeleteOrderForm();
                ConfirmDelete.OrderID = OrderId;
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
            // declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayOrders(txtEmail.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";


        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayOrders("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Category filter text box
            txtEmail.Text = "";

            listboxOrder.ClearSelected();

        }
    }
}
