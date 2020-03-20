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
    public partial class OrderAddForm : Form
    {
        int OrderId;
        clsOrder AnOrder = new clsOrder();
        public OrderAddForm()
        {
            InitializeComponent();
        }

        private void OrderAddForm_Load(object sender, EventArgs e)
        {
            txtPurchasedDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }
        void DisplayOrders()
        {
            //create an instance of the staff collection
            clsOrderCollection AllOrders = new clsOrderCollection();
            //find the record to update
            AllOrders.ThisOrder.Find(OrderId);
            //display the data for this record
            txtEmail.Text = AllOrders.ThisOrder.Email;
            txtPurchasedDate.Text = AllOrders.ThisOrder.PurchasedDate.ToString();
            txtCardNumber.Text = AllOrders.ThisOrder.CardNumber.ToString();

        }

        void Add()
        {
            //create an instance of the Staff Collenction
            clsOrderCollection AllOrders = new clsOrderCollection();
            //validate the data on the web form
            string Error = AllOrders.ThisOrder.Valid(txtEmail.Text, txtCardNumber.Text, txtPurchasedDate.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AllOrders.ThisOrder.Email = txtEmail.Text;
                AllOrders.ThisOrder.CardNumber = Convert.ToString(txtCardNumber.Text);
                AllOrders.ThisOrder.PurchasedDate = Convert.ToDateTime(txtPurchasedDate.Text);

                //add the record
                AllOrders.Add();
                //all done so redirect back to the main page
                OrderManageForm IM = new OrderManageForm();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderManageForm IM = new OrderManageForm();

            this.Hide();
            IM.Show();
            this.Close();

        }
    }
}
