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
    public partial class OrderlineManageForm : Form
    {
        Int32 OrderlineId;
        clsDataConnection dBConnecttion;
        public OrderlineManageForm()
        {
            InitializeComponent();
        }

        private void OrderlineManageForm_Load(object sender, EventArgs e)
        {
            //update the list box with Order database list
            lblError.Text = DisplayOrderlines("") + " records in the database";

            // Clear all selections in the ListBox.
            listboxOrderline.ClearSelected();



        }
        Int32 DisplayOrderlines(string OrderlineFilter)
        {
            //create an instance of the Order collection
            clsOrderCollection AllOrderlines = new clsOrderCollection();
            AllOrderlines.FilterByOrderlineId(OrderlineFilter);
            //set the data source to the list of Orders in the collection
            listboxOrderline.DataSource = AllOrderlines.OrderlineList;
            //set the name of the primary Key
            listboxOrderline.ValueMember = "OrderlineId";
            //set the data field to display

            listboxOrderline.DisplayMember = "AllDetails";

            AllOrderlines.FilterByOrderlineId(OrderlineIdFilter);

            return AllOrderlines.Count;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsOrderline AnOrderline = new clsOrderline();
            AnOrderline.OrderlineId = -1;
            OrderlineAddForm ZX = new OrderlineAddForm();
            this.Hide();
            ZX.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 OrderId;
            //if a record has been selected from the list
            if (listboxOrderline.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderId = Convert.ToInt32(listboxOrderline.SelectedValue);
                //store the data in the session object
                OrderlineUpdateForm.tempOrderline = OrderId;

                //redirect to the delete page
                OrderlineUpdateForm UpdateOrderline = new OrderlineUpdateForm();
                UpdateOrderline.OrderlineID = OrderlineId;
                this.Hide();
                UpdateOrderline.Show();
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
            Int32 OrderlineId;
            //if a record has been selected from the list
            if (listboxOrderline.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderlineId = Convert.ToInt32(listboxOrderline.SelectedValue);
                //store the data in the session object
                OrderlineUpdateForm.tempOrderline = OrderlineId;

                //redirect to the delete page
                OrderlineDeleteForm ConfirmDelete = new OrderlineDeleteForm();
                ConfirmDelete.OrderlineID = OrderlineId;
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
            RecordCount = DisplayOrderlines(txtOrderlineId.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayOrderlines("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Category filter text box
            txtOrderlineId.Text = "";

            listboxOrderline.ClearSelected();

        }
    }
}
