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
    public partial class OrderlineDeleteForm : Form
    {
        private int mOrderlineId = 0;
        public int OrderlineID
        {
            set
            {
                mOrderlineId = value;
            }


        }
        public OrderlineDeleteForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // delete the record
            DeleteOrderline();
            //redirect to the main form
            OrderlineManageForm ManageOrderline = new OrderlineManageForm();
            this.Show();
            ManageOrderline.Show();
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            OrderlineManageForm ManageOrderline = new OrderlineManageForm();
            this.Show();
            ManageOrderline.Show();
            this.Close();

        }
        void DeleteOrderline()
        {
            //function to delete the selected record

            //create an instance of the Staff List
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //find the record to delete
            AllOrderlines.ThisOrderline.Find(mOrderlineId);
            //delete the record
            AllOrderlines.Delete();
        }

        private void OrderlineDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
