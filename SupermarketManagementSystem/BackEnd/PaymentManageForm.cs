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

        private void PaymentManageForm_Load(object sender, EventArgs e)
        {
            //update the list box with Inventory database list
            lblError.Text = DisplayPayments("") + " records in the database";

            // Clear all selections in the ListBox.
            lstPayments.ClearSelected();
        }

        Int32 DisplayPayments(string Method)
        {
            //create an instance of the Payments collection
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            AllPayments.ReportByMethod(Method);
            //set the data source to the list of inventories in the collection
            lstPayments.DataSource = AllPayments.PaymentList;
            //set the name of the primary Key
            lstPayments.ValueMember = "PaymentId";
            //set the data field to display

            lstPayments.DisplayMember = "AllPayments";

            AllPayments.ReportByMethod(Method);

            return AllPayments.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsPayment AnPayment = new clsPayment();
            AnPayment.PaymentId = -1;
            AddPaymentForm ZX = new AddPaymentForm();
            this.Hide();
            ZX.ShowDialog();
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
                UpdatePaymentForm.payInv = PaymentId;

                //redirect to the delete page
                UpdatePaymentForm UpdateInv = new UpdatePaymentForm();
                UpdateInv.PaymentID = PaymentId;
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
            Int32 PaymentId;
            //if a record has been selected from the list
            if (lstPayments.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PaymentId = Convert.ToInt32(lstPayments.SelectedValue);
                //store the data in the session object
                UpdatePaymentForm.payInv = PaymentId;

                //redirect to the delete page
                ConfirmDeletePaymentForm ConfirmDeletePayment = new ConfirmDeletePaymentForm();
                ConfirmDeletePayment.PaymentID = PaymentId;
                this.Hide();
                ConfirmDeletePayment.ShowDialog();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mdiBackEndMenuForm IM = new mdiBackEndMenuForm();

            this.Hide();
            IM.ShowDialog();
            this.Close();
        }
    }
}
