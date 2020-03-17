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
    public partial class PaymentManageForm : Form
    {
        Int32 PaymentId;
        clsDataConnection dBConnection;

        public PaymentManageForm()
        {
            InitializeComponent();
        }

        private void PaymentMangeForm_Load(object sender, EventArgs e)
        {
            //update the list box with Payment database list
            lblError.Text = DisplayPayments("") + " records in the database";

            // Clear all selections in the ListBox.
            lstPayments.ClearSelected();
        }

        Int32 DisplayPayments(string MethodFilter)
        {
            //create an instance of the Payments collection
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            AllPayments.ReportByMethod(MethodFilter);
            //set the data source to the list of inventories in the collection
            lstPayments.DataSource = AllPayments.PaymentList;
            //set the name of the primary Key
            lstPayments.ValueMember = "PaymentsId";
            //set the data field to display

            lstPayments.DisplayMember = "AllDetails";

            AllPayments.ReportByMethod(MethodFilter);

            return AllPayments.Count;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayPayments(txtMethod.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayPayments("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Category filter text box
            txtMethod.Text = "";

            lstPayments.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsPayment AnPayment = new clsPayment();
            AnPayment.PaymentId = -1;
            AddPaymentForm ZX = new AddPaymentForm();
            this.Hide();
            ZX.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 PaymentId;
            //if a record has been selected from the list
            if (lstPayments.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PaymentId = Convert.ToInt32(lstPayments.SelectedValue);
                //store the data in the session object
                UpdateInventoryForm.tempInv = PaymentId;

                //redirect to the delete page
                UpdatePaymentForm UpdateInv = new UpdatePaymentForm();
                UpdateInv.PaymentId = PaymentId;
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
            Int32 PaymentId;
            //if a record has been selected from the list
            if (lstPayments.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PaymentId = Convert.ToInt32(lstPayments.SelectedValue);
                //store the data in the session object
                UpdatePaymentForm.tempInv = PaymentId;

                //redirect to the delete page
                DeletePaymentConfirmForm PaymentConfirmDelete = new DeletePaymentConfirmForm();
                PaymentConfirmDelete.PaymentId = PaymentId;
                this.Hide();
                PaymentConfirmDelete.Show();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }
    }
}
