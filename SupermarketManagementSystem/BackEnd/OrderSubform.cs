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
    public partial class OrderSubform : Form
    {
        public OrderSubform()
        {
            InitializeComponent();
        }

        private void btnOrdermanagement_Click(object sender, EventArgs e)
        {
            OrderManageForm OM = new OrderManageForm();

            this.Hide();
            OM.Show();
            this.Close();
        }

        private void btnOrderlinemanagement_Click(object sender, EventArgs e)
        {
            OrderlineListForm OL = new OrderlineListForm();

            this.Hide();
            OL.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mdiBackEndMenuForm mdiMF = new mdiBackEndMenuForm();

            this.Hide();
            mdiMF.Show();
            this.Close();
        }
    }
}
