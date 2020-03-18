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
    public partial class OrderlineManagement : Form
    {
        Int32 OrderlineId;
        clsDataConnection dBConnection;

        public OrderlineManagement()
        {
            InitializeComponent();
        }

        private void OrderlineManagement_Load(object sender, EventArgs e)
        {
            //update the list box with Inventory database list
            lblError.Text = DisplayOrderlines("") + " records in the database";

            // Clear all selections in the ListBox.
            lstboxOrderline.ClearSelected();
        }

        Int32 DisplayOrderlines(string OrderlineIdFilter)
        {
            //create an instance of the Orderlines collection
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            AllOrderlines.ReportByOrderlineId(OrderlineIdFilter);
            //set the data source to the list of Orderlines in the collection
            lstboxOrderline.DataSource = AllOrderlines.OrderlineList;
            //set the name of the primary Key
            lstboxOrderline.ValueMember = "OrderlineId";
            //set the data field to display

            lstboxOrderline.DisplayMember = "AllDetails";

            AllOrderlines.ReportByOrderlineId(OrderlineIdFilter);

            return AllOrderlines.Count;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the Display OrderLines function to the record count var
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

            lstboxOrderline.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsOrderline AnOrderline = new clsOrderline();
            AnOrderline.OrderlineId = -1;
            AddOrderlineForm ZX = new AddOrderlineForm();
            this.Hide();
            ZX.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be edited
            Int32 OrderlineId;
            //if a record has been selected from the list
            if (lstboxOrderline.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderlineId = Convert.ToInt32(lstboxOrderline.SelectedValue);
                //store the data in the session object
                UpdateOrderlineForm.tempOrderline = OrderlineId;

                //redirect to the delete page
                UpdateOrderlineForm UpdateOrderline = new UpdateOrderlineForm();
                UpdateOrderline.OrderlineID = Id;
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
            if (lstboxOrderline.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderlineId = Convert.ToInt32(lstboxOrderline.SelectedValue);
                //store the data in the session object
                UpdateOrderlineForm.tempOrderline = OrderlineId;

                //redirect to the delete page
                ConfirmDelete ConfirmDelete = new ConfirmDelete();
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
    }
}
