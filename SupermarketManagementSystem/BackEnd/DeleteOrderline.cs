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

    public partial class DeleteOrderline : Form
    {
        private int mOrderlineId = 0;
        public int OrderlineID
        {
            set
            {
                mOrderlineId = value;
            }


        }
        public DeleteOrderline()
        {
            InitializeComponent();
        }

        private void DeleteOrderline_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // delete the record
            DeleteOrderlines();
            //redirect to the main form
            OrderlineManagement ManageOrderline = new OrderlineManagement();
            this.Show();
            ManageOrderline.Show();
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            OrderlineManagement ManageOrderline = new OrderlineManagement();
            this.Show();
            ManageOrderline.Show();
            this.Close();

        }
        void DeleteOrderlines()
        {
            //function to delete the selected record

            //create an instance of the Staff List
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //find the record to delete
            AllOrderlines.ThisOrderline.Find(mOrderlineId);
            //delete the record
            AllOrderlines.Delete();
        }
    }
}
