using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ClassLibrary;


namespace BackEnd
{
    public partial class AddPaymentForm : Form
    {
        int PaymentId;
        clsPayment AnPayment = new clsPayment();


        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
        }

        void Add()
        {
            //create an instance of the Payment Collenction
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //validate the data on the web form
            string Error = AllPayments.ThisPayment.Valid(txtPayeeName.Text, txtCardNumber.Text, Convert.ToString(cmbMethod.SelectedItem), txtAmount.Text,  txtPaymentDate.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AllPayments.ThisPayment.PayeeName = txtPayeeName.Text;
                AllPayments.ThisPayment.CardNumber = txtCardNumber.Text;
                AllPayments.ThisPayment.Method = Convert.ToString(cmbMethod.SelectedItem);
                AllPayments.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
                AllPayments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                
                
                //add the record
                AllPayments.Add();
                //all done so redirect back to the main page
                PaymentManageForm IM = new PaymentManageForm();
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
            PaymentManageForm IM = new PaymentManageForm();

            this.Hide();
            IM.Show();
            this.Close();
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            //PaymentId = Convert.ToInt32

            //DisplayPayment();
            
            txtPayeeName.Text = "";
            txtCardNumber.Text = "";
            cmbMethod.Text = "";
            txtAmount.Text = "";
            txtPaymentDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        void DisplayInventory()
        {
            //create an instance of the Payment Collection
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //find the record to update
            AllPayments.ThisPayment.Find(PaymentId);
            //display the data for this record
            AllPayments.ThisPayment.PayeeName = txtPayeeName.Text;
            AllPayments.ThisPayment.CardNumber = txtCardNumber.Text;
            AllPayments.ThisPayment.Method = Convert.ToString(cmbMethod.SelectedItem);
            AllPayments.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
            AllPayments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);


        }
    }
}
