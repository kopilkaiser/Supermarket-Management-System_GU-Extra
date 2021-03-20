using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class mdiBackEndMenuForm : Form
    {
        public mdiBackEndMenuForm()
        {
            InitializeComponent();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            InventoryManageForm IM = new InventoryManageForm();

            this.Hide();
            IM.ShowDialog();
            this.Close();
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffManageForm SM = new StaffManageForm();

            this.Hide();
            SM.ShowDialog();
            this.Close();
        }

        private void btnPaymentManagement_Click(object sender, EventArgs e)
        {
            PaymentManageForm PM = new PaymentManageForm();

            this.Hide();
            PM.ShowDialog();
            this.Close();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OrderManageForm OM = new OrderManageForm();

            this.Hide();
            OM.ShowDialog();
            this.Close();
        }


    }
}
