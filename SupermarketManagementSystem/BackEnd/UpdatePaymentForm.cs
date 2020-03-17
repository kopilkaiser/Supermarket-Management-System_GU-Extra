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
    public partial class UpdatePaymentForm : Form
    {
        private int mPaymentId = 0;
        public int PaymentId
        {
            set
            {
                mPaymentId = value;
            }
        }

        public static int tempInv { get; set; }
       

        public UpdatePaymentForm()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            Update();
        }

        public void Update()
        {

            //create an instance of the Payment Collenction
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //validate the data on the web form
            string Error = AllPayments.ThisPayment.Valid(txtPayeeName.Text, txtCardNumber.Text, txtAmount.Text, Convert.ToString(cmbMethod.SelectedItem), txtPaymentDate.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //find the record to update
                AllPayments.ThisPayment.Find(mPaymentId);
                //get the data entered by the user
                AllPayments.ThisPayment.PayeeName = txtPayeeName.Text;
                AllPayments.ThisPayment.CardNumber = Convert.ToString(txtCardNumber.Text);
                AllPayments.ThisPayment.Method = Convert.ToString(cmbMethod.SelectedItem);
                AllPayments.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
                AllPayments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);

                //add the record
                AllPayments.Update();
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

        private void UpdatePaymentForm_Load(object sender, EventArgs e)
        {
            //display the current data for the record
            DisplayPayment();
            txtPaymentDate.Text = DateTime.Now.Date.ToString("dd/mm/yyyy");
        }

        public void DisplayPayment()
        {
            //create an instance of the Payment collection
            clsPaymentCollection AllPayment = new clsPaymentCollection();
            //find the record to update
            AllPayment.ThisPayment.Find(mPaymentId);
            //display the data for this record
            txtPayeeName.Text = AllPayment.ThisPayment.PayeeName;
            txtCardNumber.Text = AllPayment.ThisPayment.CardNumber.ToString();
            cmbMethod.Text = AllPayment.ThisPayment.Method.ToString();
            txtAmount.Text = AllPayment.ThisPayment.Amount.ToString();
            txtPaymentDate.Text = AllPayment.ThisPayment.PaymentDate.ToString();
        }
    }
}