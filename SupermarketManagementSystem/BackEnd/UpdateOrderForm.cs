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
    public partial class UpdateOrderForm : Form
    {
        private int mOrderId = 0;
        public int OrderID
        {
            set
            {
                mOrderId = value;
            }
        }
        public static int tempOrder { get; set; }
        public UpdateOrderForm()
        {
            InitializeComponent();
        }

        private void UpdateOrderForm_Load(object sender, EventArgs e)
        {
            DisplayOrders();
        }
        public void DisplayOrders()
        {
            //create an instance of the staff collection
            clsOrderCollection AllOrders = new clsOrderCollection();
            //find the record to update
            AllOrders.ThisOrder.Find(mOrderId);
            //display the data for this record
            txtEmail.Text = AllOrders.ThisOrder.Email;
            txtPurchasedDate.Text = AllOrders.ThisOrder.PurchasedDate.ToString();
            txtPaymentId.Text = AllOrders.ThisOrder.PaymentId.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {

            //create an instance of the Staff Collenction
            clsOrderCollection AllOrders = new clsOrderCollection();
            //validate the data on the web form
            string Error = AllOrders.ThisOrder.Valid(txtEmail.Text, txtPurchasedDate.Text, txtPaymentId.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //find the record to update
                AllOrders.ThisOrder.Find(mOrderId);
                //get the data entered by the user
                AllOrders.ThisOrder.Email = txtEmail.Text;
                AllOrders.ThisOrder.PurchasedDate = Convert.ToDateTime(txtPurchasedDate.Text);
                AllOrders.ThisOrder.PaymentId = Convert.ToInt32(txtPaymentId.Text);



                //add the record
                AllOrders.Update();
                //all done so redirect back to the main page
                ManageOrderForm IM = new ManageOrderForm();
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
            ManageOrderForm IM = new ManageOrderForm();

            this.Hide();
            IM.Show();
            this.Close();

        }
    }
}
