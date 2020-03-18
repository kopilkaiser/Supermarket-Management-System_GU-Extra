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
    public partial class OrderlineUpdateForm : Form
    {
        private int mOrderlineId = 0;
        public int OrderlineID
        {
            set
            {
                mOrderlineId = value;
            }
        }
        public static int tempOrder { get; set; }
        public OrderlineUpdateForm()
        {
            InitializeComponent();
        }

        private void OrderlineUpdateForm_Load(object sender, EventArgs e)
        {
            DisplayOrderlines();

        }
        public void DisplayOrderlines()
        {
            //create an instance of the staff collection
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //find the record to update
            AllOrderlines.ThisOrderline.Find(mOrderlineId);
            //display the data for this record
            txtOrderId.Text = AllOrderlines.ThisOrderline.OrderId.ToString();
            
            txtQuantity.Text = AllOrderlines.ThisOrderline.Quantity.ToString();
            txtInventoryId.Text = AllOrderlines.ThisOrderline.InventoryId.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Update();

        }
        public void Update()
        {

            //create an instance of the Staff Collenction
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //validate the data on the web form
            string Error = AllOrderlines.ThisOrderline.Valid(txtOrderId.Text, txtQuantity.Text, txtInventoryId.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //find the record to update
                AllOrderlines.ThisOrderline.Find(mOrderlineId);
                //get the data entered by the user
                AllOrderlines.ThisOrderline.OrderId = Convert.ToInt32(txtOrderId.Text);
                
                AllOrderlines.ThisOrderline.Quantity = Convert.ToInt32(txtQuantity.Text);
                AllOrderlines.ThisOrderline.InventoryId = Convert.ToInt32(txtInventoryId.Text);



                //add the record
                AllOrderlines.Update();
                //all done so redirect back to the main page
                OrderlineManageForm IM = new OrderlineManageForm();
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
            OrderlineManageForm IM = new OrderlineManageForm();

            this.Hide();
            IM.Show();
            this.Close();

        }
    }
}
