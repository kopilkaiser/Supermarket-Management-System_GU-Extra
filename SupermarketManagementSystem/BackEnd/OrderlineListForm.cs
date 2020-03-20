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
    public partial class OrderlineListForm : Form
    {
        public OrderlineListForm()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mdiBackEndMenuForm mdiMF = new mdiBackEndMenuForm();

            this.Hide();
            mdiMF.Show();
            this.Close();
        }

        private void OrderlineListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMS_SSDBDataSet_OrderLineTable.tblOrderline' table. You can move, or remove it, as needed.
            this.tblOrderlineTableAdapter.Fill(this.sMS_SSDBDataSet_OrderLineTable.tblOrderline);

        }
    }
}
