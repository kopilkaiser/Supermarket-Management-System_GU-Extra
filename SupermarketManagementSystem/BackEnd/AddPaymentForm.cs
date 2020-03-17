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
using System.Data.SqlClient;


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

        void DisplayPayment()
        {
            //create an instance of the Payment collection
            clsPaymentCollection AllPayment = new clsPaymentCollection();
            //find the record to update
            AllPayment.ThisPayment.Find(PaymentId);
            //display the data for this record
            txtPayeeName.Text = AllPayment.ThisPayment.PayeeName;
            txtCardNumber.Text = AllPayment.ThisPayment.CardNumber.ToString();
            cmbMethod.Text = AllPayment.ThisPayment.Method.ToString();
            txtAmount.Text = AllPayment.ThisPayment.Amount.ToString();
            txtPaymentDate.Text = AllPayment.ThisPayment.PaymentDate.ToString();
            


        }

        void Add()
        {
            //create an instance of the Payment Collenction
            clsPaymentCollection AllPayment = new clsPaymentCollection();
            //validate the data on the web form
            string Error = AllPayment.ThisPayment.Valid(txtPayeeName.Text, txtCardNumber.Text, txtAmount.Text, Convert.ToString(cmbMethod.SelectedItem), txtPaymentDate.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AllPayment.ThisPayment.PayeeName = txtPayeeName.Text;
                AllPayment.ThisPayment.CardNumber = Convert.ToString(txtCardNumber.Text);
                AllPayment.ThisPayment.Method = Convert.ToString(cmbMethod.SelectedItem);
                AllPayment.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
                AllPayment.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                
                
                //add the record
                AllPayment.Add();
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


        private void AddPayment_Load(object sender, EventArgs e)
        {
            //PaymentId = Covert.ToInt32(PaymentId);

            //Display Payment();
            txtPaymentDate.Text = DateTime.Today.Date.ToString("dd/MM/YYYY");
            txtPayeeName.Text = "";
            txtCardNumber.Text = "";
            txtAmount.Text = "";
            txtPaymentDate.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PaymentManageForm IM = new PaymentManageForm();

            this.Hide();
            IM.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
        }
    }
}
