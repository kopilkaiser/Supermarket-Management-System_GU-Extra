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
    public partial class OrderDeleteForm : Form
    {
        private int mOrderId = 0;
        public int OrderID
        {
            set
            {
                mOrderId = value;
            }


        }
        public OrderDeleteForm()
        {
            InitializeComponent();
        }

        private void OrderDeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // delete the record
            DeleteOrders();
            //redirect to the main form
            OrderManageForm ManageOrder = new OrderManageForm();
            this.Show();
            ManageOrder.Show();
            this.Close();


        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            OrderManageForm ManageOrder = new OrderManageForm();
            this.Show();
            ManageOrder.Show();
            this.Close();

        }
        void DeleteOrders()
        {
            //function to delete the selected record

            //create an instance of the Order List
            clsOrderCollection AllOrders = new clsOrderCollection();
            //find the record to delete
            AllOrders.ThisOrder.Find(mOrderId);
            //delete the record
            AllOrders.Delete();
        }

       
    }
}
